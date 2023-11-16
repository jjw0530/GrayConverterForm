using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231111
{
    public partial class LogInForm : Form
    {
       // private bool _LoggedIn = false; // 초기 상태는 로그아웃 상태

        public LogInForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool LoginCheck()
        {
            string enteredID = tBoxID.Text;
            string enteredPW = tBoxPW.Text;

            if (enteredID == "1" && enteredPW == "2")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (LoginCheck() ==true)
            {
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                mainForm.EnableMainFormFeatures();
                this.Close();
            }          
            else 
            {
                MessageBox.Show("ID 또는 PW가 올바르지 않습니다", "로그인");
            }
        }
        private void BtnLogIn_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // 로그인 버튼을 키보드(Enter)로도 클릭을 실행 할 수 있게 구현
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

    }

    
}
