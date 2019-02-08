using System;
namespage AnimalProject {
    static void Main(){
        Dog dog = new Dog();
        dog.GetName();
    }
    
    internal class Dog {
        internal string GetName(){
            return "doggy";
        }
    }
}