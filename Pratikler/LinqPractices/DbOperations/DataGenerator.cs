namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void Intialize()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }

                context.Students.AddRange(
                    new Student()
                    {
                        Name = "John",
                        Surname = "Doe",
                        ClassId = 1
                    },
                    new Student()
                    {
                        Name = "Jane",
                        Surname = "Doe",
                        ClassId = 1
                    },
                    new Student()
                    {
                        Name = "John",
                        Surname = "Smith",
                        ClassId = 2
                    },
                    new Student()
                    {
                        Name = "Jane",
                        Surname = "Smith",
                        ClassId = 2
                    },
                    new Student()
                    {
                        Name = "John",
                        Surname = "Doe",
                        ClassId = 3
                    },
                    new Student()
                    {
                        Name = "Jane",
                        Surname = "Doe",
                        ClassId = 3
                    },
                    new Student()
                    {
                        Name = "John",
                        Surname = "Smith",
                        ClassId = 4
                    },
                    new Student()
                    {
                        Name = "Jane",
                        Surname = "Smith",
                        ClassId = 4
                    }
                );

                context.SaveChanges();
            }
        }
    }
}