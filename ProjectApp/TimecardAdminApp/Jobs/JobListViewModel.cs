using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using TimecardRepository.Jobs;
using static TimecardRepository.Jobs.JobMapperExtension;


namespace TimecardAdminApp.Jobs
{
    public class JobListViewModel : BindableBase
    {
        private JobRepository _repo = new JobRepository();


        public JobListViewModel()
        {
            LoadJobs();
        }
        
        private ObservableCollection<Job> _jobs;
        public ObservableCollection<Job> Jobs
        {
            get { return _jobs; }
            set { SetProperty(ref _jobs, value); }
        }

        public void LoadJobs()
        {
            _jobs = new ObservableCollection<Job>(_repo.GetAll().Select(t => t.ToUIModel()));
        }

    }
}

