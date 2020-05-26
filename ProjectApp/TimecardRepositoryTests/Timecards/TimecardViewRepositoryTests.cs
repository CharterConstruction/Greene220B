using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimecardRepository.TimecardViews;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimecardRepository.TimecardViews.Tests
{
    [TestClass()]
    public class TimecardViewRepositoryTests
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
            TimecardViewRepository _repo = new TimecardViewRepository();
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