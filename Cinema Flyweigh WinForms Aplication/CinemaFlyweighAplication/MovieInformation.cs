using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlyweighAplication
{
    public partial class MovieInformation : Form
    {
        public MovieInformation(Movie movie)
        {
            InitializeComponent();
            nameTextBox.Text = movie.Title;
            yearTextBox.Text = movie.Year;
            releasedTextBox.Text = movie.Released;
            runTimeTextBox.Text = movie.Runtime;
            ActorsTextBox.Text = movie.Actors;
            plotTextBox.Text = movie.Plot;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
