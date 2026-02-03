using Class_library;

namespace OOPConcepts.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidate_Click(object sender, EventArgs e)
        {
            if (txtyear.Text.Length == 0)
            {
                MessageBox.Show("Digite un año", "Error");
                return;
            }

            if (txtmont.Text.Length == 0)
            {
                MessageBox.Show("Digite un mes", "Error");
                return;
            }

            if (txtday.Text.Length == 0)
            {
                MessageBox.Show("Digite un dia", "Error");
                return;
            }

            try
            {
                int year = Convert.ToInt32(txtyear.Text);
                int mont = Convert.ToInt32(txtmont.Text);
                int day = Convert.ToInt32(txtday.Text);

                var date = new Date(year, mont, day);
                MessageBox.Show($"Ok, la fecha ES: {date}", "confirmado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}