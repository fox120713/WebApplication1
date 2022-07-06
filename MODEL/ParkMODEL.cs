using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ParkMODEL
    {
        private int parkID;

        public int ParkID
        {
            get { return parkID; }
            set { parkID = value; }
        }
        private int l_CarID;

        public int L_CarID
        {
            get { return l_CarID; }
            set { l_CarID = value; }
        }
        private string parkNum;

        public string ParkNum
        {
            get { return parkNum; }
            set { parkNum = value; }
        }
        private DateTime intoTime;

        public DateTime IntoTime
        {
            get { return intoTime; }
            set { intoTime = value; }
        }
        private DateTime OutTime;

        public DateTime OutTime1
        {
            get { return OutTime; }
            set { OutTime = value; }
        }
        private double parkMoney;

        public double ParkMoney
        {
            get { return parkMoney; }
            set { parkMoney = value; }
        }
        private string parkbool;

        public string Parkbool
        {
            get { return parkbool; }
            set { parkbool = value; }
        }
    }
}
