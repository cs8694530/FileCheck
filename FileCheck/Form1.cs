using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
}

        List<string[]> Sample = new List<string[]>();
        List<string[]> Examine = new List<string[]>();
        List<string[]> CompareResult_Failing = new List<string[]>();
        List<string[]> CompareResult_Extra = new List<string[]>();

        #region Choose File Path
        private string GetFilePath()
        {
            OpenFileDialog File = new OpenFileDialog();
            // Csv File Filter
            File.Filter = "Csv File(*.csv)|*.csv";
            File.ShowDialog();
            return File.FileName;
        }
        #endregion
        
        #region Get Csv File columns Max Count

        private int GetMaxColumnsCount(string Path)
        {
            int MaxCount = 0;
            using (StreamReader Reader = new StreamReader(Path))
            {
                using (CsvHelper.CsvReader CSVReader = new CsvHelper.CsvReader(Reader, System.Globalization.CultureInfo.InvariantCulture))
                {
                    while (CSVReader.Read())
                    {
                        int i = 0;

                        while (true)
                        {
                            try
                            {
                                CSVReader.GetField(i);
                                i++;
                            }
                            catch
                            {
                                break;
                            }
                        }
                        if (i > MaxCount) MaxCount = i;
                    }
                }
            }

            TextBox_ColumnCount.Text = MaxCount.ToString();

            return MaxCount;
        }

        #endregion
    
        #region Source Data Convert To Object (CSV Format)
        private List<string[]> CSVConvertToClass(string Path,int count) 
        {
            List<string[]> Result = new List<string[]>();

            using (StreamReader Reader = new StreamReader(Path))
            using (CsvHelper.CsvReader CSVReader = new CsvHelper.CsvReader(Reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                bool CheckFlag = false;
                while (CSVReader.Read())
                {
                    try 
                    {
                        string[] Data = new string[count];
                        for (int i = 0; i < count; i++) 
                        {
                            Data[i] = CSVReader.GetField(i);
                        }
                        Result.Add(Data);
                        CheckFlag = true;
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
                if (!CheckFlag) 
                {
                    MessageBox.Show("解析資料失敗");
                    Result.Clear();
                }
            }

            return Result;
        }
        #endregion

        #region Compare Data
        private void CompareData(List<string[]> Data_A, List<string[]> Data_B, CheckedListBox.CheckedIndexCollection CheckItems) 
        {
            CompareResult_Failing = new List<string[]>();
            CompareResult_Extra = new List<string[]>();

            // A Only
            List<string[]> FailingData = new List<string[]>();
            // B Only
            List<string[]> ExtraData = new List<string[]>();

            foreach (int ItemsNo in CheckItems)
            {
                foreach (string[] data_a in Data_A)
                {
                    bool Check = false;
                    foreach (string[] data_b in Data_B)
                    {
                        if (Array.IndexOf<string>(data_b, data_a[ItemsNo]) != -1)
                        {
                            Check = true;
                            break;
                        }
                    }

                    if (!Check)
                    {
                        if (FailingData.IndexOf(data_a) == -1)
                        {
                            FailingData.Add(data_a);
                        }
                    }
                }


                foreach (string[] data_b in Data_B)
                {
                    bool Check = false;
                    foreach (string[] data_a in Data_A)
                    {
                        if (Array.IndexOf<string>(data_a, data_b[ItemsNo]) != -1)
                        {
                            Check = true;
                            break;
                        }
                    }

                    if (!Check)
                    {
                        if (ExtraData.IndexOf(data_b) == -1)
                        {
                            ExtraData.Add(data_b);
                        }
                    }
                }
            }

            CompareResult_Failing = FailingData;
            CompareResult_Extra = ExtraData;
        }

        #endregion

        #region Update Data Gird View
        private void UpdateResult(List<string[]> Data1 = null, List<string[]> Data2 = null)
        {
            this.DataGridView_Result.Rows.Clear();
            this.DataGridView_Result.Columns.Clear();

            if (!((Data1 == null) || (Data1.Count == 0)) || !((Data2 == null) || (Data2.Count == 0)))
            {
                foreach (string column in Sample[0])
                {
                    this.DataGridView_Result.Columns.Add(column, column);
                }

                if (!((Data1 == null) || (Data1.Count == 0)))
                {
                    foreach (string[] data in Data1)
                    {
                       int count = this.DataGridView_Result.Rows.Add(data);
                       this.DataGridView_Result.Rows[count].DefaultCellStyle.BackColor = Color.SkyBlue;
                    }
                }
                if (!((Data2 == null) || (Data2.Count == 0)))
                {
                    foreach (string[] data in Data2)
                    {
                        int count = this.DataGridView_Result.Rows.Add(data);
                        this.DataGridView_Result.Rows[count].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
        #endregion

        #region UI Event
        private void Button_Sample_Click(object sender, EventArgs e)
        {
            CheckedListBox_CheckField.Items.Clear();
            Label_SamplePath.Text = string.Empty;

            Sample = new List<string[]>();

            int ColumnCount;
            if (!Int32.TryParse(TextBox_ColumnCount.Text, out ColumnCount) && !CheckBox_AutoSize.Checked)
            {
                MessageBox.Show("欄位數量無法轉成數字_1");
                return;
            }
            else
            {
                UpdateResult();
                string path = GetFilePath();
                if (path == null || path == string.Empty)
                {
                    return;
                }
                Label_SamplePath.Text = path;

                if (CheckBox_AutoSize.Checked)
                {
                    ColumnCount = GetMaxColumnsCount(Label_SamplePath.Text);
                }

                Sample = CSVConvertToClass(Label_SamplePath.Text, ColumnCount);
            }

            if (Sample.Count != 0)
            {
                CheckedListBox_CheckField.Items.AddRange(Sample[0]);
            }
        }

        private void Button_Examine_Click(object sender, EventArgs e)
        {
            Label_ExaminePath.Text = string.Empty;

            Examine = new List<string[]>();

            int ColumnCount;
            if (!Int32.TryParse(TextBox_ColumnCount.Text, out ColumnCount) && !CheckBox_AutoSize.Checked)
            {
                MessageBox.Show("欄位數量無法轉成數字_2");
                return;
            }
            else
            {
                UpdateResult();
                string path = GetFilePath();
                if (path == null || path == string.Empty)
                {
                    return;
                }
                Label_ExaminePath.Text = path;

                if (CheckBox_AutoSize.Checked)
                {
                    ColumnCount = GetMaxColumnsCount(Label_ExaminePath.Text);
                }

                Examine = CSVConvertToClass(Label_ExaminePath.Text, ColumnCount);
            }
        }

        private void Button_Action_Click(object sender, EventArgs e)
        {
            UpdateResult();

            if (Sample.Count == 0)
            {
                MessageBox.Show("標準資料為空");
            }
            else if (Examine.Count == 0)
            {
                MessageBox.Show("檢查資料為空");
            }
            else if (CheckedListBox_CheckField.CheckedIndices.Count == 0)
            {
                MessageBox.Show("沒有選擇比對的項目");
            }
            else if (!Int32.TryParse(TextBox_ColumnCount.Text, out int ColumnCount))
            {
                MessageBox.Show("轉換欄位數量失敗_3");
            }
            else
            {
                CompareData(Sample, Examine, CheckedListBox_CheckField.CheckedIndices);
                UpdateResult(CompareResult_Failing, CompareResult_Extra);
            }
        }

        private void Button_Remit_Click(object sender, EventArgs e)
        {
            if (CompareResult_Extra.Count == 0 && CompareResult_Failing.Count == 0)
            {
                DialogResult CheckResult = MessageBox.Show("目前比較結果是空的，還要生成文件嗎", "啊我就沒資料阿", MessageBoxButtons.YesNo);
                if (CheckResult != DialogResult.Yes)
                {
                    return;
                }               
            }

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string Time = new DateTimeOffset(DateTime.Now, new TimeSpan(8, 0, 0)).ToString("yyyyMMdd_HHmmss");
                string ServerName;
                string UserName;
                string IPList;

                try
                {
                    ServerName = Environment.MachineName;
                }
                catch (Exception ex)
                {
                    ServerName = ex.Message;
                }

                try
                {
                    UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                }
                catch (Exception ex)
                {
                    UserName = ex.Message;
                }

                try
                {
                    IPList = string.Join(" , ", System.Net.Dns.GetHostAddresses(Environment.MachineName).Select(i => i.ToString()).ToArray());
                }
                catch (Exception ex)
                {
                    IPList = ex.Message;
                }

                string FilePath = Path.Combine(folderBrowser.SelectedPath, Time +".txt");
                StreamWriter sw = new StreamWriter(FilePath);

                sw.WriteLine($"這是比對csv的結果紀錄檔案\n");
                sw.WriteLine($"比對時間: {Time}");
                sw.WriteLine($"執行主機名稱: {ServerName}");
                sw.WriteLine($"登入使用者帳號: {UserName}");
                sw.WriteLine($"IP列表: {IPList}");
                sw.WriteLine($"標準檔案路徑: {Label_SamplePath.Text}");
                sw.WriteLine($"檢查檔案路徑: {Label_ExaminePath.Text}");

                sw.WriteLine("\n-- 標準有，檢查沒有 --\n");

                string columnstring = string.Empty;
                string underlinestring = string.Empty;

                if (Sample.Count() > 0)
                {
                    foreach (string s in Sample[0])
                    {
                        columnstring += $"{s,-100}";
                        underlinestring += $"{"----------",-100}";
                    }
                }
                
                if (CompareResult_Failing.Count != 0)
                {
                    sw.WriteLine(columnstring);
                    sw.WriteLine(underlinestring);

                    foreach (string[] sa in CompareResult_Failing)
                    {
                        string stemp = string.Empty;
                        foreach (string s in sa)
                        {
                            stemp += $"{ s,-100}";
                        }
                        sw.WriteLine(stemp);
                    }
                }

                sw.WriteLine("\n-- 標準沒有，檢查有 --\n");
                if (CompareResult_Extra.Count != 0)
                {
                    sw.WriteLine(columnstring);
                    sw.WriteLine(underlinestring);

                    foreach (string[] sa in CompareResult_Extra)
                    {
                        string stemp = string.Empty;
                        foreach (string s in sa)
                        {
                            stemp += $"{s,-100}";
                        }
                        sw.WriteLine(stemp);
                    }
                }
                sw.Close();
                Label_RemitPath.Text = FilePath;
                MessageBox.Show($"已生成 {FilePath}");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = FilePath;
                process.Start();
            }
            
        }

        private void CheckBox_AutoSize_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_AutoSize.Checked)
            {
                TextBox_ColumnCount.Enabled = false;
            }
            else if (!CheckBox_AutoSize.Checked)
            {
                TextBox_ColumnCount.Enabled = true;
            }
        }

        #endregion

    }
}
