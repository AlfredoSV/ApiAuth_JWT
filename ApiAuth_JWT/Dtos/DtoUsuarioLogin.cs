using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuth_JWT.Dtos
{
    public class DtoUsuarioLogin
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
