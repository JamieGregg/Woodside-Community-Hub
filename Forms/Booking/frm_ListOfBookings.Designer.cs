namespace WoodsideCommunityHub
{
    partial class frm_ListOfBookings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListOfBookings));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetBookinfRecords = new WoodsideCommunityHub.DatasetBookinfRecords();
            this.BookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_extended = new System.Windows.Forms.Panel();
            this.btn_transport = new System.Windows.Forms.Button();
            this.btn_children = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.btn_activities = new System.Windows.Forms.Button();
            this.pnl_booking = new System.Windows.Forms.Panel();
            this.btn_m1Sub2 = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.btn_m1Sub1 = new System.Windows.Forms.Button();
            this.pbx_hide = new System.Windows.Forms.PictureBox();
            this.pbx_woodsideLogo = new System.Windows.Forms.PictureBox();
            this.pnL_hidden = new System.Windows.Forms.Panel();
            this.pbx_staff = new System.Windows.Forms.PictureBox();
            this.pbx_activities = new System.Windows.Forms.PictureBox();
            this.pbx_transport = new System.Windows.Forms.PictureBox();
            this.pbx_children = new System.Windows.Forms.PictureBox();
            this.pbx_booking = new System.Windows.Forms.PictureBox();
            this.pbx_show = new System.Windows.Forms.PictureBox();
            this.tmr_booking = new System.Windows.Forms.Timer(this.components);
            this.rpt_showBookings = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new WoodsideCommunityHub.DatasetBookinfRecordsTableAdapters.DataTable1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.woodsideCommunityHub3ShowBookings = new WoodsideCommunityHub.woodsideCommunityHub3ShowBookings();
            this.BookingTableAdapter = new WoodsideCommunityHub.woodsideCommunityHub3ShowBookingsTableAdapters.BookingTableAdapter();
            this.ChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChildTableAdapter = new WoodsideCommunityHub.woodsideCommunityHub3ShowBookingsTableAdapters.ChildTableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.childFirstNameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.childFirstNameToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DataSetBooking = new WoodsideCommunityHub.DataSetBooking();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetBookinfRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingBindingSource)).BeginInit();
            this.pnl_topBar.SuspendLayout();
            this.pnl_extended.SuspendLayout();
            this.pnl_booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_woodsideLogo)).BeginInit();
            this.pnL_hidden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_activities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_transport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_children)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_booking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodsideCommunityHub3ShowBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildBindingSource)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DatasetBookinfRecords;
            // 
            // DatasetBookinfRecords
            // 
            this.DatasetBookinfRecords.DataSetName = "DatasetBookinfRecords";
            this.DatasetBookinfRecords.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookingBindingSource
            // 
            this.BookingBindingSource.DataMember = "Booking";
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Location = new System.Drawing.Point(-1, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(1090, 63);
            this.pnl_topBar.TabIndex = 11;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(412, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(329, 58);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "BOOKING LIST";
            // 
            // pnl_extended
            // 
            this.pnl_extended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnl_extended.Controls.Add(this.btn_transport);
            this.pnl_extended.Controls.Add(this.btn_children);
            this.pnl_extended.Controls.Add(this.btn_staff);
            this.pnl_extended.Controls.Add(this.btn_activities);
            this.pnl_extended.Controls.Add(this.pnl_booking);
            this.pnl_extended.Controls.Add(this.pbx_hide);
            this.pnl_extended.Controls.Add(this.pbx_woodsideLogo);
            this.pnl_extended.Location = new System.Drawing.Point(-1, 62);
            this.pnl_extended.Name = "pnl_extended";
            this.pnl_extended.Size = new System.Drawing.Size(231, 701);
            this.pnl_extended.TabIndex = 10;
            this.pnl_extended.Visible = false;
            // 
            // btn_transport
            // 
            this.btn_transport.FlatAppearance.BorderSize = 0;
            this.btn_transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transport.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.btn_transport.ForeColor = System.Drawing.Color.Transparent;
            this.btn_transport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_transport.Location = new System.Drawing.Point(0, 275);
            this.btn_transport.Name = "btn_transport";
            this.btn_transport.Size = new System.Drawing.Size(229, 70);
            this.btn_transport.TabIndex = 7;
            this.btn_transport.Text = "    Transport";
            this.btn_transport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transport.UseVisualStyleBackColor = true;
            this.btn_transport.Click += new System.EventHandler(this.btn_transport_Click);
            // 
            // btn_children
            // 
            this.btn_children.FlatAppearance.BorderSize = 0;
            this.btn_children.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_children.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.btn_children.ForeColor = System.Drawing.Color.Transparent;
            this.btn_children.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_children.Location = new System.Drawing.Point(0, 212);
            this.btn_children.Name = "btn_children";
            this.btn_children.Size = new System.Drawing.Size(229, 64);
            this.btn_children.TabIndex = 7;
            this.btn_children.Text = "    Children";
            this.btn_children.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_children.UseVisualStyleBackColor = true;
            this.btn_children.Click += new System.EventHandler(this.btn_children_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.btn_staff.ForeColor = System.Drawing.Color.Transparent;
            this.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_staff.Location = new System.Drawing.Point(0, 405);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(230, 70);
            this.btn_staff.TabIndex = 7;
            this.btn_staff.Text = "    Staff";
            this.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.UseVisualStyleBackColor = true;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_activities
            // 
            this.btn_activities.FlatAppearance.BorderSize = 0;
            this.btn_activities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activities.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.btn_activities.ForeColor = System.Drawing.Color.Transparent;
            this.btn_activities.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_activities.Location = new System.Drawing.Point(0, 340);
            this.btn_activities.Name = "btn_activities";
            this.btn_activities.Size = new System.Drawing.Size(229, 70);
            this.btn_activities.TabIndex = 7;
            this.btn_activities.Text = "    Activities";
            this.btn_activities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_activities.UseVisualStyleBackColor = true;
            this.btn_activities.Click += new System.EventHandler(this.btn_activities_Click);
            // 
            // pnl_booking
            // 
            this.pnl_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnl_booking.Controls.Add(this.btn_m1Sub2);
            this.pnl_booking.Controls.Add(this.btn_booking);
            this.pnl_booking.Controls.Add(this.btn_m1Sub1);
            this.pnl_booking.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_booking.Location = new System.Drawing.Point(0, 150);
            this.pnl_booking.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_booking.MaximumSize = new System.Drawing.Size(250, 146);
            this.pnl_booking.MinimumSize = new System.Drawing.Size(250, 53);
            this.pnl_booking.Name = "pnl_booking";
            this.pnl_booking.Size = new System.Drawing.Size(250, 57);
            this.pnl_booking.TabIndex = 5;
            // 
            // btn_m1Sub2
            // 
            this.btn_m1Sub2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.btn_m1Sub2.FlatAppearance.BorderSize = 0;
            this.btn_m1Sub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_m1Sub2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m1Sub2.ForeColor = System.Drawing.Color.White;
            this.btn_m1Sub2.Location = new System.Drawing.Point(-4, 97);
            this.btn_m1Sub2.Name = "btn_m1Sub2";
            this.btn_m1Sub2.Size = new System.Drawing.Size(254, 41);
            this.btn_m1Sub2.TabIndex = 9;
            this.btn_m1Sub2.Text = "      List of Bookings";
            this.btn_m1Sub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_m1Sub2.UseVisualStyleBackColor = false;
            // 
            // btn_booking
            // 
            this.btn_booking.FlatAppearance.BorderSize = 0;
            this.btn_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_booking.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.btn_booking.ForeColor = System.Drawing.Color.Transparent;
            this.btn_booking.Image = ((System.Drawing.Image)(resources.GetObject("btn_booking.Image")));
            this.btn_booking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_booking.Location = new System.Drawing.Point(0, -6);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(231, 66);
            this.btn_booking.TabIndex = 6;
            this.btn_booking.Text = "    Booking";
            this.btn_booking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_booking.UseVisualStyleBackColor = true;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // btn_m1Sub1
            // 
            this.btn_m1Sub1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.btn_m1Sub1.FlatAppearance.BorderSize = 0;
            this.btn_m1Sub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_m1Sub1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m1Sub1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_m1Sub1.Location = new System.Drawing.Point(-4, 59);
            this.btn_m1Sub1.Name = "btn_m1Sub1";
            this.btn_m1Sub1.Size = new System.Drawing.Size(254, 41);
            this.btn_m1Sub1.TabIndex = 8;
            this.btn_m1Sub1.Text = "      Booking Menu";
            this.btn_m1Sub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_m1Sub1.UseVisualStyleBackColor = false;
            this.btn_m1Sub1.Click += new System.EventHandler(this.btn_m1Sub1_Click);
            // 
            // pbx_hide
            // 
            this.pbx_hide.Image = ((System.Drawing.Image)(resources.GetObject("pbx_hide.Image")));
            this.pbx_hide.Location = new System.Drawing.Point(163, 24);
            this.pbx_hide.Name = "pbx_hide";
            this.pbx_hide.Size = new System.Drawing.Size(66, 52);
            this.pbx_hide.TabIndex = 4;
            this.pbx_hide.TabStop = false;
            this.pbx_hide.Click += new System.EventHandler(this.pbx_hide_Click);
            // 
            // pbx_woodsideLogo
            // 
            this.pbx_woodsideLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_woodsideLogo.Image")));
            this.pbx_woodsideLogo.Location = new System.Drawing.Point(13, 92);
            this.pbx_woodsideLogo.Name = "pbx_woodsideLogo";
            this.pbx_woodsideLogo.Size = new System.Drawing.Size(218, 43);
            this.pbx_woodsideLogo.TabIndex = 5;
            this.pbx_woodsideLogo.TabStop = false;
            this.pbx_woodsideLogo.Click += new System.EventHandler(this.pbx_woodsideLogo_Click_1);
            // 
            // pnL_hidden
            // 
            this.pnL_hidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnL_hidden.Controls.Add(this.pbx_staff);
            this.pnL_hidden.Controls.Add(this.pbx_activities);
            this.pnL_hidden.Controls.Add(this.pbx_transport);
            this.pnL_hidden.Controls.Add(this.pbx_children);
            this.pnL_hidden.Controls.Add(this.pbx_booking);
            this.pnL_hidden.Controls.Add(this.pbx_show);
            this.pnL_hidden.Location = new System.Drawing.Point(0, 63);
            this.pnL_hidden.Name = "pnL_hidden";
            this.pnL_hidden.Size = new System.Drawing.Size(52, 709);
            this.pnL_hidden.TabIndex = 12;
            // 
            // pbx_staff
            // 
            this.pbx_staff.Location = new System.Drawing.Point(-7, 447);
            this.pbx_staff.Name = "pbx_staff";
            this.pbx_staff.Size = new System.Drawing.Size(69, 53);
            this.pbx_staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_staff.TabIndex = 7;
            this.pbx_staff.TabStop = false;
            this.pbx_staff.Click += new System.EventHandler(this.pbx_staff_Click);
            this.pbx_staff.MouseEnter += new System.EventHandler(this.pbx_staff_MouseEnter);
            this.pbx_staff.MouseLeave += new System.EventHandler(this.pbx_staff_MouseLeave);
            // 
            // pbx_activities
            // 
            this.pbx_activities.Location = new System.Drawing.Point(-6, 352);
            this.pbx_activities.Name = "pbx_activities";
            this.pbx_activities.Size = new System.Drawing.Size(67, 53);
            this.pbx_activities.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_activities.TabIndex = 6;
            this.pbx_activities.TabStop = false;
            this.pbx_activities.Click += new System.EventHandler(this.pbx_activities_Click);
            this.pbx_activities.MouseEnter += new System.EventHandler(this.pbx_activities_MouseEnter);
            this.pbx_activities.MouseLeave += new System.EventHandler(this.pbx_activities_MouseLeave);
            // 
            // pbx_transport
            // 
            this.pbx_transport.Location = new System.Drawing.Point(-7, 262);
            this.pbx_transport.Name = "pbx_transport";
            this.pbx_transport.Size = new System.Drawing.Size(69, 54);
            this.pbx_transport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_transport.TabIndex = 5;
            this.pbx_transport.TabStop = false;
            this.pbx_transport.Click += new System.EventHandler(this.pbx_transport_Click);
            this.pbx_transport.MouseEnter += new System.EventHandler(this.pbx_transport_MouseEnter);
            this.pbx_transport.MouseLeave += new System.EventHandler(this.pbx_transport_MouseLeave);
            // 
            // pbx_children
            // 
            this.pbx_children.Image = global::WoodsideCommunityHub.Properties.Resources.child_white1;
            this.pbx_children.Location = new System.Drawing.Point(-29, 156);
            this.pbx_children.Name = "pbx_children";
            this.pbx_children.Size = new System.Drawing.Size(113, 85);
            this.pbx_children.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_children.TabIndex = 4;
            this.pbx_children.TabStop = false;
            this.pbx_children.Click += new System.EventHandler(this.pbx_children_Click);
            this.pbx_children.MouseEnter += new System.EventHandler(this.pbx_children_MouseEnter);
            this.pbx_children.MouseLeave += new System.EventHandler(this.pbx_children_MouseLeave);
            // 
            // pbx_booking
            // 
            this.pbx_booking.Location = new System.Drawing.Point(-5, 80);
            this.pbx_booking.Name = "pbx_booking";
            this.pbx_booking.Size = new System.Drawing.Size(63, 53);
            this.pbx_booking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_booking.TabIndex = 2;
            this.pbx_booking.TabStop = false;
            this.pbx_booking.MouseEnter += new System.EventHandler(this.pbx_booking_MouseEnter);
            this.pbx_booking.MouseLeave += new System.EventHandler(this.pbx_booking_MouseLeave);
            // 
            // pbx_show
            // 
            this.pbx_show.Image = ((System.Drawing.Image)(resources.GetObject("pbx_show.Image")));
            this.pbx_show.Location = new System.Drawing.Point(5, 11);
            this.pbx_show.Name = "pbx_show";
            this.pbx_show.Size = new System.Drawing.Size(50, 47);
            this.pbx_show.TabIndex = 1;
            this.pbx_show.TabStop = false;
            this.pbx_show.Click += new System.EventHandler(this.pbx_show_Click);
            // 
            // tmr_booking
            // 
            this.tmr_booking.Interval = 5;
            this.tmr_booking.Tick += new System.EventHandler(this.tmr_booking_Tick);
            // 
            // rpt_showBookings
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpt_showBookings.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_showBookings.LocalReport.ReportEmbeddedResource = "WoodsideCommunityHub.Reports.bookings.rdlc";
            this.rpt_showBookings.Location = new System.Drawing.Point(320, 207);
            this.rpt_showBookings.Name = "rpt_showBookings";
            this.rpt_showBookings.ShowBackButton = false;
            this.rpt_showBookings.ShowContextMenu = false;
            this.rpt_showBookings.ShowCredentialPrompts = false;
            this.rpt_showBookings.ShowDocumentMapButton = false;
            this.rpt_showBookings.ShowExportButton = false;
            this.rpt_showBookings.ShowFindControls = false;
            this.rpt_showBookings.ShowPageNavigationControls = false;
            this.rpt_showBookings.ShowParameterPrompts = false;
            this.rpt_showBookings.ShowPrintButton = false;
            this.rpt_showBookings.ShowProgress = false;
            this.rpt_showBookings.ShowPromptAreaButton = false;
            this.rpt_showBookings.Size = new System.Drawing.Size(666, 445);
            this.rpt_showBookings.TabIndex = 12;
            this.rpt_showBookings.Load += new System.EventHandler(this.rpt_showBookings_Load);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "List of Bookings for the Upcoming Weeks";
            // 
            // woodsideCommunityHub3ShowBookings
            // 
            this.woodsideCommunityHub3ShowBookings.DataSetName = "woodsideCommunityHub3ShowBookings";
            this.woodsideCommunityHub3ShowBookings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookingTableAdapter
            // 
            this.BookingTableAdapter.ClearBeforeFill = true;
            // 
            // ChildBindingSource
            // 
            this.ChildBindingSource.DataMember = "Child";
            this.ChildBindingSource.DataSource = this.woodsideCommunityHub3ShowBookings;
            // 
            // ChildTableAdapter
            // 
            this.ChildTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.childFirstNameToolStripLabel1,
            this.childFirstNameToolStripTextBox1,
            this.fillByToolStripButton1,
            this.toolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(320, 179);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(302, 25);
            this.fillByToolStrip1.TabIndex = 15;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            this.fillByToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByToolStrip1_ItemClicked);
            // 
            // childFirstNameToolStripLabel1
            // 
            this.childFirstNameToolStripLabel1.Name = "childFirstNameToolStripLabel1";
            this.childFirstNameToolStripLabel1.Size = new System.Drawing.Size(98, 22);
            this.childFirstNameToolStripLabel1.Text = "Child First Name:";
            // 
            // childFirstNameToolStripTextBox1
            // 
            this.childFirstNameToolStripTextBox1.Name = "childFirstNameToolStripTextBox1";
            this.childFirstNameToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.AutoSize = false;
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.fillByToolStripButton1.Text = "Run Query";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // DataSetBooking
            // 
            this.DataSetBooking.DataSetName = "DataSetBooking";
            this.DataSetBooking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_ListOfBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.pnL_hidden);
            this.Controls.Add(this.pnl_extended);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpt_showBookings);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ListOfBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Woodside Community Hub";
            this.Load += new System.EventHandler(this.frm_ListOfBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetBookinfRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingBindingSource)).EndInit();
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            this.pnl_extended.ResumeLayout(false);
            this.pnl_booking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_woodsideLogo)).EndInit();
            this.pnL_hidden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_activities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_transport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_children)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_booking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodsideCommunityHub3ShowBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildBindingSource)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_extended;
        private System.Windows.Forms.Button btn_transport;
        private System.Windows.Forms.Button btn_children;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_activities;
        private System.Windows.Forms.Panel pnl_booking;
        private System.Windows.Forms.Button btn_m1Sub2;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Button btn_m1Sub1;
        private System.Windows.Forms.PictureBox pbx_hide;
        private System.Windows.Forms.PictureBox pbx_woodsideLogo;
        private System.Windows.Forms.Timer tmr_booking;
        private System.Windows.Forms.Panel pnL_hidden;
        private System.Windows.Forms.PictureBox pbx_staff;
        private System.Windows.Forms.PictureBox pbx_activities;
        private System.Windows.Forms.PictureBox pbx_transport;
        private System.Windows.Forms.PictureBox pbx_children;
        private System.Windows.Forms.PictureBox pbx_booking;
        private System.Windows.Forms.PictureBox pbx_show;
        private System.Windows.Forms.BindingSource BookingBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_showBookings;
        private woodsideCommunityHub3ShowBookings woodsideCommunityHub3ShowBookings;
        private woodsideCommunityHub3ShowBookingsTableAdapters.BookingTableAdapter BookingTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DatasetBookinfRecords DatasetBookinfRecords;
        private DatasetBookinfRecordsTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ChildBindingSource;
        private woodsideCommunityHub3ShowBookingsTableAdapters.ChildTableAdapter ChildTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel childFirstNameToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox childFirstNameToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DataSetBooking DataSetBooking;
    }
}