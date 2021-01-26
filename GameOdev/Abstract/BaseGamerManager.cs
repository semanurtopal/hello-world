using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public void Delete(IEntity gamer)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public virtual void Save(IEntity gamer)
        {
            
        }

        public void Update(IEntity gamer)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
