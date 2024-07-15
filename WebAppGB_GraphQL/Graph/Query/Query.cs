using WebAppGB_GraphQL.Abstractions;
using WebAppGB_GraphQL.Dto;

namespace WebAppGB_GraphQL.Graph.Query
{
    public class Query
    {
        //public IEnumerable<ProductDto> GetProducts() => productRepository.GetAllProducts();
        public IEnumerable<ProductDto> GetProducts([Service] IProductRepository repository) =>
            repository.GetProducts();

        public IEnumerable<ProductGroupDto> GetProductGroups([Service] IProductGroupRepository groupRepository) =>
            groupRepository.GetProductGroups();

        public IEnumerable<StorageDto> GetStorageCount([Service] IStorageRepository storageRepository) =>
            storageRepository.GetProductsCountOnStorage();
    }
}
