namespace Design_Patterns.MementoExample
{
    public class MementoBook
    {
        private int _state;
        public MementoBook(int state)
        {
            _state = state; 
        }

        public void setMarketPage(int state)
        {
            _state = state;
        }
        public int getMarkerPage()
        {
            return _state;
        }


    }
}
