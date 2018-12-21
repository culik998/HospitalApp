using HospitalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        { 


            using(PatientDbContext db=new PatientDbContext())
            {
                 
               Patient obj1 = db.Patients.Where(x => x.Email == txbx_email.Text).FirstOrDefault();
                Patient obj2 = db.Patients.Where(x => x.Password == txbx_pws.Text).FirstOrDefault();

                
            }
        }
    }
}
