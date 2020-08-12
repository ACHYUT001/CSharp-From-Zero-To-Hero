using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirtyfilepath = @"C:\Users\acupadhy\source\repos\ACHYUT001\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.corrupted";
            string cleanedfilepath = @"C:\Users\acupadhy\source\repos\ACHYUT001\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.cleaned.txt";
            FileCleaner.Clean(dirtyfilepath , cleanedfilepath);
            
            var balancedict = convertToDict(PeoplesBalances.Balances);
            
            //Create a list of Person instances
            List<Person> people = new List<Person>();
            
            foreach( KeyValuePair<string, List<float>> kvp in balancedict)
            {
                Person person = new Person(kvp.Key, kvp.Value);
                people.Add(person);
            }
            
            var highestBalanceEver = findHighestBalanceEver(people);
            var personwithbiggestLoss = findPersonWithBIggestLoss(people);
            var RichestPerson = findRichestPerson(people);
            var mostpoorperson = findMostPoorPerson(people);


        
        
        }

        public static (string name, float value) findHighestBalanceEver(List<Person> people)
        {
            (string name , float value) person = people.Max(p => (p.getName() , p.getHistoricalBalanceCount()));
            return person;
        }

        public static (string name, float vlaue) findRichestPerson(List<Person> people)
        {
            var person = people.Max(p => (p.getName(), p.getCurrentBalance()));
            return person;
        }

        public static (string name, float vlaue) findPersonWithBIggestLoss(List<Person> people)
        {
            var person = people.Max(p => (p.getName(), p.getBiggestLoss()));
            return person;
        }

        public static (string name, float vlaue) findMostPoorPerson(List<Person> people)
        {
            var person = people.Min(p => (p.getName(), p.getCurrentBalance()));
            return person;
        }
        // public static (string name, float value) findHighestBalanceEver(Dictionary<string,List<float>> balancedict)
        // {
        //     string name = null;
        //     float value = 0f;

        //     foreach( KeyValuePair<string, List<float>> kvp in balancedict )
        //     {
        //         if(kvp.Value.Count > value)
        //         {
        //             value = kvp.Value.Count;
        //             name = kvp.Key;
        //         }
        //     }

        //     return (name,value);
        // }


        // public static (string name, float value) findPersonWithBIggestLoss(Dictionary<string,List<float>> balancedict)
        // {
        //     string name = null;
        //     float value = 0f;

            

           
        //     foreach( KeyValuePair<string, List<float>> kvp in balancedict )
        //     {
        //         float diff= kvp.Value.First() - kvp.Value.Last();
        //         if(diff > value)
        //         {
        //             value = diff;
        //             name = kvp.Key;
        //         }
        //     }

        //     return (name,value);
        // }

        // public static (string name, float value) findRichestPerson(Dictionary<string,List<float>> balancedict)
        // {
        //     string name = null;
        //     float value = 0;
        //     int counter = 0;

        //     foreach( KeyValuePair<string, List<float>> kvp in balancedict )
        //     {
        //         float sum = 0f;
                
        //         kvp.Value.ForEach( val => sum += val);
                
        //         if(counter++ == 0) value = sum;

        //         if(sum > value)
        //         {
        //             value = sum;
        //             name = kvp.Key;
                    
        //         }
        //     }

        //     return (name,value);
        // }

        // public static (string name, float value) findMostPoorPerson(Dictionary<string,List<float>> balancedict)
        // {
        //     string name = null;
        //     float value = 0;
        //     int counter = 0;

        //     foreach( KeyValuePair<string, List<float>> kvp in balancedict )
        //     {
                
                
        //         float currentbalance = kvp.Value.Last();
                
        //         if(counter++ == 0) value = currentbalance;

        //         if(currentbalance < value)
        //         {
        //             value = currentbalance;
        //             name = kvp.Key;
                    
        //         }
        //     }

        //     return (name,value);
        
        // }

        public static Dictionary<String , List<float>> convertToDict(List<string> balances)
        {
            var peoplebalancesdict = new Dictionary<String , List<float>>();
             foreach (var line in balances)
                {
                    string[] line_array = line.Split(",");
                    List<float> float_balance = new List<float>();
                    for(int i = 1; i< line_array.Length; i++)
                        {
                            
                            float_balance.Add(float.Parse(line_array[i].Replace("£","")));
                        }
                    peoplebalancesdict.Add(line_array[0],float_balance);

                }

                return peoplebalancesdict;
        }
    }
}
