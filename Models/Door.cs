using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Models
{
    public class Door
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required(ErrorMessage = "Project Id is required")]
        public string projectId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Room is required")]
        public string Room { get; set; }

        [Required(ErrorMessage = "Building is required")]
        public string Building { get; set; }

        [Required(ErrorMessage = "Floor is required")]
        public string Floor { get; set; }

        [Required(ErrorMessage = "Height is required")]
        public string Height { get; set; }

        [Required(ErrorMessage = "Width is required")]
        public string Width { get; set; }

        [Required(ErrorMessage = "Lock is required")]
        public LockType Lock { get; set; }

        [Required(ErrorMessage = "Cyclinder is required")]
        public CyclinderType Cyclinder { get; set; }

        [Required(ErrorMessage = "Frame is required")]
        public FrameType Frame { get; set; }


        public class LockType
        {
            [Required(ErrorMessage = "Lock Type is required")]
            public string Type { get; set; }

            [Required(ErrorMessage = "Lock Qty is required")]
            public int Qty { get; set; }

            [Required(ErrorMessage = "Lock Material is required")]
            public string Material { get; set; }
            public bool isCompleted { get; set; }
        }

        public class CyclinderType
        {
            [Required(ErrorMessage = "Cyclinder Type is required")]
            public string Type { get; set; }

            [Required(ErrorMessage = "Cyclinder Qty is required")]
            public int Qty { get; set; }

            [Required(ErrorMessage = "Cyclinder Material is required")]
            public string Material { get; set; }
            public bool isCompleted { get; set; }
        }

        public class FrameType
        {
            [Required(ErrorMessage = "Frame Type is required")]
            public string Type { get; set; }
            public bool isCompleted { get; set; }
        }
    }


}
