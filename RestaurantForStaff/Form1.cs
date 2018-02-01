using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestaurantClass;


namespace RestaurantForStaff
{
    public partial class Form1 : Form
    {
        public string connString= "Data Source=DESKTOP-U48MS0K\\SQLEXPRESS; database=tb1777g_PDC; Integrated Security=True";
        SqlConnection connectDB = new SqlConnection();
        

        public Form1()
        {
            InitializeComponent();
          
        }

        private String resName;
        private String resPostcode;
        private String resAddress;
        private String resType;
        private String resTelephone;
        private String resEmail, resWebsite;
        private String resAvergPrice;
        private Image resLogo;
        private String resAdverType;

        private OpenFileDialog addImgDialog;
        private DialogResult addimgresultdia;



        private void saveRestDetails_Click(object sender, EventArgs e)
        {
            if (resName != null && resAddress != null && resPostcode != null && resTelephone != null && resType != null && resLogo != null && resAvergPrice != null)
            {
                addRestaurantresult.Text = "Last inserted restaurant was: " + resName + " postcode: " + resPostcode + " address: " + resAddress + " type: " + resType + " telephone: " + resTelephone + " email: " + resEmail + " website: " + resWebsite + " averge price " + resAvergPrice + " advert type " + resAdverType;

                SqlConnection addcnct = new SqlConnection();
                SqlCommand addcmnd = new SqlCommand("INSERT INTO Restaurant_table (ResName,ResPostCode,ResAddress,ResTelephone,ResEmail,ResWebsite,ResAveragePrice,ResLogo,ResTypeID,ResAdvertID) VALUES" + "( '" + resName + "','" + resPostcode + "', '" + resAddress + "', '" + resTelephone + "', '" + resEmail + "','" + resWebsite + "','" + resAvergPrice + "','" + resLogo + "','" + resType + "','" + resAdverType + "')", addcnct);

                try
                {
                    addcmnd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                addcnct.Close();

                /*
                            string   addquery = "INSERT INTO Restaurant_table (ResName,ResPostCode,ResAddress,ResTelephone,ResEmail,ResWebsite,ResAveragePrice,ResLogo,ResTypeID,ResAdvertID) VALUES " +
                             "( '" + resName + "','" + resPostcode + "', '" + resAddress + "', '" + resTelephone + "', '" + resEmail + "','" + resWebsite + "','" + resAvergPrice + "','" + resLogo + "','"+ resType + "','"+ resAdverType + "')";
                               try
                               {
                                   using ( connectDB = new SqlConnection(connString))
                                   {
                                     SqlCommand addcmnd = new SqlCommand();
                                       addcmnd.Connection = connectDB;
                                       connectDB.Open();
                                       addcmnd.CommandText = addquery;                       
                                       addcmnd.ExecuteNonQuery();
                                       addcmnd.Clone();
                                   }
                               }
                               catch (Exception ex)
                               {
                                   Console.WriteLine("Exception Occre while creating table:" + ex.Message + "\t" + ex.GetType());
                               }

                                 try { 
                                 string addquery = "INSERT INTO Restaurant_table(ResName,ResPostCode,ResAddress,ResTelephone,ResEmail,ResWebsite,ResAveragePrice,ResLogo,ResTypeID,ResAdvertID)";
                                 addquery += "VALUES (@resName, @resPostcode, @resAddress, @resTelephone, @resEmail, @resWebsite, @resAvergPrice, @resLogo, @resType, @resAdverType)";

                                 SqlConnection connect = new SqlConnection();
                                 connect.ConnectionString = "Data Source=DESKTOP-U48MS0K\\SQLEXPRESS; database=tb1777g_PDC; Integrated Security=True";
                                 connect.Open();
                                 SqlCommand addcmnd = new SqlCommand(addquery, connect);
                                 addcmnd.Parameters.AddWithValue("@resName", resName);
                                 addcmnd.Parameters.AddWithValue("@resPostcode", resPostcode);
                                 addcmnd.Parameters.AddWithValue("@resAddress", resAddress);
                                 addcmnd.Parameters.AddWithValue("@resTelephone", resTelephone);
                                 addcmnd.Parameters.AddWithValue("@resEmail", resEmail);
                                 addcmnd.Parameters.AddWithValue("@resWebsite", resWebsite);
                                 addcmnd.Parameters.AddWithValue("@resAvergPrice", resAvergPrice);
                                 addcmnd.Parameters.AddWithValue("@resLogo", resLogo);
                                 addcmnd.Parameters.AddWithValue("@resType", resType);
                                 addcmnd.Parameters.AddWithValue("@resAdverType", resAdverType);
                                 addcmnd.ExecuteNonQuery();
                                     connect.Close();
                                 }
                                 catch (Exception)
                                 {
                                     Console.WriteLine("Exception Occre while creating table:" + e.GetType());
                                 }



                                                 string addquery = "INSERT INTO Restaurant_table(ResName,ResPostCode,ResAddress,ResTelephone,ResEmail,ResWebsite,ResAveragePrice,ResLogo,ResTypeID,ResAdvertID)";
                                                 addquery += "VALUES (@resName, @resPostcode, @resAddress, @resTelephone, @resEmail, @resWebsite, @resAvergPrice, @resLogo, @resType, @resAdverType)";
                                                 SqlCommand addcmnd = new SqlCommand(addquery,connString);
                                                 conadd.Open();

                                                 SqlCommand addcmnd = new SqlCommand();
                                                 addcmnd.CommandType = CommandType.Text;
                                                 addcmnd.CommandText = "INSERT INTO Restaurant_table(ResName,ResPostCode,ResAddress,ResTelephone,ResEmail,ResWebsite,ResAveragePrice,ResLogo,ResTypeID,ResAdvertID) values (@resName,@resPostcode,@resAddress,@resTelephone,@resEmail,@resWebsite,@resAvergPrice,@resLogo,@resType,@resAdverType)";
                                                 addcmnd.Parameters.AddWithValue("@resName", resName);
                                                 addcmnd.Parameters.AddWithValue("@resPostcode", resPostcode);
                                                 addcmnd.Parameters.AddWithValue("@resAddress", resAddress);
                                                 addcmnd.Parameters.AddWithValue("@resTelephone", resTelephone);
                                                 addcmnd.Parameters.AddWithValue("@resEmail", resEmail);
                                                 addcmnd.Parameters.AddWithValue("@resWebsite", resWebsite);
                                                 addcmnd.Parameters.AddWithValue("@resAvergPrice", resAvergPrice);
                                                 addcmnd.Parameters.AddWithValue("@resLogo", resLogo);
                                                 addcmnd.Parameters.AddWithValue("@resType", resType);
                                                 addcmnd.Parameters.AddWithValue("@resAdverType", resAdverType);
                                                 addcmnd.Connection = conadd;
                                                 addcmnd.ExecuteNonQuery();
                                                 conadd.Close();  
                                                 */
                //('" + resName + "','" + resPostcode + "','" + resAddress + "','" + resType + "','" + resTelephone + "','" + resEmail + "','" + resWebsite + "','" + resAvergPrice + "','" + resAvergPrice + "','" + resLogo)
            }
            else {
                addRestaurantresult.Text = "Required fields cannot be empty";
            }
        }

        private void picturebrowsebtn_Click(object sender, EventArgs e)
        {
            try
            {
                addImgDialog = new OpenFileDialog();
                addImgDialog.Filter = "image files|*.jpg;*.jpeg;*.png;*.gif";
                addimgresultdia = addImgDialog.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Image Error");
                imglabel.Text = "Image has to be added";
                resLogo = null;
            }


            if (addimgresultdia == DialogResult.Cancel)
                return;

            logobox.Image = Image.FromFile(addImgDialog.FileName);
            imglabel.Text = "Image was added";
           resLogo = restaurantComponent1.LogoImageRes(logobox.Image);
        }

        private void restupdatbtn_Click(object sender, EventArgs e)
        {
            searchlogoresult.Image = resLogo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tb1777g_PDCDataSet.RestaurantAdvert_table' table. You can move, or remove it, as needed.
            this.restaurantAdvert_tableTableAdapter.Fill(this.tb1777g_PDCDataSet.RestaurantAdvert_table);
            // TODO: This line of code loads data into the 'tb1777g_PDCDataSet.RestaurantType_table' table. You can move, or remove it, as needed.
            this.restaurantType_tableTableAdapter.Fill(this.tb1777g_PDCDataSet.RestaurantType_table);
            // TODO: This line of code loads data into the 'tb1777g_PDCDataSet.RestaurantAdvert_table' table. You can move, or remove it, as needed.
            this.restaurantAdvert_tableTableAdapter.Fill(this.tb1777g_PDCDataSet.RestaurantAdvert_table);
            // TODO: This line of code loads data into the 'tb1777g_PDCDataSet.RestaurantType_table' table. You can move, or remove it, as needed.
            this.restaurantType_tableTableAdapter.Fill(this.tb1777g_PDCDataSet.RestaurantType_table);

        }

        private void displayAllbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DESKTOP-U48MS0K\\SQLEXPRESS; database=tb1777g_PDC; Integrated Security=True";
            SqlCommand cmnd = new SqlCommand("select* from Restaurant_table", connect);
            connect.Open();
            SqlDataReader dataread = cmnd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = dataread;
            dataGridView1.DataSource = source;
            connect.Close();
                

        }

        private void addrestaurant_Click(object sender, EventArgs e)
        {
            
            resName = restaurantComponent1.Restaurantname(restnametxtbx.Text);
            if (resName==null)
            {
                restaurantnameresult.Text = "Restaurant name cannot be empty";
            }
            else
            {
                restaurantnameresult.Text = resName;                
            }


            resPostcode = restaurantComponent1.RestaurantPostcode(postcodtxtbx.Text);
            if (resPostcode== null)
            {
                postcoderesult.Text = "Postcode is not valid";
            }
            else
            {
                postcoderesult.Text = resPostcode;                           
            }


            resAddress = restaurantComponent1.RestaurantAddress(addresstxtbx.Text);
            if (resAddress ==null)
            {
                addressresult.Text= "Address is not valid";
            }
            else
            {
                addressresult.Text = resAddress;                          
            }


               resType = restaurantComponent1.CompResType(restypecombo.Text);
            if (resType==null)
            {
                typeresult.Text = "Type is not valid";
            }
            else { 
                typeresult.Text = resType;                
            }


            resTelephone = restaurantComponent1.Restelephonmb(restelephontxtbx.Text);
            if (resTelephone ==null)
            {
                telephoneresult.Text = "Phone number is not valid";
            }
            else
            {
                telephoneresult.Text = resTelephone;
            }


            resEmail = restaurantComponent1.ResEmailAddressCom(resemailtxtbx.Text);
            if (resEmail == null)
            {     
            }
            else { emailresult.Text = resEmail; }


             resWebsite= restaurantComponent1.ResWebSite(reswebsittxtbx.Text);
            if (resWebsite == null)
            {            }
            else { websiresult.Text = resWebsite; }


            resAvergPrice = restaurantComponent1.Averageprice(averpricetxtbx.Text);
            if (resAvergPrice !=null)
            {
                avgprresult.Text = resAvergPrice;
            }
            else { avgprresult.Text = "Average price can't be empty"; }


            resAdverType = restaurantComponent1.ResAdvertyp(advertcmbx.Text);
            if (resAdverType != null)
            {
                adverttyresultlbl.Text = resAdverType;
            }
            else { adverttyresultlbl.Text = "Field cannot be empty"; }
        }
               
              
    }
}
