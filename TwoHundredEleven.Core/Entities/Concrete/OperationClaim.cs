using System;
using System.Collections.Generic;
using System.Text;

namespace TwoHundredEleven.Core.Entities.Concrete
{
    public class OperationClaim
    {
        public int id { get; set; }
        public long lastupdated { get; set; }
        public bool status { get; set; }
        public DateTime CreatedDateAndTime { get; set; }
        public string Name { get; set; }
    }
}
