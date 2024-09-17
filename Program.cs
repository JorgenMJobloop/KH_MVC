namespace KH_MVC;
class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("John Doe", 47);
        View view = new View();

        Controller controller = new Controller(model, view);

        // Show the model

        // update the name & age

        // display the updated model

        // Keep the conole open for input
        Console.ReadLine();
    }
}
