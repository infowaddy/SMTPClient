using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPClient
{
    public partial class frmMain : Form
    {
        Serilog.Core.Logger log;
        string attachFile;
        public frmMain()
        {
            InitializeComponent();
            log = new LoggerConfiguration()
            .WriteTo.File("Logs\\log_.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        }

        private void lblAttach_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                
                SendMail(txtSubject.Text, txtTo.Text, webBody.DocumentText,                    
                    txtFrom.Text, comboServerName.Text,
                    txtPort.Text, chkRequiredSSL.Checked, 
                    txtUserName.Text, txtPassword.Text, attachFile);
                
                // log information
                if (attachFile.Trim().Length > 0)
                    log.Information("Email sending success to " + txtTo.Text + " with attach file " + attachFile);
                else
                    log.Information("Email sending success to " + txtTo.Text + " without attachment.");
                
                MessageBox.Show("Email send out ready! Check in your inbox " + txtTo.Text);
            }
            catch(Exception ex){
                log.Error(ex, "Error");
                MessageBox.Show("Email sending Fail! Check error in the log file.");
            }            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, this.Height + 100);
            List<string> smtpServers = new List<string>()
            {
                "smtp.gmail.com", // gmail SMTP server
                "smtp.live.com", // hotmail SMTP server
                "smtp.office365.com", // office365 SMTP server
                "192.168.122.251" // local relay SMTP server
            };
            
            comboServerName.DataSource = smtpServers;

            // decorate rich textbox control with html content
            webBody.DocumentText = "<html><body><p>This is <span style='color:blue;'>html</span> content.</p></body></html>";
            
        }

        public void SendMail(string subject, string to, string body,  
            string from, string SMTPServer, string SMTPPort, bool requiredSSL, 
            string userName, string password, string attachFileName)
        {
            try
            {
                MailMessage mail = new MailMessage(from, to, subject, body);
                mail.IsBodyHtml = true;
                if (attachFileName.Length > 0)
                {
                    Attachment attachment;
                    attachment = new Attachment(attachFileName);
                    mail.Attachments.Add(attachment);
                }
                SmtpClient client = new SmtpClient(SMTPServer, int.Parse(SMTPPort));
                client.DeliveryMethod = SmtpDeliveryMethod.Network; 
                client.UseDefaultCredentials = false;
                client.EnableSsl = requiredSSL;                
                client.Credentials = new System.Net.NetworkCredential(userName, password);
                
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void comboServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboServerName.SelectedItem.ToString().Contains(".com"))
            {
                txtPort.Text = "587"; // modern SMTP servers in market are using 587 TLS port
                chkRequiredSSL.Checked = true; // modern SMTP servers in market need SSL communication
            }
            else
            {
                txtPort.Text = "25"; // local SMTP port
                chkRequiredSSL.Checked = false; // assume local SMTP server is not required SSL communication 
            }

            txtFrom.Text = ""; // clear for new sender address
            txtUserName.Text = ""; // clear for new login user name
            txtPassword.Text = ""; // clear for new password
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            // Typically sender email shall be login user name except local SMTP relay server
            txtFrom.Text = txtUserName.Text; 
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                attachFile = dlgOpenFile.FileName;
                lblAttach.Text = Path.GetFileName(attachFile);
                log.Information(Path.GetFileName(lblAttach.Text) + " file was choosed for email attachement.");
            }
        }
    }

}
