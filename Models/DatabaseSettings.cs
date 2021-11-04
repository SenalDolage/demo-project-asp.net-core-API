using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string DoorsCollectionName { get; set; }
        public string ProjectsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDatabaseSettings
    {
        string DoorsCollectionName { get; set; }
        string ProjectsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
