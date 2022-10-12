using RegularStarPolygonGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

//正n角形:https://www.umayadia.com/cssample/sample0201/Sample279WinFormDrawPolygon.htm#A5
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
                Message.Text = "生成中...";

                int N = (int)Num_N.Value;
                int M = (int)Num_M.Value;
                int ImgSize = (int)Num_ImgSize.Value;
                int Linelong = (int)Num_LineLong.Value;
                if (N <= M * 2)
                    throw new Exception("値が不正です。");
                if (N % M == 0)
                    Console.WriteLine($"星型正多角形ではありません。");
                Draw();






            }
            catch (OutOfMemoryException ex)
            {
                Message.Text = "メモリが不足しています。画像サイズを小さくしてください。";
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;



            }



        }
        public void Draw()
        {

            int N = (int)Num_N.Value;
            int M = (int)Num_M.Value;
            int ImgSize = (int)Num_ImgSize.Value;
            int Linelong = (int)Num_LineLong.Value;
            Bitmap Img = new Bitmap((int)Num_ImgSize.Value, (int)Num_ImgSize.Value);
            Graphics g = Graphics.FromImage(Img);

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
              



                //↓
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

            g.Clear(Color.White);
            g.DrawPolygon(Pens.Black, Points.ToArray());
            Img.Save("test.png", System.Drawing.Imaging.ImageFormat.Png);

            Img.Dispose();

        }

        private void Wiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ja.wikipedia.org/wiki/%E6%98%9F%E5%9E%8B%E6%AD%A3%E5%A4%9A%E8%A7%92%E5%BD%A2");
        }
    }
}
