namespace Image_processing_labs
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Gauss_noise_color = new System.Windows.Forms.Button();
            this.btnGaussNoiseNotColor = new System.Windows.Forms.Button();
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoughTransform = new System.Windows.Forms.Button();
            this.gbLaplacian = new System.Windows.Forms.GroupBox();
            this.btnLaplacian = new System.Windows.Forms.Button();
            this.comboBoxLaplacianMask = new System.Windows.Forms.ComboBox();
            this.labelLaplacianMask = new System.Windows.Forms.Label();
            this.gbGradient = new System.Windows.Forms.GroupBox();
            this.comboBoxGradient = new System.Windows.Forms.ComboBox();
            this.btnGradient = new System.Windows.Forms.Button();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.gbHighFrequencyFilter = new System.Windows.Forms.GroupBox();
            this.btnHighFrequencyFilter = new System.Windows.Forms.Button();
            this.comboBoxMaskHighFrequencyFilter = new System.Windows.Forms.ComboBox();
            this.labelMaskHighFrequencyFilter = new System.Windows.Forms.Label();
            this.gbMedianFilter = new System.Windows.Forms.GroupBox();
            this.labelApertureSize = new System.Windows.Forms.Label();
            this.labelApertureForm = new System.Windows.Forms.Label();
            this.comboBoxApertureForm = new System.Windows.Forms.ComboBox();
            this.comboBoxApertureSize = new System.Windows.Forms.ComboBox();
            this.btnMedianFilter = new System.Windows.Forms.Button();
            this.tbCriterionQualityRestoration = new System.Windows.Forms.TextBox();
            this.labelCriterionQualityRestoration = new System.Windows.Forms.Label();
            this.gbGaussNoise = new System.Windows.Forms.GroupBox();
            this.labelIntensity = new System.Windows.Forms.Label();
            this.tbIntensity = new System.Windows.Forms.TextBox();
            this.gbLowFrequencyFilter = new System.Windows.Forms.GroupBox();
            this.labelCKO = new System.Windows.Forms.Label();
            this.btnRecursiveLowFrequencyFilter = new System.Windows.Forms.Button();
            this.comboBoxCKO = new System.Windows.Forms.ComboBox();
            this.btnLinearLowFrequencyFilter = new System.Windows.Forms.Button();
            this.gbOutputPicturebox = new System.Windows.Forms.GroupBox();
            this.rbPictureboxMiddle = new System.Windows.Forms.RadioButton();
            this.rbPictureboxInput = new System.Windows.Forms.RadioButton();
            this.rbPictureboxOutput = new System.Windows.Forms.RadioButton();
            this.groupBoxInterference = new System.Windows.Forms.GroupBox();
            this.btnSaltPepperInterference = new System.Windows.Forms.Button();
            this.btnPepperInterference = new System.Windows.Forms.Button();
            this.btnSaltInterference = new System.Windows.Forms.Button();
            this.labelIntensityInterference = new System.Windows.Forms.Label();
            this.tbIntensityInterference = new System.Windows.Forms.TextBox();
            this.btnMaxwellTriangle = new System.Windows.Forms.Button();
            this.btnPlaneWaveInGrayscale = new System.Windows.Forms.Button();
            this.btnToGrey = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxMiddle = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbHoughTransform = new System.Windows.Forms.GroupBox();
            this.labelThresholdBrightness = new System.Windows.Forms.Label();
            this.labelThresholdNumberPoints = new System.Windows.Forms.Label();
            this.tbThresholdBrightness = new System.Windows.Forms.TextBox();
            this.tbThresholdNumberPoints = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbLaplacian.SuspendLayout();
            this.gbGradient.SuspendLayout();
            this.gbHighFrequencyFilter.SuspendLayout();
            this.gbMedianFilter.SuspendLayout();
            this.gbGaussNoise.SuspendLayout();
            this.gbLowFrequencyFilter.SuspendLayout();
            this.gbOutputPicturebox.SuspendLayout();
            this.groupBoxInterference.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.gbHoughTransform.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Gauss_noise_color
            // 
            this.btn_Gauss_noise_color.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Gauss_noise_color.Location = new System.Drawing.Point(3, 61);
            this.btn_Gauss_noise_color.Name = "btn_Gauss_noise_color";
            this.btn_Gauss_noise_color.Size = new System.Drawing.Size(105, 23);
            this.btn_Gauss_noise_color.TabIndex = 2;
            this.btn_Gauss_noise_color.Text = "Color";
            this.btn_Gauss_noise_color.UseVisualStyleBackColor = true;
            this.btn_Gauss_noise_color.Click += new System.EventHandler(this.btn_Gauss_noise_color_Click);
            // 
            // btnGaussNoiseNotColor
            // 
            this.btnGaussNoiseNotColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGaussNoiseNotColor.Location = new System.Drawing.Point(3, 38);
            this.btnGaussNoiseNotColor.Name = "btnGaussNoiseNotColor";
            this.btnGaussNoiseNotColor.Size = new System.Drawing.Size(105, 23);
            this.btnGaussNoiseNotColor.TabIndex = 1;
            this.btnGaussNoiseNotColor.Text = "Not color";
            this.btnGaussNoiseNotColor.UseVisualStyleBackColor = true;
            this.btnGaussNoiseNotColor.Click += new System.EventHandler(this.btn_Gauss_noise_not_color_Click);
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(12, 12);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPicture.TabIndex = 0;
            this.btnLoadPicture.Text = "Load picture";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbHoughTransform);
            this.panel1.Controls.Add(this.gbLaplacian);
            this.panel1.Controls.Add(this.gbGradient);
            this.panel1.Controls.Add(this.btnSavePicture);
            this.panel1.Controls.Add(this.gbHighFrequencyFilter);
            this.panel1.Controls.Add(this.gbMedianFilter);
            this.panel1.Controls.Add(this.tbCriterionQualityRestoration);
            this.panel1.Controls.Add(this.labelCriterionQualityRestoration);
            this.panel1.Controls.Add(this.gbGaussNoise);
            this.panel1.Controls.Add(this.gbLowFrequencyFilter);
            this.panel1.Controls.Add(this.gbOutputPicturebox);
            this.panel1.Controls.Add(this.groupBoxInterference);
            this.panel1.Controls.Add(this.btnMaxwellTriangle);
            this.panel1.Controls.Add(this.btnPlaneWaveInGrayscale);
            this.panel1.Controls.Add(this.btnToGrey);
            this.panel1.Controls.Add(this.btnLoadPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1507, 191);
            this.panel1.TabIndex = 3;
            // 
            // btnHoughTransform
            // 
            this.btnHoughTransform.Location = new System.Drawing.Point(9, 63);
            this.btnHoughTransform.Name = "btnHoughTransform";
            this.btnHoughTransform.Size = new System.Drawing.Size(165, 23);
            this.btnHoughTransform.TabIndex = 5;
            this.btnHoughTransform.Text = "Hough transform";
            this.btnHoughTransform.UseVisualStyleBackColor = true;
            this.btnHoughTransform.Click += new System.EventHandler(this.btnHoughTransform_Click);
            // 
            // gbLaplacian
            // 
            this.gbLaplacian.Controls.Add(this.btnLaplacian);
            this.gbLaplacian.Controls.Add(this.comboBoxLaplacianMask);
            this.gbLaplacian.Controls.Add(this.labelLaplacianMask);
            this.gbLaplacian.Location = new System.Drawing.Point(1216, 13);
            this.gbLaplacian.Name = "gbLaplacian";
            this.gbLaplacian.Size = new System.Drawing.Size(88, 71);
            this.gbLaplacian.TabIndex = 5;
            this.gbLaplacian.TabStop = false;
            this.gbLaplacian.Text = "Laplacian";
            // 
            // btnLaplacian
            // 
            this.btnLaplacian.Location = new System.Drawing.Point(6, 41);
            this.btnLaplacian.Name = "btnLaplacian";
            this.btnLaplacian.Size = new System.Drawing.Size(75, 23);
            this.btnLaplacian.TabIndex = 2;
            this.btnLaplacian.Text = "Filter";
            this.btnLaplacian.UseVisualStyleBackColor = true;
            this.btnLaplacian.Click += new System.EventHandler(this.btnLaplacian_Click);
            // 
            // comboBoxLaplacianMask
            // 
            this.comboBoxLaplacianMask.FormattingEnabled = true;
            this.comboBoxLaplacianMask.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxLaplacianMask.Location = new System.Drawing.Point(48, 14);
            this.comboBoxLaplacianMask.Name = "comboBoxLaplacianMask";
            this.comboBoxLaplacianMask.Size = new System.Drawing.Size(33, 21);
            this.comboBoxLaplacianMask.TabIndex = 1;
            this.comboBoxLaplacianMask.Text = "3";
            // 
            // labelLaplacianMask
            // 
            this.labelLaplacianMask.AutoSize = true;
            this.labelLaplacianMask.Location = new System.Drawing.Point(6, 18);
            this.labelLaplacianMask.Name = "labelLaplacianMask";
            this.labelLaplacianMask.Size = new System.Drawing.Size(36, 13);
            this.labelLaplacianMask.TabIndex = 0;
            this.labelLaplacianMask.Text = "Mask:";
            // 
            // gbGradient
            // 
            this.gbGradient.Controls.Add(this.comboBoxGradient);
            this.gbGradient.Controls.Add(this.btnGradient);
            this.gbGradient.Location = new System.Drawing.Point(1128, 12);
            this.gbGradient.Name = "gbGradient";
            this.gbGradient.Size = new System.Drawing.Size(82, 72);
            this.gbGradient.TabIndex = 16;
            this.gbGradient.TabStop = false;
            this.gbGradient.Text = "Gradient";
            // 
            // comboBoxGradient
            // 
            this.comboBoxGradient.FormattingEnabled = true;
            this.comboBoxGradient.Items.AddRange(new object[] {
            "horizontal",
            "vertical",
            "modul"});
            this.comboBoxGradient.Location = new System.Drawing.Point(6, 15);
            this.comboBoxGradient.Name = "comboBoxGradient";
            this.comboBoxGradient.Size = new System.Drawing.Size(69, 21);
            this.comboBoxGradient.TabIndex = 6;
            this.comboBoxGradient.Text = "modul";
            // 
            // btnGradient
            // 
            this.btnGradient.Location = new System.Drawing.Point(6, 42);
            this.btnGradient.Name = "btnGradient";
            this.btnGradient.Size = new System.Drawing.Size(69, 23);
            this.btnGradient.TabIndex = 5;
            this.btnGradient.Text = "Filter";
            this.btnGradient.UseVisualStyleBackColor = true;
            this.btnGradient.Click += new System.EventHandler(this.btnGradient_Click);
            // 
            // btnSavePicture
            // 
            this.btnSavePicture.Location = new System.Drawing.Point(12, 41);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(75, 23);
            this.btnSavePicture.TabIndex = 3;
            this.btnSavePicture.Text = "Save picture";
            this.btnSavePicture.UseVisualStyleBackColor = true;
            this.btnSavePicture.Click += new System.EventHandler(this.btnSavePicture_Click);
            // 
            // gbHighFrequencyFilter
            // 
            this.gbHighFrequencyFilter.Controls.Add(this.btnHighFrequencyFilter);
            this.gbHighFrequencyFilter.Controls.Add(this.comboBoxMaskHighFrequencyFilter);
            this.gbHighFrequencyFilter.Controls.Add(this.labelMaskHighFrequencyFilter);
            this.gbHighFrequencyFilter.Location = new System.Drawing.Point(996, 13);
            this.gbHighFrequencyFilter.Name = "gbHighFrequencyFilter";
            this.gbHighFrequencyFilter.Size = new System.Drawing.Size(126, 71);
            this.gbHighFrequencyFilter.TabIndex = 5;
            this.gbHighFrequencyFilter.TabStop = false;
            this.gbHighFrequencyFilter.Text = "High frequency filter";
            // 
            // btnHighFrequencyFilter
            // 
            this.btnHighFrequencyFilter.Location = new System.Drawing.Point(9, 42);
            this.btnHighFrequencyFilter.Name = "btnHighFrequencyFilter";
            this.btnHighFrequencyFilter.Size = new System.Drawing.Size(105, 23);
            this.btnHighFrequencyFilter.TabIndex = 2;
            this.btnHighFrequencyFilter.Text = "Filter";
            this.btnHighFrequencyFilter.UseVisualStyleBackColor = true;
            this.btnHighFrequencyFilter.Click += new System.EventHandler(this.btnHighFrequencyFilter_Click);
            // 
            // comboBoxMaskHighFrequencyFilter
            // 
            this.comboBoxMaskHighFrequencyFilter.FormattingEnabled = true;
            this.comboBoxMaskHighFrequencyFilter.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxMaskHighFrequencyFilter.Location = new System.Drawing.Point(48, 15);
            this.comboBoxMaskHighFrequencyFilter.Name = "comboBoxMaskHighFrequencyFilter";
            this.comboBoxMaskHighFrequencyFilter.Size = new System.Drawing.Size(66, 21);
            this.comboBoxMaskHighFrequencyFilter.TabIndex = 1;
            this.comboBoxMaskHighFrequencyFilter.Text = "1";
            // 
            // labelMaskHighFrequencyFilter
            // 
            this.labelMaskHighFrequencyFilter.AutoSize = true;
            this.labelMaskHighFrequencyFilter.Location = new System.Drawing.Point(6, 19);
            this.labelMaskHighFrequencyFilter.Name = "labelMaskHighFrequencyFilter";
            this.labelMaskHighFrequencyFilter.Size = new System.Drawing.Size(36, 13);
            this.labelMaskHighFrequencyFilter.TabIndex = 0;
            this.labelMaskHighFrequencyFilter.Text = "Mask:";
            // 
            // gbMedianFilter
            // 
            this.gbMedianFilter.Controls.Add(this.labelApertureSize);
            this.gbMedianFilter.Controls.Add(this.labelApertureForm);
            this.gbMedianFilter.Controls.Add(this.comboBoxApertureForm);
            this.gbMedianFilter.Controls.Add(this.comboBoxApertureSize);
            this.gbMedianFilter.Controls.Add(this.btnMedianFilter);
            this.gbMedianFilter.Location = new System.Drawing.Point(793, 13);
            this.gbMedianFilter.Name = "gbMedianFilter";
            this.gbMedianFilter.Size = new System.Drawing.Size(191, 100);
            this.gbMedianFilter.TabIndex = 15;
            this.gbMedianFilter.TabStop = false;
            this.gbMedianFilter.Text = "Median filter";
            // 
            // labelApertureSize
            // 
            this.labelApertureSize.AutoSize = true;
            this.labelApertureSize.Location = new System.Drawing.Point(6, 22);
            this.labelApertureSize.Name = "labelApertureSize";
            this.labelApertureSize.Size = new System.Drawing.Size(71, 13);
            this.labelApertureSize.TabIndex = 16;
            this.labelApertureSize.Text = "Aperture size:";
            // 
            // labelApertureForm
            // 
            this.labelApertureForm.AutoSize = true;
            this.labelApertureForm.Location = new System.Drawing.Point(6, 51);
            this.labelApertureForm.Name = "labelApertureForm";
            this.labelApertureForm.Size = new System.Drawing.Size(73, 13);
            this.labelApertureForm.TabIndex = 17;
            this.labelApertureForm.Text = "Aperture form:";
            // 
            // comboBoxApertureForm
            // 
            this.comboBoxApertureForm.FormattingEnabled = true;
            this.comboBoxApertureForm.Items.AddRange(new object[] {
            "rectangle",
            "cross",
            "diagonal cross"});
            this.comboBoxApertureForm.Location = new System.Drawing.Point(85, 46);
            this.comboBoxApertureForm.Name = "comboBoxApertureForm";
            this.comboBoxApertureForm.Size = new System.Drawing.Size(96, 21);
            this.comboBoxApertureForm.TabIndex = 17;
            this.comboBoxApertureForm.Text = "rectangle";
            // 
            // comboBoxApertureSize
            // 
            this.comboBoxApertureSize.FormattingEnabled = true;
            this.comboBoxApertureSize.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.comboBoxApertureSize.Location = new System.Drawing.Point(85, 19);
            this.comboBoxApertureSize.Name = "comboBoxApertureSize";
            this.comboBoxApertureSize.Size = new System.Drawing.Size(96, 21);
            this.comboBoxApertureSize.TabIndex = 16;
            this.comboBoxApertureSize.Text = "5";
            // 
            // btnMedianFilter
            // 
            this.btnMedianFilter.Location = new System.Drawing.Point(9, 71);
            this.btnMedianFilter.Name = "btnMedianFilter";
            this.btnMedianFilter.Size = new System.Drawing.Size(172, 23);
            this.btnMedianFilter.TabIndex = 5;
            this.btnMedianFilter.Text = "Filter";
            this.btnMedianFilter.UseVisualStyleBackColor = true;
            this.btnMedianFilter.Click += new System.EventHandler(this.btnMedianFilter_Click);
            // 
            // tbCriterionQualityRestoration
            // 
            this.tbCriterionQualityRestoration.Location = new System.Drawing.Point(148, 131);
            this.tbCriterionQualityRestoration.Name = "tbCriterionQualityRestoration";
            this.tbCriterionQualityRestoration.ReadOnly = true;
            this.tbCriterionQualityRestoration.Size = new System.Drawing.Size(130, 20);
            this.tbCriterionQualityRestoration.TabIndex = 14;
            // 
            // labelCriterionQualityRestoration
            // 
            this.labelCriterionQualityRestoration.AutoSize = true;
            this.labelCriterionQualityRestoration.Location = new System.Drawing.Point(9, 134);
            this.labelCriterionQualityRestoration.Name = "labelCriterionQualityRestoration";
            this.labelCriterionQualityRestoration.Size = new System.Drawing.Size(133, 13);
            this.labelCriterionQualityRestoration.TabIndex = 13;
            this.labelCriterionQualityRestoration.Text = "Criterion quality restoration:";
            // 
            // gbGaussNoise
            // 
            this.gbGaussNoise.Controls.Add(this.labelIntensity);
            this.gbGaussNoise.Controls.Add(this.tbIntensity);
            this.gbGaussNoise.Controls.Add(this.btnGaussNoiseNotColor);
            this.gbGaussNoise.Controls.Add(this.btn_Gauss_noise_color);
            this.gbGaussNoise.Location = new System.Drawing.Point(260, 12);
            this.gbGaussNoise.Name = "gbGaussNoise";
            this.gbGaussNoise.Size = new System.Drawing.Size(111, 87);
            this.gbGaussNoise.TabIndex = 10;
            this.gbGaussNoise.TabStop = false;
            this.gbGaussNoise.Text = "Gauss noise";
            // 
            // labelIntensity
            // 
            this.labelIntensity.AutoSize = true;
            this.labelIntensity.Location = new System.Drawing.Point(6, 16);
            this.labelIntensity.Name = "labelIntensity";
            this.labelIntensity.Size = new System.Drawing.Size(49, 13);
            this.labelIntensity.TabIndex = 12;
            this.labelIntensity.Text = "Intensity:";
            // 
            // tbIntensity
            // 
            this.tbIntensity.Location = new System.Drawing.Point(55, 13);
            this.tbIntensity.Name = "tbIntensity";
            this.tbIntensity.Size = new System.Drawing.Size(50, 20);
            this.tbIntensity.TabIndex = 11;
            this.tbIntensity.Text = "50";
            // 
            // gbLowFrequencyFilter
            // 
            this.gbLowFrequencyFilter.BackColor = System.Drawing.SystemColors.Control;
            this.gbLowFrequencyFilter.Controls.Add(this.labelCKO);
            this.gbLowFrequencyFilter.Controls.Add(this.btnRecursiveLowFrequencyFilter);
            this.gbLowFrequencyFilter.Controls.Add(this.comboBoxCKO);
            this.gbLowFrequencyFilter.Controls.Add(this.btnLinearLowFrequencyFilter);
            this.gbLowFrequencyFilter.Location = new System.Drawing.Point(617, 12);
            this.gbLowFrequencyFilter.Name = "gbLowFrequencyFilter";
            this.gbLowFrequencyFilter.Size = new System.Drawing.Size(170, 101);
            this.gbLowFrequencyFilter.TabIndex = 9;
            this.gbLowFrequencyFilter.TabStop = false;
            this.gbLowFrequencyFilter.Text = "Low frequency filter";
            // 
            // labelCKO
            // 
            this.labelCKO.AutoSize = true;
            this.labelCKO.Location = new System.Drawing.Point(6, 19);
            this.labelCKO.Name = "labelCKO";
            this.labelCKO.Size = new System.Drawing.Size(32, 13);
            this.labelCKO.TabIndex = 12;
            this.labelCKO.Text = "CKO:";
            // 
            // btnRecursiveLowFrequencyFilter
            // 
            this.btnRecursiveLowFrequencyFilter.Location = new System.Drawing.Point(9, 71);
            this.btnRecursiveLowFrequencyFilter.Name = "btnRecursiveLowFrequencyFilter";
            this.btnRecursiveLowFrequencyFilter.Size = new System.Drawing.Size(152, 23);
            this.btnRecursiveLowFrequencyFilter.TabIndex = 11;
            this.btnRecursiveLowFrequencyFilter.Text = "Recursive filter";
            this.btnRecursiveLowFrequencyFilter.UseVisualStyleBackColor = true;
            this.btnRecursiveLowFrequencyFilter.Click += new System.EventHandler(this.btnRecursiveLowFrequencyFilter_Click);
            // 
            // comboBoxCKO
            // 
            this.comboBoxCKO.FormattingEnabled = true;
            this.comboBoxCKO.Items.AddRange(new object[] {
            "0,5",
            "0,7",
            "1,0",
            "1,25",
            "2,0",
            "2,5"});
            this.comboBoxCKO.Location = new System.Drawing.Point(44, 15);
            this.comboBoxCKO.Name = "comboBoxCKO";
            this.comboBoxCKO.Size = new System.Drawing.Size(117, 21);
            this.comboBoxCKO.TabIndex = 10;
            this.comboBoxCKO.Text = "0,5";
            // 
            // btnLinearLowFrequencyFilter
            // 
            this.btnLinearLowFrequencyFilter.Location = new System.Drawing.Point(9, 42);
            this.btnLinearLowFrequencyFilter.Name = "btnLinearLowFrequencyFilter";
            this.btnLinearLowFrequencyFilter.Size = new System.Drawing.Size(152, 23);
            this.btnLinearLowFrequencyFilter.TabIndex = 5;
            this.btnLinearLowFrequencyFilter.Text = "Linear filter";
            this.btnLinearLowFrequencyFilter.UseVisualStyleBackColor = true;
            this.btnLinearLowFrequencyFilter.Click += new System.EventHandler(this.btnLinearLowFrequencyFilter_Click);
            // 
            // gbOutputPicturebox
            // 
            this.gbOutputPicturebox.Controls.Add(this.rbPictureboxMiddle);
            this.gbOutputPicturebox.Controls.Add(this.rbPictureboxInput);
            this.gbOutputPicturebox.Controls.Add(this.rbPictureboxOutput);
            this.gbOutputPicturebox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbOutputPicturebox.Location = new System.Drawing.Point(0, 150);
            this.gbOutputPicturebox.Name = "gbOutputPicturebox";
            this.gbOutputPicturebox.Size = new System.Drawing.Size(1507, 41);
            this.gbOutputPicturebox.TabIndex = 5;
            this.gbOutputPicturebox.TabStop = false;
            this.gbOutputPicturebox.Text = "Output picturebox";
            // 
            // rbPictureboxMiddle
            // 
            this.rbPictureboxMiddle.AutoSize = true;
            this.rbPictureboxMiddle.Location = new System.Drawing.Point(681, 18);
            this.rbPictureboxMiddle.Name = "rbPictureboxMiddle";
            this.rbPictureboxMiddle.Size = new System.Drawing.Size(106, 17);
            this.rbPictureboxMiddle.TabIndex = 7;
            this.rbPictureboxMiddle.TabStop = true;
            this.rbPictureboxMiddle.Text = "PictureboxMiddle";
            this.rbPictureboxMiddle.UseVisualStyleBackColor = true;
            // 
            // rbPictureboxInput
            // 
            this.rbPictureboxInput.AutoSize = true;
            this.rbPictureboxInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPictureboxInput.Location = new System.Drawing.Point(3, 16);
            this.rbPictureboxInput.Name = "rbPictureboxInput";
            this.rbPictureboxInput.Size = new System.Drawing.Size(99, 22);
            this.rbPictureboxInput.TabIndex = 5;
            this.rbPictureboxInput.Text = "PictureboxInput";
            this.rbPictureboxInput.UseVisualStyleBackColor = true;
            // 
            // rbPictureboxOutput
            // 
            this.rbPictureboxOutput.AutoSize = true;
            this.rbPictureboxOutput.Checked = true;
            this.rbPictureboxOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbPictureboxOutput.Location = new System.Drawing.Point(1397, 16);
            this.rbPictureboxOutput.Name = "rbPictureboxOutput";
            this.rbPictureboxOutput.Size = new System.Drawing.Size(107, 22);
            this.rbPictureboxOutput.TabIndex = 6;
            this.rbPictureboxOutput.TabStop = true;
            this.rbPictureboxOutput.Text = "PictureboxOutput";
            this.rbPictureboxOutput.UseVisualStyleBackColor = true;
            // 
            // groupBoxInterference
            // 
            this.groupBoxInterference.Controls.Add(this.btnSaltPepperInterference);
            this.groupBoxInterference.Controls.Add(this.btnPepperInterference);
            this.groupBoxInterference.Controls.Add(this.btnSaltInterference);
            this.groupBoxInterference.Controls.Add(this.labelIntensityInterference);
            this.groupBoxInterference.Controls.Add(this.tbIntensityInterference);
            this.groupBoxInterference.Location = new System.Drawing.Point(377, 12);
            this.groupBoxInterference.Name = "groupBoxInterference";
            this.groupBoxInterference.Size = new System.Drawing.Size(234, 72);
            this.groupBoxInterference.TabIndex = 2;
            this.groupBoxInterference.TabStop = false;
            this.groupBoxInterference.Text = "Interferences";
            // 
            // btnSaltPepperInterference
            // 
            this.btnSaltPepperInterference.Location = new System.Drawing.Point(158, 44);
            this.btnSaltPepperInterference.Name = "btnSaltPepperInterference";
            this.btnSaltPepperInterference.Size = new System.Drawing.Size(70, 23);
            this.btnSaltPepperInterference.TabIndex = 4;
            this.btnSaltPepperInterference.Text = "Salt - Paper";
            this.btnSaltPepperInterference.UseVisualStyleBackColor = true;
            this.btnSaltPepperInterference.Click += new System.EventHandler(this.btnSaltPepperInterference_Click);
            // 
            // btnPepperInterference
            // 
            this.btnPepperInterference.Location = new System.Drawing.Point(82, 44);
            this.btnPepperInterference.Name = "btnPepperInterference";
            this.btnPepperInterference.Size = new System.Drawing.Size(70, 23);
            this.btnPepperInterference.TabIndex = 3;
            this.btnPepperInterference.Text = "Paper";
            this.btnPepperInterference.UseVisualStyleBackColor = true;
            this.btnPepperInterference.Click += new System.EventHandler(this.btnPepperInterference_Click);
            // 
            // btnSaltInterference
            // 
            this.btnSaltInterference.Location = new System.Drawing.Point(6, 44);
            this.btnSaltInterference.Name = "btnSaltInterference";
            this.btnSaltInterference.Size = new System.Drawing.Size(70, 23);
            this.btnSaltInterference.TabIndex = 2;
            this.btnSaltInterference.Text = "Salt";
            this.btnSaltInterference.UseVisualStyleBackColor = true;
            this.btnSaltInterference.Click += new System.EventHandler(this.btnSaltInterference_Click);
            // 
            // labelIntensityInterference
            // 
            this.labelIntensityInterference.AutoSize = true;
            this.labelIntensityInterference.Location = new System.Drawing.Point(3, 19);
            this.labelIntensityInterference.Name = "labelIntensityInterference";
            this.labelIntensityInterference.Size = new System.Drawing.Size(108, 13);
            this.labelIntensityInterference.TabIndex = 1;
            this.labelIntensityInterference.Text = "Intensity interference:";
            // 
            // tbIntensityInterference
            // 
            this.tbIntensityInterference.Location = new System.Drawing.Point(117, 16);
            this.tbIntensityInterference.Name = "tbIntensityInterference";
            this.tbIntensityInterference.Size = new System.Drawing.Size(111, 20);
            this.tbIntensityInterference.TabIndex = 0;
            this.tbIntensityInterference.Text = "50";
            // 
            // btnMaxwellTriangle
            // 
            this.btnMaxwellTriangle.Location = new System.Drawing.Point(116, 70);
            this.btnMaxwellTriangle.Name = "btnMaxwellTriangle";
            this.btnMaxwellTriangle.Size = new System.Drawing.Size(91, 23);
            this.btnMaxwellTriangle.TabIndex = 5;
            this.btnMaxwellTriangle.Text = "Maxwell triangle";
            this.btnMaxwellTriangle.UseVisualStyleBackColor = true;
            this.btnMaxwellTriangle.Click += new System.EventHandler(this.btnMaxwellTriangle_Click);
            // 
            // btnPlaneWaveInGrayscale
            // 
            this.btnPlaneWaveInGrayscale.Location = new System.Drawing.Point(116, 41);
            this.btnPlaneWaveInGrayscale.Name = "btnPlaneWaveInGrayscale";
            this.btnPlaneWaveInGrayscale.Size = new System.Drawing.Size(138, 23);
            this.btnPlaneWaveInGrayscale.TabIndex = 4;
            this.btnPlaneWaveInGrayscale.Text = "Plane wave in grayscale";
            this.btnPlaneWaveInGrayscale.UseVisualStyleBackColor = true;
            this.btnPlaneWaveInGrayscale.Click += new System.EventHandler(this.btnPlaneWaveInGrayscale_Click);
            // 
            // btnToGrey
            // 
            this.btnToGrey.Location = new System.Drawing.Point(116, 12);
            this.btnToGrey.Name = "btnToGrey";
            this.btnToGrey.Size = new System.Drawing.Size(75, 23);
            this.btnToGrey.TabIndex = 3;
            this.btnToGrey.Text = "To Grey";
            this.btnToGrey.UseVisualStyleBackColor = true;
            this.btnToGrey.Click += new System.EventHandler(this.btnToGrey_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 191);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1507, 472);
            this.splitContainer1.SplitterDistance = 482;
            this.splitContainer1.TabIndex = 4;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxMiddle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.pictureBoxOutput);
            this.splitContainer2.Size = new System.Drawing.Size(1021, 472);
            this.splitContainer2.SplitterDistance = 523;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBoxMiddle
            // 
            this.pictureBoxMiddle.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMiddle.Name = "pictureBoxMiddle";
            this.pictureBoxMiddle.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMiddle.TabIndex = 0;
            this.pictureBoxMiddle.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOutput.TabIndex = 1;
            this.pictureBoxOutput.TabStop = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // gbHoughTransform
            // 
            this.gbHoughTransform.Controls.Add(this.tbThresholdNumberPoints);
            this.gbHoughTransform.Controls.Add(this.tbThresholdBrightness);
            this.gbHoughTransform.Controls.Add(this.labelThresholdNumberPoints);
            this.gbHoughTransform.Controls.Add(this.labelThresholdBrightness);
            this.gbHoughTransform.Controls.Add(this.btnHoughTransform);
            this.gbHoughTransform.Location = new System.Drawing.Point(1310, 13);
            this.gbHoughTransform.Name = "gbHoughTransform";
            this.gbHoughTransform.Size = new System.Drawing.Size(184, 94);
            this.gbHoughTransform.TabIndex = 17;
            this.gbHoughTransform.TabStop = false;
            this.gbHoughTransform.Text = "Hough transform";
            // 
            // labelThresholdBrightness
            // 
            this.labelThresholdBrightness.AutoSize = true;
            this.labelThresholdBrightness.Location = new System.Drawing.Point(24, 18);
            this.labelThresholdBrightness.Name = "labelThresholdBrightness";
            this.labelThresholdBrightness.Size = new System.Drawing.Size(108, 13);
            this.labelThresholdBrightness.TabIndex = 6;
            this.labelThresholdBrightness.Text = "Threshold brightness:";
            // 
            // labelThresholdNumberPoints
            // 
            this.labelThresholdNumberPoints.AutoSize = true;
            this.labelThresholdNumberPoints.Location = new System.Drawing.Point(6, 41);
            this.labelThresholdNumberPoints.Name = "labelThresholdNumberPoints";
            this.labelThresholdNumberPoints.Size = new System.Drawing.Size(126, 13);
            this.labelThresholdNumberPoints.TabIndex = 7;
            this.labelThresholdNumberPoints.Text = "Threshold number points:";
            // 
            // tbThresholdBrightness
            // 
            this.tbThresholdBrightness.Location = new System.Drawing.Point(138, 14);
            this.tbThresholdBrightness.Name = "tbThresholdBrightness";
            this.tbThresholdBrightness.Size = new System.Drawing.Size(36, 20);
            this.tbThresholdBrightness.TabIndex = 8;
            this.tbThresholdBrightness.Text = "200";
            // 
            // tbThresholdNumberPoints
            // 
            this.tbThresholdNumberPoints.Location = new System.Drawing.Point(138, 37);
            this.tbThresholdNumberPoints.Name = "tbThresholdNumberPoints";
            this.tbThresholdNumberPoints.Size = new System.Drawing.Size(36, 20);
            this.tbThresholdNumberPoints.TabIndex = 9;
            this.tbThresholdNumberPoints.Text = "50";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 663);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbLaplacian.ResumeLayout(false);
            this.gbLaplacian.PerformLayout();
            this.gbGradient.ResumeLayout(false);
            this.gbHighFrequencyFilter.ResumeLayout(false);
            this.gbHighFrequencyFilter.PerformLayout();
            this.gbMedianFilter.ResumeLayout(false);
            this.gbMedianFilter.PerformLayout();
            this.gbGaussNoise.ResumeLayout(false);
            this.gbGaussNoise.PerformLayout();
            this.gbLowFrequencyFilter.ResumeLayout(false);
            this.gbLowFrequencyFilter.PerformLayout();
            this.gbOutputPicturebox.ResumeLayout(false);
            this.gbOutputPicturebox.PerformLayout();
            this.groupBoxInterference.ResumeLayout(false);
            this.groupBoxInterference.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.gbHoughTransform.ResumeLayout(false);
            this.gbHoughTransform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Gauss_noise_color;
        private System.Windows.Forms.Button btnGaussNoiseNotColor;
        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.Button btnToGrey;
        private System.Windows.Forms.Button btnPlaneWaveInGrayscale;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button btnMaxwellTriangle;
        private System.Windows.Forms.GroupBox groupBoxInterference;
        private System.Windows.Forms.TextBox tbIntensityInterference;
        private System.Windows.Forms.Button btnSaltPepperInterference;
        private System.Windows.Forms.Button btnPepperInterference;
        private System.Windows.Forms.Button btnSaltInterference;
        private System.Windows.Forms.Label labelIntensityInterference;
        private System.Windows.Forms.RadioButton rbPictureboxOutput;
        private System.Windows.Forms.RadioButton rbPictureboxInput;
        private System.Windows.Forms.GroupBox gbOutputPicturebox;
        private System.Windows.Forms.RadioButton rbPictureboxMiddle;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBoxMiddle;
        private System.Windows.Forms.GroupBox gbLowFrequencyFilter;
        private System.Windows.Forms.Button btnRecursiveLowFrequencyFilter;
        private System.Windows.Forms.ComboBox comboBoxCKO;
        private System.Windows.Forms.Button btnLinearLowFrequencyFilter;
        private System.Windows.Forms.GroupBox gbGaussNoise;
        private System.Windows.Forms.Label labelIntensity;
        private System.Windows.Forms.TextBox tbIntensity;
        private System.Windows.Forms.TextBox tbCriterionQualityRestoration;
        private System.Windows.Forms.Label labelCriterionQualityRestoration;
        private System.Windows.Forms.Label labelCKO;
        private System.Windows.Forms.Button btnMedianFilter;
        private System.Windows.Forms.GroupBox gbMedianFilter;
        private System.Windows.Forms.Label labelApertureSize;
        private System.Windows.Forms.Label labelApertureForm;
        private System.Windows.Forms.ComboBox comboBoxApertureForm;
        private System.Windows.Forms.ComboBox comboBoxApertureSize;
        private System.Windows.Forms.GroupBox gbHighFrequencyFilter;
        private System.Windows.Forms.Button btnHighFrequencyFilter;
        private System.Windows.Forms.ComboBox comboBoxMaskHighFrequencyFilter;
        private System.Windows.Forms.Label labelMaskHighFrequencyFilter;
        private System.Windows.Forms.Button btnSavePicture;
        private System.Windows.Forms.Button btnGradient;
        private System.Windows.Forms.GroupBox gbGradient;
        private System.Windows.Forms.ComboBox comboBoxGradient;
        private System.Windows.Forms.GroupBox gbLaplacian;
        private System.Windows.Forms.Button btnLaplacian;
        private System.Windows.Forms.ComboBox comboBoxLaplacianMask;
        private System.Windows.Forms.Label labelLaplacianMask;
        private System.Windows.Forms.Button btnHoughTransform;
        private System.Windows.Forms.GroupBox gbHoughTransform;
        private System.Windows.Forms.TextBox tbThresholdNumberPoints;
        private System.Windows.Forms.TextBox tbThresholdBrightness;
        private System.Windows.Forms.Label labelThresholdNumberPoints;
        private System.Windows.Forms.Label labelThresholdBrightness;
    }
}

