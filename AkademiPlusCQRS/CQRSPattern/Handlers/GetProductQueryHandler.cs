using AkademiPlusCQRS.CQRSPattern.Results;
using AkademiPlusCQRS.DAL;
using System.Reflection.Metadata;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x =>
            new GetProductQueryResult
            {
                Marka = x.Brand,
                Kategori = x.Category,
                Name = x.Name,
                Price = x.Price,
                ProductID = x.ProductID,
                Stock = x.Stock
            }).ToList();
            return values;
        }
    }
}
