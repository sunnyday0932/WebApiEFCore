using AutoMapper;
using WebApiEFCore.Parameters;
using WebApiEFCore.ViewModles;
using WebApiEFCoreService.Dtos;
using WebApiEFCoreService.InfoModels;

namespace WebApiEFCore.Mapping
{
    public class ControllerProfile : Profile
    {
        public ControllerProfile()
        {
            this.CreateMap<AccountDto, AccountViewModel>();
            this.CreateMap<AccountParameter, AccountInfoModel>();
            this.CreateMap<ResultDto, ResultViewModel>();
        }
    }
}