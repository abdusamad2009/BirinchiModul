namespace dars11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school1 = CreateSchool1();
            FillSchoolObject(school1);
        }

        static School CreateSchool1()
        {
            School school = new School();
            return school;
        }
        static School CreateSchool2()
        {
            return new School();
        }

        static void FillSchoolObject(School school)
        {
            Console.Write("maktab raqami :");
            school .Number = int.Parse(Console.ReadLine());
            Console.Write("maktab nomi :");
            school .Name = (Console.ReadLine());
            Console.Write("maktab manzili :");
            school .Location = (Console.ReadLine());
            Console.Write("maktab sigimi :");
            school .Capacity = int.Parse(Console.ReadLine());
            Console.Write("maktab talabalar soni :");
            school .CurrentStudentCount = int.Parse(Console.ReadLine());

        }
    }
}
