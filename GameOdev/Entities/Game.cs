using GameOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }

        public object NationalityId => throw new NotImplementedException();

        public object FirstName => throw new NotImplementedException();

        public object LastName => throw new NotImplementedException();

        public object DateOfBirth => throw new NotImplementedException();
    }
}
