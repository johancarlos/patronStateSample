using System;
namespace PatronState
{
    public class ArrivalState : IFlightState
    {
        public void HandleOperation(Flight flightContext)
        {
            Console.WriteLine("{0}: The plane is on land! Flight Succesfull", nameof(ArrivalState));
            flightContext.FlightState = new ReadyToFlightState();
            flightContext.FlightState.HandleOperation(flightContext);
        }
    }
}
