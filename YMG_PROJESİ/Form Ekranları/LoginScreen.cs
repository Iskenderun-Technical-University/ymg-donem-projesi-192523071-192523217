using System;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;


namespace VeritabanıGörsel
{

    public partial class LoginScreen : Form
    {
        public static string userNamekey;
        public static int userId;
        public static string isAdmin = "checkAdmin";
        public static int adminCheck;
        public static LoginScreen loginscreen = new LoginScreen();
        public LoginScreen()
        {
            InitializeComponent();
            label1.Visible = false;
        }
         private void buttonsClass1_Click_1(object sender, EventArgs e)
        {
            bool result = database.BaglantiGirisi(textBox1.Text, database.MD5(database.SHA256(textBox2.Text)));
            if (result)
            {
                userNamekey = textBox1.Text;
                userId = Convert.ToInt32(database.bringUserData(userNamekey, database.MD5(database.SHA256(textBox2.Text))));
                adminCheck = Convert.ToInt32(database.bringisAdminData(userNamekey, database.MD5(database.SHA256(textBox2.Text))));
                if (adminCheck == 0)
                {
                   
                    this.Hide();
                    HomeScreen.homescreen.ShowDialog();
                    
                }
                else
                {
                    this.Hide();
                    sellProduct.sellproduct.ShowDialog();
                    
                }
            }
            else
            {
                label1.Visible = true;
            }
        }


        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
