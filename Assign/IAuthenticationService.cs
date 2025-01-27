using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string name, string password);
        public bool AuthorizeUser(string name, string role);
    }
    class BasicAuthenticationService : IAuthenticationService
    {
        //public string?Name { get; set; }
        //public string? Password { get; set; }
        string[][] employees = new string[][]
        {
         new string[] { "Ahmed", "Manager" },
         new string[] { "Sara", "Developer" },
         new string[] { "John", "Designer" },
         new string[] {"Aly","Back End"}
        };
        string[][] Data = new string[][]
        {
         new string[] { "Ahmed", "@123" },
         new string[] { "Sara", "@456" },
         new string[] { "John", "@789" },
         new string[] {"Aly","@879"}
        };


        
        public bool AuthenticateUser(string Name, string Password)
        {
            
            for (int i = 0; i < employees.Length; i++)
            {
                if (Data[i][0] == Name && Data[i][1] == Password)
                {

                    return true;
                }
            }
            return false;
        }
        public bool AuthorizeUser(string Name, string Role)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i][0] == Name && employees[i][1] == Role)
                {
                   
                    return true;
                }
            }
            return false;
        }
    }
}
