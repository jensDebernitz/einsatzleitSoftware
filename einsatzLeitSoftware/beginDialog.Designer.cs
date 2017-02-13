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
            this.SuspendLayout();
            // 
            // mLabelTitleEinsatzOrt
            // 
            this.mLabelTitleEinsatzOrt.AutoSize = true;
            this.mLabelTitleEinsatzOrt.Depth = 0;
            this.mLabelTitleEinsatzOrt.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTitleEinsatzOrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitleEinsatzOrt.Location = new System.Drawing.Point(13, 74);
            this.mLabelTitleEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitleEinsatzOrt.Name = "mLabelTitleEinsatzOrt";
            this.mLabelTitleEinsatzOrt.Size = new System.Drawing.Size(77, 19);
            this.mLabelTitleEinsatzOrt.TabIndex = 0;
            this.mLabelTitleEinsatzOrt.Text = "Einsatzort";
            // 
            // mLabelTitleEinsatzstart
            // 
            this.mLabelTitleEinsatzstart.AutoSize = true;
            this.mLabelTitleEinsatzstart.Depth = 0;
            this.mLabelTitleEinsatzstart.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTitleEinsatzstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitleEinsatzstart.Location = new System.Drawing.Point(13, 103);
            this.mLabelTitleEinsatzstart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitleEinsatzstart.Name = "mLabelTitleEinsatzstart";
            this.mLabelTitleEinsatzstart.Size = new System.Drawing.Size(89, 19);
            this.mLabelTitleEinsatzstart.TabIndex = 1;
            this.mLabelTitleEinsatzstart.Text = "Einsatzstart";
            // 
            // mTextFieldEinsatzOrt
            // 
            this.mTextFieldEinsatzOrt.Depth = 0;
            this.mTextFieldEinsatzOrt.Hint = "";
            this.mTextFieldEinsatzOrt.Location = new System.Drawing.Point(120, 74);
            this.mTextFieldEinsatzOrt.MaxLength = 32767;
            this.mTextFieldEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldEinsatzOrt.Name = "mTextFieldEinsatzOrt";
            this.mTextFieldEinsatzOrt.PasswordChar = '\0';
            this.mTextFieldEinsatzOrt.SelectedText = "";
            this.mTextFieldEinsatzOrt.SelectionLength = 0;
            this.mTextFieldEinsatzOrt.SelectionStart = 0;
            this.mTextFieldEinsatzOrt.Size = new System.Drawing.Size(152, 23);
            this.mTextFieldEinsatzOrt.TabIndex = 2;
            this.mTextFieldEinsatzOrt.TabStop = false;
            this.mTextFieldEinsatzOrt.UseSystemPasswordChar = false;
            // 
            // mButtonEinsatzStart
            // 
            this.mButtonEinsatzStart.AutoSize = true;
            this.mButtonEinsatzStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mButtonEinsatzStart.Depth = 0;
            this.mButtonEinsatzStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mButtonEinsatzStart.Icon = null;
            this.mButtonEinsatzStart.Location = new System.Drawing.Point(219, 249);
            this.mButtonEinsatzStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mButtonEinsatzStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mButtonEinsatzStart.Name = "mButtonEinsatzStart";
            this.mButtonEinsatzStart.Primary = false;
            this.mButtonEinsatzStart.Size = new System.Drawing.Size(140, 36);
            this.mButtonEinsatzStart.TabIndex = 4;
            this.mButtonEinsatzStart.Text = "Einsatz starten";
            this.mButtonEinsatzStart.UseVisualStyleBackColor = true;
            // 
            // mLabelStartTime
            // 
            this.mLabelStartTime.Depth = 0;
            this.mLabelStartTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelStartTime.Location = new System.Drawing.Point(120, 104);
            this.mLabelStartTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelStartTime.Name = "mLabelStartTime";
            this.mLabelStartTime.Size = new System.Drawing.Size(152, 20);
            this.mLabelStartTime.TabIndex = 5;
            this.mLabelStartTime.Text = "materialLabel1";
            // 
            // beginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 300);
            this.Controls.Add(this.mLabelStartTime);
            this.Controls.Add(this.mButtonEinsatzStart);
            this.Controls.Add(this.mTextFieldEinsatzOrt);
            this.Controls.Add(this.mLabelTitleEinsatzstart);
            this.Controls.Add(this.mLabelTitleEinsatzOrt);
            this.Name = "beginDialog";
            this.Text = "beginDialog";
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
    }
}