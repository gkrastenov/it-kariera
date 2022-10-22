using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private Controller controller;
    private bool isRunning;

    public Engine(Controller controller)
    {
        this.controller = controller;
        this.isRunning = true;
    }

    public void Run()
    {
        while (isRunning)
        {
            string[] splittedInput = Console.ReadLine().Split();

            string command = splittedInput[0];
            List<string> arguments = splittedInput
                .Skip(1)
                .ToList();

            string result = "";

            switch (command)
            {
                case "Product":
                    result = controller.ProcessProductCommand(arguments);
                    break;
                case "Service":
                    result = controller.ProcessServiceCommand(arguments);
                    break;
                case "Checkout":
                    result = controller.ProcessCheckoutCommand(arguments);
                    break;
                case "Info":
                    result = controller.ProcessInfoCommand(arguments);
                    break;
                case "End":
                    result = controller.ProcessEndCommand();
                    this.isRunning = false;
                    break;
                default:
                    result = "Invalid command";
                    break;
            }

            Console.WriteLine(result);
        }
    }
}

