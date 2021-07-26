using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComaxTask.Styles
{
   public static class DataGridView_Style
    {

        public static void SetDGVAutosize(DataGridView dgv)
        {
            // Set  AutoSize Mode:
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //  DataGridView has calculated it's Widths;  storing each column Width values.
            for (int i =0; i <= dgv.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgv.Columns[i].Width;

                // Remove AutoSizing:
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgv.Columns[i].Width = colw;
            }
        }
    }
}
