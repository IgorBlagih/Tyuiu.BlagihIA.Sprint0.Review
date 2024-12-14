using Tyuiu.BlagihIA.Sprint6.TaskReview.V4.Lib;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.TaskReview.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        static int rows;
        static int cols;
        static int n1;
        static int n2;
        int[,] aValues = new int[rows, cols];
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

            rows = Convert.ToInt32(textBoxN.Text);
            cols = Convert.ToInt32(textBoxM.Text);

            dataGridViewIn.ColumnCount = cols;
            dataGridViewIn.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
            }
            n1 = Convert.ToInt32(textBoxn1.Text);
            n2 = Convert.ToInt32(textBoxn2.Text);
            

            
            aValues = ds.GetMatrix(rows, cols, n1, n2);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewIn.Rows[i].Cells[j].Value = aValues[i, j];

                }
            }
        }
        private void buttonCompilare_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBoxC.Text);
            c -= 1;
            int k = Convert.ToInt32(textBoxK.Text);
            k -= 1;
            int l = Convert.ToInt32(textBoxL.Text);
            l -= 1;
            textBoxResult.Text = Convert.ToString(ds.Calculate(aValues, n1, n2, c, k, l));



        }
        private void textBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxM_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxn1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxn2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void textBoxK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxL_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
