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
            this.mTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.mTabPageFunkProtocol = new System.Windows.Forms.TabPage();
            this.mTabPageAtemSchutzUeberwachung = new System.Windows.Forms.TabPage();
            this.mTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mLabelClock = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelEinsatzInformations = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTitleEinsatzOrt = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTitelEinsatzStart = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueEinsatzOrt = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueEinsatzStart = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueProtocolLeader = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelProtocolLeader = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueEinsatzLeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelEinsatzdauer = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ffwDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.mTabControl1.SuspendLayout();
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
            // mTabControl1
            // 
            this.mTabControl1.Controls.Add(this.mTabPageFunkProtocol);
            this.mTabControl1.Controls.Add(this.mTabPageAtemSchutzUeberwachung);
            this.mTabControl1.Depth = 0;
            this.mTabControl1.Location = new System.Drawing.Point(12, 270);
            this.mTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabControl1.Name = "mTabControl1";
            this.mTabControl1.SelectedIndex = 0;
            this.mTabControl1.Size = new System.Drawing.Size(980, 308);
            this.mTabControl1.TabIndex = 0;
            // 
            // mTabPageFunkProtocol
            // 
            this.mTabPageFunkProtocol.Location = new System.Drawing.Point(4, 22);
            this.mTabPageFunkProtocol.Name = "mTabPageFunkProtocol";
            this.mTabPageFunkProtocol.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageFunkProtocol.Size = new System.Drawing.Size(972, 282);
            this.mTabPageFunkProtocol.TabIndex = 0;
            this.mTabPageFunkProtocol.Text = "Funkprotokoll";
            this.mTabPageFunkProtocol.UseVisualStyleBackColor = true;
            // 
            // mTabPageAtemSchutzUeberwachung
            // 
            this.mTabPageAtemSchutzUeberwachung.Location = new System.Drawing.Point(4, 22);
            this.mTabPageAtemSchutzUeberwachung.Name = "mTabPageAtemSchutzUeberwachung";
            this.mTabPageAtemSchutzUeberwachung.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageAtemSchutzUeberwachung.Size = new System.Drawing.Size(972, 282);
            this.mTabPageAtemSchutzUeberwachung.TabIndex = 1;
            this.mTabPageAtemSchutzUeberwachung.Text = "Atemschutzüberwachung";
            this.mTabPageAtemSchutzUeberwachung.UseVisualStyleBackColor = true;
            // 
            // mTabSelector
            // 
            this.mTabSelector.BaseTabControl = this.mTabControl1;
            this.mTabSelector.Depth = 0;
            this.mTabSelector.Location = new System.Drawing.Point(12, 221);
            this.mTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabSelector.Name = "mTabSelector";
            this.mTabSelector.Size = new System.Drawing.Size(972, 23);
            this.mTabSelector.TabIndex = 1;
            this.mTabSelector.Text = "materialTabSelector1";
            // 
            // mLabelClock
            // 
            this.mLabelClock.Depth = 0;
            this.mLabelClock.Font = new System.Drawing.Font("Roboto", 11F);
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
            this.mLabelValueEinsatzOrt.Location = new System.Drawing.Point(145, 108);
            this.mLabelValueEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzOrt.Name = "mLabelValueEinsatzOrt";
            this.mLabelValueEinsatzOrt.Size = new System.Drawing.Size(30, 19);
            this.mLabelValueEinsatzOrt.TabIndex = 6;
            this.mLabelValueEinsatzOrt.Text = "???";
            // 
            // mLabelValueEinsatzStart
            // 
            this.mLabelValueEinsatzStart.AutoSize = true;
            this.mLabelValueEinsatzStart.Depth = 0;
            this.mLabelValueEinsatzStart.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueEinsatzStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueEinsatzStart.Location = new System.Drawing.Point(145, 131);
            this.mLabelValueEinsatzStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzStart.Name = "mLabelValueEinsatzStart";
            this.mLabelValueEinsatzStart.Size = new System.Drawing.Size(121, 19);
            this.mLabelValueEinsatzStart.TabIndex = 7;
            this.mLabelValueEinsatzStart.Text = "00.00.2017 00:00";
            // 
            // mLabelValueProtocolLeader
            // 
            this.mLabelValueProtocolLeader.AutoSize = true;
            this.mLabelValueProtocolLeader.Depth = 0;
            this.mLabelValueProtocolLeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueProtocolLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueProtocolLeader.Location = new System.Drawing.Point(145, 155);
            this.mLabelValueProtocolLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueProtocolLeader.Name = "mLabelValueProtocolLeader";
            this.mLabelValueProtocolLeader.Size = new System.Drawing.Size(30, 19);
            this.mLabelValueProtocolLeader.TabIndex = 9;
            this.mLabelValueProtocolLeader.Text = "???";
            // 
            // mLabelProtocolLeader
            // 
            this.mLabelProtocolLeader.AutoSize = true;
            this.mLabelProtocolLeader.Depth = 0;
            this.mLabelProtocolLeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelProtocolLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelProtocolLeader.Location = new System.Drawing.Point(16, 155);
            this.mLabelProtocolLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelProtocolLeader.Name = "mLabelProtocolLeader";
            this.mLabelProtocolLeader.Size = new System.Drawing.Size(118, 19);
            this.mLabelProtocolLeader.TabIndex = 8;
            this.mLabelProtocolLeader.Text = "Protokollführer: ";
            // 
            // mLabelValueEinsatzLeader
            // 
            this.mLabelValueEinsatzLeader.AutoSize = true;
            this.mLabelValueEinsatzLeader.Depth = 0;
            this.mLabelValueEinsatzLeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueEinsatzLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueEinsatzLeader.Location = new System.Drawing.Point(145, 182);
            this.mLabelValueEinsatzLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzLeader.Name = "mLabelValueEinsatzLeader";
            this.mLabelValueEinsatzLeader.Size = new System.Drawing.Size(30, 19);
            this.mLabelValueEinsatzLeader.TabIndex = 11;
            this.mLabelValueEinsatzLeader.Text = "???";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(16, 182);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(100, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Einsatzleiter: ";
            // 
            // mLabelEinsatzdauer
            // 
            this.mLabelEinsatzdauer.Depth = 0;
            this.mLabelEinsatzdauer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelEinsatzdauer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelEinsatzdauer.Location = new System.Drawing.Point(755, 33);
            this.mLabelEinsatzdauer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelEinsatzdauer.Name = "mLabelEinsatzdauer";
            this.mLabelEinsatzdauer.Size = new System.Drawing.Size(68, 26);
            this.mLabelEinsatzdauer.TabIndex = 12;
            this.mLabelEinsatzdauer.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 638);
            this.Controls.Add(this.mLabelEinsatzdauer);
            this.Controls.Add(this.mLabelValueEinsatzLeader);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.mLabelValueProtocolLeader);
            this.Controls.Add(this.mLabelProtocolLeader);
            this.Controls.Add(this.mLabelValueEinsatzStart);
            this.Controls.Add(this.mLabelValueEinsatzOrt);
            this.Controls.Add(this.mLabelTitelEinsatzStart);
            this.Controls.Add(this.mLabelTitleEinsatzOrt);
            this.Controls.Add(this.mLabelEinsatzInformations);
            this.Controls.Add(this.mLabelClock);
            this.Controls.Add(this.mTabSelector);
            this.Controls.Add(this.mTabControl1);
            this.Name = "MainForm";
            this.Text = "Einsatzleitsoftware FFW Oberfell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ffwDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.mTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ffwDBDataSet ffwDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ffwDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ffwDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialTabControl mTabControl1;
        private System.Windows.Forms.TabPage mTabPageFunkProtocol;
        private System.Windows.Forms.TabPage mTabPageAtemSchutzUeberwachung;
        private MaterialSkin.Controls.MaterialTabSelector mTabSelector;
        private MaterialSkin.Controls.MaterialLabel mLabelClock;
        private MaterialSkin.Controls.MaterialLabel mLabelEinsatzInformations;
        private MaterialSkin.Controls.MaterialLabel mLabelTitleEinsatzOrt;
        private MaterialSkin.Controls.MaterialLabel mLabelTitelEinsatzStart;
        private MaterialSkin.Controls.MaterialLabel mLabelValueEinsatzOrt;
        private MaterialSkin.Controls.MaterialLabel mLabelValueEinsatzStart;
        private MaterialSkin.Controls.MaterialLabel mLabelValueProtocolLeader;
        private MaterialSkin.Controls.MaterialLabel mLabelProtocolLeader;
        private MaterialSkin.Controls.MaterialLabel mLabelValueEinsatzLeader;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel mLabelEinsatzdauer;
    }
}

