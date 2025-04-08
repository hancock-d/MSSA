using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4InterfacesDemo1Dave
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal interface ICRUD<T>
    {
        void Create(T obj); //Create method
        IList<T> GetAll(); //Read method, get list
        void Update(T obj); //Update method, pass the object to be updated
        void Delete(T obj); //Delete method, pass the object to be deleted
    }

    //Write the CRUD operations/implement them with my applications with the Student

    class DataOperations : ICRUD<Student>
    {
        static List<Student> students = new List<Student>();  //this list is the source for students
        public void Create(Student obj) //adding new student
        {
            students.Add(obj);
        }

        public void Delete(Student obj) //removing student
        {
            students.Remove(obj); //pass the obj to be removed
        }

        public IList<Student> GetAll() //get list of all students
        {
            return students;
        }

        public void Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
