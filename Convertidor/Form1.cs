namespace Convertidor
{
    public partial class Form1 : Form
    {
        //agregamos un objeto  texbox
        private TextBox objTexBox = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

        }
        private void Convercion()
        {
            try
            {
                double grados;
                //si se escribe en la caja de texto grados centigrados ...
                if (objTexBox == txtcen)
                {
                    grados = Convert.ToDouble(txtcen.Text);
                    txtfah.Text = ((grados * 9 / 5) + 32).ToString();
                }
                if (objTexBox == txtfah)
                {
                    grados = Convert.ToDouble(txtfah.Text);
                    txtcen.Text = ((grados - 32) * 5 / 9).ToString();
                }
            }
            catch (FormatException)
            {
                txtcen.Text = "0.00";
                txtfah.Text = "32.00";
            }
        }

        private void txtcen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcen_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTexBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                //enter
                e.Handled = true;
                Convercion();
            }
        }

        private void txtfah_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTexBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                //enter
                e.Handled = true;
                Convercion();
            }
        }
    }
}
