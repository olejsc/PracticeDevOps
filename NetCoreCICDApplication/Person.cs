using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCICDApplication
{
    class Person
    {
        public string name;
        private int age;

        public int Age
        {
            get { return age; }
            set {
                if(value >100 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age", value, "Age cannot be more than 100 or less than 0");
                }
                else
                {
                    age = value;
                }
            }

        }

    }
}
