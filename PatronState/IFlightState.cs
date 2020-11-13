using System;
namespace PatronState
{
    public interface IFlightState
    {
        void HandleOperation(Flight flightContext);

    }
}
