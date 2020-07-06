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
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;

namespace WoodsideCommunityHub
{
    public partial class frm_booking : Form
    {
        userInterface interfaceClass;
        string sqlBooking;
        DataTable bookingTable;
        DataTable bookingStaffTable;
        DataTable bookingChildTable;
        SqlCommandBuilder sqlBuilder;
        SqlDataAdapter bookingAdapter;
        SqlDataAdapter childAdapter;
        SqlDataAdapter staffAdapter;
        Booking updated = new Booking();
        StaffBooking updatedStaff = new StaffBooking();
        BookingChild updatedChild = new BookingChild();
        Booking methods = new Booking();

        public frm_booking()
        {
            InitializeComponent();
        }

        public frm_booking(ref userInterface tempUserInterface)
        {
            InitializeComponent();
            interfaceClass = tempUserInterface;
        }

        private void frm_booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            //rpt_invoice.Refresh();

            //Loading icons, populating comboboxes and checking if the menu panel is expanded
            interfaceClass.loadIcons(pbx_children, pbx_booking, pbx_transport, pbx_staff, pbx_activities);
            interfaceClass.isPanelOpenLoad(pnl_extended, pnL_hidden, interfaceClass.IsPanelOpen);
            methods.populateCombobox(cbx_selectedBooking, cbx_childName, cbx_activityName, cbx_staffMember);

            //Loading the dates into the comboboxes
            loadWeekStarts();

            //Reading the tables needed for a booking 
            ReadTable();

            //Populating the listbox
            loadBookings();

            //Loading in the bus times
            loadTransportCombobox();

            txt_amountOwed.Text = methods.pricing(methods.findActivityCost(methods.findActivityId(cbx_activityName.Text)), cbx_monday, cbx_tuesday, cbx_wednesday, cbx_thursday, cbx_friday);
            
        }

        //Timer for the drop down menu section
        private void tmr_booking_Tick(object sender, EventArgs e)
        {
            interfaceClass.IsBookingClosed = interfaceClass.collapsableMenu(interfaceClass.IsBookingClosed, pnl_booking, tmr_booking, btn_children, btn_transport, btn_activities, btn_booking, btn_staff);
        }



        //MENU SYSTEM BUTTON CLICKS
                                    private void btn_booking_Click(object sender, EventArgs e)
                                    {
                                        tmr_booking.Start();
                                    }

                                    private void pbx_show_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.panelOpen(pnl_extended, pnL_hidden);
                                    }

                                    private void pbx_hide_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.panelClosed(pnl_extended, pnL_hidden);
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

                                    private void pbx_children_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_children obj = new frm_children(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void btn_children_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_children obj = new frm_children(ref interfaceClass);
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

                                    private void btn_transport_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_transport obj = new frm_transport(ref interfaceClass);
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

                                    private void btn_activities_Click(object sender, EventArgs e)
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

                                    private void pbx_woodsideLogo_Click(object sender, EventArgs e)
                                    {

                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        dgv_showBookings obj = new dgv_showBookings();
                                        this.Close();
                                        obj.Show();
                                    }

                                    private void btn_m1Sub2_Click(object sender, EventArgs e)
                                    {
                                        interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                        frm_ListOfBookings obj = new frm_ListOfBookings();
                                        this.Close();
                                        obj.Show();
                                    }



        //DELETE
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //DELETE
        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Button Click Event
        private void btn_addStaff_Click(object sender, EventArgs e)
        {
            pnl_order.Visible = false;
            //pnl_payment.Visible = true;
        }

        private void btn_saveEdits_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Program.GetConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmdBooking = new SqlCommand("UPDATE Booking SET Booking.weekStart =@weekStart, Booking.activityId =@actId, Booking.dayOne =@dayOne, Booking.dayTwo =@dayTwo, Booking.dayThree =@dayThree, Booking.dayFour =@dayFour, Booking.dayFive=@dayFive WHERE bookingId=@Id", conn))
                using (SqlCommand cmdBookingChild = new SqlCommand("UPDATE BookingChild SET BookingChild.childID =@childId WHERE bookingId=@Id", conn))
                using (SqlCommand cmdBookingStaff = new SqlCommand("UPDATE StaffBooking SET StaffBooking.staffId =@staffId WHERE bookingId=@Id", conn))
                {
                    try
                    {

                        string firstName = methods.findChildFirstName(cbx_childName.Text);
                        int childId = methods.findChildId(firstName);

                        int activityId = methods.findActivityId(cbx_activityName.Text);
                        string staffFirstName = methods.findChildFirstName(cbx_staffMember.Text);
                        int staffId = methods.findStaffId(staffFirstName);

                        int dayOne = 0;
                        int dayTwo = 0;
                        int dayThree = 0;
                        int dayFour = 0;
                        int dayFive = 0;

                        if (cbx_monday.Checked == true)
                        {
                            dayOne = 1;
                        }

                        if (cbx_tuesday.Checked == true)
                        {
                            dayTwo = 2;
                        }

                        if (cbx_wednesday.Checked == true)
                        {
                            dayThree = 3;
                        }

                        if (cbx_thursday.Checked == true)
                        {
                            dayFour = 4;

                        }

                        if (cbx_friday.Checked == true)
                        {
                            dayOne = 5;
                        }

                        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Update Record", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            cmdBooking.Parameters.AddWithValue("@Id", Convert.ToInt16(lbl_id.Text));
                            cmdBookingChild.Parameters.AddWithValue("@Id", Convert.ToInt16(lbl_id.Text));
                            cmdBookingStaff.Parameters.AddWithValue("@Id", Convert.ToInt16(lbl_id.Text));
                            cmdBookingChild.Parameters.AddWithValue("@childId", Convert.ToString(childId));
                            cmdBookingStaff.Parameters.AddWithValue("@staffId", Convert.ToString(staffId));
                            cmdBooking.Parameters.AddWithValue("@actId", Convert.ToString(activityId));
                            cmdBooking.Parameters.AddWithValue("@weekStart", dtp_weekStart.Value);
                            cmdBooking.Parameters.AddWithValue("@dayOne", Convert.ToString(dayOne));
                            cmdBooking.Parameters.AddWithValue("@dayTwo", Convert.ToString(dayTwo));
                            cmdBooking.Parameters.AddWithValue("@dayThree", Convert.ToString(dayThree));
                            cmdBooking.Parameters.AddWithValue("@dayFour", Convert.ToString(dayFour));
                            cmdBooking.Parameters.AddWithValue("@dayFive", Convert.ToString(dayFive));

                            cmdBooking.ExecuteNonQuery();
                            cmdBookingChild.ExecuteNonQuery();
                            cmdBookingStaff.ExecuteNonQuery();

                            MessageBox.Show("Booking Information Updated");
                            clearData();
                            loadBookings();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An error as occured");
                    }
                }
            }
        }

        //DELETE
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //DELETE
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //DELETE
        private void label10_Click(object sender, EventArgs e)
        {

        }

        //DELETE
        private void label11_Click(object sender, EventArgs e)
        {

        }

        //DELETE
        private void label12_Click(object sender, EventArgs e)
        {

        }

        //DELETE
        private void label7_Click(object sender, EventArgs e)
        {

        }

        //DELETE
        private void pnl_payment_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btn_bookingPaid_Click(object sender, EventArgs e)
        {
            pnl_order.Visible = true;
        }

        //Finds the cost of the selected activity
        private void cbx_activityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = methods.findActivityId(cbx_activityName.Text);
            double cost = methods.findActivityCost(id);
            Convert.ToString(cost);
        }

        //DELETE
        private void cbx_childName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Changes price if monday is checked
        private void cbx_monday_CheckedChanged(object sender, EventArgs e)
        {
            txt_amountOwed.Text = methods.pricing(methods.findActivityCost(methods.findActivityId(cbx_activityName.Text)), cbx_monday, cbx_tuesday, cbx_wednesday, cbx_thursday, cbx_friday);
        }

        //DELETE
        private void pnl_order_Paint(object sender, PaintEventArgs e)
        {

        }

        //DELETE
        private void dtp_weekStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        //Clears the textboxes and checkboxes
        private void clearData()
        {
            txt_amountOwed.Text = "";
            cbx_activityName.SelectedIndex = -1;
            cbx_selectedBooking.Text = "";
            cbx_staffMember.SelectedIndex = -1;
            cbx_childName.SelectedIndex = -1;
            cbx_dayNumber.SelectedIndex = -1;
            cbx_year.SelectedIndex = -1;
            cbx_month.SelectedIndex = -1;
            cbx_friday.Checked = false;
            cbx_thursday.Checked = false;
            cbx_wednesday.Checked = false;
            cbx_tuesday.Checked = false;
            cbx_monday.Checked = false;
        }

        //Validates the data
        private bool validation()
        {
            //Tests the validation of all the booking table fields
            pbx_childName.Visible = false;
            pbx_activityName.Visible = false;
            pbx_amountOwed.Visible = false;
            pbx_weekStart.Visible = false;
            pbx_staffMember.Visible = false;
            bool isValid = false;

            if (cbx_year.Text == "" || cbx_month.Text == "" || cbx_dayNumber.Text == "")
            {
                pbx_weekStart.Visible = true;
                isValid = false;
            }
            if (cbx_childName.Text == "")
            {
                pbx_childName.Visible = true;
                isValid = false;
            }
            if (cbx_staffMember.Text == "")
            {
                pbx_staffMember.Visible = true;
                isValid = false;
            }
            if (cbx_activityName.Text == "")
            {
                pbx_activityName.Visible = true;
                isValid = false;
            }
            if (Convert.ToInt16(txt_amountOwed.Text) == 0 || txt_amountOwed.Text == "")
            {
                pbx_amountOwed.Visible = true;
                isValid = false;
            }
            if (dtp_weekStart.Value < DateTime.Now)
            {
                dtp_weekStart.Visible = true;
                isValid = false;
            }

            if (pbx_activityName.Visible == false && pbx_staffMember.Visible == false && pbx_childName.Visible == false && pbx_amountOwed.Visible == false && pbx_weekStart.Visible == false)
            {
                pbx_staffMember.Visible = false;
                pbx_activityName.Visible = false;
                pbx_childName.Visible = false;
                pbx_weekStart.Visible = false;
                pbx_amountOwed.Visible = false;

                isValid = true;
            }
            return isValid;

        }

        //Hiding the order screen and moving to the payment screen
        private void btn_goToPayment_Click(object sender, EventArgs e)
        {
            try
            {
                dtp_dateConfimation.Value = new DateTime(2019, findDate(cbx_month.Text), Convert.ToInt16(cbx_dayNumber.Text));
                dtp_weekStart.Value = dtp_dateConfimation.Value;

                //This is testing if the fields are valid before progressing to the payment screen
                if (validation() == false)
                {
                    MessageBox.Show("Please format all data correctly");
                }
                else if(doubleBooking() == true)
                {
                    MessageBox.Show("This booking already exsists");
                }
                else 
                {
                    pnl_order.Visible = false;
                    pnl_payment.Visible = true;

                    //Assiging values from one panel to another so that user can confirm that it is accurate 
                    lbl_activityLabel.Text = cbx_activityName.Text;
                    lbl_childLabel.Text = cbx_childName.Text;
                    lbl_staffLabel.Text = cbx_staffMember.Text;
                    lbl_totalCostLabel.Text = txt_amountOwed.Text;
                }
            }
            catch
            {            
                MessageBox.Show("Check your date, Is it in the past?");
            }
        }

        //Fills textboxes with data from an item selected from the listbox at top of screen
        private void cbx_selectedBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter bookingAdapter = new SqlDataAdapter("SELECT * FROM Booking, BookingChild, StaffBooking WHERE Booking.bookingID = " + methods.findBookingId(cbx_selectedBooking.Text), Program.GetConnectionString());
            {
                DataTable bookingTable = new DataTable();
                bookingAdapter.Fill(bookingTable);

                //Formatting data 
                double cost = methods.findActivityCost(methods.findActivityId(cbx_activityName.Text));
                decimal d = Convert.ToDecimal(cost);
                string d_format = string.Format("{0:f2}", d);
                txt_amountOwed.Text = d_format;

                string activityNames;
                string staffNames;
                DateTime dayTimes;
                string childname = " ";

                //Finding names and IDs of data needed
                int childId = methods.findChildrenId(cbx_selectedBooking.Text);
                childname = methods.findChildName(childId);
                clearData();
                string surname = methods.findChildSurname(childname);
                activityNames = methods.findActivityName(Convert.ToInt32(bookingTable.Rows[0]["activityId"]));
                int staffId = methods.findStaffId(Convert.ToInt32(bookingTable.Rows[0]["bookingId"]));
                staffNames = methods.findStaffName(staffId);
                string staffSurname = methods.findStaffSurname(staffNames);

                //Adding Date & checking textboxes if day was booked
                dayTimes = Convert.ToDateTime(bookingTable.Rows[0]["weekStart"]);
                daysBooked((Convert.ToInt32(bookingTable.Rows[0]["dayOne"])));
                daysBooked((Convert.ToInt32(bookingTable.Rows[0]["dayTwo"])));
                daysBooked((Convert.ToInt32(bookingTable.Rows[0]["dayThree"])));
                daysBooked((Convert.ToInt32(bookingTable.Rows[0]["dayFour"])));
                daysBooked((Convert.ToInt32(bookingTable.Rows[0]["dayFive"])));

                int month = findMonth(dayTimes);
                string monthName = findMonthName(month);

                cbx_dayNumber.Text = Convert.ToString(dayTimes.Day);
                cbx_month.Text = Convert.ToString(monthName);
                cbx_year.Text = "2019";

                //Setting values in class to compare if any data has been changed later on (EG for saving data)
                updated.BookingID = Convert.ToInt16(bookingTable.Rows[0]["bookingId"]);
                updated.WeekStart = Convert.ToDateTime(bookingTable.Rows[0]["weekStart"]);
                updated.DayOne = (Convert.ToInt32(bookingTable.Rows[0]["dayOne"]));
                updated.DayTwo = (Convert.ToInt32(bookingTable.Rows[0]["dayTwo"]));
                updated.DayThree = (Convert.ToInt32(bookingTable.Rows[0]["dayThree"]));
                updated.DayFour = (Convert.ToInt32(bookingTable.Rows[0]["dayFour"]));
                updated.DayFive = (Convert.ToInt32(bookingTable.Rows[0]["dayFive"]));
                updated.ActivityId = (Convert.ToInt32(bookingTable.Rows[0]["activityId"]));
                updatedStaff.StaffId = staffId;
                updatedChild.ChildId = childId;

                //Setting values into the textboxes
                lbl_id.Text = Convert.ToString(bookingTable.Rows[0]["bookingId"]);
                cbx_activityName.Text = activityNames;
                cbx_childName.Text = childname + " " + surname;
                cbx_staffMember.Text = staffNames + " " + staffSurname;
                dtp_weekStart.Value = dayTimes;
               
                txt_amountOwed.Text = methods.pricing(methods.findActivityCost(methods.findActivityId(cbx_activityName.Text)), cbx_monday, cbx_tuesday, cbx_wednesday, cbx_thursday, cbx_friday);
            }

        }

        //DELETE NO PURPOSE
        private void cbx_selectedBooking_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Ensures that price is 2 decimal places
        private void txt_amountOwed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(txt_amountOwed.Text, @"\.\d\d") && e.KeyChar != 8)

            {
                e.Handled = true;
            }
        }

        //Generic method for pricing of the activities alongside days booked with travel
        private void cbx_daySelected_checkedChanged(object sender, EventArgs e)
        {
            txt_amountOwed.Text = methods.pricing(methods.findActivityCost(methods.findActivityId(cbx_activityName.Text)), cbx_monday, cbx_tuesday, cbx_wednesday, cbx_thursday, cbx_friday);
        }

        //Updates the total cost if the user needs transportation 
        private void cbx_transport_CheckedChanged(object sender, EventArgs e)
        {
            bool boolMonday = false;
            bool boolTuesday = false;
            bool boolWednesday = false;
            bool boolThursday = false;
            bool boolFriday = false;

            double runningCost = 0;
            double cost = 0.5;

            if (cbx_monday.Checked == true)
            {
                runningCost += cost;
                boolMonday = true;
            }
            else if (cbx_monday.Checked = false && boolMonday == true)
            {
                runningCost = -cost;
                boolMonday = false;
            }

            if (cbx_tuesday.Checked == true)
            {
                runningCost += cost;
                boolTuesday = true;
            }
            else if (cbx_tuesday.Checked == true && boolTuesday == true)
            {
                runningCost -= cost;
                boolTuesday = false;
            }

            if (cbx_wednesday.Checked == true)
            {
                runningCost += cost;
                boolTuesday = true;
            }
            else if (cbx_wednesday.Checked == true && boolWednesday == true)
            {
                runningCost -= cost;
                boolWednesday = false;
            }

            if (cbx_thursday.Checked == true)
            {
                runningCost += cost;
                boolThursday = true;
            }
            else if (cbx_thursday.Checked == true && boolThursday == true)
            {
                runningCost -= cost;
                boolThursday = false;
            }

            if (cbx_friday.Checked == true)
            {
                runningCost += cost;
                boolFriday = true;
            }
            else if (cbx_friday.Checked == true && boolFriday == true)
            {
                runningCost -= cost;
                boolFriday = false;
            }

            double total = Convert.ToDouble(txt_amountOwed.Text) + runningCost;
            txt_amountOwed.Text = Convert.ToString(total);
        }

        //Assigns numerical values to comboboxes showing days available to be booked
        public void daysBooked(int day)
        {
            if (day == 1)
            {
                cbx_monday.Checked = true;
            }
            else if (day == 2)
            {
                cbx_tuesday.Checked = true;
            }
            else if (day == 3)
            {
                cbx_wednesday.Checked = true;
            }
            else if (day == 4)
            {
                cbx_thursday.Checked = true;
            }
            else if (day == 5)
            {
                cbx_friday.Checked = true;
            }
        }

        //DELETE
        private void cbx_thursday_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btn_detailedSearch_Click(object sender, EventArgs e)
        {
            interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
            frm_ListOfBookings obj = new frm_ListOfBookings();
            this.Close();
            obj.Show();
        }

        //Deletes a record
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (validation() == true)
                {
                    deleteRecord();
                }
                else
                {
                    MessageBox.Show("There has been an issue cancelling this booking");
                }
            }
            catch
            {
                MessageBox.Show("There has been an issue cancelling this booking");
            }
            
            
        }

        //Adds the booking to the database
        private void addBooking()
        {
            DataRow newRow = bookingTable.NewRow();
            DataRow newRowStaff = bookingStaffTable.NewRow();
            DataRow newRowChild = bookingChildTable.NewRow();

            Booking booking = new Booking();
            BookingChild bookingChild = new BookingChild();
            StaffBooking bookingStaff = new StaffBooking();

            //methods finding names/Ids of fields 
            string childFirstName = booking.findChildFirstName(cbx_childName.Text);
            int childId = booking.findChildId(childFirstName);
            int activityId = booking.findActivityId(cbx_activityName.Text);
            string staffFirstname = booking.findChildFirstName(cbx_staffMember.Text);
            int staffId = booking.findStaffId(staffFirstname);
            int transport = findTransportId(cbx_busTimes.Text);

            //Checking to see if the user has paid yet
            double amountOwed = 0.00;
            if (cbx_paymentRecieved.Checked == true)
            {
                Convert.ToDouble(amountOwed);
            }
            else
            {
                amountOwed = Convert.ToDouble(txt_amountOwed.Text);
            }


            //assigning the values to the appropriate attributes in the class
            createBooking(ref booking, ref bookingChild, ref bookingStaff, Convert.ToInt16(booking.GetBookingyId(ref bookingTable)), transport, amountOwed, childId, activityId, staffId, dtp_weekStart.Value, cbx_monday.Checked, cbx_tuesday.Checked, cbx_wednesday.Checked, cbx_thursday.Checked, cbx_friday.Checked);

            //Adding the fields to the database
            newRow["bookingID"] = booking.BookingID;
            newRowStaff["bookingId"] = bookingStaff.BookingId;
            newRowChild["bookingId"] = bookingChild.BookingId;

            newRowChild["childID"] = bookingChild.ChildId;
            newRowStaff["staffId"] = bookingStaff.StaffId;

            newRow["dayOne"] = booking.DayOne;
            newRow["dayTwo"] = booking.DayTwo;
            newRow["dayThree"] = booking.DayThree;
            newRow["dayFour"] = booking.DayFour;
            newRow["dayFive"] = booking.DayFive;
            newRow["activityId"] = booking.ActivityId;
            newRow["transportId"] = booking.TransportId;
            newRow["weekStart"] = booking.WeekStart;
            newRow["bookingCost"] = booking.BookingCost;

            //Updating the tables
            bookingTable.Rows.Add(newRow);
            bookingAdapter.Update(bookingTable);

            bookingChildTable.Rows.Add(newRowChild);
            childAdapter.Update(bookingChildTable);

            bookingStaffTable.Rows.Add(newRowStaff);
            staffAdapter.Update(bookingStaffTable);
        }

        //Reads the staffBooking, childBooking and Booking table 
        private void ReadTable()
        {
            string sql = sqlBooking = @"Select * From " + "Booking";
            bookingAdapter = new SqlDataAdapter(sqlBooking, Program.GetConnectionString());
            sqlBuilder = new SqlCommandBuilder(bookingAdapter);
            bookingTable = new DataTable();
            bookingAdapter.FillSchema(bookingTable, SchemaType.Source);
            bookingAdapter.Fill(bookingTable);

            string sqlStaff = sqlStaff = @"Select * From " + "StaffBooking";
            staffAdapter = new SqlDataAdapter(sqlStaff, Program.GetConnectionString());
            sqlBuilder = new SqlCommandBuilder(staffAdapter);
            bookingStaffTable = new DataTable();
            staffAdapter.FillSchema(bookingStaffTable, SchemaType.Source);
            staffAdapter.Fill(bookingStaffTable);

            string sqlChild = sqlChild = @"Select * From " + "BookingChild";
            childAdapter = new SqlDataAdapter(sqlChild, Program.GetConnectionString());
            sqlBuilder = new SqlCommandBuilder(childAdapter);
            bookingChildTable = new DataTable();
            childAdapter.FillSchema(bookingChildTable, SchemaType.Source);
            childAdapter.Fill(bookingChildTable);
        }

        //Assigns booking values to the approriate classes
        private void createBooking(ref Booking booking, ref BookingChild bookingChild, ref StaffBooking bookingStaff, int bookingId, int transport, double amountOwed, int child, int activity, int staff, DateTime weekStart, bool day1, bool day2, bool day3, bool day4, bool day5)
        {
            int dayOne = 0;
            int dayTwo = 0;
            int dayThree = 0;
            int dayFour = 0;
            int dayFive = 0;

            if (day1 == true)
            {
                dayOne = 1;
            }

            if (day2 == true)
            {
                dayTwo = 2;
            }

            if (day3 == true)
            {
                dayThree = 3;
            }

            if (day4 == true)
            {
                dayFour = 4;

            }

            if (day5 == true)
            {
                dayOne = 5;
            }

            booking.BookingID = bookingId;

            bookingStaff.StaffId = staff;
            bookingStaff.BookingId = bookingId;
            bookingChild.ChildId = child;
            bookingChild.BookingId = bookingId;
            booking.ActivityId = activity;
            booking.WeekStart = weekStart;

            booking.TransportId = transport;
            booking.BookingCost = amountOwed;

            booking.DayOne = dayOne;
            booking.DayTwo = dayTwo;
            booking.DayThree = dayThree;
            booking.DayFour = dayFour;
            booking.DayFive = dayFive;
        }

        //Displays bookings in the ComboBox at the top of the screen
        public void loadBookings()
        {
            string actName = "";
            int childId = 0;
            string childName = "";
            DateTime weekStart = DateTime.Now;

            SqlDataAdapter bookingAdapter2 = new SqlDataAdapter("SELECT * FROM Booking", Program.GetConnectionString());

            DataTable bookingTable2 = new DataTable();
            bookingAdapter2.Fill(bookingTable2);

            cbx_selectedBooking.Items.Clear();

            for (int i = 0; i < bookingTable2.Rows.Count; i++)
            {
                actName = methods.findActivityName(Convert.ToInt32(bookingTable2.Rows[i]["activityId"]));
                childId = methods.findChildId(Convert.ToInt32(bookingTable2.Rows[i]["bookingId"]));
                weekStart = Convert.ToDateTime(bookingTable2.Rows[i]["weekStart"]);
                childName = methods.findChildName(childId);


                string returned = childName + " booked into " + actName + " week starting the " + weekStart.ToShortDateString();
            cbx_selectedBooking.Items.Add(returned);
            }
        }

        private void pnl_topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        //Validates all the data in the textboxes
        private bool validation(string childName, string staffName, string activityName, string amountOwed)
        {

            int amountowedInt = Convert.ToInt16(amountOwed);

            pbx_childName.Visible = false;
            pbx_staffMember.Visible = false;
            pbx_amountOwed.Visible = false;
            pbx_activities.Visible = false;

            bool isValid = false;

            if (childName.Length < 2 || childName.Length > 15 || childName == "")
            {
                pbx_childName.Visible = true;
                isValid = false;
            }
            if (staffName.Length < 2 || staffName.Length > 15 | staffName == "")
            {
                pbx_staffMember.Visible = true;
                isValid = false;
            }

            if (amountowedInt < 4 || amountowedInt > 100 || amountOwed == "")
            {
                pbx_amountOwed.Visible = true;
                isValid = false;
            }
            if (activityName.Length < 8 || activityName.Length > 12 || activityName == "")
            {
                pbx_activityName.Visible = true;
                isValid = false;
            }


            if (pbx_childName.Visible == false && pbx_activityName.Visible == false && pbx_staffMember.Visible == false && pbx_amountOwed.Visible)
            {
                pbx_childName.Visible = false;
                pbx_activityName.Visible = false;
                pbx_staffMember.Visible = false;
                pbx_amountOwed.Visible = false;
                isValid = true;
            }
            return isValid;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Returns the user from the payment panel to the bookind details panel
        private void btn_back_Click(object sender, EventArgs e)
        {
            pnl_order.Show();
            pnl_payment.Hide();
        }

        //This adds the booking to the database
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (cbx_busTimes.Text == "")
            {
                pbx_time.Visible = true;
                MessageBox.Show("Please select a time");
            }
            else
            {
                pbx_time.Visible = false;
                addBooking();
                MessageBox.Show("A new booking has been added");
                cbx_selectedBooking.Items.Clear();
                loadBookings();
                pnl_invoice.Show();
                
                pnl_payment.Hide();

                // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
                rpt_invoice.RefreshReport();

                //ReportParameter[] parms = new ReportParameter[1];
                //parms[0] = new ReportParameter("@firstName", methods.findChildFirstName(cbx_childName.Text));
                //this.rpt_invoice.LocalReport.SetParameters(parms);
                //this.rpt_invoice.RefreshReport();


                clearData();
            }

        }

        //Calculates the transport costs based on number of days booked
        private void cbx_transportNeeded_CheckedChanged(object sender, EventArgs e)
        {
            bool boolMonday = false;
            bool boolTuesday = false;
            bool boolWednesday = false;
            bool boolThursday = false;
            bool boolFriday = false;

            if (cbx_transportNeeded.Checked == false)
            {
                lbl_totalCostLabel.Text = txt_amountOwed.Text;
            }
            else
            {
                double runningCost = 0;
                double cost = 0.5;

                if (cbx_monday.Checked == true)
                {
                    runningCost += cost;
                    boolMonday = true;
                }
                else if (cbx_monday.Checked = false && boolMonday == true)
                {
                    runningCost = -cost;
                    boolMonday = false;
                }

                if (cbx_tuesday.Checked == true)
                {
                    runningCost += cost;
                    boolTuesday = true;
                }
                else if (cbx_tuesday.Checked == true && boolTuesday == true)
                {
                    runningCost -= cost;
                    boolTuesday = false;
                }

                if (cbx_wednesday.Checked == true)
                {
                    runningCost += cost;
                    boolTuesday = true;
                }
                else if (cbx_wednesday.Checked == true && boolWednesday == true)
                {
                    runningCost -= cost;
                    boolWednesday = false;
                }

                if (cbx_thursday.Checked == true)
                {
                    runningCost += cost;
                    boolThursday = true;
                }
                else if (cbx_thursday.Checked == true && boolThursday == true)
                {
                    runningCost -= cost;
                    boolThursday = false;
                }

                if (cbx_friday.Checked == true)
                {
                    runningCost += cost;
                    boolFriday = true;
                }
                else if (cbx_friday.Checked == true && boolFriday == true)
                {
                    runningCost -= cost;
                    boolFriday = false;
                }

                double total = Convert.ToDouble(lbl_totalCostLabel.Text) + runningCost;

                lbl_totalCostLabel.Text = Convert.ToString(total);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Finds the transport ID 
        private int findTransportId(string time)
        {
            int transportID;

            if (time == "12:00")
            {
                transportID = 1;
            }
            else
            {
                transportID = 2;
            }

            return transportID;
        }

        
        private void pbx_staffMember_Click(object sender, EventArgs e)
        {

        }

        //ensures that all dates can be booked (EG cannot book 33nd of January)
        private void cbx_weekNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_monday.Enabled = true;
            cbx_tuesday.Enabled = true;
            cbx_wednesday.Enabled = true;
            cbx_thursday.Enabled = true;
            cbx_friday.Enabled = true;
            

            if(cbx_month.Text == "January" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Enabled = false;
                cbx_monday.Checked = false;
            }
            else if(cbx_month.Text == "January" && cbx_dayNumber.Text == "28")
            {
                cbx_friday.Enabled = false;
                cbx_friday.Checked = false;
            }
            else if(cbx_month.Text == "February" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Checked = false;
                cbx_monday.Enabled = false;
                cbx_tuesday.Enabled = false;
                cbx_tuesday.Checked = false;
                cbx_wednesday.Enabled = false;
                cbx_wednesday.Checked = false;
                cbx_thursday.Enabled = false;
                cbx_thursday.Checked = false;
            }
            else if(cbx_month.Text == "February" && cbx_dayNumber.Text == "25")
            {
                cbx_friday.Enabled = false;
                cbx_friday.Checked = false;
            }
            else if(cbx_month.Text == "March" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Enabled = false;
                cbx_monday.Checked = false;
                cbx_tuesday.Enabled = false;
                cbx_tuesday.Checked = false;
                cbx_wednesday.Enabled = false;
                cbx_wednesday.Checked = false;
                cbx_thursday.Enabled = false;
                cbx_thursday.Checked = false;
            }
            else if (cbx_month.Text == "April" && cbx_dayNumber.Text == "29")
            {
                cbx_wednesday.Enabled = false;
                cbx_wednesday.Checked = false;
                cbx_thursday.Enabled = false;
                cbx_thursday.Checked = false;
                cbx_friday.Enabled = false;
                cbx_friday.Checked = false;
            }
            else if (cbx_month.Text == "May" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Enabled = false;
                cbx_monday.Checked = false;
                cbx_tuesday.Enabled = false;
                cbx_tuesday.Checked = false;
            }
            else if (cbx_month.Text == "May" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Enabled = false;
                cbx_monday.Checked = false;
                cbx_tuesday.Enabled = false;
                cbx_tuesday.Checked = false;
            }
            else if (cbx_month.Text == "July" && cbx_dayNumber.Text == "29")
            {
                cbx_thursday.Enabled = false;
                cbx_friday.Enabled = false;
                cbx_friday.Checked = false;
            }
            else if (cbx_month.Text == "August" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Enabled = false;
                cbx_monday.Checked = false;
                cbx_tuesday.Enabled = false;
                cbx_tuesday.Checked = false;
                cbx_wednesday.Enabled = false;
                cbx_wednesday.Checked = false;
            }
            else if (cbx_month.Text == "September" && cbx_dayNumber.Text == "30")
            {
                cbx_tuesday.Enabled = false;
                cbx_tuesday.Checked = false;
                cbx_wednesday.Enabled = false;
                cbx_wednesday.Checked = false;
                cbx_thursday.Enabled = false;
                cbx_thursday.Checked = false;
                cbx_friday.Enabled = false;
                cbx_friday.Checked = false;
            }
            else if (cbx_month.Text == "October" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Enabled = false;
                cbx_monday.Checked = false;
            }
            else if (cbx_month.Text == "October" && cbx_dayNumber.Text == "28")
            {
                cbx_friday.Enabled = false;
                cbx_friday.Checked = false;
            }
            else if (cbx_month.Text == "November" && cbx_dayNumber.Text == "1")
            {
                cbx_monday.Enabled = false;
                cbx_monday.Checked = false;
                cbx_tuesday.Enabled = false;
                cbx_tuesday.Checked = false;
                cbx_wednesday.Enabled = false;
                cbx_wednesday.Checked = false;
                cbx_thursday.Enabled = false;
                cbx_thursday.Checked = false;
            }
            else if (cbx_month.Text == "December" && cbx_dayNumber.Text == "30")
            {
                cbx_wednesday.Enabled = false;
                cbx_wednesday.Checked = false;
                cbx_thursday.Enabled = false;
                cbx_thursday.Checked = false;
                cbx_friday.Enabled = false;
                cbx_friday.Checked = false;
            }
        }

        //loads the months of the year into the combobox
        private void loadWeekStarts()
        {
            cbx_month.Items.Add("January");
            cbx_month.Items.Add("February");
            cbx_month.Items.Add("March");
            cbx_month.Items.Add("April");
            cbx_month.Items.Add("May");
            cbx_month.Items.Add("June");
            cbx_month.Items.Add("July");
            cbx_month.Items.Add("August");
            cbx_month.Items.Add("September");
            cbx_month.Items.Add("October");
            cbx_month.Items.Add("November");
            cbx_month.Items.Add("December");
            cbx_year.Items.Add("2019");
        }

        //Finds the number of each month to put in the DateTime 
        private int findDate(string month)
        {
            int monthNumber = 0;

            switch (month)
            {
                case "January":
                    monthNumber = 1;
                    break;
                case "Febuary":
                    monthNumber = 2;
                    break;
                case "March":
                    monthNumber = 3;
                    break;
                case "April":
                    monthNumber = 4;
                    break;
                case "May":
                    monthNumber = 5;
                    break;
                case "June":
                    monthNumber = 6;
                    break;
                case "July":
                    monthNumber = 7;
                    break;
                case "August":
                    monthNumber = 8;
                    break;
                case "September":
                    monthNumber = 9;
                    break;
                case "October":
                    monthNumber = 10;
                    break;
                case "November":
                    monthNumber = 11;
                    break;
                case "December":
                    monthNumber = 12;
                    break;
            }

            return monthNumber;
        }

        //Adding the first day of the week from each month 
        private void cbx_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_dayNumber.Items.Clear();

            if(cbx_month.Text == "January")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(7);
                cbx_dayNumber.Items.Add(14);
                cbx_dayNumber.Items.Add(21);
                cbx_dayNumber.Items.Add(28);
            }

            else if (cbx_month.Text == "February")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(4);
                cbx_dayNumber.Items.Add(11);
                cbx_dayNumber.Items.Add(18);
                cbx_dayNumber.Items.Add(25);
            }

            else if (cbx_month.Text == "March")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(4);
                cbx_dayNumber.Items.Add(11);
                cbx_dayNumber.Items.Add(18);
                cbx_dayNumber.Items.Add(25);
            }

            else if (cbx_month.Text == "April")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(8);
                cbx_dayNumber.Items.Add(15);
                cbx_dayNumber.Items.Add(22);
                cbx_dayNumber.Items.Add(29);
            }

            else if (cbx_month.Text == "May")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(6);
                cbx_dayNumber.Items.Add(13);
                cbx_dayNumber.Items.Add(20);
                cbx_dayNumber.Items.Add(27);
            }

            else if (cbx_month.Text == "June")
            {
                cbx_dayNumber.Items.Add(3);
                cbx_dayNumber.Items.Add(10);
                cbx_dayNumber.Items.Add(17);
                cbx_dayNumber.Items.Add(24);
            }

            else if (cbx_month.Text == "July")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(8);
                cbx_dayNumber.Items.Add(15);
                cbx_dayNumber.Items.Add(22);
                cbx_dayNumber.Items.Add(29);
            }

            else if(cbx_month.Text == "August")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(5);
                cbx_dayNumber.Items.Add(12);
                cbx_dayNumber.Items.Add(19);
                cbx_dayNumber.Items.Add(26);
            }

            else if (cbx_month.Text == "September")
            {
                cbx_dayNumber.Items.Add(2);
                cbx_dayNumber.Items.Add(9);
                cbx_dayNumber.Items.Add(16);
                cbx_dayNumber.Items.Add(23);
                cbx_dayNumber.Items.Add(30);
            }

            else if (cbx_month.Text == "October")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(7);
                cbx_dayNumber.Items.Add(14);
                cbx_dayNumber.Items.Add(21);
                cbx_dayNumber.Items.Add(28);
            }

            else if (cbx_month.Text == "November")
            {
                cbx_dayNumber.Items.Add(1);
                cbx_dayNumber.Items.Add(4);
                cbx_dayNumber.Items.Add(11);
                cbx_dayNumber.Items.Add(18);
                cbx_dayNumber.Items.Add(25);
            }

            else if(cbx_month.Text == "December")
            {
                cbx_dayNumber.Items.Add(2);
                cbx_dayNumber.Items.Add(9);
                cbx_dayNumber.Items.Add(16);
                cbx_dayNumber.Items.Add(23);
                cbx_dayNumber.Items.Add(30);
            }
        }

        private void cbx_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Finding day thats saved in SQL Server Database (For updating records)
        private int findDay(DateTime sqlDate)
        {
            int day;
            day = sqlDate.Day;
            return day;
        }

        //Finding month thats saved in SQL Server Database (For updating records)
        private int findMonth(DateTime sqlMonth)
        {
            int month;
            month = sqlMonth.Month;
            return month;
        }

        //Finding the name of a month based on a number returned from SQL
        private string findMonthName(int number)
        {
            string monthName = " ";

            if (number == 1)
            {
                monthName = "January";
            }
            else if (number == 2)
            {
                monthName = "February";
            }
            else if (number == 3)
            {
                monthName = "March";
            }
            else if (number == 4)
            {
                monthName = "April";
            }
            else if (number == 5)
            {
                monthName = "May";
            }
            else if (number == 6)
            {
                monthName = "June";
            }
            else if (number == 7)
            {
                monthName = "July";
            }
            else if (number == 8)
            {
                monthName = "August";
            }
            else if (number == 9)
            {
                monthName = "September";
            }
            else if (number == 10)            {
                monthName = "October";
            }
            else if (number == 11)
            {
                monthName = "November";
            }
            else if (number == 12)
            {
                monthName = "December";
            }

            return monthName;
        }

        private void lbl_activityLabel_Click(object sender, EventArgs e)
        {

        }

        //Comparing data to see if any information has been updated 
        private void compareValues()
        {
            string childFirstName = methods.findChildFirstName(cbx_childName.Text);
            int childId = methods.findChildId(childFirstName);

            int activityId = methods.findActivityId(cbx_activityName.Text);
            int staffId = methods.findStaffId(cbx_staffMember.Text);
            int transport = 1;
            double amountOwed = 0;

            Booking oldBooking = new Booking();
            StaffBooking oldStaffBooking = new StaffBooking();
            BookingChild oldChildBOoking = new BookingChild();

            createBooking(ref oldBooking, ref oldChildBOoking, ref oldStaffBooking, Convert.ToInt16(updated.GetBookingyId(ref bookingTable)), transport, amountOwed, childId, activityId, staffId, dtp_weekStart.Value, cbx_monday.Checked, cbx_tuesday.Checked, cbx_wednesday.Checked, cbx_thursday.Checked, cbx_friday.Checked);


            if (updated.ActivityId == activityId && updatedStaff.StaffId == staffId && updated.DayOne == oldBooking.DayOne && updated.DayTwo == oldBooking.DayTwo && updated.DayThree == oldBooking.DayThree && updated.DayFour == oldBooking.DayFour && updated.DayFive == oldBooking.DayFive) //updatedChild.ChildId == childId updated.WeekStart == dtp_weekStart.Value &
            {
                MessageBox.Show("Data is Valid");
            }
            else
            {
                MessageBox.Show("Info has been Changed");
            }
        }

        //deletes/cancels a booking
        private void deleteRecord()
        {
            Booking methods = new Booking();
            using (SqlConnection con = new SqlConnection(Program.GetConnectionString()))
            {
                string childFirstName = methods.findChildFirstName(cbx_childName.Text);
                int childId = methods.findChildId(childFirstName);

                //finding the parents contact number
                SqlDataAdapter childAdapter = new SqlDataAdapter("SELECT Child.parentContactNo FROM Child WHERE childId = " + childId, Program.GetConnectionString());

                DataTable childTable = new DataTable();
                childAdapter.Fill(childTable);

                //Reading the tables
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM BookingChild WHERE bookingID = " + lbl_id.Text, con))
                using (SqlCommand commandStaffBooking = new SqlCommand("DELETE FROM StaffBooking WHERE bookingId = " + lbl_id.Text, con))
                using (SqlCommand commandDeleteBooking = new SqlCommand("DELETE FROM Booking WHERE bookingID = " + lbl_id.Text, con))
                {
                    if (cbx_selectedBooking.Text != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Cancel Booking", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show(" If the child did not show up contact the parents: " + childTable.Rows[0]["parentContactNo"]);
                            //Executes Delete
                            command.ExecuteNonQuery();
                            commandStaffBooking.ExecuteNonQuery();
                            commandDeleteBooking.ExecuteNonQuery();

                            //Updates program to match database
                            cbx_selectedBooking.Items.Clear();
                            clearData();
                            loadBookings();
                            methods.populateCombobox(cbx_selectedBooking, cbx_childName, cbx_activityName, cbx_staffMember);
                            MessageBox.Show("This Booking has been cancelled");
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an Booking");
                    }
                }
                con.Close();
            }
        }

        //Checking for double bookings
        private bool doubleBooking()
        {
            int childId = methods.findChildrenId(cbx_childName.Text);
            int bookingId = 0;
            bool sameBooking = true;

            SqlDataAdapter doubleChildBookingAdapter = new SqlDataAdapter("SELECT * FROM BookingChild WHERE childId = " + childId, Program.GetConnectionString());
            {
                DataTable bookingTables = new DataTable();
                doubleChildBookingAdapter.Fill(bookingTables);

                if (bookingTables.Rows.Count != 0)
                {
                    bookingId = Convert.ToInt16(bookingTables.Rows[0]["bookingId"]);
                }
                else
                {
                    bookingId = 0;
                }
                

                if (bookingId > 0)
                {
                    SqlDataAdapter doubleBookingAdapter = new SqlDataAdapter("SELECT * FROM Booking WHERE bookingId = " + bookingId, Program.GetConnectionString());
                    {
                        DataTable bookingTable = new DataTable();
                        doubleBookingAdapter.Fill(bookingTable);

                        //Finding names and IDs of data needed
                        string childname = methods.findChildName(childId);
                        string activityNames = methods.findActivityName(Convert.ToInt32(bookingTable.Rows[0]["activityId"]));
                        int activityId = methods.findActivityId(cbx_activityName.Text);

                        if (Convert.ToInt16(bookingTable.Rows[0]["activityId"]) == activityId)
                        {
                            sameBooking = true;
                        }
                        else
                        {
                            sameBooking = false;
                        }
                    }
                }
                else
                {
                    sameBooking = false;
                }

                return sameBooking;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_bookingConfirmation_Click(object sender, EventArgs e)
        {
            pnl_order.Visible = true;
            pnl_invoice.Visible = false;
            pnl_payment.Visible = false;
        }

        //Populating the bus times on the confirmation panel
        private void loadTransportCombobox()
        {
            cbx_busTimes.Items.Add("1200");
            cbx_busTimes.Items.Add("1500");
        }
        private void rpt_invoice_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataTable1TableAdapter.FillBy1(this.DataSet1.DataTable1, lbl_childLabel.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataTable1TableAdapter.FillBy1(this.DataSet1.DataTable1, lbl_childLabel.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataTable1TableAdapter.FillBy1(this.DataSet1.DataTable1, firstNameToolStripTextBox.Text);
                rpt_invoice.Refresh();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}