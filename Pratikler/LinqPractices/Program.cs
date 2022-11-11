using System;
using LinqPractices.DbOperations;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Intialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();
            
            // using Linq Methods

            // Find()
            Console.WriteLine("***** Find ******");
            var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();  // without using Find()
            student = _context.Students.Find(1);
            
            Console.WriteLine($"Student Id: {student.StudentId}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student Surname: {student.Surname}");
            Console.WriteLine($"Student ClassId: {student.ClassId}");

            // FirstOrDefault()
            Console.WriteLine("***** FirstOrDefault ******");
            student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
            Console.WriteLine($"Student Id: {student.StudentId}");

            student = _context.Students.FirstOrDefault(x => x.StudentId == 1);
            Console.WriteLine($"Student Id: {student.StudentId}");

            // SingleOrDefault()
            Console.WriteLine("***** SingleOrDefault ******");
            student = _context.Students.Where(student => student.StudentId == 1).SingleOrDefault();
            Console.WriteLine($"Student Id: {student.StudentId}");

            student = _context.Students.SingleOrDefault(x => x.StudentId == 1);
            Console.WriteLine($"Student Id: {student.StudentId}");

            // toList()
            Console.WriteLine("***** toList ******");
            var studentList = _context.Students.Where(student => student.ClassId == 2).ToList();

            foreach (var item in studentList)
            {
                Console.WriteLine($"Student Id: {item.StudentId}");
                Console.WriteLine($"Student Name: {item.Name}");
                Console.WriteLine($"Student Surname: {item.Surname}");
                Console.WriteLine($"Student ClassId: {item.ClassId}");
            }

            // Count()
            Console.WriteLine("***** Count ******");
            var studentCount = _context.Students.Where(student => student.ClassId == 2).Count();
            Console.WriteLine($"Student Count: {studentCount}");

            // Max()
            Console.WriteLine("***** Max ******");
            var studentMax = _context.Students.Where(student => student.ClassId == 2).Max(x => x.StudentId);
            Console.WriteLine($"Student Max: {studentMax}");

            // Min()
            Console.WriteLine("***** Min ******");
            var studentMin = _context.Students.Where(student => student.ClassId == 2).Min(x => x.StudentId);
            Console.WriteLine($"Student Min: {studentMin}");

            // Sum()
            Console.WriteLine("***** Sum ******");
            var studentSum = _context.Students.Where(student => student.ClassId == 2).Sum(x => x.StudentId);
            Console.WriteLine($"Student Sum: {studentSum}");

            // Average()
            Console.WriteLine("***** Average ******");
            var studentAverage = _context.Students.Where(student => student.ClassId == 2).Average(x => x.StudentId);
            Console.WriteLine($"Student Average: {studentAverage}");

            // OrderBy()
            Console.WriteLine("***** OrderBy ******");
            var studentOrderBy = _context.Students.Where(student => student.ClassId == 2).OrderBy(x => x.StudentId).ToList();
            foreach (var item in studentOrderBy)
            {
                Console.WriteLine($"Student Id: {item.StudentId}");
                Console.WriteLine($"Student Name: {item.Name}");
                Console.WriteLine($"Student Surname: {item.Surname}");
                Console.WriteLine($"Student ClassId: {item.ClassId}");
            }

            // OrderByDescending()
            Console.WriteLine("***** OrderByDescending ******");
            var studentOrderByDescending = _context.Students.Where(student => student.ClassId == 2).OrderByDescending(x => x.StudentId).ToList();
            foreach (var item in studentOrderByDescending)
            {
                Console.WriteLine($"Student Id: {item.StudentId}");
                Console.WriteLine($"Student Name: {item.Name}");
                Console.WriteLine($"Student Surname: {item.Surname}");
                Console.WriteLine($"Student ClassId: {item.ClassId}");
            }

            // ThenBy()
            Console.WriteLine("***** ThenBy ******");
            var studentThenBy = _context.Students.Where(student => student.ClassId == 2).OrderBy(x => x.StudentId).ThenBy(x => x.Name).ToList();
            foreach (var item in studentThenBy)
            {
                Console.WriteLine($"Student Id: {item.StudentId}");
                Console.WriteLine($"Student Name: {item.Name}");
                Console.WriteLine($"Student Surname: {item.Surname}");
                Console.WriteLine($"Student ClassId: {item.ClassId}");
            }

            // ThenByDescending()
            Console.WriteLine("***** ThenByDescending ******");
            var studentThenByDescending = _context.Students.Where(student => student.ClassId == 2).OrderBy(x => x.StudentId).ThenByDescending(x => x.Name).ToList();
            
            foreach (var item in studentThenByDescending)
            {
                Console.WriteLine($"Student Id: {item.StudentId}");
                Console.WriteLine($"Student Name: {item.Name}");
                Console.WriteLine($"Student Surname: {item.Surname}");
                Console.WriteLine($"Student ClassId: {item.ClassId}");
            }

            // GroupBy()
            // Exception has occurred: CLR/System.InvalidOperationException
            Console.WriteLine("***** GroupBy ******");
            // var studentGroupBy = _context.Students.Where(student => student.ClassId == 2).GroupBy(x => x.StudentId).ToList();
            // foreach (var item in studentGroupBy)
            // {
            //     Console.WriteLine($"Student Id: {item.Key}");
            //     Console.WriteLine($"Student Name: {item.FirstOrDefault().Name}");
            //     Console.WriteLine($"Student Surname: {item.FirstOrDefault().Surname}");
            //     Console.WriteLine($"Student ClassId: {item.FirstOrDefault().ClassId}");
            // }

            // Anonymous Object Result
            Console.WriteLine("***** Anonymous Object Result ******");
            var studentAnonymous = _context.Students.Where(student => student.ClassId == 2)
                .Select(x => new 
                { 
                    id =  x.StudentId,
                    FullName = x.Name + " " + x.Surname
                
                });
            
            foreach (var item in studentAnonymous)
            {
                Console.WriteLine($"Student Id: {item.id}");
                Console.WriteLine($"Student Name: {item.FullName}");
            }

            Console.ReadLine();  
        }
    }
}