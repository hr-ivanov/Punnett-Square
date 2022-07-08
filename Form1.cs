namespace PunnettSquareGenerator
{
    public partial class Form1 : Form
    {
        string adData;
        int relationship;
        public Form1()
        {
            InitializeComponent();
        }
        private void WindowsFormsEnabled(ref int r, ref string a)
        {
            if (radioButtonGenotype.Checked == true)
            {
                relationship = 0;
                adData = "";
            }
            else if (radioButtonFullDom.Checked == true)
            {
                relationship = 1;
                textBoxFullDom.Enabled = true;
                adData = textBoxFullDom.Text;
            }
            else if (radioButtonIncDom.Checked == true)
            {
                relationship = 2;
                textBoxIncDom.Enabled = true;
                adData = textBoxIncDom.Text;
            }
            else if (radioButtonLethal.Checked == true)
            {
                relationship = 3;
                textBoxLethal.Enabled = true;
                adData = textBoxLethal.Text;
            }
            else if (radioButtonComp.Checked == true)
            {
                relationship = 4;
                textBoxComp.Enabled = true;
                adData = textBoxComp.Text;
            }
            else relationship = 100;
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

            WindowsFormsEnabled(ref relationship, ref adData);

            h.ShowFrequencies(h.GenerateFrequencies(dataGridView1,relationship,adData, total), dataGridView2);
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
    }
}