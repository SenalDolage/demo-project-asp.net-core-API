using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Models
{
    public class Door
    {
        public ObjectId Id { get; set; }
        public int doorId { get; set; }
        public int projectId { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public LockType Lock { get; set; }
        public CyclinderType Cyclinder { get; set; }
        public FrameType Frame { get; set; }
        public Boolean isCompleted { get; set; }


        public class LockType
        {
            public string Type { get; set; }
            public int Qty { get; set; }
            public string Material { get; set; }
            public Boolean isCompleted { get; set; }
        }

        public class CyclinderType
        {
            public string Type { get; set; }
            public int Qty { get; set; }
            public string Material { get; set; }
            public Boolean isCompleted { get; set; }
        }

        public class FrameType
        {
            public string Type { get; set; }
            public Boolean isCompleted { get; set; }
        }
    }


}
