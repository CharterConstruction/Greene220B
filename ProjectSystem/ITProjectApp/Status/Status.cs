using System;
using System.Collections.Generic;

namespace ITPM.App.Statuses
{
    using System.Linq;

    public class Status
    {
 
        public int      StatusKey { get; set; }
        public string   StatusName { get; set; }
        public string   StatusDescription { get; set; }
        public int      Sequence { get; set; }



        public Status()
        {
            
        }

        public Status Clone()
        {
            return (Status)MemberwiseClone();
        }

    }





    /*
    public class Status : BindableBase
    {
        private int _statusKey;
        public int StatusKey
        {
            get { return _statusKey; }
            set { SetProperty(ref _statusKey, value); }
        }

        private string _statusName;
        public string StatusName
        {
            get { return _statusName; }
            set { SetProperty(ref _statusName, value); }
        }


        private string _statusDescription;
        public string StatusDescription
        {
            get { return _statusDescription; }
            set { SetProperty(ref _statusDescription, value); }
        }

        private int _sequence;
        public int Sequence
        {
            get { return _sequence; }
            set { SetProperty(ref _sequence, value); }
        }
    }

    */



    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class StatusMapper
    {
        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<ITPM.Repository.Statuses.Status, ITPM.App.Statuses.Status>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Project object to Database object ITPM.Repository.Statuses.Status for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.Repository.Statuses.Status ToRepositoryModel(this ITPM.App.Statuses.Status appObject)
        {
            return mapper.Map<ITPM.Repository.Statuses.Status>(appObject);
        }

        /// <summary>
        /// Converts ITPM.Repository.Statuses.Status object to TimecardRepository.Models.Project object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.App.Statuses.Status ToUIModel(this ITPM.Repository.Statuses.Status repositoryObject)
        {
            return mapper.Map<ITPM.App.Statuses.Status>(repositoryObject);
        }

    }

}
