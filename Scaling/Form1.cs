using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scaling.Algorithms;

namespace Scaling
{
    public partial class MainForm : Form
    {
        private ImageExtension _imageExtension;
        private PixelFilling _pixelFilling;
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения (*.jpg, *.jpeg, *.png)|*.jpg|*.jpeg|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InitImage(dialog.FileName);
                FillImageInformation();

                
            }
            
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = Data.FileInfo.Name;
            dialog.Filter = "Изображения (*.jpg, *.jpeg, *.png)|*.jpg|*.jpeg|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Data.CurrentBitmap.Save(dialog.FileName);
            }
        }

        private void FillImageInformation()
        {
            resolutionLabel.Text = $"{Data.CurrentBitmap.Width}x{Data.CurrentBitmap.Height}";
            fileSizeLabel.Text = $"{Utility.BytesToString(Data.FileInfo.Length)}";
            fileFormatLabel.Text = $"{Path.GetExtension(Data.FileInfo.Name)}";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _imageExtension = new ImageExtension(Data.EmptyColor);
            _pixelFilling = new PixelFilling(Data.EmptyColor, Data.CurrentAlgorithm);

            Data.CurrentAlgorithm = new NearestNeighbourAlgorithm();
            InitAlgorithm();


        }

        private void InitImage(string path)
        {
            Image image = Image.FromFile(path);
            pictureBox1.Image = image;
            
            Data.CurrentBitmap = new Bitmap(image);
            Data.InitialBitmap = Data.CurrentBitmap;
            
            Data.FileInfo = new FileInfo(path);
        }


        private void XScaleButton_Click(object sender, EventArgs e)
        {
            Data.XCoefficient = double.Parse(XScaleTextBox.Text);
            
            Extend();
        }

        private void YScaleButton_Click(object sender, EventArgs e)
        {
            Data.YCoefficient = int.Parse(YScaleTextBox.Text);
            Extend();            
        }

        private void XYScaleButton_Click(object sender, EventArgs e)
        {
            Data.XCoefficient = int.Parse(XYScaleTextBox.Text);
            Data.YCoefficient = int.Parse(XYScaleTextBox.Text);
            Extend();
        }

        private void Extend()
        {
            Data.InterpolatedBitmap = _imageExtension.Extend(Data.CurrentBitmap, Data.XCoefficient, Data.YCoefficient);
            Data.CurrentBitmap = Data.InterpolatedBitmap;
            
            pictureBox1.Image = Data.CurrentBitmap;
            
            FillImageInformation();            
        }

        private void nearestNeighbourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data.CurrentAlgorithm = new NearestNeighbourAlgorithm();
            InitAlgorithm();
        }

        private void ktimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.CurrentAlgorithm = new KTimeAlgorithm();
            InitAlgorithm();
        }

        private void bilinearInterpolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.CurrentAlgorithm = new BilinearInterpolationAlgorithm();
            InitAlgorithm();
        }
        
        private void InitAlgorithm()
        {
            algorithmLabel.Text = Data.CurrentAlgorithm.ToString();
            _pixelFilling.Algorithm = Data.CurrentAlgorithm;
        }

        private void interpolateButton_Click(object sender, EventArgs e)
        {
            
            _pixelFilling.Fill(Data.InitialBitmap, Data.InterpolatedBitmap, Data.YCoefficient, Data.XCoefficient);
            Data.CurrentBitmap = Data.InterpolatedBitmap;
            pictureBox1.Image = Data.CurrentBitmap;
        }
    }
}
