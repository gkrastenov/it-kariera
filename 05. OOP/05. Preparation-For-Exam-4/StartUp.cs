namespace PreparationForExam4
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Engine engine = new Engine(controller);

            engine.Run();
        }
    }
}