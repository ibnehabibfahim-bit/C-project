
namespace MovieR
{
    partial class MovieForm
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
            this.MName = new System.Windows.Forms.Label();
            this.tb_Movie = new System.Windows.Forms.TextBox();
            this.tb_ActorName = new System.Windows.Forms.TextBox();
            this.ActorName = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bClick = new System.Windows.Forms.Button();
            this.tb_ActressName = new System.Windows.Forms.TextBox();
            this.ActressName = new System.Windows.Forms.Label();
            this.tb_Genre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.tb_Rating = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.tb_MID = new System.Windows.Forms.TextBox();
            this.labelMID = new System.Windows.Forms.Label();
            this.bNext = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_release = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.cb_Hall = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // MName
            // 
            this.MName.AutoSize = true;
            this.MName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MName.Location = new System.Drawing.Point(5, 74);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(133, 24);
            this.MName.TabIndex = 0;
            this.MName.Text = "Movie Name:";
            this.MName.Click += new System.EventHandler(this.MName_Click);
            // 
            // tb_Movie
            // 
            this.tb_Movie.Location = new System.Drawing.Point(157, 76);
            this.tb_Movie.Name = "tb_Movie";
            this.tb_Movie.Size = new System.Drawing.Size(100, 22);
            this.tb_Movie.TabIndex = 1;
            this.tb_Movie.TextChanged += new System.EventHandler(this.tb_Movie_TextChanged);
            // 
            // tb_ActorName
            // 
            this.tb_ActorName.Location = new System.Drawing.Point(157, 115);
            this.tb_ActorName.Name = "tb_ActorName";
            this.tb_ActorName.Size = new System.Drawing.Size(100, 22);
            this.tb_ActorName.TabIndex = 5;
            // 
            // ActorName
            // 
            this.ActorName.AutoSize = true;
            this.ActorName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorName.Location = new System.Drawing.Point(67, 113);
            this.ActorName.Name = "ActorName";
            this.ActorName.Size = new System.Drawing.Size(71, 24);
            this.ActorName.TabIndex = 4;
            this.ActorName.Text = " Actor:";
            this.ActorName.Click += new System.EventHandler(this.ActorName_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Crimson;
            this.bExit.Location = new System.Drawing.Point(12, 475);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 58);
            this.bExit.TabIndex = 8;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bClick
            // 
            this.bClick.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bClick.Location = new System.Drawing.Point(220, 475);
            this.bClick.Name = "bClick";
            this.bClick.Size = new System.Drawing.Size(75, 58);
            this.bClick.TabIndex = 9;
            this.bClick.Text = "Click";
            this.bClick.UseVisualStyleBackColor = false;
            this.bClick.Click += new System.EventHandler(this.bClick_Click);
            // 
            // tb_ActressName
            // 
            this.tb_ActressName.Location = new System.Drawing.Point(157, 155);
            this.tb_ActressName.Name = "tb_ActressName";
            this.tb_ActressName.Size = new System.Drawing.Size(100, 22);
            this.tb_ActressName.TabIndex = 11;
            this.tb_ActressName.TextChanged += new System.EventHandler(this.tb_ActressName_TextChanged);
            // 
            // ActressName
            // 
            this.ActressName.AutoSize = true;
            this.ActressName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActressName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActressName.Location = new System.Drawing.Point(53, 153);
            this.ActressName.Name = "ActressName";
            this.ActressName.Size = new System.Drawing.Size(85, 24);
            this.ActressName.TabIndex = 10;
            this.ActressName.Text = "Actress:";
            // 
            // tb_Genre
            // 
            this.tb_Genre.Location = new System.Drawing.Point(157, 204);
            this.tb_Genre.Name = "tb_Genre";
            this.tb_Genre.Size = new System.Drawing.Size(100, 22);
            this.tb_Genre.TabIndex = 17;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(64, 202);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(74, 24);
            this.labelGenre.TabIndex = 16;
            this.labelGenre.Text = "Genre:";
            this.labelGenre.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_Rating
            // 
            this.tb_Rating.Location = new System.Drawing.Point(157, 250);
            this.tb_Rating.Name = "tb_Rating";
            this.tb_Rating.Size = new System.Drawing.Size(100, 22);
            this.tb_Rating.TabIndex = 19;
            this.tb_Rating.TextChanged += new System.EventHandler(this.tb_Rating_TextChanged);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(66, 250);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(75, 24);
            this.labelRating.TabIndex = 18;
            this.labelRating.Text = "Rating:";
            this.labelRating.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_MID
            // 
            this.tb_MID.Location = new System.Drawing.Point(157, 37);
            this.tb_MID.Name = "tb_MID";
            this.tb_MID.Size = new System.Drawing.Size(100, 22);
            this.tb_MID.TabIndex = 21;
            this.tb_MID.TextChanged += new System.EventHandler(this.tb_MID_TextChanged);
            // 
            // labelMID
            // 
            this.labelMID.AutoSize = true;
            this.labelMID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMID.Location = new System.Drawing.Point(86, 35);
            this.labelMID.Name = "labelMID";
            this.labelMID.Size = new System.Drawing.Size(52, 24);
            this.labelMID.TabIndex = 20;
            this.labelMID.Text = "MID:";
            // 
            // bNext
            // 
            this.bNext.BackColor = System.Drawing.Color.Lime;
            this.bNext.Location = new System.Drawing.Point(115, 475);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 58);
            this.bNext.TabIndex = 22;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.MistyRose;
            this.btn_submit.Location = new System.Drawing.Point(84, 418);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(187, 36);
            this.btn_submit.TabIndex = 23;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(390, 74);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(647, 370);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showAll.Location = new System.Drawing.Point(371, 461);
            this.btn_showAll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(121, 50);
            this.btn_showAll.TabIndex = 25;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Yellow;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(509, 461);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 50);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(622, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 461);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search (By Movie Name):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(745, 494);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(233, 39);
            this.tb_Search.TabIndex = 29;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Release:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dt_release
            // 
            this.dt_release.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_release.Location = new System.Drawing.Point(157, 329);
            this.dt_release.Margin = new System.Windows.Forms.Padding(4);
            this.dt_release.Name = "dt_release";
            this.dt_release.Size = new System.Drawing.Size(207, 22);
            this.dt_release.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "MOVIE SITE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.Location = new System.Drawing.Point(89, 290);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(52, 24);
            this.lblHall.TabIndex = 33;
            this.lblHall.Text = "Hall:";
            // 
            // cb_Hall
            // 
            this.cb_Hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Hall.FormattingEnabled = true;
            this.cb_Hall.Items.AddRange(new object[] {
            "Hall 1",
            "Hall 2",
            "Hall 3",
            "Hall 4"});
            this.cb_Hall.Location = new System.Drawing.Point(157, 286);
            this.cb_Hall.Name = "cb_Hall";
            this.cb_Hall.Size = new System.Drawing.Size(121, 24);
            this.cb_Hall.TabIndex = 34;
            this.cb_Hall.SelectedIndexChanged += new System.EventHandler(this.cb_Hall_SelectedIndexChanged);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MovieR.Properties.Resources.technology_movies_projector_8mm_film_reel_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 588);
            this.Controls.Add(this.cb_Hall);
            this.Controls.Add(this.lblHall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_release);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.tb_MID);
            this.Controls.Add(this.labelMID);
            this.Controls.Add(this.tb_Rating);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.tb_Genre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.tb_ActressName);
            this.Controls.Add(this.ActressName);
            this.Controls.Add(this.bClick);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tb_ActorName);
            this.Controls.Add(this.ActorName);
            this.Controls.Add(this.tb_Movie);
            this.Controls.Add(this.MName);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MName;
        private System.Windows.Forms.TextBox tb_Movie;
        private System.Windows.Forms.TextBox tb_ActorName;
        private System.Windows.Forms.Label ActorName;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bClick;
        private System.Windows.Forms.TextBox tb_ActressName;
        private System.Windows.Forms.Label ActressName;
        private System.Windows.Forms.TextBox tb_Genre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox tb_Rating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox tb_MID;
        private System.Windows.Forms.Label labelMID;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_release;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.ComboBox cb_Hall;
    }
}

