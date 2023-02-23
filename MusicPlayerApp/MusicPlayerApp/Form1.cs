using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //create global variables of String Type Array to save media names and paths
        String[] paths, files;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code to select media
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select more than 1 file
            ofd.Multiselect = true; 
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //saves media name in file array
                paths = ofd.FileNames; //saves location in path array
                //shows msuic title in listbox
                for(int i=0; i<files.Length; i++) 
                {
                    listBoxSongs.Items.Add(files[i]);   //displays media in listbox
                }
            }
        }

        private void WindowsMediaPlayerSongs_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play media
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }
    }
}
