using enums_records;

Day today = Day.Thursday;
Console.WriteLine(today);

Student student1 = new Student("Benny", "1988-07-09");
Student student2 = new Student("Dan", "1988-01-15");

Console.WriteLine(student1.Name);
Console.WriteLine(student2.Birthday);
Console.WriteLine();

List<Student> students = new List<Student>()
{
    new Student("Benny", "1988-07-09"),
    new Student("Dan", "1988-01-15"),
    new Student("Arvid", "2003-10-16"),
    new Student("Manuel", "2000-10-02"),
};

foreach(Student student in students)
{
    Console.WriteLine(student.Name);
}