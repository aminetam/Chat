using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class App : Form
    {
        User u = new User();
        DCDataContext dc = new DCDataContext();
        
        public App()
        {
            InitializeComponent();
            var a = (from b in dc.Users select new { b.Username });
            textBox2.Text = null;
            for (int z = dc.Users.Count() - 1; z >= 0; z--)
            {
                textBox2.Text = textBox2.Text + a.Skip(z).First().Username + "   \r\n";
            }
            var data = (from r in dc.Messages select new { r.Username });
            var msg = from m in dc.Messages select new { m.Message1 };
            textBox1.Text = null;
            for (int i = dc.Messages.Count() - 1; i >= 0; i--)
            {
                textBox1.Text = textBox1.Text + data.Skip(i).First().Username + " : " + msg.Skip(i).First().Message1 + " \r\n";
            }
            label4.Text = Authentification.Tame;
        }
        
        private void Send_Click(object sender, EventArgs e)
        {
            Message A = new Message();
            A.Message1 = Message.Text;
            A.Username = Authentification.Tame;
            dc.Messages.InsertOnSubmit(A);
            dc.SubmitChanges();
            textBox1.Text = "";
            var data = (from r in dc.Messages select new { r.Username });
            var msg = (from m in dc.Messages select new { m.Message1 });

            for (int i = dc.Messages.Count() - 1; i >= 0; i--)
            {
               


                textBox1.Text = textBox1.Text + data.Skip(i).First().Username + " : " + msg.Skip(i).First().Message1 + " \r\n";
            }
            
            



        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            var user = (from b in dc.Users where b.Username == Authentification.Tame select b).First();
            dc.Users.DeleteOnSubmit(user);
            dc.SubmitChanges();
            var a = (from b in dc.Users select new { b.Username });
            textBox2.Text = null;
            for (int z = dc.Users.Count() - 1; z >= 0; z--)
            {
                textBox2.Text = textBox2.Text + a.Skip(z).First().Username + "   \r\n";
            }
        }
    }
}
