namespace einsatzLeitSoftware
{
    partial class beginDialog
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
            this.mLabelTitleEinsatzOrt = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTitleEinsatzstart = new MaterialSkin.Controls.MaterialLabel();
            this.mTextFieldEinsatzOrt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mButtonEinsatzStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.mLabelStartTime = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelProtokollLeader = new MaterialSkin.Controls.MaterialLabel();
            this.mTextFieldProtokollLeader = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mLabelEinsatzLeader = new MaterialSkin.Controls.MaterialLabel();
            this.mTextFieldEinsatzLeader = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // mLabelTitleEinsatzOrt
            // 
            this.mLabelTitleEinsatzOrt.AutoSize = true;
            this.mLabelTitleEinsatzOrt.BackColor = System.Drawing.Color.White;
            this.mLabelTitleEinsatzOrt.Depth = 0;
            this.mLabelTitleEinsatzOrt.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTitleEinsatzOrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitleEinsatzOrt.Location = new System.Drawing.Point(17, 91);
            this.mLabelTitleEinsatzOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTitleEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitleEinsatzOrt.Name = "mLabelTitleEinsatzOrt";
            this.mLabelTitleEinsatzOrt.Size = new System.Drawing.Size(94, 24);
            this.mLabelTitleEinsatzOrt.TabIndex = 0;
            this.mLabelTitleEinsatzOrt.Text = "Einsatzort";
            // 
            // mLabelTitleEinsatzstart
            // 
            this.mLabelTitleEinsatzstart.AutoSize = true;
            this.mLabelTitleEinsatzstart.BackColor = System.Drawing.Color.White;
            this.mLabelTitleEinsatzstart.Depth = 0;
            this.mLabelTitleEinsatzstart.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTitleEinsatzstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitleEinsatzstart.Location = new System.Drawing.Point(17, 127);
            this.mLabelTitleEinsatzstart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTitleEinsatzstart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitleEinsatzstart.Name = "mLabelTitleEinsatzstart";
            this.mLabelTitleEinsatzstart.Size = new System.Drawing.Size(109, 24);
            this.mLabelTitleEinsatzstart.TabIndex = 1;
            this.mLabelTitleEinsatzstart.Text = "Einsatzstart";
            // 
            // mTextFieldEinsatzOrt
            // 
            this.mTextFieldEinsatzOrt.Depth = 0;
            this.mTextFieldEinsatzOrt.Hint = "";
            this.mTextFieldEinsatzOrt.Location = new System.Drawing.Point(191, 91);
            this.mTextFieldEinsatzOrt.Margin = new System.Windows.Forms.Padding(4);
            this.mTextFieldEinsatzOrt.MaxLength = 32767;
            this.mTextFieldEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldEinsatzOrt.Name = "mTextFieldEinsatzOrt";
            this.mTextFieldEinsatzOrt.PasswordChar = '\0';
            this.mTextFieldEinsatzOrt.SelectedText = "";
            this.mTextFieldEinsatzOrt.SelectionLength = 0;
            this.mTextFieldEinsatzOrt.SelectionStart = 0;
            this.mTextFieldEinsatzOrt.Size = new System.Drawing.Size(203, 28);
            this.mTextFieldEinsatzOrt.TabIndex = 2;
            this.mTextFieldEinsatzOrt.TabStop = false;
            this.mTextFieldEinsatzOrt.UseSystemPasswordChar = false;
            this.mTextFieldEinsatzOrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            this.mTextFieldEinsatzOrt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTextField_KeyUp);
            // 
            // mButtonEinsatzStart
            // 
            this.mButtonEinsatzStart.AutoSize = true;
            this.mButtonEinsatzStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mButtonEinsatzStart.Depth = 0;
            this.mButtonEinsatzStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mButtonEinsatzStart.Icon = null;
            this.mButtonEinsatzStart.Location = new System.Drawing.Point(292, 306);
            this.mButtonEinsatzStart.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.mButtonEinsatzStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mButtonEinsatzStart.Name = "mButtonEinsatzStart";
            this.mButtonEinsatzStart.Primary = false;
            this.mButtonEinsatzStart.Size = new System.Drawing.Size(171, 36);
            this.mButtonEinsatzStart.TabIndex = 4;
            this.mButtonEinsatzStart.Text = "Einsatz starten";
            this.mButtonEinsatzStart.UseVisualStyleBackColor = true;
            // 
            // mLabelStartTime
            // 
            this.mLabelStartTime.Depth = 0;
            this.mLabelStartTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelStartTime.Location = new System.Drawing.Point(191, 128);
            this.mLabelStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelStartTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelStartTime.Name = "mLabelStartTime";
            this.mLabelStartTime.Size = new System.Drawing.Size(203, 25);
            this.mLabelStartTime.TabIndex = 5;
            this.mLabelStartTime.Text = "materialLabel1";
            // 
            // mLabelProtokollLeader
            // 
            this.mLabelProtokollLeader.AutoSize = true;
            this.mLabelProtokollLeader.BackColor = System.Drawing.Color.White;
            this.mLabelProtokollLeader.Depth = 0;
            this.mLabelProtokollLeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelProtokollLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelProtokollLeader.Location = new System.Drawing.Point(17, 161);
            this.mLabelProtokollLeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelProtokollLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelProtokollLeader.Name = "mLabelProtokollLeader";
            this.mLabelProtokollLeader.Size = new System.Drawing.Size(136, 24);
            this.mLabelProtokollLeader.TabIndex = 6;
            this.mLabelProtokollLeader.Text = "Protokollführer";
            // 
            // mTextFieldProtokollLeader
            // 
            this.mTextFieldProtokollLeader.Depth = 0;
            this.mTextFieldProtokollLeader.Hint = "";
            this.mTextFieldProtokollLeader.Location = new System.Drawing.Point(191, 161);
            this.mTextFieldProtokollLeader.Margin = new System.Windows.Forms.Padding(4);
            this.mTextFieldProtokollLeader.MaxLength = 32767;
            this.mTextFieldProtokollLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldProtokollLeader.Name = "mTextFieldProtokollLeader";
            this.mTextFieldProtokollLeader.PasswordChar = '\0';
            this.mTextFieldProtokollLeader.SelectedText = "";
            this.mTextFieldProtokollLeader.SelectionLength = 0;
            this.mTextFieldProtokollLeader.SelectionStart = 0;
            this.mTextFieldProtokollLeader.Size = new System.Drawing.Size(203, 28);
            this.mTextFieldProtokollLeader.TabIndex = 7;
            this.mTextFieldProtokollLeader.TabStop = false;
            this.mTextFieldProtokollLeader.UseSystemPasswordChar = false;
            this.mTextFieldProtokollLeader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            this.mTextFieldProtokollLeader.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTextField_KeyUp);
            // 
            // mLabelEinsatzLeader
            // 
            this.mLabelEinsatzLeader.AutoSize = true;
            this.mLabelEinsatzLeader.BackColor = System.Drawing.Color.White;
            this.mLabelEinsatzLeader.Depth = 0;
            this.mLabelEinsatzLeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelEinsatzLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelEinsatzLeader.Location = new System.Drawing.Point(16, 203);
            this.mLabelEinsatzLeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelEinsatzLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelEinsatzLeader.Name = "mLabelEinsatzLeader";
            this.mLabelEinsatzLeader.Size = new System.Drawing.Size(113, 24);
            this.mLabelEinsatzLeader.TabIndex = 8;
            this.mLabelEinsatzLeader.Text = "Einsatzleiter";
            // 
            // mTextFieldEinsatzLeader
            // 
            this.mTextFieldEinsatzLeader.Depth = 0;
            this.mTextFieldEinsatzLeader.Hint = "";
            this.mTextFieldEinsatzLeader.Location = new System.Drawing.Point(191, 198);
            this.mTextFieldEinsatzLeader.Margin = new System.Windows.Forms.Padding(4);
            this.mTextFieldEinsatzLeader.MaxLength = 32767;
            this.mTextFieldEinsatzLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldEinsatzLeader.Name = "mTextFieldEinsatzLeader";
            this.mTextFieldEinsatzLeader.PasswordChar = '\0';
            this.mTextFieldEinsatzLeader.SelectedText = "";
            this.mTextFieldEinsatzLeader.SelectionLength = 0;
            this.mTextFieldEinsatzLeader.SelectionStart = 0;
            this.mTextFieldEinsatzLeader.Size = new System.Drawing.Size(203, 28);
            this.mTextFieldEinsatzLeader.TabIndex = 9;
            this.mTextFieldEinsatzLeader.TabStop = false;
            this.mTextFieldEinsatzLeader.UseSystemPasswordChar = false;
            this.mTextFieldEinsatzLeader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            this.mTextFieldEinsatzLeader.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTextField_KeyUp);
            // 
            // beginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 369);
            this.Controls.Add(this.mTextFieldEinsatzLeader);
            this.Controls.Add(this.mLabelEinsatzLeader);
            this.Controls.Add(this.mTextFieldProtokollLeader);
            this.Controls.Add(this.mLabelProtokollLeader);
            this.Controls.Add(this.mLabelStartTime);
            this.Controls.Add(this.mButtonEinsatzStart);
            this.Controls.Add(this.mTextFieldEinsatzOrt);
            this.Controls.Add(this.mLabelTitleEinsatzstart);
            this.Controls.Add(this.mLabelTitleEinsatzOrt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "beginDialog";
            this.Text = "Bitte gebe die Grunddaten ein...";
            this.Load += new System.EventHandler(this.beginDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mLabelTitleEinsatzOrt;
        private MaterialSkin.Controls.MaterialLabel mLabelTitleEinsatzstart;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldEinsatzOrt;
        private MaterialSkin.Controls.MaterialFlatButton mButtonEinsatzStart;
        private MaterialSkin.Controls.MaterialLabel mLabelStartTime;
        private MaterialSkin.Controls.MaterialLabel mLabelProtokollLeader;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldProtokollLeader;
        private MaterialSkin.Controls.MaterialLabel mLabelEinsatzLeader;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldEinsatzLeader;
    }
}