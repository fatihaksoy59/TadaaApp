using System;
using System.Collections.Generic;
using System.Text;

namespace TwoHundredEleven.Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        public int id { get; set; }
        public long lastupdated { get; set; }
        public bool status { get; set; }
        public DateTime CreatedDateAndTime { get; set; }
        public int userId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
