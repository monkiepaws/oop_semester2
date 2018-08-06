using System;

namespace Week01_Tasks
{
    public class Subject
    {
        public string Name { get; private set; }
        public int YearOfDelivery { get; private set; }
        public int Grade { get; private set; }
        
        public Subject(string name, int yearOfDelivery, int optionalGrade = -1)
        {
            this.Name = name;
            this.YearOfDelivery = yearOfDelivery;
            this.Grade = optionalGrade;
        }

        public bool AddGrade(int grade)
        {
            if (grade < 0 || grade > 100)
            {
                this.Grade = grade;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}