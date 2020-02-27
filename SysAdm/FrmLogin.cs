using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAdm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MouseDownFrm);
            this.MouseMove += new MouseEventHandler(MouseMoveFrm);
            txtLogin.Text = txtPwd.Text = "admin";
        }

        int click = 0;
        int X = 0;
        int Y = 0;

        ClsLogin Login;
        Image imgBKP;

        private async void CheckLogin()
        {
            await Task.Delay(100);
            Login = new ClsLogin
            {
                Pwd = txtPwd.Text,
                Login = txtLogin.Text
            };

            string resul = Login.LoginValidation();

            if (resul.Length > 5)
            {
                DataBaseFailure(resul, "Tentar Validar Login no Servidor");
                lblMessage.Visible = false;
                btnGo.Enabled = true;
            }

            else if (Convert.ToBoolean(resul))
                ValidLogin();

            else
                InvalidLogin();
        }

        private async void ValidLogin()
        {
            lblTop.BackColor = Color.ForestGreen;
            MessageToUser(Color.SeaGreen, "Login Feito Com Sucesso");
            await Task.Delay(100);
            FrmMain frmMain = new FrmMain();
            FrmMain main = frmMain;
            this.Hide();
            main.ShowDialog();

            btnGo.Enabled = true;
            this.Show();
            txtPwd.Text = string.Empty;
            lblTop.BackColor = Color.Red;
        }

        private async void InvalidLogin()
        {
            lblTop.BackColor = Color.Red;
            MessageToUser(Color.Red, "Login ou Senha Invalidos");
            await Task.Delay(1500);              
            btnGo.Enabled = true;
        }

        private bool CheckFields()
        {
            bool isChecked = true;

            string errors = string.Empty;

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                errors = "--Preencher Corretamente o Campo Login\n";
                isChecked = false;
            }

            if (string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                errors += "--Preencher Corretamente o Campo Senha\n";
                isChecked = false;
            }

            if (errors != string.Empty)
            {
                if (errors.Length > 48)
                    MessageBox.Show(errors, "Antenção Corrija Os Seguintes Erros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show(errors, "Antenção Corrija O Seguinte Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnGo.Enabled = true;
            }
            return isChecked;
        }

        private void DataBaseFailure(string error, string when)
        {
            if (MessageBox.Show("Erro " + when + "\n\nClique Sim Para Ver a \nDescrição Completa do Erro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                MessageBox.Show(error, "Descrição Completa do Erro", MessageBoxButtons.OK);
        }

        private async void BtnGoClick()
        {
            MessageToUser(Color.Blue, "Validando Login . . .");

            if (click > 0)
                await Task.Delay(500);

            CheckLogin();
            click++;
        }

        private async void MessageToUser(Color color, string text)
        {
            lblMessage.Text = text;
            lblMessage.ForeColor = color;
            lblMessage.Visible = true;

            if (color == Color.ForestGreen)
            {
                lblTop.BackColor = color;
                await Task.Delay(1800);
                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.imgShowPwd, "Clique Para Mostar\nA Senha Digitada");
            toolTip1.SetToolTip(this.imgHidePwd, "Clique Para Ocultar\nA Senha Digitada");
            toolTip1.SetToolTip(this.btnClose, "Clique Para Sair");
            toolTip1.SetToolTip(this.btnGo, "Clique Para\nValidar o Login");
            toolTip1.SetToolTip(this.btnInfo, "Clique Para Obter\nAjuda ou Informações");
            toolTip1.SetToolTip(this.txtLogin, "Digite Seu Prontuario Aqui");
            toolTip1.SetToolTip(this.txtPwd, "Digite Sua Senha Aqui");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            if (CheckFields())
                BtnGoClick();
        }

        private void ImgHidePwd_Click(object sender, EventArgs e)
        {
            imgHidePwd.Visible = false;
            imgShowPwd.Visible = true;
            txtPwd.isPassword = true;
        }

        private void ImgShowPwd_Click(object sender, EventArgs e)
        {
            imgHidePwd.Visible = true;
            imgShowPwd.Visible = false;
            txtPwd.isPassword = false;
        }

        private void MouseDownFrm(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void MouseMoveFrm(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Logar no Sistema e necessario ter um login ja registrado\nCaso Você não tenha contate o administrador");
        }
 
        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            imgBKP = btnClose.Image;
            btnClose.Image = IMG_RED.Image;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = imgBKP;
        }
    }
}