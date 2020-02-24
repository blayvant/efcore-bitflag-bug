using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreBitflagBug
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var db = new LeadsDbContext())
            {
                var downloadLead = new Lead{ LeadType = LeadType.Download };
                var productLead = new Lead { LeadType = LeadType.Product };
                var leads = new List<Lead> { downloadLead, productLead };
                await db.AddRangeAsync(leads);
                await db.SaveChangesAsync();

                var sumLeadTypes = (int)LeadType.Download + (int)LeadType.Product;
                var matchingLeads = db.Leads
                    .Where(l => (sumLeadTypes & (int)l.LeadType) == (int)l.LeadType)
                    .ToList();
            }
        }
    }
}
