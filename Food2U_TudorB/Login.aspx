<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Food2U_TudorB.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
        
            <asp:Label ID="LoginLabel" runat="server" Font-Size="Large" style="text-align: right" Text="Login:"></asp:Label>
            <br />
                    
            <asp:Label ID="emailLabel" runat="server" Text="Email" Width="100px" style="text-align: right"></asp:Label>
            <asp:TextBox ID="emaiLogntxtbx" runat="server" Width="230px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="emailValidator" runat="server" ControlToValidate="emaiLogntxtbx" ErrorMessage="User email is required" ForeColor="Red"></asp:RequiredFieldValidator>
        
            <br />
               
            <asp:Label ID="passwordLabel" runat="server" Text="Password " Width="100px" style="text-align: right"></asp:Label>
            <asp:TextBox ID="passLogntxtbx" runat="server" Width="230px" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ControlToValidate="passLogntxtbx" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
     
            <br />
          
            <asp:Button ID="loginbtn" runat="server" Text="Login" OnClick="btnLogin_Click" ToolTip="Press to Login" />
       
            <br />

         <asp:Label ID="LoginResultLabel" runat="server" Text=""></asp:Label>
             <br />
             <br />

           <div >  
         <asp:Label ID="RegisterLabel" runat="server" Font-Bold="False" Font-Size="Large" style="text-align: right" Text="Register:"></asp:Label>
            <br />
            <br />          
                <asp:Label ID="Label1" runat="server" style="text-align: right" Text="First Name:" Width="150px"></asp:Label>
                <asp:TextBox ID="firstNametxtbx" runat="server" Width="230px" ToolTip="First name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="fnamevalid" runat="server" ControlToValidate="firstNametxtbx" ErrorMessage="First name required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="namewronvalida" runat="server" ControlToValidate="firstNametxtbx" ErrorMessage="Characters only" ForeColor="Red" ValidationExpression="([A-Za-z])+( [A-Za-z]+)*"></asp:RegularExpressionValidator>           
                <br />
                <asp:Label ID="Label2" runat="server" style="text-align: right" Text="Surname:" Width="150px"></asp:Label>
                <asp:TextBox ID="surnameTxtbx" runat="server" Width="230px" ToolTip="Surname name"></asp:TextBox>                
                <asp:RequiredFieldValidator ID="snamevalid" runat="server" ControlToValidate="surnameTxtbx" ErrorMessage="Surname required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="surnwronvalida" runat="server" ControlToValidate="surnameTxtbx" ErrorMessage="Characters only" ForeColor="Red" ValidationExpression="([A-Za-z])+( [A-Za-z]+)*"></asp:RegularExpressionValidator>                  
                <br />
                <asp:Label ID="Label3" runat="server" style="text-align: right" Text="Email:" Width="150px"></asp:Label>
                <asp:TextBox ID="emalRegistertxtbx" runat="server" Width="230px" TextMode="Email" ToolTip="Enter email address"></asp:TextBox>                
                <asp:RequiredFieldValidator ID="emailregivalida" runat="server" ControlToValidate="emalRegistertxtbx" ErrorMessage="Email required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="emaiwronvalid" runat="server" ControlToValidate="emalRegistertxtbx" ErrorMessage="Invalid email format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>            
                <br />
                <asp:Label ID="Label5" runat="server" style="text-align: right" Text="Password:" Width="150px"></asp:Label>
                <asp:TextBox ID="regipasswTxtbx" runat="server" TextMode="Password" Width="230px" ToolTip="Insert password"></asp:TextBox>                
                <asp:RequiredFieldValidator ID="passwdfievalida" runat="server" ControlToValidate="regipasswTxtbx" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="strnthepasswvalidat" runat="server" ControlToValidate="regipasswTxtbx" ErrorMessage="Insert special character to strngthen the password" ForeColor="Red" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[\W]).{6,20})"></asp:RegularExpressionValidator>                 
                <br />
                <asp:Label ID="Label6" runat="server" style="text-align: right" Text="Confirm Password:" Width="150px"></asp:Label>
                <asp:TextBox ID="confirRegpasstxbx" runat="server" TextMode="Password" Width="230px" ToolTip="Insert password"></asp:TextBox>                
                <asp:RequiredFieldValidator ID="passwcompavali" runat="server" ControlToValidate="confirRegpasstxbx" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="passwRongcompvali" runat="server" ControlToCompare="regipasswTxtbx" ControlToValidate="confirRegpasstxbx" ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>                
                <br />
                <asp:Label ID="Label11" runat="server" style="text-align: right" Text="Postcode:" Width="150px"></asp:Label>
                <asp:TextBox ID="txtPostcode" runat="server" Width="230px" ToolTip="Insert your postcode"></asp:TextBox>              
                <asp:RequiredFieldValidator ID="poscodevalidat" runat="server" ControlToValidate="txtPostcode" ErrorMessage="Postcode required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="postcwronvali" runat="server" ControlToValidate="txtPostcode" ErrorMessage="Invalid Postcode" ForeColor="Red" ValidationExpression="^(([gG][cccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccciI][rR] {0,}0[aA]{2})|((([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y]?[0-9][0-9]?)|(([a-pr-uwyzA-PR-UWYZ][0-9][a-hjkstuwA-HJKSTUW])|([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y][0-9][abehmnprv-yABEHMNPRV-Y]))) {0,}[0-9][abd-hjlnp-uw-zABD-HJLNP-UW-Z]{2}))$"></asp:RegularExpressionValidator>        
                <br />
                <asp:Label ID="Label10" runat="server" style="text-align: right" Text="Address:" Width="150px"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" Width="230px" ToolTip="Insert your address"></asp:TextBox>               
                <asp:RequiredFieldValidator ID="addressvalidat" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address required" ForeColor="Red"></asp:RequiredFieldValidator>           
                <br />
                <asp:Label ID="Label8" runat="server" style="text-align: right" Text="Date of birth:" Width="150px"></asp:Label>
                <asp:TextBox ID="txtDob" runat="server" Width="230px" TextMode="Date" ToolTip="DD/MM/YYYY"></asp:TextBox>                
                <asp:RequiredFieldValidator ID="daofbivalid" runat="server" ControlToValidate="txtDob" ErrorMessage="Date of birth required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label9" runat="server" style="text-align: right" Text="Telephone:" Width="150px"></asp:Label>
                <asp:TextBox ID="txtPhone" runat="server" Width="230px" TextMode="Phone" ToolTip="Insert telephone number"></asp:TextBox>               
                <asp:RequiredFieldValidator ID="phonevalidato" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone number required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="phonewrovalidat" runat="server" ControlToValidate="txtPhone" ErrorMessage="Invalid phone number" ForeColor="Red" ValidationExpression="^(?:(?:\(?(?:0(?:0|11)\)?[\s-]?\(?|\+)44\)?[\s-]?(?:\(?0\)?[\s-]?)?)|(?:\(?0))(?:(?:\d{5}\)?[\s-]?\d{4,5})|(?:\d{4}\)?[\s-]?(?:\d{5}|\d{3}[\s-]?\d{3}))|(?:\d{3}\)?[\s-]?\d{3}[\s-]?\d{3,4})|(?:\d{2}\)?[\s-]?\d{4}[\s-]?\d{4}))(?:[\s-]?(?:x|ext\.?|\#)\d{3,4})?$"></asp:RegularExpressionValidator>            
                <br />
                <br />
                               
                <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" ToolTip="Press to register" />           
                <br />
                <asp:Label ID="RegisterResulLabel" runat="server" ></asp:Label>          
    </div>
       
    </div>
</asp:Content>
