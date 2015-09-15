using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse.WFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChangeTextBox_Click(object sender, EventArgs e)
        {
            labelChangeText.Text = textBoxTextChange.Text;
        }

        private void buttonFillGrid_Click(object sender, EventArgs e)
        {
            List<Media> myLibrary = new List<Media>();
            
            myLibrary.Add(new CasetteMedia(TimeSpan.FromMinutes(73)) { Name = "Rock 80", Tracks = 13, ArtistName = "V.A" });
            myLibrary.Add(new CasetteMedia(TimeSpan.FromMinutes(71)) { Name = "Rock 90", Tracks = 13, ArtistName = "V.A" });
            myLibrary.Add(new GenesisGame() { Name = "Sonic 1", Stages = 15 });
            myLibrary.Add(new VHSVideo (TimeSpan.FromMinutes(91)) { Name = "Jurasic Park"});

            dataGridViewMedia.DataSource = myLibrary;

            List<string> strings = new List<string>();
                        
            //Why no try, change myLibrary generic Type, for IVideoGame or ISoundMedia and see what happens...
        }
    }
}
