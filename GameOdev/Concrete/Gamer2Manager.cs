using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Concrete
{
    public class Gamer2Manager : BaseGamerManager, IGamerService
    {
        public class Gamer : IGamerCheckService
        {
            public bool CheckIfRealPerson(IEntity gamer)
            {
                throw new NotImplementedException();
            }
        }

        private IGamerCheckService _gamerCheckService;

        public Gamer2Manager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(IEntity gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);

            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
