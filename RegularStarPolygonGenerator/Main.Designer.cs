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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularStarPolygonGenerator));
            this.Version = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.Button();
            this.GeneratedImage = new System.Windows.Forms.PictureBox();
            this.Num_N = new System.Windows.Forms.NumericUpDown();
            this.Num_M = new System.Windows.Forms.NumericUpDown();
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Num_ImgSize = new System.Windows.Forms.NumericUpDown();
            this.Gra_RegularPolygon = new System.Windows.Forms.CheckBox();
            this.Gra_Circle = new System.Windows.Forms.CheckBox();
            this.Gra_Fill = new System.Windows.Forms.CheckBox();
            this.ChangeBackColor = new System.Windows.Forms.Button();
            this.ChangePolygonColor = new System.Windows.Forms.Button();
            this.BackColorSample = new System.Windows.Forms.Label();
            this.PolygonColorSample = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Text3 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ColorCount = new System.Windows.Forms.Button();
            this.RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RC_SoftInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_DeverInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.RCbar = new System.Windows.Forms.ToolStripSeparator();
            this.RC_Reboot = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_SI_README = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_SI_Repository = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_DI_Twitter = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_DI_GitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_DI_HomePage = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ImgSize)).BeginInit();
            this.RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Version.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.Version.Location = new System.Drawing.Point(0, 78);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(500, 22);
            this.Version.TabIndex = 0;
            this.Version.Text = "進捗:　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　v1.1.0";
            this.Version.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Generation
            // 
            this.Generation.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Generation.Location = new System.Drawing.Point(396, 4);
            this.Generation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(100, 70);
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
            this.GeneratedImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeneratedImage.Name = "GeneratedImage";
            this.GeneratedImage.Size = new System.Drawing.Size(500, 500);
            this.GeneratedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeneratedImage.TabIndex = 4;
            this.GeneratedImage.TabStop = false;
            // 
            // Num_N
            // 
            this.Num_N.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num_N.Location = new System.Drawing.Point(66, 3);
            this.Num_N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.Num_M.Location = new System.Drawing.Point(196, 3);
            this.Num_M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.Text1.Location = new System.Drawing.Point(3, 5);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(63, 16);
            this.Text1.TabIndex = 7;
            this.Text1.Text = "辺の数n:";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Text2.Location = new System.Drawing.Point(130, 5);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(67, 16);
            this.Text2.TabIndex = 8;
            this.Text2.Text = "飛び数m:";
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
            // Num_ImgSize
            // 
            this.Num_ImgSize.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num_ImgSize.Location = new System.Drawing.Point(330, 3);
            this.Num_ImgSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            // Gra_RegularPolygon
            // 
            this.Gra_RegularPolygon.AutoSize = true;
            this.Gra_RegularPolygon.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Gra_RegularPolygon.Location = new System.Drawing.Point(6, 30);
            this.Gra_RegularPolygon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gra_RegularPolygon.Name = "Gra_RegularPolygon";
            this.Gra_RegularPolygon.Size = new System.Drawing.Size(166, 20);
            this.Gra_RegularPolygon.TabIndex = 14;
            this.Gra_RegularPolygon.Text = "外接正多角形も描画";
            this.Gra_RegularPolygon.UseVisualStyleBackColor = true;
            // 
            // Gra_Circle
            // 
            this.Gra_Circle.AutoSize = true;
            this.Gra_Circle.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Gra_Circle.Location = new System.Drawing.Point(179, 30);
            this.Gra_Circle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gra_Circle.Name = "Gra_Circle";
            this.Gra_Circle.Size = new System.Drawing.Size(118, 20);
            this.Gra_Circle.TabIndex = 15;
            this.Gra_Circle.Text = "外接円も描画";
            this.Gra_Circle.UseVisualStyleBackColor = true;
            // 
            // Gra_Fill
            // 
            this.Gra_Fill.AutoSize = true;
            this.Gra_Fill.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Gra_Fill.Location = new System.Drawing.Point(305, 30);
            this.Gra_Fill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gra_Fill.Name = "Gra_Fill";
            this.Gra_Fill.Size = new System.Drawing.Size(90, 20);
            this.Gra_Fill.TabIndex = 16;
            this.Gra_Fill.Text = "塗りつぶし";
            this.Gra_Fill.UseVisualStyleBackColor = true;
            // 
            // ChangeBackColor
            // 
            this.ChangeBackColor.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ChangeBackColor.Location = new System.Drawing.Point(5, 51);
            this.ChangeBackColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeBackColor.Name = "ChangeBackColor";
            this.ChangeBackColor.Size = new System.Drawing.Size(95, 23);
            this.ChangeBackColor.TabIndex = 17;
            this.ChangeBackColor.Text = "背景色変更";
            this.ChangeBackColor.UseVisualStyleBackColor = true;
            this.ChangeBackColor.Click += new System.EventHandler(this.ChangeBackColor_Click);
            // 
            // ChangePolygonColor
            // 
            this.ChangePolygonColor.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ChangePolygonColor.Location = new System.Drawing.Point(137, 51);
            this.ChangePolygonColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangePolygonColor.Name = "ChangePolygonColor";
            this.ChangePolygonColor.Size = new System.Drawing.Size(95, 23);
            this.ChangePolygonColor.TabIndex = 18;
            this.ChangePolygonColor.Text = "図形色変更";
            this.ChangePolygonColor.UseVisualStyleBackColor = true;
            this.ChangePolygonColor.Click += new System.EventHandler(this.ChangePolygonColor_Click);
            // 
            // BackColorSample
            // 
            this.BackColorSample.BackColor = System.Drawing.Color.White;
            this.BackColorSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackColorSample.Location = new System.Drawing.Point(101, 53);
            this.BackColorSample.Name = "BackColorSample";
            this.BackColorSample.Size = new System.Drawing.Size(20, 20);
            this.BackColorSample.TabIndex = 19;
            // 
            // PolygonColorSample
            // 
            this.PolygonColorSample.BackColor = System.Drawing.Color.Black;
            this.PolygonColorSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PolygonColorSample.Location = new System.Drawing.Point(233, 53);
            this.PolygonColorSample.Name = "PolygonColorSample";
            this.PolygonColorSample.Size = new System.Drawing.Size(20, 20);
            this.PolygonColorSample.TabIndex = 20;
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.FullOpen = true;
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Text3.Location = new System.Drawing.Point(259, 6);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(73, 16);
            this.Text3.TabIndex = 21;
            this.Text3.Text = "サイズ(px):";
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.ProgressBar.Location = new System.Drawing.Point(50, 79);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(400, 20);
            this.ProgressBar.TabIndex = 23;
            // 
            // ColorCount
            // 
            this.ColorCount.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ColorCount.Location = new System.Drawing.Point(269, 51);
            this.ColorCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorCount.Name = "ColorCount";
            this.ColorCount.Size = new System.Drawing.Size(117, 23);
            this.ColorCount.TabIndex = 24;
            this.ColorCount.Text = "←この色を数える";
            this.ColorCount.UseVisualStyleBackColor = true;
            this.ColorCount.Click += new System.EventHandler(this.ColorCount_Click);
            // 
            // RightClick
            // 
            this.RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RC_SoftInfo,
            this.RC_DeverInfo,
            this.RCbar,
            this.RC_Reboot,
            this.RC_Exit});
            this.RightClick.Name = "RightClick";
            this.RightClick.Size = new System.Drawing.Size(181, 120);
            // 
            // RC_SoftInfo
            // 
            this.RC_SoftInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RC_SI_README,
            this.RC_SI_Repository});
            this.RC_SoftInfo.Name = "RC_SoftInfo";
            this.RC_SoftInfo.Size = new System.Drawing.Size(180, 22);
            this.RC_SoftInfo.Text = "ソフト詳細";
            // 
            // RC_DeverInfo
            // 
            this.RC_DeverInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RC_DI_Twitter,
            this.RC_DI_GitHub,
            this.RC_DI_HomePage});
            this.RC_DeverInfo.Name = "RC_DeverInfo";
            this.RC_DeverInfo.Size = new System.Drawing.Size(180, 22);
            this.RC_DeverInfo.Text = "製作者詳細";
            // 
            // RCbar
            // 
            this.RCbar.Name = "RCbar";
            this.RCbar.Size = new System.Drawing.Size(131, 6);
            // 
            // RC_Reboot
            // 
            this.RC_Reboot.Name = "RC_Reboot";
            this.RC_Reboot.Size = new System.Drawing.Size(180, 22);
            this.RC_Reboot.Text = "再起動";
            this.RC_Reboot.Click += new System.EventHandler(this.RC_Reboot_Click);
            // 
            // RC_Exit
            // 
            this.RC_Exit.Name = "RC_Exit";
            this.RC_Exit.Size = new System.Drawing.Size(180, 22);
            this.RC_Exit.Text = "終了";
            this.RC_Exit.Click += new System.EventHandler(this.RC_Exit_Click);
            // 
            // RC_SI_README
            // 
            this.RC_SI_README.Name = "RC_SI_README";
            this.RC_SI_README.Size = new System.Drawing.Size(180, 22);
            this.RC_SI_README.Text = "GitHub - README";
            this.RC_SI_README.Click += new System.EventHandler(this.RC_SI_README_Click);
            // 
            // RC_SI_Repository
            // 
            this.RC_SI_Repository.Name = "RC_SI_Repository";
            this.RC_SI_Repository.Size = new System.Drawing.Size(180, 22);
            this.RC_SI_Repository.Text = "GitHub - レポジトリ";
            this.RC_SI_Repository.Click += new System.EventHandler(this.RC_SI_Repository_Click);
            // 
            // RC_DI_Twitter
            // 
            this.RC_DI_Twitter.Name = "RC_DI_Twitter";
            this.RC_DI_Twitter.Size = new System.Drawing.Size(212, 22);
            this.RC_DI_Twitter.Text = "Twitter(@ProjectS31415_1)";
            this.RC_DI_Twitter.Click += new System.EventHandler(this.RC_DI_Twitter_Click);
            // 
            // RC_DI_GitHub
            // 
            this.RC_DI_GitHub.Name = "RC_DI_GitHub";
            this.RC_DI_GitHub.Size = new System.Drawing.Size(212, 22);
            this.RC_DI_GitHub.Text = "GitHub(@Ichihai1415)";
            this.RC_DI_GitHub.Click += new System.EventHandler(this.RC_DI_GitHub_Click);
            // 
            // RC_DI_HomePage
            // 
            this.RC_DI_HomePage.Name = "RC_DI_HomePage";
            this.RC_DI_HomePage.Size = new System.Drawing.Size(212, 22);
            this.RC_DI_HomePage.Text = "ホームページ(GitHub Page)";
            this.RC_DI_HomePage.Click += new System.EventHandler(this.RC_DI_HomePage_Click);
            // 
            // RegularStarPolygonGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.ColorCount);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Num_ImgSize);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.PolygonColorSample);
            this.Controls.Add(this.BackColorSample);
            this.Controls.Add(this.ChangePolygonColor);
            this.Controls.Add(this.ChangeBackColor);
            this.Controls.Add(this.Gra_Fill);
            this.Controls.Add(this.Gra_Circle);
            this.Controls.Add(this.Gra_RegularPolygon);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Num_M);
            this.Controls.Add(this.Num_N);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.GeneratedImage);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(516, 639);
            this.MinimumSize = new System.Drawing.Size(516, 639);
            this.Name = "RegularStarPolygonGenerator";
            this.Text = "RegularStarPolygonGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ImgSize)).EndInit();
            this.RightClick.ResumeLayout(false);
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
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.NumericUpDown Num_ImgSize;
        private System.Windows.Forms.CheckBox Gra_RegularPolygon;
        private System.Windows.Forms.CheckBox Gra_Circle;
        private System.Windows.Forms.CheckBox Gra_Fill;
        private System.Windows.Forms.Button ChangeBackColor;
        private System.Windows.Forms.Button ChangePolygonColor;
        private System.Windows.Forms.Label BackColorSample;
        private System.Windows.Forms.Label PolygonColorSample;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ColorCount;
        private System.Windows.Forms.ContextMenuStrip RightClick;
        private System.Windows.Forms.ToolStripMenuItem RC_SoftInfo;
        private System.Windows.Forms.ToolStripMenuItem RC_SI_README;
        private System.Windows.Forms.ToolStripMenuItem RC_SI_Repository;
        private System.Windows.Forms.ToolStripMenuItem RC_DeverInfo;
        private System.Windows.Forms.ToolStripSeparator RCbar;
        private System.Windows.Forms.ToolStripMenuItem RC_Reboot;
        private System.Windows.Forms.ToolStripMenuItem RC_Exit;
        private System.Windows.Forms.ToolStripMenuItem RC_DI_Twitter;
        private System.Windows.Forms.ToolStripMenuItem RC_DI_GitHub;
        private System.Windows.Forms.ToolStripMenuItem RC_DI_HomePage;
    }
}

