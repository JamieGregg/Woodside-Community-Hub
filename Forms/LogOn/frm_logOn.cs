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
    public partial class frm_logOn : Form
    {
        public frm_logOn()
        {
            InitializeComponent();
        }

        private void frm_logOn_Load(object sender, EventArgs e)
        {
        }

        //Hiding password method
        private void displayPassword(TextBox passwordBox)
        {
            passwordBox.UseSystemPasswordChar = false;
        }

        //Showing Password method
        private void showPassword(TextBox passwordBox)
        {
            passwordBox.UseSystemPasswordChar = true;
        }

        //Action to show password
        private void pbx_showPasswordLogIn_MouseEnter(object sender, EventArgs e)
        {
            displayPassword(txt_password);
        }

        //Action to hide password
        private void pbx_showPasswordLogIn_MouseLeave(object sender, EventArgs e)
        {
            showPassword(txt_password);
        }

        //Log on button click
        private void btn_logon_Click(object sender, EventArgs e)
        {
            try
            {
                logonDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error logging on" + ex.TargetSite);
            }
        }

        //Logon validator
        private void logonDetails()
        {
            //Hiding error messages until needed later in the program
            lbl_passwordError.Visible = false;
            lbl_usernameError.Visible = false;

            //Validating the textboxes 
            //Testing if username box is empty
            if (string.IsNullOrWhiteSpace(this.txt_username.Text))
            {
                lbl_usernameError.Text = "This field is required";
                lbl_usernameError.Visible = true;
            }

            //Testing if password box is empty
            else if (string.IsNullOrWhiteSpace(this.txt_password.Text))
            {
                lbl_passwordError.Text = "This field is required";
                lbl_passwordError.Visible = true;
            }

            //Testing if the username exsists
            else if (txt_username.Text != "1494")
            {
                lbl_usernameError.Text = "This ID does not exist";
                lbl_usernameError.Visible = true;
            }

            //Testing if the username typed in matches the stored password
            else if (txt_password.Text != "woodside")
            {
                lbl_passwordError.Text = ("Incorrect password... Try again");
                lbl_passwordError.Visible = true;
                txt_password.Text = "";
            }
            else
            {
                //move to the next form
                dgv_showBookings obj = new dgv_showBookings();
                this.Hide();
                obj.Show();
            }
        }

        //Forgotton Password Label Click
        private void lbl_passwordForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username = 1494, Password = woodside");
        }
    }
    
}
