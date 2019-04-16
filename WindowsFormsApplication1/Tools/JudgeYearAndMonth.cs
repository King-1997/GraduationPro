using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class JudgeYearAndMonth
    {
        public DateTime judgeYearAndMonth(int year,int month)
        {
            DateTime entryTime2 = new DateTime(2018, 8, 26);
            if (month == 02)//当月份为2时判断是否为闰年
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    //entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                    entryTime2 = Convert.ToDateTime(year + "-" + month + "-29");
                }
                else
                {
                    //entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                    entryTime2 = Convert.ToDateTime(year + "-" + month + "-28");
                }
            }
            //当月份不为2时，判断当前月份是否有31号
            if (month == 01 || month == 03 || month == 05 || month == 07 || month == 08 || month == 10 || month == 12)
            {
                //entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                entryTime2 = Convert.ToDateTime(year + "-" + month + "-31");
            }
            else
            {
                //entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                entryTime2 = Convert.ToDateTime(year + "-" + month + "-30");
            }
            return entryTime2;
        }
    }
}
