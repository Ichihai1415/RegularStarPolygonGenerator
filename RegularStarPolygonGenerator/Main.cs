using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace RegularStarPolygonGenerator
{
    public partial class RegularStarPolygonGenerator : Form
    {
        public RegularStarPolygonGenerator()
        {
            InitializeComponent();
        }

        private void RegularStarPolygonGenerator_Load(object sender, EventArgs e)
        {

        }

        private void Generation_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 生成開始");
                DateTime StartTime = DateTime.Now;
                Message.Text = "生成中...";
                int N = (int)Num_N.Value;
                int M = (int)Num_M.Value;
                int ImgSize = (int)Num_ImgSize.Value;
                if (N <= M * 2)
                    throw new Exception("値が不正です。");
                if (N % M == 0)
                    Console.WriteLine("※星型正多角形ではありません。");
                Bitmap Img = Draw(N, M, ImgSize);
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 生成完了");
                Console.WriteLine($"生成時間:{(DateTime.Now - StartTime).TotalMilliseconds}ms");
                if (!Directory.Exists("output"))
                    Directory.CreateDirectory("output");
                if (!Directory.Exists($"output\\{N}"))
                    Directory.CreateDirectory($"output\\{N}");
                if (!Directory.Exists($"output\\{N}\\{M}"))
                    Directory.CreateDirectory($"output\\{N}\\{M}");
                Img.Save($"output\\{N}\\{M}\\{M}-{N}-{ImgSize}px.png", ImageFormat.Png);
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 出力完了");
                if (N % M == 0)
                    Message.Text = "※星型正多角形ではありません。";
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////\n" + ex + "\n////////////////////////////////////////////////////////////////////////////////////////////////////");
            }
            finally
            {
                Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
            }
        }
        public Bitmap Draw(int N, int M, int ImgSize)
        {
            Console.WriteLine($"辺の数:{N}");
            Console.WriteLine($"飛び数:{M}");
            Console.WriteLine($"画像サイズ:{ImgSize}px");
            int L = ImgSize / 2;//半径
            Console.WriteLine($"外接円半径:{L}px");
            Bitmap Img = new Bitmap(ImgSize, ImgSize);
                Graphics g = Graphics.FromImage(Img);
            double AngleRad = (Math.PI * 2) / N;
            Console.WriteLine($"外接正n角形ラジアン:{AngleRad}");


            List<Point> Points_RegularPolygon = new List<Point>();//正n角形の頂点座標(中心:0,0)
            List<Point> Points_StarRegularPolygon = new List<Point>();//星型正n角形の頂点座標
            for (int i = 0; i < N; i++)
            {
                double AngleRad_ = AngleRad * i + Math.PI;
                Points_RegularPolygon.Add(new Point((int)Math.Round(Math.Sin(AngleRad_) * L, MidpointRounding.AwayFromZero), (int)Math.Round(Math.Cos(AngleRad_) * L, MidpointRounding.AwayFromZero)));
                Console.WriteLine($"外接正n角形頂点座標{i + 1}:{Points_RegularPolygon[i].X + L},{Points_RegularPolygon[i].Y + L}");
            }
            Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 正n角形頂点座標計算終了");
            int p = -M;
            for (int i = 0; i < Points_RegularPolygon.Count; i++)
            {
                p += M;
                if (p >= N)
                    p -= N;
                Points_StarRegularPolygon.Add(new Point(Points_RegularPolygon[p].X, Points_RegularPolygon[p].Y));
                Console.WriteLine($"星型正n角形頂点座標{i + 1}:外接正n角形頂点{p + 1},{Points_StarRegularPolygon[p + 1].X + L},{Points_StarRegularPolygon[p+1].Y + L}");
            }
            Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} 星型正n角形頂点座標計算終了");
            g.TranslateTransform(L, L); //移動して-部分を無くす
            /*旧版
            int Angle = 180 * ((N - 2) * M / N) / N;
            double AngleRad = Angle * (Math.PI / 180);//Math.SinCosTanはこれ使う
            List<Point> Points = new List<Point>
            {
                new Point(100, 100),
                new Point(Linelong + 100, 100)
            };
            Console.WriteLine($"X:0 Y:0");
            Console.WriteLine($"X:{Linelong} Y:0");

            int PointX_ = Linelong;
            int PointY_ = 0;

            double L = Linelong / 2 / Math.Cos(AngleRad / 2);//半径
            double OX = Linelong / 2;//中心座標
            double OY = Linelong / 2 * Math.Tan(AngleRad / 2);

            Console.WriteLine($"内角:{Angle} 内角ラジアン:{AngleRad} 円半径:{L} 中心座標X:{OX} Y:{OY}");
            for (int i = 2; i < Num_N.Value; i++)
            {
                double PX = PointX_ + Linelong * Math.Sin(AngleRad);
                double PY = PointY_ + Linelong * Math.Cos(AngleRad);
                double PX_ = PointX_ - Linelong * Math.Sin(AngleRad);
                double PY_ = PointY_ - Linelong * Math.Cos(AngleRad);

                Console.WriteLine($"移動後座標X:{PX} Y:{PY} 逆X:{PX_} 逆Y:{PY_} 半径二乗:{L * L}");
                Console.WriteLine($"そのまま:{(OX - PX) * (OX - PX) + (OY - PY) * (OY - PY)} X変:{(OX - PX_) * (OX - PX_) + (OY - PY) * (OY - PY)} Y変:{(OX - PX) * (OX - PX) + (OY - PY_) * (OY - PY_)} XY変:{(OX - PX_) * (OX - PX_) + (OY - PY_) * (OY - PY_)}");
                //↓？
                if ((OX - PX) * (OX - PX) + (OY - PY) * (OY - PY) <= L * L)//新しい点が円の中にあるか
                {
                    Console.WriteLine("そのまま");
                    PointX_ = (int)Math.Round(PX, MidpointRounding.AwayFromZero);
                    PointY_ = (int)Math.Round(PY, MidpointRounding.AwayFromZero);
                }//↓どこにはみ出てるか不明なためそれぞれ確認
                else if ((OX - PX_) * (OX - PX_) + (OY - PY) * (OY - PY) <= L * L)
                {
                    Console.WriteLine("Xを変えればおｋ");
                    PointX_ = (int)Math.Round(PX_, MidpointRounding.AwayFromZero);
                    PointY_ = (int)Math.Round(PY, MidpointRounding.AwayFromZero);
                }
                else if ((OX - PX) * (OX - PX) + (OY - PY_) * (OY - PY_) <= L * L)
                {
                    Console.WriteLine("Yを変えればおｋ");
                    PointX_ = (int)Math.Round(PX, MidpointRounding.AwayFromZero);
                    PointY_ = (int)Math.Round(PY_, MidpointRounding.AwayFromZero);
                }
                else if ((OX - PX_) * (OX - PX_) + (OY - PY_) * (OY - PY_) <= L * L)
                {
                    Console.WriteLine("X,Yを変えればおｋ");
                    PointX_ = (int)Math.Round(PX_, MidpointRounding.AwayFromZero);
                    PointY_ = (int)Math.Round(PY_, MidpointRounding.AwayFromZero);
                }
                else
                    throw new Exception("計算ミスまたは計算に問題があります。");
                Console.WriteLine($"X:{PointX_} Y:{PointY_}");
                Points.Add(new Point(PointX_ + 100, PointY_ + 100));
            }
            Points.Add(new Point(100, 100));
            */
            g.Clear(Color.White);
            g.DrawPolygon(Pens.Black, Points_StarRegularPolygon.ToArray());
            return Img;
        }

        private void Wiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ja.wikipedia.org/wiki/%E6%98%9F%E5%9E%8B%E6%AD%A3%E5%A4%9A%E8%A7%92%E5%BD%A2");
        }

        private void RegularStarPolygonGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
