// Purdue Global IT481 Unit 2 Assignment
// The form class
//
namespace Richard_Moss_Unit2_IT481
{
    public partial class Form1 : Form
    {
        private DB? database;

        private String dbConnString = "Server = localhost\\SQLEXPRESS;" +
                                      "Trusted_Connection=true;" +
                                      "Database=northwind;" +
                                      "User Instance=false;" +
                                      "trustServerCertificate=True;" +
                                      "Connection timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB(dbConnString);
            MessageBox.Show("Connection information sent");
        }
         
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (database is null) database = new DB(dbConnString);
            string count = database.getCustomerCount();
            MessageBox.Show("Customer count requested");
            MessageBox.Show(count, " Customer Count");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (database is null) database = new DB(dbConnString);
            string names = database.getCompanyNames();
            MessageBox.Show("Company names requested");
            MessageBox.Show(names, "Company Names");
        }
    }
}