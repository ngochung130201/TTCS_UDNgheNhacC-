Trường Đại Học Nha Trang
Khoa Công Nghệ Thông Tin








THỰC TẬP CƠ SỞ
VIẾT CHƯƠNG TRÌNH C# TẠO ỨNG DỤNG NGHE NHẠC TRÊN WINDOWS





Học phần : Thực tập cơ sở 
GVHD: Nguyễn Đình Hưng
SVTH: Huỳnh Ngọc Hưng
Lớp: 61.CNTT-1
MSSV: 61133707




Khóa học 2021-2022
Mục lục
I.Giới thiệu đề tài	3
1.Giới thiệu	3
2.Quá trình phát triển trên window c#	3
3.Định dạng file là gì?	3
4.Những định dạng âm thanh cơ bản phổ biến nhất hiện nay	4
3.Những chuẩn flle video	5
II.Tìm hiểu công cụ lập trình	8
III.Mô tả giải thuật và cài đặt thuận  toán	9
1.Xây dựng chương trình	9
2.Chương trình gồm các  tab	10
3.Các button trên Ứng dụng	13
IV.Mã nguồn	15


 
I.Giới thiệu đề tài
1.Giới thiệu
Trong bài toán này đây là dạng ứng dụng và tôi sẽ sử dụng windowform 
-Ứng dụng nghe nhạc được viết bằng c# .Ý tưởng lấy từ chương trình nghe nhạc windowns Media Player Trên hệ điều hành Windowns sử dụng bunifuframework Để thiết kế GUI, WMPLib
2.Quá trình phát triển trên window c#
Ngôn ngữ lập trình C# chính là ngôn ngữ được nâng cấp lên từ C++ và Java và là một ngôn ngữ lập trình hướng đối tượng, ngôn ngữ C# cũng là một trong những ngôn ngữ sử dụng phổ biến hiện nay được sử dụng trên nền .Net với nhiều tính năng giúp cho việc lập trình trở lên dễ dàng hơn
.NET Framework
–Microsoft .NET Framework là môi trường chung cho việc xây dựng, triển khai và chạy các ứng dụng 
• Không gắn chặt vào hệ điều hành 
• Không gắn chặt vào ngôn ngữ 
• Nhiều tiện ích khác giúp cho việc phát triển các ứng dụng nhanh, hiệu quả hơn.
• .NET My Services  
– .NET My Services là một tập XML Web Service cho phép user truy cập thông tin qua Internet. Dùng các .NET My Service các ứng dụng có thể truyền thông trực tiếp bằng giao thức SOAP và XML
-Các chức năng cơ bản 
+ Phát nhạc và video(mp3,mp4)
+Tìm kiếm nhạc
+ Chuyển đổi qua lại giữa các bài hát và video
3.Định dạng file là gì?
Định dạng file hay định dạng tập tin là cách thông tin được mã hóa và lưu trữ. Nó chỉ định cách các bit được sử dụng để mã hóa thông tin trong một phương tiện lưu trữ kỹ thuật số.




4.Những định dạng âm thanh cơ bản phổ biến nhất hiện nay
+MP3








File MP3 MP3 là cụm từ viết tắt của MPEG-1 audio Player 3 hay Motion Pictures Expert Group 1 Layer 3.
Đây là định dạng âm thanh được tạo ra qua quá trình cắt bỏ bớt dãy âm quá thấp và quá cao khi nén âm thanh. MP3 là file âm thanh phổ biến nhất hiện nay, có đặc điểm là rất nhẹ, dễ dàng tải về và chia sẻ, nhưng nhược điểm là chất lượng âm thanh sẽ bị giảm nhiều so với bản gốc ở phòng thu.
MP3 là phương pháp nén và mở rộng tệp sử dụng tiêu chuẩn MPEG để giảm kích thước, thường là hệ số 12, trong khi vẫn duy trì chất lượng âm thanh tương đương với đĩa CD
Trong khi định dạng nén âm thanh thành kích thước tệp nhỏ hơn nhiều so với các định dạng cạnh tranh, nó vẫn cung cấp âm thanh chất lượng gần bằng CD (âm thanh nổi, 16-bit). Chất lượng của một tệp MP3 phụ thuộc (và vẫn còn) phần lớn vào tốc độ bit được sử dụng để nén. Tốc độ bit phổ biến là 128, 160, 192 và 256 kbps

1 +  WMA








WMA - Windows Media Audio. Định dạng này do Microsoft tạo ra để cạnh tranh cùng MP3. Với ưu điểm là dung lượng còn nhẹ hơn cả MP3 nhưng chất lượng lại tương đương nên nó cũng được yêu thích bởi khá nhiều người chơi.

+WAV









WAV - Waveform Audio File Format. Được xem là sự thay thế cho các bản gốc studio hoặc CD và được tạo ra bởi Microsoft hợp tác cùng IBM. Nhưng cũng vì thế, dung lượng của nó khá nặng và chất âm không thua âm thanh phòng thu.
3.Những chuẩn flle video 
+File AVI
AVI là tên viết tắt của Audio Video Interleave và được phát triển bởi Microsoft.
AVI là file không nén, vì vậy mà cho ra chất lượng video, âm thanh tốt, hình ảnh rõ nét hơn những file khác.
Các file AVI có phần đuôi .avi, vì là file không nén nên file AVI chiếm khá nhiều dung lượng và hạn chế thiết bị phát, không phải thiết bị nào cũng tương thích với địn dạng video này.
Định dạng AVI thường được sử dụng trên các hệ thống như Windows, macOS, Linux,...
 

+File MP4
Định dạng MP4 (viết tắt của Moving Pictures Expert Group 4) là định dạng đã quá quen thuộc với hầu hết mọi người, bởi sự tương thích cực cao, đa số trình xem video đều sử dụng được.
Các file MP4 có phần đuôi .mp4 đem đến những video chất lượng cao mà chỉ chiếm một dung lượng khá thấp. Chính vì vậy mà những kênh streaming online nổi tiếng, thậm chí cả YouTube và Vimeo, đều sử dụng định dạng này. MP4 được tạo ra bằng cách nén dữ liệu nên mặc dù mang ưu điểm nhẹ, dễ sao chép nhưng chất lượng hình ảnh sẽ kém hơn file không nén như AVI.













+File WMV
WMV là viết tắt của Windows Media Video. Định dạng file có đuôi là .mkv này được phát triển bởi Microsoft.
WMV được sử dụng để chạy trên tất cả hệ điều hành Windows, và có cả trình phát WMV miễn phí trên hệ điều hành macOS. Định dạng file này được sử dụng rộng rãi trên mạng nhờ chất lượng hình ảnh tốt, kích thước nhỏ gọn, giúp người dùng dễ dàng tải, chia sẻ qua email.
+File MKV
MKV là tên viết tắt của Matroska Video, là định dạng có thể kết hợp đa phương tiện từ âm thanh, video, và phụ đề vào trong một tập tin duy nhất. Khi bạn tải phim từ trên mạng xuống thì những file nhúng sẵn phụ đề thường có định dạng đuôi là .mkv.

File MKV có dung lượng không quá cao, dễ dàng tải về và chia sẻ, và có chất lượng âm thanh, hình ảnh khá tốt.










+File 3GP
3GP được phát triển bởi Third Generation Partnership Project. Đây là phiên bản thu gọn của chuẩn MP4 đang được sử dụng phổ biến cho đa số các dòng điện thoại hiện nay.
Định dạng 3GP được thiết kế để giảm dung lượng và băng thông video để phù hợp với các dòng điện thoại được hỗ trợ. File này sử dụng chuẩn hình ảnh MPEG-4, H2.263 và âm thanh AMR-NB, AAC-LC.
Các file 3GP có đuôi file là .3gp.
II.Tìm hiểu công cụ lập trình
Visual studio là một trong những công cụ hỗ trợ lập trình website rất nổi tiếng nhất hiện nay của Mcrosoft và chưa có một phần mềm nào có thể thay thế được nó. Visual Studio được viết bằng 2 ngôn ngữ đó chính là C# và VB+. Đây là 2 ngôn ngữ lập trình giúp người dùng có thể lập trình được hệ thống một các dễ dàng và nhanh chóng nhất thông qua Visual Studio.
Visual Studio là một phần mềm lập trình hệ thống được sản xuất trực tiếp từ Microsoft. Từ khi ra đời đến nay, Visual Studio đã có rất nhiều các phiên bản sử dụng khác nhau. Điều đó, giúp cho người dùng có thể lựa chọn được phiên bản tương thích với dòng máy của mình cũng như cấu hình sử dụng phù hợp nhất.
Bên cạnh đó, Visual Studio còn cho phép người dùng có thể tự chọn lựa giao diện chính cho máy của mình tùy thuộc vào nhu cầu sử dụng.
Một số tính năng của phần mềm Visual Studio
•	Biên tập mã
Giống như bất kỳ một IDE khác, Visual Studio gồm có một trình soạn thảo mã hỗ trợ tô sáng cú pháp và hoàn thiện mả bằng các sử dụng IntelliSense không chỉ cho các hàm, biến và các phương pháp mà còn sử dụng cho các cấu trúc ngôn ngữ như: Truy vấn hoặc vòng điều khiển.
Bên cạnh đó, các trình biên tập mã Visual Studio cũng hỗ trợ cài đặt dấu trang trong mã để có thể điều hướng một cách nhanh chóng và dễ dàng. Hỗ trợ các điều hướng như: Thu hẹp các khối mã lệnh, tìm kiếm gia tăng,…
Visual Studio còn có tính năng biên dịch nền tức là khi mã đang được viết thì phần mềm này sẽ biên dịch nó trong nền để nhằm cung cấp thông tin phản hồi về cú pháp cũng như biên dịch lỗi và được đánh dấu bằng các gạch gợn sóng màu đỏ.
•	Trình gỡ lỗi
Visual Studio có một trình gỡ lỗi có tính năng vừa lập trình gỡ lỗi cấp máy và gỡ lỗi cấp mã nguồn. Tính năng này hoạt động với cả hai mã quản lý giống như ngôn ngữ máy và có thể sử dụng để gỡ lỗi các ứng dụng được viết bằng các ngôn ngữ được hỗ trợ bởi Visual Studio.

•	Windows Forms Designer
Được sử dụng với mục đích xây dựng GUI sử dụng Windows Forms, được bố trí dùng để xây dựng các nút điều khiển bên trong hoặc cũng có thể khóa chúng vào bên cạnh mẫu. Điều khiển trình bày dữ liệu có thể được liên kết với các nguồn dữ liệu như: Cơ sở dữ liệu hoặc truy vấn.
•	WPF Designer
Tính năng này cũng giống như Windows Forms Designer có công dụng hỗ trợ kéo và thả ẩn dụ. Sử dụng tương tác giữa người và máy tính nhắm mục tiêu vào Windows Presentation Foundation.
•	Web designer/development
Visual Studio cũng có một trình soạn thảo và thiết kế website cho phép các trang web được thiết kế theo tính năng kéo và thả đối tượng. Mục đích là để hỗ trợ người dùng tạo trang web dễ dàng hơn, những yêu cầu đơn giản như thiết kế web du lịch hay các trang giới thiệu của công ty có thể sử dụng tính năng này vì nó vẫn đảm bảo cho bạn sở hữu được một website hoàn chỉnh.
– Visual Studio hỗ trợ lập trình trên nhiều ngôn ngữ như: C/C++, C#, F#, Visual Basic, HTML, CSS, JavaScript.
– Là một công cụ hỗ trợ việc Debug một cách dễ dàng và mạnh mẽ như: Break Point, xem giá trị của biến trong quá trình chạy, hỗ trợ debug từng câu lệnh.
– Giao diện Visual Studio rất dễ sử dụng đối với người mới bắt đầu lập trình.
– Visual Studio hỗ trợ phát triển các ứng dụng: desktop MFC, Windows Form, Universal App, ứng dụng mobile Windows Phone 8/8.1, Windows 10, …
– Visual Studio hỗ trợ xây dựng ứng dụng một cách chuyên nghiệp bằng các công cụ kéo thả.
– Visual Studio được đông đảo lập trình viên trên thế giới sử dụng.

III.Mô tả giải thuật và cài đặt thuận  toán
1.Xây dựng chương trình
	Để có thể vận hành và chơi 1 file media trong 1 ứng dụng .NET thì bắt buộc phải sử dụng 1 thư viện bên ngoài hoặc lời gọi hệ thống.Hiện nay có nhiều thư viện hỗ trợ cho việc này như wmm.dll, wmp.dll
	Chương trình nghe nhạc của em sử dụng thư viện wmp.dll do hệ điều hành windows hỗ trợ. Lí do em sử dụng thư viện này vì thư viện này hỗ trợ đa dạng định dạng file media cả audio và video
	Chương trình nghe nhạc sử dụng bunifuframework để thiêt kế giao diện Windows Forms đẹp hơn 
	Chương trình nghe nhạc xây dựng trên 1 namespace có tên là “UngDungNhac” bao gồm:
•	Form1:là Form giao diện chính thực hiện các chức năng của chương trình
2.Chương trình gồm các  tab 
 





o	Cá Nhân : Đây là giao diện chơi nhạc của chương trình 
o	Albums: Chứa các playlist được người dùng mở
o	MV: Chứa Video mà người dùng mở 
2.1.Mở file và định dạng file 
-  // tao mang de luu 1 danh sach nhac
        string[] paths; // tao mang chua dia chi
        string[] files; // tao mang chua ten


-Tạo ra đối tượng OpenFileDialog 
OpenFileDialog ofd = new OpenFileDialog() :Dùng để tạo ra danh sách chơi nhạc dựa trên các bài hát được chọn từ OpenFileDialog được xử lý qua đoạn code sau 

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


Vòng lặp for được dùng để duyệt qua từng file được chọn, dữ liệu được đưa lên track_list (Listview) để hiện thị trên giao diện chương trình, đồng thời cũng được nạp vào list albums track_list2

Cuối cùng là xác định playlist sẽ chơi và play nó
player.Ctlcontrols.play(); // phat
axWindowsMediaPlayer1 đối tượng có sẵn khi sử dụng thư viện wmp.dll được đổi tên thành player 
2.2.Tab Cá nhân 
 
Trong tab này sử dụng 2 Picture có tên là pic_art ,pic2 và 1 listbox có tên là track_lisk,textbox có tên là textBox1
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


2.3 Tab Albums









-Tab Albums chứa 1 Picture có tền là pictureBox4 và 1 listbox có tên track_list2
+Track_list 2được đổ ra từ hàm Open_button_Click
2.4 Tab MV 




Hình 1. Cá nhân






- Đối tượng player được hiển thị ở đây Khi người dùng chọn ở tab Albums hoặc Tab Cá nhân file media nào là file video thì sẽ được hiện ở Đây

3.Các button trên Ứng dụng 
 	Quay lại bài vừa chơi trong danh sách

 	Dừng lại bài đang chơi
 	Play 1 filde media
 	Tới bài kế tiếp bài đang chơi trong danh sách


Chức năng play:Button để làm chức năng play được đặt tên là btn_player khi người dùng click thì sẽ thực hiện đoạn code sau
  private void btn_player_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play(); // phat
        }

Chức năng tạm dừng:Button để làm chức năng tạm dùng được đặt tên là button_stop khi người dùng click thì sẽ thực hiện đoạn code sau
private void button_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop(); // dung lai
        }
Chức năng Tới bài tiếp theo :Button để làm Tới bài tiếp theo được đặt tên là button_next  khi người dùng click thì sẽ thực hiện đoạn code sau
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


 

Chức năng Quay lại:Button để làm Quay lại được đặt tên là button_back khi người dùng click thì sẽ thực hiện đoạn code sau
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

-Time file media 
 
Sử dụng 1 label có tên là label1 và 1 label có tên là  label2 và 1 slidebar có tên là 
p_bar2
o	label1 hiển thị thời gian đang phát file media
o	label2 có chức năng hiển thị file media có thời gian là bao nhiêu,
o	p_bar2 có chức năng hiển thị đoạn thời gian 
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

 
-Điều khiển âm lượng sử dụng 2 picture có tên là pictureBox2 và pictureBox3 và sliderbar có tên là track_Volumne



private void track_Volumne_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            player.settings.volume = track_Volumne.Value;// cai dat vo lumns bang gia tri
            track_Volumne.Text = track_Volumne.ToString() + "%d";// hien phan tram am luong %d la so nguyen

        }

IV.Mã nguồn
Link gihub https://github.com/ngochung130201/TTCS_UDnghenhac




