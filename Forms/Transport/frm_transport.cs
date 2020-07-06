using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WoodsideCommunityHub
{
    public partial class frm_transport : Form
    {
        userInterface interfaceClass;
        Booking booking = new Booking();
        bool isDetailsOpen = false;

        public frm_transport()
        {
            InitializeComponent();
        }

        public frm_transport(ref userInterface tempInterfaceClass)
        {
            InitializeComponent();
            interfaceClass = tempInterfaceClass;
        }

        private void frm_transport_Load(object sender, EventArgs e)
        {
            try
            {
                //Loading the interface 
                interfaceClass.loadIcons(pbx_children, pbx_booking, pbx_transport, pbx_staff, pbx_activities);
                interfaceClass.isPanelOpenLoad(pnl_extended, pnL_hidden, interfaceClass.IsPanelOpen);

                //Loading the Listboxes and the comboboxes
                populateCombobox();
                loadDataGridView();
        }
            catch(CustomException)
            {
                //Exception action defined in the class
            }
            catch
            {
                MessageBox.Show("There has been an issue loading this data, please contact a manager");
            }
        }

                                //Menu System
                                private void tmr_booking_Tick(object sender, EventArgs e)
                                {
                                    interfaceClass.IsBookingClosed = interfaceClass.collapsableMenu(interfaceClass.IsBookingClosed, pnl_booking, tmr_booking, btn_children, btn_transport, btn_activities, btn_booking, btn_staff);
                                }

                                private void pbx_woodsideLogo_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                    dgv_showBookings obj = new dgv_showBookings();
                                    this.Close();
                                    obj.Show();
                                }

                                private void btn_booking_Click(object sender, EventArgs e)
                                {
                                    tmr_booking.Start();
                                }

                                private void pbx_show_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.panelOpen(pnl_extended, pnL_hidden);
                                   // changeTextPosition(lbl_destination, lbl_travellingFrom, lbl_arrivalTime, true);
                                }

                                private void pbx_hide_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.panelClosed(pnl_extended, pnL_hidden);
                                    //changeTextPosition(lbl_destination, lbl_travellingFrom, lbl_arrivalTime, false);
                                }

                                private void btn_staff_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                    frm_staff obj = new frm_staff(ref interfaceClass);
                                    this.Close();
                                    obj.Show();
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

                                private void pbx_activities_MouseEnter(object sender, EventArgs e)
                                {
                                    pbx_activities.Image = Properties.Resources.trophy_highlighted;
                                }

                                private void pbx_activities_MouseLeave(object sender, EventArgs e)
                                {
                                    pbx_activities.Image = Properties.Resources.trophy_white;
                                }

                                private void pbx_staff_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                    frm_staff obj = new frm_staff(ref interfaceClass);
                                    this.Close();
                                    obj.Show();
                                }

                                private void pbx_staff_MouseEnter(object sender, EventArgs e)
                                {
                                    pbx_staff.Image = Properties.Resources.staff_highlighted_copy_copy;
                                }

                                private void pbx_staff_MouseLeave(object sender, EventArgs e)
                                {
                                    pbx_staff.Image = Properties.Resources.staff_white;

                                }

                                private void pbx_transport_MouseEnter(object sender, EventArgs e)
                                {
                                    pbx_transport.Image = Properties.Resources.transport_highlighted;
                                }

                                private void pbx_transport_MouseLeave(object sender, EventArgs e)
                                {
                                    pbx_transport.Image = Properties.Resources.transport_white;
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

                                private void pbx_booking_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                    frm_booking obj = new frm_booking(ref interfaceClass);
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

                                private void btn_m1Sub2_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                    frm_ListOfBookings obj = new frm_ListOfBookings(ref interfaceClass);
                                    this.Close();
                                    obj.Show();
                                }

        //populates the comboxes with bus tops and arrival times
        private void populateCombobox()
        {
            try
            {
                cbx_destination.Items.Add("Woodside Community Hub");

                SqlDataAdapter transport = new SqlDataAdapter("SELECT * FROM Transporting", Program.GetConnectionString());
                {
                    DataTable TransportingTable = new DataTable();
                    transport.Fill(TransportingTable);

                    cbx_travellingTo.Items.Add(TransportingTable.Rows[0]["stop1"]);
                    cbx_travellingTo.Items.Add(TransportingTable.Rows[0]["stop2"]);
                    cbx_travellingTo.Items.Add(TransportingTable.Rows[0]["stop3"]);
                    cbx_travellingTo.Items.Add(TransportingTable.Rows[0]["stop4"]);

                    for (int i = 0; i < TransportingTable.Rows.Count; i++)
                    {
                        cbx_busTimes.Items.Add(TransportingTable.Rows[i]["arrivalTime"]);
                    }
                }
            }
            catch
            {
                throw new CustomException();
            }
            
        }

        //searches the database for the driver of the bus based on the time of the bus 
        private void findBusDriver(string busTime)
        {
            SqlDataAdapter transport = new SqlDataAdapter("SELECT * FROM Transporting WHERE arrivalTime = " + busTime, Program.GetConnectionString());
            {
                DataTable TransportingTable = new DataTable();
                transport.Fill(TransportingTable);

                for (int i = 0; i < TransportingTable.Rows.Count; i++)
                {
                    lbl_driver.Text = Convert.ToString(TransportingTable.Rows[i]["driverName"]);
                    lbl_contactNumber.Text = Convert.ToString(TransportingTable.Rows[i]["driverContactNo"]);
                    lbl_noOfSeats.Text = Convert.ToString(TransportingTable.Rows[i]["noOfSeats"]);
                }
            }
        }

        //loading the data into the grid view showing the bus times
        private void loadDataGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.GetConnectionString()))
                {
                    using (SqlCommand commandStudentDetails = new SqlCommand("SELECT Child.childFirstname, Child.childSurname, Activity.acitivityName, Transporting.driverName, Transporting.driverContactNo, Transporting.arrivalTime, Booking.weekStart FROM Child INNER JOIN BookingChild ON Child.childId = BookingChild.childID INNER JOIN Booking ON BookingChild.bookingID = Booking.bookingID INNER JOIN Transporting ON Booking.transportId = Transporting.transportId INNER JOIN StaffBooking ON Booking.bookingID = StaffBooking.bookingId INNER JOIN Staff ON StaffBooking.staffId = Staff.staffId INNER JOIN Activity ON Booking.activityId = Activity.activityId", conn)) ;
                    using (SqlCommand commandDaysBooked = new SqlCommand("SELECT Booking.dayOne, Booking.dayTwo, Booking.DayThree, Booking.DayFour, Booking.DayFive FROM Booking", conn))
                    {
                        conn.Open();
                        Booking booking = new Booking();

                        //Creating the adapter holding the days booked
                        DataTable dtDaysBooked = new DataTable();
                        SqlDataAdapter adptDaysBooked = new SqlDataAdapter(commandDaysBooked);
                        adptDaysBooked.Fill(dtDaysBooked);

                        //Creating an adapter and table to store information on the student
                        DataTable DetailsofStudentTable = new DataTable();
                        SqlDataAdapter detailsAdapter = new SqlDataAdapter("SELECT Child.childFirstname, Child.childSurname, Transporting.arrivalTime, Booking.weekStart, Child.parentContactNo, Child.docotorName,Child.parentName, Transporting.driverName, Transporting.driverContactNo FROM Child INNER JOIN BookingChild ON Child.childId = BookingChild.childID INNER JOIN Booking ON BookingChild.bookingID = Booking.bookingID INNER JOIN Transporting ON Booking.transportId = Transporting.transportId INNER JOIN StaffBooking ON Booking.bookingID = StaffBooking.bookingId INNER JOIN Staff ON StaffBooking.staffId = Staff.staffId INNER JOIN Activity ON Booking.activityId = Activity.activityId", conn);
                        detailsAdapter.Fill(DetailsofStudentTable);

                        //Adding the columns into the DataGridView
                        DetailsofStudentTable.Columns["childFirstname"].ColumnName = "First Name";
                        DetailsofStudentTable.Columns["childSurname"].ColumnName = "Surname";
                        DetailsofStudentTable.Columns["arrivalTime"].ColumnName = "Arrival Time";
                        DetailsofStudentTable.Columns["weekStart"].ColumnName = "Week Starting";
                        DetailsofStudentTable.Columns["parentContactNo"].ColumnName = "Monday";
                        DetailsofStudentTable.Columns["docotorName"].ColumnName = "Tuesday";
                        DetailsofStudentTable.Columns["parentName"].ColumnName = "Wednesday";
                        DetailsofStudentTable.Columns["driverName"].ColumnName = "Thursday";
                        DetailsofStudentTable.Columns["driverContactNo"].ColumnName = "Friday";


                        int currentRow = 0;

                        //Looping to find if the chiild is booked in on a day
                        foreach (DataRow myrow in dtDaysBooked.Rows)
                        {
                            string dayOne = findDays(Convert.ToInt16((myrow["dayOne"])));
                            string dayTwo = findDays(Convert.ToInt16((myrow["dayTwo"])));
                            string dayThree = findDays(Convert.ToInt16((myrow["dayThree"])));
                            string dayFour = findDays(Convert.ToInt16((myrow["dayFour"])));
                            string dayFive = findDays(Convert.ToInt16((myrow["dayFive"])));

                            //Storinf the results of the day search overwiting the data already stored in the table
                            DataRow dr = DetailsofStudentTable.Rows[currentRow];
                            dr[4] = dayOne;
                            dr[5] = dayTwo;
                            dr[6] = dayThree;
                            dr[7] = dayFour;
                            dr[8] = dayFive;
                            currentRow++;
                        }

                        //Setting the datasource to the gridview and closing the database connection
                        dgv_transport.DataSource = DetailsofStudentTable;
                        conn.Close();
                    }
                }
            }
            catch
            {
                throw new CustomException();
            }
        }

        //Method used to find if a student is booked into a class that day
        private string findDays(int day)
        {
            //In SQL 0 stands for no booking
            if (day == 0)
            {
                return "No";
            }
            else
            {
                return "Yes";
            }
        }

        //searches for details about a bus route
        private void searchBusDetails()
        {
            //clearing the data in the boxes
            cbx_travellingTo.Items.Clear();
            cbx_busTimes.Items.Clear();

            //Readloading the data
            populateCombobox();

            //Hiding the panel
            pnl_details.Visible = false;
            isDetailsOpen = false;

            //Checks to see the bus time and journey length 
            if (cbx_busTimes.Text == "1200")
            {
                lbl_finishingTime.Text = "12:00";
                findBusDriver("1200");
                if (cbx_travellingTo.Text == "Lynne Rd")
                {
                    lbl_totalTime.Text = "1 Hour";
                    lbl_startingTime.Text = "11:00";
                }
                else if (cbx_travellingTo.Text == "Ashborne Rd")
                {
                    lbl_totalTime.Text = "32 Mins";
                    lbl_startingTime.Text = "11:28";
                }
                else if (cbx_travellingTo.Text == "Hillside Way")
                {
                    lbl_totalTime.Text = "24 Mins";
                    lbl_startingTime.Text = "11:36";
                }
                else if (cbx_travellingTo.Text == "Bloom Avenue")
                {
                    lbl_totalTime.Text = "14 Mins";
                    lbl_startingTime.Text = "11:46";
                }
            }
            else if (cbx_busTimes.Text == "1500")
            {
                lbl_finishingTime.Text = "15:00";
                findBusDriver("1500");
                if (cbx_travellingTo.Text == "Lynne Rd")
                {
                    lbl_totalTime.Text = "1 Hour";
                    lbl_startingTime.Text = "14:00";
                }
                else if (cbx_travellingTo.Text == "Ashborne Rd")
                {
                    lbl_totalTime.Text = "32 Mins";
                    lbl_startingTime.Text = "14:28";
                }
                else if (cbx_travellingTo.Text == "Hillside Way")
                {
                    lbl_totalTime.Text = "24 Mins";
                    lbl_startingTime.Text = "14:36";
                }
                else if (cbx_travellingTo.Text == "Bloom Avenue")
                {
                    lbl_totalTime.Text = "14 Mins";
                    lbl_startingTime.Text = "14:46";
                }
            }
        }

        //search data click event 
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                searchBusDetails();
            }
            catch (CustomException)
            {
                //Action defined in the custom class
            }
            catch
            {
                MessageBox.Show("There has been a searching error, please contact your system manager");
            }
                
        }

        //opens and closes the details about the bus driver
        private void btn_viewDetails_Click(object sender, EventArgs e)
        {
            if(isDetailsOpen == false)
            {
                pnl_details.Visible = true;
                isDetailsOpen = true;
                btn_showBusLists.Location = new Point(63, 590);
            }
            else
            {
                pnl_details.Visible = false;
                isDetailsOpen = false;
                btn_showBusLists.Location = new Point(63, 500);
            }
        }

        //changes the label position based on if the menu is open 
        private void changeTextPosition(Label destination, Label travellingFrom, Label time, bool isOpen)
        {
            if (isOpen == false)
            {
                destination.Location = new Point(225, 165);
                travellingFrom.Location = new Point(185, 235);
                time.Location = new Point(220, 300);
            }
            else
            {
                destination.Location = new Point(335, 136);
                travellingFrom.Location = new Point(335, 204);
                time.Location = new Point(335, 275);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pnl_busList.Visible = true;
            pnl_showBusDetails.Visible = false;
        }

        private void btm_return_Click(object sender, EventArgs e)
        {
            pnl_busList.Visible = false;
            pnl_showBusDetails.Visible = true;
        }

        private void btnm_return_Click(object sender, EventArgs e)
        {

        }

        private void btm_return_Click_1(object sender, EventArgs e)
        {
            pnl_busList.Visible = false;
            pnl_showBusDetails.Visible = true;
        }
    }
}
    

