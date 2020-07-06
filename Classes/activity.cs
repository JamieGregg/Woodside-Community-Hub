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
    class activity
    {
        private string activityName;
        private double activityCost;
        private int locationID;
        private int classSize;
        private int activityId;

        public activity()
        {
            activityId = 0;
            activityName = "";
            activityCost = 0.0;
            locationID = 0;
            classSize = 0;
        }

        public activity(string _activityName, int _locationName, int _classsize, double _activityCost, int _activityId)
        {
            activityId = _activityId;
            activityName = _activityName;
            locationID = _locationName;
            activityCost = _activityCost;
            classSize = _classsize;
        }

        public string  ActivityName
        {
            get { return activityName; }
            set { activityName = value; }
        }

        public int LocationId
        {
            get { return locationID; }
            set { locationID = value; }
        }

        public int ClassSize
        {
            get { return classSize; }
            set { classSize = value; }
        }

        public double ActivityCost
        {
            get { return activityCost; }
            set { activityCost = value; }
        }

        public int ActivityId
        {
            get { return activityId; }
            set { activityId = value; }
        }

        //Assigning values to an instance of a class
        public void createActivity(ref activity activity, int activityId, string name, int classsize, int location, double cost)
        {
            activity.ActivityId = activityId;
            activity.ActivityName = name;
            activity.ClassSize = classsize;
            activity.locationID = location;
            activity.activityCost = cost;
        }

        //Finding a unique ID for the next activity
        public string GetActivityId(ref DataTable activityTable)
        {
            DataRow drLastRow;
            string lastActivityId;
            string newActivityId;
            int lastRecord;

            lastRecord = activityTable.Rows.Count;
            drLastRow = activityTable.Rows[lastRecord - 1];
            lastActivityId = drLastRow["activityId"].ToString();
            newActivityId = (int.Parse(lastActivityId) + 1).ToString();

            return newActivityId;
        }

        //Comparing if the name of an activity has been changed
        public bool CompareValues(ref activity activity, string name)
        {
            if (activity.ActivityName == name )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Checking if the activity already exists
        public bool checkDuplication(string activityname)
        {
            bool isDuplicate = false;

            activity act = new activity();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            ds.Tables.Add(dt);
            SqlDataAdapter da = new SqlDataAdapter("SELECT acitivityName FROM Activity WHERE acitivityName = '" + activityname + "'", Program.GetConnectionString());
            da.Fill(dt);

            if(dt.Rows.Count != 0)
            {
                isDuplicate = true;
            }

            return isDuplicate;
        }

        //deleting a record
        public void deleteRecord(ListView showActivity, ComboBox selectedActivity, ComboBox selectedLocation, Label ID)
        {
            activity methods = new activity();

            using (SqlConnection con = new SqlConnection(Program.GetConnectionString()))
            {
                con.Open();
                //Deleting from all tables
                using (SqlCommand command = new SqlCommand("DELETE FROM Activity WHERE activityId = " + ID.Text, con))
                using (SqlCommand commandBooking = new SqlCommand("DELETE FROM Booking WHERE activityId = " + ID.Text, con))
                using (SqlCommand commandBoookingChild = new SqlCommand("DELETE FROM BookingChild WHERE bookingID = " + methods.findBookingChildId(Convert.ToInt16(ID.Text)), con))
                using (SqlCommand commandBookingStaff = new SqlCommand("DELETE FROM StaffBooking WHERE bookingID = " + methods.findBookingSatffId(Convert.ToInt16(ID.Text)), con))
                {
                    if (selectedActivity.Text != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            //Executing the commands
                            commandBoookingChild.ExecuteNonQuery();
                            commandBookingStaff.ExecuteNonQuery();
                            commandBooking.ExecuteNonQuery();
                            command.ExecuteNonQuery();

                            //Clearing comboboxes and lisboxes reloadinf them with the new data
                            selectedActivity.Items.Clear();
                            methods.populateCombobox(selectedActivity, selectedLocation);
                            methods.loadListView("acitivityName", showActivity);

                            //Giving the user feedback
                            MessageBox.Show("Activity has been deleted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an Activity");
                    }
                }
                con.Close();
            }
        }

        //loading the listview
        public void loadListView(string orderBy, ListView showActivites)
        {
            //Clearing the listbox
            showActivites.Items.Clear();

            //Creating and populating a new table with data
            activity act = new activity();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity.acitivityName, Activity.acitivityCost, Activity.locationId FROM Activity ORDER BY " + orderBy, Program.GetConnectionString());
            da.Fill(dt);
            
            //adding each row to the listbox
            foreach (DataRow myRow in dt.Rows)
            {
                showActivites.Items.Add(Convert.ToString(myRow["acitivityName"]));
                showActivites.Items[showActivites.Items.Count - 1].SubItems.Add(act.findLocationName(Convert.ToInt32(myRow["locationId"])));
            }
        }

        //finding the location ID based on the name
        public int findLocationId(string locationText)
        {
            int id = 0; 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT locationId FROM Locations WHERE locationName = '" + locationText + "'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                id = Convert.ToInt16(myRow[0]);
            }
            return id;
        }

        //finding the ID of a location based on the ID
        public string findLocationName(int id)
        {
            string name = "";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT locationName FROM Locations WHERE locationId = " + id, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                name = (string)myRow[0];
            }
            return name;
        }

        //Populating the comboboxes for activity and location
        public void populateCombobox(ComboBox selectedActivity, ComboBox selectedLocation)
        {
            SqlDataAdapter activity = new SqlDataAdapter("SELECT * FROM Activity", Program.GetConnectionString());
            SqlDataAdapter location = new SqlDataAdapter("SELECT locationName FROM Locations", Program.GetConnectionString());
            {
                DataTable activityTable = new DataTable();
                DataTable locationTable = new DataTable();

                activity.Fill(activityTable);
                location.Fill(locationTable);

                for (int i = 0; i < activityTable.Rows.Count; i++)
                {
                    string firstName = Convert.ToString(activityTable.Rows[i]["acitivityName"]);
                    selectedActivity.Items.Add(firstName);
                }

                for(int i = 0; i < locationTable.Rows.Count; i++)
                {
                    string locationName = Convert.ToString(locationTable.Rows[i]["locationName"]);
                    selectedLocation.Items.Add(locationName);
                }
            }
        }

        public int findBookingChildId(int activityId)
        {
            int Bookingid = 0;
            int childBookingId = 0;

            DataTable activityBookingsTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT bookingID FROM Booking WHERE activityId = " + activityId, Program.GetConnectionString());
            da.Fill(activityBookingsTable);

            foreach (DataRow myRow in activityBookingsTable.Rows)
            {
                Bookingid = Convert.ToInt16(myRow[0]);
            }

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT bookingID FROM BookingChild WHERE bookingID = " + Bookingid, Program.GetConnectionString());
            da2.Fill(dt2);

            foreach (DataRow myRow in dt2.Rows)
            {
                childBookingId = Convert.ToInt16(myRow[0]);
            }

            return childBookingId;
        }

        public int findBookingSatffId(int activityId)
        {
            int Bookingid = 0;
            int childBookingId = 0;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT bookingID FROM Booking WHERE activityId = " + activityId, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                Bookingid = Convert.ToInt16(myRow[0]);
            }

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT bookingID FROM StaffBooking WHERE bookingID = " + Bookingid, Program.GetConnectionString());
            da2.Fill(dt2);

            foreach (DataRow myRow in dt2.Rows)
            {
                childBookingId = Convert.ToInt16(myRow[0]);
            }

            return childBookingId;
        }

    }
}

