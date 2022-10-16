namespace RegularStarPolygonGenerator
{
    partial class RegularStarPolygonGenerator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularStarPolygonGenerator));
            this.Version = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.Button();
            this.GeneratedImage = new System.Windows.Forms.PictureBox();
            this.Num_N = new System.Windows.Forms.NumericUpDown();
            this.Num_M = new System.Windows.Forms.NumericUpDown();
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Wiki = new System.Windows.Forms.LinkLabel();
            this.Message = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.Num_ImgSize = new System.Windows.Forms.NumericUpDown();
            this.Text4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ImgSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.Version.Location = new System.Drawing.Point(456, 83);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(41, 14);
            this.Version.TabIndex = 0;
            this.Version.Text = "v1.0.0";
            // 
            // Generation
            // 
            this.Generation.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Generation.Location = new System.Drawing.Point(450, 3);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(47, 24);
            this.Generation.TabIndex = 2;
            this.Generation.Text = "生成";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // GeneratedImage
            // 
            this.GeneratedImage.BackColor = System.Drawing.Color.White;
            this.GeneratedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneratedImage.Location = new System.Drawing.Point(0, 100);
            this.GeneratedImage.Name = "GeneratedImage";
            this.GeneratedImage.Size = new System.Drawing.Size(500, 500);
            this.GeneratedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeneratedImage.TabIndex = 4;
            this.GeneratedImage.TabStop = false;
            // 
            // Num_N
            // 
            this.Num_N.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num_N.Location = new System.Drawing.Point(67, 3);
            this.Num_N.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Num_N.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Num_N.Name = "Num_N";
            this.Num_N.Size = new System.Drawing.Size(60, 23);
            this.Num_N.TabIndex = 5;
            this.Num_N.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Num_M
            // 
            this.Num_M.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num_M.Location = new System.Drawing.Point(197, 3);
            this.Num_M.Maximum = new decimal(new int[] {
            49999,
            0,
            0,
            0});
            this.Num_M.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_M.Name = "Num_M";
            this.Num_M.Size = new System.Drawing.Size(60, 23);
            this.Num_M.TabIndex = 6;
            this.Num_M.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Text1.Location = new System.Drawing.Point(4, 6);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(63, 16);
            this.Text1.TabIndex = 7;
            this.Text1.Text = "辺の数n:";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Text2.Location = new System.Drawing.Point(131, 6);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(67, 16);
            this.Text2.TabIndex = 8;
            this.Text2.Text = "飛び数m:";
            // 
            // Wiki
            // 
            this.Wiki.AutoSize = true;
            this.Wiki.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Wiki.Location = new System.Drawing.Point(269, 80);
            this.Wiki.Name = "Wiki";
            this.Wiki.Size = new System.Drawing.Size(181, 16);
            this.Wiki.TabIndex = 9;
            this.Wiki.TabStop = true;
            this.Wiki.Text = "星型正多角形 - Wikipedia";
            this.Wiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Wiki_LinkClicked);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.White;
            this.Message.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Message.Location = new System.Drawing.Point(1, 101);
            this.Message.MaximumSize = new System.Drawing.Size(498, 498);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 27);
            this.Message.TabIndex = 10;
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Text3.Location = new System.Drawing.Point(260, 6);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(105, 16);
            this.Text3.TabIndex = 11;
            this.Text3.Text = "出力サイズ(px):";
            // 
            // Num_ImgSize
            // 
            this.Num_ImgSize.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num_ImgSize.Location = new System.Drawing.Point(364, 3);
            this.Num_ImgSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Num_ImgSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_ImgSize.Name = "Num_ImgSize";
            this.Num_ImgSize.Size = new System.Drawing.Size(60, 23);
            this.Num_ImgSize.TabIndex = 12;
            this.Num_ImgSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Text4.Location = new System.Drawing.Point(1, 80);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(261, 16);
            this.Text4.TabIndex = 13;
            this.Text4.Text = "コンソールに詳しい情報が表示されます。";
            // 
            // RegularStarPolygonGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.Num_ImgSize);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Num_M);
            this.Controls.Add(this.Num_N);
            this.Controls.Add(this.Wiki);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.GeneratedImage);
            this.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(516, 639);
            this.MinimumSize = new System.Drawing.Size(516, 639);
            this.Name = "RegularStarPolygonGenerator";
            this.Text = "RegularStarPolygonGenerator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegularStarPolygonGenerator_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ImgSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.PictureBox GeneratedImage;
        private System.Windows.Forms.NumericUpDown Num_N;
        private System.Windows.Forms.NumericUpDown Num_M;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.LinkLabel Wiki;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.NumericUpDown Num_ImgSize;
        private System.Windows.Forms.Label Text4;
    }
}

