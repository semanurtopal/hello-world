using EDevletServiceReference;
using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Adapters
{
    public class EDevletServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(IEntity gamer)
        {
            EDevletServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.NationalityId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);

        }
    }
}
