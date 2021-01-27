using GameOdev.Abstract;
using GameOdev.Concrete;
using GameOdev.Entities;
using System;

namespace GameOdev
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new Gamer1Manager(new GamerCheckManager());
            gamerManager.Save(new Gamer { Id=1, FirstName="Semanur",LastName="Topal",DateOfBirth= new DateTime(1997,10,1),NationalityId="40354315637"});

            BaseGameManager gameManager = new Game1Manager();
            gamerManager.Save(new Game {GameName="Pet Society", GamePrice=12 });

            BaseCampaignManager campaignManager = new Campaign1Manager();
            gamerManager.Save(new Campaign { CampaignName="Black Friday" });
        }
    }
}
