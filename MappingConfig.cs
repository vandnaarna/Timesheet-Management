using AutoMapper;
using TimesheetMVC.Models.DTO;

namespace TimesheetMVC
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
           
            CreateMap<ProjectMasterDTO, ProjectMasterCreateDTO>().ReverseMap();
            CreateMap<ProjectMasterDTO, ProjectMasterUpdateDTO>().ReverseMap();
            
            CreateMap<UserMasterDTO, UserMasterCreateDTO>().ReverseMap();
            CreateMap<UserMasterDTO, UserMasterUpdateDTO>().ReverseMap();

            CreateMap<TaskMasterDTO, TaskMasterCreateDTO>().ReverseMap();
            CreateMap<TaskMasterDTO, TaskMasterUpdateDTO>().ReverseMap();
        }
    }
}
