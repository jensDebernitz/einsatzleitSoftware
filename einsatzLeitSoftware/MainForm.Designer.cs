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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ffwDBDataSet = new einsatzLeitSoftware.ffwDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new einsatzLeitSoftware.ffwDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new einsatzLeitSoftware.ffwDBDataSetTableAdapters.TableAdapterManager();
            this.mTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.mTabPageFunkProtocol = new System.Windows.Forms.TabPage();
            this.mButtonSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.mTextFieldPrio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldFunkTo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldFunkFrom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldTimer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldID = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.mColumnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderTimer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderFunkFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderFunkTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderPrio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            ((System.ComponentModel.ISupportInitialize)(this.ffwDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.mTabControl1.SuspendLayout();
            this.mTabPageFunkProtocol.SuspendLayout();
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
            this.mTabControl1.Location = new System.Drawing.Point(12, 250);
            this.mTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabControl1.Name = "mTabControl1";
            this.mTabControl1.SelectedIndex = 0;
            this.mTabControl1.Size = new System.Drawing.Size(1277, 385);
            this.mTabControl1.TabIndex = 0;
            // 
            // mTabPageFunkProtocol
            // 
            this.mTabPageFunkProtocol.BackColor = System.Drawing.Color.White;
            this.mTabPageFunkProtocol.Controls.Add(this.mButtonSave);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldPrio);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldMessage);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldFunkTo);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldFunkFrom);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldTimer);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldTime);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldDate);
            this.mTabPageFunkProtocol.Controls.Add(this.mTextFieldID);
            this.mTabPageFunkProtocol.Controls.Add(this.materialListView1);
            this.mTabPageFunkProtocol.Location = new System.Drawing.Point(4, 22);
            this.mTabPageFunkProtocol.Name = "mTabPageFunkProtocol";
            this.mTabPageFunkProtocol.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageFunkProtocol.Size = new System.Drawing.Size(1269, 359);
            this.mTabPageFunkProtocol.TabIndex = 0;
            this.mTabPageFunkProtocol.Text = "Funkprotokoll";
            // 
            // mButtonSave
            // 
            this.mButtonSave.AutoSize = true;
            this.mButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mButtonSave.Depth = 0;
            this.mButtonSave.Icon = null;
            this.mButtonSave.Location = new System.Drawing.Point(1168, 303);
            this.mButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mButtonSave.Name = "mButtonSave";
            this.mButtonSave.Primary = false;
            this.mButtonSave.Size = new System.Drawing.Size(94, 36);
            this.mButtonSave.TabIndex = 9;
            this.mButtonSave.Text = "Speichern";
            this.mButtonSave.UseVisualStyleBackColor = true;
            this.mButtonSave.Click += new System.EventHandler(this.mButtonSave_Click);
            // 
            // mTextFieldPrio
            // 
            this.mTextFieldPrio.Depth = 0;
            this.mTextFieldPrio.Hint = "";
            this.mTextFieldPrio.Location = new System.Drawing.Point(1099, 303);
            this.mTextFieldPrio.MaxLength = 32767;
            this.mTextFieldPrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldPrio.Name = "mTextFieldPrio";
            this.mTextFieldPrio.PasswordChar = '\0';
            this.mTextFieldPrio.SelectedText = "";
            this.mTextFieldPrio.SelectionLength = 0;
            this.mTextFieldPrio.SelectionStart = 0;
            this.mTextFieldPrio.Size = new System.Drawing.Size(62, 23);
            this.mTextFieldPrio.TabIndex = 8;
            this.mTextFieldPrio.TabStop = false;
            this.mTextFieldPrio.Text = "1";
            this.mTextFieldPrio.UseSystemPasswordChar = false;
            this.mTextFieldPrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldMessage
            // 
            this.mTextFieldMessage.Depth = 0;
            this.mTextFieldMessage.Hint = "";
            this.mTextFieldMessage.Location = new System.Drawing.Point(474, 303);
            this.mTextFieldMessage.MaxLength = 32767;
            this.mTextFieldMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldMessage.Name = "mTextFieldMessage";
            this.mTextFieldMessage.PasswordChar = '\0';
            this.mTextFieldMessage.SelectedText = "";
            this.mTextFieldMessage.SelectionLength = 0;
            this.mTextFieldMessage.SelectionStart = 0;
            this.mTextFieldMessage.Size = new System.Drawing.Size(619, 23);
            this.mTextFieldMessage.TabIndex = 7;
            this.mTextFieldMessage.TabStop = false;
            this.mTextFieldMessage.Text = "???";
            this.mTextFieldMessage.UseSystemPasswordChar = false;
            this.mTextFieldMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldFunkTo
            // 
            this.mTextFieldFunkTo.Depth = 0;
            this.mTextFieldFunkTo.Hint = "";
            this.mTextFieldFunkTo.Location = new System.Drawing.Point(365, 303);
            this.mTextFieldFunkTo.MaxLength = 32767;
            this.mTextFieldFunkTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldFunkTo.Name = "mTextFieldFunkTo";
            this.mTextFieldFunkTo.PasswordChar = '\0';
            this.mTextFieldFunkTo.SelectedText = "";
            this.mTextFieldFunkTo.SelectionLength = 0;
            this.mTextFieldFunkTo.SelectionStart = 0;
            this.mTextFieldFunkTo.Size = new System.Drawing.Size(103, 23);
            this.mTextFieldFunkTo.TabIndex = 6;
            this.mTextFieldFunkTo.TabStop = false;
            this.mTextFieldFunkTo.Text = "REMO 42";
            this.mTextFieldFunkTo.UseSystemPasswordChar = false;
            this.mTextFieldFunkTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldFunkFrom
            // 
            this.mTextFieldFunkFrom.Depth = 0;
            this.mTextFieldFunkFrom.Hint = "";
            this.mTextFieldFunkFrom.Location = new System.Drawing.Point(256, 303);
            this.mTextFieldFunkFrom.MaxLength = 32767;
            this.mTextFieldFunkFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldFunkFrom.Name = "mTextFieldFunkFrom";
            this.mTextFieldFunkFrom.PasswordChar = '\0';
            this.mTextFieldFunkFrom.SelectedText = "";
            this.mTextFieldFunkFrom.SelectionLength = 0;
            this.mTextFieldFunkFrom.SelectionStart = 0;
            this.mTextFieldFunkFrom.Size = new System.Drawing.Size(103, 23);
            this.mTextFieldFunkFrom.TabIndex = 5;
            this.mTextFieldFunkFrom.TabStop = false;
            this.mTextFieldFunkFrom.Text = "REMO 90";
            this.mTextFieldFunkFrom.UseSystemPasswordChar = false;
            this.mTextFieldFunkFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldTimer
            // 
            this.mTextFieldTimer.Depth = 0;
            this.mTextFieldTimer.Enabled = false;
            this.mTextFieldTimer.Hint = "";
            this.mTextFieldTimer.Location = new System.Drawing.Point(177, 303);
            this.mTextFieldTimer.MaxLength = 32767;
            this.mTextFieldTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldTimer.Name = "mTextFieldTimer";
            this.mTextFieldTimer.PasswordChar = '\0';
            this.mTextFieldTimer.SelectedText = "";
            this.mTextFieldTimer.SelectionLength = 0;
            this.mTextFieldTimer.SelectionStart = 0;
            this.mTextFieldTimer.Size = new System.Drawing.Size(73, 23);
            this.mTextFieldTimer.TabIndex = 4;
            this.mTextFieldTimer.TabStop = false;
            this.mTextFieldTimer.Text = "12:12:00";
            this.mTextFieldTimer.UseSystemPasswordChar = false;
            // 
            // mTextFieldTime
            // 
            this.mTextFieldTime.Depth = 0;
            this.mTextFieldTime.Enabled = false;
            this.mTextFieldTime.Hint = "";
            this.mTextFieldTime.Location = new System.Drawing.Point(124, 303);
            this.mTextFieldTime.MaxLength = 32767;
            this.mTextFieldTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldTime.Name = "mTextFieldTime";
            this.mTextFieldTime.PasswordChar = '\0';
            this.mTextFieldTime.SelectedText = "";
            this.mTextFieldTime.SelectionLength = 0;
            this.mTextFieldTime.SelectionStart = 0;
            this.mTextFieldTime.Size = new System.Drawing.Size(47, 23);
            this.mTextFieldTime.TabIndex = 3;
            this.mTextFieldTime.TabStop = false;
            this.mTextFieldTime.Text = "12:12";
            this.mTextFieldTime.UseSystemPasswordChar = false;
            // 
            // mTextFieldDate
            // 
            this.mTextFieldDate.Depth = 0;
            this.mTextFieldDate.Enabled = false;
            this.mTextFieldDate.Hint = "";
            this.mTextFieldDate.Location = new System.Drawing.Point(30, 303);
            this.mTextFieldDate.MaxLength = 32767;
            this.mTextFieldDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldDate.Name = "mTextFieldDate";
            this.mTextFieldDate.PasswordChar = '\0';
            this.mTextFieldDate.SelectedText = "";
            this.mTextFieldDate.SelectionLength = 0;
            this.mTextFieldDate.SelectionStart = 0;
            this.mTextFieldDate.Size = new System.Drawing.Size(88, 23);
            this.mTextFieldDate.TabIndex = 2;
            this.mTextFieldDate.TabStop = false;
            this.mTextFieldDate.Text = "12.02.2017";
            this.mTextFieldDate.UseSystemPasswordChar = false;
            // 
            // mTextFieldID
            // 
            this.mTextFieldID.Depth = 0;
            this.mTextFieldID.Enabled = false;
            this.mTextFieldID.Hint = "";
            this.mTextFieldID.Location = new System.Drawing.Point(6, 303);
            this.mTextFieldID.MaxLength = 32767;
            this.mTextFieldID.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldID.Name = "mTextFieldID";
            this.mTextFieldID.PasswordChar = '\0';
            this.mTextFieldID.SelectedText = "";
            this.mTextFieldID.SelectionLength = 0;
            this.mTextFieldID.SelectionStart = 0;
            this.mTextFieldID.Size = new System.Drawing.Size(18, 23);
            this.mTextFieldID.TabIndex = 1;
            this.mTextFieldID.TabStop = false;
            this.mTextFieldID.Text = "1";
            this.mTextFieldID.UseSystemPasswordChar = false;
            // 
            // mTabPageAtemSchutzUeberwachung
            // 
            this.mTabPageAtemSchutzUeberwachung.Location = new System.Drawing.Point(4, 22);
            this.mTabPageAtemSchutzUeberwachung.Name = "mTabPageAtemSchutzUeberwachung";
            this.mTabPageAtemSchutzUeberwachung.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageAtemSchutzUeberwachung.Size = new System.Drawing.Size(1032, 359);
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
            this.mTabSelector.Size = new System.Drawing.Size(1277, 23);
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
            // mColumnHeaderId
            // 
            this.mColumnHeaderId.Text = "Id";
            this.mColumnHeaderId.Width = 45;
            // 
            // mColumnHeaderDate
            // 
            this.mColumnHeaderDate.DisplayIndex = 2;
            this.mColumnHeaderDate.Text = "Datum";
            this.mColumnHeaderDate.Width = 100;
            // 
            // mColumnHeaderTime
            // 
            this.mColumnHeaderTime.DisplayIndex = 1;
            this.mColumnHeaderTime.Text = "Uhrzeit";
            this.mColumnHeaderTime.Width = 100;
            // 
            // mColumnHeaderTimer
            // 
            this.mColumnHeaderTimer.Text = "Zeit";
            this.mColumnHeaderTimer.Width = 100;
            // 
            // mColumnHeaderFunkFrom
            // 
            this.mColumnHeaderFunkFrom.Text = "von";
            this.mColumnHeaderFunkFrom.Width = 125;
            // 
            // mColumnHeaderFunkTo
            // 
            this.mColumnHeaderFunkTo.Text = "zu";
            this.mColumnHeaderFunkTo.Width = 125;
            // 
            // mColumnHeaderText
            // 
            this.mColumnHeaderText.Text = "Text";
            this.mColumnHeaderText.Width = 500;
            // 
            // mColumnHeaderPrio
            // 
            this.mColumnHeaderPrio.Text = "Prio";
            this.mColumnHeaderPrio.Width = 75;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mColumnHeaderId,
            this.mColumnHeaderDate,
            this.mColumnHeaderTime,
            this.mColumnHeaderTimer,
            this.mColumnHeaderFunkFrom,
            this.mColumnHeaderFunkTo,
            this.mColumnHeaderText,
            this.mColumnHeaderPrio});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.materialListView1.LabelEdit = true;
            this.materialListView1.Location = new System.Drawing.Point(6, 6);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1257, 280);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 638);
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
            this.mTabPageFunkProtocol.ResumeLayout(false);
            this.mTabPageFunkProtocol.PerformLayout();
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
        private MaterialSkin.Controls.MaterialFlatButton mButtonSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldPrio;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldMessage;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldFunkTo;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldFunkFrom;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldTimer;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldDate;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldID;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader mColumnHeaderId;
        private System.Windows.Forms.ColumnHeader mColumnHeaderDate;
        private System.Windows.Forms.ColumnHeader mColumnHeaderTime;
        private System.Windows.Forms.ColumnHeader mColumnHeaderTimer;
        private System.Windows.Forms.ColumnHeader mColumnHeaderFunkFrom;
        private System.Windows.Forms.ColumnHeader mColumnHeaderFunkTo;
        private System.Windows.Forms.ColumnHeader mColumnHeaderText;
        private System.Windows.Forms.ColumnHeader mColumnHeaderPrio;
    }
}

