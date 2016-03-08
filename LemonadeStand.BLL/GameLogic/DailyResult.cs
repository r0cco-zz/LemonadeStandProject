using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.BLL.GameLogic
{
    public class DailyResult
    {
        public DateTime Date { get; set; }
        public decimal MoneySpent { get; set; }
        public int CupsUsed { get; set; }
        public int LemonsUsed { get; set; }
        public int SugarUsed { get; set; }
        public Weather WeatherResult { get; set; }
    }
}
