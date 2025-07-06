namespace DesignPatterns.Behavioral.State.State03
{
    public class StateClient : IClient
    {
        public void Operate()
        {
            var state = new State1();
            var context = new StateContext(state);
            context.KeyDonw();
            context.KeyUp();

            context.SetState(state);
        }
    }

    public interface IState
    {
        void KeyUp();
        void KeyDonw();
    }


    public class State1 : IState
    {

        public void SetContext(StateContext StateContext)
        {

        }

        public void KeyDonw()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }
    }

    public class StateContext
    {
        private IState state;

        public StateContext(IState state)
        {
            this.state = state;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void KeyDonw()
        {
            state.KeyDonw();
        }

        public void KeyUp()
        {
            state.KeyUp();
        }
    }
}
