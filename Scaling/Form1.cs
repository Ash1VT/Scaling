using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private int NewHeight { get; set; }
        private int NewWidth { get; set; }
        
        
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
        private String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
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
            resolutionLabel.Text = $"{Data.CurrentBitmap.HorizontalResolution}x{Data.CurrentBitmap.VerticalResolution}";
            fileSizeLabel.Text = $"{BytesToString(Data.FileInfo.Length)}";
            fileFormatLabel.Text = $"{Path.GetExtension(Data.FileInfo.Name)}";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void InitImage(string path)
        {
            Image image = Image.FromFile(path);
            pictureBox1.Image = image;
            
            Data.CurrentBitmap = new Bitmap(image);
            Data.FileInfo = new FileInfo(path);
        }


        private void XScaleButton_Click(object sender, EventArgs e)
        {
            Bitmap btm = new Bitmap(Data.CurrentBitmap.Width * 2, Data.CurrentBitmap.Height * 2);
            pictureBox1.Image = Data.CurrentBitmap;
                        
            FillImageInformation();
        }

        private void YScaleButton_Click(object sender, EventArgs e)
        {
        }

        private void XYScaleButton_Click(object sender, EventArgs e)
        {
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
        }
    }
}
