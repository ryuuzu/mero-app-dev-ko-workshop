using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Application.DTOs;

namespace workshop.Application.Common.Interface
{
    public interface IAuthentication
    {
        Task<ResponseDTO> Register(UserRegisterRequestDTO model);
    }
}
