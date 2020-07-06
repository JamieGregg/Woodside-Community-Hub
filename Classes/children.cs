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
    class children
    {
        private string firstname;
        private string surname;
        private int age;
        private string parentName;
        private string parentContactNo;
        private string doctorName;
        private string address;
        private int childId;

        public children()
        {
            firstname = "";
            surname = "";
            age = 0;
            parentName = "";
            parentContactNo = "";
            doctorName = "";
            address = "";
            childId = 0;
        }

        public children(string _firstName, string _surname, int _age, string _parentName, string _parentContactNo, int _childId, string _doctorName, string _address)
        {
            firstname = _firstName;
            surname = _surname;
            age = _age;
            parentName = _parentName;
            parentContactNo = _parentContactNo;
            doctorName = _doctorName;
            address = _address;
            childId = _childId;
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string ParentName
        {
            get { return parentName; }
            set { parentName = value; }
        }
        public string ParentContactNo
        {
            get { return parentContactNo; }
            set { parentContactNo = value; }
        }
        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int ChildId
        {
            get { return childId; }
            set { childId = value; }
        }

        //Creating an instance of a child in the child class
        public void CreateChild(ref children child ,int childId, string firstname, string surname, int age, string parentName, string parentContact, string dcotorName, string address)
        {
            child.ChildId = childId;
            child.FirstName = firstname;
            child.Surname = surname;
            child.Age = age;
            child.ParentName = parentName;
            child.ParentContactNo = parentContact;
            child.DoctorName = doctorName;
            child.Address = address;
        }

        //Creating a new child ID that is unquie
        public string GetChildId(ref DataTable childTable)
        {
            DataRow drLastRow;
            string lastCustomerID;
            string newCustomerID;
            int lastRecord;

            lastRecord = childTable.Rows.Count;
            drLastRow = childTable.Rows[lastRecord - 1];
            lastCustomerID = drLastRow["childId"].ToString();
            newCustomerID = (int.Parse(lastCustomerID) + 1).ToString();

            return newCustomerID;
        }

        //Deletes a child from all the appropriate tables
        public void deleteRecord(ListView showChildren, ComboBox selectedChild, Label ID, string firstname, string surname, string age, string parentName, string parentContact, string dcotorName, string address)
        {
            //creating instances of classes I will use
            children methods = new children();
            Booking booking = new Booking();

            //Combinging sepearte name fields into one full name 
            string fullName = firstname + " " + surname;

            //Testing to see if the name is empty
            if (firstname != string.Empty)
            {
                //Creating a connecton to the database
                using (SqlConnection con = new SqlConnection(Program.GetConnectionString()))
                {
                    con.Open();
                    using (SqlCommand commandBookingChildTable = new SqlCommand("DELETE FROM BookingChild WHERE childId = " + ID.Text, con))
                    using (SqlCommand commandBookingStaffTable = new SqlCommand("DELETE FROM StaffBooking WHERE bookingId = " + findStaffAssosiatedWithChild(Convert.ToInt16(ID.Text)), con))
                    using (SqlCommand commandBookingTable = new SqlCommand("DELETE FROM Booking WHERE bookingId = " + booking.findBookingId(fullName) , con))
                    using (SqlCommand command = new SqlCommand("DELETE FROM Child WHERE childId = " + ID.Text, con))
                    {
                        if (selectedChild.Text != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {
                                commandBookingChildTable.ExecuteNonQuery();
                                commandBookingStaffTable.ExecuteNonQuery();
                                commandBookingTable.ExecuteNonQuery();
                                command.ExecuteNonQuery();

                                selectedChild.Items.Clear();
                                methods.populateCombobox(selectedChild);
                                methods.loadListView("childFirstName", showChildren);

                                MessageBox.Show("Record has been deleted");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a Child");
                        }
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a child from the box");
            }
        }

        //Loading the Listview on the right hand side of the form with data
        public void loadListView(string orderBy, ListView showChildren)
        {
            showChildren.Items.Clear();

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            SqlDataAdapter da = new SqlDataAdapter("SELECT childFirstName, childSurname, childAge, childId FROM Child ORDER BY " + orderBy, Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                showChildren.Items.Add(myRow[0].ToString());
                showChildren.Items[showChildren.Items.Count - 1].SubItems.Add(myRow[1].ToString());
                showChildren.Items[showChildren.Items.Count - 1].SubItems.Add(myRow[2].ToString());
            }
        }
        
        //Loading the combox at the top of the screen with childrens names
        public void populateCombobox(ComboBox selectedChild)
        {
            SqlDataAdapter children = new SqlDataAdapter("SELECT * FROM Child", Program.GetConnectionString());
            {
                DataTable ChildTable = new DataTable();
                children.Fill(ChildTable);

                for (int i = 0; i < ChildTable.Rows.Count; i++)
                {
                    //Combining the first and second name to to display in the combobox
                    string firstName = Convert.ToString(ChildTable.Rows[i]["childFirstName"]);
                    string surname = Convert.ToString(ChildTable.Rows[i]["childSurname"]);
                    selectedChild.Items.Add(firstName + " " + surname);
                }
            }
        }

        //Breaking down a full name into just the second name
        public string findFirstName(string name)
        {
            return name.Substring(0, name.IndexOf(' '));
        }

        //Finding what staff members are linked to children when deleting records
        public int findStaffAssosiatedWithChild(int childId)
        {
            int Bookingid = 0;
            int staffBooking = 0;

            //Finding the booking ID of children 
            DataTable childBookingsTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT bookingID FROM BookingChild WHERE childID = " + childId, Program.GetConnectionString());
            da.Fill(childBookingsTable);

            foreach (DataRow myRow in childBookingsTable.Rows)
            {
                Bookingid = Convert.ToInt16(myRow[0]);
            }

            //Finding the staff assoossiated with the bookings
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT staffId FROM StaffBooking WHERE bookingId = " + Bookingid, Program.GetConnectionString());
            da2.Fill(dt2);

            foreach (DataRow myRow in dt2.Rows)
            {
                staffBooking = Convert.ToInt16(myRow[0]);
            }
            MessageBox.Show("" + staffBooking);
            return Bookingid;

        }

    }
        
}
