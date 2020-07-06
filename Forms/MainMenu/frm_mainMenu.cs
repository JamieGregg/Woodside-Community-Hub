using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace WoodsideCommunityHub
{
    public partial class dgv_showBookings : Form
    {
        userInterface menu;
        Booking methods = new Booking();

        public dgv_showBookings()
        {
            InitializeComponent();
            menu = new userInterface();
            menu.IsBookingClosed = true;
        }

        private void frm_mainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                //Loading the interface with the reports
                menu.loadIcons(pbx_children, pbx_booking, pbx_transport, pbx_staff, pbx_activities);
                loadingReports();
                
            }
            catch(SqlException)
            {
                //Asking if the user wants to progress without a connection
                DialogResult dialogResult = MessageBox.Show("There has been a database connection error \n do you wish to progress anyway?", "Connection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Not all features will load correctly");
                }
                //Returning the user to Log on screen
                else
                {
                    frm_logOn obj = new frm_logOn();
                    this.Close();
                    obj.Show();
                }
            }
            
        }

                                    //Menu System
                                    private void pbx_show_Click(object sender, EventArgs e)
                                    {
                                        menu.panelOpen(pnl_extended, pnL_hidden);
                                        menu.IsPanelOpen = false;
                                    }

                                    private void pbx_hide_Click(object sender, EventArgs e)
                                    {
                                        menu.panelClosed(pnl_extended, pnL_hidden);
                                        menu.IsPanelOpen = true;
                                    }
                                  
                                    private void btn_menuOne_Click(object sender, EventArgs e)
                                    {
                                        tmr_booking.Start();
                                    }

                                    private void btn_menuTwo_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_children obj = new frm_children(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void tmr_menuOne_Tick(object sender, EventArgs e)
                                    {
                                        menu.IsBookingClosed = menu.collapsableMenu(menu.IsBookingClosed, pnl_booking, tmr_booking, btn_children, btn_transport, btn_activities, btn_booking, btn_staff);
                                    }

                                    private void btn_menuThree_Click(object sender, EventArgs e)
                                    {

                                    }

                                    private void pbx_woodsideLogo_Click(object sender, EventArgs e)
                                    {

                                    }

                                    private void btn_transport_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_transport obj = new frm_transport(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void pictureBox3_Click(object sender, EventArgs e)
                                    {

                                    }

                                    private void pictureBox1_Click(object sender, EventArgs e)
                                    {

                                    }

                                    private void pbx_staff_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_staff.Image = Properties.Resources.staff_highlighted_copy_copy;
                                    }

                                    private void pbx_staff_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_staff.Image = Properties.Resources.staff_white;
                                    }

                                    private void pbx_activities_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_activities.Image = Properties.Resources.trophy_highlighted;
                                    }

                                    private void pbx_activities_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_activities.Image = Properties.Resources.trophy_white;
                                    }

                                    private void pbx_transport_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_transport.Image = Properties.Resources.transport_highlighted;
                                    }

                                    private void pbx_transport_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_transport.Image = Properties.Resources.transport_white;
                                    }

                                    private void pbx_children_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_children.Image = Properties.Resources.child_highlighted;
                                    }

                                    private void pbx_booking_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_booking.Image = Properties.Resources.booking_highlighted;
                                    }

                                    private void pbx_booking_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_booking.Image = Properties.Resources.booking_white;
                                    }

                                    private void pbx_children_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_children.Image = Properties.Resources.child_white1;
                                    }

                                    private void pbx_children_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_children obj = new frm_children(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void btn_staff_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_staff obj = new frm_staff(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void pbx_staff_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_staff obj = new frm_staff(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void pbx_transport_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_transport obj = new frm_transport(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void btn_activities_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        rpt_bookingCharts obj = new rpt_bookingCharts(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void pbx_activities_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        rpt_bookingCharts obj = new rpt_bookingCharts(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void pbx_booking_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_booking obj = new frm_booking(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void btn_m1Sub1_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_booking obj = new frm_booking(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

                                    private void btn_m1Sub2_Click(object sender, EventArgs e)
                                    {
                                        menu.IsPanelOpen = menu.checkPanel(pnl_extended);
                                        frm_ListOfBookings obj = new frm_ListOfBookings(ref menu);
                                        this.Hide();
                                        obj.Show();
                                    }

        //Loads the report in the center of the screen
        public void loadingReports()
        {
            //Loading in the report
            this.DataTable1TableAdapter.Fill(this.DatasetBookinfRecords.DataTable1);
            this.rpt_popularActivities.RefreshReport();
        }

        //Rollover Action on the buttons
        private void btn_createBooking_MouseEnter(object sender, EventArgs e)
        {
            btn_createBooking.Image = Properties.Resources.LightBooking;
        }

        //Rollover Action on the buttons
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.transportDark;
        }

        //Rollover Action on the buttons
        private void dgv_showBookings_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.LightTransportingMenu;
        }

        //Rollover Action on the buttons
        private void btn_viewBookings_MouseEnter(object sender, EventArgs e)
        {
            btn_viewBookings.Image = Properties.Resources.LightviewBookings;
        }

        //Rollover Action on the buttons
        private void btn_viewBookings_MouseLeave(object sender, EventArgs e)
        {
            btn_viewBookings.Image = Properties.Resources.darkViewBookings;
        }

        //Rollover Action on the buttons
        private void btn_createBooking_MouseLeave(object sender, EventArgs e)
        {
            btn_createBooking.Image = Properties.Resources.DarkBooking;
        }
    }
    
}
