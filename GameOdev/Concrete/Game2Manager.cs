using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Concrete
{
    public class Game2Manager : Game, IGameServices
    {
        public void Buy(IEntity game, IEntity player)
        {
            Console.WriteLine("Oyun2 satın alındı.");
        }
    }
}
