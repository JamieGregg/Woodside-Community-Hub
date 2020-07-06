using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodsideCommunityHub
{
    public partial class frm_ListOfBookings : Form
    {
        userInterface interfaceClass;

        public frm_ListOfBookings()
        {
            InitializeComponent();
        }

        public frm_ListOfBookings(ref userInterface tempUserInterface)
        {
            InitializeComponent();
            interfaceClass = tempUserInterface;
        }

        private void frm_ListOfBookings_Load(object sender, EventArgs e)
        {
            try
            {
                //Loading the interface 
                interfaceClass.loadIcons(pbx_children, pbx_booking, pbx_transport, pbx_staff, pbx_activities);
                interfaceClass.isPanelOpenLoad(pnl_extended, pnL_hidden, interfaceClass.IsPanelOpen);

                //Loading the Report
                loadReport();
            }
            catch(CustomException)
            {
                //Action defined the Custom Exception Class
            }

            catch
            {
                MessageBox.Show("There has been an issue loading this data, please contact a manager");
            }

        }

                                    //Menu Systems
                                    private void btn_booking_Click(object sender, EventArgs e)
                                    {
                                        tmr_booking.Start();
                                    }

                                    private void tmr_booking_Tick(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsBookingClosed = interfaceClass.collapsableMenu(interfaceClass.IsBookingClosed, pnl_booking, tmr_booking, btn_children, btn_transport, btn_activities, btn_booking, btn_staff);
                                    }

                                    private void pbx_show_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.panelOpen(pnl_extended, pnL_hidden);
                                    }

                                    private void pbx_hide_Click(object sender, EventArgs e)
                                    {
                                        pnL_hidden.Visible = true;
                                        pnl_extended.Visible = false;
                                    }

                                    private void pbx_booking_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_booking.Image = Properties.Resources.booking_highlighted;

                                    }

                                    private void pbx_booking_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_booking.Image = Properties.Resources.booking_white;

                                    }

                                    private void pbx_children_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_children.Image = Properties.Resources.child_highlighted;

                                    }

                                    private void pbx_children_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_children.Image = Properties.Resources.child_white1;
                                    }

                                    private void pbx_transport_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_transport.Image = Properties.Resources.transport_highlighted;
                                    }

                                    private void pbx_transport_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_transport.Image = Properties.Resources.transport_white;
                                    }

                                    private void pbx_activities_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_activities.Image = Properties.Resources.trophy_highlighted;
                                    }

                                    private void pbx_activities_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_activities.Image = Properties.Resources.trophy_white;
                                    }

                                    private void pbx_staff_MouseEnter(object sender, EventArgs e)
                                    {
                                        pbx_staff.Image = Properties.Resources.staff_highlighted_copy_copy;
                                    }

                                    private void pbx_staff_MouseLeave(object sender, EventArgs e)
                                    {
                                        pbx_staff.Image = Properties.Resources.staff_white;
                                    }

                                    private void btn_children_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_children obj = new frm_children(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void pbx_children_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_children obj = new frm_children(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void btn_transport_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_transport obj = new frm_transport(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void pbx_transport_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_transport obj = new frm_transport(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void btn_activities_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        rpt_bookingCharts obj = new rpt_bookingCharts(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void pbx_activities_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        rpt_bookingCharts obj = new rpt_bookingCharts(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void pbx_staff_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_staff obj = new frm_staff(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void btn_staff_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_staff obj = new frm_staff(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void btn_m1Sub1_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_booking obj = new frm_booking(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void dpt_showBookings_Load(object sender, EventArgs e)
                                    {


                                    }

                                    private void rpt_showBookings_Load(object sender, EventArgs e)
                                    {
                                        this.BookingTableAdapter.Fill(this.woodsideCommunityHub3ShowBookings.Booking);
                                        rpt_showBookings.Refresh();
                                    }

                                    private void fillByToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
                                    {

                                    }

                                    private void pbx_woodsideLogo_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        dgv_showBookings obj = new dgv_showBookings();
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void pbx_woodsideLogo_Click_1(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        dgv_showBookings obj = new dgv_showBookings();
                                        this.Close();
                                        obj.Show();

                                    }

        //Filters Results based on a childs first names
        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataTable1TableAdapter.FillBy(this.DatasetBookinfRecords.DataTable1, childFirstNameToolStripTextBox1.Text);
                rpt_showBookings.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //Loading the report
        private void loadReport()
        {
            try
            {
                this.DataTable1TableAdapter.Fill(this.DatasetBookinfRecords.DataTable1);
                this.rpt_showBookings.RefreshReport();
            }
            catch
            {
                throw new CustomException();
            }
        }
    }
}
