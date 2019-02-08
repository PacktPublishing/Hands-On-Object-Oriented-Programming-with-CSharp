using System;

namespace AnimalProject {
    static void Main(){
        Animal animal = new Animal();
        animal.name = "Dog"; // Not possible, as the name field is private
        animal.GetName(); // Possible, as the GetName method is public
    }

    public class Animal {
        private string name;
        public string GetName() {
            return name;
        }
    }
}
