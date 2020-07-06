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

        private void lbl_logon_Click(object sender, EventArgs e)
        {
            //Formatting Header
            lbl_logon.ForeColor = Color.DarkGreen;
            lbl_register.ForeColor = Color.FromArgb(76, 74, 74);
            pbx_logIcon.Visible = true;
            pbx_regIcon.Visible = false;


            gpb_logIn.Visible = true;
            gpb_register.Visible = false;


        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            //Formatting Header
            lbl_logon.ForeColor = Color.FromArgb(76, 74, 74);
            lbl_register.ForeColor = Color.DarkGreen;
            pbx_logIcon.Visible = false;
            pbx_regIcon.Visible = true;

            gpb_logIn.Visible = false;
            gpb_register.Visible = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_logOn_Load(object sender, EventArgs e)
        {
            gpb_register.Visible = false;
        }

        //Showing and hiding passwords
        private void displayPassword(TextBox passwordBox)
        {
            passwordBox.UseSystemPasswordChar = false;
        }

        private void showPassword(TextBox passwordBox)
        {
            passwordBox.UseSystemPasswordChar = true;
        }

        private void pbx_showPasswordLogIn_MouseEnter(object sender, EventArgs e)
        {
            displayPassword(txt_password);
        }

        private void pbx_showPasswordLogIn_MouseLeave(object sender, EventArgs e)
        {
            showPassword(txt_password);
        }

        private void pbx_showPasswordReg_MouseEnter(object sender, EventArgs e)
        {
            displayPassword(txt_createPassword);
        }

        private void pbx_showPasswordReg_MouseLeave(object sender, EventArgs e)
        {
            showPassword(txt_createPassword);
        }

        private void pbx_showPasswordReg2_MouseEnter(object sender, EventArgs e)
        {
            displayPassword(txt_password_repeat);
        }

        private void pbx_showPasswordReg2_MouseLeave(object sender, EventArgs e)
        {
            showPassword(txt_password_repeat);
        }

        private void chb_termsAndConditions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            if (chb_termsAndConditions.Checked == false)
            {
                chb_termsAndConditions.ForeColor = Color.Red;
            }
            else
            {
                chb_termsAndConditions.ForeColor = Color.FromArgb(76, 74, 74);
            }
        }
    }
}
