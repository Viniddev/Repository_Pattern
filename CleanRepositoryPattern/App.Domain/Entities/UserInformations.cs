using App.Domain.Abstractions;
using App.Domain.ViewModel.UserInfo;
using System.Net;

namespace App.Domain.Entities;

public class UserInformations: BaseEntity, IAggregateRoot
{
    //default constructor for EF Core
    public UserInformations() { }
    public UserInformations(RegisterInformation userInformations)
    {
        Name = userInformations.Name;
        Cpf = userInformations.Cpf;
        Rg = userInformations.Rg;
        Email = userInformations.Email;
        Password = userInformations.Password;
        PhoneNumber = userInformations.PhoneNumber;
    }

    public string Name { get; private set; } = string.Empty;
    public string Cpf { get; private set; } = string.Empty;
    public string Rg { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
    public string PhoneNumber { get; private set; } = string.Empty;

    public void Update(RegisterInformation userInformations)
    {
        if (userInformations != null)
        {
            Name = userInformations.Name;
            Cpf = userInformations.Cpf;
            Rg = userInformations.Rg;
            Email = userInformations.Email;
            Password = userInformations.Password;
            PhoneNumber = userInformations.PhoneNumber;
        }
    }
}
