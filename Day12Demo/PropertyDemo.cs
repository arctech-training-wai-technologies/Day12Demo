using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Demo
{
    public class PropertyDemo
    {
        public static void Test()
        {
            //EmployeeOld e1 = new(101, "Raman", "raman@hotmail.com");
            //EmployeeOld e2 = new(102, "Chaman", "chaman@hotmail.com");
            //EmployeeOld e3 = new(103, "Naman", "naman@hotmail.com");

            //e1.SetEmail("test@hotmail.com");
            //e3.SetEmail("newEmail@hotmail.com");
            //e2.SetEmail("pop@hotmail");

            //Console.WriteLine($"{e1.GetId()},{e1.GetName()}, {e1.GetEmail()}");
            //Console.WriteLine($"{e2.GetId()},{e2.GetName()}, {e2.GetEmail()}");
            //Console.WriteLine($"{e3.GetId()},{e3.GetName()}, {e3.GetEmail()}");

            EmployeeNew newE1 = new(1001, "Superman", "superman@dc.com");
            EmployeeNew newE2 = new(1002, "Batman", "batman@dc.com");
            EmployeeNew newE3 = new(1003, "Aquaman", "aquaman@dc.com");

            newE1.Name = "Joker";
            newE2.Email = "test@test.com";
            //newE1.Id = 10;

            Console.WriteLine($"{newE1.Id},{newE1.Name}, {newE1.Email}");
            Console.WriteLine($"{newE2.Id},{newE2.Name}, {newE2.Email}");
            Console.WriteLine($"{newE3.Id},{newE3.Name}, {newE3.Email}");
        }
    }

    public class EmployeeNew
    {
        private string _email;
        public int Id { get; private set; }
        public string Name { get; set; }

        public string Email
        {
            get => _email;
            set
            {
                if (!(value.Contains('@') && value.Contains('.')))
                    throw new ArgumentException($"Invalid Email, {value}");

                _email = value;
            }
        }

        public EmployeeNew(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void Jump()
        {
            Id = 55;
            Name = "XXX";
            Email = "aaa.";
        }
    }

    public class EmployeeOld
    {
        private int _id;
        private string _name;
        private string _email;

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public string SetName()
        {
            return _name;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetEmail(string email)
        {
            if (!(email.Contains("@") && email.Contains(".")))
                throw new ArgumentException($"Invalid Email, {email}");

            _email = email;
        }

        public EmployeeOld(int id, string name, string email)
        {
            _id = id;
            _name = name;
            _email = email;
        }
    }
}
