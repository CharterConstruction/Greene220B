using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static 

namespace TimecardAdminApp
{
    public class AdminViewModel
    {
        private static TimecardRepository.JobRepository jobRepository = null;
        internal List<TimecardAdminApp.Models.Job> jobs;       

        public AdminViewModel()
        {
            InitializeRepositories();
            LoadJobs();
        }




        internal void InitializeRepositories()
        {
            jobRepository = new TimecardRepository.JobRepository();
        }



        public void LoadJobs()
        {
            jobs = jobRepository.Query().Select(t => t


            //DatabaseManager.Instance.Job.Select(t => t.ToRepositoryModel()).ToList();


        }



    }
}
