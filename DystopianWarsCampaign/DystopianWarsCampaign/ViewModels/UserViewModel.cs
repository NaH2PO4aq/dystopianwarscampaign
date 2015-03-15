using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using DystopianWarsCampaign.Models;

namespace DystopianWarsCampaign.ViewModels
{
    public class UserViewModel
    {
        public List<ApplicationUser> Users;
        public List<Faction> Factions;
    }
}