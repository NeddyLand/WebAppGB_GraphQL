using WebAppGB_GraphQL.Dto;

namespace WebAppGB_GraphQL.Abstractions
{
    public interface IProductGroupRepository
    {
        IEnumerable<ProductGroupDto> GetProductGroups();
        int AddProductGroup(ProductGroupDto productGroupDto);
        void DeleteProductGroups(int id);
    }
}
