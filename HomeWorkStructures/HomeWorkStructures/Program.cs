using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructures
{

    class Program
    {
        static void Main(string[] args)
        {
            //UserMenuChoice();

            Group myGroup = new Group("AG-08", 3, 009);

            Student testOneStudent = new Student("Vasa", 21);
            Student testTwoStudent = new Student("Vasa2", 22);
            Student testThreeStudent = new Student("Vasa3", 23);
            Student testFourStudent = new Student("Vasa4", 24);
            Student testFiveStudent = new Student("Vasa5", 25);

            myGroup.AddStudentInGroup(testOneStudent);
            myGroup.AddStudentInGroup(testTwoStudent);
            myGroup.AddStudentInGroup(testThreeStudent);
            myGroup.AddStudentInGroup(testFourStudent);
            myGroup.AddStudentInGroup(testFiveStudent);

            myGroup.RemoveStudentFromGroup(testFourStudent);

            myGroup.ShowInfoAboutGroup();
            Console.ReadLine();


        }


    }
}
