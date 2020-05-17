using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TwoHundredEleven.Core.Entities;

namespace TwoHundrendEleven.TadaaApp.Entities.Concrete
{
    public class Person:IEntity
    {
        public int id { get; set; }
        public long lastupdated { get; set; }
        public bool status { get; set; }
        public DateTime CreatedDateAndTime { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
     
        //Password bilgilerini ayrı bir tabloda tut.
    }
}
