﻿using Game.GameEngine;

namespace Game.Models
{
    public class BaseCharacter : BasePlayer<BaseCharacter>
    {
        // Just base from here down. 
        // This is what will be saved to the Database

        // So when working with the database, pass Character

        public BaseCharacter()
        {

        }

        // Makes BaseCharacter using character for constructor
        public BaseCharacter(Character newData)
        {
            // Base information
            Name = newData.Name;
            Description = newData.Description;
            Level = newData.Level;
            ExperienceTotal = newData.ExperienceTotal;
            ImageURI = newData.ImageURI;
            Alive = newData.Alive;

            // Database information
            Guid = newData.Guid;
            Id = newData.Id;

            // Populate the Attributes
            AttributeString = newData.AttributeString;

            // Set the strings for the items
            Head = newData.Head;
            Feet = newData.Feet;
            Necklass = newData.Necklass;
            RightFinger = newData.RightFinger;
            LeftFinger = newData.LeftFinger;
            Feet = newData.Feet;
        }

        // Update character from the passed in data
        public void Update(BaseCharacter newData)
        {
            if (newData == null)
            {
                return;
            }

            // Update all the fields in the Data, except for the Id

            // Base information
            Name = newData.Name;
            Description = newData.Description;
            Level = newData.Level;
            ExperienceTotal = newData.ExperienceTotal;
            ImageURI = newData.ImageURI;
            Alive = newData.Alive;

            // Database information
            Guid = newData.Guid;
            Id = newData.Id;

            // Populate the Attributes
            AttributeString = newData.AttributeString;

            // Set the strings for the items
            Head = newData.Head;
            Feet = newData.Feet;
            Necklass = newData.Necklass;
            RightFinger = newData.RightFinger;
            LeftFinger = newData.LeftFinger;
            Feet = newData.Feet;
        }

    }
}