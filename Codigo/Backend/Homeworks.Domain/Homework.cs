using System;
using System.Collections.Generic;

namespace Homeworks.Domain
{
    public class Homework
    {       
        public Guid Id {get; set;}
        public DateTime DueDate {get; set;}
        public string Description {get; set;}
        public List<Exercise> Exercises {get; set;}

        public Homework()
        {
            Exercises = new List<Exercise>();
        }

        public bool IsValid()
        {
            return true;
        }

        public Homework Update(Homework entity)
        {
            if (entity.Description != null)
                Description = entity.Description;
            return this;
        }
    }
}