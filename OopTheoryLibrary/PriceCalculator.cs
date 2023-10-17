namespace OopTheoryLibrary
{
    public static class PriceCalculator
    {
        public static decimal CalculatePrice(decimal unitPrice, decimal quantity = 1M, decimal vatPercent = 19M)
        {
            return quantity * unitPrice * (vatPercent / 100);
        }
    }
}
