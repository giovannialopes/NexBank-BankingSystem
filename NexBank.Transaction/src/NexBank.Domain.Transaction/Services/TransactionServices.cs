using AutoMapper;
using NexBank.Domain.Transaction.DTO;
using NexBank.Domain.Transaction.Entities;
using NexBank.Domain.Transaction.Repositories;

namespace NexBank.Domain.Transaction.Services;

public class TransactionServices(ITransactionRepository repository,
     IMapper mapper) : ITransactionServices
{
    public async Task<string?> CreateLogin(TransactionDTO.CreateTransactionRequest request)
    {
        var User = mapper.Map<TransactionEnt>(request);

        repository.AddUser(User);

        await repository.Commit();

        return "Usuário Criado";
    }

    public async Task<string?> DeleteLogin(int id)
    {

    }

    public async Task<TransactionDTO.TransactionResponse?> GetLogin(TransactionDTO.TransactionRequest request)
    {

    }
}
