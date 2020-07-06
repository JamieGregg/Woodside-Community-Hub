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
    public partial class frm_children : Form
    {
        userInterface interfaceClass;
        DataTable childTable;
        children child;
        children childFeatures = new children();
        children OriginalChild;
        SqlDataAdapter sqlAdapter;
        SqlCommandBuilder sqlBuilder;
        DataSet dtChidren = new DataSet();
        String cnstr, sqlcustomer;


        public frm_children()
        {
            InitializeComponent();
        }

        public frm_children(ref userInterface userInterface)
        {
            InitializeComponent();
            interfaceClass = userInterface;
        }

        private void frm_children_Load(object sender, EventArgs e)
        {
            try
            {
                //Loafing the interface (Icons, Menu Strip and text position)
                interfaceClass.loadIcons(pbx_children, pbx_booking, pbx_transport, pbx_staff, pbx_activities);
                interfaceClass.isPanelOpenLoad(pnl_extended, pnL_hidden, interfaceClass.IsPanelOpen);
                changeTextPosition(lbl_firstName, lbl_surname, lbl_age, lbl_parentName, lbl_parentContactNo, lbl_doctorName, lbl_childAddress, interfaceClass.IsPanelOpen);

                //Loading the listboxes and comboboxes on the form
                childFeatures.loadListView("childFirstName", lbv_showChildren);
                childFeatures.populateCombobox(cbx_selectedChild);

                //Reading the children tale from the database
                ReadTable();
                
            }
            catch(CustomException)
            {
                MessageBox.Show("There has been an error, would you like to progress anyway");
            }
            catch 
            {
                MessageBox.Show("There was a database connection error, this form will not load correctly");
            }
        }

                        //Menu System 
                        private void btn_booking_Click(object sender, EventArgs e)
                        {
                            tmr_booking.Start();
                        }

                        private void pbx_hide_Click(object sender, EventArgs e)
                        {
                            interfaceClass.panelClosed(pnl_extended, pnL_hidden);
                            changeTextPosition(lbl_firstName, lbl_surname, lbl_age, lbl_parentName, lbl_parentContactNo, lbl_doctorName, lbl_childAddress, false);
                        }

                        private void pbx_show_Click(object sender, EventArgs e)
                        {
                            interfaceClass.panelOpen(pnl_extended, pnL_hidden);
                            changeTextPosition(lbl_firstName, lbl_surname, lbl_age, lbl_parentName, lbl_parentContactNo, lbl_doctorName, lbl_childAddress, true);
                        }

                        private void tmr_booking_Tick(object sender, EventArgs e)
                        {
                            interfaceClass.IsBookingClosed = interfaceClass.collapsableMenu(interfaceClass.IsBookingClosed, pnl_booking, tmr_booking, btn_children, btn_transport, btn_activities, btn_booking, btn_staff);
                        }

                        private void pbx_children_Click(object sender, EventArgs e)
                        {
                            interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                            frm_children obj = new frm_children(ref interfaceClass);
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

                        private void pbx_staff_Click(object sender, EventArgs e)
                        {
                            interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                            frm_staff obj = new frm_staff(ref interfaceClass);
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

                        private void pbx_woodsideLogo_Click(object sender, EventArgs e)
                        {
                            interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                            dgv_showBookings obj = new dgv_showBookings();
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

                        private void pbx_transport_MouseEnter(object sender, EventArgs e)
                        {
                            pbx_transport.Image = Properties.Resources.transport_highlighted;
                        }

                        private void pbx_transport_MouseLeave(object sender, EventArgs e)
                        {
                            pbx_transport.Image = Properties.Resources.transport_white;
                        }

                        private void pbx_activities_MouseLeave(object sender, EventArgs e)
                        {
                            pbx_activities.Image = Properties.Resources.trophy_white;
                        }

                        private void pbx_activities_MouseEnter(object sender, EventArgs e)
                        {
                            pbx_activities.Image = Properties.Resources.trophy_highlighted;
                        }

                        private void pbx_staff_MouseEnter(object sender, EventArgs e)
                        {
                            pbx_staff.Image = Properties.Resources.staff_highlighted_copy_copy;
                        }

                        private void pbx_staff_MouseLeave(object sender, EventArgs e)
                        {
                            pbx_staff.Image = Properties.Resources.staff_white;
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

                        private void btn_m1Sub1_MouseClick(object sender, MouseEventArgs e)
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

                        private void btn_m1Sub2_Click(object sender, EventArgs e)
                        {
                            interfaceClass.IsPanelOpen = interfaceClass.checkPanel(pnl_extended);
                            frm_ListOfBookings obj = new frm_ListOfBookings(ref interfaceClass);
                            this.Close();
                            obj.Show();
                        }

       

        //searches the for children in the database
        private void searchChildren()
        {
                string childName = childFeatures.findFirstName(cbx_selectedChild.Text);
                txt_refine.Text = childName;
                
                SqlDataAdapter childAdapter = new SqlDataAdapter("SELECT * FROM Child WHERE childFirstName = '" + childName + "'", Program.GetConnectionString());
                {
                    DataTable childTable = new DataTable();
                    childAdapter.Fill(childTable);
                    ID.Text = Convert.ToString(childTable.Rows[0]["childId"]);
                    txt_childFirstName.Text = Convert.ToString(childTable.Rows[0]["childFirstName"]);
                    txt_childSurname.Text = Convert.ToString(childTable.Rows[0]["childSurname"]);
                    txt_childAge.Text = Convert.ToString(childTable.Rows[0]["childAge"]);
                    txt_parentName.Text = Convert.ToString(childTable.Rows[0]["parentName"]);
                    txt_parentContact.Text = Convert.ToString(childTable.Rows[0]["parentContactNo"]);
                    txt_doctorName.Text = Convert.ToString(childTable.Rows[0]["docotorName"]);
                    txt_address.Text = Convert.ToString(childTable.Rows[0]["childAddress"]);
                }
        }

        //Compares if the child entered already exists 
        private bool CompareValues(ref children child ,string firstName, string surname, int age, string parentName, string parentContactNo, string doctorname, string address)
        {
            if(child.FirstName == firstName && child.Surname == surname && child.Age == age && child.ParentName == parentName && child.ParentContactNo == parentContactNo && child.DoctorName == doctorname && child.Address == address)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        //assigns values to a temporary class (Allows me to test later if anything has changed) 
        private void cbx_selectedChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchChildren();
            OriginalChild = new children();
            OriginalChild.Age = Convert.ToInt16(txt_childAge.Text);
            OriginalChild.FirstName = txt_childFirstName.Text;
            OriginalChild.Surname = txt_childSurname.Text;
            OriginalChild.ParentContactNo = txt_parentContact.Text;
            OriginalChild.DoctorName = txt_doctorName.Text;
            OriginalChild.Address = txt_address.Text;
            OriginalChild.ParentName = txt_parentName.Text;
        }

        //Method that clears the textboxs and comboboxes
        private void clearData()
        {
            txt_childAge.Text = string.Empty;
            txt_childFirstName.Text = string.Empty;
            txt_childSurname.Text = string.Empty;
            txt_parentContact.Text = string.Empty;
            txt_doctorName.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_parentName.Text = string.Empty;
            cbx_selectedChild.Text = "";
            cbx_selectedChild.Items.Clear();
            childFeatures.populateCombobox(cbx_selectedChild);
        }

        //Reads the child table
        private void ReadTable()
        {
            try
            {
                string sql = sqlcustomer = @"Select * From " + "Child";
                sqlAdapter = new SqlDataAdapter(sqlcustomer, Program.GetConnectionString());
                sqlBuilder = new SqlCommandBuilder(sqlAdapter);
                childTable = new DataTable();
                sqlAdapter.FillSchema(childTable, SchemaType.Source);
                sqlAdapter.Fill(childTable);
            }
            catch
            {
                throw new CustomException();
            }
        }

        //Method to add a child to the database
        private void AddChild()
        {
            try
            {
                DataRow newRow = childTable.NewRow();
                child = new children();
                child.CreateChild(ref child, Convert.ToInt16(child.GetChildId(ref childTable)), txt_childFirstName.Text, txt_childSurname.Text, Convert.ToInt16(txt_childAge.Text), txt_parentName.Text, txt_parentContact.Text, txt_doctorName.Text, txt_address.Text);

                newRow["childI"] = child.ChildId;
                newRow["childFirstname"] = child.FirstName;
                newRow["childSurname"] = child.Surname;
                newRow["childAge"] = child.Age;
                newRow["parentName"] = child.ParentName;
                newRow["parentContactNo"] = child.ParentContactNo;
                newRow["docotorName"] = child.DoctorName;
                newRow["childAddress"] = child.Address;
                childTable.Rows.Add(newRow);
                sqlAdapter.Update(childTable);
            }
            catch
            {
                throw new CustomException();
            }
           
        }

        //Action to add button click
        private void btn_addChild_Click(object sender, EventArgs e)
        {
            int number;
            bool success = Int32.TryParse(txt_childAge.Text, out number);
            try
            {
                if (validation(txt_childFirstName.Text, txt_childSurname.Text, txt_parentName.Text, txt_parentContact.Text, txt_doctorName.Text, txt_address.Text) == false)
                {
                    MessageBox.Show("Please enter all fields correctly");
                }
                else
                {
                    //Adds a child to the system
                    AddChild();

                    MessageBox.Show(txt_childFirstName.Text + " has been added to the system");

                    //Reloads the Listbox and clears the fields
                    childFeatures.loadListView("childFirstName", lbv_showChildren);
                    clearData();
                }
            }
            catch(CustomException)
            {

            }
            catch
            {
                MessageBox.Show("There has been an issue deleting this record please contact your manager");
            }
            
        }

        //delete button click
        private void btn_deleteChild_Click(object sender, EventArgs e)
        {
            try
            {
                childFeatures.deleteRecord(lbv_showChildren, cbx_selectedChild, ID, txt_childFirstName.Text, txt_childSurname.Text, txt_childAge.Text, txt_parentName.Text, txt_parentContact.Text, txt_doctorName.Text, txt_address.Text);
                clearData();
            }
            catch
            {
                MessageBox.Show("There has been an error deleting this child");
            }

        }

        //Method update the data method
        private void updateData()
        {
            int age = Convert.ToInt16(txt_childAge.Text);
            string firstname = txt_childFirstName.Text;
            string surname = txt_childSurname.Text;
            string parentContactNo = txt_parentContact.Text;
            string doctorName = txt_doctorName.Text;
            string address = txt_address.Text;
            string parentName = txt_parentName.Text;

            //Tests if data exsists
            if (CompareValues(ref OriginalChild, firstname, surname, age, parentName, parentContactNo, doctorName, address) == true)
            {
                MessageBox.Show("No information has been changed");
            }
            else
            {
                //Implements the changes to the database
                using (SqlConnection conn = new SqlConnection(Program.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Child SET childFirstname =@firstname, childSurname =@surname, childAge =@age, parentName =@parentName, parentContactNo =@parentcontactNo, docotorName =@doctorname, childAddress =@address  WHERE childId=@Id", conn))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Update Record", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            cmd.Parameters.AddWithValue("@Id", ID.Text);
                            cmd.Parameters.AddWithValue("@firstname", txt_childFirstName.Text);
                            cmd.Parameters.AddWithValue("@surname", txt_childSurname.Text);
                            cmd.Parameters.AddWithValue("@age", txt_childAge.Text);
                            cmd.Parameters.AddWithValue("@parentname", txt_parentName.Text);
                            cmd.Parameters.AddWithValue("@parentcontactNo", txt_parentContact.Text);
                            cmd.Parameters.AddWithValue("@doctorName", txt_doctorName.Text);
                            cmd.Parameters.AddWithValue("@address", txt_address.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Child information Updated");
                            clearData();
                            childFeatures.loadListView("childFirstName", lbv_showChildren);
                        }
                    }
                }
            }
        }

        //Action that save edits 
        private void btn_saveEdits_Click(object sender, EventArgs e)
        {
            int number;
            bool success = Int32.TryParse(txt_childAge.Text, out number);

            try
            {
                if (validation(txt_childFirstName.Text, txt_childSurname.Text, txt_parentName.Text, txt_parentContact.Text, txt_doctorName.Text, txt_address.Text) == false)
                {
                    MessageBox.Show("Please enter all fields correctly");
                }
                else
                {
                    updateData();
                }
            }
            catch
            {
                MessageBox.Show("There has been an error updating the data");
            }
        }

        //loading listbox based on the text box above it
        private void txt_refine_TextChanged(object sender, EventArgs e)
        {
            lbv_showChildren.Items.Clear();

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            SqlDataAdapter da = new SqlDataAdapter("SELECT childFirstName, childSurname, childAge FROM Child WHERE childFirstName  LIKE '%" + txt_refine.Text + "%'" + "OR childSurname LIKE '%" + txt_refine.Text + "%'" + "OR childAge LIKE '%" + txt_refine.Text + "%'", Program.GetConnectionString());
            da.Fill(dt);

            foreach (DataRow myRow in dt.Rows)
            {
                lbv_showChildren.Items.Add(myRow[0].ToString());
                lbv_showChildren.Items[lbv_showChildren.Items.Count - 1].SubItems.Add(myRow[1].ToString());
                lbv_showChildren.Items[lbv_showChildren.Items.Count - 1].SubItems.Add(myRow[2].ToString());
            }
        }

        //ordering the listbox based on first name 
        private void button1_Click(object sender, EventArgs e)
        {
            childFeatures.loadListView("childFirstName", lbv_showChildren);
        }

        //ordering the listbox by the surname 
        private void btn_orderbySurname_Click(object sender, EventArgs e)
        {
            childFeatures.loadListView("childSurname", lbv_showChildren);
        }

        //ordering the listbox based on age
        private void btn_orderbyAge_Click(object sender, EventArgs e)
        {
            childFeatures.loadListView("childAge", lbv_showChildren);
        }

        //clear data button clikc
        private void button1_Click_1(object sender, EventArgs e)
        {
            clearData();
        }

        //changes the position of the text labels depending if the side panel is open or not 
        private void changeTextPosition(Label firstname, Label surname, Label age, Label parentName, Label parentContactNo, Label DoctorNo, Label childAddress, bool isOpen)
        {
            if (isOpen == false)
            {
                firstname.Location = new Point(185, 205);
                surname.Location = new Point(195, 270);
                age.Location = new Point(240, 340);
                parentName.Location = new Point(163, 410);
                parentContactNo.Location = new Point(80, 470);
                DoctorNo.Location = new Point(165, 540);
                childAddress.Location = new Point(160, 600);
            }

            else
            {
                firstname.Location = new Point(290, 180);
                surname.Location = new Point(290, 250);
                age.Location = new Point(290, 315);
                parentName.Location = new Point(290, 385);
                parentContactNo.Location = new Point(290, 450);
                DoctorNo.Location = new Point(290, 515);
                childAddress.Location = new Point(290, 576);
            }
        }

        private void clearData_Click(object sender, EventArgs e)
        {

        }

        //validates the data
        private bool validation(string firstName, string surname,  string parentName, string parentContactNo, string doctorname, string address)
        {
            pbx_firstName.Visible = false;
            pbx_surname.Visible = false;
            pbx_age.Visible = false;
            pbx_parentName.Visible = false;
            pbx_parentContactNo.Visible = false;
            pbx_address.Visible = false;
            pbx_doctorName.Visible = false;


            bool isValid = false;
            if (firstName.Length < 2 || firstName.Length > 15 || firstName == "")
            {
                pbx_firstName.Visible = true;
                isValid = false;
            }
            if (surname.Length < 2 || surname.Length > 15 | surname == "")
            {
                pbx_surname.Visible = true;
                isValid = false;
            }
           
             if (parentName.Length < 4 || parentName.Length > 25 || parentName == "")
            {
                pbx_parentName.Visible = true;
                isValid = false;
            }
            if (parentContactNo.Length < 8 || parentContactNo.Length > 12 || parentContactNo == "")
            {
                pbx_parentContactNo.Visible = true;
                isValid = false;
            }
            if(doctorname.Length < 2 || doctorname.Length > 25 || doctorname == "")
            {
                pbx_doctorName.Visible = true;
                isValid = false;
            }
            if(address.Length < 2 || address.Length >25 || address == "")
            {
                pbx_address.Visible = true;
                isValid = false;
            }

            if (pbx_firstName.Visible == false && pbx_surname.Visible == false && pbx_age.Visible == false && pbx_parentName.Visible == false &&pbx_parentContactNo.Visible == false && pbx_address.Visible == false && pbx_doctorName.Visible == false)
            {
                pbx_firstName.Visible = false;
                pbx_surname.Visible = false;
                pbx_age.Visible = false;
                pbx_parentName.Visible = false;
                pbx_parentContactNo.Visible = false;
                pbx_address.Visible = false;
                pbx_doctorName.Visible = false;
                isValid = true;
            }
            return isValid;

        }
    }
}

