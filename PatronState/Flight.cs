using System;
namespace PatronState
{
    public class Flight
    {
        private IFlightState _flightState;
        public Flight()
        {
            _flightState = new ReadyToFlightState();
        }

        public IFlightState FlightState
        {
            get
            {
                return _flightState;
            }
            set
            {
                _flightState = value;
            }
        }



        public void Fligth()
        {
            Console.WriteLine("Flight # is getting ready to departure.");
            _flightState = new DepartureState();
            _flightState.HandleOperation(this);

        }

    }
}
