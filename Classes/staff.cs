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
    class staff
    {
        private int staffId;
        private string firstName;
        private string surname;
        private string address;
        private string contactNo;

        public staff()
        {
            staffId = 0;
            firstName = "";
            surname = "";
            address = "";
            contactNo = "";
        }

        public staff(string _firstName, string _surname, string _address, string _contactNo, int _staffid)
        {
            firstName = _firstName;
            surname = _surname;
            address = _address;
            contactNo = _contactNo;
            staffId = _staffid;
        }

        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }

        //Populating the combobox with Staff Names
        public void populateCombobox(ComboBox selectedStaff)
        {
            try
            {
                selectedStaff.Items.Clear();
                SqlDataAdapter Staff = new SqlDataAdapter("SELECT * FROM Staff", Program.GetConnectionString());
                {
                    DataTable staffTable = new DataTable();
                    Staff.Fill(staffTable);

                    for (int i = 0; i < staffTable.Rows.Count; i++)
                    {
                        string surname = Convert.ToString((staffTable.Rows[i]["staffSurname"]));
                        string firstname = Convert.ToString((staffTable.Rows[i]["staffFirstname"]));
                        selectedStaff.Items.Add(firstname + " " + surname);
                    }
                }
            }
            catch
            {
                throw new CustomException();
            }
            
            
        }

        //Creates an instance of a record in the Staff Class
        public void CreateStaff(ref staff staff, int staffId, string firstname, string surname, string address, string contactNo)
        {
            staff.StaffId = staffId;
            staff.FirstName = firstname;
            staff.Surname = surname;
            staff.Address = address;
        }

        //Finds a unique staff ID
        public string GetStaffId(ref DataTable staffTable)
        {
            DataRow drLastRow;
            string lastStaffId;
            string newStaffID;
            int lastRecord;

            lastRecord = staffTable.Rows.Count;
            drLastRow = staffTable.Rows[lastRecord - 1];
            lastStaffId = drLastRow["staffId"].ToString();
            newStaffID = (int.Parse(lastStaffId) + 1).ToString();
            return newStaffID;
        }

        //Deletes a Staff Memver
        public void deleteRecord(ListView showStaff, ComboBox selectedBooking, Label ID, string firstname, string surname, string  contact, string address)
        {
            try
            {
                //Creating instances of the staff class
                staff methods = new staff();
                DataTable staffTable = new DataTable();

                //Loading the adapter with the details of a booking based on the staff member
                SqlDataAdapter bookingValues = new SqlDataAdapter("SELECT bookingId FROM StaffBooking WHERE staffId = " + staffId, Program.GetConnectionString());
                {
                    bookingValues.Fill(staffTable);
                    bool complete = false;
                    using (SqlConnection con = new SqlConnection(Program.GetConnectionString()))
                    {
                        con.Open();
                        //Creating the commands to delete the data from all the appropriate tables
                        using (SqlCommand commandBookingStaff = new SqlCommand("DELETE FROM staffBooking WHERE staffId = " + ID.Text, con))
                        using (SqlCommand commandBookingChild = new SqlCommand("DELETE FROM BookingChild WHERE bookingId = " + findBookingId(Convert.ToInt16(ID.Text)), con))
                        using (SqlCommand commandBooking = new SqlCommand("DELETE FROM Booking WHERE bookingId = " + findBookingId(Convert.ToInt16(ID.Text)), con))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Staff WHERE staffId = " + ID.Text, con))
                        {
                            if (selectedBooking.Text != null)
                            {
                                //Ensuring the user is sure about this action
                                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    //Executing the commands
                                    commandBookingStaff.ExecuteNonQuery();
                                    commandBookingChild.ExecuteNonQuery();
                                    commandBooking.ExecuteNonQuery();
                                    command.ExecuteNonQuery();

                                    MessageBox.Show(firstname + " has been deleted");

                                    //Reloading the data
                                    methods.populateCombobox(selectedBooking);
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                            }

                            else
                            {
                                MessageBox.Show("Please select a Staff Member");
                            }
                        }
                        con.Close();
                    }
                }
            }
            catch
            {
                throw new CustomException();
            }
            
        }

        //Finds the booking ID Assosiated with a staff member
        public int findBookingId(int staffId)
        {
            SqlDataAdapter bookingValues = new SqlDataAdapter("SELECT bookingId FROM StaffBooking WHERE staffId = " + staffId, Program.GetConnectionString());
            {
                DataTable staffTable = new DataTable();
                bookingValues.Fill(staffTable);

                if(staffTable.Rows.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt16(staffTable.Rows[0]["bookingId"]);
                }

            }
        }

        //Breakind down a full name into just the first name
        public string findFirstName(string name)
        {
            return name.Substring(0, name.IndexOf(' '));
        }

    }

}
