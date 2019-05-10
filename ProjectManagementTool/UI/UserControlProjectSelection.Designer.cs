namespace ProjectManagementTool.UI
{
    partial class UserControlProjectSelection
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listBoxProjects, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddProject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProjectName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxProjects
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxProjects, 2);
            this.listBoxProjects.DataSource = this.projectBindingSource;
            this.listBoxProjects.DisplayMember = "Name";
            this.listBoxProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 15;
            this.listBoxProjects.Location = new System.Drawing.Point(3, 3);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(329, 364);
            this.listBoxProjects.TabIndex = 0;
            this.listBoxProjects.SelectedIndexChanged += new System.EventHandler(this.ListBoxProjects_SelectedIndexChanged);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(ProjectManagementTool.Data.Entities.Project);
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.AutoSize = true;
            this.buttonAddProject.Enabled = false;
            this.buttonAddProject.Location = new System.Drawing.Point(215, 373);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(117, 25);
            this.buttonAddProject.TabIndex = 1;
            this.buttonAddProject.Text = "Projekt hinzufügen";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            this.buttonAddProject.Click += new System.EventHandler(this.ButtonAddProject_Click);
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectName.Location = new System.Drawing.Point(3, 373);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(206, 23);
            this.textBoxProjectName.TabIndex = 2;
            this.textBoxProjectName.TextChanged += new System.EventHandler(this.TextBoxProjectName_TextChanged);
            // 
            // UserControlProjectSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlProjectSelection";
            this.Size = new System.Drawing.Size(335, 401);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.TextBox textBoxProjectName;
    }
}
