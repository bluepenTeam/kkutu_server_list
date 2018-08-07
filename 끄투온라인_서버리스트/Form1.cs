using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 끄투온라인_서버리스트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Internet(string kkutu)
        {
            System.Diagnostics.Process.Start(kkutu);
        }
        #region 사이트
        private void kkutu_cc_Click(object sender, EventArgs e)
        {
            Internet("http://kkutu.cc");
        }

        private void kkutu_co_kr_Click(object sender, EventArgs e)
        {
            Internet("https://kkutu.co.kr");
        }

        private void 끄투_닷컴_Click(object sender, EventArgs e)
        {
            Internet("http://끄투.닷컴");
        }

        private void 끄투_닷넷_Click(object sender, EventArgs e)
        {
            Internet("http://끄투.닷넷");
        }

        private void veatyou_xyz_Click(object sender, EventArgs e)
        {
            Internet("https://veatyou.xyz");
        }

        private void prhkt_zz_am_Click(object sender, EventArgs e)
        {
            Internet("https://prjkt.zz.am");
        }
        #endregion
        #region 창이동
        private Point mousePoint;
private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                     this.Top - (mousePoint.Y - e.Y));
            }
        }
        #endregion
        #region 종료
        private void button1_Click(object sender, EventArgs e) //프로그램을 종료합니다
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
        }
        #endregion
    }
}
