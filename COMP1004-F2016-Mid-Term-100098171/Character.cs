using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// <summary>
/// DND character generator
/// Tom T. & Ben Dunn
/// Created 2016, oct 20
/// 
/// Creates a simple character object for moving data through the program.
/// </summary>
/// </summary>


namespace COMP1004_F2016_Mid_Term_100098171
{
    public class Character
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }
    }
}