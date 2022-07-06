using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class AppMODEL
    {
        private int appID;

        public int AppID
        {
            get { return appID; }
            set { appID = value; }
        }
        private int appDepartment;

        public int AppDepartment
        {
            get { return appDepartment; }
            set { appDepartment = value; }
        }
        private string appReason;

        public string AppReason
        {
            get { return appReason; }
            set { appReason = value; }
        }
        private DateTime appTime;

        public DateTime AppTime
        {
            get { return appTime; }
            set { appTime = value; }
        }
        private double appMoney;

        public double AppMoney
        {
            get { return appMoney; }
            set { appMoney = value; }
        }
        private string appName;

        public string AppName
        {
            get { return appName; }
            set { appName = value; }
        }
    }
}
