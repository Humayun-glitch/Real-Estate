using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACCOUNTMANAGEMENT;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestClass]
    public class MainFormTests
    {
        [TestMethod]
        public void Login_WhenCalled_ShouldShowLoginForm()
        {
            // Arrange
            var mainForm = new MAINFORM();

            // Act
            mainForm.Login();

            // Assert
            Assert.AreEqual(1, mainForm.MdiChildren.Length);
            Assert.IsInstanceOfType(mainForm.MdiChildren[0], typeof(Login));
        }

        [TestMethod]
        public void CustomerToolStripMenuItem_Click_ShouldShowCustomerForm()
        {
            // Arrange
            var mainForm = new MAINFORM();

            // Act
            mainForm.customerToolStripMenuItem_Click(null, null);

            // Assert
            Assert.AreEqual(1, mainForm.MdiChildren.Length);
            Assert.IsInstanceOfType(mainForm.MdiChildren[0], typeof(CUSTOMER));
        }

        [TestMethod]
        public void CompanyToolStripMenuItem_Click_ShouldShowCompanyForm()
        {
            // Arrange
            var mainForm = new MAINFORM();

            // Act
            mainForm.companyToolStripMenuItem_Click(null, null);

            // Assert
            Assert.AreEqual(1, mainForm.MdiChildren.Length);
            Assert.IsInstanceOfType(mainForm.MdiChildren[0], typeof(COMPANY));
        }

        [TestMethod]
        public void PlotSellToolStripMenuItem_Click_ShouldShowPlotSellForm()
        {
            // Arrange
            var mainForm = new MAINFORM();

            // Act
            mainForm.plotSellToolStripMenuItem_Click(null, null);

            // Assert
            Assert.AreEqual(1, mainForm.MdiChildren.Length);
            Assert.IsInstanceOfType(mainForm.MdiChildren[0], typeof(PLOTSELL));
        }

        [TestMethod]
        public void ReceiptToolStripMenuItem_Click_ShouldShowReceiptForm()
        {
            // Arrange
            var mainForm = new MAINFORM();

            // Act
            mainForm.receiptToolStripMenuItem_Click(null, null);

            // Assert
            Assert.AreEqual(1, mainForm.MdiChildren.Length);
            Assert.IsInstanceOfType(mainForm.MdiChildren[0], typeof(RECEIPT));
        }

        // Add more unit tests for other methods/events in the MAINFORM class
        // ...

    }
}
