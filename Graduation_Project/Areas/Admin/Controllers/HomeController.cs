using Domain;
using Domain.Models;
using Domain.Services;
using Domain.ViewModels;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utility.Consts;

namespace Graduation_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Admin)]
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private IUserService _userService;
        public HomeController(IUnitOfWork unitOfWork, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
        }


        public async Task<IActionResult> Index()
        {
            // Hangfire
            RecurringJob.AddOrUpdate(() => _unitOfWork.TbAdviceRequests.SaveTotalAdvicesEveryDay(), Cron.Daily);
            RecurringJob.AddOrUpdate(() => _userService.SaveTotlaRegistrationsEveryDay(), Cron.Daily);

            DashboardPageVM model = new();
            model.RegistrationsRequests = await _unitOfWork.TdRegistrationRequests.RegistrationRequestsAsync();
            model.AdvicesRequests = await _unitOfWork.TbAdviceRequests.AdviceRequestsAsync();
            model.AllUsers = await _userService.GetAllUsers().CountAsync();
            model.BlockedUsers = await _userService.GetBlockedUsers().CountAsync();
            model.Advices = await _unitOfWork.TbAdvices.CountAsync();
            model.Diseases = await _unitOfWork.TbDiseases.CountAsync();
            model.TypeOfDiseases = await _unitOfWork.TbDiseaseTypes.CountAsync();
            model.Specializations = await _unitOfWork.TbSpecialization.CountAsync();
            model.Contacts = await _unitOfWork.TbContacts.CountAsync();
            model.LungTransplants = await _unitOfWork.TbLungTransplant.CountAsync();

            return View(model);
        }
    }
}
