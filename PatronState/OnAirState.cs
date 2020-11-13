using System;
namespace PatronState
{
    public class OnAirState : IFlightState
    {

        public void HandleOperation(Flight flightContext)
        {
            Console.WriteLine("{0}: The plane is on Air", nameof(OnAirState));
            flightContext.FlightState = new ArrivalState();
            flightContext.FlightState.HandleOperation(flightContext);
        }
    }
}
