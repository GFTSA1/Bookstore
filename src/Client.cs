using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.src
{
    public class Client : IHuman
    {
        public String FirstName {get; set;}
        public String LastName {get; set;}
        public DateTime DateOfBirth { get; set;}

        public String PhoneNumber { get; set;}
    }
}
