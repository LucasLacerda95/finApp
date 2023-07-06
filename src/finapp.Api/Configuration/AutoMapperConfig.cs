
using AutoMapper;
using finapp.Api.ViewModel;
using finapp.Business.Models;

namespace finapp.Api.Configuration{

    public class AutomapperConfig : Profile{

        public AutomapperConfig(){
           
           CreateMap<Account, AccountViewModel>().ReverseMap();

        }
    }
}