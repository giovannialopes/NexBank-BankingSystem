using AutoMapper;
using NexBank.API.Domain.DTO;
using NexBank.API.Domain.Entities;

namespace NexBank.API.Domain.AutoMapper;

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
    }

    private void EntityToResponse()
    {
        CreateMap<AccountEnt, AccountDTO.CreateAccountResponse>();
    }
}
