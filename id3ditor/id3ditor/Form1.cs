using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace id3ditor
{
    public partial class Form1 : Form
    {
        //Set global variables/objects
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        TagLib.File currentMp3;
        TagLib.File copy;
        string mp3Location;
        string rootDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\id3ditor\\";

        public Form1()
        {
            InitializeComponent();
        }

        #region Folder stuff
        private void selectDirBtn_Click(object sender, EventArgs e)
        {
            //Selects the folder with the MP3s
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();
            //If there is a path selected
            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                try
                {
                    //Searches for all files with *.mp3 in the selected directory, and sub directories.
                    string[] mp3files = Directory.GetFiles(fbd.SelectedPath, "*.mp3", SearchOption.AllDirectories);

                    int count = mp3files.Count();

                    //Clear the list box to keep things clear
                    mp3ListBox.Items.Clear();

                    //Get the total ammoutn of MP3 items and update a label
                    mp3CountLbl.Text = "Total MP3 Count: " + count.ToString();

                    //Gets the path from each element of the array and adds it to the list box
                    if (count != 0)
                    {
                        foreach (string filePath in mp3files)
                        {
                            mp3ListBox.Items.Add(filePath);
                        }
                    }
                    else if (count == 0)
                    {
                        MessageBox.Show("No MP3 Files found! Ensure files are correct format and the directory is correct");
                    }
                }
                catch (UnauthorizedAccessException er)
                {
                    MessageBox.Show("Couldnt access some folders: "+ er);
                }
                
                
            }
        }

        private void selectAlbumArtBtn_Click(object sender, EventArgs e)
        {
            //creates a dialog that selects an image file
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select album art";
            dlg.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //Set the image to the file after some conversions etc
                currentMp3.Tag.Pictures = new TagLib.IPicture[]
                {
                    new TagLib.Picture(new TagLib.ByteVector((byte[])new System.Drawing.ImageConverter().ConvertTo(System.Drawing.Image.FromFile(dlg.FileName), typeof(byte[]))))
                };
            }
            dlg.Dispose();
            //Sets the text boxes on Form1
            setAlbumArt(currentMp3);
        }

        private void exportToFolderBtn_Click(object sender, EventArgs e)
        {
            //Loop through every MP3 in folder, get genre, artist, album, check if folder exists, if not create, and place in folder
            //No need for parralel foreach as the disk transfer is the bottleneck.
            folderProgressBar.Maximum = mp3ListBox.Items.Count;
            int mp3 = 0;
            foreach (string item in mp3ListBox.Items)
            {
                mp3++;
                TagLib.File workingMp3 = TagLib.File.Create(item);
                string genre = workingMp3.Tag.FirstGenre;
                string artist = workingMp3.Tag.FirstPerformer;
                string album = workingMp3.Tag.Album;
                createFolders(item, genre, artist, album);
                folderProgressBar.Value = mp3;
            }
            MessageBox.Show("All MP3s arranged according to ID3 tags", "Operation complete", MessageBoxButtons.OK);
        }

        private void createFolders(string i, string g, string ar, string al)
        {
            string dir = rootDir + g + "\\" + ar + "\\" + al;
            //Remove invalid chars such as >
            dir = dir.Trim(Path.GetInvalidFileNameChars());
            dir = dir.Trim(Path.GetInvalidPathChars());
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            moveItemToDir(i, dir);
        }

        private void moveItemToDir(string sourceFile, string dir)
        {
            string fileName = sourceFile.Substring(sourceFile.LastIndexOf("\\") + 1);
            string destFile = dir + "\\" + fileName;
            try
            {
                File.Copy(sourceFile, destFile, false);
            }
            catch (IOException er)
            {
                MessageBox.Show("One or more files already exists and will not be overwritten! Please check " + rootDir + " is free. Aborting...");
            }

        }

        #endregion

        #region Playback
        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            //If there is an item selected, set the URL to the location and play the music
            if (mp3Location != null)
            {
                playMusic();
            }
            else
            {
                MessageBox.Show("No track selected!");
            }
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            //Set the volume to the value on the volume bar
            int vol = volumeBar.Value;
            wplayer.settings.volume = vol;
            volumeLbl.Text = "Volume: " + vol.ToString();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopMusic();
        }

        private void stopMusic()
        {
            //Stops the music, sets the url to null and changed a label
            wplayer.controls.stop();
            wplayer.URL = null;
            playStateLbl.Text = "Not playing";
        }

        private void playMusic()
        {
            //Sets the URL to the mp3 and plays it
            wplayer.URL = mp3Location;
            wplayer.controls.play();
            playStateLbl.Text = "Playing music...";
        }
        #endregion

        #region id3stuff
        private void mp3ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mp3ListBox.SelectedItem != null)
            {
                stopMusic();

                enableButtons();

                //Gets the location as a string and finds the actual file name by assuming the name is what ever the last item in the string is
                mp3Location = mp3ListBox.SelectedItem.ToString();
                string fileName = mp3Location.Substring(mp3Location.LastIndexOf("\\") + 1);

                //Sets relevant lables to the file name
                id3titleLbl.Text = "Edit ID3 Tags for: " + fileName;
                previewLbl.Text = "Preview " + fileName;

                //Set the current mp3 to a TagLib file using the global mp3Location
                currentMp3 = TagLib.File.Create(mp3Location);
                setTextBoxes(currentMp3);
                setAlbumArt(currentMp3);

            }
        }

        private void saveId3Btn_Click(object sender, EventArgs e)
        {
            //Stops the music (so the file is not in use), adds the id3 to the file and saves the file
            stopMusic();
            addid3(currentMp3);
            currentMp3.Save();
            MessageBox.Show("ID3 Tags saved!", "Operation Complete", MessageBoxButtons.OK);
        }

        private void setAlbumArt(TagLib.File file)
        {
            //If the mp3 has album art, set it. Otherwise set a blank image.
            try
            {
                albumArt.Image = Image.FromStream(new MemoryStream(file.Tag.Pictures[0].Data.Data));
            }
            catch (IndexOutOfRangeException)
            {
                albumArt.Image = null;
            }
        }

        private void addid3(TagLib.File file)
        {
            //Add all the string tags
            file.Tag.Title = trackTitleTxtBox.Text;
            file.Tag.Album = albumTxtBox.Text;
            file.Tag.Performers = null;
            file.Tag.Performers = new[] { artistTxtBox.Text };

            file.Tag.AlbumArtists = null;
            file.Tag.AlbumArtists = new[] { albumArtistTxtBox.Text };

            file.Tag.Genres = null;
            file.Tag.Genres = new[] { genreTxtBox.Text };


            //Converts from the decimal for the updown control to a uint
            decimal year = yearUpDown.Value;
            file.Tag.Year = Convert.ToUInt32(year);

            decimal trackNo = trackNoUpDown.Value;
            file.Tag.Track = Convert.ToUInt32(trackNo);
        }
        #endregion

        #region Controls
        private void setTextBoxes(TagLib.File file)
        {
            //Set the properties of text boxes etc to the tags from the TagLib file (currentMp3)
            trackTitleTxtBox.Text = file.Tag.Title;
            albumTxtBox.Text = file.Tag.Album;
            artistTxtBox.Text = file.Tag.FirstPerformer;
            albumArtistTxtBox.Text = file.Tag.FirstAlbumArtist;
            genreTxtBox.Text = file.Tag.FirstGenre;
            yearUpDown.Value = file.Tag.Year;
            trackNoUpDown.Value = file.Tag.Track;
            setAlbumArt(file);

        }

        private void enableButtons()
        {
            //Enables buttons that would cause errors if no MP3 is selected
            playPauseBtn.Enabled = true;
            stopBtn.Enabled = true;
            selectAlbumArtBtn.Enabled = true;
            saveId3Btn.Enabled = true;
            exportToFolderBtn.Enabled = true;
            copyBtn.Enabled = true;
            pasteBtn.Enabled = true;
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A small program that loads all MP3 files within a folder before allowing the user to preview them and edit the ID3 tags before exporting them to a folder structure determined by the ID3 tags.\n\nWritten by Alex Shaw with C# and Windows Forms, (c) 2016 \n\nLibTag-Sharp used.", "About Program", MessageBoxButtons.OK);
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)Select a folder with your MP3s inside.\n2)Select a file to edit\n3)Edit the ID3 tags and add album art\n4)Click \"Save and overwrite tags\"\n5)Once all files have been edited, click \"Export music to folders\"", "How to use!", MessageBoxButtons.OK);
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            //Set the values of the copy MP3 to current MP3
            copy = currentMp3;
            //Remove specific info
            copy.Tag.Title = null;
            copy.Tag.Track = 0;
            MessageBox.Show("Album information copied!");
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            if (copy != null)
            {
                setTextBoxes(copy);
            }
            else
            {
                MessageBox.Show("Nothing has been copied!");
            }
        }
        #endregion
    }
}
