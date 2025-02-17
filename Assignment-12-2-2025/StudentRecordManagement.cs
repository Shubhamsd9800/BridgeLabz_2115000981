using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagement
{
    public class Student
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public string Grade;
        public Student Next;

        public Student(int rollNumber, string name, int age, string grade)
        {
            this.RollNumber = rollNumber;
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
            Next = null;
        }
    }
    class StudentList
    {
        private Student head;
        public void AddStudentAtBeginning(int rollNumber, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            newStudent.Next = head;
            head = newStudent;
        }

        public void AddStudentAtEnd(int rollNumber, string name, int age,string grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            if (head == null)
            {
                head = newStudent;
                return;
            }
            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;
        }

        public void AddStudentAtPosition(int rollNumber, string name, int age, string grade, int position)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            if (position == 1)
            {
                AddStudentAtBeginning(rollNumber, name, age, grade);
                return;
            }
            Student temp = head;
            for (int i = 1; temp != null && i < position - 1; i++)
                temp = temp.Next;
            if (temp == null)
            {
                Console.WriteLine("Position out of range");
                return;
            }
            newStudent.Next = temp.Next;
            temp.Next = newStudent;
        }

        public void DeleteStudent(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.RollNumber == rollNumber)
            {
                head = head.Next;
                return;
            }

            Student temp = head;
            while (temp.Next != null && temp.Next.RollNumber != rollNumber)
                temp = temp.Next;

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            temp.Next = temp.Next.Next;
        }
        public void SearchStudent(int rollNumber)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    Console.WriteLine($"Roll Number: {temp.RollNumber}, Name: { temp.Name}, Age: { temp.Age}, Grade: { temp.Grade}  ");
                    return;
                }
                temp = temp.Next;

            }
            Console.WriteLine("Student Not Found");
        }

        public void UpdateGrade(int rollNumber, string newGrade)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found");
        }
        public void DisplayAllStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No student records found.");
                return;
            }
            Student temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll Number: {temp.RollNumber}, Name:{ temp.Name}, Age: { temp.Age}, Grade: { temp.Grade}   ");
            temp = temp.Next;
            }

        }
    }
}
