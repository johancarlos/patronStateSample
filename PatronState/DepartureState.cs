using System;
namespace PatronState
{
    public class DepartureState : IFlightState
    {
        public DepartureState()
        {
        }

        public void HandleOperation(Flight flightContext)
        {
            Console.WriteLine("{0}: Flight departure", nameof(DepartureState));
            flightContext.FlightState = new OnAirState();
            flightContext.FlightState.HandleOperation(flightContext);

        }
    }
}
