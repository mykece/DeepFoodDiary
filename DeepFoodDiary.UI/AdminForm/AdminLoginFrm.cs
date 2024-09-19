using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.ENTITY.Entities;
using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.UI.MainForm;


namespace DeepFoodDiary.UI
{
    public partial class AdminLoginFrm : KryptonForm
    {
        private readonly IAdminService _adminService;
        public AdminLoginFrm()
        {
            InitializeComponent();
            _adminService = new AdminService();
        }


        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� b�rak�lamaz.");
                return;
            }

            if (_adminService.LogIn(username, password))
            {

                MessageBox.Show("giri� ba�ar�l�");
                AdminRaporFrm adminRaporFrm = new AdminRaporFrm();
                adminRaporFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullan�c� ad� veya �ifre hatal�");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
            this.Hide();
        }
    }
}
