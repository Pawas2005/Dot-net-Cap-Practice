using System;
using LPU_Common;
using LPU_Entity;
using LPU_Exceptions;

namespace LPU_DAL
{
    /// <summary>
    /// Student DAO class is used for CRUD Operations
    /// </summary>
    public class StudentDAO : IStudentCRUD
    {
        static List<Student> studentList = null;
        public StudentDAO()
        {
            //Collection Init
            studentList = new List<Student>()
            {
                new Student() { StudentID = 101, Name = "Pawas", Course = CourseType.CSE, Address = "Chandigarh" },
                new Student() { StudentID = 102, Name = "Alok", Course = CourseType.CSE, Address = "Jalandhar" },
                new Student() { StudentID = 103, Name = "Alia", Course = CourseType.CSE, Address = "Amritsar" },
                new Student() { StudentID = 104, Name = "Rajat", Course = CourseType.CSE, Address = "Phagwara" },
                new Student() { StudentID = 105, Name = "Aman", Course = CourseType.CSE, Address = "Patiala" },
            };
        }
        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if(sObj != null)
            {
                studentList.Add(sObj);
                flag = true;
            }
            return flag;
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if(rollNo != 0)
            {
                myStud = studentList.Find(s => s.StudentID == rollNo);
                if(myStud == null)
                {
                    throw new LPUException("Student Record Not Found.");
                }
            }
            else
            {
                throw new LPUException("Error Generated");
            }
            return myStud;
        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = studentList.FindAll(p => p.Name == name);
            return data;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}
