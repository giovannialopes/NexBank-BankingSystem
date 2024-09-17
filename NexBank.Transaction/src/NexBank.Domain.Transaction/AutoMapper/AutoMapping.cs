using AutoMapper;
using NexBank.Domain.Transaction.DTO;
using NexBank.Domain.Transaction.Entities;

namespace NexBank.Domain.Transaction.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<TransactionDTO.CreateTransactionRequest, TransactionEnt>();
        CreateMap<TransactionDTO.TransactionRequest, TransactionEnt>();
    }

    private void EntityToResponse()
    {
        CreateMap<TransactionEnt, TransactionDTO.TransactionResponse>();
    }
}
