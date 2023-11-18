using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
namespace _20231111
{
    
    public partial class MainForm : Form
    {
        private Bitmap convertImage; // 클래스 수준에서 변수를 선언(변환한 이미지를 저장하기 위해 클래스로 선언)
        private Mat originalImage; // 원본 이미지를 저장할 Mat 객체
        private LogInForm _loginForm; // 로그인 폼을 전역 변수로 선언
        private bool isLoggedIn = false; //로그인을 확인하는 변수 선언
      
        public MainForm()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen; //폼을 가운데로 고정시킵니다
            //this.TopMost = true; // 다른 창 위에 폼이 나타나도록 설정
            this.FormBorderStyle = FormBorderStyle.None; //폼의 경계를 없앱니다
            this.WindowState = FormWindowState.Maximized;
           



            if (!isLoggedIn)
            {
                // 사용자가 로그인하지 않았을 때 메인 폼의 기능을 비활성화
                DisableMainFormFeatures();
            }
            else
            {
                EnableMainFormFeatures();
            }
        }

        private void DisableMainFormFeatures()
        {
            // 메인 폼 내의 버튼을 비활성화
            btnOpenIMG.Enabled = false;
            btnConvert.Enabled = false;
            btnSave.Enabled = false;
            // 비활성화 상태 시 흰색 배경
            btnOpenIMG.BackColor = Color.White;
            btnConvert.BackColor = Color.White;
            btnSave.BackColor = Color.White;
            //버튼 상태 메시지
            lblBtnCheck.BackColor = Color.White;
            lblBtnCheck.ForeColor = Color.Red;
            
            lblLogInMsg.ForeColor = Color.Red;
        }

        public void EnableMainFormFeatures()
        {
            // 메인 폼 내의 버튼을 활성화
            btnOpenIMG.Enabled = true;
            btnConvert.Enabled = true;
            btnSave.Enabled = true;
            // 비활성화 상태 시 회색 배경
            btnOpenIMG.BackColor = Color.DimGray;
            btnConvert.BackColor = Color.DimGray;
            btnSave.BackColor = Color.DimGray;
            //버튼 상태 메시지
            lblBtnCheck.ForeColor = Color.DarkGreen;
            lblBtnCheck.BackColor = Color.DimGray;
            lblBtnCheck.Text = "버튼 활성화";

            LogIn();
        }

        public void LogIn()
        {
            isLoggedIn = true;
            lblLogIn.Text = "Log Out";
            lblLogInMsg.Text = "로그인되었습니다.";
            lblLogInMsg.ForeColor = Color.DarkGreen;
             
        }

        public void LogOut()
        {
            isLoggedIn = false;
            DisableMainFormFeatures();
            lblLogIn.Text = "Log In";
            //로그아웃 버튼을 눌렀을 때 버튼 원복
            lblLogInMsg.Text = "로그인이 필요합니다!";
            lblBtnCheck.Text = "버튼 비활성화";
            //lblLogInMsg.ForeColor = Color.Red;
        }


        private void pBoxLogIn_Click(object sender, EventArgs e)
        {
            
            if (isLoggedIn)
            {
                //로그아웃 시 등록했던 사진 초기화
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                // 로그인 상태에서 로그인 버튼을 클릭하면 로그아웃 처리를 수행합니다.               
                LogOut();
            }
            else
            {
                if (_loginForm == null || _loginForm.IsDisposed)
                {  // 로그인 폼이 열려있지 않을 때만 새로 생성 및 열기
                    _loginForm = new LogInForm();
                    _loginForm.Show();
                }
                else
                {
                    // 로그인 폼이 이미 열려 있을 경우 포커스를 주거나 아무 작업도 하지 않게
                    _loginForm.Focus();
                }
            }

        }

        private void pboxMinimize_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void pBoxExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOpenIMG_Click(object sender, EventArgs e)
        {
            //OpenCvSharp.Point OpenCvPoint = new OpenCvSharp.Point();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // 원본 이미지를 Mat 객체로 불러옴
                originalImage = Cv2.ImRead(imagePath, ImreadModes.Color);

                // Mat을 Bitmap으로 변환
                Bitmap bitmapImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(originalImage);

                // 이미지가 중앙에 오도록 PictureBox 설정
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                // pbox1에 이미지 표시
                pictureBox1.Image = bitmapImage;

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                // 이미지를 흑백으로 변환
                Mat grayImage = new Mat();
                Cv2.CvtColor(originalImage, grayImage, ColorConversionCodes.BGR2GRAY);

                // Mat을 Bitmap으로 변환
                convertImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(grayImage);

                // 이미지가 중앙에 오도록 PictureBox 설정
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                // pbox2에 이미지 표시
                pictureBox2.Image = convertImage;


            }
            else
            {
                MessageBox.Show("변환할 이미지가 없습니다!!!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 저장할 파일 경로 설정
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;


                // 이미지를 파일로 저장
                Mat matImage = OpenCvSharp.Extensions.BitmapConverter.ToMat(convertImage); // Bitmap을 Mat으로 변환(Mat 객채를 저장하기 때문에 변환)
                matImage.ImWrite(savePath);
            }
        }
    }
}

