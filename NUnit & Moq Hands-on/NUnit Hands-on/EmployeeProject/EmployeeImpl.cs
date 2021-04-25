using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject {
    public class EmployeeImpl {
        public string Login(string UserId, string Password) {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be Empty.";
            } else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }

        public List<Employee> GetUsers() {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee {
                Id = 100,
                Name = "Bharat",
                Geneder = "male",
                Salary = 40000
            });
            li.Add(new Employee {
                Id = 101,
                Name = "sunita",
                Geneder = "Female",
                Salary = 50000
            });
            li.Add(new Employee {
                Id = 103,
                Name = "Karan",
                Geneder = "male",
                Salary = 40000
            });
            li.Add(new Employee {
                Id = 104,
                Name = "Jeetu",
                Geneder = "male",
                Salary = 23000
            });


            li.Add(new Employee {
                Id = 105,
                Name = "Manasi",
                Geneder = "Female",
                Salary = 80000
            });
            li.Add(new Employee {
                Id = 106,
                Name = "Ranjit",
                Geneder = "male",
                Salary = 670000
            });
            return li;
        }

        public List<Employee> getDetails(int id) {
            List<Employee> li1 = new List<Employee>();
            EmployeeImpl p = new EmployeeImpl();
            var li = p.GetUsers();
            foreach (var x in li)
            {
                if (x.Id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }


    }
}
