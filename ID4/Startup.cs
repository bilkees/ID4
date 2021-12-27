using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using ID4.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using ID4.Migrations;
using System.Web.Providers.Entities;

[assembly: OwinStartupAttribute(typeof(ID4.Startup))]
namespace ID4
{

    public partial class Startup
    {
        ///ApplicationDbContext context;
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           //////// createRolesandUsers();
        }
    //    private void createRolesandUsers()
    //    {
    //        ApplicationDbContext context = new ApplicationDbContext();
    //        var roleManager = new Microsoft.AspNet.Identity.RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
    //        var UserManager = new Microsoft.AspNet.Identity.UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
    //    }

    //         // In Startup iam creating first Admin Role and creating a default Admin User     
    //        if (!RoleManager.RoleExists("Admin"))    
    //        {    

    //            // first we create Admin rool    
    //            var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
    //    role.Name = "Admin";    
    //            roleManager.Create(role);    

    //            //Here we create a Admin super user who will maintain the website                   

    //            var user = new ApplicationUser();
    //    user.UserName = "Admin";    
    //            User.Email = "admin@gmail.com";    

    //            string userPWD = "oma@123";

    //    var chkUser = UserManager.Create(user, userPWD);    

    //            //Add default User to Role Admin    
    //            if (chkUser.Succeeded)    
    //            {    
    //                var result1 = UserManager.AddToRole(user.Id, "Admin");

    //}
}
}   
    

