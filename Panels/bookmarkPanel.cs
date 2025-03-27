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
    public partial class bookmarkPanel : UserControl
    {
        public bookmarkPanel()
        {
            InitializeComponent();
            this.BringToFront();

        }

        private void btnNewbookmark_Click(object sender, EventArgs e)
        {
           addBookmarkUI bookmarkUI = new addBookmarkUI();
            bookmarkUI.ShowDialog();
            
        }
    }
}
