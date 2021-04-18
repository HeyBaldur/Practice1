using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1.Models
{
    public class Person
    {
        /// <summary>
        /// Person id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Person name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Score
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }
    }
}
