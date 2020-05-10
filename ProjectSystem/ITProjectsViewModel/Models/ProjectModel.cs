using System;
using System.Collections.Generic;
using System.Text;


namespace ITProjectsViewModel.Models
{
    public class ProjectModel
    {

        public int      Id          { get; set; }
        public string   Name        { get; set; }
        public string   Concept     { get; set; }
        public int      StageKey    { get; set; }
        public int      StatusKey   { get; set; }

        
        public static ProjectModel ToModel(ITProjectsRepository.ProjectModel repoModel)
        {
            var model = new ProjectModel
            {
                Id = repoModel.Id,
                Name = repoModel.Name,
                Concept = repoModel.Concept,
                StageKey = repoModel.StageKey,
                StatusKey = repoModel.StatusKey
            };

            return model;
        }



        public ITProjectsRepository.ProjectModel ToRepositoryModel()
        {
            var repoModel = new ITProjectsRepository.ProjectModel
            {
                Id = this.Id,
                Name = this.Name,
                Concept = this.Concept,
                StageKey = this.StageKey,
                StatusKey = this.StatusKey
            };

            return repoModel;
        }

    }
}
