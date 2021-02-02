using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlyweighAplication
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (movieNameTextBox.Text.Length>0)
            {
                var movie = MovieSearchApi.Search(movieNameTextBox.Text);
                if (movie!=null)
                {
                    var information = new MovieInformation(movie);
                    information.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please enter movie name !");
            }
        }
    }
}
