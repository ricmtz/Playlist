namespace Playlist
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
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.groupDescription = new System.Windows.Forms.GroupBox();
            this.btnLastItem = new System.Windows.Forms.Button();
            this.btnFirstItem = new System.Windows.Forms.Button();
            this.btnNextItem = new System.Windows.Forms.Button();
            this.btnPrevItem = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabResult1 = new System.Windows.Forms.TabPage();
            this.ptrBox1 = new System.Windows.Forms.PictureBox();
            this.tabResult2 = new System.Windows.Forms.TabPage();
            this.ptrBox2 = new System.Windows.Forms.PictureBox();
            this.tabResult3 = new System.Windows.Forms.TabPage();
            this.ptrBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.itemShort = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReset = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupDescription.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tabResult1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox1)).BeginInit();
            this.tabResult2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox2)).BeginInit();
            this.tabResult3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSongs
            // 
            this.lstSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 18;
            this.lstSongs.Location = new System.Drawing.Point(12, 31);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(279, 436);
            this.lstSongs.TabIndex = 0;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(9, 33);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(45, 18);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Artist:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(9, 65);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(53, 18);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "Album:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(12, 95);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 18);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(9, 125);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 18);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.Color.White;
            this.txtArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(69, 30);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.ReadOnly = true;
            this.txtArtist.Size = new System.Drawing.Size(264, 24);
            this.txtArtist.TabIndex = 10;
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.Color.White;
            this.txtAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbum.Location = new System.Drawing.Point(69, 62);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(264, 24);
            this.txtAlbum.TabIndex = 11;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(69, 92);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(264, 24);
            this.txtYear.TabIndex = 12;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.White;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(69, 122);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(264, 24);
            this.txtGender.TabIndex = 13;
            // 
            // groupDescription
            // 
            this.groupDescription.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupDescription.Controls.Add(this.btnLastItem);
            this.groupDescription.Controls.Add(this.txtGender);
            this.groupDescription.Controls.Add(this.lblArtist);
            this.groupDescription.Controls.Add(this.txtYear);
            this.groupDescription.Controls.Add(this.lblAlbum);
            this.groupDescription.Controls.Add(this.txtAlbum);
            this.groupDescription.Controls.Add(this.lblYear);
            this.groupDescription.Controls.Add(this.txtArtist);
            this.groupDescription.Controls.Add(this.lblGender);
            this.groupDescription.Controls.Add(this.btnFirstItem);
            this.groupDescription.Controls.Add(this.btnNextItem);
            this.groupDescription.Controls.Add(this.btnPrevItem);
            this.groupDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDescription.Location = new System.Drawing.Point(310, 31);
            this.groupDescription.Name = "groupDescription";
            this.groupDescription.Size = new System.Drawing.Size(344, 201);
            this.groupDescription.TabIndex = 14;
            this.groupDescription.TabStop = false;
            this.groupDescription.Text = "Descripton";
            this.groupDescription.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLastItem
            // 
            this.btnLastItem.BackColor = System.Drawing.Color.White;
            this.btnLastItem.BackgroundImage = global::Playlist.Properties.Resources.lastOne;
            this.btnLastItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLastItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastItem.Location = new System.Drawing.Point(150, 158);
            this.btnLastItem.Name = "btnLastItem";
            this.btnLastItem.Size = new System.Drawing.Size(40, 30);
            this.btnLastItem.TabIndex = 9;
            this.btnLastItem.UseVisualStyleBackColor = false;
            this.btnLastItem.Click += new System.EventHandler(this.btnLastItem_Click);
            // 
            // btnFirstItem
            // 
            this.btnFirstItem.BackColor = System.Drawing.Color.White;
            this.btnFirstItem.BackgroundImage = global::Playlist.Properties.Resources.firstOne;
            this.btnFirstItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirstItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstItem.Location = new System.Drawing.Point(12, 158);
            this.btnFirstItem.Name = "btnFirstItem";
            this.btnFirstItem.Size = new System.Drawing.Size(40, 30);
            this.btnFirstItem.TabIndex = 6;
            this.btnFirstItem.UseVisualStyleBackColor = false;
            this.btnFirstItem.Click += new System.EventHandler(this.btnFirstItem_Click);
            // 
            // btnNextItem
            // 
            this.btnNextItem.BackColor = System.Drawing.Color.White;
            this.btnNextItem.BackgroundImage = global::Playlist.Properties.Resources.nextOne;
            this.btnNextItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextItem.Location = new System.Drawing.Point(104, 158);
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.Size = new System.Drawing.Size(40, 30);
            this.btnNextItem.TabIndex = 8;
            this.btnNextItem.UseVisualStyleBackColor = false;
            this.btnNextItem.Click += new System.EventHandler(this.btnNextItem_Click);
            // 
            // btnPrevItem
            // 
            this.btnPrevItem.BackgroundImage = global::Playlist.Properties.Resources.prevOne;
            this.btnPrevItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevItem.Location = new System.Drawing.Point(58, 158);
            this.btnPrevItem.Name = "btnPrevItem";
            this.btnPrevItem.Size = new System.Drawing.Size(40, 30);
            this.btnPrevItem.TabIndex = 7;
            this.btnPrevItem.UseVisualStyleBackColor = true;
            this.btnPrevItem.Click += new System.EventHandler(this.btnPrevItem_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.White;
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 475);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(120, 30);
            this.btnSelectFolder.TabIndex = 15;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(310, 274);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 24);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(578, 271);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabResult1);
            this.tabCtrl.Controls.Add(this.tabResult2);
            this.tabCtrl.Controls.Add(this.tabResult3);
            this.tabCtrl.Location = new System.Drawing.Point(310, 307);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(343, 193);
            this.tabCtrl.TabIndex = 21;
            // 
            // tabResult1
            // 
            this.tabResult1.Controls.Add(this.ptrBox1);
            this.tabResult1.Location = new System.Drawing.Point(4, 22);
            this.tabResult1.Name = "tabResult1";
            this.tabResult1.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult1.Size = new System.Drawing.Size(335, 167);
            this.tabResult1.TabIndex = 0;
            this.tabResult1.Text = "Result1";
            this.tabResult1.UseVisualStyleBackColor = true;
            // 
            // ptrBox1
            // 
            this.ptrBox1.Location = new System.Drawing.Point(0, 0);
            this.ptrBox1.Name = "ptrBox1";
            this.ptrBox1.Size = new System.Drawing.Size(335, 167);
            this.ptrBox1.TabIndex = 0;
            this.ptrBox1.TabStop = false;
            // 
            // tabResult2
            // 
            this.tabResult2.Controls.Add(this.ptrBox2);
            this.tabResult2.Location = new System.Drawing.Point(4, 22);
            this.tabResult2.Name = "tabResult2";
            this.tabResult2.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult2.Size = new System.Drawing.Size(335, 167);
            this.tabResult2.TabIndex = 1;
            this.tabResult2.Text = "Result2";
            this.tabResult2.UseVisualStyleBackColor = true;
            // 
            // ptrBox2
            // 
            this.ptrBox2.Location = new System.Drawing.Point(0, 0);
            this.ptrBox2.Name = "ptrBox2";
            this.ptrBox2.Size = new System.Drawing.Size(335, 167);
            this.ptrBox2.TabIndex = 0;
            this.ptrBox2.TabStop = false;
            // 
            // tabResult3
            // 
            this.tabResult3.Controls.Add(this.ptrBox3);
            this.tabResult3.Location = new System.Drawing.Point(4, 22);
            this.tabResult3.Name = "tabResult3";
            this.tabResult3.Size = new System.Drawing.Size(335, 167);
            this.tabResult3.TabIndex = 2;
            this.tabResult3.Text = "Result3";
            this.tabResult3.UseVisualStyleBackColor = true;
            // 
            // ptrBox3
            // 
            this.ptrBox3.Location = new System.Drawing.Point(0, 0);
            this.ptrBox3.Name = "ptrBox3";
            this.ptrBox3.Size = new System.Drawing.Size(335, 167);
            this.ptrBox3.TabIndex = 0;
            this.ptrBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFilter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFilter
            // 
            this.menuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemShort,
            this.itemMedium,
            this.itemLong,
            this.itemReset});
            this.menuFilter.Name = "menuFilter";
            this.menuFilter.Size = new System.Drawing.Size(50, 20);
            this.menuFilter.Text = "Filters";
            // 
            // itemShort
            // 
            this.itemShort.Name = "itemShort";
            this.itemShort.Size = new System.Drawing.Size(168, 22);
            this.itemShort.Text = "Short Duration";
            this.itemShort.Click += new System.EventHandler(this.itemShort_Click);
            // 
            // itemMedium
            // 
            this.itemMedium.Name = "itemMedium";
            this.itemMedium.Size = new System.Drawing.Size(168, 22);
            this.itemMedium.Text = "Medium Duration";
            this.itemMedium.Click += new System.EventHandler(this.itemMedium_Click);
            // 
            // itemLong
            // 
            this.itemLong.Name = "itemLong";
            this.itemLong.Size = new System.Drawing.Size(168, 22);
            this.itemLong.Text = "Long Duration";
            this.itemLong.Click += new System.EventHandler(this.itemLong_Click);
            // 
            // itemReset
            // 
            this.itemReset.Name = "itemReset";
            this.itemReset.Size = new System.Drawing.Size(168, 22);
            this.itemReset.Text = "Reset list";
            this.itemReset.Click += new System.EventHandler(this.itemReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.BackgroundImage = global::Playlist.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(395, 235);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(45, 30);
            this.btnPause.TabIndex = 18;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.BackgroundImage = global::Playlist.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(353, 235);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 30);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.BackgroundImage = global::Playlist.Properties.Resources.stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(310, 235);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 30);
            this.btnStop.TabIndex = 16;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Playlist.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 512);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.groupDescription);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupDescription.ResumeLayout(false);
            this.groupDescription.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.tabResult1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox1)).EndInit();
            this.tabResult2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox2)).EndInit();
            this.tabResult3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnFirstItem;
        private System.Windows.Forms.Button btnPrevItem;
        private System.Windows.Forms.Button btnNextItem;
        private System.Windows.Forms.Button btnLastItem;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.GroupBox groupDescription;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabResult1;
        private System.Windows.Forms.TabPage tabResult2;
        private System.Windows.Forms.PictureBox ptrBox1;
        private System.Windows.Forms.PictureBox ptrBox2;
        private System.Windows.Forms.TabPage tabResult3;
        private System.Windows.Forms.PictureBox ptrBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFilter;
        private System.Windows.Forms.ToolStripMenuItem itemShort;
        private System.Windows.Forms.ToolStripMenuItem itemMedium;
        private System.Windows.Forms.ToolStripMenuItem itemLong;
        private System.Windows.Forms.ToolStripMenuItem itemReset;
    }
}

