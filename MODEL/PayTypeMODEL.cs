using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class PayTypeMODEL
    {
        private int payID;

        public int PayID
        {
            get { return payID; }
            set { payID = value; }
        }
        private string payName;

        public string PayName
        {
            get { return payName; }
            set { payName = value; }
        }
        private double dj;

        public double Dj
        {
            get { return dj; }
            set { dj = value; }
        }
    }
}
