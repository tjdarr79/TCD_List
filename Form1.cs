using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace TCD_List
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCD_ListDataSet.TCD' table. You can move, or remove it, as needed.
            this.tCDTableAdapter.Fill(this.tCD_ListDataSet.TCD);

            int cellnum = 0;
            int rownum = 0;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }
        }
       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tCDBindingSource.EndEdit();
                this.tCDTableAdapter.Update(this.tCD_ListDataSet.TCD);
                MessageBox.Show("Updated Successful");
                this.tCDTableAdapter.Fill(this.tCD_ListDataSet.TCD);
            }
            catch (System.Exception )
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btnCIM_Click(object sender, EventArgs e)
        {
            this.tCDTableAdapter.FillBy(this.tCD_ListDataSet.TCD);

            int cellnum = 0;
            int rownum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }

        }

        private void btnWallMount_Click(object sender, EventArgs e)
        {
            this.tCDTableAdapter.FillWall(this.tCD_ListDataSet.TCD);
            int cellnum = 0;
            int rownum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.tCDTableAdapter.Fill(this.tCD_ListDataSet.TCD);
            int cellnum = 0;
            int rownum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }
        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            this.tCDTableAdapter.FillDesk(this.tCD_ListDataSet.TCD);
            int cellnum = 0;
            int rownum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }
        }

        private void btnHotSwap_Click(object sender, EventArgs e)
        {
            this.tCDTableAdapter.FillHotSwap(this.tCD_ListDataSet.TCD);
            int cellnum = 0;
            int rownum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tCDBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

    
}
