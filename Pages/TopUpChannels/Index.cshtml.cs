﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prepaid_Mobile_Topup_Core_Web_App.BusinessModel;
using Prepaid_Mobile_Topup_Core_Web_App.Models;

namespace Prepaid_Mobile_Topup_Core_Web_App.Pages.TopUpChannels
{
    public class IndexModel : PageModel
    {
        private readonly Prepaid_Mobile_Topup_Core_Web_App.Models.Prepaid_Mobile_Topup_DataContext _context;

        public IndexModel(Prepaid_Mobile_Topup_Core_Web_App.Models.Prepaid_Mobile_Topup_DataContext context)
        {
            _context = context;
        }

        public IList<TopUpChannel> TopUpChannel { get;set; }

        public async Task OnGetAsync()
        {
            TopUpChannel = await (from channel in _context.TopUpChannel select channel).ToListAsync();
        }
    }
}
