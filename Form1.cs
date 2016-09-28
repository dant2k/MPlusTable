using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPlusTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            Variables.Clear();
        }

        class Entry
        {
            public string Name;
            public string[] Values;
        };

        List<Entry> Variables = new List<Entry>();

        private int ParseTableChunk(string[] Lines, int HeaderIndex)
        {
            // Parse the header line for the active columns.
            string[] Headers = Lines[HeaderIndex].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Start parsing the entries.
            int Start = HeaderIndex + 2;

            for (int i = Start; i < Lines.Length; i++)
            {
                // To see if we bailed 
                if (Lines[i].Length == 0)
                    return i;

                string[] Entries = Lines[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (Entries.Length == 0)
                    return i;

                // See if the named entry already exists.
                int Copied = 0;
                for (int e = 0; e < Variables.Count; e++)
                {
                    if (Variables[e].Name == Entries[0])
                    {
                        // Concatenate these values on to the end.
                        string[] Con = new string[Variables[e].Values.Length + Entries.Length - 1];
                        Variables[e].Values.CopyTo(Con, 0);
                        System.Array.Copy(Entries, 1, Con, Variables[e].Values.Length, Entries.Length - 1);
                        Variables[e].Values = Con;
                        Copied = 1;
                        break;
                    }
                }

                if (Copied == 1)
                    continue;

                Entry N = new Entry();
                N.Name = Entries[0];
                N.Values = new string[Entries.Length - 1];
                System.Array.Copy(Entries, 1, N.Values, 0, Entries.Length - 1);

                Variables.Add(N);
            }

            return -1; // Finished the table.
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Variables.Clear();

            string Source = txtInput.Text;

            Source = Source.Replace('\r', ' ');

            string[] Lines = Source.Split(new char[] {'\n' });

            int CurrentOffset = 0;
            for (; ; )
            {
                // Find the header by looking for the "______"
                int FirstDivider = -1;
                for (int i = CurrentOffset; i < Lines.Length; i++)
                {
                    if (Lines[i].IndexOf("______") != -1)
                    {
                        FirstDivider = i;
                        break;
                    }
                }

                if (FirstDivider == -1 && CurrentOffset == 0)
                {
                    MessageBox.Show("Couldn't find a table in the provided text.");
                    return;
                }

                if (FirstDivider == -1)
                {
                    // No more table chunks exist.
                    break;
                }

                int HeaderLocation = FirstDivider - 1;

                CurrentOffset = ParseTableChunk(Lines, HeaderLocation);
                if (CurrentOffset == -1)
                    break;
            }

            // Clear the name list and repopulate.
            lstNames.Items.Clear();

            foreach (Entry E in Variables)
            {
                lstNames.Items.Add(E.Name);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            StringBuilder S = new StringBuilder();
            S.Append("NAME");

            foreach (string s in lstNames.Items)
            {
                S.Append(",");
                S.Append(s);
            }

            S.Append("\r\n");

            int CurrentIndex = 0;
            foreach (string s in lstNames.Items)
            {
                S.Append(s);

                for (int c = 0; c < CurrentIndex; c++)
                {
                    S.Append(",");
                }

                int LeftIndex = 0;
                for (LeftIndex = 0; LeftIndex < Variables.Count; LeftIndex++)
                {
                    if (Variables[LeftIndex].Name == s)
                        break;
                }

                for (int c = CurrentIndex; c < Variables.Count; c++)
                {
                    S.Append(",");

                    // Find the correct value for the position we're at
                    // [s, lstNames.Items[c]]
                    int TopIndex = 0;
                    for (TopIndex = 0; TopIndex < Variables.Count; TopIndex++)
                    {
                        if (Variables[TopIndex].Name == (string)lstNames.Items[c])
                            break;
                    }

                    string Value = null;

                    if (TopIndex < LeftIndex)
                    {
                        Value = Variables[LeftIndex].Values[TopIndex];
                    }
                    else
                    {
                        Value = Variables[TopIndex].Values[LeftIndex];
                    }

                    double v = Double.Parse(Value);
                    if (chkRound.Checked)
                    {
                        // Parse the value and round.
                        v = Math.Round(v, 2);
                        Value = v.ToString();
                        if (Value.IndexOf('.') == Value.Length - 2)
                            Value = Value + "0"; // make sure decimals have a trailing 0.
                        else if (Value.IndexOf('.') == -1)
                            Value = Value + ".00";
                    }

                    // Don't asterisk anything over 1
                    if (v < 1)
                    {
                        double bound = 0;
                        int astcount = 0;
                        if (chkAst1.Checked && Double.TryParse(txtAst1.Text, out bound))
                        {
                            if (Math.Abs(v) >= bound)
                            {
                                for (; astcount < 1; astcount++)
                                    Value += "*";
                            }
                        }

                        if (chkAst2.Checked && Double.TryParse(txtAst2.Text, out bound))
                        {
                            if (Math.Abs(v) >= bound)
                            {
                                for (; astcount < 2; astcount++)
                                    Value += "*";
                            }
                        }

                        if (chkAst3.Checked && Double.TryParse(txtAst3.Text, out bound))
                        {
                            if (Math.Abs(v) >= bound)
                            {
                                for (; astcount < 3; astcount++)
                                    Value += "*";
                            }
                        }
                    }

                    S.Append(Value);
                }
                S.Append("\r\n");

                CurrentIndex++;
            }

            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Comma Separated Values|*.csv";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                for (; ; )
                {
                    try
                    {
                        File.WriteAllText(SFD.FileName, S.ToString());
                        break;
                    }
                    catch (Exception)
                    {
                        if (MessageBox.Show("Failed to write file - did you leave it open in excel?", "Oops", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int Index = lstNames.SelectedIndex;
            if (Index <= 0)
                return;

            // Swap the Index - 1 and Index items.
            lstNames.SuspendLayout();
            object s = lstNames.Items[Index - 1];
            lstNames.Items[Index - 1] = lstNames.Items[Index];
            lstNames.Items[Index] = s;
            lstNames.SelectedIndex = Index - 1;
            lstNames.ResumeLayout();
            lstNames.Refresh();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int Index = lstNames.SelectedIndex;
            if (Index == -1)
                return;
            if (Index == lstNames.Items.Count - 1)
                return;

            // Swap the Index + 1 and Index items.
            lstNames.SuspendLayout();
            object s = lstNames.Items[Index + 1];
            lstNames.Items[Index + 1] = lstNames.Items[Index];
            lstNames.Items[Index] = s;
            lstNames.SelectedIndex = Index + 1;
            lstNames.ResumeLayout();
            lstNames.Refresh();
        }
    }
}
