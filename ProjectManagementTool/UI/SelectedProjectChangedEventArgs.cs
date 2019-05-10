using ProjectManagementTool.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool.UI
{
    public class SelectedProjectChangedEventArgs : EventArgs
    {
        public Project NewProject { get; set; }
    }
}
