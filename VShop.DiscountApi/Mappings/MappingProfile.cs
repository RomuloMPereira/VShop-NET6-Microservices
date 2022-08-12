using AutoMapper;
using VShop.DiscountApi.DTOs;
using VShop.DiscountApi.Model;

namespace VShop.DiscountApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CouponDTO, Coupon>().ReverseMap();
        }
    }
}
