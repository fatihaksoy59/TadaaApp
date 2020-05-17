using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities;

namespace TwoHundrendEleven.TadaaApp.Entities.Concrete
{
    public class Task:IEntity
    {
        public int id { get; set; }
        public long lastupdated { get; set; }
        public bool status { get; set; }
        public int listId { get; set; }
        public DateTime CreatedDateAndTime { get; set; }
        public string Name { get; set; }
        public string TaskExplanation { get; set; }
        public DateTime TaskDateAndTime { get; set; }
        public bool isCompleted { get; set; }
        public DateTime CompletedDateAndTime { get; set; }
    }
}
