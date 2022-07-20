namespace Design_Patterns.AdapterExample
{
    public class CashEuro
    {

        private double euros = 0;


        public double getTotalEuros()
        {
            return euros;
        }

        public void withDrawEuros(double _euros)
        {
            euros -= _euros;
        }

        public void enterEuros(double _euros)
        {
            euros += _euros;
        }
    }
}
