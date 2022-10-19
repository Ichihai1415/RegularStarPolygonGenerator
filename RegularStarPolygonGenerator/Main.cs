using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegularStarPolygonGenerator
{
    public partial class RegularStarPolygonGenerator : Form
    {
        public RegularStarPolygonGenerator()
        {
            InitializeComponent();
        }

        private async void Generation_Click(object sender, EventArgs e)
        {
            try
            {
                Generation.Enabled = false;
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 生成開始");
                DateTime StartTime = DateTime.Now;
                ProgressBar.Value = 0;

                Message.Text = "準備中...";
                int N = (int)Num_N.Value;
                int M = (int)Num_M.Value;
                int ImgSize = (int)Num_ImgSize.Value;
                if (N <= M * 2)
                    throw new RegularStarPolygonGeneratorException("値が不正です。辺の数 > 飛び数 x 2 である必要があります。");
                if (N % M == 0)
                    throw new RegularStarPolygonGeneratorException("星型正多角形ではありません。生成対象外です。N ÷ M の余りが0以外である必要があります。");
                int A = GreatestCommonDivisor(N,M);
                if (A != 1)
                {

                    Console.WriteLine($"NとMが同じ数({A})で割れます。Nを{N/A}、Mを{M/A}として計算します。");

                }
                Img = new Bitmap(ImgSize, ImgSize);
                await Task.Run(() => 
                { 
                    Invoke((MethodInvoker)(() => 
                    {
                        Draw(N/A,M/A,ImgSize); 
                    })); 
                });
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 生成完了");
                Console.WriteLine($"生成時間:{(DateTime.Now - StartTime).TotalMilliseconds}ms");
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 保存開始");
                if (!Directory.Exists("output"))
                    Directory.CreateDirectory("output");
                if (!Directory.Exists($"output\\{N}"))
                    Directory.CreateDirectory($"output\\{N}");
                if (!Directory.Exists($"output\\{N}\\{M}"))
                    Directory.CreateDirectory($"output\\{N}\\{M}");
                await Task.Run(() => 
                {
                    Invoke((MethodInvoker)(() => 
                    {
                        Message.Text = "表示準備中...";
                        ProgressBar.Value = 60;
                        GeneratedImage.Image = Img;
                        Message.Text = "画像保存中...";
                        ProgressBar.Value = 80;
                        Img.Save($"output\\{N}\\{M}\\{N}-{M}-{ImgSize}px.png", ImageFormat.Png);
                        ProgressBar.Value = 100;
                        Console.WriteLine($"output\\{N}\\{M}\\{N}-{M}-{ImgSize}px.pngに保存しました。");
                    }));
                });
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 保存完了");
                if (N % M == 0)
                    Message.Text = "※星型正多角形ではありません。";
                else
                    Message.Text = "";
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////\n" + ex + "\n////////////////////////////////////////////////////////////////////////////////////////////////////");
            }
            finally
            {
                Generation.Enabled = true;
                ProgressBar.Value = 0;
                Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
            }
        }
        /// <summary>
        /// 星型正多角形を描画します。
        /// </summary>
        /// <param name="N">辺の数。</param>
        /// <param name="M">飛び数。</param>
        /// <param name="ImgSize">画像サイズ。</param>
        public void Draw(int N,int M,int ImgSize)
        {
            Console.WriteLine($"辺の数:{N}");
            Console.WriteLine($"飛び数:{M}");
            Console.WriteLine($"画像サイズ:{ImgSize}px");
            int L = ImgSize / 2;//半径
            Console.WriteLine($"外接円半径:{L}px");
            Graphics g = Graphics.FromImage(Img);
            double AngleRad = Math.PI * 2 / N;
            Console.WriteLine($"外接正n角形内角ラジアン:{AngleRad}");
            Console.WriteLine($"外接正n角形内角:{180 * (N - 2) / N}°");
            Console.WriteLine($"外接正n角形内角合計:{180 * (N - 2)}°");
            List<Point> Points_RegularPolygon = new List<Point>();//正n角形の頂点座標(中心:0,0)
            List<Point> Points_StarRegularPolygon = new List<Point>();//星型正n角形の頂点座標
            Message.Text = "座標計算中...(1/2)";
            ProgressBar.Value = 10;
            for (int i = 0; i < N; i++)
            {
                double AngleRad_ = AngleRad * i + Math.PI;
                Points_RegularPolygon.Add(new Point((int)Math.Round(Math.Sin(AngleRad_) * L, MidpointRounding.AwayFromZero), (int)Math.Round(Math.Cos(AngleRad_) * L, MidpointRounding.AwayFromZero)));
                Console.WriteLine($"外接正n角形頂点座標{i + 1}:{Points_RegularPolygon[i].X + L},{Points_RegularPolygon[i].Y + L}");
            }
            Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 正n角形頂点座標計算終了");
            Message.Text = "座標計算中...(2/2)";
            ProgressBar.Value = 30;
            int p = -M;
            for (int i = 0; i < Points_RegularPolygon.Count; i++)
            {
                p += M;
                if (p >= N)
                    p -= N;
                Points_StarRegularPolygon.Add(new Point(Points_RegularPolygon[p].X, Points_RegularPolygon[p].Y));
                Console.WriteLine($"星型正n角形頂点座標{i + 1}:外接正n角形頂点{p + 1},{Points_StarRegularPolygon[i].X + L},{Points_StarRegularPolygon[i].Y + L}");
            }
            Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 星型正n角形頂点座標計算終了");
            g.TranslateTransform(L, L); //移動して-部分を無くす
            double Angle_Star = 180 * (N - 2 * M);
            double LineLong = L * Math.Cos(Angle_Star / N * (Math.PI / 180)) * 2;
            Console.WriteLine($"描画情報再掲");
            Console.WriteLine($"　辺の数:{N}");
            Console.WriteLine($"　飛び数:{M}");
            Console.WriteLine($"　画像サイズ:{ImgSize}px");
            Console.WriteLine($"　外接円半径:{L}px");
            Console.WriteLine($"　外接正n角形内角ラジアン:{AngleRad}");
            Console.WriteLine($"　外接正n角形内角:{180 * (N - 2) / N}°");
            Console.WriteLine($"　外接正n角形内角合計:{180 * (N - 2)}°");
            Console.WriteLine($"その他情報");
            Console.WriteLine($"　一辺の長さ:{LineLong}px");
            Console.WriteLine($"　内角の大きさ:{Angle_Star / N}°");
            Console.WriteLine($"　内角の合計:{Angle_Star}°");
            Message.Text = "描画中...";
            ProgressBar.Value = 50;
            g.Clear(Color.White);
            g.DrawPolygon(Pens.Black, Points_StarRegularPolygon.ToArray());
        }
        public Bitmap Img;
        private void Wiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ja.wikipedia.org/wiki/%E6%98%9F%E5%9E%8B%E6%AD%A3%E5%A4%9A%E8%A7%92%E5%BD%A2");
        }

        /// <summary>
        /// ユークリッドの互除法を利用して最大公約数を求めます。
        /// </summary>
        /// <remarks>a>bである必要があります。</remarks>
        /// <param name="A">自然数A。</param>
        /// <param name="B">自然数B。</param>
        /// <returns>計算された最大公約数。</returns>
        public int GreatestCommonDivisor(int A, int B)
        {
            while (B != 0)
            {
                int Temp = A % B;
                A = B;
                B = Temp;
            }
            return A;
        }

        private void ChangeBackColor_Click(object sender, EventArgs e)
        {
            SelectColor.ShowDialog();
            BackColorSample.BackColor = SelectColor.Color;
        }

        private void ChangePolygonColor_Click(object sender, EventArgs e)
        {
            SelectColor.ShowDialog();
            PolygonColorSample.BackColor = SelectColor.Color;
        }

        private void ColorCount_Click(object sender, EventArgs e)
        {
            try
            {
                int Count = 0;
                int ImgSize = (int)Num_ImgSize.Value;
                Color CheckColor = PolygonColorSample.BackColor;
                for (int x = 0; x < ImgSize; x++)
                {
                    int Count_ = 0;
                    for (int y = 0; y < ImgSize; y++)
                    {
                        if (Img.GetPixel(x, y) == CheckColor)
                            Count_++;
                    }
                    Count += Count_;
                    Console.WriteLine($"X:{x} 対象数:{Count_}/{ImgSize} 累計:{Count}/{ImgSize * x + ImgSize}");
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        readonly ColorDialog SelectColor = new ColorDialog();

        private void RC_SI_README_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ichihai1415/RegularStarPolygonGenerator/blob/main/README.md");
        }

        private void RC_SI_Repository_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ichihai1415/RegularStarPolygonGenerator/");
        }

        private void RC_DI_Twitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/ProjectS31415_1");
        }

        private void RC_DI_GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ichihai1415/");
        }

        private void RC_DI_HomePage_Click(object sender, EventArgs e)
        {
            Process.Start("https://ichihai1415.github.io");
        }

        private void RC_Reboot_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void RC_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    [Serializable()]
    public class RegularStarPolygonGeneratorException : Exception
    {
        public RegularStarPolygonGeneratorException() : base()
        {

        }

        public RegularStarPolygonGeneratorException(string message) : base(message)
        {

        }

        public RegularStarPolygonGeneratorException(string message, Exception innerException) : base(message, innerException)
        {

        }
        protected RegularStarPolygonGeneratorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
