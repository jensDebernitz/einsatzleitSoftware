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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.ffwDBDataSet = new einsatzLeitSoftware.ffwDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new einsatzLeitSoftware.ffwDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new einsatzLeitSoftware.ffwDBDataSetTableAdapters.TableAdapterManager();
            this.mTabControlMaps = new MaterialSkin.Controls.MaterialTabControl();
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
            this.mTabPageMaps = new System.Windows.Forms.TabPage();
            this.mTabPageExport = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.mTextFieldStreet = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldState = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldZip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.mButtonSearchButton = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.ffwDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.mTabControlMaps.SuspendLayout();
            this.mTabPageFunkProtocol.SuspendLayout();
            this.mTabPageMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // mTabControlMaps
            // 
            this.mTabControlMaps.Controls.Add(this.mTabPageFunkProtocol);
            this.mTabControlMaps.Controls.Add(this.mTabPageAtemSchutzUeberwachung);
            this.mTabControlMaps.Controls.Add(this.mTabPageMaps);
            this.mTabControlMaps.Controls.Add(this.mTabPageExport);
            this.mTabControlMaps.Depth = 0;
            this.mTabControlMaps.Location = new System.Drawing.Point(12, 250);
            this.mTabControlMaps.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabControlMaps.Name = "mTabControlMaps";
            this.mTabControlMaps.SelectedIndex = 0;
            this.mTabControlMaps.Size = new System.Drawing.Size(1277, 385);
            this.mTabControlMaps.TabIndex = 0;
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
            this.mTabPageAtemSchutzUeberwachung.Size = new System.Drawing.Size(1269, 359);
            this.mTabPageAtemSchutzUeberwachung.TabIndex = 1;
            this.mTabPageAtemSchutzUeberwachung.Text = "Atemschutzüberwachung";
            this.mTabPageAtemSchutzUeberwachung.UseVisualStyleBackColor = true;
            // 
            // mTabSelector
            // 
            this.mTabSelector.BaseTabControl = this.mTabControlMaps;
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
            listViewItem3});
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
            // mTabPageMaps
            // 
            this.mTabPageMaps.Controls.Add(this.splitContainer1);
            this.mTabPageMaps.Location = new System.Drawing.Point(4, 22);
            this.mTabPageMaps.Name = "mTabPageMaps";
            this.mTabPageMaps.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageMaps.Size = new System.Drawing.Size(1269, 359);
            this.mTabPageMaps.TabIndex = 2;
            this.mTabPageMaps.Text = "Maps";
            this.mTabPageMaps.UseVisualStyleBackColor = true;
            // 
            // mTabPageExport
            // 
            this.mTabPageExport.Location = new System.Drawing.Point(4, 22);
            this.mTabPageExport.Name = "mTabPageExport";
            this.mTabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageExport.Size = new System.Drawing.Size(1269, 359);
            this.mTabPageExport.TabIndex = 3;
            this.mTabPageExport.Text = "Export";
            this.mTabPageExport.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.mButtonSearchButton);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.materialLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.mTextFieldZip);
            this.splitContainer1.Panel1.Controls.Add(this.mTextFieldState);
            this.splitContainer1.Panel1.Controls.Add(this.mTextFieldCity);
            this.splitContainer1.Panel1.Controls.Add(this.mTextFieldStreet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1263, 353);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(838, 353);
            this.webBrowser1.TabIndex = 0;
            // 
            // mTextFieldStreet
            // 
            this.mTextFieldStreet.Depth = 0;
            this.mTextFieldStreet.Hint = "";
            this.mTextFieldStreet.Location = new System.Drawing.Point(76, 17);
            this.mTextFieldStreet.MaxLength = 32767;
            this.mTextFieldStreet.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldStreet.Name = "mTextFieldStreet";
            this.mTextFieldStreet.PasswordChar = '\0';
            this.mTextFieldStreet.SelectedText = "";
            this.mTextFieldStreet.SelectionLength = 0;
            this.mTextFieldStreet.SelectionStart = 0;
            this.mTextFieldStreet.Size = new System.Drawing.Size(203, 23);
            this.mTextFieldStreet.TabIndex = 0;
            this.mTextFieldStreet.TabStop = false;
            this.mTextFieldStreet.UseSystemPasswordChar = false;
            // 
            // mTextFieldCity
            // 
            this.mTextFieldCity.Depth = 0;
            this.mTextFieldCity.Hint = "";
            this.mTextFieldCity.Location = new System.Drawing.Point(76, 47);
            this.mTextFieldCity.MaxLength = 32767;
            this.mTextFieldCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldCity.Name = "mTextFieldCity";
            this.mTextFieldCity.PasswordChar = '\0';
            this.mTextFieldCity.SelectedText = "";
            this.mTextFieldCity.SelectionLength = 0;
            this.mTextFieldCity.SelectionStart = 0;
            this.mTextFieldCity.Size = new System.Drawing.Size(203, 23);
            this.mTextFieldCity.TabIndex = 1;
            this.mTextFieldCity.TabStop = false;
            this.mTextFieldCity.UseSystemPasswordChar = false;
            // 
            // mTextFieldState
            // 
            this.mTextFieldState.Depth = 0;
            this.mTextFieldState.Hint = "";
            this.mTextFieldState.Location = new System.Drawing.Point(76, 77);
            this.mTextFieldState.MaxLength = 32767;
            this.mTextFieldState.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldState.Name = "mTextFieldState";
            this.mTextFieldState.PasswordChar = '\0';
            this.mTextFieldState.SelectedText = "";
            this.mTextFieldState.SelectionLength = 0;
            this.mTextFieldState.SelectionStart = 0;
            this.mTextFieldState.Size = new System.Drawing.Size(203, 23);
            this.mTextFieldState.TabIndex = 2;
            this.mTextFieldState.TabStop = false;
            this.mTextFieldState.UseSystemPasswordChar = false;
            // 
            // mTextFieldZip
            // 
            this.mTextFieldZip.Depth = 0;
            this.mTextFieldZip.Hint = "";
            this.mTextFieldZip.Location = new System.Drawing.Point(76, 107);
            this.mTextFieldZip.MaxLength = 32767;
            this.mTextFieldZip.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldZip.Name = "mTextFieldZip";
            this.mTextFieldZip.PasswordChar = '\0';
            this.mTextFieldZip.SelectedText = "";
            this.mTextFieldZip.SelectionLength = 0;
            this.mTextFieldZip.SelectionStart = 0;
            this.mTextFieldZip.Size = new System.Drawing.Size(203, 23);
            this.mTextFieldZip.TabIndex = 3;
            this.mTextFieldZip.TabStop = false;
            this.mTextFieldZip.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Strasse";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 51);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(29, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Ort";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 81);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(44, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "State";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(13, 111);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(29, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Plz";
            // 
            // mButtonSearchButton
            // 
            this.mButtonSearchButton.AutoSize = true;
            this.mButtonSearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mButtonSearchButton.Depth = 0;
            this.mButtonSearchButton.Icon = null;
            this.mButtonSearchButton.Location = new System.Drawing.Point(117, 157);
            this.mButtonSearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mButtonSearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mButtonSearchButton.Name = "mButtonSearchButton";
            this.mButtonSearchButton.Primary = false;
            this.mButtonSearchButton.Size = new System.Drawing.Size(74, 36);
            this.mButtonSearchButton.TabIndex = 8;
            this.mButtonSearchButton.Text = "suchen";
            this.mButtonSearchButton.UseVisualStyleBackColor = true;
            this.mButtonSearchButton.Click += new System.EventHandler(this.mButtonSearchButton_Click);
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
            this.Controls.Add(this.mTabControlMaps);
            this.Name = "MainForm";
            this.Text = "Einsatzleitsoftware FFW Oberfell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ffwDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.mTabControlMaps.ResumeLayout(false);
            this.mTabPageFunkProtocol.ResumeLayout(false);
            this.mTabPageFunkProtocol.PerformLayout();
            this.mTabPageMaps.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ffwDBDataSet ffwDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ffwDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ffwDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialTabControl mTabControlMaps;
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
        private System.Windows.Forms.TabPage mTabPageMaps;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldZip;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldState;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldCity;
        private MaterialSkin.Controls.MaterialSingleLineTextField mTextFieldStreet;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage mTabPageExport;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton mButtonSearchButton;
    }
}

