using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComaxTask.AppSystem;
using ComaxTask.Infrastructure;
using System.Configuration;

namespace ComaxTask.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //Watermark text for Username
            txtUsername.Font = new Font(txtUsername.Font,  FontStyle.Italic);
            txtUsername.ForeColor = Color.FromArgb(183, 192, 168);
            txtUsername.Text = "Username";
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new EventHandler(this.txtUsername_Enter);

            //Watermark text for Password
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);          
            txtPassword.ForeColor = Color.FromArgb(183, 192, 168);
            
            txtPassword.Text = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new EventHandler(this.txtPassword_Enter);
        }

        #region Watermark Text
        // Events  for Watermark text of Username textbox
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length==0)
            {
                txtUsername.Font = new Font(txtUsername.Font, FontStyle.Italic);
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.FromArgb(183,192,168);
            }
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = " ";
                txtUsername.Font = new Font(txtUsername.Font, FontStyle.Regular);
                txtUsername.ForeColor = Color.FromArgb(100, 100, 100);
            }
        }

        // Events  for Watermark text of Password textbox
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);              
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.FromArgb(183, 192, 168);
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = " ";
               
               txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
                txtPassword.ForeColor = Color.FromArgb(100, 100, 100);
            }
        }

        #endregion


        #region Custom Form Draging  
        /// <summary>
        /// Drag Form 
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelBackground_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void SubmitConnection()
        {
            if(CanConnect())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials ");
            }
        }

        /// <summary>
        /// Validation Method for checking connection permission of user
        /// </summary>
        /// <returns></returns>
        private bool CanConnect()
        {
            if(txtUsername.Text.Length<3)
            {
                return false;
            }
            if (txtPassword.Text.Length<3)
            {
                return false;
            }
            string query = String.Format("Select * From Users Where Username=@Username  and Password=@Password");
            List<SqlParameter> l = new List<SqlParameter>();
            l.Add(new SqlParameter("@Username", txtUsername.Text.Trim()));
            l.Add(new SqlParameter("@Password", txtPassword.Text.Trim()));

            DataTable dt = ComaxTask.DAL.Database.GetDataSet_WithParameters(query, l).Tables[0];
            if (dt!=null && dt.Rows.Count==1)
            {
                SetUserProfile(ref dt);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetUserProfile(ref DataTable dt)
        {
            UserProfile up = new UserProfile();
            up.User_Id = Convert.ToInt32(dt.GetValueSafely<int>("User_ID",0));
            up.Username = dt.GetValueSafely<string>("Username", 0).ToString();
            up.Password = dt.GetValueSafely<string>("Password", 0).ToString();
            up.First_Name = dt.GetValueSafely<string>("First_Name", 0).ToString();
            up.Last_Name = dt.GetValueSafely<string>("Last_Name", 0).ToString();
            up.LastConnection = Convert.ToDateTime(dt.GetValueSafely<DateTime>("Last_Connection", 0).ToString());

            //update database about connection
            UpdateConnectedUserOnDb(up.User_Id);
            General.ConnectedUserProfile = up;

        }

        private void UpdateConnectedUserOnDb(int user_Id)
        {
            var cmd = "UPDATE Users SET Last_Connection=@Last_Connection WHERE User_ID=" + user_Id;
            List<SqlParameter> l = new List<SqlParameter>();

            l.Add(new SqlParameter("@Last_Connection", DateTime.Now.GetDateWithoutMilliseconds()));
           ComaxTask.DAL.Database.ParametersCommand(cmd, l);
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            SubmitConnection();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitConnection();
            }
        }
    }

        
}

