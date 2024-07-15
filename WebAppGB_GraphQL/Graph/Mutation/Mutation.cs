using WebAppGB_GraphQL.Abstractions;
using WebAppGB_GraphQL.Dto;

namespace WebAppGB_GraphQL.Graph.Mutation
{
    public class Mutation
    {
        public int AddProduct([Service] IProductRepository productRepository, ProductDto productDto) => productRepository.AddProduct(productDto);
        public int AddProductGroup([Service] IProductGroupRepository productGroupRepository, ProductGroupDto productGroupDto) =>
            productGroupRepository.AddProductGroup(productGroupDto);
        public int AddProductOnStorage([Service] IStorageRepository storageRepository, StorageDto storageDto) => storageRepository.AddProductOnStorage(storageDto);
    }
}
