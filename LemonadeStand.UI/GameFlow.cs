using LemonadeStand.BLL.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.UI
{
    public class GameFlow
    {
        private Player _player;

        public GameFlow()
        {
            _player = new Player();
        }

        public void PlayGame()
        {
            Animations.DisplayStartScreen();
            GetPlayerName();
        }

        private void GetPlayerName()
        {
            Console.Write("What is your name? : ");
            _player.Name = Console.ReadLine();
            if (_player.Name == string.Empty)
            {
                _player.Name = "Player1";
            }
            Console.Clear();
        }
    }
}
