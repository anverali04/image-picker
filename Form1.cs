using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace imagePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 990;
        }

Bitmap baseImage;
Bitmap outImage;
private void openImageButton_Click(object sender, EventArgs e)
{
    var openFileDialog = new OpenFileDialog();
    openFileDialog.ShowDialog();

    baseImage = new Bitmap(openFileDialog.FileName);

    // Resize the image to fit in the picturebox
    baseImage = new Bitmap(baseImage, pictureBox1.Width, pictureBox1.Height);
            
    pictureBox1.Image = baseImage;

    // Create outImage with same base image size to store the output
    outImage = new Bitmap(baseImage.Width, baseImage.Height);
    var g = Graphics.FromImage(outImage);
    // Fill the outImage with white color
    g.FillRectangle(Brushes.White, 0, 0, outImage.Width, outImage.Height);
}

Bitmap workingImage;
Color pickColour;
private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
{
    // Get the color of image in the mouse clicked location
    pickColour = Color.FromArgb(baseImage.GetPixel(e.X, e.Y).ToArgb());

    drawIntoWorkingImage();
}

private void drawIntoWorkingImage()
{
    workingImage = new Bitmap(outImage);
                        
    var range = trackBar1.Value;

    colorButton.BackColor = pickColour;

    // Compare all the pixels in the image with the picked color 
    for (int i = 0; i < baseImage.Width; i++)
    {
        for (int j = 0; j < baseImage.Height; j++)
        {
            var pixel = baseImage.GetPixel(i, j);

            // if the difference of the picked color and current pixel comes in range 
            if (pixel.R - pickColour.R > -range && pixel.R - pickColour.R < range
                && pixel.G - pickColour.G > -range && pixel.G - pickColour.G < range
                && pixel.B - pickColour.B > -range && pixel.B - pickColour.B < range)
            {
                workingImage.SetPixel(i, j, pixel);
            }
        }
    }

    pictureBox2.Image = workingImage;
}

private void trackBar1_Scroll(object sender, EventArgs e)
{
    drawIntoWorkingImage();
}

private void AddToOutbutton_Click(object sender, EventArgs e)
{
    outImage = new Bitmap(workingImage);
}

private void saveOutButton_Click(object sender, EventArgs e)
{
    var saveFileDialog = new SaveFileDialog();
    saveFileDialog.ShowDialog();

    outImage.Save(saveFileDialog.FileName + ".jpeg", ImageFormat.Jpeg);
}
    }
}
