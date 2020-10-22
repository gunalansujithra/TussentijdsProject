using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TussentijdsProject
{
    public partial class ProductTemplate : Form
    {
        public ProductTemplate()
        {
            InitializeComponent();
        }

        List<string> ProductDetails = new List<string>();

        private void btnInvoke_Click(object sender, EventArgs e)
        {           

            if (!File.Exists("ProductTemplate.txt"))
            {
                var fileStream = File.Create("ProductTemplate.txt");
                fileStream.Close();
            }

            using (StreamReader reader = new StreamReader("ProductTemplate.txt"))
            {
                while (!reader.EndOfStream)
                {
                    ProductDetails.Add(reader.ReadLine());
                }
                reader.Close();
            }

            foreach(var item in ProductDetails)
            {
                string[] columnName = item.Split(':');

                if (columnName[0].Contains("Product"))
                {
                    
                }
            }
        }
    }
}
