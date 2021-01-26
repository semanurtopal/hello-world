using GameOdev.Concrete;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {

        public void Save(IEntity campaign)
        {
            Console.WriteLine("Saved");
        }

        public void Update(IEntity campaign)
        {
            Console.WriteLine("Updated");
        }

        public void Delete(IEntity campaign)
        {
            Console.WriteLine("Deleted");
        }

        public static implicit operator BaseCampaignManager(Campaign1Manager v)
        {
            throw new NotImplementedException();
        }
    }
}
