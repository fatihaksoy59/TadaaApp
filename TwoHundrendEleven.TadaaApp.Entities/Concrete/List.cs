using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities;

namespace TwoHundrendEleven.TadaaApp.Entities.Concrete
{
    public class List:IEntity
    {
        public int id { get; set; }
        public long lastupdated { get; set; }
        public bool status { get; set; }
        public int userId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateAndTime { get; set; }
      
    }
}
