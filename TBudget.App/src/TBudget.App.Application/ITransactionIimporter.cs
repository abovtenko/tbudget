using TBudget.App.Domain;

namespace TBudget.App.Application;

public interface ITransactionImporter
{
    List<Transaction> Import(string filePath);
}
