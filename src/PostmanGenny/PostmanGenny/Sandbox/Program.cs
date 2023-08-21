using Newtonsoft.Json;
using v20 = PostmanGenny.Models.v20.Collections;
using v21 = PostmanGenny.Models.v21.Collections;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coll1 = new v20.Collection();
            coll1.Information.Name = "Foo";
            coll1.Information.Description = "Bar";
            coll1.Authentication = new v20.Authentication.Auth()
            {
                AuthDetails = new v20.Authentication.BasicAuthDetails()
                {
                    Username = "F", Password = "B"
                }
            };

            var coll2 = new v21.Collection();
            coll2.Information.Name = "Foo";
            coll2.Information.Description = "Bar";
            coll2.Authentication = new v20.Authentication.Auth()
            {
                AuthDetails = new v20.Authentication.BearerTokenAuthDetails()
                {
                    Token = "abc123"
                }
            };

            Console.WriteLine(JsonConvert.SerializeObject(coll1, Formatting.Indented));
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(coll2, Formatting.Indented));
            Console.WriteLine();
        }
    }
}