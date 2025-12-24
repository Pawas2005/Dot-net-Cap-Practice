using System;
using System.Collections.Generic;

namespace Day4OOPDemo
{
    class Emp
    {
        public int id;
        public string name, job;
        public double sal;
        public bool status;
    }
    class UserDefinedTypes
    {
        public Emp GetEmpDetails(int id)
        {
            Emp emp = new Emp();
            emp.id = id;
            emp.name = "Raju";
            emp.job = "Manager";
            emp.sal = 50000.00;
            emp.status = true;

            return emp;
        }
    }
}