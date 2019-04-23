using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SportsStore.Models
{
    public class EFPollingRepository : IPollingRepository
    {
        private ApplicationDbContext context;
        public EFPollingRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Polling> Selection => context.Selection;

        public void SaveVote(Polling polling)
        {
            context.Attach(polling);
        
            var accountInDb = context.Selection.Single(a => a.VoteID == polling.VoteID);
            context.Selection.Add(polling);
            // Update the properties
            context.Entry(accountInDb).CurrentValues.SetValues(polling);
            if (polling.VoteID == 0)
            {
                context.Selection.Add(polling);
            }
            context.SaveChanges();
        }
    }
}