using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Assets.Tests
{
    [TestFixture]
    public class DataAccessTests
    {
        [Test]
        public void GetPeople_ShouldReturnListOfPeople()
        {
            // Arrange
            var email = "johndoe@example.com";
            var connectionMock = Mock.Of<IDbConnection>();

            var dataAccess = new DataAccess();
            dataAccess.SetDbConnection(connectionMock);

            // Act
            List<Employee> people = dataAccess.GetPeople(email);

            // Assert
            Assert.That(people, Is.Not.Null);
            Assert.That(people.Count, Is.EqualTo(1));
            Assert.That(people[0].firstname, Is.EqualTo("John"));
        }

        // ... (other test methods)
    }
}
