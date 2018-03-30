using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DB_Library
{
    class LoadBook
    {
        public void Load()
        {
            try
            {
                string pathTofile = Mediator.MediatorLoadBook.GetNameFile();
                string rowStr = "";
                TextWriter sw = new StreamWriter(pathTofile, true, Encoding.Unicode);
                foreach (DataGridViewRow row in MediatorLoadBook.GetBooks())
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        rowStr += cel.Value + "\t";
                    }
                    sw.WriteLine(rowStr.TrimEnd());
                    rowStr = "";
                }
                sw.Close();                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}