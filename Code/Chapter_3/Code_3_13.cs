//Assembly1.dll
using System;
namespace AnimalProject {
    public class Animal {
        protected internal string GetName(){
            return "Nice Animal";
        }
    }
}
//Assembly2.dll
using System;
namespace AnimalProject2 {
    public class Dog : Animal {
        public string GetDogName(){
            return base.GetName(); // This will work
        }
    }
    public class Cat {
        Animal animal = new Animal();
        
        public string GetCatName(){
            return animal.GetName(); // This is not possible, as GetName is protected internal
        }
    }
}