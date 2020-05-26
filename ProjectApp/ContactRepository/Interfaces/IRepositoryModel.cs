using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;


//why doesn't this work?

namespace TimecardRepository.Interfaces
{
    /// <summary>
    /// Enforces conversion methods
    /// </summary>
    public interface IRepositoryModel<R,D>
    {
        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static MapperConfiguration mapperConfig;         // = new MapperConfiguration(cfg => cfg.CreateMap<D, R>().ReverseMap());
        public static IMapper mapper;                           // = mapperConfig.CreateMapper();
   
        public D ToDbModel(R repositoryObject)
        {
            return mapper.Map<D>(repositoryObject);
        }

        public  R ToRepositoryModel(D databaseObject)
        {
            return mapper.Map<R>(databaseObject);
        }
    }
}
