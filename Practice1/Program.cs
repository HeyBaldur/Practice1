using Practice1.Models;
using System;
using System.Collections.Generic;

namespace Practice1
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person
                {
                    Id = i,
                    Email = "test@test.com",
                    Name = "Mauriel" + i,
                    LastName = "Lee",
                    Score = i
                });
            }

            var peopleToReturn = GetPeople(people);
            foreach (var item in peopleToReturn)
            {
                Console.WriteLine($"The score is {item.Score} and the name is {item.Name}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Return all peple with more than 5 of score
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public static List<PersonDto> GetPeople(List<Person> people)
        {
            List<PersonDto> peopleCollection = new List<PersonDto>();
            foreach (var guy in people)
            {
                if (guy.Score > 5)
                {
                    peopleCollection.Add(new PersonDto { Score = guy.Score, Name = guy.Name });
                }
            };

            return peopleCollection;
        }
    }
}
