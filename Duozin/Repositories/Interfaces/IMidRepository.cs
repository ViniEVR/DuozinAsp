using Duozin.Models;

namespace Duozin.Repositories.interfaces
{
    public interface IMidRepository
    {
        List<MidModel> GetMidList();
        List<MidModel> GetMidsId(IFormCollection ids);
        MidModel GetMidsId(int id);

    }
}