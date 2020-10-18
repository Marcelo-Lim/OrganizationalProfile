using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = OrganizationProfile.frmRegistration.StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = OrganizationProfile.frmRegistration.StudentInformationClass.SetFullName;
            lblProgram.Text = OrganizationProfile.frmRegistration.StudentInformationClass.SetProgram;
            lblBirthday.Text = OrganizationProfile.frmRegistration.StudentInformationClass.SetBirthday;
            lblGender.Text = OrganizationProfile.frmRegistration.StudentInformationClass.SetGender;
            lblContactNo.Text = OrganizationProfile.frmRegistration.StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = OrganizationProfile.frmRegistration.StudentInformationClass.SetAge.ToString();

        }

        private string FullName(object text1, object text2, object text3)
        {
            throw new NotImplementedException();
        }
    }
}
