using App.Domain.ViewModel.Response;
using App.Domain.ViewModel.UserInfo;

namespace App.Domain.Services;

public interface ICreateUserService
{
    Task<BaseResponse<RegisterInformation>> CreateUser(RegisterInformation request, CancellationToken cancellationToken);
}
