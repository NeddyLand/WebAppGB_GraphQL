using AutoMapper;
using WebAppGB_GraphQL.Abstractions;
using WebAppGB_GraphQL.Data;
using WebAppGB_GraphQL.Dto;
using WebAppGB_GraphQL.Models;

namespace WebAppGB_GraphQL.Repository
{
    public class StorageRepository : IStorageRepository
    {
        Context storageContext;
        private readonly IMapper _mapper;
        public StorageRepository(Context storageContext, IMapper mapper)
        {
            this.storageContext = storageContext;
            this._mapper = mapper;
        }
        public int AddProductOnStorage(StorageDto storageDto)
        {
            var storage = _mapper.Map<Storage>(storageDto);
            storageContext.Storages.Add(storage);
            storageContext.SaveChanges();
            return storage.ID;
        }

        public IEnumerable<StorageDto> GetProductsCountOnStorage()
        {
            return storageContext.Storages.Select(_mapper.Map<StorageDto>).ToList();
        }
    }
}
