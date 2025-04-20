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
    public partial class basePanel : UserControl
    {
        protected DatabaseHelper dbHelper;
        public basePanel()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
    }

    public partial class CopyOfbasePanel : UserControl
    {
        protected DatabaseHelper dbHelper;
        public CopyOfbasePanel()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
    }
}
