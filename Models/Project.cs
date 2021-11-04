using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Models
{
    public class Project
    {
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "Project Id is required")]
        public int projectId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Venue is required")]
        public string Venue { get; set; }
        public string createdDate { get; set; }
        public string modifiedDate { get; set; }

    }
}
