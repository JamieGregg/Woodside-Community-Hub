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

namespace WoodsideCommunityHub
{
    public partial class rpt_bookingCharts : Form
    {
        userInterface interfaceClass;
        activity activity = new activity();
        activity orginalActivity;
        SqlDataAdapter activityAdapter;
        SqlCommandBuilder sqlBuilder;
        DataTable activityTable;
        string sqlActivitiy;
        

        public rpt_bookingCharts()
        {
            InitializeComponent();
        }

        public rpt_bookingCharts(ref userInterface tempInterfaceClass)
        {
            InitializeComponent();
            interfaceClass = tempInterfaceClass;
        }

        private void frm_activities_Load(object sender, EventArgs e)
        {
            try
            {
                //loading the icons, menu panel and text position
                interfaceClass.loadIcons(pbx_children, pbx_booking, pbx_transport, pbx_staff, pbx_activities);
                interfaceClass.isPanelOpenLoad(pnl_extended, pnL_hidden, interfaceClass.IsPanelOpen);

                //rpt_activities.RefreshReport();

                //Loading the listview and combobox
                activity.populateCombobox(cbx_selectedActivity, cbx_showLocation);
                activity.loadListView("acitivityName", lbv_showActivites);

                //Reading the activity table
                ReadTable();
            }
            catch(SqlException)
            {
                MessageBox.Show("There was a database connecttion error, this form will not load correctly");
            }
            catch
            {
                MessageBox.Show("There has been an error adding this record. Please contact your system administrator");
            }
        }

        //Menu System
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

                                    private void pnL_hidden_Paint(object sender, PaintEventArgs e)
                                    {

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

                                    }

                                    private void btn_activities_Click(object sender, EventArgs e)
                                    {

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
                                        frm_ListOfBookings obj = new frm_ListOfBookings(ref interfaceClass);
                                        this.Close();
                                        obj.Show();
                                    }


        //reads the activity table
        private void ReadTable()
        {
            string sql = sqlActivitiy = @"Select * From " + "Activity";
            activityAdapter = new SqlDataAdapter(sqlActivitiy, Program.GetConnectionString());
            sqlBuilder = new SqlCommandBuilder(activityAdapter);
            activityTable = new DataTable();
            activityAdapter.FillSchema(activityTable, SchemaType.Source);
            activityAdapter.Fill(activityTable);
        }

        //assigns values to a temporary class to compare if values have been changed when looking to save data
        private void cbx_selectedActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchActivities();
            orginalActivity = new activity();
            orginalActivity.ActivityName = txt_activityName.Text;
            orginalActivity.ActivityCost = Convert.ToDouble(txt_activityCost.Text);
            orginalActivity.ActivityCost = Convert.ToInt16(txt_classSize.Text);
            orginalActivity.LocationId = orginalActivity.findLocationId(lbl_id.Text);
        }

        //Searches for the activity when the user selects an activity from the combobox at the top
        private void searchActivities()
        {
            string activityName = cbx_selectedActivity.Text;
            txt_refine.Text = cbx_selectedActivity.Text;

            SqlDataAdapter staffAdapter = new SqlDataAdapter("SELECT activity.activityId, activity.acitivityName, activity.acitivityCost, activity.activityClassSize, activity.locationId, locations.locationName FROM Activity, Locations WHERE acitivityName = '" + cbx_selectedActivity.Text + "'", Program.GetConnectionString());
            {
                DataTable staffTable = new DataTable();
                staffAdapter.Fill(staffTable);

                decimal d = Convert.ToDecimal(staffTable.Rows[0]["acitivityCost"]);
                string d_format = string.Format("{0:f2}", d);
                txt_activityCost.Text = d_format;

                string actName;
                actName = activity.findLocationName(Convert.ToInt32(staffTable.Rows[0]["locationId"]));

                lbl_id.Text = Convert.ToString(staffTable.Rows[0]["activityId"]);
                txt_activityName.Text = Convert.ToString(staffTable.Rows[0]["acitivityName"]);
                txt_classSize.Text = Convert.ToString(staffTable.Rows[0]["activityClassSize"]);
                cbx_showLocation.Text = actName;
            }


        }

        //loads the listbox based on what is typed into the textbox
        private void txt_refine_TextChanged(object sender, EventArgs e)
        {
            lbv_showActivites.Items.Clear();

            DataTable dtt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dtt);
            SqlDataAdapter daa = new SqlDataAdapter("SELECT acitivityName, locationId  FROM Activity WHERE acitivityName LIKE '%" + txt_refine.Text + "%' OR acitivityCost LIKE '%" + txt_refine.Text + "%' OR locationId LIKE '%" + txt_refine.Text + "%'", Program.GetConnectionString());
            daa.Fill(dtt);

            foreach (DataRow myRow in dtt.Rows)
            {
                string locationName = Convert.ToString((activity.findLocationName(Convert.ToInt32(myRow[1]))));
                lbv_showActivites.Items.Add(myRow[0].ToString());
                lbv_showActivites.Items[lbv_showActivites.Items.Count - 1].SubItems.Add(locationName.ToString());
            }
        }

        //Orders the listbox by activity name
        private void btn_orderbyName_Click(object sender, EventArgs e)
        {
            activity.loadListView("acitivityName", lbv_showActivites);
        }

        //orders the listbox by activity cost
        private void btn_orderbyCost_Click(object sender, EventArgs e)
        {
            activity.loadListView("acitivityCost", lbv_showActivites);
        }

        //orders the listbox by location
        private void btn_orderByLocation_Click(object sender, EventArgs e)
        {
            activity.loadListView("locationId", lbv_showActivites);
        }

        //Method that validates the data entered
        private bool validation(string name, string cost, string size, string location)
        {
            //Hiding all the error icons
            pbx_name.Visible = false;
            pbx_classSzie.Visible = false;
            pbx_cost.Visible = false;
            pbx_location.Visible = false;

            //Hiding all the error messages
            lbl_nameEx.Visible = false;
            lbl_costEx.Visible = false;
            lbl_locationEx.Visible = false;
            lbl_sizeEx.Visible = false;

            bool costNum = int.TryParse(cost, out int resultCost);
            bool sizeNum = int.TryParse(size, out int resultSize);

            bool isValid = false;

            //Testing all the textboxes for invalid data
            if (name.Length < 2 || name.Length > 15 || name == "")
            {
                lbl_nameEx.Visible = true;
                pbx_name.Visible = true;
                isValid = false;
            }

            if (costNum == false || txt_activityCost.Text == "" || Convert.ToInt16(cost) < 5 || Convert.ToInt16(cost) > 10)
            {
                pbx_cost.Visible = true;
                lbl_costEx.Visible = true;
                isValid = false;
            }

            if (sizeNum == false || txt_classSize.Text == "" || Convert.ToInt16(size) < 5 || Convert.ToInt16(size) > 30)
            {
                pbx_classSzie.Visible = true;
                lbl_sizeEx.Visible = true;
                isValid = false;
            }
            if (location.Length < 8 || location.Length > 25 || location == "")
            {
                pbx_location.Visible = true;
                lbl_locationEx.Visible = true;
                isValid = false;
            }

            //Testing to see if all the textboxes have passed the validation checks
            if (pbx_name.Visible == false && pbx_cost.Visible == false && pbx_classSzie.Visible == false && pbx_location.Visible == false)
            {
                pbx_name.Visible = false;
                pbx_cost.Visible = false;
                pbx_classSzie.Visible = false;
                pbx_location.Visible = false;

                isValid = true;
            }

            //returning if the data is valid or not
            return isValid;
        }

        //adds an activity to the list
        private void addActivity()
        {
            DataRow newRow = activityTable.NewRow();
            activity = new activity();

            int locationId = activity.findLocationId(cbx_showLocation.Text);
            activity.createActivity(ref activity, Convert.ToInt16(activity.GetActivityId(ref activityTable)), txt_activityName.Text, Convert.ToInt32(txt_classSize.Text), locationId, Convert.ToDouble(txt_activityCost.Text));

            newRow["activityId"] = activity.ActivityId;
            newRow["acitivityName"] = activity.ActivityName;
            newRow["acitivityCost"] = activity.ActivityCost;
            newRow["activityClassSize"] = activity.ClassSize;
            newRow["locationId"] = activity.LocationId;
            activityTable.Rows.Add(newRow);
            activityAdapter.Update(activityTable);
        }

        //add activity button click
        private void btn_addActivity_Click(object sender, EventArgs e)
        {
            try
            {
                if (validation(txt_activityName.Text, txt_activityCost.Text, txt_classSize.Text, cbx_showLocation.Text) == false)
                {
                    MessageBox.Show("Please fill all fields correctly");
                }
                else if (activity.checkDuplication(txt_activityName.Text) == true)
                {
                    MessageBox.Show("This Activity already exisits");
                }
                else
                {
                    addActivity();
                    MessageBox.Show(txt_activityName.Text + " has been added to the system");
                    activity.loadListView("acitivityName", lbv_showActivites);
                    cbx_selectedActivity.Items.Clear();
                    activity.populateCombobox(cbx_selectedActivity, cbx_showLocation);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There has been an issue adding this record to the database");
            }
            catch
            {
                MessageBox.Show("There has been an error adding this activity");
            }

        }

        //this updates the records in the database
        private void saveEdits()
        {
            //Comparing if the activity has been edited
            if (activity.CompareValues(ref orginalActivity, txt_activityName.Text) == true)
            {
                MessageBox.Show("The activity name must be altered to edit an activity");
            }
            //validating the data entered
            else if (validation(txt_activityName.Text, txt_activityCost.Text, txt_classSize.Text, cbx_showLocation.Text) == false)
            {
                MessageBox.Show("Please enter in all fields correctly");
            }
            //Saving the data
            else
            {
                using (SqlConnection conn = new SqlConnection(Program.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Activity SET acitivityName = @actName, acitivityCost = @actCost, locationId = @actLocation, activityClassSize = @actClassSize  FROM Activity WHERE activityId=@Id", conn))
                    {
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Update Record", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                cmd.Parameters.AddWithValue("@Id", lbl_id.Text);
                                cmd.Parameters.AddWithValue("@actName", txt_activityName.Text);
                                cmd.Parameters.AddWithValue("@actCost", Convert.ToDouble(txt_activityCost.Text));
                                cmd.Parameters.AddWithValue("@actLocation", activity.findLocationId(cbx_showLocation.Text));
                                cmd.Parameters.AddWithValue("@actClassSize", Convert.ToInt16((txt_classSize.Text)));
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Activity Information Updated");

                                //Clearing the comboboxes
                                cbx_selectedActivity.Items.Clear();
                                cbx_showLocation.Items.Clear();

                                //Reloading the comboboxes and listboxes with new updated data
                                activity.populateCombobox(cbx_selectedActivity, cbx_showLocation);
                                activity.loadListView("acitivityName", lbv_showActivites);
                            }
                        }

                    }
                }
            }
        }

        //save button click event
        private void btn_saveEdits_Click(object sender, EventArgs e)
        {
            try
            {
                saveEdits();
            }
            catch (SqlException)
            {
                MessageBox.Show("There has been an error connecting with the database");
            }
            catch
            {
                MessageBox.Show("Sorry this record could not be updated");
            }
        }

        //Method to clear the data in textboxes and combobox
        private void clearData()
        {
            cbx_showLocation.Text = "";
            cbx_selectedActivity.Text = "";
            txt_activityCost.Text = string.Empty;
            txt_classSize.Text = string.Empty;
            txt_activityName.Text = string.Empty;
            txt_refine.Text = string.Empty;

        }

        //delete button click
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                activity.deleteRecord(lbv_showActivites, cbx_selectedActivity, cbx_showLocation, lbl_id);
                clearData();
            }
            catch (SqlException)
            {
                MessageBox.Show("This record could not be deleted from the database");
            }
            catch
            {
                MessageBox.Show("An error has occurred when deleting this record");
            }

        }

        //clear data click
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            clearData();
        }

        //changes the text position based if the menu system is open
        private void changeTextPosition( bool isOpen)
        {
            if (isOpen == false)
            {
                lbl_acitivityName.Location = new Point(162, 242);
                lbl_activityCost.Location = new Point(175, 332);
                lbl_classSize.Location = new Point(189, 412);
                lbl_location.Location = new Point(205, 505);
            }

            else
            {
                lbl_acitivityName.Location = new Point(290, 215);
                lbl_activityCost.Location = new Point(288, 305);
                lbl_classSize.Location = new Point(288, 385);
                lbl_location.Location = new Point(288, 470);
            }
        }

        //ensures the validation of the cost of the activity
        private void txt_activityCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(txt_activityCost.Text, @"\.") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_acitivityName_Click(object sender, EventArgs e)
        {

        }

        private void txt_activityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nameEx_Click(object sender, EventArgs e)
        {

        }

        private void pbx_name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ActivityBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BookingBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    
}
