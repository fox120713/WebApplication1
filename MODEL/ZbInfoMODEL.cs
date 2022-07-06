using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public  class ZbInfoMODEL
    {
        private int YgId;
        /// <summary>
        /// 员工编号
        /// </summary>
        public int YgId1
        {
            get { return YgId; }
            set { YgId = value; }
        }
        private string YgName;
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string YgName1
        {
            get { return YgName; }
            set { YgName = value; }
        }
        private int YgPos;
        /// <summary>
        /// 所属部门
        /// </summary>
        public int YgPos1
        {
            get { return YgPos; }
            set { YgPos = value; }
        }
        private DateTime zbdate;
        /// <summary>
        /// 值班日期
        /// </summary>
        public DateTime Zbdate
        {
            get { return zbdate; }
            set { zbdate = value; }
        }
        private string gznr;
        /// <summary>
        /// 工作内容
        /// </summary>
        public string Gznr
        {
            get { return gznr; }
            set { gznr = value; }
        }
        private string jttime;
        /// <summary>
        /// 具体时间
        /// </summary>
        public string Jttime
        {
            get { return jttime; }
            set { jttime = value; }
        }


    }
}
