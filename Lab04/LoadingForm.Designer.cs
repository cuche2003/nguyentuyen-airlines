namespace Lab04
{
    partial class LoadingForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            tmLoading = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            lblLoading = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tmLoading
            // 
            tmLoading.Interval = 5000;
            tmLoading.Tick += tmLoading_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 366);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLoading
            // 
            lblLoading.Dock = DockStyle.Bottom;
            lblLoading.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoading.Location = new Point(0, 381);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(800, 83);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "Loading...";
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(lblLoading);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoadingForm";
            Text = "Loading";
            Load += LoadingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer tmLoading;
        private PictureBox pictureBox1;
        private Label lblLoading;
    }
}