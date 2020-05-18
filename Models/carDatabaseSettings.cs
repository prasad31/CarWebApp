using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1234.Models
{
    public class carDatabaseSettings : IcarDatabaseSettings
    {
        public string CarsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IcarDatabaseSettings
    {
        string CarsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
