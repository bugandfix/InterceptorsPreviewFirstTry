


var studentExample = new Student();

studentExample.Enroll("Ali");
studentExample.Enroll("Hasan");
studentExample.Enroll("Kamal");
studentExample.Enroll("Reza");




public class Student
{
    public void Enroll(string studentName)
    {
        Console.WriteLine($"This Student {studentName} has been registered");
    }
}

