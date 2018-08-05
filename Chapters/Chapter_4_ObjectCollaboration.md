# Introduction

As we have discussed in earlier chapter, Object oriented programming is about objects. Objects are in the center of this programming methodology. We will design our software keeping OOP in mind, we will try to break our software components into small objects and try to make proper relation between them so that all these objects can ultimately give us our desired output. This "relationship" between the objects is called "Object Collaboration".

Object collaboration is definitely one of the most important topics in oop. If the objects doesn't collaborate with each other in a program, nothing can be achieved. For example, if we think about a simple web application. It normally has 3 parts, UI, logic and data access layer. Every layer has their own objects which are specially designed to serve a purpose. There could be objects related to UI, there will be objects for the logical layers and may be some objects which will talk with database. Now anyhow every object has to collaborate with another object to maintain the flow. It will be very very rare where an object will not have any type of collaboration with each other in a software.

## Different types of Object Collaboration in CSharp

There are many ways an object can collaborate with other objects. But here in this chapter we will only talk about the basic 3 collaboration rules. We will see some examples, to understand the concepts properly. The 3 basic collaborate rules are:

1. Collaboration
2. Aggregation
3. Inheritance

Now before we jump into details about these types. Let's first see a case study. After when we will be discussing about the types, we will try to use the case study so that we can relate the types with real examples.

### Case Study

Let's think that we are going to develop a Restaurant Management Software. Definitely we are only going to focus on object collaboration and not about the application design in this chapter. So lets see what objects we will be needing for a simple Restaurant Management System software? We will be surly needing an object of Food, an object of Chef, an object of Waiter and an object or Beverage. Let's try to list all the objects that are needed to develop a restaurant management software.

The objects we need:

* Food
* Beef Burger
* Pasta
* Beverage
* Cola
* Coffee
* Order
* OrderItem
* Staff
* Chef
* Waiter
* FoodRepository
* BeverageRepository
* StaffRepository

The Repository objects will be talking with the database to store and retrieve related information. For example, the FoodRepository will be used to save and retrieve objects of Food and Beverage. We have more specific food objects like Beef Burger and Pasta. Here these objects are sub category of the Food object. Now as a software developer, we have identified the objects that are needed to develop this software. Now its time to use these objects in such a way so that it solves the problem that the software will be used for. But before we start writing code, we need to understand or figure out how the objects will relate to each other. Lets start with the rule "Collaboration".

## Collaboration

When one object uses another unrelated object to do some task, the relationship between them is called collaboration. In software world we also refer this relation as "use a" relation. Lets see if we have any collaboration relation between our objects. If we analyze our FoodRepository object will be saving and retrieving Food and Beverage objects form database. It means the FoodRepository object has to use the "Food" object. From the frontend when a new Food object will be created, that object will be passed to FoodRepository. The FoodRepository will then serialize the Food object to database data to save it in the database. If the FoodRepository doesn't use the Food object then how would it know what to serialize and store in database? So here the FoodRepository must have collaboration relationship with the "Food" object. Lets see code of it:

```csharp
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
```

In the above code we can see that the FoodRepository class has 2 methods. One is **SaveFood** and another is **GetFood**. SaveFood is taking one object of Food and saving it in database. And returning the newly created FoodId. On the other method GetFood, the id of a Food is passed. The method searches the food in database and maps it back to a Food object. Then the food object is returned to the view.

So here we can see that FoodRepository object needs to use the Food object to do its work. And this type of relationship is called Collaboration relationship. We can also use the "use a" phrase to identify these relationship. The FoodRepository uses a Food object to save food in database.

Like food, the foodRepository also uses a Beverage object to save and retrieve beverage in database. Let's see the code:

``` csharp
public class Beverage {
    public int? BeverageId {get;set;}
    public string Name { get;set;}
    public decimal Price {get;set;}
}

public class FoodRepository {
    public int SaveBeverage(Beverage beverage){
        int result = SaveBeverageInDatabase(beverage);
        return result;
    }

    public Food GetBeverage(int beverageId){
        Beverage result = new Beverage();
        result = GetBeverageFromDatabaseById(beverageId);
        return result;
    }
}
```

If you see the above code, you will see that the FoodRepository has two methods one is SaveBeverage and another is GetBeverage. Both of these methods uses Beverage object. It means the FoodRepository has a collaborative relationship with Beverage object.

Now lets see the whole FoodRepository class:

```csharp
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

    public int SaveBeverage(Beverage beverage){
        int result = SaveBeverageInDatabase(beverage);
        return result;
    }

    public Food GetBeverage(int beverageId){
        Beverage result = new Beverage();
        result = GetBeverageFromDatabaseById(beverageId);
        return result;
    }
}
```

One object can be related with multiple objects using collaborative relationship. In OOP this type of relationship is very common.

### Why we need Collaboration relationship

## Aggregation

Another type of relationship the objects have between them is Aggregation. Aggregation type of relationship is also called "has a" relationship. When one object has another object in it as a property, it is the "has a" relationship means Aggregation relationship. For example in our case study, we have Food object. We all know, no food can exist without a chef. Someone has to cook, bake, prepare it. So we can say a food has a chef. It means, the food object will have a property named "Chef", which will hold the chef of that food. Let's see the code:

``` csharp
public class Food {
    public int? FoodId {get;set;}
    public string Name { get; set; }
    public string Price { get; set; }
    public Chef Chef { get; set; }
}
```

If we also think about Beverage, every beverage must have a company or maker. For example if we think about the commercial beverages, those are made by companies like "Pepsi Co.", "Coka Cola Company". The beverage can also be local made, in that case the company name would be the name of the local shop. But the main idea here is that, a beverage must have a Manufacturer Company. So let's see this is code:

```csharp
public class Beverage {
    public int? BeverageId {get;set;}
    public string Name { get; set; }
    public string Price { get; set; }
    public Manufacturer Manufacturer { get; set; }
}
```

In both of the above objects "Chef" and "Manufacturer" are objects and are used as property of "Food" and "Beverage" objects. This relationship is called aggregation. There is a special type of aggregation relationship, named "Composition".

### Composition

If we think about the Chef and Manufacturer classes, the existence of these classes are not depending on "Food" and "Beverage" classes fully. These classes can exists independently by themselves. But when there is a case that an object can't exist without another object, that relationship is called Composition relationship. Let's see an example:

```csharp
public class Order {
    public int OrderId { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public DateTime OrderTime { get; set; }
    public Customer Customer { get; set; }
}
```

Here if we analyze the above class, we will see that Order class has Customer class and List of OrderItems as a property and these are related in aggregate way. Between these two Customer object can be an independent object, but OrderItem is not. OrderItem can't be independent. OrderItem has to be a part of Order. If an OrderItem is not a part of Order, its untraceable, its unusable. So, we can say OrderItem has a composition relationship with Order object.

### Inheritance

This is one of the 4 pillars of OOP. Inheritance is when one object inherits or reuses another objects properties or methods. The class that gets inherited is called base class and the class that inherits the base class is normally called derived class. The inheritance relationship can be treated as "is a" relationship. For example "Pasta is a Food". We know that Pasta is a kind of food, and satisfies all the attributes of Food. Pasta has unique id in database, it has a name, it has a price and for sure it has a chef. So as Pasta is satisfying all the attributes of the Food class, it can inherit Food class and use the properties of the food class. Let's see the code:

```csharp
public class Pasta : Food {
    public string Type { get; set; }
    public CheeseType Cheese { get; set; }
    public string[] Spices { get; set; }
}
```

Same like pasta, is we think about any kind of beverage. For example Coffee is a type of beverage. And Coffee has all the attributes that the beverage object has. A coffee has a name and price. Coffee has might have sugar amount, milk, coffee bean location. Let's write the coffee class and see how it looks:

```csharp
public class Coffee : Beverage {
    public int Sugar { get; set; }
    public int Milk { get; set; }
    public string BeanLocation { get; set; }
}
```

So here we can say, Coffee is inheriting beverage. Coffee is the derived class and Beverage is the base class.

## Conclusion

The above mentioned types are the most used collaboration types in C#. When designing an application or architecture a software, the object collaboration is very important thing. It will define how much flexible the software is, how many new functionality can be added, how easy will it be to maintain code. Object collaboration is very important. In the next chapter, we will talk about exception handling. It's another very important part of programming.