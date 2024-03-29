﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentsJournalCore.DTOService.Services.Users;
using StudentsJournalCore.Models.Auth;
using StudentsJournalCore.Utils;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using StudentsJournalCore.Database.Entities;

namespace StudentsJournalCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        UsersService usersService;

        public AuthController(UsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginViewModel viewModel)
        {
            var identity = GetIdentity(viewModel.Login, viewModel.Password);
            if (identity is null)
                return BadRequest(new { errorText = "Invalid username or password." });

            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromSeconds(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new JsonResult(new
            {
                access_token = encodedJwt,
                username = identity.Name
            });
        }

        private ClaimsIdentity GetIdentity(string login, string password)
        {
            var person = usersService.GetUserByLoginData(login, password).Result;
            if (person is null)
                return null;

            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, person.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, Enum.GetName(typeof(User.AuthRole), person.Role))
            };

            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity;
        }
    }
}
