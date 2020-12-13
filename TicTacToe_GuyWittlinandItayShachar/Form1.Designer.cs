
namespace TicTacToe_GuyWittlinandItayShachar
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
            this.components = new System.ComponentModel.Container();
            this.Restat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer_Text = new System.Windows.Forms.Label();
            this.TheSeconds = new System.Windows.Forms.Label();
            this.Turns = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox02 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox01 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox00 = new System.Windows.Forms.PictureBox();
            this.BackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Restat
            // 
            this.Restat.Location = new System.Drawing.Point(248, 555);
            this.Restat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Restat.Name = "Restat";
            this.Restat.Size = new System.Drawing.Size(254, 54);
            this.Restat.TabIndex = 10;
            this.Restat.Text = "Restart";
            this.Restat.UseVisualStyleBackColor = true;
            this.Restat.Click += new System.EventHandler(this.Restat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer_Text
            // 
            this.Timer_Text.AutoSize = true;
            this.Timer_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Timer_Text.Location = new System.Drawing.Point(-10, 545);
            this.Timer_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timer_Text.Name = "Timer_Text";
            this.Timer_Text.Size = new System.Drawing.Size(131, 47);
            this.Timer_Text.TabIndex = 11;
            this.Timer_Text.Text = "Timer";
            // 
            // TheSeconds
            // 
            this.TheSeconds.AutoSize = true;
            this.TheSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TheSeconds.Location = new System.Drawing.Point(16, 586);
            this.TheSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TheSeconds.Name = "TheSeconds";
            this.TheSeconds.Size = new System.Drawing.Size(177, 37);
            this.TheSeconds.TabIndex = 12;
            this.TheSeconds.Text = "0 Seconds";
            this.TheSeconds.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // Turns
            // 
            this.Turns.AutoSize = true;
            this.Turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Turns.Location = new System.Drawing.Point(524, 565);
            this.Turns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Turns.Name = "Turns";
            this.Turns.Size = new System.Drawing.Size(213, 37);
            this.Turns.TabIndex = 13;
            this.Turns.Text = "X, Your Turn";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(508, 366);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(254, 180);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 9;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::TicTacToe_GuyWittlinandItayShachar.Properties.Resources.None;
            this.pictureBox12.Location = new System.Drawing.Point(507, 180);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(254, 178);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 8;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox02
            // 
            this.pictureBox02.Location = new System.Drawing.Point(508, 2);
            this.pictureBox02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox02.Name = "pictureBox02";
            this.pictureBox02.Size = new System.Drawing.Size(254, 174);
            this.pictureBox02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox02.TabIndex = 7;
            this.pictureBox02.TabStop = false;
            this.pictureBox02.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(248, 365);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(252, 180);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 6;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(248, 182);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(252, 177);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 5;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox01
            // 
            this.pictureBox01.Image = global::TicTacToe_GuyWittlinandItayShachar.Properties.Resources.None;
            this.pictureBox01.Location = new System.Drawing.Point(246, 3);
            this.pictureBox01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox01.Name = "pictureBox01";
            this.pictureBox01.Size = new System.Drawing.Size(252, 172);
            this.pictureBox01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox01.TabIndex = 4;
            this.pictureBox01.TabStop = false;
            this.pictureBox01.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(-2, 368);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(238, 174);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 3;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(0, 183);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(238, 174);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.sign_Click);
            // 
            // pictureBox00
            // 
            this.pictureBox00.Image = global::TicTacToe_GuyWittlinandItayShachar.Properties.Resources.None;
            this.pictureBox00.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox00.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox00.Name = "pictureBox00";
            this.pictureBox00.Size = new System.Drawing.Size(238, 174);
            this.pictureBox00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox00.TabIndex = 1;
            this.pictureBox00.TabStop = false;
            this.pictureBox00.Click += new System.EventHandler(this.sign_Click);
            // 
            // BackPictureBox
            // 
            this.BackPictureBox.Image = global::TicTacToe_GuyWittlinandItayShachar.Properties.Resources.Back;
            this.BackPictureBox.Location = new System.Drawing.Point(-2, 2);
            this.BackPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackPictureBox.Name = "BackPictureBox";
            this.BackPictureBox.Size = new System.Drawing.Size(764, 545);
            this.BackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackPictureBox.TabIndex = 0;
            this.BackPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 628);
            this.Controls.Add(this.Turns);
            this.Controls.Add(this.TheSeconds);
            this.Controls.Add(this.Timer_Text);
            this.Controls.Add(this.Restat);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox02);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox01);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox00);
            this.Controls.Add(this.BackPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "TicTacToe - Guy Wittlin and Itay Shachar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackPictureBox;
        private System.Windows.Forms.PictureBox pictureBox00;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox01;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox02;
        private System.Windows.Forms.Button Restat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer_Text;
        private System.Windows.Forms.Label TheSeconds;
        private System.Windows.Forms.Label Turns;
    }
}

