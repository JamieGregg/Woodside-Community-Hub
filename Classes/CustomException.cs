using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodsideCommunityHub
{
    public class CustomException : Exception
    {
        public CustomException() : base()
        {
            DialogResult dialogResult = MessageBox.Show("There has been a database connection error, do you wish to progress anyway?", "ConnectionError", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else
            {
                dgv_showBookings obj = new dgv_showBookings();
                obj.Show();
            }
        }

        
    }
}
