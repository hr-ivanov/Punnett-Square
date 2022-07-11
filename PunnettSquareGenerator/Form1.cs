namespace PunnettSquareGenerator
{
    public partial class Form1 : Form
    {
        string adData;
        static double total;
        Hybrids h;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            string first = textBox1.Text;
            string second = textBox2.Text;
            h = new Hybrids(first, second);
            string[,] arr  = h.GenerateData();
            h.ShowPunnettSquare(arr, dataGridView1);

            total = (arr.GetLength(0) - 1) * (arr.GetLength(1) - 1);
            labelTotal.Text = total.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGenotype_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxComp.Enabled = false;
            textBoxEpi.Enabled = false;
            textBoxFullDom.Enabled = false;
            textBoxIncDom.Enabled = false;
            textBoxLethal.Enabled = false;
            textBoxNonCum.Enabled = false;
            textBoxPolCum.Enabled = false;

            adData = "";
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 0, adData, total), dataGridView2);
        }

        private void radioButtonFullDom_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxComp.Enabled = false;
            textBoxEpi.Enabled = false;
            textBoxIncDom.Enabled = false;
            textBoxLethal.Enabled = false;
            textBoxNonCum.Enabled = false;
            textBoxPolCum.Enabled = false;

            textBoxFullDom.Enabled = true;
            adData = textBoxFullDom.Text;
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 1, adData, total), dataGridView2);
        }

        private void radioButtonIncDom_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxComp.Enabled = false;
            textBoxEpi.Enabled = false;
            textBoxFullDom.Enabled = false;
            textBoxLethal.Enabled = false;
            textBoxNonCum.Enabled = false;
            textBoxPolCum.Enabled = false;

            textBoxIncDom.Enabled = true;
            adData = textBoxIncDom.Text;
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 2, adData, total), dataGridView2);
        }

        private void radioButtonLethal_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxComp.Enabled = false;
            textBoxEpi.Enabled = false;
            textBoxFullDom.Enabled = false;
            textBoxIncDom.Enabled = false;
            textBoxNonCum.Enabled = false;
            textBoxPolCum.Enabled = false;

            textBoxLethal.Enabled = true;
            adData = textBoxLethal.Text;
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 3, adData, total), dataGridView2);
        }

        private void radioButtonComp_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxEpi.Enabled = false;
            textBoxFullDom.Enabled = false;
            textBoxIncDom.Enabled = false;
            textBoxLethal.Enabled = false;
            textBoxNonCum.Enabled = false;
            textBoxPolCum.Enabled = false;

            textBoxComp.Enabled = true;
            adData = textBoxComp.Text;
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 4, adData, total), dataGridView2);
        }

        private void radioButtonPolCum_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxComp.Enabled = false;
            textBoxEpi.Enabled = false;
            textBoxFullDom.Enabled = false;
            textBoxIncDom.Enabled = false;
            textBoxLethal.Enabled = false;
            textBoxNonCum.Enabled = false;

            textBoxPolCum.Enabled = true;
            adData = textBoxPolCum.Text;
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 6, adData, total), dataGridView2);
        }

        private void radioButtonNonCum_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxComp.Enabled = false;
            textBoxEpi.Enabled = false;
            textBoxFullDom.Enabled = false;
            textBoxIncDom.Enabled = false;
            textBoxLethal.Enabled = false;
            textBoxPolCum.Enabled = false;

            textBoxNonCum.Enabled = true;
            adData = textBoxNonCum.Text;
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 7, adData, total), dataGridView2);
        }

        private void radioButtonEp_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxComp.Enabled = false;
            textBoxFullDom.Enabled = false;
            textBoxIncDom.Enabled = false;
            textBoxLethal.Enabled = false;
            textBoxNonCum.Enabled = false;
            textBoxPolCum.Enabled = false;

            textBoxEpi.Enabled = true;
            adData = textBoxEpi.Text;
            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1, 5, adData, total), dataGridView2);
        }
    }
}