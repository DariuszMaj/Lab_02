using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02
{
    class Program
    {
        public static void Main()
        {
            //Teacher treacher = new Teacher("Maria Skłodowska", 50);

            //Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            //Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            //Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            //student1.AddTask("Taks A", TaskStatus.Waiting);
            //student1.AddTask("Taks B", TaskStatus.Waiting);
            //student1.AddTask("Taks C", TaskStatus.Rejected);

            //student2.AddTask("Taks A", TaskStatus.Waiting);
            //student2.AddTask("Taks B", TaskStatus.Waiting);
            //student2.AddTask("Taks C", TaskStatus.Rejected);

            //student3.AddTask("Taks D", TaskStatus.Done);
            //student3.AddTask("Taks E", TaskStatus.Waiting);
            //student3.AddTask("Taks F", TaskStatus.Waiting);

            //student3.UpdateTask(1, TaskStatus.Done);
            //student3.UpdateTask(2, TaskStatus.Progress);

            //Person[] persons = { treacher, student1, student2, student3 };
            //Classroom classroom = new Classroom("Sala Komputerowa", persons);

            //Console.WriteLine(classroom);

            //Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            //Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        }
    }
   public class Person 
    {
        protected string name;
        protected int age;
        public string Name
        {
            get { return Name; }
            set { Name= name; }
        }
        public int Age
        {
            get { return Age; }
            set { Age =age; }
        }

        public Person(string name ,int age)
        {

            Name = name;
            Age = age;
        
        }

        public override string ToString()
        {
            return name+age;
        }

    }

   class Student:Person
    {

        protected string group;
        protected List<Task> tasks = new List<Task>();
       
        public string Group
        {
            get { return Group; }
            set { Group = group; }
        }
        public class Task
        {
            private string name;
            private Task status;

            public string Name
            {
                get { return Name; }
                set {
                    Name = name; 
                    //if exist
                
                }
            }
            public Task Status
            {
                get { return Status; }
                set { Status = status; }
            }

            Task(string name, Task status)
            {
                Name = name;
                Status = status;

            }

            public override string ToString()
            {
                return name + status;
            }


        }

        //GRUPA
        public Student(string name,int  age,string group): base(name,age)
        
        {
            Group = group;
        
        }



        //TASKI
        public Student(string name, int age, string group, List <Task> tasks) : base(name, age)

        {
           

        }

        public void AddTask()
        {
            
        }
        public void RemoveTask()
        {

        }
        public void UpdateTask()
        {

        }
        public void RenderTasks()
        {

        }


        public override string ToString()
        {
            return group;
        }


    }



    public class Teacher:Person
    {
        Teacher(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return name ;
        }


    }





    public class Classroom
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { Name = name; }
        }

        public Classroom(string name,Person [] persons)
        {
            Name = name;
        }


        public override string ToString()
        {
            return name ;
        }
    }



}
