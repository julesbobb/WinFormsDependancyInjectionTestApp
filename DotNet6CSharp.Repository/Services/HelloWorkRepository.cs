using DotNet6CSharp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6CSharp.Repository.Services
{
    public partial class HelloWorkRepository : IHelloWorkRepository
    {
        public string SayHello()
        {
            return "Hello World";
        }

    }
}
