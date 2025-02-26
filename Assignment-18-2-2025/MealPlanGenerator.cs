
using System;
using System.Collections.Generic;

// Meal Plan Interface
public interface IMealPlan
{
    string GetMealType();
    void DisplayMeals();
}

// Different meal plan implementations
public class VegetarianMeal : IMealPlan
{
    public string GetMealType() => "Vegetarian";
    public void DisplayMeals() => Console.WriteLine("Meals: Salad, Grilled Vegetables, Paneer Curry");
}

public class VeganMeal : IMealPlan
{
    public string GetMealType() => "Vegan";
    public void DisplayMeals() => Console.WriteLine("Meals: Tofu Stir-Fry, Quinoa Salad, Lentil Soup");
}

public class KetoMeal : IMealPlan
{
    public string GetMealType() => "Keto";
    public void DisplayMeals() => Console.WriteLine("Meals: Grilled Chicken, Avocado Salad, Cheese Omelette");
}

public class HighProteinMeal : IMealPlan
{
    public string GetMealType() => "High-Protein";
    public void DisplayMeals() => Console.WriteLine("Meals: Egg Whites, Grilled Fish, Protein Smoothie");
}

// Generic Meal class
public class Meal<T> where T : IMealPlan, new()
{
    public T MealPlan;

    public Meal()
    {
        MealPlan = new T();
    }

    public void ShowMealPlan()
    {
        Console.WriteLine($"Meal Plan Type: {MealPlan.GetMealType()}");
        MealPlan.DisplayMeals();
    }
}

// Meal Plan Generator class
public static class MealPlanGenerator
{
    public static void GenerateMealPlan<T>() where T : IMealPlan, new()
    {
        Meal<T> meal = new Meal<T>();
        meal.ShowMealPlan();
    }
}





