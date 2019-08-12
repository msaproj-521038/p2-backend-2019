using PeriodicTable.Controllers;
using PeriodicTable.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace PeriodicTableUnitTest
{
    [TestClass]
    class SearchControllerUnitTest
    {
        public static readonly DbContextOptions<PeriodicTableContext> options
        = new DbContextOptionsBuilder<PeriodicTableContext>()
        .UseInMemoryDatabase(databaseName: "testDatabase")
        .Options;

        public static readonly IList<Element> Elements = new List<Element>
        {
            new Element
            {
                AtomicNumber = 1,
                Name = "Hydrogen",
                Symbol = "H",
                AtomicMass = "1.008",
                AtomicRadius = "37",
                GroupBlock = "nonmetal",
                BondingType = "diatomic",
                ElectronConfiguration = "1s1",
                FirstIonisationEnergy = "1312.0",
                MeltingPoint = "14",
                BoilingPoint = "20"
            },

            new Element
            {
                AtomicNumber = 2,
                Name = "Helium",
                Symbol = "He",
                AtomicMass = "4.003",
                AtomicRadius = "32",
                GroupBlock = "noble gas",
                BondingType = "atomic",
                ElectronConfiguration = "1s2",
                FirstIonisationEnergy = "2372.0",
                MeltingPoint = "1",
                BoilingPoint = "4"
            },

            new Element
            {
                AtomicNumber = 3,
                Name = "Lithium",
                Symbol = "Li",
                AtomicMass = "6.94",
                AtomicRadius = "134",
                GroupBlock = "alkali metal",
                BondingType = "metallic",
                ElectronConfiguration = "[He] 2s1",
                FirstIonisationEnergy = "520.0",
                MeltingPoint = "454",
                BoilingPoint = "1615"
            },

            new Element
            {
                AtomicNumber = 4,
                Name = "Beryllium",
                Symbol = "Be",
                AtomicMass = "9.012",
                AtomicRadius = "90",
                GroupBlock = "alkaline earth metal",
                BondingType = "metallic",
                ElectronConfiguration = "[He] 2s2",
                FirstIonisationEnergy = "900.0",
                MeltingPoint = "1560",
                BoilingPoint = "2743"
            },

            new Element
            {
                AtomicNumber = 5,
                Name = "Boron",
                Symbol = "B",
                AtomicMass = "10.81",
                AtomicRadius = "82",
                GroupBlock = "metalloid",
                BondingType = "covalent network",
                ElectronConfiguration = "[He] 2s2 2p1",
                FirstIonisationEnergy = "801.0",
                MeltingPoint = "2348",
                BoilingPoint = "4273"
            },

            new Element
            {
                AtomicNumber = 6,
                Name = "Carbon",
                Symbol = "C",
                AtomicMass = "12.011",
                AtomicRadius = "77",
                GroupBlock = "nonmetal",
                BondingType = "covalent network",
                ElectronConfiguration = "[He] 2s2 2p2",
                FirstIonisationEnergy = "1086.0",
                MeltingPoint = "3823",
                BoilingPoint = "4300"
            },
        };

        [TestInitialize]
        public void SetupDb()
        {
            using (var context = new PeriodicTableContext(options))
            {
                // populate the db
                context.Element.Add(Elements[0]);
                context.Element.Add(Elements[1]);
                context.Element.Add(Elements[2]);
                context.Element.Add(Elements[3]);
                context.Element.Add(Elements[4]);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public async Task TestGetSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                ActionResult<IEnumerable<Element>> result = await ElementsController.GetElements();

                // Check that the results are returned
                Assert.IsNotNull(result);
            }
        }

        [TestCleanup]
        public void ClearDb()
        {
            using (var context = new PeriodicTableContext(options))
            {
                // clear the db
                context.Element.RemoveRange(context.Element);
                context.SaveChanges();
            };
        }
    }
}
