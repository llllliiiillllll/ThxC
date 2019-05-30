using ThxLivet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThxLivet.Services
{
    interface IRestService
    {
        Task<LoginModel> LogonAsync(LoginModel user);
    }
}