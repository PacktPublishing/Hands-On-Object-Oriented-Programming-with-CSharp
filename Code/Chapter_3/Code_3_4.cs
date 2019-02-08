// File name: Animal.cs
using System;
namespace AnimalProject {
    public partial class Animal {
        public string name;
        public int ageInMonths;
    
        public void Eat(){
            Console.WriteLine("Eating");
        }
     }
}

// File name: AnimalMoving.cs
using System;
namespace AnimalProject {
    public partial class Animal {
        
        public void Move(){
            Console.WriteLine("Moving");
        }
    }
}