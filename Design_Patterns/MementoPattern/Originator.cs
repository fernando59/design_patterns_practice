namespace Design_Patterns.MementoPattern
{
    public class Originator
    {

        private string state;
        public void setState(String _state)
        {
           state = _state;
        }

        public String getState()
        {
            return state;
        }

        public Memento saveStateMemento()
        {
            return new Memento(state);
        }

        public void getStateMemento(Memento memento)
        {
            state = memento.getState();

        }




    }
}
