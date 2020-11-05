using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st_mid_practice
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string filter = "Zeeshan Files |*.txt;*.java;*.cs|your Files |*.java;*.cs";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.FilterIndex = 2;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
            string[] value = File.ReadAllLines(openFileDialog.FileName);
            string x = "";
            foreach (String v in value)
            {
                x = x + (v);
                x = x + "\n";
            }
            txtBox.Text  = x;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, txtBox.Text);
            MessageBox.Show("Updated");
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (rbFalse.Checked) colorDialog.FullOpen = false;
            else colorDialog.FullOpen = true;
            colorDialog.ShowDialog();
            lblColor.BackColor = txtBox.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = colorDialog.Color;
                txtBox.ForeColor = colorDialog.Color;
            }
        
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (rbfFalse.Checked) fontDialog.ShowColor = false;
            else fontDialog.ShowColor = true;

            fontDialog.ShowDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtBox.Font = fontDialog.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                MessageBox.Show(txtBox.Text);
                File.WriteAllText(saveFileDialog.FileName+".txt", txtBox.Text);
                MessageBox.Show("Saved");
            }
        }
    }
    public enum Cities
    {
        Sukkur,Larkana,Kandkot,Naudero
    }
    public enum ContantNumber: int 
    {
        
    }

}
