using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool.Data.Entities
{
    public class Project
    {
        #region Constructors
        public Project()
            : this(0, "", "")
        {
        }

        public Project(int id, string name, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
        }
        #endregion

        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
