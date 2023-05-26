using NUnit.Framework;
using System;

namespace ACCOUNTMANAGEMENT.Tests
{
    [TestFixture]
    public class COMPANYTests
    {
        [Test]
        public void Reset_ShouldResetFieldsAndSetCompanyId()
        {
            // Arrange
            var form = new COMPANY();
            var companyName = "Test Company";
            var address = "Test Address";
            var phoneNo = "Test Phone";
            var email = "test@example.com";
            var cstNo = "Test CST";
            var tinNo = "Test TIN";
            var web = "www.test.com";
            var extra1 = "Extra 1";
            var extra2 = "Extra 2";
            
            // Act
            form.txtCompanyName.Text = companyName;
            form.txtAddress.Text = address;
            form.txtPhoneNo.Text = phoneNo;
            form.txtEmail.Text = email;
            form.txtCstNo.Text = cstNo;
            form.txtTinNo.Text = tinNo;
            form.txtWeb.Text = web;
            form.txt_extra1.Text = extra1;
            form.txt_extra2.Text = extra2;
            form.Reset();

            // Assert
            Assert.AreEqual(string.Empty, form.txtCompanyName.Text);
            Assert.AreEqual(string.Empty, form.txtAddress.Text);
            Assert.AreEqual(string.Empty, form.txtPhoneNo.Text);
            Assert.AreEqual(string.Empty, form.txtEmail.Text);
            Assert.AreEqual(string.Empty, form.txtCstNo.Text);
            Assert.AreEqual(string.Empty, form.txtTinNo.Text);
            Assert.AreEqual(string.Empty, form.txtWeb.Text);
            Assert.AreEqual(string.Empty, form.txt_extra1.Text);
            Assert.AreEqual(string.Empty, form.txt_extra2.Text);
            Assert.AreEqual("1", form.lblcompanyid.Text);
        }
    }
}
