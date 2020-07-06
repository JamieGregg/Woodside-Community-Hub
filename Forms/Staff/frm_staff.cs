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
    public partial class frm_staff : Form
    {
        userInterface interfaceClass;
        staff staffFeatures = new staff();
        staff staff;
        String sqlStaff;
        staff originalStaff;
        DataTable staffTable;
        SqlDataAdapter sqlAdapter;
        SqlCommandBuilder sqlBuilder;
        DataSet dtStaff = new DataSet();


        public frm_staff()
        {
            InitializeComponent();
        }

        public frm_staff(ref userInterface tempUserInterface)
        {
            InitializeComponent();
            interfaceClass = tempUserInterface;
        }

        private void frm_staff_Load(object sender, EventArgs e)
        {
            try
            {
                //Loads the icons, menu panels and sets text position 
                interfaceClass.loadIcons(pbx_children, pbx_booking, pbx_transport, pbx_staff, pbx_activities);
                interfaceClass.isPanelOpenLoad(pnl_extended, pnL_hidden, interfaceClass.IsPanelOpen);
                changeTextPosition(lbl_firstName, lbl_surname, lbl_address, lbl_staffContactNo, interfaceClass.IsPanelOpen);

                //Loads the combobox at the top of the screen
                staffFeatures.populateCombobox(cbx_selectedStaff);

                //loads the listview
                loadListview("staffFirstname");

                //Reads the staff table
                ReadTable();
                
            }
            catch(CustomException)
            {
                //Defined in the Custom Exception Class
            }
            catch(Exception)
            {
                MessageBox.Show("There has been an error, do you wish to close the program", "Error 404", MessageBoxButtons.YesNo);

                if(DialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                    dgv_showBookings obj = new dgv_showBookings();
                    this.Close();
                    obj.Show();
                }
            }
        }
    
                                //Menu System
                                private void btn_booking_Click(object sender, EventArgs e)
                                {
                                    tmr_booking.Start();
                                }

                                private void btn_staff_Click(object sender, EventArgs e)
                                {

                                }

                                private void pbx_show_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.panelOpen(pnl_extended, pnL_hidden);
                                    changeTextPosition(lbl_firstName, lbl_surname, lbl_address, lbl_staffContactNo, true);
                                }

                                private void pbx_hide_Click_1(object sender, EventArgs e)
                                {
                                    interfaceClass.panelClosed(pnl_extended, pnL_hidden);
                                    changeTextPosition(lbl_firstName, lbl_surname, lbl_address, lbl_staffContactNo, false);
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

                                private void btn_booking_Click_1(object sender, EventArgs e)
                                {
                                    tmr_booking.Start();
                                }

                                private void tmr_booking_Tick_1(object sender, EventArgs e)
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

                                private void btn_m1Sub1_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                    frm_booking obj = new frm_booking(ref interfaceClass);
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

                                private void btn_activities_Click(object sender, EventArgs e)
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

                                private void pbx_activities_Click(object sender, EventArgs e)
                                {
                                    interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                                    rpt_bookingCharts obj = new rpt_bookingCharts(ref interfaceClass);
                                    this.Close();
                                    obj.Show();
                                }

        //reads the staff table
        private void ReadTable()
        {
            try
            {
                string sql = sqlStaff = @"Select * From " + "Staff";
                sqlAdapter = new SqlDataAdapter(sqlStaff, Program.GetConnectionString());
                sqlBuilder = new SqlCommandBuilder(sqlAdapter);
                staffTable = new DataTable();
                sqlAdapter.FillSchema(staffTable, SchemaType.Source);
                sqlAdapter.Fill(staffTable);
            }
            catch
            {
                throw new CustomException();
            }
        }

        //searches the database for staff
        private void searchStaff()
        {
            string staffName = staffFeatures.findFirstName(cbx_selectedStaff.Text);
            txt_refine.Text = staffName;

            try
            {
                SqlDataAdapter staffAdapter = new SqlDataAdapter("SELECT * FROM Staff WHERE staffFirstname = '" + staffName + "'", Program.GetConnectionString());
                {
                    DataTable staffTable = new DataTable();
                    staffAdapter.Fill(staffTable);

                    lbl_id.Text = Convert.ToString(staffTable.Rows[0]["staffId"]);
                    txt_staffFirstName.Text = Convert.ToString(staffTable.Rows[0]["staffFirstname"]);
                    txt_staffSurname.Text = Convert.ToString(staffTable.Rows[0]["staffSurname"]);
                    txt_staffContactNo.Text = Convert.ToString(staffTable.Rows[0]["staffContactNo"]);
                    txt_address.Text = Convert.ToString(staffTable.Rows[0]["staffAddress"]);
                }
            }
            catch
            {
                throw new CustomException();
            }
        }

        //this adds staff member to the database
        private void AddStaff()
        {
            try
            {
                ReadTable();
                DataRow newRow = staffTable.NewRow();
                staff = new staff();

                int staffId = Convert.ToInt16(staff.GetStaffId(ref staffTable));
                staff.CreateStaff(ref staff, staffId, txt_staffFirstName.Text, txt_staffSurname.Text, txt_address.Text, txt_staffContactNo.Text);

                newRow["staffId"] = staff.StaffId;
                newRow["staffFirstname"] = staff.FirstName;
                newRow["staffSurname"] = staff.Surname;
                newRow["staffAddress"] = staff.Address;
                newRow["staffContactNo"] = staff.ContactNo;
                staffTable.Rows.Add(newRow);
                sqlAdapter.Update(staffTable);
            }
            catch
            {
                throw new CustomException();
            }
        }

        //click event for the add staff button
        private void btn_addChild_Click(object sender, EventArgs e)
        {
            try
            {
                if (validation(txt_staffFirstName.Text, txt_staffSurname.Text, txt_staffContactNo.Text, txt_address.Text) == false)
                {
                    MessageBox.Show("Please format all fields correctly");
                }
                else
                {
                    //Adding the staff member
                    AddStaff();

                    //Reloading data
                    loadListview("staffFirstname");
                    staffFeatures.populateCombobox(cbx_selectedStaff);

                    MessageBox.Show(txt_staffFirstName.Text + " has been added as a Staff Member");
                    clearData();
                }
            }
            catch (CustomException)
            {
                //Defined in the custom class
            }
            catch
            {
                MessageBox.Show("There has been an error adding this record. Please contact your system administrator");
            }
        }

        //adds staff to a temporary class to comapre if any data was changed when updating the database
        private void cbx_selectedStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchStaff();
            originalStaff = new staff();
            originalStaff.FirstName = txt_staffFirstName.Text;
            originalStaff.Surname = txt_staffSurname.Text;
            originalStaff.ContactNo = txt_staffContactNo.Text;
            originalStaff.Address = txt_address.Text;
        }

        //Updating the listbox based on the textbox above it 
        private void txt_refine_TextChanged(object sender, EventArgs e)
        {
            lbv_showStaff.Items.Clear();

            try
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                SqlDataAdapter da = new SqlDataAdapter("SELECT staffFirstname, staffSurname FROM Staff WHERE staffFirstname LIKE '%" + txt_refine.Text + "%'" + " OR staffSurname LIKE '%" + txt_refine.Text + "%'", Program.GetConnectionString());
                da.Fill(dt);

                foreach (DataRow myRow in dt.Rows)
                {
                    lbv_showStaff.Items.Add(myRow[0].ToString());
                    lbv_showStaff.Items[lbv_showStaff.Items.Count - 1].SubItems.Add(myRow[1].ToString());
                }
            }
            catch
            {
                throw new CustomException();
            }
            
        }

        //sorting the listbox based on a parameter
        private void loadListview(string OrderBy)
        {
            try
            {
                lbv_showStaff.Items.Clear();

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                SqlDataAdapter da = new SqlDataAdapter("SELECT staffFirstName, staffSurname FROM Staff ORDER BY " + OrderBy, Program.GetConnectionString());
                da.Fill(dt);

                foreach (DataRow myRow in dt.Rows)
                {
                    lbv_showStaff.Items.Add(myRow[0].ToString());
                    lbv_showStaff.Items[lbv_showStaff.Items.Count - 1].SubItems.Add(myRow[1].ToString());
                    //lbv_showStaff.Items[lbv_showStaff.Items.Count - 1].SubItems.Add(myRow[2].ToString());
                }
            }
            catch
            {
                throw new CustomException();
            }
            
        }

        //orders the listbox by first name
        private void btn_orderbyFirstName_Click(object sender, EventArgs e)
        {
            try
            {
                loadListview("staffFirstname");
            }
            catch(CustomException)
            {
                //Action defined in the custom exception class
            }
            
        }

        //orders the listbox by second name
        private void btn_orderbySurname_Click(object sender, EventArgs e)
        {
            try
            {
                loadListview("staffSurname");
            }
            catch (CustomException)
            {
                //Action defined in the custom exception class
            }
        }

        //method that saves the edits to the database
        private void saveEdits()
        {
            try
            {
                //Comparing to see if any information has been updated
                if (CompareValues(ref originalStaff, txt_staffFirstName.Text, txt_staffSurname.Text, txt_address.Text, txt_staffContactNo.Text) == true)
                {
                    MessageBox.Show("No information has been changed");
                }
                //Testing if all the information is valid
                else if (validation(txt_staffFirstName.Text, txt_staffSurname.Text, txt_staffContactNo.Text, txt_address.Text) == false)
                {
                    MessageBox.Show("Please enter in all fields correctly");
                }
                //Updating the staff member
                else
                {
                    using (SqlConnection conn = new SqlConnection(Program.GetConnectionString()))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE Staff SET staffFirstname =@firstname, staffSurname =@surname, staffAddress =@address, staffContactNo =@contactNo WHERE staffId=@Id", conn))
                        {
                            {
                                //Ensuring the user is sure with the decision
                                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Update Record", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    cmd.Parameters.AddWithValue("@Id", lbl_id.Text);
                                    cmd.Parameters.AddWithValue("@firstname", txt_staffFirstName.Text);
                                    cmd.Parameters.AddWithValue("@surname", txt_staffSurname.Text);
                                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                                    cmd.Parameters.AddWithValue("@contactNo", txt_staffContactNo.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show(txt_staffFirstName.Text + " has been updated");

                                    //Clearing and reloading the data
                                    staffFeatures.populateCombobox(cbx_selectedStaff);
                                    loadListview("staffFirstname");
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                throw new CustomException();
            }
        }

        //save edits click event
        private void btn_saveEdits_Click(object sender, EventArgs e)
        {
            try
            {
                saveEdits();
            }
            catch (CustomException)
            {
                //Defined in the custom class
            }
            catch
            {
                MessageBox.Show("Conact your system manager, there has been an error updating this record");
            }
        }

        //delete button click
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            { 
                if (validation(txt_staffFirstName.Text, txt_staffSurname.Text, txt_staffContactNo.Text, txt_address.Text) == false)
                {
                    MessageBox.Show("Please enter in all fields correctly");
                }
                else
                {
                    //Delete the record
                    staffFeatures.deleteRecord(lbv_showStaff, cbx_selectedStaff, lbl_id, txt_staffFirstName.Text, txt_staffSurname.Text, txt_staffContactNo.Text, txt_address.Text);

                    //Reloads and clears the data
                    loadListview("staffFirstname");
                    clearData();
                }
            }
            catch(CustomException)
            {
                //Action Defined in the Custom Exception class
            }
            catch
            {
                MessageBox.Show("There has been an issue deleting this record, please contact a manager");
            }
        }

        //validates the data 
        private bool validation(string firstName, string surname, string contactNo, string address)
        {
            pbx_firstName.Visible = false;
            pbx_surname.Visible = false;
            pbx_address.Visible = false;
            pbx_contactNo.Visible = false;

            lbl_firstNameEx.Visible = false;
            lbl_surnameEx.Visible = false;
            lbl_addressEx.Visible = false;
            lbl_contactEx.Visible = false;

            bool isValid = false;

            if (firstName.Length < 2 || firstName.Length > 15 || firstName == "")
            {
                pbx_firstName.Visible = true;
                lbl_firstNameEx.Visible = true ;
                isValid = false;
            }
            if (surname.Length < 2 || surname.Length > 15 || surname == "")
            {
                pbx_surname.Visible = true;
                lbl_surnameEx.Visible = true;
                isValid = false;
            }

            if (address.Length < 4 || address.Length > 25 || address == "")
            {
                lbl_addressEx.Visible = true;
                pbx_address.Visible = true;
                isValid = false;
            }
            if (contactNo.Length < 8 || contactNo.Length > 12 || contactNo == "")
            {
                pbx_contactNo.Visible = true;
                lbl_contactEx.Visible = true;
                isValid = false;
            }

            if (pbx_firstName.Visible == false && pbx_surname.Visible == false && pbx_address.Visible == false && pbx_contactNo.Visible == false)
            {
                pbx_firstName.Visible = false;
                pbx_surname.Visible = false;
                pbx_address.Visible = false;
                pbx_contactNo.Visible = false;

                lbl_firstNameEx.Visible = false;
                lbl_surnameEx.Visible = false;
                lbl_addressEx.Visible = false;
                lbl_contactEx.Visible = false;

                isValid = true;
            }
            return isValid;

        }

        //Compares if this record already exsists
        private bool CompareValues(ref staff staff, string firstName, string surname, string address, string contactNo)
        {
            if (originalStaff.FirstName == firstName && originalStaff.Surname == surname && originalStaff.ContactNo == contactNo && originalStaff.Address == address)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Method to clear the data in the textboxs and comboboxes
        private void clearData()
        {
            txt_refine.Text = string.Empty;
            txt_staffFirstName.Text = string.Empty;
            txt_staffSurname.Text = string.Empty;
            txt_staffContactNo.Text = string.Empty;
            txt_address.Text = string.Empty;
        }

        //clear data button click
        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        //moves the text based on if the side menu panel is open
        private void changeTextPosition(Label firstname, Label surname, Label address, Label contactNO, bool isOpen)
        {
            if (isOpen == false)
            {
                firstname.Location = new Point(175, 210);
                surname.Location = new Point(192, 298);
                address.Location = new Point(195, 385);
                contactNO.Location = new Point(133, 465);
            }
            else
            {
                firstname.Location = new Point(281, 186);
                surname.Location = new Point(281, 277);
                address.Location = new Point(281, 360);
                contactNO.Location = new Point(280, 441);
            }
        }
    }
}

