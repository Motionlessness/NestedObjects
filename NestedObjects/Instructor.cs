using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{  
    /// <summary>
    /// Represents an individual Instructor
    /// </summary>
    class Instructor
    {
        /// <summary>
        /// The legal full name
        /// Example: Jake Lohng
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// The company email address
        /// Example: JaneDoe@cptc.edu
        /// </summary>
        public string Email { get; set; }
    }
}
