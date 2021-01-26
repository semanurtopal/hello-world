using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Concrete
{
    public class Campaign1Manager : Campaign, ICampaignService
    {
        public void Delete(IEntity campaign)
        {
            Console.WriteLine("Kampanya1 silindi.");
        }

        public void Save(IEntity campaign)
        {
            Console.WriteLine("Kampanya1 kaydedildi.");
        }

        public void Update(IEntity campaign)
        {
            Console.WriteLine("Kampanya1 güncellendi.");
        }
    }
}
