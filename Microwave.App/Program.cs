using System;
using Microwave.Classes.Boundary;
using Microwave.Classes.Controllers;

namespace Microwave.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Button startCancelButton = new Button();
            Button powerButton = new Button();
            Button timeButton = new Button();

            int maxMicrowavePower = 1000; //Unit is Watts

            Door door = new Door();

            Output output = new Output();

            Display display = new Display(output);

            PowerTube powerTube = new PowerTube(output, maxMicrowavePower);

            Light light = new Light(output);

            Buzzer buzzer = new Buzzer();

            Microwave.Classes.Boundary.Timer timer = new Timer();

            CookController cooker = new CookController(timer, display, powerTube);

            UserInterface ui = new UserInterface(powerButton, timeButton, startCancelButton, door, display, light, cooker, buzzer, maxMicrowavePower);

            // Finish the double association
            cooker.UI = ui;

            // Simulate a simple sequence
            for (int i = 0; i < 25; i++)
            {
                powerButton.Press();
            }
            

            timeButton.Press();

            startCancelButton.Press();

            // Tilføjelse: Vi tilføjer 2x 5 sekunder til tiden.
            timeButton.Press(); // 5 sek

            timeButton.Press(); // 5 sek

            // The simple sequence should now run

            System.Console.WriteLine("When you press enter, the program will stop"); 
            // Wait for input

            System.Console.ReadLine();
        }
    }
}
