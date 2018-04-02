using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WingsOn.Bus.Test.Mock;
using WingsOn.Dal;
using WingsOn.Domain;

namespace WingsOn.Bus.Test
{
    [TestClass]
    public class PassengersContractUnitTest
    {
        PassengersContract contract;
        Mock<IRepository<Person>> mockPersonRepository;
        Mock<IRepository<Booking>> mockBookingRepository;

        [TestInitialize]
        public void Init()
        {
            mockPersonRepository = new Mock<IRepository<Person>>();
            mockBookingRepository = new Mock<IRepository<Booking>>();

            mockPersonRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int x) => new MockPersonRepository().Get(x));
            mockPersonRepository.Setup(x => x.GetAll()).Returns(() => new MockPersonRepository().GetAll());

            mockBookingRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int x) => new MockBookingRepository().Get(x));
            mockBookingRepository.Setup(x => x.GetAll()).Returns(() => new MockBookingRepository().GetAll());

            contract = new PassengersContract(mockPersonRepository.Object, mockBookingRepository.Object);
        }


        [TestMethod]
        public void Get_Found()
        {
            int id = 91;
            var result = contract.Get(id);

            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        public void Get_NotFound()
        {
            int id = 2;
            var result = contract.Get(id);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetByFlight_Found()
        {
            string flightNumber = "PZ696";
            var result = contract.GetByFlight(flightNumber);

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
        }

        [TestMethod]
        public void GetByFlight_NotFound()
        {
            string flightNumber = "PZ6967";
            var result = contract.GetByFlight(flightNumber);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetByGender_Found()
        {
            GenderType type = GenderType.Male;
            var result = contract.GetByGender(type);

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
            result.ForEach(p => Assert.AreEqual(type, p.Gender));
        }

        [TestMethod]
        [ExpectedException(typeof(Util.Helper.ExecutionException))]
        public void Get_RepositoryException()
        {
            mockPersonRepository = new Mock<IRepository<Person>>();
            mockPersonRepository.Setup(x => x.Get(It.IsAny<int>())).Throws(new Exception("Repository not found"));

            contract = new PassengersContract(mockPersonRepository.Object, mockBookingRepository.Object);

            int id = 91;
            var result = contract.Get(id);
        }

        [TestMethod]
        [ExpectedException(typeof(Util.Helper.ExecutionException))]
        public void GetAll_RepositoryInvalidResponse()
        {
            mockBookingRepository = new Mock<IRepository<Booking>>();
            mockBookingRepository.Setup(x => x.GetAll()).Returns((List<Booking>)null);

            contract = new PassengersContract(mockPersonRepository.Object, mockBookingRepository.Object);

            string flightNumber = "PZ696";
            var result = contract.GetByFlight(flightNumber);

        }
    }
}
