using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvWorks.Api.Controllers;
using NUnit.Framework;

namespace AdvWorks.Api.Tests
{
    [TestFixture]
    public class SalesControllerTest
    {
        [Test]
        public void SalesControllerReceivesSaleAndReturns204()
        {
            var controller = new SalesController();
            Sale sale = new Sale();
            var ret = controller.Post(sale);

            
        }
    }
}
