using CustomerManagementSystem.BL;

namespace CustomerManagementSystem.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Azeez",
                LastName = "Oladejo"
            };
            string expected = "Oladejo, Azeez";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Azeez"
            };
            string expected = "Azeez";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Oladejo"
            };
            string expected = "Oladejo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }
} 