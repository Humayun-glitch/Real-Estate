using NUnit.Framework;
using System;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class CUSTOMERTests
    {
        [Test]
        public void Reset_ShouldResetFieldsAndSetCustomerId()
        {
            // Arrange
            var form = new CUSTOMER();
            var path = "test/path";
            var customerName = "Test Customer";
            var address = "Test Address";
            var phoneNo = "Test Phone";
            var mobileNo = "Test Mobile";
            var email = "test@example.com";
            var extra1 = "Extra 1";
            var extraDetail1 = "Extra Detail 1";

            form.lblpath.Text = path;
            form.txtCustomerName.Text = customerName;
            form.txtAddress.Text = address;
            form.txtPhoneNo.Text = phoneNo;
            form.txt_Mobile.Text = mobileNo;
            form.txtEmail.Text = email;
            form.txt_extra1.Text = extra1;
            form.txt_extradetail1.Text = extraDetail1;

            // Act
            form.Reset();

            // Assert
            Assert.AreEqual(string.Empty, form.txtCustomerName.Text);
            Assert.AreEqual(string.Empty, form.txtAddress.Text);
            Assert.AreEqual(string.Empty, form.txtPhoneNo.Text);
            Assert.AreEqual(string.Empty, form.txt_Mobile.Text);
            Assert.AreEqual(string.Empty, form.txtEmail.Text);
            Assert.AreEqual(string.Empty, form.txt_extra1.Text);
            Assert.AreEqual(string.Empty, form.txt_extradetail1.Text);
            Assert.AreEqual("1", form.txtcustid.Text);
            Assert.AreEqual(path, form.lblpath.Text);
        }
    }
}
