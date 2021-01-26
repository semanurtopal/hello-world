using GameOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

        object IEntity.NationalityId => throw new NotImplementedException();

        object IEntity.FirstName => throw new NotImplementedException();

        object IEntity.LastName => throw new NotImplementedException();

        object IEntity.DateOfBirth => throw new NotImplementedException();
    }
}
