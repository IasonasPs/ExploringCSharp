using System;

namespace Exploring._101_Miscellaneous
{
    public class SelectMany
    {
        //https://stackoverflow.com/questions/958949/difference-between-select-and-selectmany
        public static void ManyMain()
        {
            testingSelectMany();
        }

        public static void testingSelectMany()
        {
            //Every person has an IEnumerable of PhoneNumber 
            IEnumerable<Person> people = new List<Person>
            {
                new Person()
                {
                    Name = "makis",
                    PhoneNumbers = new List<PhoneNumber>()
                    {
                        new PhoneNumber(){ Number = "1"},
                        new PhoneNumber(){ Number = "2"},
                        new PhoneNumber(){ Number = "3"},
                        new PhoneNumber(){ Number = "4"},
                        new PhoneNumber(){ Number = "5"},
                    }
                },
                new Person()
                {
                    Name = "nikos",
                    PhoneNumbers = new List<PhoneNumber>()
                    {
                        new PhoneNumber(){ Number = "6"},
                        new PhoneNumber(){ Number = "7"},
                        new PhoneNumber(){ Number = "8"},
                        new PhoneNumber(){ Number = "9"},
                        new PhoneNumber(){ Number = "10"},
                    }
                },
                new Person()
                {
                    Name = "maria",
                    PhoneNumbers = new List<PhoneNumber>()
                    {
                        new PhoneNumber(){ Number = "11"},
                        new PhoneNumber(){ Number = "12"},
                        new PhoneNumber(){ Number = "13"},
                    }
                },
            };

            //phoneLists is an IEnumerable of IEnumerables of PhoneNumbers
            //(a list of lists of phoneNumbers)
            var phoneLists = people.Select( person => person.PhoneNumbers);
            //but in the end we just need a list of phone numbers and not a list of lists...
            //to achieve this using only "Select", we have to make use of "Enumerable.Aggregate" method
            var phoneNumbers  =
                people.
                Select(person => person.PhoneNumbers.Select(number => number))
                .Aggregate(
                    new List<PhoneNumber>(),
                    (numbersList,numbers) => 
                    {
                        numbersList.AddRange(numbers); 
                        return numbersList;
                    });

            //SelectMany : this way we get exactly what we may need
            var phoneNumbersList = people.SelectMany( person => person.PhoneNumbers);

            #region SelectMany : CrossProduct (εξωτερικό γινόμενο)

            //SelectMany can actually be used to return the Cross Product :
            List<string> coordinates = new List<string> {"x","y","z"};
            List<string> polar = new List<string>{ "r","φ","z"};
            List<int> angles = new List<int>(){ 90,180,360};

            var crossProduct = coordinates.SelectMany(coordinate => angles,(f,s) => new { f , s }).ToList();

            foreach (var item in crossProduct)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }

    public class PhoneNumber
    {
        public string? Number { get; set; }
    }
    public class Person
    {
        public IEnumerable<PhoneNumber> PhoneNumbers { get; set; }
        public string Name { get; set; }
    }
}
