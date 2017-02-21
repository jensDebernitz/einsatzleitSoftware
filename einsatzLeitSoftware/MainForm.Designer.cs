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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mButtonSearchButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mTextFieldZip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldState = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mTextFieldStreet = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.mColumnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderTimer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderFunkFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderFunkTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mColumnHeaderPrio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mTabPageAtemSchutzUeberwachung = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mTabControlAtemSchutz = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageAtemschutz1 = new System.Windows.Forms.TabPage();
            this.mButtonNewTabPage = new MaterialSkin.Controls.MaterialFlatButton();
            this.mTabPageMaps = new System.Windows.Forms.TabPage();
            this.mTabPageExport = new System.Windows.Forms.TabPage();
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
            this.containerClassAtemschutz1 = new einsatzLeitSoftware.containerClassAtemschutz();
            this.containerClassAtemschutz2 = new einsatzLeitSoftware.containerClassAtemschutz();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mTabControlMaps.SuspendLayout();
            this.mTabPageFunkProtocol.SuspendLayout();
            this.mTabPageAtemSchutzUeberwachung.SuspendLayout();
            this.mTabControlAtemSchutz.SuspendLayout();
            this.tabPageAtemschutz1.SuspendLayout();
            this.mTabPageMaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
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
            // 
            // mButtonSearchButton
            // 
            resources.ApplyResources(this.mButtonSearchButton, "mButtonSearchButton");
            this.mButtonSearchButton.Depth = 0;
            this.mButtonSearchButton.Icon = null;
            this.mButtonSearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mButtonSearchButton.Name = "mButtonSearchButton";
            this.mButtonSearchButton.Primary = false;
            this.mButtonSearchButton.UseVisualStyleBackColor = true;
            this.mButtonSearchButton.Click += new System.EventHandler(this.mButtonSearchButton_Click);
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // mTextFieldZip
            // 
            this.mTextFieldZip.Depth = 0;
            this.mTextFieldZip.Hint = "";
            resources.ApplyResources(this.mTextFieldZip, "mTextFieldZip");
            this.mTextFieldZip.MaxLength = 32767;
            this.mTextFieldZip.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldZip.Name = "mTextFieldZip";
            this.mTextFieldZip.PasswordChar = '\0';
            this.mTextFieldZip.SelectedText = "";
            this.mTextFieldZip.SelectionLength = 0;
            this.mTextFieldZip.SelectionStart = 0;
            this.mTextFieldZip.TabStop = false;
            this.mTextFieldZip.UseSystemPasswordChar = false;
            // 
            // mTextFieldState
            // 
            this.mTextFieldState.Depth = 0;
            this.mTextFieldState.Hint = "";
            resources.ApplyResources(this.mTextFieldState, "mTextFieldState");
            this.mTextFieldState.MaxLength = 32767;
            this.mTextFieldState.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldState.Name = "mTextFieldState";
            this.mTextFieldState.PasswordChar = '\0';
            this.mTextFieldState.SelectedText = "";
            this.mTextFieldState.SelectionLength = 0;
            this.mTextFieldState.SelectionStart = 0;
            this.mTextFieldState.TabStop = false;
            this.mTextFieldState.UseSystemPasswordChar = false;
            // 
            // mTextFieldCity
            // 
            this.mTextFieldCity.Depth = 0;
            this.mTextFieldCity.Hint = "";
            resources.ApplyResources(this.mTextFieldCity, "mTextFieldCity");
            this.mTextFieldCity.MaxLength = 32767;
            this.mTextFieldCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldCity.Name = "mTextFieldCity";
            this.mTextFieldCity.PasswordChar = '\0';
            this.mTextFieldCity.SelectedText = "";
            this.mTextFieldCity.SelectionLength = 0;
            this.mTextFieldCity.SelectionStart = 0;
            this.mTextFieldCity.TabStop = false;
            this.mTextFieldCity.UseSystemPasswordChar = false;
            // 
            // mTextFieldStreet
            // 
            this.mTextFieldStreet.Depth = 0;
            this.mTextFieldStreet.Hint = "";
            resources.ApplyResources(this.mTextFieldStreet, "mTextFieldStreet");
            this.mTextFieldStreet.MaxLength = 32767;
            this.mTextFieldStreet.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldStreet.Name = "mTextFieldStreet";
            this.mTextFieldStreet.PasswordChar = '\0';
            this.mTextFieldStreet.SelectedText = "";
            this.mTextFieldStreet.SelectionLength = 0;
            this.mTextFieldStreet.SelectionStart = 0;
            this.mTextFieldStreet.TabStop = false;
            this.mTextFieldStreet.UseSystemPasswordChar = false;
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // mTabControlMaps
            // 
            this.mTabControlMaps.Controls.Add(this.mTabPageFunkProtocol);
            this.mTabControlMaps.Controls.Add(this.mTabPageAtemSchutzUeberwachung);
            this.mTabControlMaps.Controls.Add(this.mTabPageMaps);
            this.mTabControlMaps.Controls.Add(this.mTabPageExport);
            this.mTabControlMaps.Depth = 0;
            resources.ApplyResources(this.mTabControlMaps, "mTabControlMaps");
            this.mTabControlMaps.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabControlMaps.Name = "mTabControlMaps";
            this.mTabControlMaps.SelectedIndex = 0;
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
            resources.ApplyResources(this.mTabPageFunkProtocol, "mTabPageFunkProtocol");
            this.mTabPageFunkProtocol.Name = "mTabPageFunkProtocol";
            // 
            // mButtonSave
            // 
            resources.ApplyResources(this.mButtonSave, "mButtonSave");
            this.mButtonSave.Depth = 0;
            this.mButtonSave.Icon = null;
            this.mButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mButtonSave.Name = "mButtonSave";
            this.mButtonSave.Primary = false;
            this.mButtonSave.UseVisualStyleBackColor = true;
            this.mButtonSave.Click += new System.EventHandler(this.mButtonSave_Click);
            // 
            // mTextFieldPrio
            // 
            this.mTextFieldPrio.Depth = 0;
            this.mTextFieldPrio.Hint = "";
            resources.ApplyResources(this.mTextFieldPrio, "mTextFieldPrio");
            this.mTextFieldPrio.MaxLength = 32767;
            this.mTextFieldPrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldPrio.Name = "mTextFieldPrio";
            this.mTextFieldPrio.PasswordChar = '\0';
            this.mTextFieldPrio.SelectedText = "";
            this.mTextFieldPrio.SelectionLength = 0;
            this.mTextFieldPrio.SelectionStart = 0;
            this.mTextFieldPrio.TabStop = false;
            this.mTextFieldPrio.UseSystemPasswordChar = false;
            this.mTextFieldPrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldMessage
            // 
            this.mTextFieldMessage.Depth = 0;
            this.mTextFieldMessage.Hint = "";
            resources.ApplyResources(this.mTextFieldMessage, "mTextFieldMessage");
            this.mTextFieldMessage.MaxLength = 32767;
            this.mTextFieldMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldMessage.Name = "mTextFieldMessage";
            this.mTextFieldMessage.PasswordChar = '\0';
            this.mTextFieldMessage.SelectedText = "";
            this.mTextFieldMessage.SelectionLength = 0;
            this.mTextFieldMessage.SelectionStart = 0;
            this.mTextFieldMessage.TabStop = false;
            this.mTextFieldMessage.UseSystemPasswordChar = false;
            this.mTextFieldMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldFunkTo
            // 
            this.mTextFieldFunkTo.Depth = 0;
            this.mTextFieldFunkTo.Hint = "";
            resources.ApplyResources(this.mTextFieldFunkTo, "mTextFieldFunkTo");
            this.mTextFieldFunkTo.MaxLength = 32767;
            this.mTextFieldFunkTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldFunkTo.Name = "mTextFieldFunkTo";
            this.mTextFieldFunkTo.PasswordChar = '\0';
            this.mTextFieldFunkTo.SelectedText = "";
            this.mTextFieldFunkTo.SelectionLength = 0;
            this.mTextFieldFunkTo.SelectionStart = 0;
            this.mTextFieldFunkTo.TabStop = false;
            this.mTextFieldFunkTo.UseSystemPasswordChar = false;
            this.mTextFieldFunkTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldFunkFrom
            // 
            this.mTextFieldFunkFrom.Depth = 0;
            this.mTextFieldFunkFrom.Hint = "";
            resources.ApplyResources(this.mTextFieldFunkFrom, "mTextFieldFunkFrom");
            this.mTextFieldFunkFrom.MaxLength = 32767;
            this.mTextFieldFunkFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldFunkFrom.Name = "mTextFieldFunkFrom";
            this.mTextFieldFunkFrom.PasswordChar = '\0';
            this.mTextFieldFunkFrom.SelectedText = "";
            this.mTextFieldFunkFrom.SelectionLength = 0;
            this.mTextFieldFunkFrom.SelectionStart = 0;
            this.mTextFieldFunkFrom.TabStop = false;
            this.mTextFieldFunkFrom.UseSystemPasswordChar = false;
            this.mTextFieldFunkFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTextField_KeyPress);
            // 
            // mTextFieldTimer
            // 
            this.mTextFieldTimer.Depth = 0;
            resources.ApplyResources(this.mTextFieldTimer, "mTextFieldTimer");
            this.mTextFieldTimer.Hint = "";
            this.mTextFieldTimer.MaxLength = 32767;
            this.mTextFieldTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldTimer.Name = "mTextFieldTimer";
            this.mTextFieldTimer.PasswordChar = '\0';
            this.mTextFieldTimer.SelectedText = "";
            this.mTextFieldTimer.SelectionLength = 0;
            this.mTextFieldTimer.SelectionStart = 0;
            this.mTextFieldTimer.TabStop = false;
            this.mTextFieldTimer.UseSystemPasswordChar = false;
            // 
            // mTextFieldTime
            // 
            this.mTextFieldTime.Depth = 0;
            resources.ApplyResources(this.mTextFieldTime, "mTextFieldTime");
            this.mTextFieldTime.Hint = "";
            this.mTextFieldTime.MaxLength = 32767;
            this.mTextFieldTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldTime.Name = "mTextFieldTime";
            this.mTextFieldTime.PasswordChar = '\0';
            this.mTextFieldTime.SelectedText = "";
            this.mTextFieldTime.SelectionLength = 0;
            this.mTextFieldTime.SelectionStart = 0;
            this.mTextFieldTime.TabStop = false;
            this.mTextFieldTime.UseSystemPasswordChar = false;
            // 
            // mTextFieldDate
            // 
            this.mTextFieldDate.Depth = 0;
            resources.ApplyResources(this.mTextFieldDate, "mTextFieldDate");
            this.mTextFieldDate.Hint = "";
            this.mTextFieldDate.MaxLength = 32767;
            this.mTextFieldDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldDate.Name = "mTextFieldDate";
            this.mTextFieldDate.PasswordChar = '\0';
            this.mTextFieldDate.SelectedText = "";
            this.mTextFieldDate.SelectionLength = 0;
            this.mTextFieldDate.SelectionStart = 0;
            this.mTextFieldDate.TabStop = false;
            this.mTextFieldDate.UseSystemPasswordChar = false;
            // 
            // mTextFieldID
            // 
            this.mTextFieldID.Depth = 0;
            resources.ApplyResources(this.mTextFieldID, "mTextFieldID");
            this.mTextFieldID.Hint = "";
            this.mTextFieldID.MaxLength = 32767;
            this.mTextFieldID.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTextFieldID.Name = "mTextFieldID";
            this.mTextFieldID.PasswordChar = '\0';
            this.mTextFieldID.SelectedText = "";
            this.mTextFieldID.SelectionLength = 0;
            this.mTextFieldID.SelectionStart = 0;
            this.mTextFieldID.TabStop = false;
            this.mTextFieldID.UseSystemPasswordChar = false;
            // 
            // materialListView1
            // 
            this.materialListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
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
            resources.ApplyResources(this.materialListView1, "materialListView1");
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HoverSelection = true;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("materialListView1.Items")))});
            this.materialListView1.LabelEdit = true;
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.List;
            // 
            // mColumnHeaderId
            // 
            resources.ApplyResources(this.mColumnHeaderId, "mColumnHeaderId");
            // 
            // mColumnHeaderDate
            // 
            resources.ApplyResources(this.mColumnHeaderDate, "mColumnHeaderDate");
            // 
            // mColumnHeaderTime
            // 
            resources.ApplyResources(this.mColumnHeaderTime, "mColumnHeaderTime");
            // 
            // mColumnHeaderTimer
            // 
            resources.ApplyResources(this.mColumnHeaderTimer, "mColumnHeaderTimer");
            // 
            // mColumnHeaderFunkFrom
            // 
            resources.ApplyResources(this.mColumnHeaderFunkFrom, "mColumnHeaderFunkFrom");
            // 
            // mColumnHeaderFunkTo
            // 
            resources.ApplyResources(this.mColumnHeaderFunkTo, "mColumnHeaderFunkTo");
            // 
            // mColumnHeaderText
            // 
            resources.ApplyResources(this.mColumnHeaderText, "mColumnHeaderText");
            // 
            // mColumnHeaderPrio
            // 
            resources.ApplyResources(this.mColumnHeaderPrio, "mColumnHeaderPrio");
            // 
            // mTabPageAtemSchutzUeberwachung
            // 
            this.mTabPageAtemSchutzUeberwachung.BackColor = System.Drawing.Color.White;
            this.mTabPageAtemSchutzUeberwachung.Controls.Add(this.materialTabSelector1);
            this.mTabPageAtemSchutzUeberwachung.Controls.Add(this.mButtonNewTabPage);
            this.mTabPageAtemSchutzUeberwachung.Controls.Add(this.mTabControlAtemSchutz);
            resources.ApplyResources(this.mTabPageAtemSchutzUeberwachung, "mTabPageAtemSchutzUeberwachung");
            this.mTabPageAtemSchutzUeberwachung.Name = "mTabPageAtemSchutzUeberwachung";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.mTabControlAtemSchutz;
            this.materialTabSelector1.Depth = 0;
            resources.ApplyResources(this.materialTabSelector1, "materialTabSelector1");
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            // 
            // mTabControlAtemSchutz
            // 
            this.mTabControlAtemSchutz.Controls.Add(this.tabPageAtemschutz1);
            this.mTabControlAtemSchutz.Depth = 0;
            resources.ApplyResources(this.mTabControlAtemSchutz, "mTabControlAtemSchutz");
            this.mTabControlAtemSchutz.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabControlAtemSchutz.Name = "mTabControlAtemSchutz";
            this.mTabControlAtemSchutz.SelectedIndex = 0;
            // 
            // tabPageAtemschutz1
            // 
            this.tabPageAtemschutz1.Controls.Add(this.containerClassAtemschutz2);
            resources.ApplyResources(this.tabPageAtemschutz1, "tabPageAtemschutz1");
            this.tabPageAtemschutz1.Name = "tabPageAtemschutz1";
            this.tabPageAtemschutz1.UseVisualStyleBackColor = true;
            // 
            // mButtonNewTabPage
            // 
            resources.ApplyResources(this.mButtonNewTabPage, "mButtonNewTabPage");
            this.mButtonNewTabPage.BackColor = System.Drawing.Color.Gray;
            this.mButtonNewTabPage.Depth = 0;
            this.mButtonNewTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mButtonNewTabPage.Icon = null;
            this.mButtonNewTabPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.mButtonNewTabPage.Name = "mButtonNewTabPage";
            this.mButtonNewTabPage.Primary = false;
            this.mButtonNewTabPage.UseVisualStyleBackColor = false;
            this.mButtonNewTabPage.Click += new System.EventHandler(this.mButtonNewTabPage_Click);
            // 
            // mTabPageMaps
            // 
            this.mTabPageMaps.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.mTabPageMaps, "mTabPageMaps");
            this.mTabPageMaps.Name = "mTabPageMaps";
            this.mTabPageMaps.UseVisualStyleBackColor = true;
            // 
            // mTabPageExport
            // 
            resources.ApplyResources(this.mTabPageExport, "mTabPageExport");
            this.mTabPageExport.Name = "mTabPageExport";
            this.mTabPageExport.UseVisualStyleBackColor = true;
            // 
            // mTabSelector
            // 
            this.mTabSelector.BaseTabControl = this.mTabControlMaps;
            this.mTabSelector.Depth = 0;
            resources.ApplyResources(this.mTabSelector, "mTabSelector");
            this.mTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabSelector.Name = "mTabSelector";
            // 
            // mLabelClock
            // 
            this.mLabelClock.Depth = 0;
            resources.ApplyResources(this.mLabelClock, "mLabelClock");
            this.mLabelClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelClock.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelClock.Name = "mLabelClock";
            // 
            // mLabelEinsatzInformations
            // 
            resources.ApplyResources(this.mLabelEinsatzInformations, "mLabelEinsatzInformations");
            this.mLabelEinsatzInformations.BackColor = System.Drawing.Color.White;
            this.mLabelEinsatzInformations.Depth = 0;
            this.mLabelEinsatzInformations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelEinsatzInformations.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelEinsatzInformations.Name = "mLabelEinsatzInformations";
            // 
            // mLabelTitleEinsatzOrt
            // 
            resources.ApplyResources(this.mLabelTitleEinsatzOrt, "mLabelTitleEinsatzOrt");
            this.mLabelTitleEinsatzOrt.BackColor = System.Drawing.Color.White;
            this.mLabelTitleEinsatzOrt.Depth = 0;
            this.mLabelTitleEinsatzOrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitleEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitleEinsatzOrt.Name = "mLabelTitleEinsatzOrt";
            // 
            // mLabelTitelEinsatzStart
            // 
            resources.ApplyResources(this.mLabelTitelEinsatzStart, "mLabelTitelEinsatzStart");
            this.mLabelTitelEinsatzStart.BackColor = System.Drawing.Color.White;
            this.mLabelTitelEinsatzStart.Depth = 0;
            this.mLabelTitelEinsatzStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTitelEinsatzStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTitelEinsatzStart.Name = "mLabelTitelEinsatzStart";
            // 
            // mLabelValueEinsatzOrt
            // 
            resources.ApplyResources(this.mLabelValueEinsatzOrt, "mLabelValueEinsatzOrt");
            this.mLabelValueEinsatzOrt.BackColor = System.Drawing.Color.White;
            this.mLabelValueEinsatzOrt.Depth = 0;
            this.mLabelValueEinsatzOrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueEinsatzOrt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzOrt.Name = "mLabelValueEinsatzOrt";
            // 
            // mLabelValueEinsatzStart
            // 
            resources.ApplyResources(this.mLabelValueEinsatzStart, "mLabelValueEinsatzStart");
            this.mLabelValueEinsatzStart.BackColor = System.Drawing.Color.White;
            this.mLabelValueEinsatzStart.Depth = 0;
            this.mLabelValueEinsatzStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueEinsatzStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzStart.Name = "mLabelValueEinsatzStart";
            // 
            // mLabelValueProtocolLeader
            // 
            resources.ApplyResources(this.mLabelValueProtocolLeader, "mLabelValueProtocolLeader");
            this.mLabelValueProtocolLeader.BackColor = System.Drawing.Color.White;
            this.mLabelValueProtocolLeader.Depth = 0;
            this.mLabelValueProtocolLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueProtocolLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueProtocolLeader.Name = "mLabelValueProtocolLeader";
            // 
            // mLabelProtocolLeader
            // 
            resources.ApplyResources(this.mLabelProtocolLeader, "mLabelProtocolLeader");
            this.mLabelProtocolLeader.BackColor = System.Drawing.Color.White;
            this.mLabelProtocolLeader.Depth = 0;
            this.mLabelProtocolLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelProtocolLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelProtocolLeader.Name = "mLabelProtocolLeader";
            // 
            // mLabelValueEinsatzLeader
            // 
            resources.ApplyResources(this.mLabelValueEinsatzLeader, "mLabelValueEinsatzLeader");
            this.mLabelValueEinsatzLeader.BackColor = System.Drawing.Color.White;
            this.mLabelValueEinsatzLeader.Depth = 0;
            this.mLabelValueEinsatzLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueEinsatzLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueEinsatzLeader.Name = "mLabelValueEinsatzLeader";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // mLabelEinsatzdauer
            // 
            this.mLabelEinsatzdauer.Depth = 0;
            resources.ApplyResources(this.mLabelEinsatzdauer, "mLabelEinsatzdauer");
            this.mLabelEinsatzdauer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelEinsatzdauer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelEinsatzdauer.Name = "mLabelEinsatzdauer";
            // 
            // containerClassAtemschutz1
            // 
            this.containerClassAtemschutz1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.containerClassAtemschutz1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.containerClassAtemschutz1, "containerClassAtemschutz1");
            this.containerClassAtemschutz1.Name = "containerClassAtemschutz1";
            // 
            // containerClassAtemschutz2
            // 
            this.containerClassAtemschutz2.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.containerClassAtemschutz2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.containerClassAtemschutz2, "containerClassAtemschutz2");
            this.containerClassAtemschutz2.Name = "containerClassAtemschutz2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mTabControlMaps.ResumeLayout(false);
            this.mTabPageFunkProtocol.ResumeLayout(false);
            this.mTabPageFunkProtocol.PerformLayout();
            this.mTabPageAtemSchutzUeberwachung.ResumeLayout(false);
            this.mTabPageAtemSchutzUeberwachung.PerformLayout();
            this.mTabControlAtemSchutz.ResumeLayout(false);
            this.tabPageAtemschutz1.ResumeLayout(false);
            this.mTabPageMaps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private MaterialSkin.Controls.MaterialFlatButton mButtonNewTabPage;
        private MaterialSkin.Controls.MaterialTabControl mTabControlAtemSchutz;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPageAtemschutz1;
        private containerClassAtemschutz containerClassAtemschutz1;
        private containerClassAtemschutz containerClassAtemschutz2;
    }
}

