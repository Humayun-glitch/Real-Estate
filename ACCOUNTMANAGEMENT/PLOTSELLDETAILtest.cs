using NUnit.Framework;
using ACCOUNTMANAGEMENT;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class PLOTSELLDETAILTests
    {
        private PLOTSELLDETAIL form;

        [SetUp]
        public void Setup()
        {
            form = new PLOTSELLDETAIL();
        }

        [Test]
        public void LoadGrid_WhenCalled_PopulatesDataGridViewWithPlotSellData()
        {
            // Arrange
            // Set up the test by providing a valid lblpath.Text value and connecting to a database with PlotSell data
            form.lblpath.Text = "path_to_your_database.accdb";

            // Act
            form.loadgrid();

            // Assert
            Assert.AreEqual(expectedRowCount, form.dgvinstallment.Rows.Count);
            // You can add additional assertions here to verify the contents of the DataGridView and ensure the data is populated correctly.
        }

        [Test]
        public void BtnSearch_Click_WhenCalled_PopulatesDataGridViewWithFilteredPlotSellData()
        {
            // Arrange
            // Set up the test by providing a valid lblpath.Text value and connecting to a database with PlotSell data
            form.lblpath.Text = "path_to_your_database.accdb";
            form.dtpDateFrom.Value = new DateTime(2023, 5, 1);
            form.dtpDateTo.Value = new DateTime(2023, 5, 31);

            // Act
            form.btnSearch_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(expectedRowCount, form.dgvinstallment.Rows.Count);
            // You can add additional assertions here to verify the contents of the DataGridView and ensure the data is filtered correctly.
        }
    }
}
