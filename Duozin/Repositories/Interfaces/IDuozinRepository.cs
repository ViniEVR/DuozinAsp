using Duozin.Models;

namespace Duozin.Repositories.interfaces
{
    public interface IDuozinRepository
    {
        int CalcPercentVictories(MidModel mid);
        MidModel GetWinnerDuozin(List<MidModel> mid);
        MidModel GetWinnerMid(MidModel mid1, MidModel mid2);
        MidModel GetDrawMid(MidModel mid1, MidModel mid2);
        List<MidModel> Match(List<MidModel> mid);
        List<MidModel> OrderByAge(List<MidModel> midId);     
        MidModel UpdateMid(MidModel midWinner, MidModel midLoser);   
    } 
}