using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Application.Common.Interface;
using workshop.Application.DTOs;

namespace workshop.Infrastructure.Services
{
    public class AuthenticationService : IAuthentication
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ResponseDTO> Register(UserRegisterRequestDTO model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
            {
                return new ResponseDTO { Status = "Error", Message = "User already exists!" };

            }

            IdentityUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };

            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                return new ResponseDTO
                {
                    Status = "Error",
                    Message = "User creation failed! Please check user details."
                };
            }
            return new ResponseDTO { Status = "Success", Message = "User created successfully!" };
        }
    }
}
