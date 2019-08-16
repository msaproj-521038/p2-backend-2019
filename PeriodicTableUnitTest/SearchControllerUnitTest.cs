/*
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
    public class SearchControllerUnitTest
    {
        public static DbContextOptions<PeriodicTableContext> options
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
                X_Position = 1,
                Y_Position = 1,
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
                X_Position = 18,
                Y_Position = 1,
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
                X_Position = 1,
                Y_Position = 2,
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
                X_Position = 2,
                Y_Position = 2,
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
                X_Position = 13,
                Y_Position = 2,
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
                X_Position = 14,
                Y_Position = 2,
                MeltingPoint = "3823",
                BoilingPoint = "4300"
            }
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
        public async Task TestGetElementsSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                ActionResult<IEnumerable<Element>> result = await ElementsController.GetElements();
                
                // Check that there are five results returned
                Assert.IsTrue(result.Value.Count() == 5);
            }
        }

        [TestMethod]
        public async Task TestSearchByNameSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                ActionResult<IEnumerable<Element>> result = await ElementsController.SearchElementByName("Helium");

                // Check that the results are returned
                Assert.IsTrue(result.Value.ElementAt(0).Name.Equals("Helium"));
            }
        }

        [TestMethod]
        public async Task TestSearchByNameReturnsNothingSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                ActionResult<IEnumerable<Element>> result = await ElementsController.SearchElementByName("Helimum");

                // Check that it returns a null json item as name does not exist
                Assert.IsTrue(result.Value.Count() == 0);
            }
        }

        [TestMethod]
        public async Task TestSearchBySymbolSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                ActionResult<IEnumerable<Element>> result = await ElementsController.SearchElementBySymbol("He");

                // Check that the results are returned
                Assert.IsTrue(result.Value.ElementAt(0).Symbol.Equals("He"));
            }
        }

        [TestMethod]
        public async Task TestSearchByGroupSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                ActionResult<IEnumerable<Element>> result = await ElementsController.SearchElementByGroup("alkaline");

                // Check that the results are returned. Berylium is the only alkaline metal so check that result is there.
                // Also another test to check that you do not need to spell the whole group exactly.
                // Actual result's group should be "alkaline earth metal"
                Assert.IsTrue(result.Value.ElementAt(0).GroupBlock.Contains("alkaline"));
            }
        }

        [TestMethod]
        public async Task TestAddElementSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                Element nitrogen = new Element
                {
                    AtomicNumber = 7,
                    Name = "Nitrogen",
                    Symbol = "N",
                    AtomicMass = "14.007",
                    AtomicRadius = "75",
                    GroupBlock = "nonmetal",
                    BondingType = "diatomic",
                    ElectronConfiguration = "[He] 2s2 2p3",
                    FirstIonisationEnergy = "1402.0",
                    X_Position = 15,
                    Y_Position = 2,
                    MeltingPoint = "63",
                    BoilingPoint = "77"
                };
                ActionResult<Element> result = await ElementsController.PostElement(nitrogen);
                ActionResult<IEnumerable<Element>> Finalresult = await ElementsController.GetElements();

                // Check that the list of element count is 6 as one element is added.
                Assert.IsTrue(Finalresult.Value.Count() == 6);
            }
        }

        [TestMethod]
        public async Task TestChangeElementSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                Element helium = new Element
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
                    X_Position = 18,
                    Y_Position = 1,
                    MeltingPoint = "",
                    BoilingPoint = "4"
                };
                IActionResult result = await ElementsController.PutElement(2,helium);
                ActionResult<Element> Finalresult = await ElementsController.GetElementById(2);

                // Check that helium's melting point is changed from "1" to "".
                Assert.IsTrue(Finalresult.Value.MeltingPoint.Equals(""));
            }
        }

        [TestMethod]
        public async Task TestDeleteElementSuccessfully()
        {
            using (var context = new PeriodicTableContext(options))
            {
                ElementsController ElementsController = new ElementsController(context);
                ActionResult<Element> result = await ElementsController.DeleteElement(3);

                ActionResult<IEnumerable<Element>> Finalresult = await ElementsController.GetElements();

                // Check that the list of element count is 4 as one element is removed.
                Assert.IsTrue(Finalresult.Value.Count() == 4);
            };
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
*/