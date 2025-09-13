namespace P41_C__SystemOfADown
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Console.WriteLine("Group");
            Console.WriteLine("----------------------------------------");
            foreach (Student s in group)
            {
                Console.WriteLine(s);
            }

            group.Sort(new DateComparer());

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            foreach (Student s in group)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            group.Sort(new StudentCardComparer());
            foreach (Student s in group)
            {
                Console.WriteLine(s);
            }

            //Array Shapes = new Shape[4];

            //Shapes.SetValue(new Rectangle(4, 5), 0);
            //Shapes.SetValue(new Circle(1), 1);
            //Shapes.SetValue(new Triangle(3, 4), 2);
            //Shapes.SetValue(new Trapezoid(3, 4, 5), 3);

            //foreach (Shape shape in Shapes)
            //{
            //    Console.WriteLine(shape.Area());
            //}
            //Random random = new Random();

            //happybirthday birthday = new happybirthday(new DateTime(1990, 1, 1));
            //birthday.PrintBirthday();
            //birthday.setBirthday(new DateTime(2008, 2, 4));
            //birthday.PrintBirthday();
            //Console.WriteLine(birthday.getWeekBirth());
            //Console.WriteLine(birthday.getDayOfWeekBirth());
            //Console.WriteLine(birthday.getDaysTillNextBirthday());
            //Console.WriteLine();
            //Console.WriteLine(birthday.getBirthdayInYear(2025));
            //Console.WriteLine(birthday.getBirthdayInYear(2026));

            //int[,] TDArr = new int[5, 5];

            //for (int i = 0; i < TDArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TDArr.GetLength(1); j++)
            //    {
            //        TDArr[i, j] = random.Next(1, 30); 
            //    }
            //}

            //for (int i = 0; i < TDArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TDArr.GetLength(1); j++)
            //    {
            //        Console.Write(TDArr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int min = TDArr[0, 0];
            //int max = TDArr[0, 0];
            //for (int i = 0; i < TDArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TDArr.GetLength(1); j++)
            //    {
            //        if (TDArr[i, j] < min)
            //        {
            //            min = TDArr[i, j];
            //        }
            //        if (TDArr[i, j] > max)
            //        {
            //            max = TDArr[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"Max: {max}, Min: {min}");


        }
    }

}
