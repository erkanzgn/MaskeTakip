using System;
using Business.Concrete;
using Entities.Concrete;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {


            Person person1 = new Person();
            person1.FirstName = "Erkan";
            person1.LastName = "Özgün";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 123;

            PttMenager pttmenager = new PttMenager(new PersonMenager());
            pttmenager.GiveMask(person1);



            Console.ReadLine();
        }
        
 

  
    }

 
}
