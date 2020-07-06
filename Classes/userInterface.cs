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
    public class userInterface
    {
        private bool isPanelOpen;
        private bool isBookingOpen;

        public userInterface()
        {
            bool isPanelOpen = false;
            bool isBookingOpen = false;
        }

        public userInterface(bool tempIsPanelOpen, bool tempIsBookingOpen)
        {
            isPanelOpen = tempIsPanelOpen;
            isBookingOpen = tempIsBookingOpen;
        }

        public bool IsPanelOpen
        {
            get { return isPanelOpen; }
            set { isPanelOpen = value; }
        }

        public bool IsBookingClosed
        {
            get { return isBookingOpen; }
            set { isBookingOpen = value; }
        }

        //Loads the images into the side bar
        public void loadIcons(PictureBox child, PictureBox booking, PictureBox transport, PictureBox staff, PictureBox activities)
        {
            child.Image = Properties.Resources.child_white1;
            booking.Image = Properties.Resources.booking_white;
            transport.Image = Properties.Resources.transport_white;
            staff.Image = Properties.Resources.staff_white;
            activities.Image = Properties.Resources.trophy_white;
        }

        //Opens and closes the Booking drop down section of the menu 
        public bool collapsableMenu(bool isCollapsed, Panel booking, Timer time, Button children, Button transport, Button activities, Button bookingButton, Button staff)
        {
            if (isCollapsed)
            {
                booking.Height += 10;
                if (booking.Size == booking.MaximumSize)
                {
                    time.Stop();
                    bookingButton.Image = Properties.Resources.Collapse_Arrow_20px;


                    children.Location = new Point(0, 311);
                    transport.Location = new Point(0, 378);
                    activities.Location = new Point(0, 445);
                    staff.Location = new Point(0, 512);
                    isCollapsed = false;
                    
                }
            }
            else
            {
                booking.Height -= 10;
                if (booking.Size == booking.MinimumSize)
                {
                    time.Stop();
                    bookingButton.Image = Properties.Resources.Expand_Arrow_20px;

                    children.Location = new Point(0, 211);
                    transport.Location = new Point(0, 278);
                    activities.Location = new Point(0, 345);
                    staff.Location = new Point(0, 412);
                    isCollapsed = true;
                }
            }

            return isCollapsed;
        }

        //This opens the side bar from icons to text
        public void panelOpen(Panel open, Panel closed)
        {
            open.Visible = true;
            closed.Visible = false;
        }

        //This closes the the side panel from text to icons
        public void panelClosed(Panel open, Panel closed)
        {
            closed.Visible = true;
            open.Visible = false;
        }

        //This tests to see if the booking panel is open
        public bool checkPanel(Panel open)
        {
            bool isOpen = false;

            if (open.Visible == true)
            {
                isOpen = true;
            }

            return isOpen;
        }

        //This tests to see if the side panel is open on the loading of a form
        public void isPanelOpenLoad(Panel open, Panel closed, bool isOpen)
        {
            userInterface obj = new userInterface();

            if (isOpen == true)
            {
                obj.panelOpen(open, closed);
            }
            else if (isOpen == false)
            {
                obj.panelClosed(open, closed);
            }

        }
    }
}
