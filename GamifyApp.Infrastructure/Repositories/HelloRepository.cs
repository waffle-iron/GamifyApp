using GamifyApp.Contracts.Infrastructure.Repositories;
using GamifyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamifyApp.Infrastructure.Repositories
{
    public class HelloRepository : IHelloRepository
    {
        public string LoadHello(string Name)
        {
            return $"Hello {Name}";
        }
    }
}
