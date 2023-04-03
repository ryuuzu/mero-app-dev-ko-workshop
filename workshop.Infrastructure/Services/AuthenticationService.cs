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

        public Task<ResponseDTO> Register(UserRegisterRequestDTO model)
        {
            throw new NotImplementedException();
        }

    }
}
