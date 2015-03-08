using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Threading;

namespace ScratchIO
{
    public partial class MainForm : Form
    {
        List<WeatherInfo> WeatherInfoList=new List<WeatherInfo>();
        String LocationName, LocationEnglishName;
        String WeatherUrl, UltraVioletUrl;

        public MainForm()
        {
            InitializeComponent();

            Init();
        }
        
        void Init()
        {
           // WeatherInfo Info;
            String HomeUrl = "http://www.cwb.gov.tw/V7/observe/24real/Data/";
            WeatherInfoList.Add(new WeatherInfo("臺北", "Taipei", HomeUrl + "46692.htm"));
            WeatherInfoList.Add(new WeatherInfo("新竹", "Hsinchu", HomeUrl + "46757.htm"));
            WeatherInfoList.Add(new WeatherInfo("臺中", "Taichung", HomeUrl + "46749.htm"));
            WeatherInfoList.Add(new WeatherInfo("嘉義", "Chiayi", HomeUrl + "46748.htm"));
            WeatherInfoList.Add(new WeatherInfo("臺南", "Tainan", HomeUrl + "46741.htm"));
            WeatherInfoList.Add(new WeatherInfo("高雄", "Kaohsiung", HomeUrl + "46744.htm"));
            WeatherInfoList.Add(new WeatherInfo("恆春", "Pingtung", HomeUrl + "46759.htm"));
            WeatherInfoList.Add(new WeatherInfo("宜蘭", "Yilan", HomeUrl + "46708.htm"));
            WeatherInfoList.Add(new WeatherInfo("花蓮", "Hualien", HomeUrl + "46699.htm"));
            WeatherInfoList.Add(new WeatherInfo("臺東", "Taitung", HomeUrl + "46766.htm"));

            foreach (WeatherInfo Info in WeatherInfoList)
            {
                cbLocation.Items.Add(Info.LocationName);
            }

            cbLocation.Text = WeatherInfoList[0].LocationName;
            //LocationName = WeatherInfoList[0].LocationName;
            //LocationEnglishName = WeatherInfoList[0].LocationEnglishName;
            //WeatherUrl = WeatherInfoList[0].WeatherUrl;
            UltraVioletUrl = "http://www.cwb.gov.tw/V7/observe/UVI/UVI.htm";

            toolStripMessage.Text = "OK";
        }

        private void DownloadWeatherInfo()
        {
            // 氣象報告
            tbReportTime.Text = "無資料";
            tbReportTemperature.Text = "無資料";
            tbReportHumidity.Text = "無資料";
            tbReportWindDir.Text = "無資料";
            tbReportWindSpeed.Text = "無資料";
            tbReportRain.Text = "無資料";
            try
            {
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(WeatherUrl));

                // 使用預設編碼讀入 HTML
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(ms, Encoding.UTF8);

                // 裝載第一層查詢結果
                HtmlAgilityPack.HtmlDocument docReportContext = new HtmlAgilityPack.HtmlDocument();

                docReportContext.LoadHtml(doc.DocumentNode.SelectSingleNode("/table[1]").InnerHtml);

                tbReportTime.Text = docReportContext.DocumentNode.SelectSingleNode(String.Format("./tr[2]/th[1]")).InnerText;
                tbReportTemperature.Text = docReportContext.DocumentNode.SelectSingleNode(String.Format("./tr[2]/td[1]")).InnerText;
                tbReportWindDir.Text = docReportContext.DocumentNode.SelectSingleNode(String.Format("./tr[2]/td[4]")).InnerText;
                char[] SplitChar = { '|' };
                tbReportWindSpeed.Text = docReportContext.DocumentNode.SelectSingleNode(String.Format("./tr[2]/td[5]")).InnerText.Split(SplitChar)[0];
                tbReportHumidity.Text = docReportContext.DocumentNode.SelectSingleNode(String.Format("./tr[2]/td[8]")).InnerText;
                tbReportRain.Text = docReportContext.DocumentNode.SelectSingleNode(String.Format("./tr[2]/td[10]")).InnerText;

                //tbMessage.Text += DateTime.Now.ToString() + " 讀取氣象局資料成功" + Environment.NewLine;
            }
            catch
            {
                toolStripMessage.Text = DateTime.Now.ToString() + " 讀取氣象資料失敗";
            }

            // 紫外線
            tbReportUltraViolet.Text = "無資料";
            try
            {
                // 氣象局Url
                string Url = String.Format(UltraVioletUrl);

                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(Url));

                // 使用預設編碼讀入 HTML
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(ms, Encoding.UTF8);

                // 裝載第一層查詢結果
                HtmlAgilityPack.HtmlDocument docReportContext = new HtmlAgilityPack.HtmlDocument();

                //docReportContext.LoadHtml(doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[3]/div[2]/div[1]/div[2]").InnerHtml);
                docReportContext.LoadHtml(doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[4]/div[2]/div[1]/div[2]").InnerHtml);

                String strUltraViolet = docReportContext.DocumentNode.SelectSingleNode(String.Format(".")).InnerText;
                String strLocation = LocationName+" 紫外線指數 :";
                int ReportIndex = strUltraViolet.IndexOf(strLocation) + strLocation.Length;
                tbReportUltraViolet.Text = Convert.ToInt16(strUltraViolet.Substring(ReportIndex, 3).Trim()).ToString();

                //tbMessage.Text += DateTime.Now.ToString() + " 讀取氣象局資料成功" + Environment.NewLine;
            }
            catch
            {
                toolStripMessage.Text = DateTime.Now.ToString() + " 讀取紫外線資料失敗";
            }

            SendToScratch();
        }

        public class WeatherInfo
        {
            public String LocationName, LocationEnglishName;
            public String WeatherUrl;
 
            public WeatherInfo(String LocationName, String LocationEnglishName, String WeatherUrl)
            {
                this.LocationName = LocationName;
                this.WeatherUrl = WeatherUrl;
                this.LocationEnglishName = LocationEnglishName;
            }
        }

        String GetData(String Report)
        {
            if (Report == "儀器調校中")
            {
                return "Maintain";
            }
            else if (Report == "儀器故障")
            {
                return "Failure";
            }
            else if (Report == "無資料")
            {
                return "NoData";
            }
            else if (Report == "靜風")
            {
                return "NoWind";
            }
            return Report;
        }

        private void SendToScratch()
        {
            bool Fail = false;
            int Delay = 50;

            try
            {
                String VarName="CWB_TIME";
                String Data = "M"+tbReportTime.Text.Replace("/", "D").Replace(" ", "H").Replace(":", "M");
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient(); 
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch{
                Fail = true;
            }
            Thread.Sleep(Delay);

            try
            {
                String VarName = "CWB_LOCATION";
                String Data = LocationEnglishName;
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                Fail = true;
            }
            Thread.Sleep(Delay);

            try
            {
                String VarName = "CWB_TEMPERATURE";
                String Data = GetData(tbReportTemperature.Text);
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                Fail = true;
            }
            Thread.Sleep(Delay);

            try
            {
                String VarName = "CWB_HUMIDITY";
                String Data = GetData(tbReportHumidity.Text);
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                Fail = true;
            }

            try
            {
                String VarName = "CWB_WDIR";
                String Data = GetData(tbReportWindDir.Text).Replace("東", "E").Replace("西", "W").Replace("南", "S").Replace("北", "N");
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                Fail = true;
            }
            Thread.Sleep(Delay);

            try
            {
                String VarName = "CWB_WSPEED";
                String Data = GetData(tbReportWindSpeed.Text);
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                Fail = true;
            }
            Thread.Sleep(Delay);

            try
            {
                String VarName = "CWB_UV";
                String Data = GetData(tbReportUltraViolet.Text);
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                Fail = true;
            }
            Thread.Sleep(Delay);

            try
            {
                String VarName = "CWB_RAIN";
                String Data = GetData(tbReportRain.Text);
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001/vars-update=" + VarName + "=" + Data;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                Fail = true;
            }
            Thread.Sleep(Delay);

            // Broadcast
            String BroadCast = (Fail) ? "CWB_FAIL" : "CWB_UPDATE";
            try
            {
                String DataUrl = "http://" + tbScratchAddress.Text + ":42001//broadcast=" + BroadCast;
                WebClient client = new WebClient();
                MemoryStream ms = new MemoryStream(client.DownloadData(DataUrl));
            }
            catch
            {
                
            }
            Thread.Sleep(Delay);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripMessage.Text = "最近傳送時間 : " + DateTime.Now.ToString(); 
            DownloadWeatherInfo();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                tbScratchAddress.Enabled = false;
                tbUpdatePeriod.Enabled = false;
                timer.Interval = Convert.ToInt32(tbUpdatePeriod.Text) * 1000;
                timer.Enabled = true;
                toolStripMessage.Text = DateTime.Now.ToString() + " 開始傳送";
                btnStart.Text = "停止";
               // DownloadWeatherInfo(); //第一次先抓資料
            }
            else
            {
                timer.Enabled = false;
                btnStart.Text = "起動";
                toolStripMessage.Text = DateTime.Now.ToString() + " 停止傳送";
                tbScratchAddress.Enabled = true;
                tbUpdatePeriod.Enabled = true;
            }
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool state = timer.Enabled;
            timer.Enabled = false;

            int Index = cbLocation.SelectedIndex;
            LocationName = WeatherInfoList[Index].LocationName;
            LocationEnglishName = WeatherInfoList[Index].LocationEnglishName;
            WeatherUrl   = WeatherInfoList[Index].WeatherUrl;
            toolStripMessage.Text = DateTime.Now.ToString() + "  地點:" + LocationName;
            DownloadWeatherInfo();

            timer.Enabled = state;
        } 
 
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm Help = new HelpForm();

            Help.ShowDialog();
        }

    }
}
