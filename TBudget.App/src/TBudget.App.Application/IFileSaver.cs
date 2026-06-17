using TBudget.App.Domain;

namespace TBudget.App.Application;

public interface IFileSaver<T>
{
    bool Save(string filePath, List<T> items);
}
