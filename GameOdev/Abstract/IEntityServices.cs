using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface IEntityServices
    {
        void Buy(List<IEntity> entities);
        void Save(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
