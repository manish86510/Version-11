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
using VisioForge.Controls.UI.WinForms;
using VisioForge.Tools;
using VisioForge.Tools.MediaInfo;
using VisioForge.Types;
using VisioForge.Types.GPUVideoEffects;
using VisioForge.Types.VideoEffects;

namespace NCube
{
    public partial class Firstscreen : Form
    {
        ListBox filepath = new ListBox();
        List<string> s;
        ListBox multiselect = new ListBox();
        private List<int> selectedItemIndexes = new List<int>();
        private List<int> selectedItemIndexes2 = new List<int>();
        int Visibility = 2;
        public object DriveList { get; private set; }
        List<string> pathcheck = new List<string>();
        MediaInfoReader MediaInfo = new MediaInfoReader();
        private List<PIPInfo> _pipInfos;
        int originalwidth = 0, originalheight = 0;

        string mediaplayer2path;
        string mediaplayer10path;
        string mediaplayer4path;
        string mediaplayer3path;
        string mediaplayer5path;
        string mediaplayer6path;
        string mediaplayer7path;
        string mediaplayer8path;
        string mediaplayer9path;
        string mediaplayer11path;
        string mediaplayer12path;
        string mediaplayer13path;
        string mediaplayer14path;
        string mediaplayer15path;
        string mediaplayer16path;
        string mediaplayer17path;
        string mediaplayer18path;
        string mediaplayer19path;

        int _lastZOrder = 8;
        int file1width = 0, file2height = 0;

        public Firstscreen()
        {
            InitializeComponent();

            _pipInfos = new List<PIPInfo>();
            Player1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            Player1.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer1.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer2.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer2.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer10.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer10.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer11.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer11.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer3.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer3.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer4.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer4.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer5.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer5.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer6.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer6.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer7.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer7.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer8.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer8.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer9.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer9.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer12.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer12.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer13.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer13.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer14.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer14.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer15.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer15.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer16.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer16.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer17.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer17.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer18.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer18.Source_Mode = VFMediaPlayerSource.LAV;

            mediaPlayer19.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer19.Source_Mode = VFMediaPlayerSource.LAV;

            Player1.Video_Sample_Grabber_UseForVideoEffects = true;
            Player1.Video_Effects_Enabled = true;
            Player1.Loop = true;
        }

        int t1 = 45;
        private void flatButton4_Click_1(object sender, EventArgs e)
        {
            if (t1 > 90)
            {
                t1 = 23;
                this.panel18.Size = new Size(this.panel18.Size.Width, t1);
                timer1.Stop();
            }
        }

        private void flatButton4_leave(object sender, EventArgs e)
        {
        }

        private void flatButton4_hover(object sender, EventArgs e)
        {
            this.panel18.Size = new Size(this.panel18.Size.Width, t1);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1 > 140)
            {
                timer1.Stop();
            }
            else
            {
                this.panel18.Size = new Size(this.panel18.Size.Width, t1);
                t1 += 5;
            }
        }

        int t2 = 45;
        private void flatButton3_Click(object sender, EventArgs e)
        {

            if (t2 > 90)
            {
                t2 = 23;
                this.panel1.Size = new Size(this.panel1.Size.Width, t2);
                timer2.Stop();
            }
        }

        private void flatButton3_leave(object sender, EventArgs e)
        {

        }

        private void flatButton3_hover(object sender, EventArgs e)
        {
            this.panel1.Size = new Size(this.panel1.Size.Width, t2);
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t2 > 140)
            {
                timer2.Stop();
            }
            else
            {
                this.panel1.Size = new Size(this.panel1.Size.Width, t2);
                t2 += 5;
            }
        }

        int t3 = 45;
        private void flatButton2_Click_1(object sender, EventArgs e)
        {
            if (t3 > 90)
            {
                t3 = 23;
                this.panel8.Size = new Size(this.panel8.Size.Width, t3);
                timer3.Stop();
            }
        }

        private void flatButton2_leave(object sender, EventArgs e)
        {
        }

        private void flatButton2_hover(object sender, EventArgs e)
        {
            this.panel8.Size = new Size(this.panel8.Size.Width, t3);
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (t3 > 140)
            {
                timer3.Stop();
            }
            else
            {
                this.panel8.Size = new Size(this.panel8.Size.Width, t3);
                t3 += 5;
            }
        }

        int t4 = 45;
        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (t4 > 90)
            {
                t4 = 23;
                this.panel9.Size = new Size(this.panel9.Size.Width, t4);
                timer4.Stop();
            }
        }

        private void panel9_leave(object sender, EventArgs e)
        {
            
        }

        private void flatButton1_leave(object sender, EventArgs e)
        {
           
        }

        private void flatButton1_hover(object sender, EventArgs e)
        {
            this.panel9.Size = new Size(this.panel9.Size.Width, t4);
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (t4 > 165)
            {
                timer4.Stop();
               // t4 = 45;
            }
            else
            {
                this.panel9.Size = new Size(this.panel9.Size.Width, t4);
                t4 += 5;
            } 
        }

        private void Firstscreen_Click(object sender, EventArgs e)
        {
            if (t4 > 90)
            {
                t4 = 23;
                this.panel9.Size = new Size(this.panel9.Size.Width, t4);
                timer4.Stop();
            }

            if (t3 > 90)
            {
                t3 = 23;
                this.panel8.Size = new Size(this.panel8.Size.Width, t3);
                timer3.Stop();
            }

            if (t2 > 90)
            {
                t2 = 23;
                this.panel1.Size = new Size(this.panel1.Size.Width, t2);
                timer2.Stop();
            }

            if (t1 > 90)
            {
                t1 = 23;
                this.panel18.Size = new Size(this.panel18.Size.Width, t1);
                timer1.Stop();
            }
        }

        private void ScreenSelect()
        {
            s = new List<string>();
            foreach (var screen in Screen.AllScreens)
            {
                s.Add("Device Name: " + screen.DeviceName);
                s.Add("Bounds: " + screen.Bounds.ToString());
                s.Add("Type: " + screen.GetType().ToString());
                s.Add("Working Area: " + screen.WorkingArea.ToString());
                s.Add("Primary Screen: " + screen.Primary.ToString());
                // SetWindowPos(proceso.MainWindowHandle, 0, monitor.Left, monitor.Top, monitor.Width, monitor.Height, 0);
            }
        }


        public bool SetScreenToFirstNonPrimary(Form self)
        {
            // Retrieves the collection of available screens (monitors)
            var aScreens = Screen.AllScreens;
            // If count is not greater than 1 then exit
            if (aScreens.Length <= 1)
                return false; // screen kept original

            // Saves current screen reference
            var screenOld = Screen.FromControl(self);
            foreach (var screen in aScreens)
            {
                // Skips primary and current screen
                if (screen.Primary || screen.Equals(screenOld))
                    continue;
                var boundsScreen = screen.Bounds;
                var oldState = self.WindowState;
                // If form is currently maximized ...
                if (oldState == FormWindowState.Maximized)
                {
                    self.WindowState = FormWindowState.Normal;
                    self.StartPosition = FormStartPosition.Manual;
                    self.Location = boundsScreen.Location;
                    self.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    self.StartPosition = FormStartPosition.Manual;
                    // Center into new screen
                    var sizeGaps = boundsScreen.Size - self.Size;
                    var x = boundsScreen.Left + (sizeGaps.Width / 2);
                    var y = boundsScreen.Top + (sizeGaps.Height / 2);
                    self.Location = new System.Drawing.Point(x, y);
                }

                return true; // screen has been changed
            }
            return true; // screen kept original
        }

        private void tbLightness_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectLightness lightness;
            var effect = mediaPlayer1.Video_Effects_Get("Lightness");
            if (effect == null)
            {
                lightness = new VFVideoEffectLightness(true, tbLightness.Value);
                Player1.Video_Effects_Add(lightness);
            }
            else
            {
                lightness = effect as IVFVideoEffectLightness;
                if (lightness != null)
                {
                    lightness.Value = tbLightness.Value;
                }
            }
        }

        private void tbsaturation_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectSaturation saturation;
            var effect = mediaPlayer1.Video_Effects_Get("Saturation");
            if (effect == null)
            {
                saturation = new VFVideoEffectSaturation(tbsaturation.Value);
                Player1.Video_Effects_Add(saturation);
            }
            else
            {
                saturation = effect as IVFVideoEffectSaturation;
                if (saturation != null)
                {
                    saturation.Value = tbsaturation.Value;
                }
            }

        }

        private void tbContrast_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectContrast contrast;
            var effect = mediaPlayer1.Video_Effects_Get("Contrast");
            if (effect == null)
            {
                contrast = new VFVideoEffectContrast(true, tbContrast.Value);
                Player1.Video_Effects_Add(contrast);
            }
            else
            {
                contrast = effect as IVFVideoEffectContrast;
                if (contrast != null)
                {
                    contrast.Value = tbContrast.Value;
                }
            }
        }

        private void tbdarkness_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectDarkness darkness;
            var effect = mediaPlayer1.Video_Effects_Get("Darkness");

            if (effect == null)
            {
                darkness = new VFVideoEffectDarkness(true, tbdarkness.Value);
                Player1.Video_Effects_Add(darkness);

            }
            else
            {

                darkness = effect as IVFVideoEffectDarkness;
                if (darkness != null)
                {
                    darkness.Value = tbdarkness.Value/10;
                }
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Firstscreen_Load(object sender, EventArgs e)
        {
            var node = new TreeNode();
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                node = treeView1.Nodes.Add(di.Name);
                node.Tag = di;
                node.ImageIndex = 0;
                node.SelectedImageIndex = 1;
            }





        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            LoadDirectory(e, path);
        }

        public bool checkPath(List<string> vs, string path)
        {
            bool val = false;
            foreach (string s in vs)
            {
                if (s == path)
                {
                    val = true;
                    break;
                }
            }
            return val;
        }
        public void LoadDirectory(TreeViewEventArgs tree, string path)
        {

            TreeNode tds = new TreeNode();
            DirectoryInfo di = new DirectoryInfo(path);
            tds = tree.Node;
            tds.Tag = di.FullName;
            tds.ImageIndex = 0;
            tds.SelectedImageIndex = 1;

            listView1.Items.Clear();
            bool value = checkPath(pathcheck, path);
            if (!value)
            {
                pathcheck.Add(path);
                LoadFiles((string)tree.Node.Tag, tds);
                LoadSubDirectories((string)tree.Node.Tag, tds);
            }
            else
            {
                LoadFiles((string)tree.Node.Tag, tds);
            }
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.ImageIndex = 0;
                tds.SelectedImageIndex = 1;
                tds.Tag = di.FullName;
                // LoadFiles(subdirectory, tds);
                // LoadSubDirectories(subdirectory, tds);
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");
            //ImageList imageList = new ImageList();
            //Image image = Properties.Resources.black;

            //imageList.Images.Add(image);
            //listView1.LargeImageList = imageList;
            //listView1.View = View.Tile;
            //TreeNode tds = td.Nodes.Add(fi.Name);
            //tds.Tag = fi.FullName;
            //tds.StateImageIndex = 0;
            listView1.Items.Clear();
            filepath.Items.Clear();
            listView1.View = View.List;

            foreach (string file in Files)
            {

                FileInfo fi = new FileInfo(file);
                listView1.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                filepath.Items.Add(fi.FullName);
            }

        }






        private void button2_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.));
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button78_Click(object sender, EventArgs e)
        {

        }

        private void button77_Click(object sender, EventArgs e)
        {

        }

        private void button76_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofb = new OpenFileDialog();
            ofb.Multiselect = true;
            if (ofb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               // this.textBoxlocation.Text = ofb.FileName;
            }
        }


        private void btnstopplyer_Click(object sender, EventArgs e)
        {
            // player1.URL = textBoxlocation.Text;
            mediaPlayer10.Stop();
        }

        private void btnpauseplyer_Click(object sender, EventArgs e)
        {
            // player1.URL = textBoxlocation.Text;
            mediaPlayer10.Pause();
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            myfile();
        }

        private void myfile()
        {

            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2.BackgroundImage = Properties.Resources.SETTINGB;
            //button5.BackgroundImage = Properties.Resources.SETTINGG;
            //button4.BackgroundImage = Properties.Resources.SHORTCUT;
            //button1.BackgroundImage = Properties.Resources.WINDOW;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //    button5.BackgroundImage = Properties.Resources.OUTPUTB;
            //    button2.BackgroundImage = Properties.Resources.SETTINGG;
            //    button4.BackgroundImage = Properties.Resources.SHORTCUT;
            //    button1.BackgroundImage = Properties.Resources.WINDOW;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //    button4.BackgroundImage = Properties.Resources.SHORTCUTB;
            //    button2.BackgroundImage = Properties.Resources.SETTINGG;
            //    button5.BackgroundImage = Properties.Resources.OUTPUT;
            //    button1.BackgroundImage = Properties.Resources.WINDOW;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button4.BackgroundImage = Properties.Resources.SHORTCUT;
            //button2.BackgroundImage = Properties.Resources.SETTINGG;
            //button5.BackgroundImage = Properties.Resources.OUTPUT;
            //button1.BackgroundImage = Properties.Resources.WINDOWB;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void player1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((Visibility % 2) == 0)
            {
                compositionpanel.Visible = true;
            }
            else
            {
                compositionpanel.Visible = false;
            }

            ++Visibility;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void textBoxlocation_TextChanged(object sender, EventArgs e)
        {

        }







        private void axWindowsMediaPlayer17_Enter(object sender, EventArgs e)
        {

        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fixtureAditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer8_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer7_Enter(object sender, EventArgs e)
        {

        }


        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {


            if (listView1.SelectedItems.Count > 1)
            {

                listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.All);

            }
            else if (listView1.SelectedItems.Count == 1)
            {

                int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);

                listView1.DoDragDrop(filepath.Items[index].ToString(), DragDropEffects.All);


            }

        }


        private void AddFile(string filename1,string filename2)
        {
            var info = new PIPInfo();
            Player1.FilenamesOrURL.Clear();
            Player1.PIP_Sources_Clear();
            // first file should be added as usual, other files using PIP API
          
                Player1.FilenamesOrURL.Add(filename1);
                info.Rect = new Rectangle(0, 0, 0, 0);
                info.Alpha = 1.0f;
                info.Filename = filename1;
                info.ZOrder = _lastZOrder--;

                _pipInfos.Add(info);
          
                MediaInfo.Filename = filename2;
                MediaInfo.ReadFileInfo(true);

                file1width = Convert.ToInt32(MediaInfo.Video_Width(0));
                file2height = Convert.ToInt32(MediaInfo.Video_Height(0));

                Player1.PIP_Sources_Add(filename2, 0, 0, file1width, file2height);
                info.Rect = new Rectangle(0, 0, file1width, file2height);

                info.Alpha = TBtransparency.Value / 100.0f;
                info.Filename = filename2;
                info.ZOrder = _lastZOrder--;

                _pipInfos.Add(info);

            Player1.Play();

        }

        private void MediaInfoInitilize(string path)
        {
            MediaInfo.Filename = path;
            MediaInfo.ReadFileInfo(true);
            textBox1.Text = MediaInfo.Video_Height(0).ToString();
            textBox4.Text = MediaInfo.Video_Width(0).ToString();
            originalheight = Convert.ToInt32(MediaInfo.Video_Height(0));
            originalwidth = Convert.ToInt32(MediaInfo.Video_Width(0));
            MediaInfo.Filename.Remove(0);

        }

        private void MediaPlayerURL1()
        {

            List<MediaPlayer> collection = mediaplayercollection1();

            foreach (int i in selectedItemIndexes2)
            {
                foreach (MediaPlayer player in collection)
                {
                    if (player.FilenamesOrURL.Count == 0)
                    {
                        player.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
                        string path = filepath.Items[i].ToString();
                        player.FilenamesOrURL.Add(path);
                        player.Play();
                       
                        switch (player.Name)
                        {
                            case "mediaPlayer12":
                                button68.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer12path = path;
                                break;
                            case "mediaPlayer13":
                                button69.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer13path = path;
                                break;
                            case "mediaPlayer14":
                                button67.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer14path = path;
                                break;
                            case "mediaPlayer15":
                                button66.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer15path = path;
                                break;
                            case "mediaPlayer16":
                                button65.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer16path = path;
                                break;
                            case "mediaPlayer17":
                                button64.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer17path = path;
                                break;
                            case "mediaPlayer18":
                                button63.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer18path = path;
                                break;
                            case "mediaPlayer19":
                                button62.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer19path = path;
                                break;

                        }
                     
                        collection.Remove(player);
                        break;
                    }
                }
            }

        }

        private List<MediaPlayer> mediaplayercollection1()
        {

            List<MediaPlayer> append = new List<MediaPlayer>();



            append.Add(mediaPlayer12);
            append.Add(mediaPlayer13);
            append.Add(mediaPlayer14);
            append.Add(mediaPlayer15);
            append.Add(mediaPlayer16);
            append.Add(mediaPlayer17);
            append.Add(mediaPlayer18);
            append.Add(mediaPlayer19);


            return append;

        }

        private void mediaPlayer11_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer11path);
            MediaInfoInitilize(mediaplayer11path);
             Player1.Play();
        }

        private void mediaPlayer11_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if(e.StartTime >1200000)
            {
               // mediaPlayer11.Pause();
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer11path);
            mediaPlayer1.Play();


        }

        private void mediaPlayer12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer12_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer12.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer12.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {

                mediaplayer12path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer12.FilenamesOrURL.Add(mediaplayer12path);
                mediaPlayer12.Play();
                button68.Text = Path.GetFileNameWithoutExtension(mediaplayer12path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }
        }

        private void mediaPlayer12_Click(object sender, EventArgs e)
        {
            
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer12path);
            MediaInfoInitilize(mediaplayer12path);
            Player1.Play();

            mediaPlayer11.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            mediaPlayer11.Source_Mode = VFMediaPlayerSource.LAV;
            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer12path);
            mediaplayer11path = mediaplayer12path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer12path);
        }

        private void mediaPlayer12_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if(e.StartTime >2200000)
            {
             
            }
        }
        private void button68_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer12path);
            mediaPlayer1.Play();
        }

        private void mediaPlayer13_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer13_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer13.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer13.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer13path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer13.FilenamesOrURL.Add(mediaplayer13path);
                mediaPlayer13.Play();
                button69.Text = Path.GetFileNameWithoutExtension(mediaplayer13path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }
        }


        private void mediaPlayer13_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer13path);
            MediaInfoInitilize(mediaplayer13path);
            Player1.Play();

            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer13path);
            mediaplayer11path = mediaplayer13path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer13path);
        }

        private void mediaPlayer13_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer13.Pause();
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {

            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer13path);
            mediaPlayer1.Play();


        }
        private void mediaPlayer14_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer14_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer14.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer14.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer14path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer14.FilenamesOrURL.Add(mediaplayer14path);
                mediaPlayer14.Play();
                button67.Text = Path.GetFileNameWithoutExtension(mediaplayer14path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }

        }

        private void mediaPlayer14_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer14path);
           
            MediaInfoInitilize(mediaplayer14path);
            Player1.Play();

            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer14path);
            mediaplayer11path = mediaplayer14path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer14path);

        }

        private void mediaPlayer14_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer14.Pause();
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer14path);
            mediaPlayer1.Play();


        }

        private void mediaPlayer15_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer15_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer15.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer15.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer15path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer15.FilenamesOrURL.Add(mediaplayer15path);
                mediaPlayer15.Play();
                button66.Text = Path.GetFileNameWithoutExtension(mediaplayer15path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }

        }

        private void mediaPlayer15_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer15path);
           
            MediaInfoInitilize(mediaplayer15path);
            Player1.Play();

            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer15path);
            mediaplayer11path = mediaplayer15path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer15path);
        }

        private void mediaPlayer15_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if(e.StartTime >1200000)
            {
                mediaPlayer15.Pause();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer15path);
            mediaPlayer1.Play();

        }

        private void mediaPlayer16_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer16_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer16.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer16.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer16path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer16.FilenamesOrURL.Add(mediaplayer16path);
                mediaPlayer16.Play();
                button65.Text = Path.GetFileNameWithoutExtension(mediaplayer16path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }
        }
        private void mediaPlayer16_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer16path);
          
            MediaInfoInitilize(mediaplayer16path);
            Player1.Play();

            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer16path);
            mediaplayer11path = mediaplayer16path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer16path);
        }

       

        private void mediaPlayer16_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 1200000)
            {
                mediaPlayer16.Pause();
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer16path);
            mediaPlayer1.Play();

        }

        private void mediaPlayer17_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer17_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer17.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer17.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer17path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer17.FilenamesOrURL.Add(mediaplayer17path);
                mediaPlayer17.Play();
                button64.Text = Path.GetFileNameWithoutExtension(mediaplayer17path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }
        }
        private void mediaPlayer17_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer17path);
           
            MediaInfoInitilize(mediaplayer17path);
            Player1.Play();

            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer17path);
            mediaplayer11path = mediaplayer17path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer17path);
        }

   

        private void mediaPlayer17_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 1200000)
            {
                mediaPlayer17.Pause();
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer17path);
            mediaPlayer1.Play();


        }

        private void mediaPlayer18_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer18_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer18.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer18.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer18path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer18.FilenamesOrURL.Add(mediaplayer18path);
                mediaPlayer18.Play();
                button63.Text = Path.GetFileNameWithoutExtension(mediaplayer18path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }
        }

        private void mediaPlayer18_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer18path);
            
            MediaInfoInitilize(mediaplayer18path);
            Player1.Play();


            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer18path);
            mediaplayer11path = mediaplayer18path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer18path);
        }

       

        private void mediaPlayer18_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 1200000)
            {
                mediaPlayer18.Pause();
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer18path);
            mediaPlayer1.Play();


        }

        private void mediaPlayer19_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer19_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer19.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer19.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer19path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer19.FilenamesOrURL.Add(mediaplayer19path);
                mediaPlayer19.Play();
                button62.Text = Path.GetFileNameWithoutExtension(mediaplayer19path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes2.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL1();
            }
        }
        private void mediaPlayer19_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer19path);
        
            MediaInfoInitilize(mediaplayer19path);
            Player1.Play();


            mediaPlayer11.Stop();
            mediaPlayer11.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer11.FilenamesOrURL.Add(mediaplayer19path);
            mediaplayer11path = mediaplayer19path;
            mediaPlayer11.Play();
            button70.Text = Path.GetFileNameWithoutExtension(mediaplayer19path);
        }

        

        private void mediaPlayer19_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 1200000)
            {
                mediaPlayer19.Pause();
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer1.Loop = true;

            mediaPlayer1.Stop();
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer19path);
            mediaPlayer1.Play();


        }

       




       

        private void button1_Click_1(object sender, EventArgs e)
        {

            //  Point btnPosition = PointToScreen(this.button1.Location);

            //  Point startPoint = new Point(btnPosition.X, btnPosition.Y + 4 + this.button1.Height);

            //  this.contextMenuStrip1.Show(startPoint);
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofb = new OpenFileDialog();
            ofb.Multiselect = true;
            if (ofb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mediaPlayer10.FilenamesOrURL.Add(ofb.FileName);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();

            string extension = Path.GetExtension(mediaPlayer10.FilenamesOrURL.ToString());


            if (f.ShowDialog() == DialogResult.OK)
            {
                f.FileName += extension;
                File.Copy(mediaPlayer10.FilenamesOrURL.ToString(), f.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "mp4|*.mp4|mov|*.mov|avi|*.avi";


            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Copy(mediaPlayer10.FilenamesOrURL.ToString(), f.FileName);
            }
        }


        private void mediaPlayer2_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.All;
        }


        private void mediaPlayer2_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer2.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer2.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer2path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer2.FilenamesOrURL.Add(mediaplayer2path);
                mediaPlayer2.Play();
                button50.Text = Path.GetFileNameWithoutExtension(mediaplayer2path);

            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }
        }


        private void button50_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer2path);
            mediaPlayer1.Play();

        }
        private void mediaPlayer2_Click(object sender, EventArgs e)
        {
            mediaplayer10path = mediaplayer2path;
            if (mediaplayer11path.ToString() != string.Empty && mediaplayer10path.ToString() != string.Empty)
            {
                Player1.Stop();
                AddFile(mediaplayer11path, mediaplayer10path);
                mediaPlayer10.Stop();
                mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

                mediaPlayer10.FilenamesOrURL.Add(mediaplayer2path);
                mediaplayer10path = mediaplayer2path;
                mediaPlayer10.Play();
                button47.Text = Path.GetFileNameWithoutExtension(mediaplayer2path);
            }

            else
            {
                Player1.Stop();
                Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
                Player1.FilenamesOrURL.Clear();
                Player1.FilenamesOrURL.Add(mediaplayer2path);
                MediaInfoInitilize(mediaplayer2path);
                Player1.Play();
                mediaPlayer10.Stop();
                mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

                mediaPlayer10.FilenamesOrURL.Add(mediaplayer2path);
                mediaplayer10path = mediaplayer2path;
                mediaPlayer10.Play();
                button47.Text = Path.GetFileNameWithoutExtension(mediaplayer2path);
            }

          
        }

        private void mediaPlayer2_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 1200000)
            {
                mediaPlayer2.Pause();
            }
        }

        private void mediaPlayer10_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
               // mediaPlayer10.Pause();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer10path);
            mediaPlayer1.Play();

        }
        private void mediaPlayer10_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer10path);
           
            MediaInfoInitilize(mediaplayer10path);
            Player1.Play();
        }

        private void mediaPlayer3_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer3_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer3.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer3.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer3path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer3.FilenamesOrURL.Add(mediaplayer3path);
                button49.Text = Path.GetFileNameWithoutExtension(mediaplayer3path);
                mediaPlayer3.Play();


            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }


        }


        private void mediaPlayer3_Click(object sender, EventArgs e)
        {
           
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();

            Player1.FilenamesOrURL.Add(mediaplayer3path);
            MediaInfoInitilize(mediaplayer12path);
            Player1.Play();
            mediaPlayer10.Stop();
            mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer10.FilenamesOrURL.Add(mediaplayer3path);
            mediaplayer10path = mediaplayer3path;
            mediaPlayer10.Play();
            button47.Text = Path.GetFileNameWithoutExtension(mediaplayer3path);
        }
        private void mediaPlayer3_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer3.Pause();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer3path);
            mediaPlayer1.Play();
        }

        private void mediaPlayer4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer4_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer4.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer4.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer4path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer4.FilenamesOrURL.Add(mediaplayer4path);
                button48.Text = Path.GetFileNameWithoutExtension(mediaplayer4path);
                mediaPlayer4.Play();


            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }

        }

        private void mediaPlayer4_Click(object sender, EventArgs e)
        {
          
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer4path);
           
            MediaInfoInitilize(mediaplayer4path);
            Player1.Play();
          
            
            mediaPlayer10.Stop();
            mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer10.FilenamesOrURL.Add(mediaplayer4path);
            mediaplayer10path = mediaplayer4path;
            mediaPlayer10.Play();
            button47.Text = Path.GetFileNameWithoutExtension(mediaplayer4path);
        }

        private void mediaPlayer4_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer4.Pause();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer4path);
            mediaPlayer1.Play();
        }

        private void mediaPlayer5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer5_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer5.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer5.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer5path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer5.FilenamesOrURL.Add(mediaplayer5path);
                button51.Text = Path.GetFileNameWithoutExtension(mediaplayer5path);
                mediaPlayer5.Play();


            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }
        }

        private void mediaPlayer5_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
           
            MediaInfoInitilize(mediaplayer5path);
            Player1.Play();
            mediaPlayer10.Stop();
            mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer10.FilenamesOrURL.Add(mediaplayer5path);
            mediaplayer10path = mediaplayer5path;
            mediaPlayer10.Play();
            button47.Text = Path.GetFileNameWithoutExtension(mediaplayer5path);
        }

        private void mediaPlayer5_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer5.Pause();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {

            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer5path);
            mediaPlayer1.Play();
        }



        private void MediaPlayerURL()
        {

            List<MediaPlayer> collection = mediaplayercollection();

            foreach (int i in selectedItemIndexes)
            {
                foreach (MediaPlayer player in collection)
                {
                    if (player.FilenamesOrURL.Count == 0)
                    {
                        player.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
                        string path = filepath.Items[i].ToString();
                        player.FilenamesOrURL.Add(path);
                        player.Play();
                        switch (player.Name)
                        {
                            case "mediaPlayer2":
                                button50.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer2path = path;
                                break;
                            case  "mediaPlayer3":
                                button49.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer3path = path;
                                break;
                            case "mediaPlayer4":
                                button48.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer4path = path;
                                break;
                            case "mediaPlayer5":
                                button51.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer5path = path;
                                break;
                            case "mediaPlayer6":
                                button52.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer6path = path;
                                break;
                            case "mediaPlayer7":
                                button53.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer7path = path;
                                break;
                            case "mediaPlayer8":
                                button54.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer8path = path;
                                break;
                            case "mediaPlayer9":
                                button55.Text = Path.GetFileNameWithoutExtension(path);
                                mediaplayer9path = path;
                                break;

                        }
                        
                        collection.Remove(player);
                        break;
                    }
                }
            }

        }


        private List<MediaPlayer> mediaplayercollection()
        {

            List<MediaPlayer> append = new List<MediaPlayer>();



            append.Add(mediaPlayer3);
            append.Add(mediaPlayer4);
            append.Add(mediaPlayer2);
            append.Add(mediaPlayer5);
            append.Add(mediaPlayer6);
            append.Add(mediaPlayer7);
            append.Add(mediaPlayer8);
            append.Add(mediaPlayer9);


            return append;

        }
      

      



        private void mediaPlayer6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        private void mediaPlayer6_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer6.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer6.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer6path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer6.FilenamesOrURL.Add(mediaplayer6path);
                button52.Text = Path.GetFileNameWithoutExtension(mediaplayer6path);
                mediaPlayer6.Play();


            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }
        }


        private void mediaPlayer6_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer6path);

            MediaInfoInitilize(mediaplayer6path);
            Player1.Play();
            mediaPlayer10.Stop();
            mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer10.FilenamesOrURL.Add(mediaplayer6path);
            mediaplayer10path = mediaplayer6path;
            mediaPlayer10.Play();
            button47.Text = Path.GetFileNameWithoutExtension(mediaplayer6path);

        }

        private void mediaPlayer6_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer6.Pause();
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {

            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer6path);
            mediaPlayer1.Play();
        }

        private void mediaPlayer7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer7_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer7.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer7.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer7path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer7.FilenamesOrURL.Add(mediaplayer7path);
                button53.Text = Path.GetFileNameWithoutExtension(mediaplayer7path);
                mediaPlayer7.Play();


            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }
        }

        private void mediaPlayer7_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer7path);
           
            MediaInfoInitilize(mediaplayer7path);
            Player1.Play();
            mediaPlayer10.Stop();
            mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer10.FilenamesOrURL.Add(mediaplayer7path);
            mediaplayer10path = mediaplayer7path;
            mediaPlayer10.Play();
            button47.Text = Path.GetFileNameWithoutExtension(mediaplayer7path);

        }

        private void mediaPlayer7_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer7.Pause();
            }

        }

        private void button53_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer7path);
            mediaPlayer1.Play();
        }


        private void mediaPlayer8_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mediaPlayer8_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer8.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer8.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer8path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer8.FilenamesOrURL.Add(mediaplayer8path);
                button54.Text = Path.GetFileNameWithoutExtension(mediaplayer8path);
                mediaPlayer8.Play();


            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }

        }

        private void mediaPlayer8_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer8path);
           
            MediaInfoInitilize(mediaplayer8path);
            Player1.Play();

            mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer10.FilenamesOrURL.Add(mediaplayer8path);
            mediaplayer10path = mediaplayer8path;
            mediaPlayer10.Play();
            button47.Text = Path.GetFileNameWithoutExtension(mediaplayer8path);

        }

        private void mediaPlayer8_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer8.Pause();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer8path);
            mediaPlayer1.Play();
        }

        private void mediaPlayer9_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.All;
        }


        private void mediaPlayer9_DragDrop(object sender, DragEventArgs e)
        {
            mediaPlayer9.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer9.FilenamesOrURL.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                mediaplayer9path = (string)e.Data.GetData(DataFormats.StringFormat);
                mediaPlayer9.FilenamesOrURL.Add(mediaplayer9path);
                button55.Text = Path.GetFileNameWithoutExtension(mediaplayer9path);
                mediaPlayer9.Play();


            }

            else
            {
                foreach (ListViewItem o in listView1.SelectedItems)
                    selectedItemIndexes.Add(listView1.Items.IndexOf(o));
                MediaPlayerURL();
            }
        }


        private void mediaPlayer9_Click(object sender, EventArgs e)
        {
            Player1.Stop();
            Player1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            Player1.FilenamesOrURL.Clear();
            Player1.FilenamesOrURL.Add(mediaplayer9path);
          

            MediaInfoInitilize(mediaplayer9path);
            Player1.Play();
            mediaPlayer10.Stop();
            mediaPlayer10.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");

            mediaPlayer10.FilenamesOrURL.Add(mediaplayer9path);
            mediaplayer10path = mediaplayer9path;
            mediaPlayer10.Play();
            button47.Text = Path.GetFileNameWithoutExtension(mediaplayer9path);
        }

        private void mediaPlayer9_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.StartTime > 2200000)
            {
                mediaPlayer9.Pause();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {

            mediaPlayer1.Stop();
            mediaPlayer1.SetLicenseKey("1DCD-6E16-691F-ACDC-6E9E-AF7C", "Ankur Kumar", "thatsankurteotia@gmail.com");
            mediaPlayer1.FilenamesOrURL.Clear();
            mediaPlayer1.FilenamesOrURL.Add(mediaplayer9path);
            mediaPlayer1.Play();
        }



        private void axWindowsMediaPlayer5_Enter(object sender, EventArgs e)
        {

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
           Player1.Pause();
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            Player1.Resume();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Player1.Stop();
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {

            Player1.SetSpeed(tbSpeed.Value / 10.0);
        }


        private void flatButton33_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatButton51_Click(object sender, EventArgs e)
        {
            compositionpanel.Hide();
        }

        private void flatButton53_Click(object sender, EventArgs e)
        {
            compositionpanel.Show();
        }

        private void flatButton59_Click(object sender, EventArgs e)
        {
            int y1 = Player1.Video_Width;
            int z1 = Player1.Video_Height;
            int a1 = (Player1.Width + Player1.Location.X) / 2;
            int b1 = (Player1.Height + Player1.Location.Y) / 2;
            int width = 0; int height = 0;
            int x = 0;
            int y = 0;
            int index = 0;
            width = Convert.ToInt32(textBox4.Text.ToString());
            height = Convert.ToInt32(textBox1.Text.ToString());

      
            if (textBox3.Text.ToString() != string.Empty && textBox2.Text.ToString() != string.Empty)
            {
                x = Convert.ToInt32(textBox3.Text.ToString());
                y = Convert.ToInt32(textBox2.Text.ToString());

                Rectangle Rect = new Rectangle(x, y, Player1.Video_Width, Player1.Video_Height);
                Player1.PIP_Sources_SetSourcePosition(index, Rect, 1.0f);
               
            }

            if (x == 0 && y == 0)
            {
                int cordinatex = (originalwidth - width) / 2;
                int cordinatey = (originalheight - height) / 2;

                if (cordinatex > 0)
                {
                    Rectangle Rect = new Rectangle(cordinatex, cordinatey, width, height);
                    Player1.PIP_Sources_SetSourcePosition(index, Rect , 1.0f);
                }
                else
                {
                    Rectangle Rect = new Rectangle(x, y, width, height);
                    Player1.PIP_Sources_SetSourcePosition(index, Rect , 1.0f);
                }
            }

        }

        private void Player1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatButton8_Click(object sender, EventArgs e)
        {

        }

        private void flatButton9_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatButton22_Click(object sender, EventArgs e)
        {

        }

        private void TBrotation_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectRotate rotate;
            var effect = Player1.Video_Effects_Get("Rotate");
            if (effect == null)
            {
                rotate = new VFVideoEffectRotate(true, TBrotation.Value, false);
                Player1.Video_Effects_Add(rotate);
            }
            else
            {
                rotate = effect as IVFVideoEffectRotate;
            }

            if (rotate == null)
            {
                MessageBox.Show("Unable to configure rotate effect.");
                return;
            }

            rotate.Enabled = true;
            rotate.Angle = TBrotation.Value;
            rotate.Stretch = false; ;
        }

        private double calculatewidth(int height, double dimension)
        {
            double value = 0.0;
            value = dimension * Convert.ToInt32(height);
            return value;
        }

        private double calculateheight(int width, double dimension)
        {
            double value = 0.0;
            value = (Convert.ToInt32(width) / dimension);
            return value;
        }

        private void compositionpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double d1 = MediaInfo.Video_AspectRatio(0);
                int height = Convert.ToInt32(textBox1.Text.ToString());
                int width = Convert.ToInt32(calculatewidth(height, d1));
                textBox4.Text = width.ToString();
            }

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Expand();
            TreeNode trNode = (TreeNode)e.Node;
            trNode.Collapse();
        }

        private void mediaPlayer4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mediaPlayer12_OnError(object sender, ErrorsEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void mediaPlayer13_OnError(object sender, ErrorsEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void mediaPlayer14_OnError(object sender, ErrorsEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void mediaPlayer11_OnError(object sender, ErrorsEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void Player1_OnError(object sender, ErrorsEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void TBtransparency_Scroll(object sender, EventArgs e)
        {
            Player1.Pause();
            Rectangle Rect = new Rectangle(0, 0, file1width, file2height);
            Player1.PIP_Sources_SetSourcePosition(1, Rect, trackBar5.Value / 100.0f);
            Player1.Resume();
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty)
            {
                double d1 = MediaInfo.Video_AspectRatio(0);
                int width = Convert.ToInt32(textBox4.Text.ToString());
                int height = Convert.ToInt32(calculateheight(width, d1));
                textBox1.Text = height.ToString();
            }
        }
    }
}