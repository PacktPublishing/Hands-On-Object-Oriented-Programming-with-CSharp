using System;
namespace AnimalProject {
    abstract class Animal {
        public string name;
        public int ageInMonths;
        public abstract void Move();
        public void Eat(){
            Console.WriteLine("Eating");
        }
    }
    static void Main(){
        Animal animal = new Animal(); // Not possible as the Animal class is abstract class
    }
}