using AkademiPlusCQRS.CQRSPattern.Handlers;
using AkademiPlusCQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusCQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, GetProductByIDQueryHandler getProductByIDQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        public IActionResult GetProduct(int id)
        {
            var values=_getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }
    }
}
