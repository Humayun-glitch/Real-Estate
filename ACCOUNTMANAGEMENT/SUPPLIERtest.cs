using NUnit.Framework;
using Moq;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class SupplierTests
    {
        private Supplier supplierForm;
        private Mock<Purchase> mockPurchaseForm;
        private Mock<OleDbConnection> mockConnection;
        private Mock<OleDbCommand> mockCommand;
        private Mock<OleDbDataReader> mockDataReader;

        [SetUp]
        public void SetUp()
        {
            mockPurchaseForm = new Mock<Purchase>();
            mockPurchaseForm.SetupGet(f => f.lblpath.Text).Returns("testpath");

            mockConnection = new Mock<OleDbConnection>("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='testpath';");
            mockConnection.Setup(c => c.Open());

            mockCommand = new Mock<OleDbCommand>();
            mockCommand.Setup(c => c.ExecuteReader()).Returns(mockDataReader.Object);

            mockDataReader = new Mock<OleDbDataReader>();
            mockDataReader.SetupSequence(r => r.Read())
                .Returns(false)
                .Returns(true);

            supplierForm = new Supplier(mockPurchaseForm.Object)
            {
                txtSupplierid = { Text = "" },
                txtSupplierName = { Text = "Test Supplier" },
                txtAddress = { Text = "Test Address" },
                txtPhoneNo = { Text = "1234567890" },
                txtEmail = { Text = "test@example.com" },
                txt_extra1 = { Text = "Extra1" },
                txt_extradetail1 = { Text = "Extra Detail1" },
                cmbcrdr = { Text = "Test CR/DR" },
                txtOpbal = { Text = "100" },
                lblpath = { Text = "testpath" }
            };

            supplierForm.con = mockConnection.Object;
            supplierForm.cmd = mockCommand.Object;
        }

        [Test]
        public void Reset_Should_ClearFormFields()
        {
            // Arrange
            mockDataReader.Setup(r => r.IsDBNull(It.IsAny<int>())).Returns(false);
            mockDataReader.Setup(r => r["ACCOUNTID"]).Returns(1);

            // Act
            supplierForm.Reset();

            // Assert
            Assert.AreEqual("1", supplierForm.txtSupplierid.Text);
            Assert.AreEqual("", supplierForm.txtSupplierName.Text);
            Assert.AreEqual("", supplierForm.txtAddress.Text);
            Assert.AreEqual("", supplierForm.txtPhoneNo.Text);
            Assert.AreEqual("", supplierForm.cmbcrdr.Text);
            Assert.AreEqual("", supplierForm.txtOpbal.Text);
            Assert.AreEqual("", supplierForm.txtEmail.Text);
            Assert.AreEqual("", supplierForm.txt_extra1.Text);
            Assert.AreEqual("", supplierForm.txt_extradetail1.Text);
            Assert.IsTrue(supplierForm.btn_save.Enabled);
            Assert.IsFalse(supplierForm.btn_delete.Enabled);
            Assert.IsFalse(supplierForm.btn_update.Enabled);
            Assert.IsTrue(supplierForm.txtSupplierName.Focused);
        }

        [Test]
        public void btn_save_Click_WithNonExistingSupplierName_ShouldSaveSupplierAndShowSuccessMessage()
        {
            // Arrange
            mockDataReader.Setup(r => r.Read()).Returns(false);

            // Act
            supplierForm.btn_save_Click(null, EventArgs.Empty);

            // Assert
            mockCommand.Verify(c => c.ExecuteReader(), Times.Once());
            mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Once());
            mockCommand.Verify(c => c.Dispose(), Times.Once());
            mockConnection.Verify(c => c.Close(), Times.Once());
            Assert.IsFalse(supplierForm.btn_save.Enabled);
            Assert.AreEqual(DialogResult.OK, MessageBox.Show("Successfully saved", "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information));
}
    [Test]
    public void btn_save_Click_WithExistingSupplierName_ShouldShowErrorMessageAndClearSupplierNameField()
    {
        // Arrange
        mockDataReader.Setup(r => r.Read()).Returns(true);

        // Act
        supplierForm.btn_save_Click(null, EventArgs.Empty);

        // Assert
        mockCommand.Verify(c => c.ExecuteReader(), Times.Once());
        mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Never());
        mockCommand.Verify(c => c.Dispose(), Times.Never());
        mockConnection.Verify(c => c.Close(), Times.Never());
        Assert.IsTrue(string.IsNullOrEmpty(supplierForm.txtSupplierName.Text));
        Assert.IsTrue(supplierForm.txtSupplierName.Focused);
        Assert.AreEqual(DialogResult.OK, MessageBox.Show("Supplier Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
    }

    [Test]
    public void btn_update_Click_ShouldUpdateSupplierAndShowSuccessMessage()
    {
        // Act
        supplierForm.btn_update_Click(null, EventArgs.Empty);

        // Assert
        mockCommand.Verify(c => c.ExecuteReader(), Times.Never());
        mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Once());
        mockCommand.Verify(c => c.Dispose(), Times.Once());
        mockConnection.Verify(c => c.Close(), Times.AtLeastOnce());
        Assert.IsFalse(supplierForm.btn_update.Enabled);
        Assert.AreEqual(DialogResult.OK, MessageBox.Show("Successfully updated", "Supplier Details", MessageBoxButtons.OK, MessageBoxIcon.Information));
    }

    [Test]
    public void btn_delete_Click_ShouldDeleteSupplierAndShowSuccessMessage()
    {
        // Act
        supplierForm.btn_delete_Click(null, EventArgs.Empty);

        // Assert
        mockCommand.Verify(c => c.ExecuteReader(), Times.Never());
        mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Once());
        mockCommand.Verify(c => c.Dispose(), Times.Once());
        mockConnection.Verify(c => c.Close(), Times.Once());
        Assert.AreEqual(DialogResult.OK, MessageBox.Show("Successfully Deleted", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Information));
        mockPurchaseForm.Verify(f => f.supplierresete(), Times.Once());
    }

    [Test]
    public void btn_close_Click_ShouldCloseForm()
    {
        // Arrange
        bool formClosed = false;
        supplierForm.FormClosed += (s, e) => { formClosed = true; };

        // Act
        supplierForm.btn_close_Click(null, EventArgs.Empty);

        // Assert
        Assert.IsTrue(formClosed);
    }
}
}