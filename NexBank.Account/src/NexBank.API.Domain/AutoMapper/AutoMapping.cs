using AutoMapper;
using NexBank.Domain.Account.DTO;
using NexBank.Domain.Account.Entities;

namespace NexBank.Domain.Account.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<AccountDTO.CreateAccountRequest, AccountEnt>();
        CreateMap<AccountDTO.UpdateAccountRequest, AccountEnt>()
            .ForMember(config => config.AgencyNumber, opt => opt.Ignore())
            .ForMember(config => config.AccountNumber, opt => opt.Ignore());


    }

    private void EntityToResponse()
    {
        CreateMap<AccountEnt, AccountDTO.AccountResponse>();
        CreateMap<AccountEnt, AccountDTO.AccountResponseList>();
    }
}
