using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WoodsideCommunityHub
{
    public partial class frm_mainMenu : Form
    {

        bool isBookingClosed = true;


        public frm_mainMenu()
        {
            InitializeComponent();
        }

        private void frm_mainMenu_Load(object sender, EventArgs e)
        {
            pbx_booking.Image = Properties.Resources.booking_white;
            pbx_children.Image = Properties.Resources.child_white;
            pbx_transport.Image = Properties.Resources.transport_white;
            pbx_staff.Image = Properties.Resources.staff_white;
            pbx_activities.Image = Properties.Resources.trophy_white;
        }

        private void pbx_show_Click(object sender, EventArgs e)
        {
            pnl_extended.Visible = true;
            pnL_hidden.Visible = false;
        }

        private void pbx_hide_Click(object sender, EventArgs e)
        {
            pnl_extended.Visible = false;
            pnL_hidden.Visible = true;
        }

 
        private void pnl_extended_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_menuOneDropdown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_menuOne_Click(object sender, EventArgs e)
        {
            tmr_booking.Start();
        }

        private void btn_menuTwo_Click(object sender, EventArgs e)
        {
            tmr_children.Start();
        }



        //private bool menuCollapse(Panel menuOne, Panel menuTwo, Panel menuThree, Timer time, bool isCollasped, int numberBelow, Button button)
        //{
        //    //Point pointOpenMenu1 = new Point(0, 150);
        //    //Point pointOpenMenu2 = new Point(2, 280);
        //    //Point pointClosedMenu2 = new Point(2, 210);
        //    //Point pointOpenMenu3 = new Point(0, 285);
        //    //Point pointClosedMenu3 = new Point(2, 355);


        //    //if (isCollasped)
        //    //{
        //    //    menuOne.Height += 10;
        //    //    if (menuOne.Size == menuOne.MaximumSize)
        //    //    {
        //    //        time.Stop();
        //    //        button.Image = Properties.Resources.Collapse_Arrow_20px;
        //    //        isBookingClosed = false;
        //    //        pnl_children.Size = MinimumSize;
        //    //        pnl_transport.Size = MinimumSize;
        //    //        pnl_children.Location = new Point(0, 280);
        //    //        pnl_transport.Location = new Point(0, 355);
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    pnl_booking.Height -= 10;
        //    //    if (pnl_booking.Size == pnl_booking.MinimumSize)
        //    //    {
        //    //        tmr_booking.Stop();
        //    //        btn_booking.Image = Properties.Resources.Expand_Arrow_20px;
        //    //        isBookingClosed = true;
        //    //        pnl_children.Location = new Point(2, 210);
        //    //        pnl_transport.Location = new Point(2, 285);
        //    //    }
        //    //}



        //    //return isCollasped;

        //}

        private void tmr_menuOne_Tick(object sender, EventArgs e)
        {
            //isMenuOneCollapsed = menuCollapse(pnl_menuOne, pnl_menuTwo, pnl_menuThree,  tmr_menuOne, isMenuOneCollapsed);

            if (isBookingClosed)
            {
                pnl_booking.Height += 10;
                if (pnl_booking.Size == pnl_booking.MaximumSize)
                {
                    tmr_booking.Stop();
                    btn_booking.Image = Properties.Resources.Collapse_Arrow_20px;
                    

                    btn_children.Location = new Point(0,311);
                    btn_transport.Location = new Point(0, 378);
                    btn_activities.Location = new Point(0, 445);
                    btn_staff.Location = new Point(0, 512);
                    isBookingClosed = false;
                }
            }
            else
            {
                pnl_booking.Height -= 10;
                if (pnl_booking.Size == pnl_booking.MinimumSize)
                {
                    tmr_booking.Stop();
                    btn_booking.Image = Properties.Resources.Expand_Arrow_20px;
                    
                    btn_children.Location = new Point(0, 211);
                    btn_transport.Location = new Point(0, 278);
                    btn_activities.Location = new Point(0, 345);
                    btn_staff.Location = new Point(0,412);
                    isBookingClosed = true;
                }
            }
        }

        private void tmr_menuTwo_Tick(object sender, EventArgs e)
        {

            //if (isChildrenClosed)
            //{
            //    pnl_children.Height += 10;
            //    if (pnl_children.Size == pnl_children.MaximumSize)
            //    {
            //        tmr_children.Stop();
                    
            //        pnl_booking.Size = MinimumSize;
            //        pnl_transport.Size = MinimumSize;

            //        pnl_booking.Location = new Point(0, 150);
            //        pnl_transport.Location = new Point(0, 355); 
            //        pnl_children.Location = new Point(2, 210);

            //        isChildrenClosed = false;

            //    }
            //}
            //else
            //{
            //    pnl_children.Height -= 10;
            //    if (pnl_children.Size == pnl_children.MinimumSize)
            //    {
            //        tmr_children.Stop();
            //        isChildrenClosed = true;
            //        pnl_transport.Location = new Point(0, 285);
            //    }
            //}

        }

        private void btn_menuThree_Click(object sender, EventArgs e)
        {
            tmr_transport.Start();
            
        }

        private void tmr_menuThree_Tick(object sender, EventArgs e)
        {

            //// isMenuThreeCollapsed = menuCollapse(pnl_menuThree, pnl_menuTwo, pnl_menuOne, tmr_menuThree, isMenuThreeCollapsed);
            //if (isTransportClosed)
            //{
            //    pnl_transport.Height += 10;
            //    if (pnl_transport.Size == pnl_transport.MaximumSize)
            //    {
            //        tmr_transport.Stop();
                    
            //        pnl_children.Size = MinimumSize;
            //        pnl_booking.Size = MinimumSize;

            //        pnl_children.Location = new Point(2, 210);
            //        pnl_booking.Location = new Point(0, 150);
            //        pnl_transport.Location = new Point(0, 285);

            //        isTransportClosed = false;
            //    }
            //}
            //else
            //{
            //    pnl_transport.Height -= 10;
            //    if (pnl_transport.Size == pnl_transport.MinimumSize)
            //    {
            //        tmr_transport.Stop();
            //        isTransportClosed = true;
            //        pnl_transport.Location = new Point(0, 345);
            //    }
            //}
        }
        
        private void pbx_woodsideLogo_Click(object sender, EventArgs e)
        {

        }

        private void btn_transport_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbx_staff_MouseEnter(object sender, EventArgs e)
        {
            pbx_staff.Image = Properties.Resources.staff_highlighted_copy_copy;
        }

        private void pbx_staff_MouseLeave(object sender, EventArgs e)
        {
            pbx_staff.Image = Properties.Resources.staff_white;
        }

        private void pbx_activities_MouseEnter(object sender, EventArgs e)
        {
            pbx_activities.Image = Properties.Resources.trophy_highlighted;
        }

        private void pbx_activities_MouseLeave(object sender, EventArgs e)
        {
            pbx_activities.Image = Properties.Resources.trophy_white;
        }

        private void pbx_transport_MouseEnter(object sender, EventArgs e)
        {
            pbx_transport.Image = Properties.Resources.transport_highlighted;
        }

        private void pbx_transport_MouseLeave(object sender, EventArgs e)
        {
            pbx_transport.Image = Properties.Resources.transport_white;
        }

        private void pbx_children_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbx_booking_MouseEnter(object sender, EventArgs e)
        {
            pbx_booking.Image = Properties.Resources.booking_highlighted;
        }

        private void pbx_booking_MouseLeave(object sender, EventArgs e)
        {
            pbx_booking.Image = Properties.Resources.booking_white;
        }
    }
    
}
