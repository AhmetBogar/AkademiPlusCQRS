namespace AkademiPlusCQRS.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Marka { get; set; }
        public string Kategori { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
