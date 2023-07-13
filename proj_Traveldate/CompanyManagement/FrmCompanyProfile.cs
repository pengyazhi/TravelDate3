using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proj_Traveldate;
using proj_Traveldate.Models;

namespace proj_Traveldate
{
    public partial class FrmCompanyProfile : Form
    {
        public FrmCompanyProfile()
        {
            InitializeComponent();
            var q = from c in CommonClass.dbContext.Companies
                    where c.CompanyID == Models.Login.ManufacturerID
                    select c;
            foreach (var c in q) 
            {
                txtTax.Text = c.Tax_ID_Number;
                txtCompanyName.Text = c.CompanyName;
                txtCountry.Text = c.Country;
                txtCity.Text = c.City;
                txtPostcode.Text = c.PostalCode;
                txtAddress.Text = c.Address;
                txtPhone.Text = c.Phone;
                txtURL.Text = c.URL;
                txtPrincipal.Text = c.Principal;
                txtContact.Text = c.Contact;
                txtTile.Text = c.Title;
                txtEmail.Text = c.Email;
                txtPassword.Text = c.Password;
                txtServerDetail.Text = c.ServerDescription;
            }
             
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
            var q = (from c in CommonClass.dbContext.Companies
                    where c.CompanyID==Models.Login.ManufacturerID
                    select c).FirstOrDefault();
            
            
            q.CompanyName=txtCompanyName.Text;
            q.Principal=txtPrincipal.Text;
            q.Tax_ID_Number = txtTax.Text;
            q.URL = txtURL.Text;
            q.Country = txtCountry.Text;
            q.PostalCode = txtPostcode.Text;
            q.City = txtCity.Text;
            q.Address = txtAddress.Text;
            q.Contact = txtContact.Text;
            q.Phone = txtPhone.Text;
            q.Title = txtTile.Text;
            q.Email = txtEmail.Text;
            q.ServerDescription=txtServerDetail.Text;
            q.Password = txtPassword.Text;

                CommonClass.dbContext.SaveChanges();
                MessageBox.Show("儲存成功");
            }
            catch(Exception a) 
            {
                MessageBox.Show(a.Message);
            }
            

        }
    }
}
