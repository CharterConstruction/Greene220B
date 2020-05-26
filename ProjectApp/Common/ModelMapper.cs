using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Common
{
    /// <summary>
    /// Generic model mapper D = Database class, R = Repository class.
    /// DOES NOT APPEAR TO WOOOOORKKKKK
    /// STACK OVERFLOW
    /// </summary>
    /// <typeparam name="D"></typeparam>
    /// <typeparam name="R"></typeparam>
    
    [Obsolete("Doesn't work - don't use")]
    public static class ModelMapper<D, R>
    //where TRepo : TimecardRepository.Interfaces.IDataRepository<T>
    {
        public static MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<D, R>().ReverseMap());
        public static IMapper mapper = mapperConfig.CreateMapper();


        /// <summary>
        /// Converts TimecardRepository.Models.R object to Database object devTimecardDB.D for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static D ToDbModel(R repositoryObject)
        {
            var output = new object();
            output = mapper.Map<D>(repositoryObject);
            return (D)output;

            //return mapper.Map<D>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.D object to TimecardRepository.Models.R object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static R ToRepositoryModel(D databaseObject)
        {
            var output = new object();
            output = mapper.Map<R>(databaseObject);
            return (R)output;

            //return mapper.Map<R>(databaseObject);
        }
    }
}
