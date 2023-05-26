using System;
using System.Windows.Forms;
using NUnit.Framework;
using ACCOUNTMANAGEMENT;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class LedgerAMTests
    {
        private LEDGERAM ledgerForm;

        [SetUp]
        public void SetUp()
        {
            ledgerForm = new LEDGERAM();
        }

        [Test]
        public void BtnNew_Click_ShouldPopulateCustomerComboBox()
        {
            // Arrange
            ComboBox cmbCustomer = new ComboBox();
            ledgerForm.cmbCustomer = cmbCustomer;

            // Act
            ledgerForm.btn_new_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(ledgerForm.cmbCustomer.Items.Count, cmbCustomer.Items.Count);
            Assert.IsTrue(cmbCustomer.Items.Count > 0);
        }

        [Test]
        public void CmbCustomer_KeyDown_Enter_ShouldSetCustomerAccountId()
        {
            // Arrange
            ComboBox cmbCustomer = new ComboBox();
            Label lblcustid = new Label();
            ledgerForm.cmbCustomer = cmbCustomer;
            ledgerForm.lblcustid = lblcustid;
            ledgerForm.cmbCustomer.Text = "John Doe";

            // Act
            ledgerForm.cmbCustomer_KeyDown(null, new KeyEventArgs(Keys.Enter));

            // Assert
            Assert.AreEqual("John Doe", cmbCustomer.Text);
            Assert.AreEqual("John Doe", ledgerForm.cmbCustomer.Text);
            Assert.AreEqual(lblcustid.Text, ledgerForm.lblcustid.Text);
        }

        [Test]
        public void BtnSearch_Click_ShouldPopulateDataGridView()
        {
            // Arrange
            DataGridView dgvinstallment = new DataGridView();
            ComboBox cmbCustomer = new ComboBox();
            Label lblcustid = new Label();
            ledgerForm.dgvinstallment = dgvinstallment;
            ledgerForm.cmbCustomer = cmbCustomer;
            ledgerForm.lblcustid = lblcustid;
            ledgerForm.lblpath.Text = "path_to_database.accdb";
            cmbCustomer.Text = "John Doe";

            // Act
            ledgerForm.btnSearch_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(dgvinstallment.Rows.Count > 0);
        }
    }
}
