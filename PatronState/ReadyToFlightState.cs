using System;
namespace PatronState
{
    public class ReadyToFlightState: IFlightState
    {
        public void HandleOperation(Flight flightContext)
        {
            Console.WriteLine("the Airplane is ready to flight.");
        }
    }
}
