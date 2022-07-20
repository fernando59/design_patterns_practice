namespace Design_Patterns.MementoPattern
{
    public class Memento
    {
        private string _state;
        public Memento(string state)
        {
            _state = state; 
        }
        public string getState()
        {
            return _state;
        }
    }
}
