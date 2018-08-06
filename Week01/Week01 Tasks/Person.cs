using System;
using System.Collections.Generic;
using System.Text;

namespace Week01_Tasks
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public double Height { get; private set; }
        public int Id { get; private set; }
        public List<Subject> Subjects { get; private set; }

        public Person(string firstName, string surname, DateTime dateOfBirth, double height, int id)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.Height = height;
            this.Id = id;

            this.Subjects = new List<Subject>();
        }

        public string FullName()
        {
            return $"{FirstName} {Surname}";
        }

        public string HeightDifference(Person otherPerson)
        {
            double difference = Math.Round((this.Height - otherPerson.Height), 1);

            if (difference > 0)
            {
                return $"I'm taller than {otherPerson.FullName()} by {Math.Abs(difference)}cm";
            }
            else if (difference < 0)
            {
                return $"I'm shorter than {otherPerson.FullName()} by {Math.Abs(difference)}cm";
            }
            else
            {
                return $"I'm the same height as {otherPerson.FullName()}";
            }
        }

        public void AddSubject(string name, int yearOfDelivery)
        {
            Subject subject = new Subject(name, yearOfDelivery);
            this.Subjects.Add(subject);
        }
        
        public void AddSubject(string name, int yearOfDelivery, int grade)
        {
            Subject subject = new Subject(name, yearOfDelivery, grade);
            this.Subjects.Add(subject);
        }

        public string FormattedSubjectList()
        {
            if (Subjects.Count == 0)
            {
                return "List of subjects is empty!";
            }

            StringBuilder printableList = new StringBuilder();

            string listTitle = $"** List of subjects for {this.FullName()} **";
            printableList.AppendLine(listTitle);

            foreach (Subject s in Subjects)
            {
                printableList.AppendLine($"{s.Name} in {s.YearOfDelivery}");
                if (s.Grade >= 0)
                {
                    printableList.AppendLine($"-graded {s.Grade}");
                }
                else
                {
                    printableList.AppendLine($"-is ungraded");
                }
            }

            printableList.AppendLine(HorizontalRule(listTitle.Length));

            return printableList.ToString();
        }

        private string HorizontalRule(int length)
        {
            StringBuilder rule = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                rule.Append("-");
            }

            return rule.ToString();
        }
    }
}