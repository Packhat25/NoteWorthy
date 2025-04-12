using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWorthy.Panels
{
    public partial class feedbackPanel : UserControl
    {
        public feedbackPanel()
        {
            InitializeComponent();
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedbackCard card = new FeedbackCard(); 
            flowLayoutPanel1.Controls.Add(card);
        }
    }
}
