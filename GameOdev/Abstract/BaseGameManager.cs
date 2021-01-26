using GameOdev.Concrete;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public abstract class BaseGameManager : IEntityServices
    {
        

        public void Buy(List<IEntity> games)
        {
            Console.WriteLine("Oyun satın alındı.");
        }

        public void Delete(IEntity game)
        {
            Console.WriteLine("Oyun silindi.");
        }

        public void Save(IEntity game)
        {
            Console.WriteLine("Oyun kaydedildi.");
        }

        public void Update(IEntity game)
        {
            Console.WriteLine("Oyun güncellendi.");
        }

        public static implicit operator BaseGameManager(Game1Manager v)
        {
            throw new NotImplementedException();
        }
    }
}
