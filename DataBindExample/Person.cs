using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindExample
{
    class Person
    {
        private string fname;
        private string lname;
        private int age;
        private string job;

        public string FName { get { return fname; } }
        public string LName { get { return lname; } }
        public int Age { get { return age; } }
        public string Job { get { return job; } }
        public string FullName { get { return fname + " " + lname; } }

        public Person(string _fname, string _lname, int _age, string _job)
        {
            fname = _fname;
            lname = _lname;
            age = _age;
            job = _job;
        }
    }
}
