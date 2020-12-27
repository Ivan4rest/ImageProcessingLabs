using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_processing_labs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            string path = "";

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files(*.JPG;)|*.JPG;|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                }
            }

            Bitmap bmp = new Bitmap(path);
            pictureBoxInput.Image = bmp;
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Image Files(*.JPG;)|*.JPG;|All files (*.*)|*.*";
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = SaveFileDialog.FileName;
            Bitmap bmp = (Bitmap)pictureBoxOutput.Image;
            if (rbPictureboxInput.Checked)
                bmp = (Bitmap)pictureBoxInput.Image;
            else if (rbPictureboxMiddle.Checked)
                bmp = (Bitmap)pictureBoxMiddle.Image;
            else if (rbPictureboxOutput.Checked)
                bmp = (Bitmap)pictureBoxOutput.Image;
            bmp.Save(filename);
        }

        private void btn_Gauss_noise_not_color_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.GaussNoiseNotColor((Bitmap)pictureBoxInput.Image, int.Parse(tbIntensity.Text));
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btn_Gauss_noise_color_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.GaussNoiseColor((Bitmap)pictureBoxInput.Image, int.Parse(tbIntensity.Text));
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnToGrey_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.ToGrey((Bitmap)pictureBoxInput.Image);
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if(rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnPlaneWaveInGrayscale_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.GetSynthesizedImagePlaneWaveInGrayscale(400, 400, 0.3, 0.15);
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnMaxwellTriangle_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.GetMaxwellTriangle();
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnSaltInterference_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.SaltInterference((Bitmap)pictureBoxInput.Image.Clone(), Int32.Parse(tbIntensityInterference.Text));
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnPepperInterference_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.PepperInterference((Bitmap)pictureBoxInput.Image.Clone(), Int32.Parse(tbIntensityInterference.Text));
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnSaltPepperInterference_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ImageProcessing.SaltPepperInterference((Bitmap)pictureBoxInput.Image.Clone(), Int32.Parse(tbIntensityInterference.Text));
            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnLinearLowFrequencyFilter_Click(object sender, EventArgs e)
        {
            ImageProcessing.apertureSize = 5;
            ImageProcessing.SetApertureElementsForLowFrequencyFilter(Convert.ToDouble(comboBoxCKO.Text));
            pictureBoxMiddle.Image = ImageProcessing.GaussNoiseNotColor((Bitmap)pictureBoxInput.Image, int.Parse(tbIntensity.Text));
            pictureBoxOutput.Image = ImageProcessing.LinearLowFrequencyFilter((Bitmap)pictureBoxMiddle.Image);
            tbCriterionQualityRestoration.Text = ImageProcessing.GetCriterionQualityRestoration((Bitmap)pictureBoxInput.Image, (Bitmap)pictureBoxOutput.Image).ToString();
        }

        private void btnRecursiveLowFrequencyFilter_Click(object sender, EventArgs e)
        {
            ImageProcessing.apertureSize = 5;
            ImageProcessing.SetApertureElementsForLowFrequencyFilter(Convert.ToDouble(comboBoxCKO.Text));
            pictureBoxMiddle.Image = ImageProcessing.GaussNoiseNotColor((Bitmap)pictureBoxInput.Image, int.Parse(tbIntensity.Text));
            pictureBoxOutput.Image = ImageProcessing.RecursiveLowFrequencyFilter((Bitmap)pictureBoxMiddle.Image.Clone());
            tbCriterionQualityRestoration.Text = ImageProcessing.GetCriterionQualityRestoration((Bitmap)pictureBoxInput.Image, (Bitmap)pictureBoxOutput.Image).ToString();
        }

        private void btnMedianFilter_Click(object sender, EventArgs e)
        {
            ImageProcessing.apertureSize = int.Parse(comboBoxApertureSize.Text);
            pictureBoxMiddle.Image = ImageProcessing.SaltPepperInterference((Bitmap)pictureBoxInput.Image.Clone(), int.Parse(tbIntensityInterference.Text));
            pictureBoxOutput.Image = ImageProcessing.MedianFilter((Bitmap)pictureBoxMiddle.Image.Clone(), comboBoxApertureForm.Text);
            tbCriterionQualityRestoration.Text = ImageProcessing.GetCriterionQualityRestoration((Bitmap)pictureBoxInput.Image, (Bitmap)pictureBoxOutput.Image).ToString();
        }

        private void btnHighFrequencyFilter_Click(object sender, EventArgs e)
        {
            ImageProcessing.apertureSize = 3;
            ImageProcessing.SetApertureElementsForHighFrequencyFilter(int.Parse(comboBoxMaskHighFrequencyFilter.Text));
            pictureBoxOutput.Image = ImageProcessing.HighFrequencyFilter((Bitmap)pictureBoxInput.Image);
        }

        private void btnGradient_Click(object sender, EventArgs e)
        {
            ImageProcessing.apertureSize = 3;

            Bitmap bmp = (Bitmap)pictureBoxInput.Image;

            switch (comboBoxGradient.Text)
            {
                case "horizontal":
                    bmp = ImageProcessing.GradientHorizontal((Bitmap)pictureBoxInput.Image);
                    break;
                case "vertical":
                    bmp = ImageProcessing.GradientVertical((Bitmap)pictureBoxInput.Image);
                    break;
                case "modul":
                    bmp = ImageProcessing.GradientModul((Bitmap)pictureBoxInput.Image);
                    break;
            }

            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnLaplacian_Click(object sender, EventArgs e)
        {
            ImageProcessing.apertureSize = 3;
            ImageProcessing.SetApertureElementsForLaplacian(int.Parse(comboBoxLaplacianMask.Text));
            Bitmap bmp = ImageProcessing.Laplacian((Bitmap)pictureBoxInput.Image);

            if (rbPictureboxInput.Checked)
                pictureBoxInput.Image = bmp;
            else if (rbPictureboxMiddle.Checked)
                pictureBoxMiddle.Image = bmp;
            else if (rbPictureboxOutput.Checked)
                pictureBoxOutput.Image = bmp;
        }

        private void btnHoughTransform_Click(object sender, EventArgs e)
        {
            ImageProcessing.apertureSize = 3;

            pictureBoxMiddle.Image = ImageProcessing.HoughTransform(ImageProcessing.GradientModul((Bitmap)pictureBoxInput.Image), int.Parse(tbThresholdBrightness.Text), int.Parse(tbThresholdNumberPoints.Text));

            pictureBoxOutput.Image = ImageProcessing.GetBitmapParameterSpace();
        }
    }
}
