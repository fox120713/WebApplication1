using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class ZHMODEL
    {
      /* INSERT INTO [PRO].[dbo].[ZHuInfo]
           ([ZHId]
           ,[ZHName]
           ,[ZHType]
           ,[ZHMoney]
           ,[ZHDate]
           ,[Yzid])
     VALUES
           (<ZHId, nvarchar(10),>
           ,<ZHName, nvarchar(10),>
           ,<ZHType, nvarchar(11),>
           ,<ZHMoney, decimal(8,2),>
           ,<ZHDate, date,>
           ,<Yzid, int,>)*/
        private string zhid;

        public string Zhid
        {
            get { return zhid; }
            set { zhid = value; }
        }
        private string zhname;

        public string Zhname
        {
            get { return zhname; }
            set { zhname = value; }
        }
        private string zhtype;

        public string Zhtype
        {
            get { return zhtype; }
            set { zhtype = value; }
        }
        private double zhmoney;

        public double Zhmoney
        {
            get { return zhmoney; }
            set { zhmoney = value; }
        }
        private DateTime zhdate;

        public DateTime Zhdate
        {
            get { return zhdate; }
            set { zhdate = value; }
        }
        private int yzid;

        public int Yzid
        {
            get { return yzid; }
            set { yzid = value; }
        }
    }
}
