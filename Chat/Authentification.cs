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
    public partial class Authentification : Form
    {
        private static string tame="";
        public static string Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        
        DCDataContext dc = new DCDataContext();
        public Authentification()
        {
            InitializeComponent();
            
        }
        public void SeConnecter_Click(object sender, EventArgs e)
        {
            

            var user = (from b in dc.Users where b.Username == Username.Text select b).First();
                if (user.Password == Password.Text)
                                {

                                    App app = new App();
                                    app.Show();
                /*this.Hide();*/
                Tame = Username.Text;
                

            }
           





        }

        private void Sinscrire_Click(object sender, EventArgs e)
        {
            Inscription ins = new Inscription();
            ins.Show();
            this.Hide();
        }
    }
}
