using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using OOPLab13._1.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace OOPLab13._1.Controllers
{

    public class HomeController : Controller
    {
        private ClientContext cdb;
        private UserContext udb;
        public HomeController(ClientContext ccontext, UserContext ucontext)
        {
            cdb = ccontext;
            udb = ucontext;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(Client client)
        {
            cdb.Clients.Add(client);
            cdb.SaveChanges();
            if (ModelState.IsValid)
            {
                return View("Thanks", client);
            }
            else return View();
        }

        public ViewResult ListResponses()
        {
            return View(cdb.Clients.OrderBy(c => c.Name).ToList());
        }




        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                User us = await udb.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
                var foundEmail = udb.Users.FirstOrDefault(u => u.Email == user.Email);
                var foundLogin = udb.Users.FirstOrDefault(u => u.Login == user.Login);

                if (us == null)
                {
                    if (foundLogin != null)
                    {
                        ModelState.AddModelError("", $"Login {user.Login} is already used!");
                        return View();
                    }

                    us = new User { Email = user.Email, Login = user.Login, Password = user.Password };
                    Role userRole = await udb.Roles.FirstOrDefaultAsync(r => r.Login == "user");
                    if (userRole != null)
                    {
                        us.Role = userRole;
                    }

                    // добавляем пользователя в бд
                    udb.Users.Add(us);

                    await udb.SaveChangesAsync();

                    await Authenticate(us); // аутентификация

                    return RedirectToAction("Forum", "Home");
                }
                else if (foundEmail != null)
                {
                    ModelState.AddModelError("", $"Email {user.Email} is already used!");
                    return View();
                }
                else
                    ModelState.AddModelError("", "Invalid email or password");
            }
            return View(user);
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                User us = await udb.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Login == user.Login && u.Password == user.Password);

                if (us != null)
                {
                    await Authenticate(us);
                    return RedirectToAction("Forum", "Home");

                }
                if (us == null)
                {
                    ModelState.AddModelError("", "No such user");
                }
                else
                    ModelState.AddModelError("", "Invalid login or password");
            }
            return View(user);
        }



        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Login)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        //[Authorize(Roles = "admin")]
        public ViewResult UsersList()
        {
            return View(udb.Users.OrderBy(u => u.Login).ToList());
        }


        public ViewResult Forum()
        {
            if (ModelState.IsValid)
            {
                var query = udb.Comments.AsEnumerable().OrderByDescending(b => b.CommentDate).ToList();
                ViewBag.Comments = query;
                foreach (var item in query)
                    udb.Entry(item).Reference(p => p.User).Load();
            }
            return View();

        }

        [HttpGet]
        public ViewResult Publish()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Publish(Comment comment)
        {
            if (ModelState.IsValid)
            {
                Comment found = udb.Comments.FirstOrDefault(u => u.CommentText == comment.CommentText);
                found = new Comment { Login = User.Identity.Name, CommentText = comment.CommentText, CommentDate = comment.CommentDate };
                // добавляем комментарий в бд
                udb.Comments.Add(found);

                udb.SaveChanges();
                return RedirectToAction("Forum", "Home");

            }
            return View(comment);

        }

        public ActionResult HideComment(int id)
        {
            Comment comment = udb.Comments.Find(id);
            if (comment != null)
            {
                comment.Hidden = !comment.Hidden;
                udb.SaveChanges();
            }
            return RedirectToAction("Forum", "Home");
        }


        [HttpGet]
        public ActionResult EditComment(int id)
        {
            Comment comment = udb.Comments.Find(id);
            return View(comment);
            
        }
        [HttpPost]
        public ActionResult EditComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                udb.Entry(comment).State = EntityState.Modified;
                udb.SaveChanges();
                return RedirectToAction("Forum");
            }
            return View(comment);
        }



        public ActionResult DeleteComment(int id)
        {
            Comment comment = udb.Comments.Find(id);
            if (comment != null) { 

                udb.Comments.Remove(comment);

                udb.SaveChanges();
            }
            return RedirectToAction("Forum", "Home");
        }


    }
}
