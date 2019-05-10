using MickSeeliger.DB;
using ProjectManagementTool.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool.DataAccess.Access
{
    public class ProjectAccess
    {
        #region Private Variables
        private IDatabaseFactory databaseFactory;
        #endregion

        #region Constructors
        public ProjectAccess(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        #endregion

        #region Public Methods
        public List<ProjectEntity> GetAllProjects()
        {
            return new List<ProjectEntity>();
            // Todo: Lesen.
        }

        public ProjectEntity SaveNewProject(string name)
        {
            return new ProjectEntity() { Name = name };
            // Todo: Speichern.
        }
        #endregion
    }
}
