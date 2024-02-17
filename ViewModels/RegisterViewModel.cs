using Batates.Areas.Identity.Pages.Account;
using Batates.Models;
using Batates.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Batates.ViewModels
{
    public class RegisterViewModel : RegisterModel
    {
        public RegisterViewModel(UserManager<ApplicationUser> userManager, IUserStore<ApplicationUser> userStore, SignInManager<ApplicationUser> signInManager, ILogger<RegisterModel> logger, IEmailSender emailSender) : base(userManager, userStore, signInManager, logger, emailSender)
        {
        }

        public string? Fullname { get; set; }
        public Gender? Gender { get; set; }
        public string? ContactNo { get; set; }
        public string? Address { get; set; }
    }
}
