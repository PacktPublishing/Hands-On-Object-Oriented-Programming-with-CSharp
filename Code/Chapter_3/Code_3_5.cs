sealed class Animal {
    public string name;
    public int ageInMonths;
    public void Move(){
        Console.WriteLine("Moving");
    }
    public void Eat(){
        Console.WriteLine("Eating");
    }
}
public static void Main(){
    Animal dog = new Animal();
    dog.name = "Doggy";
    dog.ageInMonths = 1;
    
    dog.Move();
    dog.Eat();
}