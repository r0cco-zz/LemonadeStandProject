using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.BLL.GameLogic
{
    public class Player
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public int NumberOfCups { get; set; }
        public int NumberOfLemons { get; set; }
        public int PoundsOfSugar { get; set; }
        public int NumberOfIceCubes { get; set; }
    }
}
