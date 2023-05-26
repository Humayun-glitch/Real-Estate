using NUnit.Framework;
using Moq;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class GroupTests
    {
        private Group group;
        private Mock<PRODUCTCREATION> mockProductCreation;

        [SetUp]
        public void SetUp()
        {
            // Mock PRODUCTCREATION form
            mockProductCreation = new Mock<PRODUCTCREATION>();

            // Create Group form and pass the mock PRODUCTCREATION form as a parameter
            group = new Group(mockProductCreation.Object);
        }

        [Test]
        public void Reset_ShouldResetFormAndLoadDataFromDatabase()
        {
            // Arrange
            var fakeDataReader = new Mock<OleDbDataReader>();
            fakeDataReader
                .SetupSequence(rdr => rdr.Read())
                .Returns(true) // First iteration
                .Returns(false); // Second iteration

            var fakeConnection = new Mock<OleDbConnection>();
            fakeConnection
                .SetupSequence(con => con.CreateCommand().ExecuteReader())
                .Returns(fakeDataReader.Object) // First iteration
                .Returns(fakeDataReader.Object); // Second iteration

            mockProductCreation.SetupGet(pc => pc.lblpath.Text).Returns("fake/path/to/database.accdb");
            group.con = fakeConnection.Object;

            // Act
            group.Reset();

            // Assert
            Assert.AreEqual("1", group.lblgroupid.Text);
            Assert.AreEqual("", group.txtGroupName.Text);
            Assert.IsTrue(group.btnSave.Enabled);
            Assert.IsFalse(group.btnDelete.Enabled);
            Assert.IsFalse(group.btnUpdate.Enabled);
            Assert.AreEqual(1, group.dgwGroup.Rows.Count);
            Assert.AreEqual("GROUPID1", group.dgwGroup.Rows[0].Cells[0].Value);
            Assert.AreEqual("GROUPNAME1", group.dgwGroup.Rows[0].Cells[1].Value);
            mockProductCreation.Verify(pc => pc.group(), Times.Once);
            mockProductCreation.Verify(pc => pc.cmbGroup.Focus(), Times.Once);
        }
    }
}
