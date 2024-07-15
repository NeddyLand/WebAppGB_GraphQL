using WebAppGB_GraphQL.Dto;

namespace WebAppGB_GraphQL.Abstractions
{
    public interface IStorageRepository
    {
        IEnumerable<StorageDto> GetProductsCountOnStorage();
        int AddProductOnStorage(StorageDto storageDto);
    }
}
