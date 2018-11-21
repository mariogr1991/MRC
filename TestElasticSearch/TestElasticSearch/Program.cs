using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestElasticSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Configuración de conexión*/

            var node = new Uri("http://localhost:9200");
            var config = new ConnectionConfiguration(node);
            var client = new ElasticLowLevelClient(config);



        }
    }
}
