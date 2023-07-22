using DirectoryService.Core.Entities;

namespace DirectoryService.Core.RepositoryInterfaces;

public interface IDomainRepository : IBaseRepository<Domain>
{
    public Task<Domain?> FindByName(string name);
    public Task<List<Domain>> GetDomains();
}