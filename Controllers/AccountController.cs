using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QRMenu.Models;
using QRMenu.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Controllers
{
  //[Authorize( Roles ="Owner")]
    public class AccountController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private AppDBContext db;
        private SignInManager<IdentityUser> signInManager;
        private UserManager<IdentityUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        public AccountController(IWebHostEnvironment hostEnvironment ,AppDBContext _db , SignInManager<IdentityUser> _signInManager , UserManager<IdentityUser> _userManager , RoleManager<IdentityRole> _roleManager)
        {
            _hostEnvironment = hostEnvironment;
            db = _db;
            signInManager = _signInManager;
            userManager = _userManager;
            roleManager = _roleManager;
        }

        [Authorize(Roles = "Owner")]
        public IActionResult Register()
        {
           // ViewBag.AllRole = new SelectList(db.Roles, "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Username,
                    PasswordHash = model.Password,
                    PhoneNumber = model.Mobile,
                    NormalizedUserName = model.FullName ,
             
            };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("UploadImage");
                }
                foreach(var err in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, err.Description);
                }
            }
            return View(model);
        }

        [Authorize(Roles = "Owner")]
        [HttpGet]
        public  IActionResult  UploadImage()
        {
            // Assuming you have a DbContext instance named "_context"
            var userList =   db.Users.ToList();

            ViewBag.UserList = userList;

            // You may also want to pass an empty ImageModel to your view
            // to bind the form fields to a model when submitting.
            var model = new ImageModel();
            return View(model);
            //var users = await userManager.Users.ToListAsync();
             
            //var userList = new SelectList(users, "Id", "UserName");

            //ViewBag.allUsers = userList;

            //return View();

        }
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile imageFile, string userId)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                // Create a unique filename for the image, e.g., using a GUID
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;

                // Determine the path where you want to save the image
                var imagePath = Path.Combine("wwwroot/LogoImages", uniqueFileName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                // Save the image path to the database
                var imageModel = new ImageModel
                {
                    LogoUrl = uniqueFileName,
                    UserId = userId
                };

                db.Images.Add(imageModel);
                await db.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            // Handle invalid file uploads here
            return View();
        }



        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
             return RedirectToAction( "Index" , "Home");
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(); 
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);
                if (result.Succeeded)
                {
                    // Check if the user is in a specific role and redirect accordingly
                    var user = await userManager.FindByNameAsync(model.UserName);
                    if (await userManager.IsInRoleAsync(user, "Owner"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashboard" , new { area = "Administrator" });
                    }
                 
                }
                ModelState.AddModelError(string.Empty, "Invalid  Username or password");
            }

                return View();
        }
         [Authorize(Roles = "Owner")]
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View(); 
        }
        [HttpPost]
        //[Authorize(Roles = "Owner")]
        public async Task<IActionResult>   CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var identityRole = new IdentityRole { 
                Name = model.RoleName 

                };
                var result = await roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("AllRoles", "Account"); 
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(string.Empty , err.Description);
                }
            }
            return View(model);
        }
     
        [HttpGet]
       [Authorize(Roles = "Owner")]
        public  IActionResult  AllRoles()
        {
            var roles =   roleManager.Roles;
            return View(roles);
        }
 
        [HttpGet]
        [Authorize(Roles = "Owner")]
        public async Task<IActionResult> EditRole(string id)
        {
            var r  = await roleManager.FindByIdAsync(id);
            if (r==null)
            {
                return View(NotFound());
            }
            var model = new EditRoleViewModel 
            {
                Id = r.Id,
                RoleName= r.Name
            };

            // call all users 
            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user , r.Name))
                {
                    model.Users.Add(user.UserName);
                }
               
            }

            return View(model);
        }
        [HttpPost]
         [Authorize(Roles = "Owner")]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                return View(NotFound());
            }
            else
            {
                role.Name = model.RoleName;
                var result = await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("AllRoles");
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, err.Description);
                }

            }

            return View(model);
        }
 
        [HttpGet]
       [Authorize(Roles = "Owner")]
        public async Task<IActionResult> AddRemoveUserRole(string id  )
        {
              
            ViewBag.RoleId = id; 
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return View(NotFound());
            }
            ViewBag.RoleName = role.Name; 
            var model = new List<UserRoleViewModel>(); 
            foreach (var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel {
                    UserId = user.Id,
                    UserName = user.UserName  

                };
                if (await userManager.IsInRoleAsync(user , role.Name))
                {
                    userRoleViewModel.IsSelected = true; 
                }
                else
                {
                    userRoleViewModel.IsSelected = false;

                }
                model.Add(userRoleViewModel);
            }


         
           

            // call all users 
       

            return View(model);
        }
        [HttpPost]
         [Authorize(Roles = "Owner")]
        public async Task<IActionResult> AddRemoveUserRole(List<UserRoleViewModel> model , string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                return View(NotFound());
            }
            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;
                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user , role.Name))  )
                {

                    result = await userManager.AddToRoleAsync(user, role.Name); 
                }
                else if (!(model[i].IsSelected )&&  await userManager.IsInRoleAsync(user, role.Name) )
                {

                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
                if (result.Succeeded)
                {
                    return RedirectToAction("AllRoles"); 
                }
            }
            return RedirectToAction("AllRoles");
        }



        [HttpGet]
         [Authorize(Roles = "Owner")]
        public IActionResult AllUsers()
        { 
            var users = userManager.Users;
            return View(users);
        }

        [HttpGet]
        [Authorize(Roles = "Owner")]
        public IActionResult Messages()
        {
            var Msgs = db.Contacts;
            return View(Msgs);
        }

        [HttpGet]
       [Authorize(Roles = "Owner")]

        public async Task<IActionResult> DeleteUser(string? id)
        {
            ViewBag.UserId = id; 
       
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByIdAsync(id);
           
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

       
        [HttpPost]
        [Authorize(Roles = "Owner")]
        public async Task<IActionResult> DeleteUser( UserRoleViewModel model , string idd)
        {
            //var x = ViewBag.UserId;
            var user = await userManager.FindByIdAsync(idd);
            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("AllUsers");
            }
           return NotFound();
           
        }
        [Authorize(Roles = "Owner")]
        public async Task<IActionResult> DeleteMsg(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Msg = await db.Contacts.FirstOrDefaultAsync(m => m.ContactId == id);
            if (Msg == null)
            {
                return NotFound();
            }

            return View(Msg);
        }

         
        [HttpPost]
        [Authorize(Roles = "Owner")]
        public async Task<IActionResult> DeleteMsg(Contact msg, int idd)
        {
            var Msg = await db.Contacts.FindAsync(idd);
            db.Contacts.Remove(Msg);
            await db.SaveChangesAsync();
            return RedirectToAction("Messages");
        }

        [HttpGet]
        [Authorize(Roles = "Owner")]

        public async Task<IActionResult> DeleteRole(string? id)
        {
            ViewBag.RoleId = id;

            if (id == null)
            {
                return NotFound();
            }

            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }


        [HttpPost]
        [Authorize(Roles = "Owner")]
        public async Task<IActionResult> DeleteRole(EditRoleViewModel model, string idd)
        {
            //var x = ViewBag.UserId;
            var role = await roleManager.FindByIdAsync(idd);
            var result = await roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("AllRoles");
            }
            return NotFound();

        }

        private string UploadFile(IFormFile file)
        {
            string filename = null;
            if (file != null)
            {
                string UploadDir = Path.Combine(_hostEnvironment.WebRootPath + "/uploads/", "uploads");
                filename = Guid.NewGuid().ToString() + "-" + file.FileName;
                string filePath = Path.Combine(UploadDir + filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                { file.CopyTo(fileStream); }
            }
            return filename;
        }
    }

}
 
