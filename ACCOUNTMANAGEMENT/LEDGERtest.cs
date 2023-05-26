using System;
using System.Windows.Forms;
using NUnit.Framework;
using ACCOUNTMANAGEMENT;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class LedgerTests
    {
        private Ledger ledgerForm;

        [SetUp]
        public void SetUp()
        {
            ledgerForm = new Ledger();
        }

        [Test]
        public void Reset_ShouldPopulateCustomerComboBox()
        {
            // Arrange
            ComboBox cmbCustomer = new ComboBox();
            ledgerForm.cmbCustomer = cmbCustomer;

            // Act
            ledgerForm.reset();

            // Assert
            Assert.AreEqual(ledgerForm.cmbCustomer.Items.Count, cmbCustomer.Items.Count);
            Assert.IsTrue(cmbCustomer.Items.Count > 0);
        }

        [Test]
        public void CmbCustomer_Leave_ShouldPopulatePlotNoComboBox()
        {
            // Arrange
            ComboBox cmbPlotNo = new ComboBox();
            ledgerForm.cmbPlotNo = cmbPlotNo;
            ledgerForm.cmbCustomer.Text = "John Doe";

            // Act
            ledgerForm.cmbCustomer_Leave(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(ledgerForm.cmbPlotNo.Items.Count, cmbPlotNo.Items.Count);
            Assert.IsTrue(cmbPlotNo.Items.Count > 0);
        }

        [Test]
        public void CmbPlotNo_Leave_ShouldPopulateSurveyNoComboBox()
        {
            // Arrange
            ComboBox cmbSurveyNo = new ComboBox();
            ledgerForm.cmbSurveyNo = cmbSurveyNo;
            ledgerForm.cmbPlotNo.Text = "A1";

            // Act
            ledgerForm.cmbPlotNo_Leave(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(ledgerForm.cmbSurveyNo.Items.Count, cmbSurveyNo.Items.Count);
            Assert.IsTrue(cmbSurveyNo.Items.Count > 0);
        }

        [Test]
        public void CmbSurveyNo_Leave_ShouldPopulatePlotSellIdComboBox()
        {
            // Arrange
            ComboBox cmbPlotSellId = new ComboBox();
            ledgerForm.cmbPlotSellId = cmbPlotSellId;
            ledgerForm.cmbPlotNo.Text = "A1";
            ledgerForm.cmbSurveyNo.Text = "S1";

            // Act
            ledgerForm.cmbSurveyNo_Leave(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(ledgerForm.cmbPlotSellId.Items.Count, cmbPlotSellId.Items.Count);
            Assert.IsTrue(cmbPlotSellId.Items.Count > 0);
        }
    }
}
