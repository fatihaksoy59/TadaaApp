using System;
using System.Collections.Generic;
using System.Text;

namespace TwoHundredEleven.Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int id { get; set; }
        public long lastupdated { get; set; }
        public bool status { get; set; }
        public DateTime CreatedDateAndTime { get; set; }
        public int personId { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }


    }
}
