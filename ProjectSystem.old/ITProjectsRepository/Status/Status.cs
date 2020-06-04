using System;
using System.Collections.Generic;

namespace ITPM.Repository.Statuses
{
    public partial class Status
    {
 
        public int      StatusKey { get; set; }
        public string   StatusName { get; set; }
        public string   StatusDescription { get; set; }
        public int      Sequence { get; set; }        
    }


    public static class StatusMapper
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<ITPM.Database.Status, ITPM.Repository.Statuses.Status>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Employee object to Database object ITPM.Database.Status for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.Database.Status ToDbModel(this ITPM.Repository.Statuses.Status repositoryObject)
        {
            return mapper.Map<ITPM.Database.Status>(repositoryObject);
        }

        /// <summary>
        /// Converts ITPM.Database.Status object to TimecardRepository.Models.Employee object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.Repository.Statuses.Status ToRepositoryModel(this ITPM.Database.Status databaseObject)
        {
            return mapper.Map<ITPM.Repository.Statuses.Status>(databaseObject);
        }

    }

}
