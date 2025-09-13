using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C__SystemOfADown
{
   
    class StudentCard
    {
        public string? Series { get; set; }

        public int Number { get; set; }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }

        public int CompareTo(object? obj)
        {
            StudentCard? sc = obj as StudentCard;
            int res = Series!.CompareTo(sc!.Series);
            if (res == 0)
                res = Number.CompareTo(sc!.Number);
            return res;
        }
    }


    class Student : IComparable
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard? StudentCard { get; set; }

        public int CompareTo(object? obj)
        {
            Student? st = obj as Student;
            return (LastName + FirstName).CompareTo(st!.LastName + st!.FirstName);
        }

        public override string ToString()
        {
            return $"{LastName,-10} {FirstName,-8} {BirthDay.ToShortDateString()} {StudentCard}";
        }
    }

    class Group : IEnumerable
    {
        Student[] students;
        
        public Group()
        {
            students = new Student[4]
            {
                new Student { LastName="Sidorov", FirstName="Ivan",   BirthDay=new DateTime(2000,10,5), StudentCard=new StudentCard { Series="AC", Number=123456 } },
                new Student { LastName="Ivanova", FirstName="Maria",  BirthDay=new DateTime(2000,10,3), StudentCard=new StudentCard { Series="AB", Number=123455 } },
                new Student { LastName="Ivanov",  FirstName="Sidr",   BirthDay=new DateTime(2002,3,3),  StudentCard=new StudentCard { Series="AA", Number=123456 } },
                new Student { LastName="Smirnov", FirstName="Sergey", BirthDay=new DateTime(1999,4,4),  StudentCard=new StudentCard { Series="AB", Number=124356 } }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }




        public void Sort()
        {
            Array.Sort(students);
        }


        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }



    class DateComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Student? st1 = x as Student;
            Student? st2 = y as Student;
            return DateTime.Compare(st1!.BirthDay, st2!.BirthDay);
        }
    }

    class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Student? st1 = x as Student;
            Student? st2 = y as Student;
            return st1!.StudentCard!.CompareTo(st2!.StudentCard);
        }
    }
}
