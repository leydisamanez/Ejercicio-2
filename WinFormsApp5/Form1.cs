using System.ComponentModel;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista lista = new Lista();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {

            try
            {



                lista.insertar(+double.Parse(numerotxt.Text));

                Mostrarbtn_Click(sender, e);




                numerotxt.Clear();


            }



            catch (Exception)
            {
                MessageBox.Show("ingrese sus datos",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Mostrarbtn_Click(object sender, EventArgs e)
        {

            lista.desplegar(dgvregistro);
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {

            try
            {
                double c = double.Parse(datotxt.Text);
                lista.buscar(c, dgvregistro);
                datotxt.Clear();

                if (datotxt.Text == " ")
                {
                    MessageBox.Show("EL NUMERO NO FUE ENCONTRADO",
                      "Contactos");
                    datotxt.Focus();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("EL NUMERO NO FUE ENCONTRADO",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ordenarbtn_Click(object sender, EventArgs e)
        {
            {
                dgvregistro.Sort(dgvregistro.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                dgvregistro.Sort(dgvregistro.Columns[0], ListSortDirection.Descending);
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (datotxt.Text == " ")
                {
                    MessageBox.Show("El campo Nombres es obligatorio",
                      "Contactos");


                }

                else
                {
                    if (MessageBox.Show("Está seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {



                        lista.eliminar(double.Parse(datotxt.Text));
                        datotxt.Clear();
                        Mostrarbtn_Click(sender, e);



                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("EL NUMERO NO FUE ENCONTRADO",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}