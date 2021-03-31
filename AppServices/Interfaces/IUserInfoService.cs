using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppServices.Interfaces
{
    public interface IUserInfoService
    {
        UserInfoDTO CreateUserInfo(UserInfoDTO userInfoDTO);

        IEnumerable<UserInfoDTO> GetAll();
    }
}
