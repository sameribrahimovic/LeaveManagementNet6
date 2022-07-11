﻿using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            //mapping configuration

            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap(); 
        }
    }
}