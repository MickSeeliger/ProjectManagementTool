using MickSeeliger.DB.SQLite;
using ProjectManagementTool.Data.Entities;
using ProjectManagementTool.DataAccess.Access;
using ProjectManagementTool.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool.Data
{
    public class Model
    {
        #region Private Variables
        private ProjectAccess projectAccess;
        #endregion

        #region Constructors
        public Model()
        {
            var databaseFactory = new SQLiteDatabaseFactory("connectionString");
            this.projectAccess = new ProjectAccess(databaseFactory);
        }
        #endregion

        #region Public Methods
        public List<Project> GetAllProjects()
        {
            var projects = new List<Project>();
            foreach (var proj in this.projectAccess.GetAllProjects())
            {
                projects.Add(MapToProject(proj));
            }
            return projects;
        }

        public Project CreateNewProject(string name)
        {
            return MapToProject(this.projectAccess.SaveNewProject(name));
        }
        #endregion

        #region Private Methods
        private Project MapToProject(ProjectEntity projectEntity)
        {
            return new Project()
            {
                Name = projectEntity.Name,
                Description = projectEntity.Description
            };
        }
        #endregion
    }
}
