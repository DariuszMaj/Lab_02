using System;
using System.Collections.Generic;
using System.Linq;
using static Lab_02.Student;
using static Lab_02.Student.Task;

namespace Lab_02
{
    class Program
    {
        public static void Main()
        {
            Teacher teacher = new Teacher("Maria Skłodowska", 50);       
            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");        
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");      
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");
            
            student1.AddTask("Taks A",TaskStatus.Waiting);
            student1.AddTask("Taks B", TaskStatus.Waiting);
            student1.AddTask("Taks C", TaskStatus.Rejected);
            student2.AddTask("Taks A", TaskStatus.Waiting);
            student2.AddTask("Taks B", TaskStatus.Waiting);
            student2.AddTask("Taks C", TaskStatus.Rejected);
            student3.AddTask("Taks D", TaskStatus.Done);
            student3.AddTask("Taks E", TaskStatus.Waiting);
            student3.AddTask("Taks F", TaskStatus.Waiting);

            student3.UpdateTask(1, TaskStatus.Done);
            student3.UpdateTask(2, TaskStatus.Progress);

            Person[] persons = { teacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);

            Console.WriteLine(classroom);
           

            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        }
    }
    public class Person
    {
        protected string name;
        protected int age;
        public string Name
        {
            get => name;
            set { name = value; }
        }
        public int Age
        {
            get => age;
            set { age = value; }
        }

        public Person(string name, int age)
        {

            Name = name;
            Age = age;

        }
        public virtual bool Equals(Person obj)

        {
            if (this.name == obj.name && this.age == obj.age)
            {
                return true;
            }
            else { return false; }

        }


        public override string ToString()
        {
            return name + "(" + age + " y.o.)";
        }

    }

    public class Student : Person
    {
        protected string group;
        protected List<Task> tasks = new List<Task>();
        public string Group { get => group; set { group = value; } }

        public class Task
        {
            private string name;
            private TaskStatus status;
            public  enum TaskStatus
            {
                Waiting, Rejected, Progress, Done
            }
            public string Name { get => name; set { name = value; } }
            public TaskStatus Status { get => status; set { status = value; } }


            public Task(string name,TaskStatus status)
            {
                Name = name;
                Status = status;
            }

            public override string ToString()
            {
                return name + " [" + status+"]";          
            }
            public virtual bool Equals(Task obj)

            {
                if (this.name == obj.name && this.Status == obj.Status)
                {
                    return true;
                }
                return false;

            }

        }
        //GRUPA
        public Student(string name, int age, string group) : base(name, age)

        {
            Group = group;
            Name = name;
            Age = age;

        }

        //TASKI
        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)

        {
            Group = group;
            Name = name;
            Age = age;
            //taska dodac

        }

       public void AddTask(string taskName,TaskStatus taskStatus)
        {
            Task task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }
       public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }
       public void UpdateTask(int index,TaskStatus taskStatus)
        {   
            Task taskn = tasks.ElementAt(index);
            if (taskn!=null) { taskn.Status = taskStatus; }   
        }
       //public void RenderTasks(){}
       
        public override string ToString()
        {
            
            var result =($"{Environment.NewLine}{Environment.NewLine}Student: {name} ({age} y.o){Environment.NewLine}Group: {group}{Environment.NewLine}Tasks:");
            int i = 1;
            
            foreach(Task a in tasks)
            {
              
                result +=Environment.NewLine+i+". "+a.ToString();
                i++;
            }

            return result;
        }

        public virtual bool Equals(Student obj)
        {
            if (this.name == obj.name && this.age == obj.age)
            {
                return true;
            }
            return false;

        }

        //sequenceEqual (a:List<T> b:List<T>):bool

    }
    public class Teacher : Person
    {
        public Teacher(string name, int aged) : base(name, aged) {
            Name = name;
            Age = age;
        }
        

        public override string ToString()
        {
            return Environment.NewLine+ Environment.NewLine + "Teacher: " +this.name+" ("+this.age+" y.o)";
         
        }


    }
    public class Classroom
    {
        private string name;
        private  Person[] persons;
        public string Name { get => name; set => name = value; }
        public Classroom(string name, Person[] persons)
        {
            Name = name;
            this.persons = persons;
        }


        public override string ToString()
        {
            var result = "";
            int i = 0;
            foreach(var a in persons)
            {
                result += persons[i];
                i++; 
            }
            return Environment.NewLine + "Classroom: " +name+result;
        }
    }



}
