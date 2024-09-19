using AutoMapper;
using NexBank.Domain.Transaction.DTO;
using NexBank.Domain.Transaction.Entities;
using NexBank.Domain.Transaction.Repositories;

namespace NexBank.Domain.Transaction.Services;

public class TransactionServices(ITransactionRepository repository,
     IMapper mapper) : ITransactionServices
{
    public async Task<TransactionDTO.TransactionResponse?> GetTransactionById(int id)
    {
        var Transaction = await repository.GetTransactionById(id);
        if (Transaction != null) 
        {
            return mapper.Map<TransactionDTO.TransactionResponse>(Transaction);
        }
        return default;
    }

    public async Task<TransactionDTO.TransactionResponse?> RegisterTransaction(TransactionDTO.RegisterTransactionRequest request)
    {
        var Transaction = mapper.Map<TransactionEnt>(request);

        repository.AddTransaction(Transaction);

        await repository.Commit();

        return mapper.Map<TransactionDTO.TransactionResponse>(Transaction);

    }
}
