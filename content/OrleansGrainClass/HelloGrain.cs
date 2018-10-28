using Orleans;
using System.Threading.Tasks;

namespace OrleansGrainClass
{
    // Add reference to the Interface and Implement the interface in this class
    public class HelloGrain : Grain //,IHello
    {
        private Task<string> SayHello(string greeting)
        {
            return Task.FromResult($"{greeting}, welcome to Orleans!");
        }
    }
}