using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using FreeNet;
using System.IO;
namespace CodeFight
{
    public partial class Form2 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        String userName = "Default";
        String enemyName = "Default";
        String moon = "Default";
        String qNum = "0";
        public Form2(String userName)
        {
            this.userName = userName;
            InitializeComponent();
            getJson();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void getJson()
        {
            while (get.a.Length == 0)
            {
                Delay(1);
            }
            string[] tmp = get.a.Split(' ');
            this.enemyName = tmp[0];
            this.moon = File.ReadAllText("/resource/" + tmp[1] + ".txt");
            this.qNum = tmp[1];
            setting();
        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
        public void setting()
        {
            user1.Text = userName;
            user2.Text = enemyName;
            questionBox.Text = moon;
            panel1.Visible = true;
        }

        private async void compileButton_ClickAsync(object sender, EventArgs e)
        {
            var nowLang = Convert.ToString(languege.SelectedIndex + 1);
            var source = textBox1.Text;
            var values = new Dictionary<string, string> { { "source", source }, { "qnum", qNum }, { "languege", nowLang } };
            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://114.202.56.161:5000", content);

            var responseString = await response.Content.ReadAsStringAsync();

            compilerResultBox.Text = responseString;
            if (compilerResultBox.Text.IndexOf("sucksex!!") == 0)
            {
                Socket_.post("win "+userName);
            }
        }

        private void giveup_Click(object sender, EventArgs e)
        {

        }
    }
    static public class get
    {
        public static string a = string.Empty;

    }
}