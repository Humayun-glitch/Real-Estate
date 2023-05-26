using NUnit.Framework;
using Moq;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class TAXTests
    {
        private TAX taxForm;
        private Mock<OleDbDataReader> mockDataReader;
        private Mock<OleDbCommand> mockCommand;
        private Mock<OleDbConnection> mockConnection;
        private PRODUCTCREATION mockProductCreationForm;

        [SetUp]
        public void Setup()
        {
            mockDataReader = new Mock<OleDbDataReader>();
            mockCommand = new Mock<OleDbCommand>();
            mockConnection = new Mock<OleDbConnection>();
            mockProductCreationForm = new Mock<PRODUCTCREATION>();

            taxForm = new TAX(mockProductCreationForm.Object);
            taxForm.lblpath.Text = "test path";

            taxForm.dgwTax = new DataGridView();
            taxForm.lbltaxid = new Label();
            taxForm.txtTaxName = new TextBox();
            taxForm.cmbTaxType = new ComboBox();
            taxForm.txttaxper = new TextBox();
            taxForm.btnSave = new Button();
            taxForm.btnUpdate = new Button();
            taxForm.btnDelete = new Button();

            mockCommand.SetupSet(c => c.CommandText = It.IsAny<string>());
            mockCommand.Setup(c => c.ExecuteReader()).Returns(mockDataReader.Object);
            mockCommand.Setup(c => c.ExecuteNonQuery());
            mockCommand.Setup(c => c.Dispose());
            mockConnection.Setup(c => c.Open());
            mockConnection.Setup(c => c.Close());

            taxForm.con = mockConnection.Object;
            taxForm.cmd = mockCommand.Object;
            taxForm.rdr = mockDataReader.Object;
        }

        [Test]
        public void Reset_ShouldResetFormFieldsAndLoadTaxDataIntoDataGridView()
        {
            // Arrange
            mockDataReader.SetupSequence(r => r.Read())
                .Returns(true)
                .Returns(false);

            // Act
            taxForm.Reset();

            // Assert
            mockConnection.Verify(c => c.Open(), Times.Exactly(2));
            mockCommand.Verify(c => c.CommandText = "SELECT MAX(TAXID) as TAXID FROM Tax", Times.Once());
            mockDataReader.Verify(r => r.Read(), Times.Exactly(2));
            mockDataReader.Verify(r => r.IsDBNull(It.IsAny<int>()), Times.Once());
            mockDataReader.VerifyGet(r => r["TAXID"], Times.Once());
            mockDataReader.Verify(r => r.Close(), Times.Once());
            mockCommand.Verify(c => c.CommandText = "SELECT TAXID,TAXNAME,TAXATIONTYPE,TAXPER FROM Tax", Times.Once());
            mockCommand.Verify(c => c.ExecuteReader(), Times.Once());
            mockDataReader.Verify(r => r[0], Times.Once());
            mockDataReader.Verify(r => r[1], Times.Once());
            mockDataReader.Verify(r => r[2], Times.Once());
            mockDataReader.Verify(r => r[3], Times.Once());
            mockConnection.Verify(c => c.Close(), Times.Exactly(2));
            Assert.AreEqual(string.Empty, taxForm.txtTaxName.Text);
            Assert.AreEqual(string.Empty, taxForm.cmbTaxType.Text);
            Assert.AreEqual(string.Empty, taxForm.txttaxper.Text);
            Assert.IsTrue(taxForm.btnSave.Enabled);
            Assert.IsFalse(taxForm.btnUpdate.Enabled);
            Assert.IsFalse(taxForm.btnDelete.Enabled);
            Assert.IsTrue(taxForm.txtTaxName.Focused);
        }

        [Test]
        public void btnNew_Click_ShouldResetForm()
        {
            // Arrange
            taxForm.txtTaxName.Text = "Test";
            taxForm.cmbTaxType.Text = "Test";
            taxForm.txttaxper.Text = "Test";

            // Act
            taxForm.btnNew_Click(null, null);

            // Assert
            Assert.AreEqual(string.Empty, taxFormtxtTaxName.Text);
Assert.AreEqual(string.Empty, taxForm.cmbTaxType.Text);
Assert.AreEqual(string.Empty, taxForm.txttaxper.Text);
Assert.IsTrue(taxForm.btnSave.Enabled);
Assert.IsFalse(taxForm.btnUpdate.Enabled);
Assert.IsFalse(taxForm.btnDelete.Enabled);
Assert.IsTrue(taxForm.txtTaxName.Focused);
}
    [Test]
    public void btnSave_Click_ShouldSaveTaxDataAndResetForm()
    {
        // Arrange
        taxForm.txtTaxName.Text = "Test Name";
        taxForm.cmbTaxType.Text = "Test Type";
        taxForm.txttaxper.Text = "10";

        // Act
        taxForm.btnSave_Click(null, null);

        // Assert
        mockConnection.Verify(c => c.Open(), Times.Once());
        mockCommand.Verify(c => c.CommandText = "insert into Tax(TAXID,TAXNAME,TAXATIONTYPE,TAXPER) VALUES (1,'Test Name','Test Type',10)", Times.Once());
        mockCommand.Verify(c => c.ExecuteReader(), Times.Once());
        mockConnection.Verify(c => c.Close(), Times.Once());
        Assert.AreEqual(string.Empty, taxForm.txtTaxName.Text);
        Assert.AreEqual(string.Empty, taxForm.cmbTaxType.Text);
        Assert.AreEqual(string.Empty, taxForm.txttaxper.Text);
        Assert.IsTrue(taxForm.btnSave.Enabled);
        Assert.IsFalse(taxForm.btnUpdate.Enabled);
        Assert.IsFalse(taxForm.btnDelete.Enabled);
    }

    [Test]
    public void btnUpdate_Click_ShouldUpdateTaxDataAndResetForm()
    {
        // Arrange
        taxForm.lbltaxid.Text = "1";
        taxForm.txtTaxName.Text = "Test Name";
        taxForm.cmbTaxType.Text = "Test Type";
        taxForm.txttaxper.Text = "10";

        // Act
        taxForm.btnUpdate_Click(null, null);

        // Assert
        mockConnection.Verify(c => c.Open(), Times.Once());
        mockCommand.Verify(c => c.CommandText = "update Tax set  TAXNAME = 'Test Name', TAXATIONTYPE ='Test Type' , TAXPER= 10 where  TAXID = 1", Times.Once());
        mockCommand.Verify(c => c.ExecuteReader(), Times.Once());
        mockConnection.Verify(c => c.Close(), Times.Once());
        Assert.AreEqual(string.Empty, taxForm.txtTaxName.Text);
        Assert.AreEqual(string.Empty, taxForm.cmbTaxType.Text);
        Assert.AreEqual(string.Empty, taxForm.txttaxper.Text);
        Assert.IsTrue(taxForm.btnSave.Enabled);
        Assert.IsFalse(taxForm.btnUpdate.Enabled);
        Assert.IsFalse(taxForm.btnDelete.Enabled);
    }

    [Test]
    public void btnDelete_Click_ShouldDeleteTaxDataAndResetForm()
    {
        // Arrange
        taxForm.lbltaxid.Text = "1";

        // Act
        taxForm.btnDelete_Click(null, null);

        // Assert
        mockConnection.Verify(c => c.Open(), Times.Once());
        mockCommand.Verify(c => c.CommandText = "DELETE FROM Tax WHERE TAXID=1", Times.Once());
        mockCommand.Verify(c => c.ExecuteReader(), Times.Once());
        mockConnection.Verify(c => c.Close(), Times.Once());
        Assert.AreEqual(string.Empty, taxForm.txtTaxName.Text);
        Assert.AreEqual(string.Empty, taxForm.cmbTaxType.Text);
        Assert.AreEqual(string.Empty, taxForm.txttaxper.Text);
        Assert.IsTrue(taxForm.btnSave.Enabled);
        Assert.IsFalse(taxForm.btnUpdate.Enabled);
        Assert.IsFalse(taxForm.btnDelete.Enabled);
    }

    [Test]
    public void dgwTax_MouseClick_ShouldPopulateFormFieldsForSelectedTax()
    {
        // Arrange
        taxForm.dgwTax.Rows.Add("1", "Test Name", "Test Type", "10");

        // Act
        taxForm.dgwTax_MouseClick(null, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

        // Assert
        Assert.AreEqual("1", taxForm.lbltaxid.Text);
        Assert.AreEqual("Test Name", taxForm.txtTaxName.Text);
        Assert.AreEqual("Test Type", taxForm.cmbTaxType.Text);
        Assert.AreEqual("10", taxForm.txttaxper.Text);
        Assert.IsTrue(taxForm.btnUpdate.Enabled);
        Assert.IsTrue(taxForm.btnDelete.Enabled);
        Assert.IsFalse(taxForm.btnSave.Enabled);
    }

    [Test]
    public void TAX_FormClosed_ShouldResetProductCreationFormAndSetFocusToComboBox()
    {
        // Arrange

        // Act
        taxForm.TAX_FormClosed(null, new FormClosedEventArgs(CloseReason.None));

        // Assert
        mockProductCreationForm.Verify(f => f.taxresete(), Times.Once());
        mockProductCreationForm.Verify(f => f.cmbTax.Focus(), Times.Once());
    }
}
}
            
