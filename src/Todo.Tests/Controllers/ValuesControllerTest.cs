using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo;
using Todo.Controllers;

namespace Todo.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Düzenle
            ValuesController controller = new ValuesController();

            // Yap
            IEnumerable<string> result = controller.Get();

            // Onayla
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Düzenle
            ValuesController controller = new ValuesController();

            // Yap
            string result = controller.Get(5);

            // Onayla
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Düzenle
            ValuesController controller = new ValuesController();

            // Yap
            controller.Post("value");

            // Onayla
        }

        [TestMethod]
        public void Put()
        {
            // Düzenle
            ValuesController controller = new ValuesController();

            // Yap
            controller.Put(5, "value");

            // Onayla
        }

        [TestMethod]
        public void Delete()
        {
            // Düzenle
            ValuesController controller = new ValuesController();

            // Yap
            controller.Delete(5);

            // Onayla
        }
    }
}
