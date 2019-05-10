using ProjectManagementTool.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementTool
{
    public partial class FormMain : Form
    {
        private Model model;

        public FormMain(Model model)
        {
            this.model = model;
            
            InitializeComponent();

            this.userControlProjectSelection.Model = model;
            this.userControlProjectSelection.SelectedProjectChanged += UserControlProjectSelection_SelectedProjectChanged;
        }

        #region Events
        private void UserControlProjectSelection_SelectedProjectChanged(object sender, UI.SelectedProjectChangedEventArgs e)
        {
            textBoxProjectName.Text = e.NewProject.Name;
            // UserControlProjectInformation.ChangeSelectedProject(e.NewProject);
        } 
        #endregion
    }
}
