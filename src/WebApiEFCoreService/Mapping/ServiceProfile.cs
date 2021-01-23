using AutoMapper;
using WebApiEFCoreRepository.Conditions;
using WebApiEFCoreRepository.DataModels;
using WebApiEFCoreService.Dtos;
using WebApiEFCoreService.InfoModels;

namespace WebApiEFCoreService.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            this.CreateMap<AccountDataModel, AccountDto>()
                .ForMember(x => x.CreateDate, y => y.MapFrom(z => z.CreateDate.ToString("yyyy/MM/dd")))
                .ForMember(x => x.ModifyDate, y => y.MapFrom(z => z.ModifyDate.ToString("yyyy/MM/dd")));

            this.CreateMap<AccountInfoModel, AccountCondition>();
        }
    }
}