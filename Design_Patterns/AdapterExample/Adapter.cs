namespace Design_Patterns.AdapterExample
{
    public class Adapter : IAdapter
    {
        CashEuro cashEuro = new CashEuro();

        public double getBalance()
        {
            return Math.Round(cashEuro.getTotalEuros(),2);    
        }


        public void enterPesetas(double pesetas)
        {
            double euros = pesetas / 166.386;
            cashEuro.enterEuros(euros);
        }



        public void withDrawPesetas(double pesetas)
        {
            double euros = pesetas / 166.386;
            cashEuro.withDrawEuros(euros);
        }
    }
}
