using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementTool.Data;
using ProjectManagementTool.Data.Entities;

namespace ProjectManagementTool.UI
{
    public partial class UserControlProjectSelection : UserControl
    {
        #region Private Variables
        private BindingList<Project> projects = new BindingList<Project>();
        #endregion

        #region Constructors
        public UserControlProjectSelection()
        {           
            InitializeComponent();
            this.projectBindingSource.DataSource = projects;
        }
        #endregion

        #region Properties
        public Model Model { get; set; }
        #endregion

        #region Public Methods
        public void FillProjects(List<Project> projects)
        {
            this.projects = new BindingList<Project>(projects);
        }
        #endregion

        #region Listbox Events
        private void ListBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBoxProjects.SelectedItem as Project;
            if (selectedItem != null)
            {
                var args = new SelectedProjectChangedEventArgs();
                args.NewProject = selectedItem;
                OnSelectedProjectChanged(args);
            }
        }
        #endregion

        #region Button Events
        private void ButtonAddProject_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxProjectName.Text))
            {
                var newProject = Model.CreateNewProject(textBoxProjectName.Text);
                this.projects.Add(newProject);                
            }
        }
        #endregion

        #region Textbox Events
        private void TextBoxProjectName_TextChanged(object sender, EventArgs e)
        {
            buttonAddProject.Enabled = !String.IsNullOrWhiteSpace(textBoxProjectName.Text);
        }
        #endregion

        #region Own Events
        protected void OnSelectedProjectChanged(SelectedProjectChangedEventArgs e)
        {
            SelectedProjectChanged?.Invoke(this, e);
        }

        public event EventHandler<SelectedProjectChangedEventArgs> SelectedProjectChanged;
        #endregion       
    }
}
