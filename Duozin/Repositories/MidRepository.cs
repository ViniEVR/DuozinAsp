using Duozin.Repositories.interfaces;
using Duozin.Data;
using Microsoft.EntityFrameworkCore;
using Duozin.Models;

namespace Duozin.Repositories
{
    public class MidRepository : IMidRepository
    {
        private readonly DataBaseContext _dbContext;
        private readonly DbSet<MidModel> _dbSet;

        public MidRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<MidModel>();
        }
        
        public List<MidModel> GetMidList()
        {
            return _dbContext.MidModels.ToList();
        }

        public List<MidModel> GetMidsId(IFormCollection ids)
        {
            List<MidModel> mids = new List<MidModel>();

            foreach(var id in ids)
            {
                mids.Add(_dbSet.Find(Convert.ToInt32(id.Key)));
            }
            return mids;
        }

        public MidModel GetMidsId(int id)
        {
            var midId = _dbSet.Find(id);

            return midId;
        }
    }
}