public class Food {
    public int? FoodId {get;set;}
    public string Name { get;set;}
    public decimal Price {get;set;}
}

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