using System;

namespace Events
{
    class Events
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ivan";
            Student student2 = new Student();
            student2.Name = "Ani";
            Student student3 = new Student();
            student3.Name = "Didi";
            Teacher teacher = new Teacher();
            teacher.Name = "Ivanov";

            student1.Enroll(teacher);
            student2.Enroll(teacher);
            student3.Enroll(teacher);
            teacher.StartCourse();
        }
    }
    class Student
    {
        public string Name { get; set; }

        public void Enroll(Teacher teacher)
        {
            teacher.OnStartCourse += EnterInClassroom;
        }
        private void EnterInClassroom()
        {
            Console.WriteLine($"{Name} enter in classroom!");
        }
    }
    class Teacher
    {
        public string Name { get; set; }
        public delegate void SubscribeToClass();
        public event SubscribeToClass OnStartCourse;

        public void StartCourse()
        {
            OnStartCourse();
        }
    }
}
