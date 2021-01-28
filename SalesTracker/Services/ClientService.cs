using Microsoft.EntityFrameworkCore;
using SalesTracker.Data;
using SalesTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Services
{
    public class ClientService
    {
        private readonly SalesTrackerContext _context;

        public ClientService(SalesTrackerContext context)
        {
            _context = context;
        }


        //LIST ALL VISITS TO ONE CLIENT
        public async Task<List<Visit>> VisitsToClient(int id)
        {
            var result = from obj in _context.Visits select obj;
            result = result
                .Where(x => x.ClientId == id);

            return await result
                .ToListAsync();
        }
    }
}
