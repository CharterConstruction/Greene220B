using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimecardRepository.Employees;

namespace TimecardRepository.Employees.Tests
{
    [TestClass()]
    public class EmployeeRepositoryTests
    {       

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QueryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            EmployeeRepository _repo = new EmployeeRepository();
            var results = _repo.GetAll();

            Assert.IsNotNull(results);            
        }

        [TestMethod()]
        public void RemoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}