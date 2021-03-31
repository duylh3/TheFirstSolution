using AppDTO;
using AppServices.Interfaces;
using Repositories.Interfaces;
using AppData;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AppServices
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<UserInfo> _userInforRepository;
        private readonly IMapper _mapper; 

        public UserInfoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userInforRepository = unitOfWork.UserInfoRepository;
            _mapper = mapper;
        }

        public UserInfoDTO CreateUserInfo(UserInfoDTO userInfoDTO)
        {
            var userInfo = _userInforRepository.Add(_mapper.Map<UserInfo>(userInfoDTO));
            _unitOfWork.Commit();

            return _mapper.Map<UserInfoDTO>(userInfo);
        }

        public IEnumerable<UserInfoDTO> GetAll()
        {
            var userInfo = _userInforRepository.GetAll();

            return _mapper.Map<IEnumerable<UserInfoDTO>>(userInfo);
        }
    }
}
