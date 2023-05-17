using CSharp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Repository.Services
{
    public class HelloWorkRepository : IHelloWorkRepository
    {
        public string SayHello => "Hello World";
    }
}
