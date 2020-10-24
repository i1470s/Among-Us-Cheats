using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVRYMenu__Amoung_Us__V._1
{
    public partial class Form1 : Form
    {
        Memory.Mem memory = new Memory.Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+1472280,5C,24,14", "float", textBox1.Text);
        }
    }
}
