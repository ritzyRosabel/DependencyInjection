using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    //Hello everyone, this is my dependency injectyion pproject it imitates a school log book
   
    // dependency injection involves three differet types of classes
    //client class
    //service class
    //injector class
    // we have three types of dependency injector
    //fields/property injector
   //constructor injector
   // setter injector
   // i will be using the constructor injector 


    // client class : This class depends on the Service class to function 
    public class SchoolLog
    {
        private IService _service;
      
        public SchoolLog(IService service) 
        {
            this._service = service;
            this._service.GetFirstName();
            this._service.GetLastName();
        }
    }
    //interface for the service class
    public interface IService
    {
        void GetFirstName();
        void GetLastName();
    }
    // service class:  This class provides a service to my client class
    public class Student : IService
    {
        public void GetFirstName()
        {
            Console.WriteLine("Students FirstName");
        }

        public void GetLastName()
        {
            Console.WriteLine("Students LastName");
        }
    }
     public class Teacher : IService
    {
        public void GetFirstName()
        {
            Console.WriteLine("Teacher FirstName");
        }

        public void GetLastName()
        {
            Console.WriteLine("Teacher LastName");
        }
    }

    // injector class :This class injects the Service class to the client class
    class Program
    {
        static void Main(string[] args)
        {
            SchoolLog schoolLog = new SchoolLog (new Student());

            //SchoolLog schoolLog1 = new SchoolLog (new Teacher());
            Console.ReadKey();
        }
    }
}
