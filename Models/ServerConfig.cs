using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1234.Models;

namespace test1234.Models
{
    public class ServerConfig
    {
        public MongoDbConfig MongoDB { get; set; } = new MongoDbConfig();
    }
}
