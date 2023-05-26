using NUnit.Framework;
using ACCOUNTMANAGEMENT;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class PRODUCTCOMPANYTests
    {
        private PRODUCTCOMPANY form;
        private PRODUCTCREATION productCreationForm;

        [SetUp]
        public void Setup()
        {
            productCreationForm = new PRODUCTCREATION();
            form = new PRODUCTCOMPANY(productCreationForm);
        }

        [Test]
        public void Reset_WhenCalled_ResetsFormFieldsAndPopulatesDataGridViewWithProductCompanyData()
        {
            // Arrange
            // Set up the test by providing a valid lblpath.Text value and connecting to a database with ProductCompany data
            form.lblpath.Text = "path_to_your_database.accdb";

            // Act
            form.Reset();

            // Assert
            Assert.AreEqual(expectedCompanyID, form.lblcompanyid.Text);
            Assert.AreEqual(expectedRowCount, form.dgwCompany.Rows.Count);
            Assert.AreEqual(expectedCompanyName, form.txtCompanyName.Text);
            Assert.IsTrue(form.btnSave.Enabled);
            Assert.IsFalse(form.btnDelete.Enabled);
            Assert.IsFalse(form.btnUpdate.Enabled);
            Assert.IsTrue(form.txtCompanyName.Focused);
            // You can add additional assertions here to verify the contents of the DataGridView and ensure the data is populated correctly.
        }

        [Test]
        public void BtnSave_Click_WhenCalled_SavesProductCompanyDataAndResetsForm()
        {
            // Arrange
            // Set up the test by providing a valid lblpath.Text value and connecting to a database with ProductCompany data
            form.lblpath.Text = "path_to_your_database.accdb";
            form.txtCompanyName.Text = "Test Company";

            // Act
            form.btnSave_Click(null, EventArgs.Empty);

            // Assert
            // Assert that the data was saved to the database
            // You can add assertions here to check the saved data in the database if needed
            Assert.AreEqual(expectedCompanyID, form.lblcompanyid.Text);
            Assert.AreEqual("", form.txtCompanyName.Text);
            Assert.IsTrue(form.btnSave.Enabled);
            Assert.IsFalse(form.btnDelete.Enabled);
            Assert.IsFalse(form.btnUpdate.Enabled);
            Assert.IsTrue(form.txtCompanyName.Focused);
            // You can add additional assertions here to verify the state of the form after saving the data.
        }

        [Test]
        public void BtnUpdate_Click_WhenCalled_UpdatesProductCompanyDataAndResetsForm()
        {
            // Arrange
            // Set up the test by providing a valid lblpath.Text value and connecting to a database with ProductCompany data
            form.lblpath.Text = "path_to_your_database.accdb";
            form.lblcompanyid.Text = "1"; // Set the company ID for the company to update
            form.txtCompanyName.Text = "Updated Company";

            // Act
            form.btnUpdate_Click(null, EventArgs.Empty);

            // Assert
            // Assert that the data was updated in the database
            // You can add assertions here to check the updated data in the database if needed
            Assert.AreEqual(expectedCompanyID, form.lblcompanyid.Text);
            Assert.AreEqual("", form.txtCompanyName.Text);
            Assert.IsTrue(form.btnSave.Enabled);
            Assert.IsFalse(form.btnDelete.Enabled);
            Assert.IsFalse(form.btnUpdate.Enabled);
            Assert.IsTrue(form.txtCompanyName.Focused);
            // You can add additional assertions here to verify the state of the form after updating the data.
        }

               [Test]
        public void BtnDelete_Click_WhenCalled_DeletesProductCompanyDataAndResetsForm()
        {
            // Arrange
            // Set up the test by providing a valid lblpath.Text value and connecting to a database with ProductCompany data
            form.lblpath.Text = "path_to_your_database.accdb";
            form.lblcompanyid.Text = "1"; // Set the company ID for the company to delete

            // Act
            form.btnDelete_Click(null, EventArgs.Empty);

            // Assert
            // Assert that the data was deleted from the database
            // You can add assertions here to check the deleted data in the database if needed
            Assert.AreEqual("", form.lblcompanyid.Text);
            Assert.AreEqual("", form.txtCompanyName.Text);
            Assert.IsTrue(form.btnSave.Enabled);
            Assert.IsFalse(form.btnDelete.Enabled);
            Assert.IsFalse(form.btnUpdate.Enabled);
            Assert.IsTrue(form.txtCompanyName.Focused);
            // You can add additional assertions here to verify the state of the form after deleting the data.
        }

        [Test]
        public void DgwCompany_MouseClick_WhenCalled_PopulatesFormFieldsWithSelectedProductCompanyData()
        {
            // Arrange
            // Set up the test by providing a valid lblpath.Text value and connecting to a database with ProductCompany data
            form.lblpath.Text = "path_to_your_database.accdb";

            // Simulate selecting a row in the DataGridView
            var selectedRow = new DataGridViewRow();
            selectedRow.Cells.AddRange(new DataGridViewCell[]
            {
                new DataGridViewTextBoxCell() { Value = "1" }, // Company ID
                new DataGridViewTextBoxCell() { Value = "Test Company" } // Company Name
            });

            // Act
            form.dgwCompany_MouseClick(null, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

            // Assert
            Assert.AreEqual("1", form.lblcompanyid.Text);
            Assert.AreEqual("Test Company", form.txtCompanyName.Text);
            Assert.IsFalse(form.btnSave.Enabled);
            Assert.IsTrue(form.btnDelete.Enabled);
            Assert.IsTrue(form.btnUpdate.Enabled);
            Assert.IsTrue(form.txtCompanyName.Focused);
            // You can add additional assertions here to verify the state of the form after selecting a row in the DataGridView.
        }

        [Test]
        public void PRODUCTCOMPANY_FormClosed_WhenFormClosed_ResetsProductCreationFormAndFocusesOnCmbCompany()
        {
            // Arrange
            productCreationForm.Show(); // Show the productCreationForm before closing the PRODUCTCOMPANY form

            // Act
            form.PRODUCTCOMPANY_FormClosed(null, new FormClosedEventArgs(CloseReason.UserClosing));

            // Assert
            // Assert that the productCreationForm's method and focus were called
            Assert.IsTrue(productCreationForm.ProductCompanyResetMethodCalled);
            Assert.IsTrue(productCreationForm.CmbCompanyFocused);
        }
    }
}
