using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Inscription : Form
    {
        DCDataContext dc = new DCDataContext();
        public Inscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Username = Username.Text;
            u.Password = Password.Text;
            dc.Users.InsertOnSubmit(u);
            dc.SubmitChanges();
            Authentification app = new Authentification();
            app.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
