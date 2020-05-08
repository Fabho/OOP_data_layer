using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using ACM.BL;

namespace Acme.CommonTest
{
    /// <summary>
    /// Summary description for LoggingServiceTest
    /// </summary>
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                AddressList = null,
                FirstName = "Frodo",
                LastName = "Bagginns",
                EmailAddress = "fbaggins@hobbiton.me"
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }
    }
}
