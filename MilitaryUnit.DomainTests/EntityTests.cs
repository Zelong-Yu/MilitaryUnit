using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilitaryUnit.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain.Tests
{
    [TestClass()]
    public class EntityTests
    {
        Entity ootDefault = new Entity();
        Entity ootWithName = new Entity("newname");
        [TestMethod()]
        public void EntityTest()
        {
            //Test Constructor
            Assert.AreEqual("Default Entity", ootDefault.Name);

            Assert.AreEqual("newname", ootWithName.Name);

            //Test numEntities
            Assert.AreEqual(2, Entity.numEntities);
        }
    }
}