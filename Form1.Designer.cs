namespace imagePicker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openImageButton = new System.Windows.Forms.Button();
            this.addToOutButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.saveOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(744, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(701, 536);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // openImageButton
            // 
            this.openImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openImageButton.Location = new System.Drawing.Point(13, 596);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(147, 50);
            this.openImageButton.TabIndex = 1;
            this.openImageButton.Text = "Open Image";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // addToOutButton
            // 
            this.addToOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToOutButton.Location = new System.Drawing.Point(808, 590);
            this.addToOutButton.Name = "addToOutButton";
            this.addToOutButton.Size = new System.Drawing.Size(49, 50);
            this.addToOutButton.TabIndex = 2;
            this.addToOutButton.Text = "+";
            this.addToOutButton.UseVisualStyleBackColor = true;
            this.addToOutButton.Click += new System.EventHandler(this.AddToOutbutton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorButton.Location = new System.Drawing.Point(592, 590);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(50, 50);
            this.colorButton.TabIndex = 2;
            this.colorButton.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(648, 599);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(153, 69);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // saveOutButton
            // 
            this.saveOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOutButton.Location = new System.Drawing.Point(1250, 596);
            this.saveOutButton.Name = "saveOutButton";
            this.saveOutButton.Size = new System.Drawing.Size(195, 50);
            this.saveOutButton.TabIndex = 2;
            this.saveOutButton.Text = "Save Out Image";
            this.saveOutButton.UseVisualStyleBackColor = true;
            this.saveOutButton.Click += new System.EventHandler(this.saveOutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 658);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.saveOutButton);
            this.Controls.Add(this.addToOutButton);
            this.Controls.Add(this.openImageButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.Button addToOutButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button saveOutButton;
    }
}

