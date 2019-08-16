using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeriodicTable.Models
{
    public static class Data
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PeriodicTableContext(
                serviceProvider.GetRequiredService<DbContextOptions<PeriodicTableContext>>()))
            {
                // Check that that the elements are present.
                if (context.Element.Count() > 0)
                {
                    return;   // DB has been seeded
                }

                context.Element.AddRange(
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
                    },

                    new Element
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
                    },

                    new Element
                    {
                        AtomicNumber = 8,
                        Name = "Oxygen",
                        Symbol = "O",
                        AtomicMass = "15.999",
                        AtomicRadius = "73",
                        GroupBlock = "nonmetal",
                        BondingType = "diatomic",
                        ElectronConfiguration = "[He] 2s2 2p4",
                        FirstIonisationEnergy = "1314.0",
                        X_Position = 16,
                        Y_Position = 2,
                        MeltingPoint = "55",
                        BoilingPoint = "90"
                    },

                    new Element
                    {
                        AtomicNumber = 9,
                        Name = "Fluorine",
                        Symbol = "F",
                        AtomicMass = "18.998",
                        AtomicRadius = "71",
                        GroupBlock = "halogen",
                        BondingType = "atomic",
                        ElectronConfiguration = "[He] 2s2 2p5",
                        FirstIonisationEnergy = "1681.0",
                        X_Position = 17,
                        Y_Position = 2,
                        MeltingPoint = "54",
                        BoilingPoint = "85"
                    },

                    new Element
                    {
                        AtomicNumber = 10,
                        Name = "Neon",
                        Symbol = "Ne",
                        AtomicMass = "20.18",
                        AtomicRadius = "69",
                        GroupBlock = "noble gas",
                        BondingType = "atomic",
                        ElectronConfiguration = "[He] 2s2 2p6",
                        FirstIonisationEnergy = "2081.0",
                        X_Position = 18,
                        Y_Position = 2,
                        MeltingPoint = "25",
                        BoilingPoint = "27"
                    },

                    new Element
                    {
                        AtomicNumber = 11,
                        Name = "Sodium",
                        Symbol = "Na",
                        AtomicMass = "22.99",
                        AtomicRadius = "154",
                        GroupBlock = "alkali metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ne] 3s1",
                        FirstIonisationEnergy = "496.0",
                        X_Position = 1,
                        Y_Position = 3,
                        MeltingPoint = "371",
                        BoilingPoint = "1156"
                    },

                    new Element
                    {
                        AtomicNumber = 12,
                        Name = "Magnesium",
                        Symbol = "Mg",
                        AtomicMass = "24.305",
                        AtomicRadius = "130",
                        GroupBlock = "alkaline earth metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ne] 3s2",
                        FirstIonisationEnergy = "738.0",
                        X_Position = 2,
                        Y_Position = 3,
                        MeltingPoint = "923",
                        BoilingPoint = "1363"
                    },

                    new Element
                    {
                        AtomicNumber = 13,
                        Name = "Aluminium",
                        Symbol = "Al",
                        AtomicMass = "26.982",
                        AtomicRadius = "118",
                        GroupBlock = "metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ne] 3s2 3p1",
                        FirstIonisationEnergy = "578.0",
                        X_Position = 13,
                        Y_Position = 3,
                        MeltingPoint = "933",
                        BoilingPoint = "2792"
                    },

                    new Element
                    {
                        AtomicNumber = 14,
                        Name = "Silicon",
                        Symbol = "Si",
                        AtomicMass = "28.085",
                        AtomicRadius = "111",
                        GroupBlock = "metalloid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ne] 3s2 3p2",
                        FirstIonisationEnergy = "786.0",
                        X_Position = 14,
                        Y_Position = 3,
                        MeltingPoint = "1687",
                        BoilingPoint = "3173"
                    },

                    new Element
                    {
                        AtomicNumber = 15,
                        Name = "Phosphorus",
                        Symbol = "P",
                        AtomicMass = "30.974",
                        AtomicRadius = "106",
                        GroupBlock = "nonmetal",
                        BondingType = "covalent network",
                        ElectronConfiguration = "[Ne] 3s2 3p3",
                        FirstIonisationEnergy = "1012.0",
                        X_Position = 15,
                        Y_Position = 3,
                        MeltingPoint = "317",
                        BoilingPoint = "554"
                    },

                    new Element
                    {
                        AtomicNumber = 16,
                        Name = "Sulfur",
                        Symbol = "S",
                        AtomicMass = "32.06",
                        AtomicRadius = "102",
                        GroupBlock = "nonmetal",
                        BondingType = "covalent network",
                        ElectronConfiguration = "[Ne] 3s2 3p4",
                        FirstIonisationEnergy = "1000.0",
                        X_Position = 16,
                        Y_Position = 3,
                        MeltingPoint = "388",
                        BoilingPoint = "718"
                    },

                    new Element
                    {
                        AtomicNumber = 17,
                        Name = "Chlorine",
                        Symbol = "Cl",
                        AtomicMass = "35.45",
                        AtomicRadius = "99",
                        GroupBlock = "halogen",
                        BondingType = "covalent network",
                        ElectronConfiguration = "[Ne] 3s2 3p5",
                        FirstIonisationEnergy = "1251.0",
                        X_Position = 17,
                        Y_Position = 3,
                        MeltingPoint = "172",
                        BoilingPoint = "239"
                    },

                    new Element
                    {
                        AtomicNumber = 18,
                        Name = "Argon",
                        Symbol = "Ar",
                        AtomicMass = "39.948",
                        AtomicRadius = "97",
                        GroupBlock = "noble gas",
                        BondingType = "atomic",
                        ElectronConfiguration = "[Ne] 3s2 3p6",
                        FirstIonisationEnergy = "1521.0",
                        X_Position = 18,
                        Y_Position = 3,
                        MeltingPoint = "84",
                        BoilingPoint = "87"
                    },

                    new Element
                    {
                        AtomicNumber = 19,
                        Name = "Potassium",
                        Symbol = "K",
                        AtomicMass = "39.098",
                        AtomicRadius = "196",
                        GroupBlock = "alkali metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 4s1",
                        FirstIonisationEnergy = "419.0",
                        X_Position = 1,
                        Y_Position = 4,
                        MeltingPoint = "337",
                        BoilingPoint = "1032"
                    },

                    new Element
                    {
                        AtomicNumber = 20,
                        Name = "Calcium",
                        Symbol = "Ca",
                        AtomicMass = "40.078",
                        AtomicRadius = "174",
                        GroupBlock = "alkaline earth metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 4s2",
                        FirstIonisationEnergy = "590.0",
                        X_Position = 2,
                        Y_Position = 4,
                        MeltingPoint = "1115",
                        BoilingPoint = "1757"
                    },

                    new Element
                    {
                        AtomicNumber = 21,
                        Name = "Scandium",
                        Symbol = "Sc",
                        AtomicMass = "44.956",
                        AtomicRadius = "144",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d1 4s2",
                        FirstIonisationEnergy = "633.0",
                        X_Position = 3,
                        Y_Position = 4,
                        MeltingPoint = "1814",
                        BoilingPoint = "3103"
                    },

                    new Element
                    {
                        AtomicNumber = 22,
                        Name = "Titanium",
                        Symbol = "Ti",
                        AtomicMass = "47.867",
                        AtomicRadius = "136",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d2 4s2",
                        FirstIonisationEnergy = "659.0",
                        X_Position = 4,
                        Y_Position = 4,
                        MeltingPoint = "1941",
                        BoilingPoint = "3560"
                    },

                    new Element
                    {
                        AtomicNumber = 23,
                        Name = "Vanadium",
                        Symbol = "V",
                        AtomicMass = "50.942",
                        AtomicRadius = "125",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d3 4s2",
                        FirstIonisationEnergy = "651.0",
                        X_Position = 5,
                        Y_Position = 4,
                        MeltingPoint = "2183",
                        BoilingPoint = "3680"
                    },

                    new Element
                    {
                        AtomicNumber = 24,
                        Name = "Chromium",
                        Symbol = "Cr",
                        AtomicMass = "51.996",
                        AtomicRadius = "127",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d5 4s1",
                        FirstIonisationEnergy = "653.0",
                        X_Position = 6,
                        Y_Position = 4,
                        MeltingPoint = "2180",
                        BoilingPoint = "2944"
                    },

                    new Element
                    {
                        AtomicNumber = 25,
                        Name = "Manganese",
                        Symbol = "Mn",
                        AtomicMass = "54.938",
                        AtomicRadius = "139",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d5 4s2",
                        FirstIonisationEnergy = "717.0",
                        X_Position = 7,
                        Y_Position = 4,
                        MeltingPoint = "1519",
                        BoilingPoint = "2334"
                    },

                    new Element
                    {
                        AtomicNumber = 26,
                        Name = "Iron",
                        Symbol = "Fe",
                        AtomicMass = "55.845",
                        AtomicRadius = "125",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d6 4s2",
                        FirstIonisationEnergy = "762.0",
                        X_Position = 8,
                        Y_Position = 4,
                        MeltingPoint = "1811",
                        BoilingPoint = "3134"
                    },

                    new Element
                    {
                        AtomicNumber = 27,
                        Name = "Cobalt",
                        Symbol = "Co",
                        AtomicMass = "58.933",
                        AtomicRadius = "126",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d7 4s2",
                        FirstIonisationEnergy = "760.0",
                        X_Position = 9,
                        Y_Position = 4,
                        MeltingPoint = "1768",
                        BoilingPoint = "3200"
                    },

                    new Element
                    {
                        AtomicNumber = 28,
                        Name = "Nickel",
                        Symbol = "Ni",
                        AtomicMass = "58.693",
                        AtomicRadius = "121",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d8 4s2",
                        FirstIonisationEnergy = "737.0",
                        X_Position = 10,
                        Y_Position = 4,
                        MeltingPoint = "1728",
                        BoilingPoint = "3186"
                    },

                    new Element
                    {
                        AtomicNumber = 29,
                        Name = "Copper",
                        Symbol = "Cu",
                        AtomicMass = "63.546",
                        AtomicRadius = "138",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d10 4s1",
                        FirstIonisationEnergy = "746.0",
                        X_Position = 11,
                        Y_Position = 4,
                        MeltingPoint = "1358",
                        BoilingPoint = "3200"
                    },

                    new Element
                    {
                        AtomicNumber = 30,
                        Name = "Zinc",
                        Symbol = "Zn",
                        AtomicMass = "65.382",
                        AtomicRadius = "131",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d10 4s2",
                        FirstIonisationEnergy = "906.0",
                        X_Position = 12,
                        Y_Position = 4,
                        MeltingPoint = "693",
                        BoilingPoint = "1180"
                    },

                    new Element
                    {
                        AtomicNumber = 31,
                        Name = "Gallium",
                        Symbol = "Ga",
                        AtomicMass = "69.723",
                        AtomicRadius = "126",
                        GroupBlock = "metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d10 4s2 4p1",
                        FirstIonisationEnergy = "579.0",
                        X_Position = 13,
                        Y_Position = 4,
                        MeltingPoint = "303",
                        BoilingPoint = "2477"
                    },

                    new Element
                    {
                        AtomicNumber = 32,
                        Name = "Germanium",
                        Symbol = "Ge",
                        AtomicMass = "72.631",
                        AtomicRadius = "122",
                        GroupBlock = "metalloid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d10 4s2 4p2",
                        FirstIonisationEnergy = "762",
                        X_Position = 14,
                        Y_Position = 4,
                        MeltingPoint = "1211",
                        BoilingPoint = "3093"
                    },

                    new Element
                    {
                        AtomicNumber = 33,
                        Name = "Arsenic",
                        Symbol = "As",
                        AtomicMass = "74.922",
                        AtomicRadius = "119",
                        GroupBlock = "metalloid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d10 4s2 4p3",
                        FirstIonisationEnergy = "947.0",
                        X_Position = 15,
                        Y_Position = 4,
                        MeltingPoint = "1090",
                        BoilingPoint = "887"
                    },

                    new Element
                    {
                        AtomicNumber = 34,
                        Name = "Selenium",
                        Symbol = "Se",
                        AtomicMass = "78.972",
                        AtomicRadius = "116",
                        GroupBlock = "nonmetal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Ar] 3d10 4s2 4p4",
                        FirstIonisationEnergy = "941.0",
                        X_Position = 16,
                        Y_Position = 4,
                        MeltingPoint = "494",
                        BoilingPoint = "958"
                    },

                    new Element
                    {
                        AtomicNumber = 35,
                        Name = "Bromine",
                        Symbol = "Br",
                        AtomicMass = "79.904",
                        AtomicRadius = "114",
                        GroupBlock = "halogen",
                        BondingType = "covalent network",
                        ElectronConfiguration = "[Ar] 3d10 4s2 4p5",
                        FirstIonisationEnergy = "1140.0",
                        X_Position = 17,
                        Y_Position = 4,
                        MeltingPoint = "266",
                        BoilingPoint = "332"
                    },

                    new Element
                    {
                        AtomicNumber = 36,
                        Name = "Krypton",
                        Symbol = "Kr",
                        AtomicMass = "83.798",
                        AtomicRadius = "110",
                        GroupBlock = "noble gas",
                        BondingType = "atomic",
                        ElectronConfiguration = "[Ar] 3d10 4s2 4p6",
                        FirstIonisationEnergy = "1351.0",
                        X_Position = 18,
                        Y_Position = 4,
                        MeltingPoint = "116",
                        BoilingPoint = "120"
                    },

                    new Element
                    {
                        AtomicNumber = 37,
                        Name = "Rubidium",
                        Symbol = "Rb",
                        AtomicMass = "85.468",
                        AtomicRadius = "211",
                        GroupBlock = "alkali metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 5s1",
                        FirstIonisationEnergy = "403.0",
                        X_Position = 1,
                        Y_Position = 5,
                        MeltingPoint = "312",
                        BoilingPoint = "961"
                    },

                    new Element
                    {
                        AtomicNumber = 38,
                        Name = "Strontium",
                        Symbol = "Sr",
                        AtomicMass = "87.621",
                        AtomicRadius = "192",
                        GroupBlock = "alkaline earth metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 5s2",
                        FirstIonisationEnergy = "550.0",
                        X_Position = 2,
                        Y_Position = 5,
                        MeltingPoint = "1050",
                        BoilingPoint = "1655"
                    },

                    new Element
                    {
                        AtomicNumber = 39,
                        Name = "Yttrium",
                        Symbol = "Y",
                        AtomicMass = "88.906",
                        AtomicRadius = "162",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d1 5s2",
                        FirstIonisationEnergy = "600",
                        X_Position = 3,
                        Y_Position = 5,
                        MeltingPoint = "1799",
                        BoilingPoint = "3618"
                    },

                    new Element
                    {
                        AtomicNumber = 40,
                        Name = "Zirconium",
                        Symbol = "Zr",
                        AtomicMass = "91.224",
                        AtomicRadius = "148",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d2 5s2",
                        FirstIonisationEnergy = "640.0",
                        X_Position = 4,
                        Y_Position = 5,
                        MeltingPoint = "2128",
                        BoilingPoint = "4682"
                    },

                    new Element
                    {
                        AtomicNumber = 41,
                        Name = "Niobium",
                        Symbol = "Nb",
                        AtomicMass = "92.906",
                        AtomicRadius = "137",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d4 5s1",
                        FirstIonisationEnergy = "652.0",
                        X_Position = 5,
                        Y_Position = 5,
                        MeltingPoint = "2750",
                        BoilingPoint = "5017"
                    },

                    new Element
                    {
                        AtomicNumber = 42,
                        Name = "Molybdenum",
                        Symbol = "Mo",
                        AtomicMass = "95.951",
                        AtomicRadius = "145",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d5 5s1",
                        FirstIonisationEnergy = "684.0",
                        X_Position = 6,
                        Y_Position = 5,
                        MeltingPoint = "2896",
                        BoilingPoint = "4912"
                    },

                    new Element
                    {
                        AtomicNumber = 43,
                        Name = "Technetium",
                        Symbol = "Tc",
                        AtomicMass = "98",
                        AtomicRadius = "156",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d5 5s2",
                        FirstIonisationEnergy = "702",
                        X_Position = 7,
                        Y_Position = 5,
                        MeltingPoint = "2430",
                        BoilingPoint = "4538"
                    },

                    new Element
                    {
                        AtomicNumber = 44,
                        Name = "Ruthenium",
                        Symbol = "Ru",
                        AtomicMass = "101.072",
                        AtomicRadius = "126",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d7 5s1",
                        FirstIonisationEnergy = "710.0",
                        X_Position = 8,
                        Y_Position = 5,
                        MeltingPoint = "2607",
                        BoilingPoint = "4423"
                    },

                    new Element
                    {
                        AtomicNumber = 45,
                        Name = "Rhodium",
                        Symbol = "Rh",
                        AtomicMass = "102.906",
                        AtomicRadius = "135",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d8 5s1",
                        FirstIonisationEnergy = "720.0",
                        X_Position = 9,
                        Y_Position = 5,
                        MeltingPoint = "2237",
                        BoilingPoint = "3968"
                    },

                    new Element
                    {
                        AtomicNumber = 46,
                        Name = "Palladium",
                        Symbol = "Pd",
                        AtomicMass = "106.421",
                        AtomicRadius = "131",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d10",
                        FirstIonisationEnergy = "804.0",
                        X_Position = 10,
                        Y_Position = 5,
                        MeltingPoint = "1828",
                        BoilingPoint = "3236"
                    },

                    new Element
                    {
                        AtomicNumber = 47,
                        Name = "Silver",
                        Symbol = "Ag",
                        AtomicMass = "107.868",
                        AtomicRadius = "153",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d10 5s1",
                        FirstIonisationEnergy = "731.0",
                        X_Position = 11,
                        Y_Position = 5,
                        MeltingPoint = "1235",
                        BoilingPoint = "2435"
                    },

                    new Element
                    {
                        AtomicNumber = 48,
                        Name = "Cadmium",
                        Symbol = "Cd",
                        AtomicMass = "112.414",
                        AtomicRadius = "148",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d10 5s2",
                        FirstIonisationEnergy = "868.0",
                        X_Position = 12,
                        Y_Position = 5,
                        MeltingPoint = "594",
                        BoilingPoint = "1040"
                    },

                    new Element
                    {
                        AtomicNumber = 49,
                        Name = "Indium",
                        Symbol = "In",
                        AtomicMass = "114.818",
                        AtomicRadius = "144",
                        GroupBlock = "metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d10 5s2 5p1",
                        FirstIonisationEnergy = "558.0",
                        X_Position = 13,
                        Y_Position = 5,
                        MeltingPoint = "430",
                        BoilingPoint = "2345"
                    },

                    new Element
                    {
                        AtomicNumber = 50,
                        Name = "Tin",
                        Symbol = "Sn",
                        AtomicMass = "118.711",
                        AtomicRadius = "141",
                        GroupBlock = "metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d10 5s2 5p2",
                        FirstIonisationEnergy = "709.0",
                        X_Position = 14,
                        Y_Position = 5,
                        MeltingPoint = "505",
                        BoilingPoint = "2875"
                    },

                    new Element
                    {
                        AtomicNumber = 51,
                        Name = "Antimony",
                        Symbol = "Sb",
                        AtomicMass = "121.76",
                        AtomicRadius = "138",
                        GroupBlock = "metalloid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d10 5s2 5p3",
                        FirstIonisationEnergy = "834",
                        X_Position = 15,
                        Y_Position = 5,
                        MeltingPoint = "904",
                        BoilingPoint = "1860"
                    },

                    new Element
                    {
                        AtomicNumber = 52,
                        Name = "Tellurium",
                        Symbol = "Te",
                        AtomicMass = "127.603",
                        AtomicRadius = "135",
                        GroupBlock = "metalloid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Kr] 4d10 5s2 5p4",
                        FirstIonisationEnergy = "869.0",
                        X_Position = 16,
                        Y_Position = 5,
                        MeltingPoint = "723",
                        BoilingPoint = "1261"
                    },

                    new Element
                    {
                        AtomicNumber = 53,
                        Name = "Iodine",
                        Symbol = "I",
                        AtomicMass = "126.904",
                        AtomicRadius = "133",
                        GroupBlock = "halogen",
                        BondingType = "covalent network",
                        ElectronConfiguration = "[Kr] 4d10 5s2 5p5",
                        FirstIonisationEnergy = "1008.0",
                        X_Position = 17,
                        Y_Position = 5,
                        MeltingPoint = "387",
                        BoilingPoint = "457"
                    },

                    new Element
                    {
                        AtomicNumber = 54,
                        Name = "Xenon",
                        Symbol = "Xe",
                        AtomicMass = "131.294",
                        AtomicRadius = "130",
                        GroupBlock = "noble gas",
                        BondingType = "atomic",
                        ElectronConfiguration = "[Kr] 4d10 5s2 5p6",
                        FirstIonisationEnergy = "1170.0",
                        X_Position = 18,
                        Y_Position = 5,
                        MeltingPoint = "161",
                        BoilingPoint = "165"
                    },

                    new Element
                    {
                        AtomicNumber = 55,
                        Name = "Cesium",
                        Symbol = "Cs",
                        AtomicMass = "132.905",
                        AtomicRadius = "225",
                        GroupBlock = "alkali metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 6s1",
                        FirstIonisationEnergy = "376.0",
                        X_Position = 1,
                        Y_Position = 6,
                        MeltingPoint = "302",
                        BoilingPoint = "944"
                    },

                    new Element
                    {
                        AtomicNumber = 56,
                        Name = "Barium",
                        Symbol = "Ba",
                        AtomicMass = "137.328",
                        AtomicRadius = "198",
                        GroupBlock = "alkaline earth metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 6s2",
                        FirstIonisationEnergy = "503.0",
                        X_Position = 2,
                        Y_Position = 6,
                        MeltingPoint = "1000",
                        BoilingPoint = "2143"
                    },

                    new Element
                    {
                        AtomicNumber = 57,
                        Name = "Lanthanum",
                        Symbol = "La",
                        AtomicMass = "138.905",
                        AtomicRadius = "169",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 5d1 6s2",
                        FirstIonisationEnergy = "538.0",
                        X_Position = 3,
                        Y_Position = 9,
                        MeltingPoint = "1193",
                        BoilingPoint = "3737"
                    },

                    new Element
                    {
                        AtomicNumber = 58,
                        Name = "Cerium",
                        Symbol = "Ce",
                        AtomicMass = "140.116",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f1 5d1 6s2",
                        FirstIonisationEnergy = "534.0",
                        X_Position = 4,
                        Y_Position = 9,
                        MeltingPoint = "1071",
                        BoilingPoint = "3633"
                    },

                    new Element
                    {
                        AtomicNumber = 59,
                        Name = "Praseodymium",
                        Symbol = "Pr",
                        AtomicMass = "140.908",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f3 6s2",
                        FirstIonisationEnergy = "527",
                        X_Position = 5,
                        Y_Position = 9,
                        MeltingPoint = "1204",
                        BoilingPoint = "3563"
                    },

                    new Element
                    {
                        AtomicNumber = 60,
                        Name = "Neodymium",
                        Symbol = "Nd",
                        AtomicMass = "144.242",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f4 6s2",
                        FirstIonisationEnergy = "533.0",
                        X_Position = 6,
                        Y_Position = 9,
                        MeltingPoint = "1294",
                        BoilingPoint = "3373"
                    },

                    new Element
                    {
                        AtomicNumber = 61,
                        Name = "Promethium",
                        Symbol = "Pm",
                        AtomicMass = "145",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f5 6s2",
                        FirstIonisationEnergy = "540",
                        X_Position = 7,
                        Y_Position = 9,
                        MeltingPoint = "1373",
                        BoilingPoint = "3273"
                    },

                    new Element
                    {
                        AtomicNumber = 62,
                        Name = "Samarium",
                        Symbol = "Sm",
                        AtomicMass = "150.362",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f6 6s2",
                        FirstIonisationEnergy = "544.0",
                        X_Position = 8,
                        Y_Position = 9,
                        MeltingPoint = "1345",
                        BoilingPoint = "2076"
                    },

                    new Element
                    {
                        AtomicNumber = 63,
                        Name = "Europium",
                        Symbol = "Eu",
                        AtomicMass = "151.964",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f7 6s2",
                        FirstIonisationEnergy = "547.0",
                        X_Position = 9,
                        Y_Position = 9,
                        MeltingPoint = "1095",
                        BoilingPoint = "1800"
                    },

                    new Element
                    {
                        AtomicNumber = 64,
                        Name = "Gadolinium",
                        Symbol = "Gd",
                        AtomicMass = "157.253",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f7 5d1 6s2",
                        FirstIonisationEnergy = "593.0",
                        X_Position = 10,
                        Y_Position = 9,
                        MeltingPoint = "1586",
                        BoilingPoint = "3523"
                    },

                    new Element
                    {
                        AtomicNumber = 65,
                        Name = "Terbium",
                        Symbol = "Tb",
                        AtomicMass = "158.925",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f9 6s2",
                        FirstIonisationEnergy = "566.0",
                        X_Position = 11,
                        Y_Position = 9,
                        MeltingPoint = "1629",
                        BoilingPoint = "3503"
                    },

                    new Element
                    {
                        AtomicNumber = 66,
                        Name = "Dysprosium",
                        Symbol = "Dy",
                        AtomicMass = "162.5",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f10 6s2",
                        FirstIonisationEnergy = "573.0",
                        X_Position = 12,
                        Y_Position = 9,
                        MeltingPoint = "1685",
                        BoilingPoint = "2840"
                    },

                    new Element
                    {
                        AtomicNumber = 67,
                        Name = "Holmium",
                        Symbol = "Ho",
                        AtomicMass = "164.93",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f11 6s2",
                        FirstIonisationEnergy = "581.0",
                        X_Position = 13,
                        Y_Position = 9,
                        MeltingPoint = "1747",
                        BoilingPoint = "2973"
                    },

                    new Element
                    {
                        AtomicNumber = 68,
                        Name = "Erbium",
                        Symbol = "Er",
                        AtomicMass = "167.259",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f12 6s2",
                        FirstIonisationEnergy = "589.0",
                        X_Position = 14,
                        Y_Position = 9,
                        MeltingPoint = "1770",
                        BoilingPoint = "3141"
                    },

                    new Element
                    {
                        AtomicNumber = 69,
                        Name = "Thulium",
                        Symbol = "Tm",
                        AtomicMass = "168.934",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f13 6s2",
                        FirstIonisationEnergy = "597.0",
                        X_Position = 15,
                        Y_Position = 9,
                        MeltingPoint = "1818",
                        BoilingPoint = "2223"
                    },

                    new Element
                    {
                        AtomicNumber = 70,
                        Name = "Ytterbium",
                        Symbol = "Yb",
                        AtomicMass = "173.045",
                        AtomicRadius = "",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 6s2",
                        FirstIonisationEnergy = "603.0",
                        X_Position = 16,
                        Y_Position = 9,
                        MeltingPoint = "1092",
                        BoilingPoint = "1469"
                    },

                    new Element
                    {
                        AtomicNumber = 71,
                        Name = "Lutetium",
                        Symbol = "Lu",
                        AtomicMass = "174.967",
                        AtomicRadius = "160",
                        GroupBlock = "lanthanoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d1 6s2",
                        FirstIonisationEnergy = "524.0",
                        X_Position = 17,
                        Y_Position = 9,
                        MeltingPoint = "1936",
                        BoilingPoint = "3675"
                    },

                    new Element
                    {
                        AtomicNumber = 72,
                        Name = "Hafnium",
                        Symbol = "Hf",
                        AtomicMass = "178.492",
                        AtomicRadius = "150",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d2 6s2",
                        FirstIonisationEnergy = "658.0",
                        X_Position = 4,
                        Y_Position = 6,
                        MeltingPoint = "2506",
                        BoilingPoint = "4876"
                    },

                    new Element
                    {
                        AtomicNumber = 73,
                        Name = "Tantalum",
                        Symbol = "Ta",
                        AtomicMass = "180.948",
                        AtomicRadius = "138",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d3 6s2",
                        FirstIonisationEnergy = "761",
                        X_Position = 5,
                        Y_Position = 6,
                        MeltingPoint = "3290",
                        BoilingPoint = "5731"
                    },

                    new Element
                    {
                        AtomicNumber = 74,
                        Name = "Tungsten",
                        Symbol = "W",
                        AtomicMass = "183.841",
                        AtomicRadius = "146",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d4 6s2",
                        FirstIonisationEnergy = "770",
                        X_Position = 6,
                        Y_Position = 6,
                        MeltingPoint = "3695",
                        BoilingPoint = "5828"
                    },

                    new Element
                    {
                        AtomicNumber = 75,
                        Name = "Rhenium",
                        Symbol = "Re",
                        AtomicMass = "186.207",
                        AtomicRadius = "159",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d5 6s2",
                        FirstIonisationEnergy = "760",
                        X_Position = 7,
                        Y_Position = 6,
                        MeltingPoint = "3459",
                        BoilingPoint = "5869"
                    },

                    new Element
                    {
                        AtomicNumber = 76,
                        Name = "Osmium",
                        Symbol = "Os",
                        AtomicMass = "190.233",
                        AtomicRadius = "128",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d6 6s2",
                        FirstIonisationEnergy = "840",
                        X_Position = 8,
                        Y_Position = 6,
                        MeltingPoint = "3306",
                        BoilingPoint = "5285"
                    },

                    new Element
                    {
                        AtomicNumber = 77,
                        Name = "Iridium",
                        Symbol = "Ir",
                        AtomicMass = "192.217",
                        AtomicRadius = "137",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d7 6s2",
                        FirstIonisationEnergy = "880",
                        X_Position = 9,
                        Y_Position = 6,
                        MeltingPoint = "2739",
                        BoilingPoint = "4701"
                    },

                    new Element
                    {
                        AtomicNumber = 78,
                        Name = "Platinum",
                        Symbol = "Pt",
                        AtomicMass = "195.085",
                        AtomicRadius = "128",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d9 6s1",
                        FirstIonisationEnergy = "870",
                        X_Position = 10,
                        Y_Position = 6,
                        MeltingPoint = "2041",
                        BoilingPoint = "4098"
                    },

                    new Element
                    {
                        AtomicNumber = 79,
                        Name = "Gold",
                        Symbol = "Au",
                        AtomicMass = "196.967",
                        AtomicRadius = "144",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s1",
                        FirstIonisationEnergy = "890.0",
                        X_Position = 11,
                        Y_Position = 6,
                        MeltingPoint = "1337",
                        BoilingPoint = "3129"
                    },

                    new Element
                    {
                        AtomicNumber = 80,
                        Name = "Mercury",
                        Symbol = "Hg",
                        AtomicMass = "200.592",
                        AtomicRadius = "149",
                        GroupBlock = "transition metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s2",
                        FirstIonisationEnergy = "1007.0",
                        X_Position = 12,
                        Y_Position = 6,
                        MeltingPoint = "234",
                        BoilingPoint = "630"
                    },

                    new Element
                    {
                        AtomicNumber = 81,
                        Name = "Thallium",
                        Symbol = "Tl",
                        AtomicMass = "204.38",
                        AtomicRadius = "148",
                        GroupBlock = "metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s2 6p1",
                        FirstIonisationEnergy = "589.0",
                        X_Position = 13,
                        Y_Position = 6,
                        MeltingPoint = "577",
                        BoilingPoint = "1746"
                    },

                    new Element
                    {
                        AtomicNumber = 82,
                        Name = "Lead",
                        Symbol = "Pb",
                        AtomicMass = "207.21",
                        AtomicRadius = "147",
                        GroupBlock = "metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s2 6p2",
                        FirstIonisationEnergy = "716.0",
                        X_Position = 14,
                        Y_Position = 6,
                        MeltingPoint = "601",
                        BoilingPoint = "2022"
                    },

                    new Element
                    {
                        AtomicNumber = 83,
                        Name = "Bismuth",
                        Symbol = "Bi",
                        AtomicMass = "208.98",
                        AtomicRadius = "146",
                        GroupBlock = "metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s2 6p3",
                        FirstIonisationEnergy = "703",
                        X_Position = 15,
                        Y_Position = 6,
                        MeltingPoint = "544",
                        BoilingPoint = "1837"
                    },

                    new Element
                    {
                        AtomicNumber = 84,
                        Name = "Polonium",
                        Symbol = "Po",
                        AtomicMass = "209",
                        AtomicRadius = "",
                        GroupBlock = "metalloid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s2 6p4",
                        FirstIonisationEnergy = "812.0",
                        X_Position = 16,
                        Y_Position = 6,
                        MeltingPoint = "527",
                        BoilingPoint = "1235"
                    },

                    new Element
                    {
                        AtomicNumber = 85,
                        Name = "Astatine",
                        Symbol = "At",
                        AtomicMass = "210",
                        AtomicRadius = "",
                        GroupBlock = "halogen",
                        BondingType = "covalent network",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s2 6p5",
                        FirstIonisationEnergy = "899.0",
                        X_Position = 17,
                        Y_Position = 6,
                        MeltingPoint = "575",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 86,
                        Name = "Radon",
                        Symbol = "Rn",
                        AtomicMass = "222",
                        AtomicRadius = "145",
                        GroupBlock = "noble gas",
                        BondingType = "atomic",
                        ElectronConfiguration = "[Xe] 4f14 5d10 6s2 6p6",
                        FirstIonisationEnergy = "1037",
                        X_Position = 18,
                        Y_Position = 6,
                        MeltingPoint = "202",
                        BoilingPoint = "211"
                    },


                    new Element
                    {
                        AtomicNumber = 87,
                        Name = "Francium",
                        Symbol = "Fr",
                        AtomicMass = "223",
                        AtomicRadius = "242",
                        GroupBlock = "alkali metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 7s1",
                        FirstIonisationEnergy = "380",
                        X_Position = 1,
                        Y_Position = 7,
                        MeltingPoint = "27",
                        BoilingPoint = "676.8"
                    },

                    new Element
                    {
                        AtomicNumber = 88,
                        Name = "Radium",
                        Symbol = "Ra",
                        AtomicMass = "226",
                        AtomicRadius = "211",
                        GroupBlock = "alkaline earth metal",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 7s2",
                        FirstIonisationEnergy = "509.0",
                        X_Position = 2,
                        Y_Position = 7,
                        MeltingPoint = "973",
                        BoilingPoint = "2010"
                    },

                    new Element
                    {
                        AtomicNumber = 89,
                        Name = "Actinium",
                        Symbol = "Ac",
                        AtomicMass = "227",
                        AtomicRadius = "201",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 6d1 7s2",
                        FirstIonisationEnergy = "499",
                        X_Position = 3,
                        Y_Position = 10,
                        MeltingPoint = "1323",
                        BoilingPoint = "3473"
                    },

                    new Element
                    {
                        AtomicNumber = 90,
                        Name = "Thorium",
                        Symbol = "Th",
                        AtomicMass = "232.038",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 6d2 7s2",
                        FirstIonisationEnergy = "587",
                        X_Position = 4,
                        Y_Position = 10,
                        MeltingPoint = "2023",
                        BoilingPoint = "5093"
                    },

                    new Element
                    {
                        AtomicNumber = 91,
                        Name = "Protactinium",
                        Symbol = "Pa",
                        AtomicMass = "231.036",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f2 6d1 7s2",
                        FirstIonisationEnergy = "568",
                        X_Position = 5,
                        Y_Position = 10,
                        MeltingPoint = "1845",
                        BoilingPoint = "4273"
                    },

                    new Element
                    {
                        AtomicNumber = 92,
                        Name = "Uranium",
                        Symbol = "U",
                        AtomicMass = "238.029",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f3 6d1 7s2",
                        FirstIonisationEnergy = "598.0",
                        X_Position = 6,
                        Y_Position = 10,
                        MeltingPoint = "1408",
                        BoilingPoint = "4200"
                    },

                    new Element
                    {
                        AtomicNumber = 93,
                        Name = "Neptunium",
                        Symbol = "Np",
                        AtomicMass = "237",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f4 6d1 7s2",
                        FirstIonisationEnergy = "604.0",
                        X_Position = 7,
                        Y_Position = 10,
                        MeltingPoint = "917",
                        BoilingPoint = "4273"
                    },

                    new Element
                    {
                        AtomicNumber = 94,
                        Name = "Plutonium",
                        Symbol = "Pu",
                        AtomicMass = "244",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f6 7s2",
                        FirstIonisationEnergy = "585.0",
                        X_Position = 8,
                        Y_Position = 10,
                        MeltingPoint = "913",
                        BoilingPoint = "3503"
                    },

                    new Element
                    {
                        AtomicNumber = 95,
                        Name = "Americium",
                        Symbol = "Am",
                        AtomicMass = "243",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f7 7s2",
                        FirstIonisationEnergy = "578",
                        X_Position = 9,
                        Y_Position = 10,
                        MeltingPoint = "1449",
                        BoilingPoint = "2284"
                    },

                    new Element
                    {
                        AtomicNumber = 96,
                        Name = "Curium",
                        Symbol = "Cm",
                        AtomicMass = "247",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f7 6d1 7s2",
                        FirstIonisationEnergy = "581",
                        X_Position = 10,
                        Y_Position = 10,
                        MeltingPoint = "1618",
                        BoilingPoint = "3383"
                    },

                    new Element
                    {
                        AtomicNumber = 97,
                        Name = "Berkelium",
                        Symbol = "Bk",
                        AtomicMass = "247",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f9 7s2",
                        FirstIonisationEnergy = "601",
                        X_Position = 11,
                        Y_Position = 10,
                        MeltingPoint = "1323",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 98,
                        Name = "Californium",
                        Symbol = "Cf",
                        AtomicMass = "251",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "metallic",
                        ElectronConfiguration = "[Rn] 5f10 7s2",
                        FirstIonisationEnergy = "608",
                        X_Position = 12,
                        Y_Position = 10,
                        MeltingPoint = "1173",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 99,
                        Name = "Einsteinium",
                        Symbol = "Es",
                        AtomicMass = "252",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f11 7s2",
                        FirstIonisationEnergy = "619",
                        X_Position = 13,
                        Y_Position = 10,
                        MeltingPoint = "1133",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 100,
                        Name = "Fermium",
                        Symbol = "Fm",
                        AtomicMass = "257",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f12 7s2",
                        FirstIonisationEnergy = "627",
                        X_Position = 14,
                        Y_Position = 10,
                        MeltingPoint = "1800",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 101,
                        Name = "Mendelevium",
                        Symbol = "Md",
                        AtomicMass = "258",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f13 7s2",
                        FirstIonisationEnergy = "635",
                        X_Position = 15,
                        Y_Position = 10,
                        MeltingPoint = "1100",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 102,
                        Name = "Nobelium",
                        Symbol = "No",
                        AtomicMass = "259",
                        AtomicRadius = "",
                        GroupBlock = "actinoid",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 7s2",
                        FirstIonisationEnergy = "642",
                        X_Position = 16,
                        Y_Position = 10,
                        MeltingPoint = "1100",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 103,
                        Name = "Lawrencium",
                        Symbol = "Lr",
                        AtomicMass = "266",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 7s2 7p1",
                        FirstIonisationEnergy = "470",
                        X_Position = 17,
                        Y_Position = 10,
                        MeltingPoint = "1900",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 104,
                        Name = "Rutherfordium",
                        Symbol = "Rf",
                        AtomicMass = "267",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d2 7s2",
                        FirstIonisationEnergy = "580",
                        X_Position = 4,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 105,
                        Name = "Dubnium",
                        Symbol = "Db",
                        AtomicMass = "268",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d3 7s2",
                        X_Position = 5,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 106,
                        Name = "Seaborgium",
                        Symbol = "Sg",
                        AtomicMass = "269",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d4 7s2",
                        X_Position = 6,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 107,
                        Name = "Bohrium",
                        Symbol = "Bh",
                        AtomicMass = "270",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d5 7s2",
                        X_Position = 7,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 108,
                        Name = "Hassium",
                        Symbol = "Hs",
                        AtomicMass = "269",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d6 7s2",
                        X_Position = 8,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 109,
                        Name = "Meitnerium",
                        Symbol = "Mt",
                        AtomicMass = "278",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d7 7s2",
                        X_Position = 9,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 110,
                        Name = "Darmstadtium",
                        Symbol = "Ds",
                        AtomicMass = "281",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d9 7s1",
                        X_Position = 10,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 111,
                        Name = "Roentgenium",
                        Symbol = "Rg",
                        AtomicMass = "282",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s1",
                        X_Position = 11,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 112,
                        Name = "Copernicium",
                        Symbol = "Cn",
                        AtomicMass = "285",
                        AtomicRadius = "",
                        GroupBlock = "transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s2",
                        X_Position = 12,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 113,
                        Name = "Nihonium",
                        Symbol = "Nh",
                        AtomicMass = "286",
                        AtomicRadius = "",
                        GroupBlock = "post-transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s2 7p1",
                        X_Position = 13,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 114,
                        Name = "Flerovium",
                        Symbol = "Fl",
                        AtomicMass = "289",
                        AtomicRadius = "",
                        GroupBlock = "post-transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s2 7p2",
                        X_Position = 14,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 115,
                        Name = "Moscovium",
                        Symbol = "Mc",
                        AtomicMass = "289",
                        AtomicRadius = "",
                        GroupBlock = "post-transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s2 7p3",
                        X_Position = 15,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 116,
                        Name = "Livermorium",
                        Symbol = "Lv",
                        AtomicMass = "293",
                        AtomicRadius = "",
                        GroupBlock = "post-transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s2 7p4",
                        X_Position = 16,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 117,
                        Name = "Tennessine",
                        Symbol = "Ts",
                        AtomicMass = "294",
                        AtomicRadius = "",
                        GroupBlock = "post-transition metal",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s2 7p5",
                        X_Position = 17,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    },

                    new Element
                    {
                        AtomicNumber = 118,
                        Name = "Oganesson",
                        Symbol = "Og",
                        AtomicMass = "294",
                        AtomicRadius = "",
                        GroupBlock = "noble gas",
                        BondingType = "",
                        ElectronConfiguration = "[Rn] 5f14 6d10 7s2 7p6",
                        X_Position = 18,
                        Y_Position = 7,
                        MeltingPoint = "",
                        BoilingPoint = ""
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
