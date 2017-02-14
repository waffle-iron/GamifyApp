using GamifyApp.Contracts.Domain.Services;
using GamifyApp.Contracts.Infrastructure.Repositories;
using GamifyApp.Infrastructure.Repositories;
using System;

namespace GamifyApp.Domain.Services
{
    public class HelloService : IHelloService
    {
        private readonly IHelloRepository helloRepository;

        public HelloService(IHelloRepository helloRepository)
        {
            this.helloRepository = helloRepository;
        }

        public string Hello(string name)
        {
            try
            {                
                string helloMessage = helloRepository.LoadHello(name);
                return helloMessage;
            } catch (Exception ex) {
                //TODO: Log this
                throw ex;
            }
        }
    }
}
