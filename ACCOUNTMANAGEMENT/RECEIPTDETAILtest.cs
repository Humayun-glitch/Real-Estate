using NUnit.Framework;
using System;

namespace ACCOUNTMANAGEMENT.UnitTests
{
    [TestFixture]
    public class ReceiptTests
    {
        private RECEIPT receipt;

        [SetUp]
        public void SetUp()
        {
            receipt = new RECEIPT();
        }

        [Test]
        public void Reset_ShouldResetFormFields()
        {
            // Arrange

            // Act
            receipt.Reset();

            // Assert
            // Add assertions to verify that the form fields are reset correctly
        }

        [Test]
        public void Print_ShouldOpenReportForm()
        {
            // Arrange

            // Act
            receipt.print();

            // Assert
            // Add assertions to verify that the report form is opened
        }

        [Test]
        public void InstallmentBalAmount_ShouldCalculateRemainingAmount()
        {
            // Arrange
            receipt.cmbInstallmentNo.Text = "1";
            receipt.cmbPlotSellId.Text = "1";
            receipt.txtinstallmentamount.Text = "1000";

            // Act
            receipt.installmentbalamount();

            // Assert
            // Add assertions to verify that the remaining amount is calculated correctly
        }

        [Test]
        public void BtnSave_Click_ShouldSaveReceipt()
        {
            // Arrange
            receipt.cmbpaymentmode.Text = "Cash";
            receipt.txtRemainingamount.Text = "1000";
            receipt.txttotalamount.Text = "1000";

            // Act
            receipt.btn_save_Click(null, EventArgs.Empty);

            // Assert
            // Add assertions to verify that the receipt is saved correctly
        }

        // Add more test methods for other functions as needed
    }
}
