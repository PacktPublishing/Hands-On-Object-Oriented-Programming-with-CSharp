public class FoodRepository {
    public int SaveFood(Food food){
        int result = SaveFoodInDatabase(food);
        return result;
    }

    public Food GetFood(int foodId){
        Food result = new Food();
        result = GetFoodFromDatabaseById(foodId);
        return result;
    }
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