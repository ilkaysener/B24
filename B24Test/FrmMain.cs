using B24;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B24Test
{
    public partial class FrmMain : Form
    {
        API B24Api;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCreateApi_Click(object sender, EventArgs e)
        {
            B24Api = new API(txtWebhookURL.Text, int.Parse(txtUserId.Text), txtWebhookKey.Text);
            MessageBox.Show(B24Api.API_URL);
        }

        private void btnGetUserWithId_Click(object sender, EventArgs e)
        {
            B24Core b24Core = new B24Core(B24Api);
            B24Response b24Response = b24Core.GetUserWithID(int.Parse(txtGetUserWithId.Text));
            MessageBox.Show($"{b24Response.UserResult.NAME} {b24Response.UserResult.LAST_NAME}");
        }

        private void btnGetUserWithEmail_Click(object sender, EventArgs e)
        {
            B24Core b24Core = new B24Core(B24Api);
            B24Response b24Response = b24Core.GetUserWithEmail(txtGetUserWithEmail.Text);
            MessageBox.Show($"{b24Response.UserResult.NAME} {b24Response.UserResult.LAST_NAME}");
        }

        private void btnGetProjects_Click(object sender, EventArgs e)
        {
            B24Core b24Core = new B24Core(B24Api);
            //B24Response b24Response = b24Core.GetProjects(chkIsAdmin.Checked);
            B24Response b24Response = b24Core.GetProjectsWithUserId(int.Parse(txtGetUserWithId.Text));
            cmbProjects.Items.Clear();
            foreach (ProjectResult projectResult in b24Response.ProjectResults)
            {
                cmbProjects.Items.Add(projectResult.NAME);
            }
            if (cmbProjects.Items.Count > 0)
            {
                cmbProjects.SelectedIndex = 0;
            }
        }

        private void btnGetTaskWithId_Click(object sender, EventArgs e)
        {
            B24Core b24Core = new B24Core(B24Api);
            B24Response b24Response = b24Core.GetTask(int.Parse(txtGetTaskWithId.Text));
            MessageBox.Show($"{b24Response.TaskResult.Task.Title}");
        }

        private void btnControlTaskWithId_Click(object sender, EventArgs e)
        {
            B24Core b24Core = new B24Core(B24Api);
            b24Core.ControlTask(txtControlTaskWithId.Text);
            MessageBox.Show(b24Core.ControlTask(txtControlTaskWithId.Text).ToString());
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            //List<string> lstAuditors = new List<string>();
            //foreach (string AuditorsId in txtAuidtors.Text.Split(','))
            //{
            //    lstAuditors.Add(AuditorsId);
            //}

            List<object> lstAccomplices = new List<object>();
            foreach (string Accomplices in txtAccomplices.Text.Split(','))
            {
                lstAccomplices.Add(Accomplices);
            }

            B24Core b24Core = new B24Core(B24Api);
            B24Task b24Task = new B24Task
            {
                Result = new TaskResult
                {
                    Task = new B24.Task
                    {
                        Title = txtTitle.Text,
                        Description = txtDescription.Text,
                        StartDatePlan = DateTime.Parse(txtStartDatePlan.Text),
                        Deadline = DateTime.Parse(txtDeadline.Text),
                        Priority = txtPriority.Text,
                        GroupId = txtGroupId.Text,
                        CreatedBy = txtCreatedBy.Text,
                        ResponsibleId = txtResponsibleId.Text,
                        Accomplices = lstAccomplices
                    }
                }
            };
            B24Response b24Response = b24Core.AddTasks(b24Task);
            MessageBox.Show(b24Response.ResponseCode.ToString());
        }

        private void btnCheckApi_Click(object sender, EventArgs e)
        {
            B24Core b24Core = new B24Core(B24Api);
            B24Response b24Response = b24Core.CheckApiKey();
            MessageBox.Show(b24Response.RcResponse.StatusDescription.ToString());
        }
    }
}
