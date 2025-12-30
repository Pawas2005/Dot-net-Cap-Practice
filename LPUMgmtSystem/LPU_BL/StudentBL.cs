using System;
using System.Collections.Generic;
using LPU_Common;
using LPU_DAL;
using LPU_Entity;
using LPU_Exceptions;

namespace LPU_BL
{
    public class StudentBL : IStudentCRUD
    {
        StudentDAO sDao = null;
        public StudentBL()
        {
            sDao = new StudentDAO();
        }
        public bool DropStudentDetails(int id)
        {
            bool result = false;
            try
            {
                result = sDao.DropStudentDetails(id);
            }
            catch (LPUException e)
            {
                throw e;
            }
            return result;
        }

        public bool EnrollStudent(Student sObj)
        {
            bool result = false;
            try
            {
                result = sDao.EnrollStudent(sObj);
            }
            catch (LPUException e)
            {
                throw e;
            }
            return result;
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student s1 = null;
            try
            {
                s1 = sDao.SearchStudentByID(rollNo);
            }
            catch (LPUException e)
            {
                throw e;
            }
            return s1;
        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> studentList = null;
            try
            {
                studentList = sDao.SearchStudentByName(name);
            }
            catch (LPUException e)
            {
                throw e;
            }
            return studentList;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            bool result = false;
            try
            {
                result = sDao.UpdateStudentDetails(id, newObj);
            }
            catch (LPUException e)
            {
                throw e;
            }
            return result;
        }
    }
}
