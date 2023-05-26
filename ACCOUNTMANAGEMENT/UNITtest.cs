using NUnit.Framework;
using Moq;

namespace ACCOUNTMANAGEMENT.UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        private UNIT unitForm;
        private Mock<PRODUCTCREATION> mockProductCreationForm;

        [SetUp]
        public void SetUp()
        {
            mockProductCreationForm = new Mock<PRODUCTCREATION>();
            mockProductCreationForm.Setup(f => f.lblpath).Returns(new Label());

            unitForm = new UNIT(mockProductCreationForm.Object);
        }

        [Test]
        public void Reset_ShouldSetDefaultValuesAndLoadDataGrid()
        {
            // Arrange
            unitForm.lblpath.Text = "test_path";
            unitForm.dgwUnit = new DataGridView();

            // Mock the database interaction
            var mockDataReader = new Mock<OleDbDataReader>();
            mockDataReader.SetupSequence(r => r.Read())
                .Returns(true)
                .Returns(false);
            mockDataReader.Setup(r => r[0]).Returns(1);
            mockDataReader.Setup(r => r[1]).Returns("Test Unit");

            var mockCommand = new Mock<OleDbCommand>();
            mockCommand.Setup(c => c.ExecuteReader(CommandBehavior.CloseConnection)).Returns(mockDataReader.Object);

            var mockConnection = new Mock<OleDbConnection>();
            mockConnection.SetupSequence(c => c.State)
                .Returns(ConnectionState.Open)
                .Returns(ConnectionState.Closed);
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);

            unitForm.con = mockConnection.Object;

            // Act
            unitForm.Reset();

            // Assert
            Assert.AreEqual("1", unitForm.lblUnitId.Text);
            Assert.AreEqual("Test Unit", unitForm.txtUnit.Text);
            Assert.AreEqual(1, unitForm.dgwUnit.Rows.Count);
            Assert.IsTrue(unitForm.btnSave.Enabled);
            Assert.IsFalse(unitForm.btnUpdate.Enabled);
            Assert.IsFalse(unitForm.btnDelete.Enabled);
            Assert.IsTrue(unitForm.txtUnit.Focused);
        }

        [Test]
        public void btnNew_Click_ShouldCallReset()
        {
            // Arrange
            bool resetCalled = false;
            unitForm.Reset = () => resetCalled = true;

            // Act
            unitForm.btnNew_Click(null, null);

            // Assert
            Assert.IsTrue(resetCalled);
        }

        [Test]
        public void btnSave_Click_ShouldInsertNewUnitAndReset()
        {
            // Arrange
            unitForm.lblpath.Text = "test_path";
            unitForm.lblUnitId.Text = "1";
            unitForm.txtUnit.Text = "New Unit";

            // Mock the database interaction
            var mockCommand = new Mock<OleDbCommand>();
            var mockConnection = new Mock<OleDbConnection>();
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);

            unitForm.con = mockConnection.Object;

            // Act
            unitForm.btnSave_Click(null, null);

            // Assert
            mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Once);
            mockProductCreationForm.Verify(f => f.unitresete(), Times.Once);
        }

        [Test]
        public void btnUpdate_Click_ShouldUpdateUnitAndReset()
        {
            // Arrange
            unitForm.lblpath.Text = "test_path";
            unitForm.lblUnitId.Text = "1";
            unitForm.txtUnit.Text = "Updated Unit";

            // Mock the database interaction
            var mockCommand = new Mock<OleDbCommand>();
            var mockConnection = new Mock<OleDbConnection>();
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);

            unitForm.con = mockConnection.Object;

            // Act
            unitForm.btnUpdate_Click(null, null);
                    // Assert
        mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Once);
        mockProductCreationForm.Verify(f => f.unitresete(), Times.Once);
    }

    [Test]
    public void btnDelete_Click_ShouldDeleteUnitAndReset()
    {
        // Arrange
        unitForm.lblpath.Text = "test_path";
        unitForm.lblUnitId.Text = "1";

        // Mock the database interaction
        var mockCommand = new Mock<OleDbCommand>();
        var mockConnection = new Mock<OleDbConnection>();
        mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);

        unitForm.con = mockConnection.Object;

        // Act
        unitForm.btnDelete_Click(null, null);

        // Assert
        mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Once);
        mockProductCreationForm.Verify(f => f.unitresete(), Times.Once);
    }

    [Test]
    public void dgwUnit_MouseClick_ShouldPopulateFieldsAndEnableButtons()
    {
        // Arrange
        unitForm.dgwUnit = new DataGridView();
        unitForm.dgwUnit.Rows.Add(1, "Test Unit");

        // Act
        unitForm.dgwUnit_MouseClick(null, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

        // Assert
        Assert.AreEqual("1", unitForm.lblUnitId.Text);
        Assert.AreEqual("Test Unit", unitForm.txtUnit.Text);
        Assert.IsTrue(unitForm.btnDelete.Enabled);
        Assert.IsTrue(unitForm.btnUpdate.Enabled);
        Assert.IsFalse(unitForm.btnSave.Enabled);
    }
}
}
