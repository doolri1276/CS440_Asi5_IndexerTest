using OOPconcepts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IndexerTest
{
    class University
    {
        public Student[] STA = null; 

        public Student this[int idToSearch]
        {
            get
            {
                Student stFound = null;
                foreach (Student st in STA)
                {
                    if (st.Id == idToSearch)
                    {
                        stFound = st;
                        break;
                    }
                }
                return stFound;
            }
            set
            {
                Student stFound = null;
                foreach (Student st in STA)
                {
                    if (st.Id == idToSearch)
                    {
                        stFound = st;
                        break;
                    }
                }
                stFound = value;
            }
        }

        public Student[] this[string name, NameType nmType]
        {
            get
            {
                ArrayList MatchList = new ArrayList();
                foreach (Student st in STA)
                {
                    if (nmType == NameType.FIRSTNAME)
                    {
                        if (st.FirstName.ToUpper() == name.ToUpper())
                        {
                            MatchList.Add(st);
                        }
                    }
                    else if(nmType == NameType.LASTNAME)
                    {
                        if (st.LastName.ToUpper() == name.ToUpper())
                        {
                            MatchList.Add(st);
                        }
                    }
                }
                return (Student[])MatchList.ToArray(typeof(Student));
            }
           
        }

        

        public University()
        {
            //read students from DB
            STA = new Student[3];
            STA[0] = new Student
            {
                FirstName = "Bill",
                LastName = "Baker",
                Id = 12341,
                Test1 = 85,
                Test2 = 91
            };
            STA[1] = new Student
            {
                FirstName = "Sally",
                LastName = "Simpson",
                Id = 12344,
                Test1 = 88,
                Test2 = 95
            };
            STA[2] = new Student
            {
                FirstName = "Mark",
                LastName = "Mathews",
                Id = 12347,
                Test1 = 81,
                Test2 = 83
            };

        }
    }
}
