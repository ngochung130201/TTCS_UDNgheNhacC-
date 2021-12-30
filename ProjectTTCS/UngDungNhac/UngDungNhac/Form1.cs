using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UngDungNhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
           
        }

        private void bunifuShapes1_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }

        private void btnSileBar_Click(object sender, EventArgs e)
        {
           
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            //khi bam nut x thi hien len hop thoai nguoi dung nhan ok thi thoat
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
        // tao mang de luu 1 danh sach nhac
        string[] paths; // tao mang chua dia chi
        string[] files; // tao mang chua ten
   
      

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];// play file duong dan
            player.Ctlcontrols.play();// nhan vao duong dan thi phat nhat
           
            this.textBox1.Text = files[track_list.SelectedIndex];// lay ten file hien thi vao texbox1
      
            try // luon duoc thuc hien
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);// tao ra 1 duong dan vi tr
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);//lay anh
              
                pic_art.Image = Image.FromStream(new MemoryStream(bin));// them anh nhac vao khung anh co ten la art
                pic2.Image = Image.FromStream(new MemoryStream(bin));// hien ra anh co ten la pic2
            }
            catch
            {

            }
        }


        private void btn_Pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();// dung lai 
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();//phat nhat
           
        }


        private void btn_Previwe_Click(object sender, EventArgs e)
        {
            // quay lai  neu vi tri trong o track_list len hon 0 thi giam 1 khi nhan vao phim back
            if (track_list.SelectedIndex > 0|| track_list2.SelectedIndex>0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
                //list box cos ten la track_list_se ... 
               
            }
            else
                track_list.SelectedIndex = track_list.SelectedIndex;
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((player.playState == WMPLib.WMPPlayState.wmppsPlaying))
            {
               p_bar2.Maximum = (int)player.Ctlcontrols.currentItem.duration; // thoi gian max cua fille do
                p_bar2.Value = (int)player.Ctlcontrols.currentPosition;// giia tri tai vi tri cua file do
                label1.Text = player.Ctlcontrols.currentPositionString;// hien thi thoi gian bat dau
                label2.Text = player.Ctlcontrols.currentItem.durationString.ToString();// hien thi thoi gian ket thuc
               
            }
         



        }

       

        private void p_bar2_MouseDown(object sender, MouseEventArgs e)
            // vi tri se bang voi file do chia cho chieu rong
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar2.Width;
           
        }

        private void p_bar2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list2.SelectedIndex];// lay file duong dan
          


        }

        private void btnExplore_Click_1(object sender, EventArgs e)
        {
            //chuyen trang 2
            indicator.Top = btnExplore.Top + 10;
            bunifuPages1.SetPage(1);
        }

        private void btnPlaying_Click_1(object sender, EventArgs e)
        {
            indicator.Top = btnPlaying.Top + 10;
            bunifuPages1.SetPage(0);
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void btnPreviwe_Click(object sender, EventArgs e)
        {

        }

        private void btn_mv_Click(object sender, EventArgs e)
        {
            indicator.Top = btn_mv.Top + 15;
            bunifuPages1.SetPage(2);// khi bam vao thi chuyen sang page mv
        }

        private void btn_player_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play(); // phat
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop(); // dung lai
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            // track list(list nhac) nho hon so luong nhac thi list nhac tang them 1 
            if ((track_list.SelectedIndex < track_list.Items.Count - 1))
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
               
            }
            //khi o vi tri cuoi cung thi quay tro lai dau
            else
                track_list.SelectedIndex = track_list.SelectedIndex - track_list.SelectedIndex;
           
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            // quay lai 
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
            else
                track_list.SelectedIndex = track_list.SelectedIndex;
        }

        private void indicator_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void track_Volumne_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            player.settings.volume = track_Volumne.Value;// cai dat vo lumns bang gia tri
            track_Volumne.Text = track_Volumne.ToString() + "%d";// hien phan tram am luong %d la so nguyen

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mp3 files , mp4 file ( *.mp3, *.mp4)|*.mp*";
            ofd.Multiselect = true; // cho phep chon nhieu file
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)// khi nguoi dung bam vao thi 
            {
                
                paths = ofd.FileNames;//LAY DUONG DAN
                files = ofd.SafeFileNames;// lay tn
              
              
                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);//Dòng lệnh để thêm nhạc vào hiển thị vào track_líst1 bên tab Cá nhân
                    track_list2.Items.Add(files[x]); // Dòng lệnh để thêm nhạc vào hiển thị vào track_líst2 bên tab Albums

                }

            }
        }

        private void pic_art_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //phong to 
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bunifuImageButton2_DoubleClick(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Trở về kích thước ban đầu", "Thu nho",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.WindowState = FormWindowState.Normal;
            }
         
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            indicator.Top = Setting.Top + 15;
            bunifuPages1.SetPage(3);// khi bam vao thi chuyen sang page mv
        }




        // mo file 

    }
}
