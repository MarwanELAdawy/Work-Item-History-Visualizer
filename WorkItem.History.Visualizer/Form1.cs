using System.Diagnostics;
using Microsoft.TeamFoundation.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace WorkItem.History.Visualizer
{
    public partial class Form1 : Form
    {
        // Variables I want to use globally
        //private static TfsTeamProjectCollection _tfs;
        //private static ProjectInfo _selectedTeamProject;
        //private static WorkItemStore _wis;

        public Form1()
        {
            InitializeComponent();
        }

        // Connect to TFS Using Team Project Picker
        //public static void ConnectToTfsUsingTeamProjectPicker()
        //{
        //    // The  user is allowed to select only one project
        //    var tfsPp = new TeamProjectPicker(TeamProjectPickerMode.SingleProject, false);

        //    tfsPp.ShowDialog();

        //    // The TFS project collection
        //    _tfs = tfsPp.SelectedTeamProjectCollection;

        //    if (tfsPp.SelectedProjects.Any())
        //    {
        //        //  The selected Team Project
        //        _selectedTeamProject = tfsPp.SelectedProjects[0];
        //    }
        //}

        //public Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem GetWorkItemDetails(int id)
        //{
        //    _wis = _tfs.GetService<WorkItemStore>();

        //    return _wis.GetWorkItem(id);
        //}

        /// <summary>
        /// This method takes a work item id, generates a datatable with all revision fields.
        /// </summary>
        //public void GetWorkItemHistory(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem wi)
        //{
        //    var dataTable = new DataTable();

        //    //foreach (Field field in wi.Fields)
        //    //{
        //    //    dataTable.Columns.Add(field.Name);
        //    //}

        //    //foreach (Revision revision in wi.Revisions)
        //    //{
        //    //    var row = dataTable.NewRow();
        //    //    foreach (Field field in wi.Fields)
        //    //    {
        //    //        row[field.Name] = revision.Fields[field.Name].Value;
        //    //    }
        //    //    dataTable.Rows.Add(row);
        //    //}

        //    dgWiHistory.DataSource = dataTable;
        //    dgWiHistory.AutoGenerateColumns = true;

        //    // List of fields to ignore in comparison
        //    var visualize = new List<string>()
        //        {
        //            "Title",
        //            "State",
        //            "Rev",
        //            "Reason",
        //            "Iteration Path",
        //            "Assigned To",
        //            "Effort",
        //            "Area Path"
        //        };

        //    // Debug.Write(String.Format("Work Item: {0}{1}", wi.Id, Environment.NewLine));
        //    lstVisualizer.Items.Add(String.Format("Work Item: {0}{1}", wi.Id, Environment.NewLine));

        //    // Compare Two Work Item Revisions 
        //    for (var i = 0; i < dgWiHistory.RowCount; i++)
        //    {
        //        var currentRow = dgWiHistory.Rows[i];

        //        if (i + 1 < dgWiHistory.RowCount)
        //        {
        //            var currentRowPlus1 = dgWiHistory.Rows[i + 1];

        //            // Debug.Write(String.Format("Comparing Revision {0} to {1} {2}", i, i + 1, Environment.NewLine));
        //            lstVisualizer.Items.Add(String.Format("Comparing Revision {0} to {1} {2}", i, i + 1,
        //                                                  Environment.NewLine));

        //            bool title = false;

        //            for (int j = 0; j < currentRow.Cells.Count; j++)
        //            {
        //                if (!title)
        //                {
        //                    //Debug.Write(
        //                    //    String.Format(String.Format("Changed By '{0}' On '{1}'{2}", currentRow.Cells["Changed By"].Value,
        //                    //                                currentRow.Cells["Changed Date"].Value, Environment.NewLine)));

        //                    lstVisualizer.Items.Add(
        //                        String.Format(String.Format("Changed By '{0}' On '{1}'{2}",
        //                                                    currentRow.Cells["Changed By"].Value,
        //                                                    currentRow.Cells["Changed Date"].Value, Environment.NewLine)));
        //                    title = true;
        //                }

        //                if (visualize.Contains(dataTable.Columns[j].ColumnName))
        //                {
        //                    if (currentRow.Cells[j].Value.ToString() != currentRowPlus1.Cells[j].Value.ToString())
        //                    {
        //                        //Debug.Write(String.Format("[{0}]: '{1}' => '{2}' {3}", dataTable.Columns[j].ColumnName,
        //                        //                          currentRow.Cells[j].Value, currentRowPlus1.Cells[j].Value,
        //                        //                          Environment.NewLine));
        //                        lstVisualizer.Items.Add(String.Format("[{0}]: '{1}' => '{2}' {3}",
        //                                                              dataTable.Columns[j].ColumnName,
        //                                                              currentRow.Cells[j].Value,
        //                                                              currentRowPlus1.Cells[j].Value,
        //                                                              Environment.NewLine));
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to TFS
                ConnectToTfsUsingTeamProjectPicker();

                // Enter a valid work item Id
                if (string.IsNullOrEmpty(tbWorkItemId.Text))
                {
                    throw new Exception("Enter a valid Work Item Id");
                }

                // Get the history
               // GetWorkItemHistory(GetWorkItemDetails(Convert.ToInt32(tbWorkItemId.Text.Trim())));
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Work Item Visualizer", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void lstVisualizer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
