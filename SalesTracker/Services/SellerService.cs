using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesTracker.Data;
using SalesTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Services
{
    public class SellerService
    {
        private readonly SalesTrackerContext _context;

        public SellerService(SalesTrackerContext context)
        {
            _context = context;
        }


        //LIST ALL CLIENTS FROM ONE SELLER
        public async Task<List<Client>> ClientsFromSeller(int id)
        {
            var result = from obj in _context.Clients select obj;
            result = result
                .Where(x => x.SellerId == id);

            return await result
                .ToListAsync();
        }
    }
}
