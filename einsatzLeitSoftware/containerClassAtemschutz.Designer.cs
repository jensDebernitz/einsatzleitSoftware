namespace einsatzLeitSoftware
{
    partial class containerClassAtemschutz
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.mLabelValueBottleFielPressureSicherungsTruppMann = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueSicherungsTruppMann = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelSicherungsTruppFuehrer = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueSicherungsTruppFuehrer = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelSicherungsTruppMann = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueBottleFielPressureTruppMann = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueBottleFielPressureTruppFuehrer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelStartTime = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueTruppMann = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelValueTruppFuehrer = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTruppMann = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTruppfuehrer = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mLabelValueBottleFielPressureTruppMann);
            this.groupBox1.Controls.Add(this.mLabelValueBottleFielPressureTruppFuehrer);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.mLabelStartTime);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.mLabelValueTruppMann);
            this.groupBox1.Controls.Add(this.mLabelValueTruppFuehrer);
            this.groupBox1.Controls.Add(this.mLabelTruppMann);
            this.groupBox1.Controls.Add(this.mLabelTruppfuehrer);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(693, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atemschutz Trupp";
            this.groupBox1.UseCompatibleTextRendering = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mLabelValueBottleFielPressureSicherungsTruppMann);
            this.groupBox2.Controls.Add(this.mLabelValueSicherungsTruppMann);
            this.groupBox2.Controls.Add(this.mLabelValueBottleFielPressureSicherungsTruppFuehrer);
            this.groupBox2.Controls.Add(this.mLabelSicherungsTruppFuehrer);
            this.groupBox2.Controls.Add(this.mLabelValueSicherungsTruppFuehrer);
            this.groupBox2.Controls.Add(this.mLabelSicherungsTruppMann);
            this.groupBox2.Location = new System.Drawing.Point(705, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(559, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sicherungs Trupp";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(693, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "S T A R T";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(4, 189);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(4);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1161, 317);
            this.materialListView1.TabIndex = 13;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // mLabelValueBottleFielPressureSicherungsTruppMann
            // 
            this.mLabelValueBottleFielPressureSicherungsTruppMann.AutoSize = true;
            this.mLabelValueBottleFielPressureSicherungsTruppMann.Depth = 0;
            this.mLabelValueBottleFielPressureSicherungsTruppMann.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueBottleFielPressureSicherungsTruppMann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueBottleFielPressureSicherungsTruppMann.Location = new System.Drawing.Point(483, 48);
            this.mLabelValueBottleFielPressureSicherungsTruppMann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueBottleFielPressureSicherungsTruppMann.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueBottleFielPressureSicherungsTruppMann.Name = "mLabelValueBottleFielPressureSicherungsTruppMann";
            this.mLabelValueBottleFielPressureSicherungsTruppMann.Size = new System.Drawing.Size(70, 24);
            this.mLabelValueBottleFielPressureSicherungsTruppMann.TabIndex = 11;
            this.mLabelValueBottleFielPressureSicherungsTruppMann.Text = "300bar";
            this.mLabelValueBottleFielPressureSicherungsTruppMann.TextChanged += new System.EventHandler(this.mLabelValueBottleFielPressure_TextChanged);
            // 
            // mLabelValueSicherungsTruppMann
            // 
            this.mLabelValueSicherungsTruppMann.AutoSize = true;
            this.mLabelValueSicherungsTruppMann.Depth = 0;
            this.mLabelValueSicherungsTruppMann.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueSicherungsTruppMann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueSicherungsTruppMann.Location = new System.Drawing.Point(136, 48);
            this.mLabelValueSicherungsTruppMann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueSicherungsTruppMann.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueSicherungsTruppMann.Name = "mLabelValueSicherungsTruppMann";
            this.mLabelValueSicherungsTruppMann.Size = new System.Drawing.Size(37, 24);
            this.mLabelValueSicherungsTruppMann.TabIndex = 7;
            this.mLabelValueSicherungsTruppMann.Text = "???";
            // 
            // mLabelValueBottleFielPressureSicherungsTruppFuehrer
            // 
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.AutoSize = true;
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.Depth = 0;
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.Location = new System.Drawing.Point(481, 25);
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.Name = "mLabelValueBottleFielPressureSicherungsTruppFuehrer";
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.Size = new System.Drawing.Size(70, 24);
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.TabIndex = 10;
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.Text = "300bar";
            this.mLabelValueBottleFielPressureSicherungsTruppFuehrer.TextChanged += new System.EventHandler(this.mLabelValueBottleFielPressure_TextChanged);
            // 
            // mLabelSicherungsTruppFuehrer
            // 
            this.mLabelSicherungsTruppFuehrer.AutoSize = true;
            this.mLabelSicherungsTruppFuehrer.Depth = 0;
            this.mLabelSicherungsTruppFuehrer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelSicherungsTruppFuehrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelSicherungsTruppFuehrer.Location = new System.Drawing.Point(7, 25);
            this.mLabelSicherungsTruppFuehrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelSicherungsTruppFuehrer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelSicherungsTruppFuehrer.Name = "mLabelSicherungsTruppFuehrer";
            this.mLabelSicherungsTruppFuehrer.Size = new System.Drawing.Size(113, 24);
            this.mLabelSicherungsTruppFuehrer.TabIndex = 4;
            this.mLabelSicherungsTruppFuehrer.Text = "Truppführer:";
            // 
            // mLabelValueSicherungsTruppFuehrer
            // 
            this.mLabelValueSicherungsTruppFuehrer.AutoSize = true;
            this.mLabelValueSicherungsTruppFuehrer.Depth = 0;
            this.mLabelValueSicherungsTruppFuehrer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueSicherungsTruppFuehrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueSicherungsTruppFuehrer.Location = new System.Drawing.Point(136, 25);
            this.mLabelValueSicherungsTruppFuehrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueSicherungsTruppFuehrer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueSicherungsTruppFuehrer.Name = "mLabelValueSicherungsTruppFuehrer";
            this.mLabelValueSicherungsTruppFuehrer.Size = new System.Drawing.Size(37, 24);
            this.mLabelValueSicherungsTruppFuehrer.TabIndex = 6;
            this.mLabelValueSicherungsTruppFuehrer.Text = "???";
            // 
            // mLabelSicherungsTruppMann
            // 
            this.mLabelSicherungsTruppMann.AutoSize = true;
            this.mLabelSicherungsTruppMann.Depth = 0;
            this.mLabelSicherungsTruppMann.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelSicherungsTruppMann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelSicherungsTruppMann.Location = new System.Drawing.Point(8, 48);
            this.mLabelSicherungsTruppMann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelSicherungsTruppMann.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelSicherungsTruppMann.Name = "mLabelSicherungsTruppMann";
            this.mLabelSicherungsTruppMann.Size = new System.Drawing.Size(111, 24);
            this.mLabelSicherungsTruppMann.TabIndex = 5;
            this.mLabelSicherungsTruppMann.Text = "Truppmann:";
            // 
            // mLabelValueBottleFielPressureTruppMann
            // 
            this.mLabelValueBottleFielPressureTruppMann.AutoSize = true;
            this.mLabelValueBottleFielPressureTruppMann.Depth = 0;
            this.mLabelValueBottleFielPressureTruppMann.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueBottleFielPressureTruppMann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueBottleFielPressureTruppMann.Location = new System.Drawing.Point(613, 48);
            this.mLabelValueBottleFielPressureTruppMann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueBottleFielPressureTruppMann.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueBottleFielPressureTruppMann.Name = "mLabelValueBottleFielPressureTruppMann";
            this.mLabelValueBottleFielPressureTruppMann.Size = new System.Drawing.Size(70, 24);
            this.mLabelValueBottleFielPressureTruppMann.TabIndex = 9;
            this.mLabelValueBottleFielPressureTruppMann.Text = "300bar";
            this.mLabelValueBottleFielPressureTruppMann.TextChanged += new System.EventHandler(this.mLabelValueBottleFielPressure_TextChanged);
            // 
            // mLabelValueBottleFielPressureTruppFuehrer
            // 
            this.mLabelValueBottleFielPressureTruppFuehrer.AutoSize = true;
            this.mLabelValueBottleFielPressureTruppFuehrer.Depth = 0;
            this.mLabelValueBottleFielPressureTruppFuehrer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueBottleFielPressureTruppFuehrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueBottleFielPressureTruppFuehrer.Location = new System.Drawing.Point(613, 25);
            this.mLabelValueBottleFielPressureTruppFuehrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueBottleFielPressureTruppFuehrer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueBottleFielPressureTruppFuehrer.Name = "mLabelValueBottleFielPressureTruppFuehrer";
            this.mLabelValueBottleFielPressureTruppFuehrer.Size = new System.Drawing.Size(70, 24);
            this.mLabelValueBottleFielPressureTruppFuehrer.TabIndex = 8;
            this.mLabelValueBottleFielPressureTruppFuehrer.Text = "300bar";
            this.mLabelValueBottleFielPressureTruppFuehrer.TextChanged += new System.EventHandler(this.mLabelValueBottleFielPressure_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(137, 95);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 24);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "00:00";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 95);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 24);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Einsatzdauer";
            // 
            // mLabelStartTime
            // 
            this.mLabelStartTime.AutoSize = true;
            this.mLabelStartTime.Depth = 0;
            this.mLabelStartTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelStartTime.Location = new System.Drawing.Point(137, 71);
            this.mLabelStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelStartTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelStartTime.Name = "mLabelStartTime";
            this.mLabelStartTime.Size = new System.Drawing.Size(0, 24);
            this.mLabelStartTime.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 71);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Startzeit";
            // 
            // mLabelValueTruppMann
            // 
            this.mLabelValueTruppMann.AutoSize = true;
            this.mLabelValueTruppMann.Depth = 0;
            this.mLabelValueTruppMann.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueTruppMann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueTruppMann.Location = new System.Drawing.Point(137, 48);
            this.mLabelValueTruppMann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueTruppMann.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueTruppMann.Name = "mLabelValueTruppMann";
            this.mLabelValueTruppMann.Size = new System.Drawing.Size(37, 24);
            this.mLabelValueTruppMann.TabIndex = 3;
            this.mLabelValueTruppMann.Text = "???";
            // 
            // mLabelValueTruppFuehrer
            // 
            this.mLabelValueTruppFuehrer.AutoSize = true;
            this.mLabelValueTruppFuehrer.Depth = 0;
            this.mLabelValueTruppFuehrer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelValueTruppFuehrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelValueTruppFuehrer.Location = new System.Drawing.Point(137, 25);
            this.mLabelValueTruppFuehrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelValueTruppFuehrer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelValueTruppFuehrer.Name = "mLabelValueTruppFuehrer";
            this.mLabelValueTruppFuehrer.Size = new System.Drawing.Size(37, 24);
            this.mLabelValueTruppFuehrer.TabIndex = 2;
            this.mLabelValueTruppFuehrer.Text = "???";
            // 
            // mLabelTruppMann
            // 
            this.mLabelTruppMann.AutoSize = true;
            this.mLabelTruppMann.Depth = 0;
            this.mLabelTruppMann.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTruppMann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTruppMann.Location = new System.Drawing.Point(9, 48);
            this.mLabelTruppMann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTruppMann.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTruppMann.Name = "mLabelTruppMann";
            this.mLabelTruppMann.Size = new System.Drawing.Size(111, 24);
            this.mLabelTruppMann.TabIndex = 1;
            this.mLabelTruppMann.Text = "Truppmann:";
            // 
            // mLabelTruppfuehrer
            // 
            this.mLabelTruppfuehrer.AutoSize = true;
            this.mLabelTruppfuehrer.Depth = 0;
            this.mLabelTruppfuehrer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelTruppfuehrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelTruppfuehrer.Location = new System.Drawing.Point(9, 25);
            this.mLabelTruppfuehrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTruppfuehrer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTruppfuehrer.Name = "mLabelTruppfuehrer";
            this.mLabelTruppfuehrer.Size = new System.Drawing.Size(113, 24);
            this.mLabelTruppfuehrer.TabIndex = 0;
            this.mLabelTruppfuehrer.Text = "Truppführer:";
            // 
            // containerClassAtemschutz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "containerClassAtemschutz";
            this.Size = new System.Drawing.Size(1300, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mLabelValueTruppMann;
        private MaterialSkin.Controls.MaterialLabel mLabelValueTruppFuehrer;
        private MaterialSkin.Controls.MaterialLabel mLabelTruppMann;
        private MaterialSkin.Controls.MaterialLabel mLabelTruppfuehrer;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel mLabelValueSicherungsTruppMann;
        private MaterialSkin.Controls.MaterialLabel mLabelSicherungsTruppFuehrer;
        private MaterialSkin.Controls.MaterialLabel mLabelValueSicherungsTruppFuehrer;
        private MaterialSkin.Controls.MaterialLabel mLabelSicherungsTruppMann;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel mLabelStartTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel mLabelValueBottleFielPressureTruppMann;
        private MaterialSkin.Controls.MaterialLabel mLabelValueBottleFielPressureTruppFuehrer;
        private MaterialSkin.Controls.MaterialLabel mLabelValueBottleFielPressureSicherungsTruppMann;
        private MaterialSkin.Controls.MaterialLabel mLabelValueBottleFielPressureSicherungsTruppFuehrer;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
    }
}
