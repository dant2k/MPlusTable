namespace MPlusTable
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRound = new System.Windows.Forms.CheckBox();
            this.chkAst1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAst1 = new System.Windows.Forms.TextBox();
            this.txtAst2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAst2 = new System.Windows.Forms.CheckBox();
            this.txtAst3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAst3 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInput.Location = new System.Drawing.Point(12, 81);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(565, 690);
            this.txtInput.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(711, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 63);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Save";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 63);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(710, 79);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(122, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Move Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(710, 110);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(122, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Move Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lstNames
            // 
            this.lstNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(584, 81);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 693);
            this.lstNames.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(456, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(121, 63);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Convert";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "Paste the table from MPlus, set options, and click \"Convert\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 59);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rearrange and Save";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Options\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkRound
            // 
            this.chkRound.AutoSize = true;
            this.chkRound.Checked = true;
            this.chkRound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRound.Location = new System.Drawing.Point(714, 629);
            this.chkRound.Name = "chkRound";
            this.chkRound.Size = new System.Drawing.Size(113, 17);
            this.chkRound.TabIndex = 11;
            this.chkRound.Text = "Round to 2 places";
            this.chkRound.UseVisualStyleBackColor = true;
            // 
            // chkAst1
            // 
            this.chkAst1.AutoSize = true;
            this.chkAst1.Location = new System.Drawing.Point(714, 652);
            this.chkAst1.Name = "chkAst1";
            this.chkAst1.Size = new System.Drawing.Size(52, 17);
            this.chkAst1.TabIndex = 12;
            this.chkAst1.Text = "Add *";
            this.chkAst1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "@";
            // 
            // txtAst1
            // 
            this.txtAst1.Location = new System.Drawing.Point(762, 669);
            this.txtAst1.Name = "txtAst1";
            this.txtAst1.Size = new System.Drawing.Size(42, 20);
            this.txtAst1.TabIndex = 14;
            // 
            // txtAst2
            // 
            this.txtAst2.Location = new System.Drawing.Point(758, 712);
            this.txtAst2.Name = "txtAst2";
            this.txtAst2.Size = new System.Drawing.Size(42, 20);
            this.txtAst2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 715);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "@";
            // 
            // chkAst2
            // 
            this.chkAst2.AutoSize = true;
            this.chkAst2.Location = new System.Drawing.Point(710, 695);
            this.chkAst2.Name = "chkAst2";
            this.chkAst2.Size = new System.Drawing.Size(56, 17);
            this.chkAst2.TabIndex = 15;
            this.chkAst2.Text = "Add **";
            this.chkAst2.UseVisualStyleBackColor = true;
            // 
            // txtAst3
            // 
            this.txtAst3.Location = new System.Drawing.Point(758, 755);
            this.txtAst3.Name = "txtAst3";
            this.txtAst3.Size = new System.Drawing.Size(42, 20);
            this.txtAst3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(734, 758);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "@";
            // 
            // chkAst3
            // 
            this.chkAst3.AutoSize = true;
            this.chkAst3.Location = new System.Drawing.Point(710, 738);
            this.chkAst3.Name = "chkAst3";
            this.chkAst3.Size = new System.Drawing.Size(60, 17);
            this.chkAst3.TabIndex = 18;
            this.chkAst3.Text = "Add ***";
            this.chkAst3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(711, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "(Set Before \"Convert\")";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 783);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAst3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAst3);
            this.Controls.Add(this.txtAst2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkAst2);
            this.Controls.Add(this.txtAst1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkAst1);
            this.Controls.Add(this.chkRound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "MPlus Table Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRound;
        private System.Windows.Forms.CheckBox chkAst1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAst1;
        private System.Windows.Forms.TextBox txtAst2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAst2;
        private System.Windows.Forms.TextBox txtAst3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAst3;
        private System.Windows.Forms.Label label7;
    }
}

