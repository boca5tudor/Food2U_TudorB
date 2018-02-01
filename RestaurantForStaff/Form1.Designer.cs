namespace RestaurantForStaff
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addrestaurant = new System.Windows.Forms.Button();
            this.imglabel = new System.Windows.Forms.Label();
            this.advertcmbx = new System.Windows.Forms.ComboBox();
            this.restaurantAdverttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb1777g_PDCDataSet = new RestaurantForStaff.tb1777g_PDCDataSet();
            this.adverttyresultlbl = new System.Windows.Forms.Label();
            this.picturebrowsebtn = new System.Windows.Forms.Button();
            this.averttyplabl = new System.Windows.Forms.Label();
            this.logobox = new System.Windows.Forms.PictureBox();
            this.addlogolab = new System.Windows.Forms.Label();
            this.restypecombo = new System.Windows.Forms.ComboBox();
            this.restaurantTypetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelrestnme = new System.Windows.Forms.Label();
            this.avgprresult = new System.Windows.Forms.Label();
            this.labeltype = new System.Windows.Forms.Label();
            this.upadteitemslbl = new System.Windows.Forms.Label();
            this.saveRestDetails = new System.Windows.Forms.Button();
            this.restupdatbtn = new System.Windows.Forms.Button();
            this.websiresult = new System.Windows.Forms.Label();
            this.labelpostcode = new System.Windows.Forms.Label();
            this.emailresult = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labeltelephone = new System.Windows.Forms.Label();
            this.typeresult = new System.Windows.Forms.Label();
            this.addRestaurantresult = new System.Windows.Forms.Label();
            this.telephoneresult = new System.Windows.Forms.Label();
            this.searchlogoresult = new System.Windows.Forms.PictureBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.addressresult = new System.Windows.Forms.Label();
            this.restnametxtbx = new System.Windows.Forms.TextBox();
            this.postcoderesult = new System.Windows.Forms.Label();
            this.restaurantnameresult = new System.Windows.Forms.Label();
            this.postcodtxtbx = new System.Windows.Forms.TextBox();
            this.restelephontxtbx = new System.Windows.Forms.TextBox();
            this.averpricetxtbx = new System.Windows.Forms.TextBox();
            this.resemailtxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelwebsite = new System.Windows.Forms.Label();
            this.reswebsittxtbx = new System.Windows.Forms.TextBox();
            this.deleterestabtn = new System.Windows.Forms.Button();
            this.addresstxtbx = new System.Windows.Forms.TextBox();
            this.restaurantAddpanel = new System.Windows.Forms.Panel();
            this.restaurantComponent1 = new RestaurantClass.RestaurantComponent(this.components);
            this.restaurantType_tableTableAdapter = new RestaurantForStaff.tb1777g_PDCDataSetTableAdapters.RestaurantType_tableTableAdapter();
            this.restaurantAdvert_tableTableAdapter = new RestaurantForStaff.tb1777g_PDCDataSetTableAdapters.RestaurantAdvert_tableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.displayAllbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAdverttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1777g_PDCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantTypetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchlogoresult)).BeginInit();
            this.restaurantAddpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addrestaurant
            // 
            this.addrestaurant.Location = new System.Drawing.Point(1048, 42);
            this.addrestaurant.Name = "addrestaurant";
            this.addrestaurant.Size = new System.Drawing.Size(222, 26);
            this.addrestaurant.TabIndex = 80;
            this.addrestaurant.Text = "Check Restaurant Details";
            this.addrestaurant.UseVisualStyleBackColor = true;
            this.addrestaurant.Click += new System.EventHandler(this.addrestaurant_Click);
            // 
            // imglabel
            // 
            this.imglabel.AutoSize = true;
            this.imglabel.Location = new System.Drawing.Point(641, 452);
            this.imglabel.Name = "imglabel";
            this.imglabel.Size = new System.Drawing.Size(103, 17);
            this.imglabel.TabIndex = 79;
            this.imglabel.Text = "Image required";
            // 
            // advertcmbx
            // 
            this.advertcmbx.DataSource = this.restaurantAdverttableBindingSource;
            this.advertcmbx.DisplayMember = "ResAdvertType";
            this.advertcmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advertcmbx.FormattingEnabled = true;
            this.advertcmbx.Location = new System.Drawing.Point(244, 549);
            this.advertcmbx.Name = "advertcmbx";
            this.advertcmbx.Size = new System.Drawing.Size(306, 24);
            this.advertcmbx.TabIndex = 78;
            // 
            // restaurantAdverttableBindingSource
            // 
            this.restaurantAdverttableBindingSource.DataMember = "RestaurantAdvert_table";
            this.restaurantAdverttableBindingSource.DataSource = this.tb1777g_PDCDataSet;
            // 
            // tb1777g_PDCDataSet
            // 
            this.tb1777g_PDCDataSet.DataSetName = "tb1777g_PDCDataSet";
            this.tb1777g_PDCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adverttyresultlbl
            // 
            this.adverttyresultlbl.AutoSize = true;
            this.adverttyresultlbl.Location = new System.Drawing.Point(638, 556);
            this.adverttyresultlbl.Name = "adverttyresultlbl";
            this.adverttyresultlbl.Size = new System.Drawing.Size(66, 17);
            this.adverttyresultlbl.TabIndex = 77;
            this.adverttyresultlbl.Text = "Required";
            // 
            // picturebrowsebtn
            // 
            this.picturebrowsebtn.Location = new System.Drawing.Point(433, 396);
            this.picturebrowsebtn.Name = "picturebrowsebtn";
            this.picturebrowsebtn.Size = new System.Drawing.Size(117, 23);
            this.picturebrowsebtn.TabIndex = 65;
            this.picturebrowsebtn.Text = "Browse Picture";
            this.picturebrowsebtn.UseVisualStyleBackColor = true;
            this.picturebrowsebtn.Click += new System.EventHandler(this.picturebrowsebtn_Click);
            // 
            // averttyplabl
            // 
            this.averttyplabl.AutoSize = true;
            this.averttyplabl.Location = new System.Drawing.Point(12, 558);
            this.averttyplabl.Name = "averttyplabl";
            this.averttyplabl.Size = new System.Drawing.Size(88, 17);
            this.averttyplabl.TabIndex = 75;
            this.averttyplabl.Text = "Addvert type";
            // 
            // logobox
            // 
            this.logobox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.logobox.Location = new System.Drawing.Point(244, 396);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(162, 122);
            this.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logobox.TabIndex = 64;
            this.logobox.TabStop = false;
            // 
            // addlogolab
            // 
            this.addlogolab.AutoSize = true;
            this.addlogolab.Location = new System.Drawing.Point(24, 394);
            this.addlogolab.Name = "addlogolab";
            this.addlogolab.Size = new System.Drawing.Size(143, 17);
            this.addlogolab.TabIndex = 63;
            this.addlogolab.Text = "Add Restaurant Logo";
            // 
            // restypecombo
            // 
            this.restypecombo.DataSource = this.restaurantTypetableBindingSource;
            this.restypecombo.DisplayMember = "ResType";
            this.restypecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restypecombo.FormattingEnabled = true;
            this.restypecombo.Location = new System.Drawing.Point(244, 159);
            this.restypecombo.Name = "restypecombo";
            this.restypecombo.Size = new System.Drawing.Size(306, 24);
            this.restypecombo.TabIndex = 62;
            // 
            // restaurantTypetableBindingSource
            // 
            this.restaurantTypetableBindingSource.DataMember = "RestaurantType_table";
            this.restaurantTypetableBindingSource.DataSource = this.tb1777g_PDCDataSet;
            // 
            // labelrestnme
            // 
            this.labelrestnme.AutoSize = true;
            this.labelrestnme.Location = new System.Drawing.Point(24, 30);
            this.labelrestnme.Name = "labelrestnme";
            this.labelrestnme.Size = new System.Drawing.Size(148, 17);
            this.labelrestnme.TabIndex = 36;
            this.labelrestnme.Text = "Add Restaurant Name";
            // 
            // avgprresult
            // 
            this.avgprresult.AutoSize = true;
            this.avgprresult.Location = new System.Drawing.Point(638, 346);
            this.avgprresult.Name = "avgprresult";
            this.avgprresult.Size = new System.Drawing.Size(66, 17);
            this.avgprresult.TabIndex = 61;
            this.avgprresult.Text = "Required";
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(24, 159);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(182, 17);
            this.labeltype.TabIndex = 37;
            this.labeltype.Text = "Add Type (eg Italian, Pizza)";
            // 
            // upadteitemslbl
            // 
            this.upadteitemslbl.AutoSize = true;
            this.upadteitemslbl.Location = new System.Drawing.Point(759, 656);
            this.upadteitemslbl.Name = "upadteitemslbl";
            this.upadteitemslbl.Size = new System.Drawing.Size(228, 17);
            this.upadteitemslbl.TabIndex = 85;
            this.upadteitemslbl.Text = "Update Restaurants from list below";
            // 
            // saveRestDetails
            // 
            this.saveRestDetails.Location = new System.Drawing.Point(1096, 97);
            this.saveRestDetails.Name = "saveRestDetails";
            this.saveRestDetails.Size = new System.Drawing.Size(174, 65);
            this.saveRestDetails.TabIndex = 84;
            this.saveRestDetails.Text = "Add Restaurant";
            this.saveRestDetails.UseVisualStyleBackColor = true;
            this.saveRestDetails.Click += new System.EventHandler(this.saveRestDetails_Click);
            // 
            // restupdatbtn
            // 
            this.restupdatbtn.Location = new System.Drawing.Point(1096, 206);
            this.restupdatbtn.Name = "restupdatbtn";
            this.restupdatbtn.Size = new System.Drawing.Size(174, 63);
            this.restupdatbtn.TabIndex = 83;
            this.restupdatbtn.Text = "Update Restaurant";
            this.restupdatbtn.UseVisualStyleBackColor = true;
            this.restupdatbtn.Click += new System.EventHandler(this.restupdatbtn_Click);
            // 
            // websiresult
            // 
            this.websiresult.AutoSize = true;
            this.websiresult.Location = new System.Drawing.Point(638, 300);
            this.websiresult.Name = "websiresult";
            this.websiresult.Size = new System.Drawing.Size(61, 17);
            this.websiresult.TabIndex = 60;
            this.websiresult.Text = "Optional";
            // 
            // labelpostcode
            // 
            this.labelpostcode.AutoSize = true;
            this.labelpostcode.Location = new System.Drawing.Point(24, 70);
            this.labelpostcode.Name = "labelpostcode";
            this.labelpostcode.Size = new System.Drawing.Size(96, 17);
            this.labelpostcode.TabIndex = 38;
            this.labelpostcode.Text = "Add Postcode";
            // 
            // emailresult
            // 
            this.emailresult.AutoSize = true;
            this.emailresult.Location = new System.Drawing.Point(638, 253);
            this.emailresult.Name = "emailresult";
            this.emailresult.Size = new System.Drawing.Size(61, 17);
            this.emailresult.TabIndex = 59;
            this.emailresult.Text = "Optional";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(24, 113);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(89, 17);
            this.labeladdress.TabIndex = 39;
            this.labeladdress.Text = "Add Address";
            // 
            // labeltelephone
            // 
            this.labeltelephone.AutoSize = true;
            this.labeltelephone.Location = new System.Drawing.Point(24, 207);
            this.labeltelephone.Name = "labeltelephone";
            this.labeltelephone.Size = new System.Drawing.Size(105, 17);
            this.labeltelephone.TabIndex = 40;
            this.labeltelephone.Text = "Add Telephone";
            // 
            // typeresult
            // 
            this.typeresult.AutoSize = true;
            this.typeresult.Location = new System.Drawing.Point(638, 159);
            this.typeresult.Name = "typeresult";
            this.typeresult.Size = new System.Drawing.Size(66, 17);
            this.typeresult.TabIndex = 57;
            this.typeresult.Text = "Required";
            // 
            // addRestaurantresult
            // 
            this.addRestaurantresult.AutoSize = true;
            this.addRestaurantresult.Location = new System.Drawing.Point(58, 621);
            this.addRestaurantresult.Name = "addRestaurantresult";
            this.addRestaurantresult.Size = new System.Drawing.Size(164, 17);
            this.addRestaurantresult.TabIndex = 81;
            this.addRestaurantresult.Text = "Last Inserted Restaurant";
            // 
            // telephoneresult
            // 
            this.telephoneresult.AutoSize = true;
            this.telephoneresult.Location = new System.Drawing.Point(638, 207);
            this.telephoneresult.Name = "telephoneresult";
            this.telephoneresult.Size = new System.Drawing.Size(66, 17);
            this.telephoneresult.TabIndex = 58;
            this.telephoneresult.Text = "Required";
            // 
            // searchlogoresult
            // 
            this.searchlogoresult.Location = new System.Drawing.Point(1059, 656);
            this.searchlogoresult.Name = "searchlogoresult";
            this.searchlogoresult.Size = new System.Drawing.Size(237, 168);
            this.searchlogoresult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchlogoresult.TabIndex = 87;
            this.searchlogoresult.TabStop = false;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(24, 251);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(71, 17);
            this.labelemail.TabIndex = 41;
            this.labelemail.Text = "Add Email";
            // 
            // addressresult
            // 
            this.addressresult.AutoSize = true;
            this.addressresult.Location = new System.Drawing.Point(638, 113);
            this.addressresult.Name = "addressresult";
            this.addressresult.Size = new System.Drawing.Size(66, 17);
            this.addressresult.TabIndex = 56;
            this.addressresult.Text = "Required";
            // 
            // restnametxtbx
            // 
            this.restnametxtbx.Location = new System.Drawing.Point(244, 25);
            this.restnametxtbx.Name = "restnametxtbx";
            this.restnametxtbx.Size = new System.Drawing.Size(306, 22);
            this.restnametxtbx.TabIndex = 42;
            // 
            // postcoderesult
            // 
            this.postcoderesult.AutoSize = true;
            this.postcoderesult.Location = new System.Drawing.Point(638, 75);
            this.postcoderesult.Name = "postcoderesult";
            this.postcoderesult.Size = new System.Drawing.Size(66, 17);
            this.postcoderesult.TabIndex = 55;
            this.postcoderesult.Text = "Required";
            // 
            // restaurantnameresult
            // 
            this.restaurantnameresult.AutoSize = true;
            this.restaurantnameresult.Location = new System.Drawing.Point(638, 29);
            this.restaurantnameresult.Name = "restaurantnameresult";
            this.restaurantnameresult.Size = new System.Drawing.Size(66, 17);
            this.restaurantnameresult.TabIndex = 54;
            this.restaurantnameresult.Text = "Required";
            // 
            // postcodtxtbx
            // 
            this.postcodtxtbx.Location = new System.Drawing.Point(244, 70);
            this.postcodtxtbx.Name = "postcodtxtbx";
            this.postcodtxtbx.Size = new System.Drawing.Size(306, 22);
            this.postcodtxtbx.TabIndex = 44;
            // 
            // restelephontxtbx
            // 
            this.restelephontxtbx.Location = new System.Drawing.Point(244, 207);
            this.restelephontxtbx.Name = "restelephontxtbx";
            this.restelephontxtbx.Size = new System.Drawing.Size(306, 22);
            this.restelephontxtbx.TabIndex = 46;
            // 
            // averpricetxtbx
            // 
            this.averpricetxtbx.Location = new System.Drawing.Point(244, 349);
            this.averpricetxtbx.Name = "averpricetxtbx";
            this.averpricetxtbx.Size = new System.Drawing.Size(306, 22);
            this.averpricetxtbx.TabIndex = 51;
            // 
            // resemailtxtbx
            // 
            this.resemailtxtbx.Location = new System.Drawing.Point(244, 251);
            this.resemailtxtbx.Name = "resemailtxtbx";
            this.resemailtxtbx.Size = new System.Drawing.Size(306, 22);
            this.resemailtxtbx.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Add Average Price";
            // 
            // labelwebsite
            // 
            this.labelwebsite.AutoSize = true;
            this.labelwebsite.Location = new System.Drawing.Point(24, 300);
            this.labelwebsite.Name = "labelwebsite";
            this.labelwebsite.Size = new System.Drawing.Size(88, 17);
            this.labelwebsite.TabIndex = 48;
            this.labelwebsite.Text = "Add Website";
            // 
            // reswebsittxtbx
            // 
            this.reswebsittxtbx.Location = new System.Drawing.Point(244, 300);
            this.reswebsittxtbx.Name = "reswebsittxtbx";
            this.reswebsittxtbx.Size = new System.Drawing.Size(306, 22);
            this.reswebsittxtbx.TabIndex = 49;
            // 
            // deleterestabtn
            // 
            this.deleterestabtn.Location = new System.Drawing.Point(1096, 315);
            this.deleterestabtn.Name = "deleterestabtn";
            this.deleterestabtn.Size = new System.Drawing.Size(174, 47);
            this.deleterestabtn.TabIndex = 86;
            this.deleterestabtn.Text = "Delete Restaurant";
            this.deleterestabtn.UseVisualStyleBackColor = true;
            // 
            // addresstxtbx
            // 
            this.addresstxtbx.Location = new System.Drawing.Point(244, 113);
            this.addresstxtbx.Name = "addresstxtbx";
            this.addresstxtbx.Size = new System.Drawing.Size(306, 22);
            this.addresstxtbx.TabIndex = 45;
            // 
            // restaurantAddpanel
            // 
            this.restaurantAddpanel.Controls.Add(this.imglabel);
            this.restaurantAddpanel.Controls.Add(this.advertcmbx);
            this.restaurantAddpanel.Controls.Add(this.adverttyresultlbl);
            this.restaurantAddpanel.Controls.Add(this.picturebrowsebtn);
            this.restaurantAddpanel.Controls.Add(this.averttyplabl);
            this.restaurantAddpanel.Controls.Add(this.logobox);
            this.restaurantAddpanel.Controls.Add(this.addlogolab);
            this.restaurantAddpanel.Controls.Add(this.restypecombo);
            this.restaurantAddpanel.Controls.Add(this.labelrestnme);
            this.restaurantAddpanel.Controls.Add(this.avgprresult);
            this.restaurantAddpanel.Controls.Add(this.labeltype);
            this.restaurantAddpanel.Controls.Add(this.websiresult);
            this.restaurantAddpanel.Controls.Add(this.labelpostcode);
            this.restaurantAddpanel.Controls.Add(this.emailresult);
            this.restaurantAddpanel.Controls.Add(this.labeladdress);
            this.restaurantAddpanel.Controls.Add(this.telephoneresult);
            this.restaurantAddpanel.Controls.Add(this.labeltelephone);
            this.restaurantAddpanel.Controls.Add(this.typeresult);
            this.restaurantAddpanel.Controls.Add(this.labelemail);
            this.restaurantAddpanel.Controls.Add(this.addressresult);
            this.restaurantAddpanel.Controls.Add(this.restnametxtbx);
            this.restaurantAddpanel.Controls.Add(this.postcoderesult);
            this.restaurantAddpanel.Controls.Add(this.restaurantnameresult);
            this.restaurantAddpanel.Controls.Add(this.postcodtxtbx);
            this.restaurantAddpanel.Controls.Add(this.addresstxtbx);
            this.restaurantAddpanel.Controls.Add(this.restelephontxtbx);
            this.restaurantAddpanel.Controls.Add(this.averpricetxtbx);
            this.restaurantAddpanel.Controls.Add(this.resemailtxtbx);
            this.restaurantAddpanel.Controls.Add(this.label2);
            this.restaurantAddpanel.Controls.Add(this.labelwebsite);
            this.restaurantAddpanel.Controls.Add(this.reswebsittxtbx);
            this.restaurantAddpanel.Location = new System.Drawing.Point(58, 22);
            this.restaurantAddpanel.Name = "restaurantAddpanel";
            this.restaurantAddpanel.Size = new System.Drawing.Size(929, 596);
            this.restaurantAddpanel.TabIndex = 79;
            // 
            // restaurantComponent1
            // 
            this.restaurantComponent1.AdTypeCcom = 0;
            this.restaurantComponent1.AveragePricecomp = null;
            this.restaurantComponent1.LogoComp = null;
            this.restaurantComponent1.PostcodeAcc = null;
            this.restaurantComponent1.ResAddressAcc = null;
            this.restaurantComponent1.ResEmailAddressComp = null;
            this.restaurantComponent1.Restaurantnameacc = null;
            this.restaurantComponent1.Restauranttype = null;
            this.restaurantComponent1.TReselephNumbe = 0;
            this.restaurantComponent1.WebsiteAddressComp = null;
            // 
            // restaurantType_tableTableAdapter
            // 
            this.restaurantType_tableTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantAdvert_tableTableAdapter
            // 
            this.restaurantAdvert_tableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 676);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 220);
            this.dataGridView1.TabIndex = 88;
            // 
            // displayAllbtn
            // 
            this.displayAllbtn.Location = new System.Drawing.Point(1096, 418);
            this.displayAllbtn.Name = "displayAllbtn";
            this.displayAllbtn.Size = new System.Drawing.Size(234, 23);
            this.displayAllbtn.TabIndex = 89;
            this.displayAllbtn.Text = "List all restaurants";
            this.displayAllbtn.UseVisualStyleBackColor = true;
            this.displayAllbtn.Click += new System.EventHandler(this.displayAllbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 908);
            this.Controls.Add(this.displayAllbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addrestaurant);
            this.Controls.Add(this.upadteitemslbl);
            this.Controls.Add(this.saveRestDetails);
            this.Controls.Add(this.restupdatbtn);
            this.Controls.Add(this.addRestaurantresult);
            this.Controls.Add(this.searchlogoresult);
            this.Controls.Add(this.deleterestabtn);
            this.Controls.Add(this.restaurantAddpanel);
            this.Name = "Form1";
            this.Text = "Restaurant Creator, Updater and Remover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAdverttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1777g_PDCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantTypetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchlogoresult)).EndInit();
            this.restaurantAddpanel.ResumeLayout(false);
            this.restaurantAddpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addrestaurant;
        private System.Windows.Forms.Label imglabel;
        private System.Windows.Forms.ComboBox advertcmbx;
        private System.Windows.Forms.Label adverttyresultlbl;
        private System.Windows.Forms.Button picturebrowsebtn;
        private System.Windows.Forms.Label averttyplabl;
        private System.Windows.Forms.PictureBox logobox;
        private System.Windows.Forms.Label addlogolab;
        private System.Windows.Forms.ComboBox restypecombo;
        private System.Windows.Forms.Label labelrestnme;
        private System.Windows.Forms.Label avgprresult;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label upadteitemslbl;
        private System.Windows.Forms.Button saveRestDetails;
        private System.Windows.Forms.Button restupdatbtn;
        private System.Windows.Forms.Label websiresult;
        private System.Windows.Forms.Label labelpostcode;
        private System.Windows.Forms.Label emailresult;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labeltelephone;
        private System.Windows.Forms.Label typeresult;
        private System.Windows.Forms.Label addRestaurantresult;
        private System.Windows.Forms.Label telephoneresult;
        private System.Windows.Forms.PictureBox searchlogoresult;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label addressresult;
        private System.Windows.Forms.TextBox restnametxtbx;
        private System.Windows.Forms.Label postcoderesult;
        private System.Windows.Forms.Label restaurantnameresult;
        private System.Windows.Forms.TextBox postcodtxtbx;
        private System.Windows.Forms.TextBox restelephontxtbx;
        private System.Windows.Forms.TextBox averpricetxtbx;
        private System.Windows.Forms.TextBox resemailtxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelwebsite;
        private System.Windows.Forms.TextBox reswebsittxtbx;
        private System.Windows.Forms.Button deleterestabtn;
        private System.Windows.Forms.TextBox addresstxtbx;
        private System.Windows.Forms.Panel restaurantAddpanel;
        private RestaurantClass.RestaurantComponent restaurantComponent1;
        private tb1777g_PDCDataSet tb1777g_PDCDataSet;
        private System.Windows.Forms.BindingSource restaurantTypetableBindingSource;
        private tb1777g_PDCDataSetTableAdapters.RestaurantType_tableTableAdapter restaurantType_tableTableAdapter;
        private System.Windows.Forms.BindingSource restaurantAdverttableBindingSource;
        private tb1777g_PDCDataSetTableAdapters.RestaurantAdvert_tableTableAdapter restaurantAdvert_tableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button displayAllbtn;
    }
}

