namespace KH_MVC;
class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("John Doe", 47);
        View view = new View();

        Controller controller = new Controller(model, view);

        // Show the model
        controller.ShowModel();

        // update the name & age
        controller.UpdateAge();


        // display the updated model
        controller.ShowModel();

        // Keep the conole open for input
        Console.ReadLine();
    }
}
