using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;

namespace BLL;

public class MapperConfig
{
    static MapperConfiguration cfg = new MapperConfiguration(cfg => {
        cfg.CreateMap<User,UserDTO>().ReverseMap();
        
        cfg.CreateMap<Student,StudentDTO>().ReverseMap();
        cfg.CreateMap<Student,StudentCourseRegistrationDTO>().ReverseMap();
        
        cfg.CreateMap<Instructor,InstructorDTO>().ReverseMap();
        cfg.CreateMap<Instructor,InstructorCouresDTO>().ReverseMap();
        
        cfg.CreateMap<CourseRegistration,CourseRegistrationDTO>().ReverseMap();
        
        cfg.CreateMap<Course,CourseDTO>().ReverseMap();
        cfg.CreateMap<Course,CourseRegistrationCourseDTO>().ReverseMap();
    });
    public static Mapper GetMapper() { 
        return new Mapper(cfg);
    }
}