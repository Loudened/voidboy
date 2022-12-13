using DirectoryService.Core.Dto;
using DirectoryService.Shared;

namespace DirectoryService.Api.Models;

public class UserListModel
{
    public UserListModel(PaginatedResponse<UserSearchResultDto> result)
    {
        Users = result.Data!;
    }
    public IEnumerable<UserSearchResultDto> Users { get; set; }
}