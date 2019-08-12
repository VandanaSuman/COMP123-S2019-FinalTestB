﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION: This is the character class used in character creation as well as the data container for the application
 * */

namespace COMP123_S2019_FinalTestB.Objects
{
    class Character
    {
        //Character Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        //Secondary Abilities
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }

        //Character Class
        public int CharacterClass { get; set; }
        public int Level { get; set; }

        //Equipment
        List<Item> Inventory;

        //Constructor 
        Character()
        {
            this.Inventory = new List<Item>();  
        }
    }
}
