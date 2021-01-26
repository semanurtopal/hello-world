using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface ICampaignService
    {

        void Save(IEntity campaign);
        void Update(IEntity campaign);
        void Delete(IEntity campaign);
    }
}
