using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echo
{
    /// <summary>
    /// Общий Вид любой формы
    /// </summary>
    public partial class StyleForm : Form
    {
        private Point mouseLocation;

        public StyleForm()
        {
            InitializeComponent();
        }

        private void StyleForm_Load(object sender, EventArgs e)
        {
            StyleFormHeaderPanel.Location = new Point(0,0);
            //this.Size = new Size();
        }

        // Перетаскивание Мышью

        private void StyleFormHeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void StyleFormHeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void StyleFormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
