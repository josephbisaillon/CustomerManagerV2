using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CustomerManagerV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int currentCustomerID;
        DataTable datatable = new DataTable();



        private void ImportCSV()
        {
            
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Customer Name");
            datatable.Columns.Add("Service Type");
            datatable.Columns.Add("Cost");
            datatable.Columns.Add("Paid");
            datatable.Columns.Add("Comments");

            string[] line = new string[6];

            if (!File.Exists("customerdata.csv"))
            {
                using (File.CreateText("customerdata.csv"));
            }

            using (StreamReader file = new StreamReader("customerdata.csv"))
            {
                while (!file.EndOfStream)
                {
                    string hold = file.ReadLine();
                    line = hold.Split(',');
                    datatable.Rows.Add(line);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImportCSV();

            MainGridView.DataSource = datatable;
            MainGridView.Columns[0].Width = 25;
            MainGridView.Columns[2].Width = 100;
            MainGridView.Columns[3].Width = 60;
            MainGridView.Columns[4].Width = 50;
            MainGridView.Columns[5].Width = 275;
        }

        private void CurrentRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by dragonz2444\nSe7ensins.com\nContribute to this github.com/4jlabs");
        }

        private void SaveNewCSV()
        {
            using (var writer = new StreamWriter("customerdata.csv", false))
            {
                for (int x = 0; x <= MainGridView.RowCount; x++)
                {
                    string fullRow = "";
                    try
                    {
                        foreach (var y in datatable.Rows[x].ItemArray)
                        {
                            fullRow += (y.ToString() + ',');
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (!fullRow.Equals(""))
                         writer.WriteLine(fullRow.TrimEnd(','));
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGridView.EndEdit();
            SaveNewCSV();
            MessageBox.Show("Saved");
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;
                if (CustomerIDTextBox.Text.Contains(",")
                    || CustomerNameTextBox.Text.Contains(",")
                    || ServiceTextBox.Text.Contains(",")
                    || commentsTextBox.Text.Contains(",")
                    || ServiceCostTextBox.Text.Contains(","))
                {
                    MessageBox.Show("Since the file is stored in CSV format\nDo not use commas\nRemove them and for row to be added");
                    error = true;
                }
                string paid = "N";
                if (paidCheckBox.Checked)
                {
                    paid = "Y";
                }

                if (!error)
                {
                    string[] newCustomer = { CustomerIDTextBox.Text, CustomerNameTextBox.Text, ServiceTextBox.Text, ServiceCostTextBox.Text, paid, commentsTextBox.Text }; 
                    datatable.Rows.Add(newCustomer);
                    ClearTextboxes();
                    SaveNewCSV();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inputting row:" + ex.Message);
            }
        }

        private void ClearTextboxes()
        {
            paidCheckBox.Checked = false;
            CustomerIDTextBox.Clear(); 
            CustomerNameTextBox.Clear(); 
            ServiceTextBox.Clear();
            ServiceCostTextBox.Clear(); 
            commentsTextBox.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
