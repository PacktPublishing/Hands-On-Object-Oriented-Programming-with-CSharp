abstract class Animal {
    public string name;
    public int ageInMonths;
    public abstract void Move();
    public void Eat(){
        Console.WriteLine("Eating");
    }
}
class Dog : Animal {
    public override void Move() {
        Console.WriteLine("Moving");
    }
} 