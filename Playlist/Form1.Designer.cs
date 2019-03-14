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
            this.btnFirstItem = new System.Windows.Forms.Button();
            this.btnPrevItem = new System.Windows.Forms.Button();
            this.btnNextItem = new System.Windows.Forms.Button();
            this.btnLastItem = new System.Windows.Forms.Button();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.groupDescription = new System.Windows.Forms.GroupBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSongs
            // 
            this.lstSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 18;
            this.lstSongs.Location = new System.Drawing.Point(12, 31);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(279, 364);
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
            // btnFirstItem
            // 
            this.btnFirstItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstItem.Location = new System.Drawing.Point(12, 158);
            this.btnFirstItem.Name = "btnFirstItem";
            this.btnFirstItem.Size = new System.Drawing.Size(40, 30);
            this.btnFirstItem.TabIndex = 6;
            this.btnFirstItem.Text = "l<<";
            this.btnFirstItem.UseVisualStyleBackColor = true;
            this.btnFirstItem.Click += new System.EventHandler(this.btnFirstItem_Click);
            // 
            // btnPrevItem
            // 
            this.btnPrevItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevItem.Location = new System.Drawing.Point(58, 158);
            this.btnPrevItem.Name = "btnPrevItem";
            this.btnPrevItem.Size = new System.Drawing.Size(40, 30);
            this.btnPrevItem.TabIndex = 7;
            this.btnPrevItem.Text = "<";
            this.btnPrevItem.UseVisualStyleBackColor = true;
            this.btnPrevItem.Click += new System.EventHandler(this.btnPrevItem_Click);
            // 
            // btnNextItem
            // 
            this.btnNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextItem.Location = new System.Drawing.Point(104, 158);
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.Size = new System.Drawing.Size(40, 30);
            this.btnNextItem.TabIndex = 8;
            this.btnNextItem.Text = ">";
            this.btnNextItem.UseVisualStyleBackColor = true;
            this.btnNextItem.Click += new System.EventHandler(this.btnNextItem_Click);
            // 
            // btnLastItem
            // 
            this.btnLastItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastItem.Location = new System.Drawing.Point(150, 158);
            this.btnLastItem.Name = "btnLastItem";
            this.btnLastItem.Size = new System.Drawing.Size(40, 30);
            this.btnLastItem.TabIndex = 9;
            this.btnLastItem.Text = ">>l";
            this.btnLastItem.UseVisualStyleBackColor = true;
            this.btnLastItem.Click += new System.EventHandler(this.btnLastItem_Click);
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
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 401);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(120, 30);
            this.btnSelectFolder.TabIndex = 15;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(310, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "[]";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(391, 238);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 30);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = ">";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(472, 238);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 30);
            this.btnPause.TabIndex = 18;
            this.btnPause.Text = "ll";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 441);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.groupDescription);
            this.Controls.Add(this.lstSongs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupDescription.ResumeLayout(false);
            this.groupDescription.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
    }
}

