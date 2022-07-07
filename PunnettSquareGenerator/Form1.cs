namespace PunnettSquareGenerator
{
    public partial class Form1 : Form
    {
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
            Hybrids h = new Hybrids(first, second);
            string[,] arr  = h.GenerateData();
            h.ShowPunnettSquare(arr, dataGridView1);

            double total = (arr.GetLength(0) - 1) * (arr.GetLength(1) - 1);
            labelTotal.Text = total.ToString();

            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1,0,"", total), dataGridView2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}