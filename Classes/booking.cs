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
    class Booking
    {
        private int bookingID;
        private int childId;
        private double bookingCost;
        private DateTime weekstart;
        private double amountOwed;
        private int transportId;
        private int dayOne;
        private int dayTwo;
        private int dayThree;
        private int dayFour;
        private int dayFive;
        private int activityId;


        public Booking()
        {
            bookingID = 0;
            activityId = 0;
            bookingCost = 0.0;
            weekstart = DateTime.Now;
            amountOwed = 0.0;
            transportId = 0;
            dayOne = 0;
            childId = 0;
            dayTwo = 0;
            dayThree = 0;
            dayFour = 0;
            dayFive = 0;
        }

        public Booking(int _bookingId, int _activityID, int _childId, double _bookingCost, DateTime _weekStart, double _amountOwed, int _transportId, int _dayOne, int _dayTwo, int _dayThree, int _dayFour, int _dayFive)
        {
            bookingID = _bookingId;
            activityId = _activityID;
            childId = _childId;
            bookingCost = _bookingCost;
            weekstart = _weekStart;
            amountOwed = _amountOwed;
            transportId = _transportId;
            dayOne = _dayOne;
            dayTwo = _dayTwo;
            dayThree = _dayThree;
            dayFour = _dayFour;
            dayFive = _dayFive;
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public double BookingCost
        {
            get { return bookingCost; }
            set { bookingCost = value; }
        }

        public DateTime WeekStart
        {
            get { return weekstart; }
            set { weekstart = value; }
        }

        public int ActivityId
        {
            get { return activityId; }
            set { activityId = value; }
        }

        public int ChildId
        {
            get { return childId; }
            set { childId = value; }
        }

        public int DayOne
        {
            get { return dayOne; }
            set { dayOne = value; }
        }

        public int DayTwo
        {
            get { return dayTwo; }
            set { dayTwo = value; }
        }

        public int DayThree
        {
            get { return dayThree; }
            set { dayThree = value; }
        }

        public int DayFour
        {
            get { return dayFour; }
            set { dayFour = value; }
        }

        public int DayFive
        {
            get { return dayFive; }
            set { dayFive = value; }
        }

        public int TransportId
        {
            get { return transportId; }
            set { transportId = value; }
        }

        

        

        //Finding the childID based on the first name of a child
        public int findChildId(string childName)
        {
            int id = 0;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT childId FROM Child WHERE childFirstname = '" + childName + "'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                id = Convert.ToInt16(myRow[0]);
            }
            return id;
        }

        //Uses substring to find where the space in a name is
        public string findChildFirstName(string name)
        {
            return name.Substring(0, name.IndexOf(' '));

        }

        //Finds a childs surname based on first name
        public string findChildSurname(string name)
        {
            //finds the ID of te child
            int childId = findChildId(name);
            string fullName = "";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT childSurname FROM Child WHERE ChildId = '" + childId + "'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                fullName = (string)myRow[0];
            }
            return fullName;

        }

        //Finding childID based on a childs full name
        public int findChildrenId(string childName)
        {
            int id = 0;

            //finds first name
            string firstName = findChildFirstName(childName);

            //finds the ID for that name
            id = findChildId(firstName);

            return id;
        }

        //Finds the childs name based on a Booking ID
        public int findChildId(int id)
        {
            int name = 0;
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT childId FROM BookingChild WHERE bookingId = " + id, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                name = (int)myRow[0];
            }

            return name;
        }

        //DUPLICATE METHOD   Finds the childs first name based on the full name
        public string findChildName(int id)
        {
            string name = "";
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT childFirstname FROM Child WHERE childID = " + id, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                name = (string)myRow[0];
            }
            return name;
        }

        //Finding the activityCost based on the ID of an activity
        public double findActivityCost(int activiityId)
        {
            double cost = 0.0;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT acitivityCost FROM Activity WHERE activityId = " + activiityId, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                cost = Convert.ToInt16(myRow[0]);
            }
            return cost;
        }

        //Finding activity name from the ID of an activity
        public string findActivityName(int id)
        {
            string name = "";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT acitivityName FROM Activity WHERE activityId = " + id, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                name = (string)myRow[0];
            }
            return name;
        }

        //Finding the activityID based on the name 
        public int findActivityId(string activityName)
        {
            int id = 0;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT activityId FROM Activity WHERE acitivityName = '" + activityName + "'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                id = Convert.ToInt16(myRow[0]);
            }
            return id;
        }

        //Finds the transport Time based on the ID selected
        private string findTransportTime(int id)
        {
            string time;

            if (id == 1)
            {
                time = "12:00";
            }
            else
            {
                time = "15:00";
            }

            return time;
        }

        //Finds the staffName based on the Staff ID
        public string findStaffName(int id)
        {
            string name = "";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT staffFirstName FROM Staff WHERE staffId = " + id, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                name = (string)myRow[0];
            }
            return name;
        }

        //Finds the staff name based on a booking ID
        public int findStaffId(int id)
        {
            int name = 0;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT staffId FROM StaffBooking WHERE bookingId = " + id, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                name = (int)myRow[0];
            }
            return name;
        }

        //Finds a staffs surname based on first name
        public string findStaffSurname(string name)
        {
            int staffId = findStaffId(name);

            string fullName = "";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT staffSurname FROM Staff WHERE staffId = '" + staffId + "'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                fullName = (string)myRow[0];
            }
            return fullName;

        }

        //Finding the staffID based on the first name of a staff member
        public int findStaffId(string staffName)
        {
            int id = 0;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT staffId FROM Staff WHERE staffFirstname = '" + staffName + "'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                id = Convert.ToInt16(myRow[0]);
            }

            return id;
        }

        //Finding the bookingID based on a childs full name
        public int findBookingId(string childName)
        {
            int id = 0;

            //converts full name into just a first name
            string firstName = findChildFirstName(childName);

            //finds the childs ID based on first name
            id = findChildId(firstName);

            //finds booking ID based on the child ID from the previous line
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT bookingID FROM BookingChild WHERE childId = '" + id + "'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                id = Convert.ToInt16(myRow[0]);
            }
            return id;

        }

        //Creates a new Unqiue booking ID
        public string GetBookingyId(ref DataTable bookingTable)
        {
            DataRow drLastRow;
            string lastBookingId;
            string newBookingId;
            int lastRecord;

            lastRecord = bookingTable.Rows.Count;
            drLastRow = bookingTable.Rows[lastRecord - 1];
            lastBookingId = drLastRow["bookingID"].ToString();
            newBookingId = (int.Parse(lastBookingId) + 1).ToString();

            return newBookingId;
        }

        //Collecting data to display in the comobox at the top of the screen
        public string showNameAndActivity()
        {
            string returned = string.Empty;

            //Creating booking, datatable and a dataset
            Booking book = new Booking();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            //Loading the information into an adapter
            SqlDataAdapter da = new SqlDataAdapter("SELECT BookingChild.childID, Booking.activityId FROM BookingChild, Booking", Program.GetConnectionString());

            //Filling the table and populating the dataset
            ds.Tables.Add(dt);
            da.Fill(dt);

            //Adding each record to the combobox at the top of the screen
            foreach (DataRow myRow in dt.Rows)
            {
                string activityName = book.findActivityName(Convert.ToInt32(myRow["activityId"]));
                string childName = book.findChildName(Convert.ToInt32(myRow["ChildID"]));

                returned = childName + " booked into " + activityName;
            }

            return returned;
        }

        //Calulates the amount owed based on the days booked
        public string pricing(double cost, CheckBox monday, CheckBox tuesday, CheckBox wednesday, CheckBox thursday, CheckBox friday)
        {
            //setting all values to false
            bool boolMonday = false;
            bool boolTuesday = false;
            bool boolWednesday = false;
            bool boolThursday = false;
            bool boolFriday = false;
            double runningCost = 0;

            //This if statement checks to see if a day is selected and then add the cost of the activity to the running total
            if (monday.Checked == true)
            {
                runningCost += cost;
                boolMonday = true;
            }
            else if (monday.Checked = false && boolMonday == true)
            {
                runningCost = -cost;
                boolMonday = false;
            }

            if (tuesday.Checked == true)
            {
                runningCost += cost;
                boolTuesday = true;
            }
            else if (tuesday.Checked == true && boolTuesday == true)
            {
                runningCost = -cost;
                boolTuesday = false;
            }

            if (wednesday.Checked == true)
            {
                runningCost += cost;
                boolTuesday = true;
            }
            else if (wednesday.Checked == true && boolWednesday == true)
            {
                runningCost = -cost;
                boolWednesday = false;
            }

            if (thursday.Checked == true)
            {
                runningCost += cost;
                boolThursday = true;
            }
            else if (thursday.Checked == true && boolThursday == true)
            {
                runningCost = -cost;
                boolThursday = false;
            }

            if (friday.Checked == true)
            {
                runningCost += cost;
                boolFriday = true;
            }
            else if (friday.Checked == true && boolFriday == true)
            {
                runningCost = -cost;
                boolFriday = false;
            }

            return Convert.ToString(runningCost);
        }

        //Populating the comboxes
        public void populateCombobox(ComboBox selectedBooking, ComboBox selectedChild, ComboBox selectedActivity, ComboBox selectedStaff)
        {
            Booking book = new Booking();
            //Selecting all the data from the tables
            SqlDataAdapter activity = new SqlDataAdapter("SELECT * FROM Activity", Program.GetConnectionString());
            SqlDataAdapter booking = new SqlDataAdapter("SELECT * FROM Booking", Program.GetConnectionString());
            SqlDataAdapter children = new SqlDataAdapter("SELECT * FROM Child", Program.GetConnectionString());
            SqlDataAdapter staff = new SqlDataAdapter("SELECT * FROM Staff", Program.GetConnectionString());
            {
                //Creating the Datatables to store the adapters
                DataTable activityTable = new DataTable();
                DataTable bookingTable = new DataTable();
                DataTable childTable = new DataTable();
                DataTable staffTable = new DataTable();

                //Filling the tables with the data
                staff.Fill(staffTable);
                activity.Fill(activityTable);
                booking.Fill(bookingTable);
                children.Fill(childTable);

                //Adding all the data to the comboxes on the booking form
                for (int i = 0; i < activityTable.Rows.Count; i++)
                {
                    string firstName = Convert.ToString(activityTable.Rows[i]["acitivityName"]);
                    selectedActivity.Items.Add(firstName);
                }

                for (int i = 0; i < staffTable.Rows.Count; i++)
                {
                    string firstName = Convert.ToString(staffTable.Rows[i]["staffFirstName"]);
                    string surname = Convert.ToString(staffTable.Rows[i]["staffSurname"]);
                    selectedStaff.Items.Add(firstName + " " + surname);
                }

                for (int i = 0; i < childTable.Rows.Count; i++)
                {
                    string firstChildName = Convert.ToString(childTable.Rows[i]["childFirstName"]);
                    string secondChildName = Convert.ToString(childTable.Rows[i]["childSurname"]);
                    selectedChild.Items.Add(firstChildName + " " + secondChildName);
                }
            }
        }
    }
}

