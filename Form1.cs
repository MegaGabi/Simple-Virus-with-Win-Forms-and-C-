using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_a_virus
{
    public partial class Form1 : Form
    {
        static bool initial = true;
        static int all = 0;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }

        protected override void OnLoad(EventArgs e)
        {

            var size = Screen.PrimaryScreen.Bounds.Size;

            int x = rand.Next(0, size.Width  - 1),
                y = rand.Next(0, size.Height - 1);

            this.Location = new Point(x, y);

            this.Size = new Size(1, 1);

            this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

            if (initial)
            {
                create.Enabled = true;
                initial = false;
            }

            base.OnLoad(e);
        }

        private void create_Tick(object sender, EventArgs e)
        {
            if (all < 1000)
            {
                Form1 form = new Form1();
                form.Show();
                all++;
            }
        }
    }
}
