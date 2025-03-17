using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.State1
{
    public class DirectionService
    {


        public IState CurrentState { get; set; }

        public object getEta()
        {
            return CurrentState.getEta();
        }

        public object getDirection()
        {
            return CurrentState.getDirection();
        }

        public TravelMode getTravelMode()
        {
            return CurrentState.travelMode;
        }

        public void setTravelMode(IState state)
        {
            CurrentState = state;
        }
    }

    public enum TravelMode
    {
        DRIVING,
        BICYCLING,
        TRANSIT,
        WALKING
    }

    public abstract class IState
    {
        public abstract object getEta();
        public abstract object getDirection();

        public TravelMode travelMode;
    }


    public class DRIVINGState : IState
    {
        public override object getDirection()
        {
            throw new NotImplementedException();
        }

        public override object getEta()
        {
            throw new NotImplementedException();
        }
    }


}
