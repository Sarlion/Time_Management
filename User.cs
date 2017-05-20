using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_project
{
    class User
    {


        private string Name;
        private string Age;
        private string NName;
        private string Uni;
        private string Graduate;
        private string Password;
  

        public User(string name, string age, string nname, string uni, string graduate, string pas)
        {
            this.Name = name;
            this.Age = age;
            this.NName = nname;
            this.Uni = uni;
            this.Graduate = graduate;
            this.Password = pas;
        }

     
    }
}
