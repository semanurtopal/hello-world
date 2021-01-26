using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; }
        object NationalityId { get; }
        object FirstName { get; }
        object LastName { get; }
        object DateOfBirth { get; }
    }
}
