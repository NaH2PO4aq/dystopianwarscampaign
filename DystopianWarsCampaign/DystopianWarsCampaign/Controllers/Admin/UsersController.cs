using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using DystopianWarsCampaign.Models;
using DystopianWarsCampaign.ViewModels;

namespace DystopianWarsCampaign.Controllers.Admin
{
    public class UsersController : Controller
    {
        public UsersController()
        {
            applicationDbContext = new ApplicationDbContext();
            dystopianWarsContext = new DystopianCampaignContext();
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(applicationDbContext));
            RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(applicationDbContext));
        }

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            UserManager = userManager;
            RoleManager = roleManager;
        }

        public UserManager<ApplicationUser> UserManager { get; private set; }
        public RoleManager<IdentityRole> RoleManager { get; private set; }
        public ApplicationDbContext applicationDbContext { get; private set; }
        public DystopianCampaignContext dystopianWarsContext { get; private set; }

        //
        // GET: /Users/
        [Authorize]
        public async Task<ActionResult> Index()
        {
            UserViewModel uvm = new UserViewModel();
            uvm.Users = await UserManager.Users.ToListAsync();
            uvm.Factions = await dystopianWarsContext.Factions.ToListAsync();
            return View(uvm);
        }
    }
}