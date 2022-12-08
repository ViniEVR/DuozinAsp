using Duozin.Models;
using System.Linq;
using Duozin.Repositories.interfaces;

namespace Duozin.Repositories
{
    public class DuozinRepository : IDuozinRepository 
    {

        public int CalcPercentVictories(MidModel mid)
        {
            int percentVictories = 100 * mid.Victories / mid.Fights;
            return percentVictories;
        }

        public MidModel GetDrawMid(MidModel mid1, MidModel mid2)
        {
            if(mid1.MartialArts > mid2.MartialArts)
            {
                return UpdateMid(mid1, mid2);
            } else if (mid2.MartialArts > mid1.MartialArts)
            {
                return UpdateMid(mid2, mid1);
            } else 
            {
                return UpdateMid(mid2, mid1);
            }
        }

        public MidModel GetWinnerMid(MidModel mid1, MidModel mid2)
        {
            int percentMid1 = CalcPercentVictories(mid1);
            int percentMid2 = CalcPercentVictories(mid2);

            if (percentMid1 == percentMid2)
            {
                return GetDrawMid(mid1, mid2);
            } else if (percentMid1 > percentMid2)
            {
                return UpdateMid(mid1, mid2);
            } else {
                return UpdateMid(mid2, mid1);
            }
        }

        public List<MidModel> Match(List<MidModel> mid)
        {
            var midWinners = new List<MidModel>();

            for(int i = 0; i < mid.Count; i+= 2)
            {
                MidModel midWinner = GetWinnerMid(mid[i], mid[i + 1]);
                midWinners.Add(midWinner);
            }
            return midWinners;
        }


        public MidModel GetWinnerDuozin(List<MidModel> mid)
        {
            List<MidModel> winnersMidLane = mid;

            for(int i = 0; i < 4; i++)
            {
                winnersMidLane = Match(winnersMidLane);
            }

            var winnerDuozin = winnersMidLane.FirstOrDefault();

            return winnerDuozin;
        }


        public List<MidModel> OrderByAge(List<MidModel> midId)
        {
            List<MidModel> midsByAge = midId.OrderBy(X => X.Age).ToList();
            return midsByAge;
        } 

  
        public MidModel UpdateMid(MidModel midWinner, MidModel midLoser)
        {
            return midWinner;
        }
    }
}