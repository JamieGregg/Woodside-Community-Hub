namespace WoodsideCommunityHub
{
    partial class dgv_showBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dgv_showBookings));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetBookinfRecords = new WoodsideCommunityHub.DatasetBookinfRecords();
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
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tmr_booking = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btn_viewBookings = new System.Windows.Forms.Button();
            this.btn_createBooking = new System.Windows.Forms.Button();
            this.rpt_popularActivities = new Microsoft.Reporting.WinForms.ReportViewer();
            this.woodsideCommunityHub3ShowBookings = new WoodsideCommunityHub.woodsideCommunityHub3ShowBookings();
            this.ChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChildTableAdapter = new WoodsideCommunityHub.woodsideCommunityHub3ShowBookingsTableAdapters.ChildTableAdapter();
            this.DataTable1TableAdapter = new WoodsideCommunityHub.DatasetBookinfRecordsTableAdapters.DataTable1TableAdapter();
            this.DataSetBooking = new WoodsideCommunityHub.DataSetBooking();
            this.ActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityTableAdapter = new WoodsideCommunityHub.DataSetBookingTableAdapters.ActivityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetBookinfRecords)).BeginInit();
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
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woodsideCommunityHub3ShowBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityBindingSource)).BeginInit();
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
            this.pnl_extended.Location = new System.Drawing.Point(-2, 60);
            this.pnl_extended.Name = "pnl_extended";
            this.pnl_extended.Size = new System.Drawing.Size(231, 701);
            this.pnl_extended.TabIndex = 0;
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
            this.btn_children.Click += new System.EventHandler(this.btn_menuTwo_Click);
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
            this.btn_m1Sub2.Click += new System.EventHandler(this.btn_m1Sub2_Click);
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
            this.btn_booking.Click += new System.EventHandler(this.btn_menuOne_Click);
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
            this.pbx_woodsideLogo.Click += new System.EventHandler(this.pbx_woodsideLogo_Click);
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
            this.pnL_hidden.Location = new System.Drawing.Point(-2, 54);
            this.pnL_hidden.Name = "pnL_hidden";
            this.pnL_hidden.Size = new System.Drawing.Size(52, 709);
            this.pnL_hidden.TabIndex = 1;
            this.pnL_hidden.Visible = false;
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
            this.pbx_booking.Click += new System.EventHandler(this.pbx_booking_Click);
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
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Location = new System.Drawing.Point(-2, -2);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(1090, 63);
            this.pnl_topBar.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(412, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(304, 58);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "DASHBOARD";
            // 
            // tmr_booking
            // 
            this.tmr_booking.Interval = 5;
            this.tmr_booking.Tick += new System.EventHandler(this.tmr_menuOne_Tick);
            // 
            // button2
            // 
            this.button2.Image = global::WoodsideCommunityHub.Properties.Resources.LightTransportingMenu;
            this.button2.Location = new System.Drawing.Point(791, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 317);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.pbx_transport_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // btn_viewBookings
            // 
            this.btn_viewBookings.Image = global::WoodsideCommunityHub.Properties.Resources.LightviewBookings;
            this.btn_viewBookings.Location = new System.Drawing.Point(541, 349);
            this.btn_viewBookings.Name = "btn_viewBookings";
            this.btn_viewBookings.Size = new System.Drawing.Size(227, 316);
            this.btn_viewBookings.TabIndex = 6;
            this.btn_viewBookings.Text = " ";
            this.btn_viewBookings.UseVisualStyleBackColor = true;
            this.btn_viewBookings.Click += new System.EventHandler(this.btn_m1Sub2_Click);
            this.btn_viewBookings.MouseEnter += new System.EventHandler(this.btn_viewBookings_MouseEnter);
            this.btn_viewBookings.MouseLeave += new System.EventHandler(this.btn_viewBookings_MouseLeave);
            // 
            // btn_createBooking
            // 
            this.btn_createBooking.FlatAppearance.BorderSize = 0;
            this.btn_createBooking.Image = global::WoodsideCommunityHub.Properties.Resources.LightBooking;
            this.btn_createBooking.Location = new System.Drawing.Point(291, 348);
            this.btn_createBooking.Name = "btn_createBooking";
            this.btn_createBooking.Size = new System.Drawing.Size(223, 317);
            this.btn_createBooking.TabIndex = 5;
            this.btn_createBooking.UseVisualStyleBackColor = true;
            this.btn_createBooking.Click += new System.EventHandler(this.pbx_booking_Click);
            this.btn_createBooking.MouseEnter += new System.EventHandler(this.btn_createBooking_MouseEnter);
            this.btn_createBooking.MouseLeave += new System.EventHandler(this.btn_createBooking_MouseLeave);
            // 
            // rpt_popularActivities
            // 
            reportDataSource1.Name = "dashboard";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpt_popularActivities.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_popularActivities.LocalReport.ReportEmbeddedResource = "WoodsideCommunityHub.Reports.ShowBookingsMainMenu.rdlc";
            this.rpt_popularActivities.Location = new System.Drawing.Point(291, 84);
            this.rpt_popularActivities.Name = "rpt_popularActivities";
            this.rpt_popularActivities.ShowToolBar = false;
            this.rpt_popularActivities.Size = new System.Drawing.Size(729, 227);
            this.rpt_popularActivities.TabIndex = 8;
            this.rpt_popularActivities.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // woodsideCommunityHub3ShowBookings
            // 
            this.woodsideCommunityHub3ShowBookings.DataSetName = "woodsideCommunityHub3ShowBookings";
            this.woodsideCommunityHub3ShowBookings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataSetBooking
            // 
            this.DataSetBooking.DataSetName = "DataSetBooking";
            this.DataSetBooking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityBindingSource
            // 
            this.ActivityBindingSource.DataMember = "Activity";
            this.ActivityBindingSource.DataSource = this.DataSetBooking;
            // 
            // ActivityTableAdapter
            // 
            this.ActivityTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_showBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1080, 757);
            this.Controls.Add(this.rpt_popularActivities);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_viewBookings);
            this.Controls.Add(this.btn_createBooking);
            this.Controls.Add(this.pnl_topBar);
            this.Controls.Add(this.pnL_hidden);
            this.Controls.Add(this.pnl_extended);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dgv_showBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Woodside Community Hub";
            this.Load += new System.EventHandler(this.frm_mainMenu_Load);
            this.MouseLeave += new System.EventHandler(this.dgv_showBookings_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetBookinfRecords)).EndInit();
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
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woodsideCommunityHub3ShowBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_extended;
        private System.Windows.Forms.Panel pnL_hidden;
        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.PictureBox pbx_show;
        private System.Windows.Forms.PictureBox pbx_hide;
        private System.Windows.Forms.PictureBox pbx_woodsideLogo;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Button btn_children;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_booking;
        private System.Windows.Forms.Button btn_m1Sub2;
        private System.Windows.Forms.Button btn_m1Sub1;
        private System.Windows.Forms.Timer tmr_booking;
        private System.Windows.Forms.Button btn_transport;
        private System.Windows.Forms.Button btn_activities;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.PictureBox pbx_booking;
        private System.Windows.Forms.PictureBox pbx_staff;
        private System.Windows.Forms.PictureBox pbx_activities;
        private System.Windows.Forms.PictureBox pbx_transport;
        private System.Windows.Forms.PictureBox pbx_children;
        private System.Windows.Forms.Button btn_viewBookings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_createBooking;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_popularActivities;
        private System.Windows.Forms.BindingSource ChildBindingSource;
        private woodsideCommunityHub3ShowBookings woodsideCommunityHub3ShowBookings;
        private woodsideCommunityHub3ShowBookingsTableAdapters.ChildTableAdapter ChildTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DatasetBookinfRecords DatasetBookinfRecords;
        private DatasetBookinfRecordsTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource ActivityBindingSource;
        private DataSetBooking DataSetBooking;
        private DataSetBookingTableAdapters.ActivityTableAdapter ActivityTableAdapter;
    }
}