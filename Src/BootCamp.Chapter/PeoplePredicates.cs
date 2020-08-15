using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class PeoplePredicates
    {
        /// <summary>
        /// a) over 18, who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <returns></returns>
        
        static Predicate<Person> isA = (person) => person.age>18 && person.address.ToUpper() != "UK" && !person.surname.Contains('a');
        public static bool IsA(Person person) => isA(person);
        

        /// <summary>
        /// b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        static Predicate<Person> isB = (person) => person.age<18 && person.address.ToUpper() != "UK" && !person.surname.Contains('a');
        public static bool IsB(Person person) => isB(person);

        /// <summary>
        /// c) who do not live in UK, whose surename and name does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>

        static Predicate<Person> isC = (person) =>  person.address.ToUpper() != "UK" && !person.surname.Contains('a') && !person.name.Contains('a');
        public static bool IsC(Person person) => isC(person);
    }


    
}
