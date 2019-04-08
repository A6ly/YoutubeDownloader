namespace Youtube_Audio_Video_Downloader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Download_button = new System.Windows.Forms.Button();
            this.YoutubeURL_textBox = new System.Windows.Forms.TextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Converter_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Download_button
            // 
            this.Download_button.Location = new System.Drawing.Point(564, 64);
            this.Download_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Download_button.Name = "Download_button";
            this.Download_button.Size = new System.Drawing.Size(132, 49);
            this.Download_button.TabIndex = 0;
            this.Download_button.Text = "Download";
            this.Download_button.UseVisualStyleBackColor = true;
            this.Download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // YoutubeURL_textBox
            // 
            this.YoutubeURL_textBox.Location = new System.Drawing.Point(14, 75);
            this.YoutubeURL_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YoutubeURL_textBox.Name = "YoutubeURL_textBox";
            this.YoutubeURL_textBox.Size = new System.Drawing.Size(402, 27);
            this.YoutubeURL_textBox.TabIndex = 2;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Converter_comboBox
            // 
            this.Converter_comboBox.FormattingEnabled = true;
            this.Converter_comboBox.Items.AddRange(new object[] {
            "MP3",
            "MP4",
            "AVI",
            "WAV"});
            this.Converter_comboBox.Location = new System.Drawing.Point(422, 75);
            this.Converter_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Converter_comboBox.Name = "Converter_comboBox";
            this.Converter_comboBox.Size = new System.Drawing.Size(136, 28);
            this.Converter_comboBox.TabIndex = 1;
            this.Converter_comboBox.Text = "MP3";
            // 
            // Form1
            // 
            this.AcceptButton = this.Download_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 120);
            this.Controls.Add(this.YoutubeURL_textBox);
            this.Controls.Add(this.Converter_comboBox);
            this.Controls.Add(this.Download_button);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(22, 80, 22, 27);
            this.Text = "Youtube Audio & Video Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Download_button;
        private System.Windows.Forms.TextBox YoutubeURL_textBox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ComboBox Converter_comboBox;
    }
}

