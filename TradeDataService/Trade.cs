using System;

namespace TradeDataService
{
    public class Trade
    {
        public string Counterparty { get; set; }

        public string Isin { get; set; }

        public string CountryOfIssue { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Boolean Filter => true;
    }
}
