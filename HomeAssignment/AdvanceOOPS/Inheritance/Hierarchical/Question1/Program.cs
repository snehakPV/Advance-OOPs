using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Student student=new Student("sneha","kumar",new DateTime(2001,01,02),"987654321","female","sneha@gmail.com",100,"BE","CSE",6);
        Teacher teacher=new Teacher("sneha","kumar",new DateTime(2001,01,02),"987654321","female","sneha@gmail.com",1223,"CSE","Science","BE",2023,new DateTime(2023,03,01));
        student.ShowDetails();
        teacher.ShowDetails();
    }
}
