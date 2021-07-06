namespace ImNotGoodAtDrawingButTracing
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagePathLabel = new System.Windows.Forms.Label();
            this.ImageFileTextBox = new System.Windows.Forms.TextBox();
            this.FindImageButton = new System.Windows.Forms.Button();
            this.ImageUrlTextBox = new System.Windows.Forms.TextBox();
            this.ImageUrlLabel = new System.Windows.Forms.Label();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.LoadUrlImageButton = new System.Windows.Forms.Button();
            this.LoadFileImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePathLabel
            // 
            this.ImagePathLabel.AutoSize = true;
            this.ImagePathLabel.Location = new System.Drawing.Point(12, 15);
            this.ImagePathLabel.Name = "ImagePathLabel";
            this.ImagePathLabel.Size = new System.Drawing.Size(101, 12);
            this.ImagePathLabel.TabIndex = 0;
            this.ImagePathLabel.Text = "이미지 파일 위치:";
            // 
            // ImageFileTextBox
            // 
            this.ImageFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageFileTextBox.Location = new System.Drawing.Point(119, 12);
            this.ImageFileTextBox.Name = "ImageFileTextBox";
            this.ImageFileTextBox.Size = new System.Drawing.Size(418, 21);
            this.ImageFileTextBox.TabIndex = 1;
            // 
            // FindImageButton
            // 
            this.FindImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindImageButton.Location = new System.Drawing.Point(542, 10);
            this.FindImageButton.Name = "FindImageButton";
            this.FindImageButton.Size = new System.Drawing.Size(75, 23);
            this.FindImageButton.TabIndex = 2;
            this.FindImageButton.Text = "파일 찾기";
            this.FindImageButton.UseVisualStyleBackColor = true;
            this.FindImageButton.Click += new System.EventHandler(this.FindImageButton_Click);
            // 
            // ImageUrlTextBox
            // 
            this.ImageUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageUrlTextBox.Location = new System.Drawing.Point(94, 40);
            this.ImageUrlTextBox.Name = "ImageUrlTextBox";
            this.ImageUrlTextBox.Size = new System.Drawing.Size(524, 21);
            this.ImageUrlTextBox.TabIndex = 3;
            // 
            // ImageUrlLabel
            // 
            this.ImageUrlLabel.AutoSize = true;
            this.ImageUrlLabel.Location = new System.Drawing.Point(12, 43);
            this.ImageUrlLabel.Name = "ImageUrlLabel";
            this.ImageUrlLabel.Size = new System.Drawing.Size(76, 12);
            this.ImageUrlLabel.TabIndex = 4;
            this.ImageUrlLabel.Text = "이미지 URL: ";
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "Sample.png";
            this.FileDialog.Filter = "이미지|*.png;*.jpg;*.bmp";
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.Location = new System.Drawing.Point(12, 67);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(713, 562);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 5;
            this.ImageBox.TabStop = false;
            // 
            // LoadUrlImageButton
            // 
            this.LoadUrlImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadUrlImageButton.Location = new System.Drawing.Point(624, 38);
            this.LoadUrlImageButton.Name = "LoadUrlImageButton";
            this.LoadUrlImageButton.Size = new System.Drawing.Size(101, 23);
            this.LoadUrlImageButton.TabIndex = 6;
            this.LoadUrlImageButton.Text = "이미지 불러오기";
            this.LoadUrlImageButton.UseVisualStyleBackColor = true;
            this.LoadUrlImageButton.Click += new System.EventHandler(this.LoadUrlImageButton_Click);
            // 
            // LoadFileImage
            // 
            this.LoadFileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFileImage.Location = new System.Drawing.Point(624, 10);
            this.LoadFileImage.Name = "LoadFileImage";
            this.LoadFileImage.Size = new System.Drawing.Size(101, 23);
            this.LoadFileImage.TabIndex = 7;
            this.LoadFileImage.Text = "이미지 불러오기";
            this.LoadFileImage.UseVisualStyleBackColor = true;
            this.LoadFileImage.Click += new System.EventHandler(this.LoadFileImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 641);
            this.Controls.Add(this.LoadFileImage);
            this.Controls.Add(this.LoadUrlImageButton);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.ImageUrlLabel);
            this.Controls.Add(this.ImageUrlTextBox);
            this.Controls.Add(this.FindImageButton);
            this.Controls.Add(this.ImageFileTextBox);
            this.Controls.Add(this.ImagePathLabel);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tracer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImagePathLabel;
        private System.Windows.Forms.TextBox ImageFileTextBox;
        private System.Windows.Forms.Button FindImageButton;
        private System.Windows.Forms.TextBox ImageUrlTextBox;
        private System.Windows.Forms.Label ImageUrlLabel;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button LoadUrlImageButton;
        private System.Windows.Forms.Button LoadFileImage;
    }
}
