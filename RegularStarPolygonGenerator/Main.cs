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

            int Angle = 180 * (N - 2 * M / N);

            List<Point> Points = new List<Point>
            {
                new Point(100, 100),
                new Point(Linelong + 100, 100)
            };
            double PointX_ = Linelong;
            double PointY_ = 0;

            double L = Linelong * Math.Cos(Angle / 2) / 2;//半径
            double OX = Linelong / 2;//中心座標
            double OY = OX * Math.Cos(Angle / 2);
            for (int i = 2; i < Num_N.Value; i++)
            {
                double PX = PointX_ + Linelong * Math.Sin(Angle);
                double PY = PointY_ + Linelong * Math.Cos(Angle);
                double PX_ = PointX_ - Linelong * Math.Sin(Angle);
                double PY_ = PointY_ - Linelong * Math.Cos(Angle);
                Console.WriteLine($"{PointX_} {PointY_} {L} {OX} {OY}");
                Console.WriteLine($"{PX} {PY} {PX_} {PY_}");
                Console.WriteLine($"{L * L} {(OX - PX) * (OX - PX) + (OY - PY) * (OY - PY)} {(OX - PX_) * (OX - PX_) + (OY - PY) * (OY - PY)} {(OX - PX) * (OX - PX) + (OY - PY_) * (OY - PY_)} {(OX - PX_) * (OX - PX_) + (OY - PY_) * (OY - PY_)}");


                if ((OX - PX) * (OX - PX) + (OY - PY) * (OY - PY) <= L * L)//新しい点が円の中にあるか
                    Points.Add(new Point((int)PX + 100, (int)PY + 100));//↓どこにはみ出てるか不明なためそれぞれ確認
                else if ((OX - PX_) * (OX - PX_) + (OY - PY) * (OY - PY) <= L * L)//Xを変えればおｋ
                    Points.Add(new Point((int)PX_ + 100, (int)PY + 100));
                else if ((OX - PX) * (OX - PX) + (OY - PY_) * (OY - PY_) <= L * L)//Yを変えればおｋ
                    Points.Add(new Point((int)PX + 100, (int)PY_ + 100));
                else if ((OX - PX_) * (OX - PX_) + (OY - PY_) * (OY - PY_) <= L * L)//X,Yを変えればおｋ
                    Points.Add(new Point((int)PX_ + 100, (int)PY_ + 100));
                else;
                //throw new Exception("計算ミスまたは計算に問題があります。");

                /*
                 23:01:38.9017 生成開始
100 0 -36.5076482090253 50 -36.5076482090253
199.780327442197 6.62467022031581 0.219672557802951 -6.62467022031581
1332.80837775395 24294.5433817818 4338.47789334244 23327.1388621655 3371.07337372605
                 */
            }

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
