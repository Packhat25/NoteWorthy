using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWorthy
{
    public partial class settingsPanel : UserControl
    {
        public event Action LogoutRequested;
        public settingsPanel()
        {
            InitializeComponent();
            button1.Location = new(this.Width / 2 - button1.Width / 2, 195);
            button2.Location = new(this.Width / 2 - button2.Width / 2, 120);

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke();
        }

    }
}
