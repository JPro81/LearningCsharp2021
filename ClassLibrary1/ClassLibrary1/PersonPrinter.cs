using System;

namespace ClassLibrary1
{
    public class PersonPrinter
    {
        public PersonPrinter(Person person)
        {
            Person = person ?? throw new ArgumentNullException(nameof(person));
        }

        public Person Person { get; }

        public void PrintPerson() 
        {
            Console.WriteLine(Person.ToString());
        }

    }

}
