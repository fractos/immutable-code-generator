using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsImmutableCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxTemplate.Text = Path.Combine(
                Application.StartupPath,
                ConfigurationManager.AppSettings["templateFolder"],
                ConfigurationManager.AppSettings["template"]);

            LoadCollections();
        }

        protected void LoadCollections()
        {
            
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string codeTemplate = ReadTextFile(textBoxTemplate.Text);

            Dictionary<string, string> dictProperties = new Dictionary<string, string>();

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if(!dr.IsNewRow)
                {
                    string propName = dr.Cells["Name"].Value.ToString();
                    string propType = (dr.Cells["Custom"].Value ?? dr.Cells["Type"].Value).ToString();
                    dictProperties.Add(propName, propType);
                }
            }

            Generator generator = new Generator();
            textBoxCode.Text =
                generator.Generate(codeTemplate, textBoxNamespace.Text, textBoxClassName.Text, dictProperties);
        }

        public static string ReadTextFile(string pathname)
        {
            StreamReader streamReader = new StreamReader(pathname);
            string text = streamReader.ReadToEnd();
            streamReader.Close();
            return text;
        }

    }
}
