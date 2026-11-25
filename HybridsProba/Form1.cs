namespace HybridsProba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] arr = new string[6,9];
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int l = 0; l < arr.GetLength(1); l++)
                {
                    arr[k,l] = k.ToString()+", "+l.ToString();
                }
            }

            int height = arr.GetLength(0);
            int width = arr.GetLength(1);

            this.dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = arr[r, c];
                }

                this.dataGridView1.Rows.Add(row);
            }
        }
    }
}