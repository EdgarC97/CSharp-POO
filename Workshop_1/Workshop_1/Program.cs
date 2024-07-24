using System.Security.Cryptography.X509Certificates;
using Workshop_1.models;
public class Program
{
    static void Main(string[] args)
    {
        //CLASS STUDENT
        //Student list
        List<Student> students = new List<Student>();
        //Create a new student instance
        Student student1 = new Student("PEPE", 19,true);
        Student student2 = new Student("JOACO", 31,true);
        //Add student to list
        students.Add(student1);
        students.Add(student2);
        //Print list of students
        foreach (var student in students)
        {
            Console.WriteLine(student.GetStudentDetails());
        }

        //CLASE STORE
        Garment garment = new Garment("CAMISA","XL", 50000);
        Store store = new Store();

        store.AddGarment(garment);
        store.ShowGarmentList();
        store.FindGarmentByName("CAMISA");

    }
}