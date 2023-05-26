using NUnit.Framework;
using System;
using System.IO;
using System.Windows.Forms;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class PurchaseTests
    {
        private Purchase purchaseForm;

        [SetUp]
        public void Setup()
        {
            purchaseForm = new Purchase();
            // Set lblpath.Text to a valid path for testing
            purchaseForm.lblpath.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test_database.accdb");
        }

        [Test]
        public void SupplierResete_ShouldPopulateCmbSupplier()
        {
            // Arrange

            // Act
            purchaseForm.supplierresete();

            // Assert
            Assert.Greater(purchaseForm.cmbSupplier.Items.Count, 0);
        }

        [Test]
        public void ItemResete_ShouldPopulateCmbItemName()
        {
            // Arrange

            // Act
            purchaseForm.itemresete();

            // Assert
            Assert.Greater(purchaseForm.cmbitemname.Items.Count, 0);
        }

        [Test]
        public void Reset_ShouldResetFormFields()
        {
            // Arrange
            purchaseForm.txtinvoiceno.Text = "123";
            purchaseForm.cmbSupplier.Text = "Supplier";
            // Set other fields as needed

            // Act
            purchaseForm.Reset();

            // Assert
            Assert.AreEqual("", purchaseForm.txtinvoiceno.Text);
            Assert.AreEqual("", purchaseForm.cmbSupplier.Text);
            // Assert other fields are reset as well
        }

        [Test]
        public void GetData_ShouldPopulateDataGridViewWithPurchaseDetails()
        {
            // Arrange
            purchaseForm.txtinvoiceno.Text = "1";

            // Act
            purchaseForm.GetData();

            // Assert
            Assert.Greater(purchaseForm.dgwSales.Rows.Count, 0);
        }

        [Test]
        public void InsertInventory_ShouldInsertInventoryRecord()
        {
            // Arrange
            purchaseForm.txtinvoiceno.Text = "1";
            purchaseForm.txtitemno.Text = "1";
            purchaseForm.cmbitemname.Text = "Item 1";
            purchaseForm.txtqty.Text = "10";

            // Act
            purchaseForm.INSERTINVENTORY();

            // Assert
            // Assert the inventory record is inserted correctly
        }

        [Test]
        public void BtnSave_Click_ShouldSavePurchaseInvoice()
        {
            // Arrange
            purchaseForm.txtinvoiceno.Text = "1";
            purchaseForm.dtpDate.Value = DateTime.Now;
            // Set other fields as needed

            // Act
            purchaseForm.btnSave_Click(null, EventArgs.Empty);

            // Assert
            // Assert that the purchase invoice is saved correctly
        }
    }
}
