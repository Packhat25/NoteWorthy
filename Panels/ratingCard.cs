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
    public partial class ratingCard : UserControl
    {
        public ratingCard()
        {
            InitializeComponent();
            
        }
        public void SetTopRatedDetails(string title, double avgRating, int reviewCount)
        {
            lblTitle.Text = title;
            lblAvg.Text = $"({avgRating:F1})";
            lblReviews.Text = $"{reviewCount} Reviews";
            lblStars.Text = GetStars(avgRating);
            lblReviews.Location = new System.Drawing.Point(this.Width / 2 - lblReviews.Width / 2,98);
        }
        private string GetStars(double rating)
        {
            int fullStars = (int)Math.Floor(rating);
            return new string('★', fullStars).PadRight(5, '☆');
        }
    }

    
}
