using AutoMapper;
using NexBank.Domain.Login.DTO;
using NexBank.Domain.Login.Entities;

namespace NexBank.Domain.Login.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<LoginDTO.CreateLoginRequest, LoginEnt>();
        CreateMap<LoginDTO.LoginRequest, LoginEnt>();
    }

    private void EntityToResponse()
    {
        CreateMap<LoginEnt, LoginDTO.LoginResponse>();
    }
}
