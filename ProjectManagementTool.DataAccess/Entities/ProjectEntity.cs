using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool.DataAccess.Entities
{
    public class ProjectEntity
    {
        #region Constructors
        public ProjectEntity()
        {
        }
        #endregion

        #region Properties
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
