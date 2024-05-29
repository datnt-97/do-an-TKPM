using ALoxe.Common;
using ALoxe.Components;
using ALoxe.Infrastructure.Data;
using ALoxe.Infrastructure.DB;
using ALoxe.Infrastructure.Http;
using ALoxe.Infrastructure.Model;
using ALoxe.Interface;
using ALoxe.UI;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Net.Http;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ALoxe
{
    public partial class frmLogin : Form, IForm
    {
        public Color BackgroundColor { get; set; } = Color.White;
        AppDBContext db;
        public bool UserSuccessfullyAuthenticated { get; private set; } = false;
        private bool isShowPass = false;
        private bool isRemember = true;
        public frmLogin(AppDBContext db)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            //set background color
            this.BackColor = BackgroundColor;
            this.db = new AppDBContext();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var mainForm = new frmMain();
            //mainForm.Closed += (s, args) => this.Close();
            //mainForm.Show();
            //txtEmail.Texts = "84972266712";
            //txtPassword.Texts = "abc123";
            lbPass.Visible = false;
            lbMail.Visible = false;
            string textError = "Sai tài khoản hoặc mật khẩu";
            bool loginSuccess = true;
            UserModel userLogin = null;

            var loading = new frmLoading(async (l) =>
            {
                await Task.Run(async () =>
                  {
                      HttpRequest_v2 httpRequest = new HttpRequest_v2();
                      if (isRemember)
                      {

                          db.UserRemembers.RemoveRange(db.UserRemembers);
                          db.UserRemembers.Add(new UserRemember
                          {
                              Phone = txtEmail.Texts,
                              Pasword = txtPassword.Texts
                          });
                          db.SaveChanges();
                      }

                      var response = await httpRequest.SendAsync(Constant.APP_SERVER + Constant.URL_LOGIN, HttpMethod.Post, new
                      {
                          phoneNumber = txtEmail.Texts,
                          password = txtPassword.Texts
                      }, headers: new Dictionary<string, string>
                      {
                      });
                      if (response.IsSuccessStatusCode)
                      {
                          var result = await response.Content.ReadAsStringAsync();
                          var res = JsonConvert.DeserializeObject<Result>(result);
                          if (res.status == "SUCCESS")
                          {
                              var user = JsonConvert.DeserializeObject<UserLogin>(JsonConvert.SerializeObject(res.data));
                              if (user.staffId == null || user.role != "STAFF")
                              {
                                  textError = "Tài khoản không có quyền truy cập hoặc không tồn tại";
                                  loginSuccess = false;
                                  return;
                              }
                              userLogin = new Infrastructure.Model.UserModel
                              {
                                  Id = user.staffId ?? 0,
                                  Email = txtEmail.Texts,
                                  Password = txtPassword.Texts,
                                  Token = user.accessToken,
                                  Phone = txtEmail.Texts,
                                  FullName = user.fullName ?? "",
                                  UrlAvatar = "",
                                  ReToken = user.refreshToken

                              };
                              textError = "Đăng nhập thành công";

                          }
                      }
                      else
                      {
                          if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                          {

                              textError = "Lỗi kết nối";
                          }

                          loginSuccess = false;
                          //lbPass.Text = "Sai tài khoản hoặc mật khẩu";
                          //lbPass.Visible = true;
                          //lbPass.ForeColor = Color.Red;
                      }
                  });
                l.PerformSafely(() => l.Close());
            });
            loading.ShowDialog(this);

            //loginSuccess = true;
            lbPass.Text = textError;
            lbPass.Visible = true;
            if (loginSuccess)
            {
                lbPass.ForeColor = Color.Green;
                db.Users.RemoveRange(db.Users);
                db.Users.Add(userLogin);
                db.SaveChanges();
                UserSuccessfullyAuthenticated = true;
                this.Close();
            }
            else
            {
                lbPass.ForeColor = Color.Red;
            }
        }

        private void FrmLogin_Closed(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ptShowPass.Image = Properties.Resources.eye;
            if (db.Users.FirstOrDefault() != null)
            {
                UserSuccessfullyAuthenticated = true;
                this.Close();
                return;
            }//set không cho resize form 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtEmail.TextBox.Font = new Font("Arial", 12, FontStyle.Bold);
            txtPassword.TextBox.Font = new Font("Arial", 12, FontStyle.Bold);
            //get user remember
            var userRemember = db.UserRemembers.FirstOrDefault();
            if (userRemember != null)
            {
                txtEmail.Texts = userRemember.Phone;
                txtPassword.Texts = userRemember.Pasword;
                cbIsRemember.Checked = true;
            }

        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {


        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            //check if email is valid
            return;
            if (txtEmail.Texts.Length > 0)
            {
                if (!Common.Util.IsValidEmail(txtEmail.Texts))
                {
                    lbMail.Visible = true;
                    lbMail.Text = "Email không hợp lệ";
                    lbMail.ForeColor = Color.Red;
                }
                else
                {
                    lbMail.Visible = false;
                }

            }
            else
            {
                lbMail.Visible = false;

            }
        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            //check enter key
            if (e.KeyCode == Keys.Enter)
            {
                rjButton1_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rjButton1_Click(sender, e);
            }
        }

        private void ptShowPass_Click(object sender, EventArgs e)
        {
            if (isShowPass)
            {
                txtPassword.PasswordChar = false;
                ptShowPass.Image = Properties.Resources.eye;
                isShowPass = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
                ptShowPass.Image = Properties.Resources.eye_close;
                isShowPass = true;
            }
        }

        private void cbIsRemember_CheckedChanged(object sender, EventArgs e)
        {
            isRemember = cbIsRemember.Checked;
        }
    }
}
