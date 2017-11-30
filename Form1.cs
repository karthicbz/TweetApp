using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace Tweetapp
{
    public partial class Form1 : Form
    {
        AppHearth ah;
        public Form1()
        {
            InitializeComponent();
            Auth.SetUserCredentials("Pybn9D6ffBaVMqxa9cNuWM5No", "99lJWXWzUFB64CsCPIkMVoj7JmEqVlairCFDAdmYXB3GOyoXcS",
                "550611451-Z0JhUFtZmP6aiC4nhYn9MPqLuNkvkWhksl9l5xM4", "Qeh4vOdcgvETxdjv3pTeTSK7uUp4xJqCKUQB6Ja4BPPJp");
            var user = User.GetAuthenticatedUser();
            ah = new AppHearth();
            displayTweet();
        }

        public void displayTweet()
        {
            label3.Text = ah.ReturnDefaultTweet;
            //listView1.Items.Add(ah.returnDefaultTweet());
            /*tweetDisplayBox.AppendText(ah.returnDefaultTweet());
            tweetDisplayBox.AppendText(Environment.NewLine);*/
            
        }

        private void showTweetButton_Click(object sender, EventArgs e)
        {
            ah.Name = textBox1.Text;
            label1.Text = "Now showing searched user tweets";
            /*tweetDisplayBox.Clear();
            tweetDisplayBox.AppendText(ah.searchedTweet());
            tweetDisplayBox.AppendText(Environment.NewLine);*/
            //listView1.Items.Add(ah.searchedTweet());
            label3.Text = ah.SearchedTweet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "Now showing default Timeline";
            //listView1.Items.Clear();
            //listView1.Items.Add(ah.returnDefaultTweet());
            //tweetDisplayBox.Text = ah.returnDefaultTweet();
            label3.Text = ah.ReturnDefaultTweet;
        }
    }
}
