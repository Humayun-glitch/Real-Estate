using System;
using System.Windows.Forms;
using NUnit.Framework;
using ACCOUNTMANAGEMENT;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class LoginTests
    {
        private Login loginForm;

        [SetUp]
        public void SetUp()
        {
            loginForm = new Login();
        }

        [Test]
        public void OK_Click_ValidCredentials_ShouldOpenMainForm()
        {
            // Arrange
            TextBox userID = new TextBox();
            TextBox password = new TextBox();
            Label lblpath = new Label();
            Label lblcompanyname = new Label();
            loginForm.UserID = userID;
            loginForm.Password = password;
            loginForm.lblpath = lblpath;
            loginForm.lblcompanyname = lblcompanyname;
            userID.Text = "admin";
            password.Text = "password";
            lblpath.Text = "path_to_database.accdb";

            // Act
            loginForm.OK_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsFalse(loginForm.Visible); // The login form should be hidden
            Assert.IsTrue(loginForm.Owner is MAINFORM); // The main form should be shown
            Assert.AreEqual(lblpath.Text, ((MAINFORM)loginForm.Owner).lblcompanypath.Text);
            Assert.AreEqual(lblcompanyname.Text, ((MAINFORM)loginForm.Owner).lblcompanyname.Text);
        }

        [Test]
        public void OK_Click_InvalidCredentials_ShouldShowErrorMessageAndClearInputs()
        {
            // Arrange
            TextBox userID = new TextBox();
            TextBox password = new TextBox();
            loginForm.UserID = userID;
            loginForm.Password = password;
            userID.Text = "admin";
            password.Text = "wrong_password";

            // Act
            loginForm.OK_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(string.Empty, userID.Text);
            Assert.AreEqual(string.Empty, password.Text);
            Assert.AreEqual(userID, loginForm.ActiveControl); // Focus should be set back to the UserID textbox
            Assert.IsTrue(loginForm.Visible); // The login form should still be visible
            Assert.AreEqual(DialogResult.OK, MessageBoxWrapper.LastShownDialogResult); // Error message box shown
        }
    }

    // Helper class to wrap MessageBox for testing
    public static class MessageBoxWrapper
    {
        public static DialogResult LastShownDialogResult { get; private set; }

        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            LastShownDialogResult = DialogResult.OK;
            return LastShownDialogResult;
        }
    }
}
