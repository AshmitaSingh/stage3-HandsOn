using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeProject;

namespace EmployeeTest
{
    [TestFixture]
    public class TestEmployeeMethod
    {
        [Test]
        public void TestLogin() {
            EmployeeImpl emp = new EmployeeImpl();
            string x = emp.Login("Admin", "1234");
            string y = emp.Login("", "");
            string z = emp.Login("Admin", "Admin");
            Assert.AreEqual("Incorrect UserId or Password.", x);
            Assert.AreEqual("Userid or password could not be Empty.", y);
            Assert.AreEqual("Welcome Admin.", z);
        }
        List<Employee> li;
        [Test]
        public void CheckDetailsTest() {
            EmployeeImpl emp = new EmployeeImpl();
            li = emp.GetUsers();
            
            foreach (var employee in li)
            {
                Assert.IsNotNull(employee.Id);
                Assert.IsNotNull(employee.Name);
                Assert.IsNotNull(employee.Geneder);
                Assert.IsNotNull(employee.Salary);
            }

        }

        [Test]
        public void GetUserDetailsTest() {
            EmployeeImpl emp = new EmployeeImpl();
            Employee p = emp.getDetails(100).SingleOrDefault();
            Employee employee = p;

            Assert.AreSame(employee, p);
            // foreach (var x in p)
            {
                Assert.AreEqual(p.Id, 100);
                Assert.AreEqual(p.Name, "Bharat");
            }
        }
    }
}
