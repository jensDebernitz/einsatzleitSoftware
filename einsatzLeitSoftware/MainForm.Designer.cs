namespace einsatzLeitSoftware
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ffwDBDataSet = new einsatzLeitSoftware.ffwDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new einsatzLeitSoftware.ffwDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new einsatzLeitSoftware.ffwDBDataSetTableAdapters.TableAdapterManager();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mLabelClock = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelEinsatzInformations = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTitleEinsatzOrt = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTitelEinsatzStart = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueEinsatzOrt = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueEinsatzStart = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ffwDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ffwDBDataSet
            // 
            this.ffwDBDataSet.DataSetName = "ffwDBDataSet";
            this.ffwDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.ffwDBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = einsatzLeitSoftware.ffwDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 270);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(980, 308);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 221);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(972, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // mLabelClock
            // 
            this.mLabelClock.Depth = 0;
            this.mLabelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mLabelClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelClock.Location = new System.Drawing.Point(838, 33);
            this.mLabelClock.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelClock.Name = "mLabelClock";
            this.mLabelClock.Size = new System.Drawing.Size(150, 26);
            this.mLabelClock.TabIndex = 2;
            this.mLabelClock.Text = "00:00";
            // 
            // mLabelEinsatzInformations
            // 
            this.mLabelEinsatzInformations.AutoSize = true;
            this.mLabelEinsatzInformations.Depth = 0;
            this.mLabelEinsatzInformations.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelEinsatzInformations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelEinsatzInformations.Location = new System.Drawing.Point(12, 71);
            this.mLabelEinsatzInformations.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelEinsatzInformations.Name = "mLabelEinsatzInformations";
            this.mLabelEinsatzInformations.Size = new System.Drawing.Size(140, 19);
            this.mLabelEinsatzInformations.TabIndex = 3;
            this.mLabelEinsatzInformations.Text = "Einsatzinformation:";
            // 
            // mLabelTitleEinsatzOrt
            // 
            this.mLabelTitleEinsatzOrt.AutoSize = true;
            this.mLabelTitleEinsatzOrt.Depth = 0;
            this.mLabelTitleEinsatzOrt.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTitleEinsatzOrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitleEinsatzOrt.Location = new System.Drawing.Point(16, 108);
            this.mLabelTitleEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitleEinsatzOrt.Name = "mLabelTitleEinsatzOrt";
            this.mLabelTitleEinsatzOrt.Size = new System.Drawing.Size(85, 19);
            this.mLabelTitleEinsatzOrt.TabIndex = 4;
            this.mLabelTitleEinsatzOrt.Text = "Einsatzort: ";
            // 
            // mLabelTitelEinsatzStart
            // 
            this.mLabelTitelEinsatzStart.AutoSize = true;
            this.mLabelTitelEinsatzStart.Depth = 0;
            this.mLabelTitelEinsatzStart.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTitelEinsatzStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitelEinsatzStart.Location = new System.Drawing.Point(15, 131);
            this.mLabelTitelEinsatzStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitelEinsatzStart.Name = "mLabelTitelEinsatzStart";
            this.mLabelTitelEinsatzStart.Size = new System.Drawing.Size(93, 19);
            this.mLabelTitelEinsatzStart.TabIndex = 5;
            this.mLabelTitelEinsatzStart.Text = "Einsatzstart:";
            // 
            // mLabelValueEinsatzOrt
            // 
            this.mLabelValueEinsatzOrt.AutoSize = true;
            this.mLabelValueEinsatzOrt.Depth = 0;
            this.mLabelValueEinsatzOrt.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueEinsatzOrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueEinsatzOrt.Location = new System.Drawing.Point(117, 108);
            this.mLabelValueEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzOrt.Name = "mLabelValueEinsatzOrt";
            this.mLabelValueEinsatzOrt.Size = new System.Drawing.Size(61, 19);
            this.mLabelValueEinsatzOrt.TabIndex = 6;
            this.mLabelValueEinsatzOrt.Text = "Oberfell";
            // 
            // mLabelValueEinsatzStart
            // 
            this.mLabelValueEinsatzStart.AutoSize = true;
            this.mLabelValueEinsatzStart.Depth = 0;
            this.mLabelValueEinsatzStart.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueEinsatzStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueEinsatzStart.Location = new System.Drawing.Point(117, 131);
            this.mLabelValueEinsatzStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzStart.Name = "mLabelValueEinsatzStart";
            this.mLabelValueEinsatzStart.Size = new System.Drawing.Size(121, 19);
            this.mLabelValueEinsatzStart.TabIndex = 7;
            this.mLabelValueEinsatzStart.Text = "00.00.2017 00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 638);
            this.Controls.Add(this.mLabelValueEinsatzStart);
            this.Controls.Add(this.mLabelValueEinsatzOrt);
            this.Controls.Add(this.mLabelTitelEinsatzStart);
            this.Controls.Add(this.mLabelTitleEinsatzOrt);
            this.Controls.Add(this.mLabelEinsatzInformations);
            this.Controls.Add(this.mLabelClock);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = "Einsatzleitsoftware FFW Oberfell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ffwDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ffwDBDataSet ffwDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ffwDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ffwDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel mLabelClock;
        private MaterialSkin.Controls.MaterialLabel mLabelEinsatzInformations;
        private MaterialSkin.Controls.MaterialLabel mLabelTitleEinsatzOrt;
        private MaterialSkin.Controls.MaterialLabel mLabelTitelEinsatzStart;
        private MaterialSkin.Controls.MaterialLabel mLabelValueEinsatzOrt;
        private MaterialSkin.Controls.MaterialLabel mLabelValueEinsatzStart;
    }
}

