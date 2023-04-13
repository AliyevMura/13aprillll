using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task13april.Personclass;
using Task13april;
namespace Task13april.Personclass
{
    internal class Person
    {

        private string _username;
        private string _password;
        private string _name;
        private string _surname;
        private int _age;
        private int _birthday;





        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }


        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
               _password = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
               _surname = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
               
        }
        public int Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
               _birthday = value;

            }
        }
    }
}
