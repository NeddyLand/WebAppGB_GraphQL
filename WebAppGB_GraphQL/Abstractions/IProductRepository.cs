using WebAppGB_GraphQL.Dto;

namespace WebAppGB_GraphQL.Abstractions
{
    public interface IProductRepository
    {
        IEnumerable<ProductDto> GetProducts();
        int AddProduct(ProductDto productDto);
        void DeleteProduct(int id);

    }
}
