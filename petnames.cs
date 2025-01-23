using cmd;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.XPath;


namespace Act01
{
    internal class Program
    {
        static void Main(string[] args, string petnames)
        {

            Data data = new Data();
            List<Petname> petnamess = data.Getpetnamess();

            foreach (var namepets in petnames)
            {
                Console.WriteLine();
                Console.WriteLine($"name: {namepets.pnames}");
            }

            //Filter
            List<Petname> filteredPetnames = petnames.Where(x => x.pGender == "Male" || x.pGender == "Female").ToList();

            //Count
            Console.WriteLine($"The number of petnames is {filteredPetnames.Count}");
            foreach (var petname in filteredPetnames)
            {
                Console.WriteLine($"NAME: {petname.pOwner} {petname.pnames} - {petname.pGender}");
            }

            //Order By
            List<Petname> OrderedPetnames = petnames.OrderBy(x => x.pnames).ThenBy(x => x.pGender).ToList();
            Console.WriteLine("\nOrdered Petnames:");
            foreach (var petname in OrderedPetnames)
            {
                Console.WriteLine($"petnames: {petname.pnames} - {petname.pGender}");
            }

            //Group
            var groupedPetnames = petnames.GroupBy(x => x.pOwner);
            Console.WriteLine("\nGrouped Petnames by Owner:");
            foreach (var group in groupedPetnames)
            {
                Console.WriteLine($"Owner: {group.Key}");
                foreach (var petname in group)
                {
                    Console.WriteLine($"  petnames: {petname.pnames} - {petname.pGender}");
                }







                // pOwner = "Mari",
                //    pnames = "Shiro",
                //    pGender = "Male",

                //};

                //List<petnames> list = new List<petnames>();

                //list.Add(petnames1);

                //foreach (var plist in list)
                //{
                //    Console.WriteLine(plist);


                //}
            }
            }
        }
    }