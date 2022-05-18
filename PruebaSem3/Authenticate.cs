using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PruebaSem3
{
    public partial class Authenticate : Form
    {
        public Authenticate()
        {
            InitializeComponent();
        }

        private void Authenticate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 4;
            if (textBox1.Text != "rut" && textBox1.TextLength > 2)
            {
                if (textBox2.Text != "clave")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(textBox1.Text, textBox2.Text);
                    if (validLogin == true)
                    {
                        Authenticate form = new Authenticate();
                        form.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        if (count == 0)
                        {
                            MessageBox.Show("Has superado el limite de intentos permitidos, usuario bloqueado");
                            Application.Exit();
                        }
                        MessageBox.Show("rut o clave incorrecta");
                        textBox2.Text = "clave";
                        textBox2.UseSystemPasswordChar = true;
                        textBox1.Focus();
                        result4.Text = "te quedan " + count + " intentos";count--;
                    }
                }
                else MessageBox.Show("Por favor ingrese su clave");
            }
            else MessageBox.Show("Por favor digite su rut completo");
        }
    }
}
