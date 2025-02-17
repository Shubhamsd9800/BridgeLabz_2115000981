using System;
using MovieManagementSystem;
using StudentRecordManagement;
using CustomTaskScheduler;
using TaskScheduler = CustomTaskScheduler.TaskScheduler;
using InventoryMAnagementSystem;
using LibraryManagementSystem;
using RoundRobinAlgorithm;
using SocialMediaFriendConnection;
using UndoRedoFunctionality;
using OnlineTicketReservationSystem;
class Program
{
    public static void Main(string[] args)
    {

        // QUESTION NO-1
        //StudentList studentList = new StudentList();
        //studentList.AddStudentAtEnd(1, "Somesh Purwar", 21, "A+");
        //studentList.AddStudentAtBeginning(2, "Shubham Das", 20, "A");
        //studentList.AddStudentAtPosition(3, "Krishna", 21, "B", 2);
        //Console.WriteLine("Student Records:");
        //studentList.DisplayAllStudents();
        //Console.WriteLine("\nSearching for student with Roll Number 2:");
        //studentList.SearchStudent(2);
        //Console.WriteLine("\nUpdating grade for Roll Number 3:");
        //studentList.UpdateGrade(3, "A+");
        //studentList.DisplayAllStudents();
        //Console.WriteLine("\nDeleting student with Roll Number 2:");
        //studentList.DeleteStudent(2);
        //studentList.DisplayAllStudents();


        //QUESTION NO-2
        //MovieList movieList = new MovieList();
        //movieList.AddMovieAtEnd("Jawaan", "Atlee", 2021, 9.0);
        //movieList.AddMovieAtEnd("Baby John", "kalees", 2025, 7.8);
        //movieList.AddMovieAtEnd("Marco", "Haneef Adeni", 2024, 9.0);
        //movieList.DisplayMovies();
        //movieList.DisplayMoviesReverse();
        //movieList.SearchMovie("kalees");
        //movieList.UpdateRating("Marco", 8.0);
        //movieList.RemoveMovie("Baby John");
        //movieList.DisplayMovies();


        // QUESTION NO-3
        //TaskScheduler scheduler = new TaskScheduler();
        //scheduler.AddTaskAtEnd(1, "Task A", 2, DateTime.Now.AddDays(3));
        //scheduler.AddTaskAtEnd(2, "Task B", 1, DateTime.Now.AddDays(2));
        //scheduler.AddTaskAtBeginning(3, "Task C", 3, DateTime.Now.AddDays(5));
        //scheduler.AddTaskAtPosition(4, "Task D", 2, DateTime.Now.AddDays(4), 2);

        //Console.WriteLine("All Tasks:");
        //scheduler.DisplayAllTasks();

        //Console.WriteLine("\nCurrent Task:");
        //scheduler.ViewCurrentTask();

        //scheduler.RemoveTask(2);
        //Console.WriteLine("\nTasks after removing Task 2:");
        //scheduler.DisplayAllTasks();

        //Console.WriteLine("\nSearch Task with Priority 2:");
        //scheduler.SearchTaskByPriority(2);

        // QUESTION NO-4
        //Inventory inventory = new Inventory();
        //inventory.AddItemAtEnd("Laptop", "101", 5, 75000.50);
        //inventory.AddItemAtBeginning("Mouse", "102", 10, 2500.99);
        //inventory.AddItemAtEnd("Keyboard", "103", 7, 4500.75);
        //Console.WriteLine("Inventory Records:");
        //inventory.DisplayAllItems();
        //Console.WriteLine("\nSearching for item with ID 102:");
        //inventory.SearchItem("102");
        //Console.WriteLine("\nUpdating quantity for Item ID 103:");
        //inventory.UpdateQuantity("103", 12);
        //inventory.DisplayAllItems();
        //Console.WriteLine("\nDisplaying total inventory value:");
        //inventory.DisplayTotalInventoryValue();
        //Console.WriteLine("\nRemoving item with ID 101:");
        //inventory.RemoveItem("101");
        //inventory.DisplayAllItems();


        // QUESTION NO-5


        //Library library = new Library();
        //library.AddBookAtEnd("Gunahon Ka Devta", "Dharamveer Bharti", "Romance", "B001", true);
        //library.AddBookAtEnd("Madhushala", "Harivansh Rai Bachchan", "Poetry", "B002", true);
        //library.AddBookAtEnd("Rag Darbari", "Shrilal Shukla",
        //"Satire", "B003", false);
        //library.AddBookAtEnd("Godaan", "Munshi Premchand",
        //"Fiction", "B004", true);
        //library.AddBookAtEnd("Ramayan", "Valmiki",
        //"Mythology", "B005", true);
        //library.DisplayBooks();
        //library.DisplayBooksReverse();
        //library.SearchBook("Valmiki");
        //library.UpdateAvailability("B003", true);
        //library.RemoveBook("B001");
        //library.DisplayBooks();
        //library.CountBooks();


        // QUESTION NO-6

        //CircularLinkedList scheduler = new CircularLinkedList();
        //scheduler.AddProcess(1, 10, 2);
        //scheduler.AddProcess(2, 5, 1);
        //scheduler.AddProcess(3, 8, 3);
        //scheduler.AddProcess(4, 6, 2);
        //scheduler.DisplayProcesses();
        //scheduler.RoundRobinScheduling(4);

        //Question NO-7

        //SocialMedia socialMedia = new SocialMedia();
        //socialMedia.AddUser("1", "Somesh", 25);
        //socialMedia.AddUser("2", "Shubham", 27);
        //socialMedia.AddUser("3", "Vaibhav", 22);
        //socialMedia.AddUser("4", "Shivam", 24);
        //socialMedia.AddFriend("1", "2");
        //socialMedia.AddFriend("1", "3");
        //socialMedia.AddFriend("2", "3");
        //socialMedia.AddFriend("2", "4");
        //socialMedia.DisplayFriends("1");
        //socialMedia.CountFriends("1");
        //Console.WriteLine("Finding mutual friends between Somesh and Shubham: ");
        //socialMedia.FindMutualFriends("1", "2");
        //socialMedia.RemoveFriend("1", "2");
        //socialMedia.DisplayFriends("1");


        //QUESTION  NO-8
        //TextEditor editor = new TextEditor();
        //editor.AddState("Hello");
        //editor.AddState("Hello, World!");
        //editor.AddState("Hello, World! How are you?");
        //editor.DisplayCurrentState();
        //editor.Undo();
        //editor.DisplayCurrentState();
        //editor.Undo();
        //editor.DisplayCurrentState();
        //editor.Redo();
        //editor.DisplayCurrentState();


        // QUESTION NO-9
        OnlineTicketReservationSystem.CircularLinkedList ticketSystem = new OnlineTicketReservationSystem.CircularLinkedList();
        ticketSystem.AddTicket(101, "Somesh", "Sanam Teri Kasam", "A1");
        ticketSystem.AddTicket(102, "Shubham", "Baby John", "B3");
        ticketSystem.AddTicket(103, "Bangali", "TMKOC", "C2");
        ticketSystem.AddTicket(104, "Krishna", "SkyForce", "D4");

        ticketSystem.DisplayTickets();

        ticketSystem.SearchTicket("Sanam Teri Kasam");
        ticketSystem.SearchTicket("TMKOC");

        Console.WriteLine($"\nTotal booked tickets: {ticketSystem.CountTickets()}");
        ticketSystem.RemoveTicket(103);
        ticketSystem.DisplayTickets();
        Console.WriteLine($"\nTotal booked tickets: {ticketSystem.CountTickets()}");


    }
}