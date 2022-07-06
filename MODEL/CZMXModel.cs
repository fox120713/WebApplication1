using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class CZMXModel
    {
        private int yzid;

        public int Yzid
        {
            get { return yzid; }
            set { yzid = value; }
        }
        private string months;

        public string Months
        {
            get { return months; }
            set { months = value; }
        }
        private double czje;

        public double Czje
        {
            get { return czje; }
            set { czje = value; }
        }
        private DateTime czdates;

        public DateTime Czdates
        {
            get { return czdates; }
            set { czdates = value; }
        }
        private string mph;

        public string Mph
        {
            get { return mph; }
            set { mph = value; }
        }

    }
}
