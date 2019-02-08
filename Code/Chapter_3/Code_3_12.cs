using System;
namespage AnimalProject {
    static void Main(){
        Animal animal = new Animal();
        Dog dog = new Dog();
        animal.GetName(); // Not possible as Main is not a child of Animal
        dog.GetDogName();
    }
    
    class Animal {
        protected string GetName(){
            return "doggy";
        }
    }
    class Dog : Animal {
        public string GetDogName() {
            return base.GetName();
        }
    }
}