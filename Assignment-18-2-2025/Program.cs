using System;


class Program
{
    static void Main()
    {


        // QUESTION NO-1

        //Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        //electronicsStorage.AddItem(new Electronics("Laptop", 120000.50, "Dell"));
        //electronicsStorage.AddItem(new Electronics("Smartphone", 8999.99, "Samsung"));

        //Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        //groceriesStorage.AddItem(new Groceries("Milk", 30.50, DateTime.Now.AddDays(10)));
        //groceriesStorage.AddItem(new Groceries("Bread", 20.00, DateTime.Now.AddDays(5)));

        //Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        //furnitureStorage.AddItem(new Furniture("Chair", 1500.75, "Wood"));
        //furnitureStorage.AddItem(new Furniture("Table", 3000.40, "Metal"));

        //Console.WriteLine("Electronics Storage:");
        //electronicsStorage.DisplayItems();

        //Console.WriteLine("\nGroceries Storage:");
        //groceriesStorage.DisplayItems();

        //Console.WriteLine("\nFurniture Storage:");
        //furnitureStorage.DisplayItems();



        // QUESTION NO-2

        //var book = new Product<BookCategory>("C# Programming", 50.00, new BookCategory());
        //var shirt = new Product<ClothingCategory>("T-Shirt", 20.00, new ClothingCategory());


        //book.DisplayInfo();
        //shirt.DisplayInfo();


        //DiscountManager.ApplyDiscount(book, 10);
        //DiscountManager.ApplyDiscount(shirt, 15);


        //book.DisplayInfo();
        //shirt.DisplayInfo();


        // QUESTION NO-3

        //var university = new University();
        //var mathCourse = new Course<ExamCourse>("Advanced Mathematics", "Science", new ExamCourse());
        //var literatureCourse = new Course<AssignmentCourse>("World Literature", "Arts", new AssignmentCourse());


        //university.AddCourse(mathCourse);
        //university.AddCourse(literatureCourse);


        //university.DisplayAllCourses();




        // QUESTION NO-4

        //Console.WriteLine("Generating Vegetarian Meal Plan:");
        //MealPlanGenerator.GenerateMealPlan<VegetarianMeal>();

        //Console.WriteLine("\nGenerating Vegan Meal Plan:");
        //MealPlanGenerator.GenerateMealPlan<VeganMeal>();

        //Console.WriteLine("\nGenerating Keto Meal Plan:");
        //MealPlanGenerator.GenerateMealPlan<KetoMeal>();

        //Console.WriteLine("\nGenerating High-Protein Meal Plan:");
        //MealPlanGenerator.GenerateMealPlan<HighProteinMeal>();



        // QUESTION NO-5
        var resume1 = new Resume<SoftwareEngineer>("SP", "C#, .NET, SQL");
        var resume2 = new Resume<DataScientist>("KP", "Python, Machine Learning, SQL");

        ResumeScreeningSystem.ProcessResume(resume1);
        ResumeScreeningSystem.ProcessResume(resume2);

        Console.WriteLine("\nAll Screened Resumes:");
        ResumeScreeningSystem.DisplayAllResumes();
    }
}
