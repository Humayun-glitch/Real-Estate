using NUnit.Framework;
using System;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class frmBackupTests
    {
        [Test]
        public void btnBackup_Click_ShouldCreateBackupDirectoriesAndCopyFiles()
        {
            // Arrange
            var form = new frmBackup();
            form.checkBox1.Checked = true;
            form.checkBox2.Checked = true;
            form.checkBox3.Checked = true;
            form.checkBox4.Checked = true;
            form.checkBox5.Checked = true;
            form.checkBox6.Checked = true;

            form.lblpath.Text = "source/path";
            form.lblcompanyname.Text = "Test Company";

            // Act
            form.btnBackup_Click(null, EventArgs.Empty);

            // Assert
            var backupDate = DateTime.Today.ToString("dd_MM_yyyy");
            Assert.True(System.IO.Directory.Exists($@"E:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company"));
            Assert.True(System.IO.Directory.Exists($@"F:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company"));
            Assert.True(System.IO.Directory.Exists($@"G:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company"));
            Assert.True(System.IO.Directory.Exists($@"H:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company"));
            Assert.True(System.IO.Directory.Exists($@"I:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company"));
            Assert.True(System.IO.Directory.Exists($@"J:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company"));

            Assert.True(System.IO.File.Exists($@"E:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company\accountmanagement.accdb"));
            Assert.True(System.IO.File.Exists($@"F:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company\accountmanagement.accdb"));
            Assert.True(System.IO.File.Exists($@"G:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company\accountmanagement.accdb"));
            Assert.True(System.IO.File.Exists($@"H:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company\accountmanagement.accdb"));
            Assert.True(System.IO.File.Exists($@"I:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company\accountmanagement.accdb"));
            Assert.True(System.IO.File.Exists($@"J:\ACCOUNTMANAGEMENT\BACKUPDATA\{backupDate}\Test Company\accountmanagement.accdb"));
        }
    }
}
