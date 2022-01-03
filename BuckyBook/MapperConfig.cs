using AutoMapper;
using BuckyBook.Models;
using BuckyBook.ViewModels;

namespace BuckyBook
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // what is a mapping configuration 
            // this is what tells auto mapper that it is legal to convert from config A to config B 
            // which is LeaveType to LeaveTypeVM 
            CreateMap<Product, ProductVM>().ReverseMap();
            
        }
    }
}
