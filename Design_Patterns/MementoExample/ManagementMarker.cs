namespace Design_Patterns.MementoExample
{
    public class ManagementMarker
    {

        private List<MementoBook> mementoList = new List<MementoBook> ();

        public void addPositionMarker(MementoBook state)
        {
            mementoList.Add (state);
        }

        public MementoBook getPositionMarker(int index = 0)
        {
            int length = mementoList.Count-1;

            if(index > length) return mementoList[length];


            return mementoList[index];
        }

    }
}
