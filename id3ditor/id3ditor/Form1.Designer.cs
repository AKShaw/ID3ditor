namespace id3ditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mp3ListBox = new System.Windows.Forms.ListBox();
            this.musicBoxLbl = new System.Windows.Forms.Label();
            this.selectDirBtn = new System.Windows.Forms.Button();
            this.mp3CountLbl = new System.Windows.Forms.Label();
            this.id3panel = new System.Windows.Forms.Panel();
            this.selectAlbumArtBtn = new System.Windows.Forms.Button();
            this.albumArt = new System.Windows.Forms.PictureBox();
            this.trackNoUpDown = new System.Windows.Forms.NumericUpDown();
            this.trackNoLbl = new System.Windows.Forms.Label();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearLbl = new System.Windows.Forms.Label();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.genreLbl = new System.Windows.Forms.Label();
            this.albumArtistTxtBox = new System.Windows.Forms.TextBox();
            this.albumArtistLbl = new System.Windows.Forms.Label();
            this.artistTxtBox = new System.Windows.Forms.TextBox();
            this.artistLbl = new System.Windows.Forms.Label();
            this.albumTxtBox = new System.Windows.Forms.TextBox();
            this.albumLbl = new System.Windows.Forms.Label();
            this.trackTitleTxtBox = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.id3titleLbl = new System.Windows.Forms.Label();
            this.playPauseBtn = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playStateLbl = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.previewLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveId3Btn = new System.Windows.Forms.Button();
            this.id3panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mp3ListBox
            // 
            this.mp3ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mp3ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mp3ListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.mp3ListBox.FormattingEnabled = true;
            this.mp3ListBox.HorizontalScrollbar = true;
            this.mp3ListBox.Location = new System.Drawing.Point(12, 94);
            this.mp3ListBox.Name = "mp3ListBox";
            this.mp3ListBox.Size = new System.Drawing.Size(441, 433);
            this.mp3ListBox.TabIndex = 0;
            this.mp3ListBox.SelectedIndexChanged += new System.EventHandler(this.mp3ListBox_SelectedIndexChanged);
            // 
            // musicBoxLbl
            // 
            this.musicBoxLbl.AutoSize = true;
            this.musicBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicBoxLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.musicBoxLbl.Location = new System.Drawing.Point(12, 27);
            this.musicBoxLbl.Name = "musicBoxLbl";
            this.musicBoxLbl.Size = new System.Drawing.Size(176, 20);
            this.musicBoxLbl.TabIndex = 1;
            this.musicBoxLbl.Text = "List of MP3s in directory";
            // 
            // selectDirBtn
            // 
            this.selectDirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.selectDirBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.selectDirBtn.Location = new System.Drawing.Point(12, 50);
            this.selectDirBtn.Name = "selectDirBtn";
            this.selectDirBtn.Size = new System.Drawing.Size(441, 38);
            this.selectDirBtn.TabIndex = 3;
            this.selectDirBtn.Text = "Select folder with music";
            this.selectDirBtn.UseVisualStyleBackColor = false;
            this.selectDirBtn.Click += new System.EventHandler(this.selectDirBtn_Click);
            // 
            // mp3CountLbl
            // 
            this.mp3CountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mp3CountLbl.AutoSize = true;
            this.mp3CountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.mp3CountLbl.Location = new System.Drawing.Point(13, 534);
            this.mp3CountLbl.Name = "mp3CountLbl";
            this.mp3CountLbl.Size = new System.Drawing.Size(101, 13);
            this.mp3CountLbl.TabIndex = 4;
            this.mp3CountLbl.Text = "Total MP3 Count: --";
            // 
            // id3panel
            // 
            this.id3panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.id3panel.Controls.Add(this.saveId3Btn);
            this.id3panel.Controls.Add(this.selectAlbumArtBtn);
            this.id3panel.Controls.Add(this.albumArt);
            this.id3panel.Controls.Add(this.trackNoUpDown);
            this.id3panel.Controls.Add(this.trackNoLbl);
            this.id3panel.Controls.Add(this.yearUpDown);
            this.id3panel.Controls.Add(this.yearLbl);
            this.id3panel.Controls.Add(this.genreTxtBox);
            this.id3panel.Controls.Add(this.genreLbl);
            this.id3panel.Controls.Add(this.albumArtistTxtBox);
            this.id3panel.Controls.Add(this.albumArtistLbl);
            this.id3panel.Controls.Add(this.artistTxtBox);
            this.id3panel.Controls.Add(this.artistLbl);
            this.id3panel.Controls.Add(this.albumTxtBox);
            this.id3panel.Controls.Add(this.albumLbl);
            this.id3panel.Controls.Add(this.trackTitleTxtBox);
            this.id3panel.Controls.Add(this.titleLbl);
            this.id3panel.Controls.Add(this.id3titleLbl);
            this.id3panel.Location = new System.Drawing.Point(459, 95);
            this.id3panel.Name = "id3panel";
            this.id3panel.Size = new System.Drawing.Size(513, 432);
            this.id3panel.TabIndex = 5;
            // 
            // selectAlbumArtBtn
            // 
            this.selectAlbumArtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.selectAlbumArtBtn.Enabled = false;
            this.selectAlbumArtBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.selectAlbumArtBtn.Location = new System.Drawing.Point(11, 406);
            this.selectAlbumArtBtn.Name = "selectAlbumArtBtn";
            this.selectAlbumArtBtn.Size = new System.Drawing.Size(240, 23);
            this.selectAlbumArtBtn.TabIndex = 16;
            this.selectAlbumArtBtn.Text = "Select album art";
            this.selectAlbumArtBtn.UseVisualStyleBackColor = false;
            this.selectAlbumArtBtn.Click += new System.EventHandler(this.selectAlbumArtBtn_Click);
            // 
            // albumArt
            // 
            this.albumArt.Image = ((System.Drawing.Image)(resources.GetObject("albumArt.Image")));
            this.albumArt.Location = new System.Drawing.Point(11, 160);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(240, 240);
            this.albumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumArt.TabIndex = 15;
            this.albumArt.TabStop = false;
            // 
            // trackNoUpDown
            // 
            this.trackNoUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.trackNoUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.trackNoUpDown.Location = new System.Drawing.Point(275, 309);
            this.trackNoUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.trackNoUpDown.Name = "trackNoUpDown";
            this.trackNoUpDown.Size = new System.Drawing.Size(213, 21);
            this.trackNoUpDown.TabIndex = 14;
            // 
            // trackNoLbl
            // 
            this.trackNoLbl.AutoSize = true;
            this.trackNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackNoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.trackNoLbl.Location = new System.Drawing.Point(271, 286);
            this.trackNoLbl.Name = "trackNoLbl";
            this.trackNoLbl.Size = new System.Drawing.Size(61, 20);
            this.trackNoLbl.TabIndex = 13;
            this.trackNoLbl.Text = "Track #";
            // 
            // yearUpDown
            // 
            this.yearUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.yearUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.yearUpDown.Location = new System.Drawing.Point(275, 247);
            this.yearUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(213, 21);
            this.yearUpDown.TabIndex = 12;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.yearLbl.Location = new System.Drawing.Point(271, 224);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(43, 20);
            this.yearLbl.TabIndex = 11;
            this.yearLbl.Text = "Year";
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.genreTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.genreTxtBox.Location = new System.Drawing.Point(275, 183);
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(213, 21);
            this.genreTxtBox.TabIndex = 10;
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.genreLbl.Location = new System.Drawing.Point(271, 160);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(54, 20);
            this.genreLbl.TabIndex = 9;
            this.genreLbl.Text = "Genre";
            // 
            // albumArtistTxtBox
            // 
            this.albumArtistTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.albumArtistTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.albumArtistTxtBox.Location = new System.Drawing.Point(275, 120);
            this.albumArtistTxtBox.Name = "albumArtistTxtBox";
            this.albumArtistTxtBox.Size = new System.Drawing.Size(213, 21);
            this.albumArtistTxtBox.TabIndex = 8;
            // 
            // albumArtistLbl
            // 
            this.albumArtistLbl.AutoSize = true;
            this.albumArtistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtistLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.albumArtistLbl.Location = new System.Drawing.Point(271, 97);
            this.albumArtistLbl.Name = "albumArtistLbl";
            this.albumArtistLbl.Size = new System.Drawing.Size(95, 20);
            this.albumArtistLbl.TabIndex = 7;
            this.albumArtistLbl.Text = "Album Artist";
            // 
            // artistTxtBox
            // 
            this.artistTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.artistTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.artistTxtBox.Location = new System.Drawing.Point(275, 56);
            this.artistTxtBox.Name = "artistTxtBox";
            this.artistTxtBox.Size = new System.Drawing.Size(213, 21);
            this.artistTxtBox.TabIndex = 6;
            // 
            // artistLbl
            // 
            this.artistLbl.AutoSize = true;
            this.artistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.artistLbl.Location = new System.Drawing.Point(271, 33);
            this.artistLbl.Name = "artistLbl";
            this.artistLbl.Size = new System.Drawing.Size(46, 20);
            this.artistLbl.TabIndex = 5;
            this.artistLbl.Text = "Artist";
            // 
            // albumTxtBox
            // 
            this.albumTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.albumTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.albumTxtBox.Location = new System.Drawing.Point(16, 120);
            this.albumTxtBox.Name = "albumTxtBox";
            this.albumTxtBox.Size = new System.Drawing.Size(235, 21);
            this.albumTxtBox.TabIndex = 4;
            // 
            // albumLbl
            // 
            this.albumLbl.AutoSize = true;
            this.albumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.albumLbl.Location = new System.Drawing.Point(12, 97);
            this.albumLbl.Name = "albumLbl";
            this.albumLbl.Size = new System.Drawing.Size(54, 20);
            this.albumLbl.TabIndex = 3;
            this.albumLbl.Text = "Album";
            // 
            // trackTitleTxtBox
            // 
            this.trackTitleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.trackTitleTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.trackTitleTxtBox.Location = new System.Drawing.Point(16, 56);
            this.trackTitleTxtBox.Name = "trackTitleTxtBox";
            this.trackTitleTxtBox.Size = new System.Drawing.Size(235, 21);
            this.trackTitleTxtBox.TabIndex = 2;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.titleLbl.Location = new System.Drawing.Point(12, 33);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(81, 20);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Track Title";
            // 
            // id3titleLbl
            // 
            this.id3titleLbl.AutoSize = true;
            this.id3titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id3titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.id3titleLbl.Location = new System.Drawing.Point(4, 4);
            this.id3titleLbl.Name = "id3titleLbl";
            this.id3titleLbl.Size = new System.Drawing.Size(137, 16);
            this.id3titleLbl.TabIndex = 0;
            this.id3titleLbl.Text = "Edit ID3 Tags for MP3";
            // 
            // playPauseBtn
            // 
            this.playPauseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.playPauseBtn.Enabled = false;
            this.playPauseBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.playPauseBtn.Location = new System.Drawing.Point(10, 23);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(135, 38);
            this.playPauseBtn.TabIndex = 1;
            this.playPauseBtn.Text = "Play music";
            this.playPauseBtn.UseVisualStyleBackColor = false;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBar.Location = new System.Drawing.Point(288, 23);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(222, 45);
            this.volumeBar.TabIndex = 2;
            this.volumeBar.Value = 50;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.playStateLbl);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.volumeLbl);
            this.panel1.Controls.Add(this.volumeBar);
            this.panel1.Controls.Add(this.previewLbl);
            this.panel1.Controls.Add(this.playPauseBtn);
            this.panel1.Location = new System.Drawing.Point(459, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 62);
            this.panel1.TabIndex = 6;
            // 
            // playStateLbl
            // 
            this.playStateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playStateLbl.AutoSize = true;
            this.playStateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.playStateLbl.Location = new System.Drawing.Point(450, 6);
            this.playStateLbl.Name = "playStateLbl";
            this.playStateLbl.Size = new System.Drawing.Size(61, 13);
            this.playStateLbl.TabIndex = 5;
            this.playStateLbl.Text = "Not playing";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.stopBtn.Enabled = false;
            this.stopBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.stopBtn.Location = new System.Drawing.Point(151, 23);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(135, 38);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop music";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // volumeLbl
            // 
            this.volumeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.volumeLbl.Location = new System.Drawing.Point(288, 6);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(60, 13);
            this.volumeLbl.TabIndex = 3;
            this.volumeLbl.Text = "Volume: 50";
            // 
            // previewLbl
            // 
            this.previewLbl.AutoSize = true;
            this.previewLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.previewLbl.Location = new System.Drawing.Point(7, 4);
            this.previewLbl.Name = "previewLbl";
            this.previewLbl.Size = new System.Drawing.Size(86, 16);
            this.previewLbl.TabIndex = 0;
            this.previewLbl.Text = "Preview MP3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // saveId3Btn
            // 
            this.saveId3Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.saveId3Btn.Enabled = false;
            this.saveId3Btn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.saveId3Btn.Location = new System.Drawing.Point(275, 345);
            this.saveId3Btn.Name = "saveId3Btn";
            this.saveId3Btn.Size = new System.Drawing.Size(213, 38);
            this.saveId3Btn.TabIndex = 17;
            this.saveId3Btn.Text = "Save and overwrite tags";
            this.saveId3Btn.UseVisualStyleBackColor = false;
            this.saveId3Btn.Click += new System.EventHandler(this.saveId3Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.id3panel);
            this.Controls.Add(this.mp3CountLbl);
            this.Controls.Add(this.selectDirBtn);
            this.Controls.Add(this.musicBoxLbl);
            this.Controls.Add(this.mp3ListBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 525);
            this.Name = "Form1";
            this.Text = "ID3DITOR";
            this.id3panel.ResumeLayout(false);
            this.id3panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mp3ListBox;
        private System.Windows.Forms.Label musicBoxLbl;
        private System.Windows.Forms.Button selectDirBtn;
        private System.Windows.Forms.Label mp3CountLbl;
        private System.Windows.Forms.Panel id3panel;
        private System.Windows.Forms.Label id3titleLbl;
        private System.Windows.Forms.Button playPauseBtn;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label previewLbl;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label playStateLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.TextBox albumArtistTxtBox;
        private System.Windows.Forms.Label albumArtistLbl;
        private System.Windows.Forms.TextBox artistTxtBox;
        private System.Windows.Forms.Label artistLbl;
        private System.Windows.Forms.TextBox albumTxtBox;
        private System.Windows.Forms.Label albumLbl;
        private System.Windows.Forms.TextBox trackTitleTxtBox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.NumericUpDown trackNoUpDown;
        private System.Windows.Forms.Label trackNoLbl;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.TextBox genreTxtBox;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.PictureBox albumArt;
        private System.Windows.Forms.Button selectAlbumArtBtn;
        private System.Windows.Forms.Button saveId3Btn;
    }
}

