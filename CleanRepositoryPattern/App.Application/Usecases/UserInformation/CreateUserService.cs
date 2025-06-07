using App.Domain.Entities;
using App.Domain.Repository;
using App.Domain.Services;
using App.Domain.ViewModel.Response;
using App.Domain.ViewModel.UserInfo;

namespace App.Application.Usecases.UserInformation;

public class CreateUserService(
    IUserInformationsRepository _userInfoRepository,
    IUnitOfWork _unitOfWork
): ICreateUserService
{
    public async Task<BaseResponse<RegisterInformation>> CreateUser(RegisterInformation request, CancellationToken cancellationToken)
    {
        if (request is null)
            return new BaseResponse<RegisterInformation>(null, 500, "Não foi possível registrar o Usuário");

        UserInformations NewUser = new(request);

        await _userInfoRepository.CreateAsync(NewUser, cancellationToken);
        await _unitOfWork.CommitAsync();

        return new BaseResponse<RegisterInformation>(request, 200, "Success."); ;
    }
}
