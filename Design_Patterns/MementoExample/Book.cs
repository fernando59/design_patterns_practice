namespace Design_Patterns.MementoExample
{
    public class Book
    {

        private int current_page;
        public void goPage(int page)
        {
           current_page = page;
        }


        public int getPage()
        {
            return current_page;
        }

        public MementoBook saveMarker()
        {
            return new MementoBook(current_page);
        }

        public void recoveryPage(MementoBook m)
        {
            current_page = m.getMarkerPage();

        }

    



    }
}
