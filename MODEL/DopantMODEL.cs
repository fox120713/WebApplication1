using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class DopantMODEL
    {
        private int dopantID;

        public int DopantID
        {
            get { return dopantID; }
            set { dopantID = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userCell;

        public string UserCell
        {
            get { return userCell; }
            set { userCell = value; }
        }
        private int payID;

        public int PayID
        {
            get { return payID; }
            set { payID = value; }
        }
        private int dopantMoney;

        public int DopantMoney
        {
            get { return dopantMoney; }
            set { dopantMoney = value; }
        }
        private string dopantBool;

        public string DopantBool
        {
            get { return dopantBool; }
            set { dopantBool = value; }
        }
        private DateTime dopantTime;

        public DateTime DopantTime
        {
            get { return dopantTime; }
            set { dopantTime = value; }
        }
        private string dopantBlr;

        public string DopantBlr
        {
            get { return dopantBlr; }
            set { dopantBlr = value; }
        }
    }
}
