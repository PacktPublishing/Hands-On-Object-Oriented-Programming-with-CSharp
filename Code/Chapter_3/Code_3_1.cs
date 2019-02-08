interface IBankAccount {
    void Debit(double amount);
    void Credit(double amount);
}
class BankAccount : IBankAccount {
    public void Debit(double amount){
        Console.WriteLine($"${amount} has been debited from your account!");
    } 
    public void Credit(double amount){
        Console.WriteLine($"${amount} has been credited to your account!");
    }
}