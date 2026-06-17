using TBudget.App.Domain;

namespace TBudget.App.Application;

public class SaveFileIntention<Transaction>
{
    private readonly IFileSaver<Transaction> _os;
    public List<Transaction> Records {get; set; }
    public string TargetPath {get; set;}


    public SaveFileIntention(IFileSaver<Transaction> os)
    {
        _os = os;
    }

    public bool Save()
    {
        // future errors
        if (string.IsNullOrWhiteSpace(TargetPath))
        {
            return false;
        }

        if (Records == null || !Records.Any())
        {
            return false;
        }

        return _os.Save(TargetPath, Records);
    }
}
