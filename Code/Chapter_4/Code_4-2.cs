public class Beverage {
    public int? BeverageId {get;set;}
    public string Name { get;set;}
    public decimal Price {get;set;}
}

public class BeverageRepository {
    public int SaveBeverage(Beverage beverage){
        int result = SaveBeverageInDatabase(beverage);
        return result;
    }

    public Beverage GetBeverage(int beverageId){
        Beverage result = new Beverage();
        result = GetBeverageFromDatabaseById(beverageId);
        return result;
    }
}