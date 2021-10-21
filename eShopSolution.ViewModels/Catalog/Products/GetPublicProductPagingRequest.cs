using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.ProductImages
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
