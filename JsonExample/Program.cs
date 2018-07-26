using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiEntities.Api apiEntities = new ApiEntities.Api();
            Controller.Response response = new Controller.Response(apiEntities.Borsalar);
            List<ResponseEntities.Exchange> result = response.ParseJSON<ResponseEntities.Exchange>();
            foreach (var item in result)
            {
                Console.WriteLine(item.full_name + "\n" + item.buying + "\n" + item.selling);
                Console.WriteLine("--------------------------------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
