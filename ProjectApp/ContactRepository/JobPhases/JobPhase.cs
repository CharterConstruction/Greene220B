using System;
using System.Collections.Generic;


namespace TimecardRepository.JobPhases
{
    public class JobPhase
    {
        public int PhaseKey { get; set; }
        public int CompanyKey { get; set; }
        public int JobKey { get; set; }
        public string PhaseDivision { get; set; }
        public string PhaseCode { get; set; }
        public string PhaseDescription { get; set; }
        public string PhaseDivCsiDescription { get; set; }
    }


    public static class JobPhaseMapperExtension
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.JobPhase, TimecardRepository.JobPhases.JobPhase>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.JobPhase object to Database object devTimecardDB.JobPhase for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.JobPhase ToDbModel(this TimecardRepository.JobPhases.JobPhase repositoryObject)
        {
            return mapper.Map<devTimecardDB.JobPhase>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.JobPhase object to TimecardRepository.Models.JobPhase object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.JobPhases.JobPhase ToRepositoryModel(this devTimecardDB.JobPhase databaseObject)
        {
            return mapper.Map<TimecardRepository.JobPhases.JobPhase>(databaseObject);
        }


    }

}
