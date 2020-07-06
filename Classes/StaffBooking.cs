using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodsideCommunityHub
{
    class StaffBooking
    {
        private int staffId;
        private int bookingId;

        public StaffBooking()
        {
            staffId = 0;
            bookingId = 0;
        }

        public StaffBooking(int _staffId, int _bookingId)
        {
            staffId = _staffId;
            bookingId = _bookingId;
        }

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }
    }
}
