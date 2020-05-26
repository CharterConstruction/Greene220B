using System;
using System.Collections.Generic;
using System.Text;


namespace ITPM.ViewModels.Projects
{
    public class Project
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Concept { get; set; }
        public int StageKey { get; set; }
        public int StatusKey { get; set; }




    }



    public static class ProjectMapper
    {
        public static Project ToDbModel(ITProjectsRepository.Projects.Project repoModel)
        {
            var model = new Project
            {
                Id = repoModel.Id,
                Name = repoModel.Name,
                Concept = repoModel.Concept,
                StageKey = repoModel.StageKey,
                StatusKey = repoModel.StatusKey
            };

            return model;
        }



        public ITProjectsRepository.Projects.Project ToRepositoryModel()
        {
            var repoModel = new ITProjectsRepository.Project
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
