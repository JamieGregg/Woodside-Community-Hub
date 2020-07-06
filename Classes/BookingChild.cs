using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodsideCommunityHub
{
    class BookingChild
    {
        private int childId;
        private int bookingId;

        public BookingChild()
        {
            childId = 0;
            bookingId = 0;
        }

        public BookingChild(int _childId, int _bookingId)
        {
            childId = _childId;
            bookingId = _bookingId;
        }

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public int ChildId
        {
            get { return childId; }
            set { childId = value; }
        }
    }
}
