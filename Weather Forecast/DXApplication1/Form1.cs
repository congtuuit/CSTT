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

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OpenFileDialog openf = new OpenFileDialog();
        SaveFileDialog Savef = new SaveFileDialog();
        StreamReader sr;
        string filetxt = "";
        string[] linePart1;
        bool flagL = false;//LOAD FILE
        string fm = "";
        public string address;
        public Form1()
        {
            InitializeComponent();
            KetQua_labelControl.Font = new Font(KetQua_labelControl.Font, FontStyle.Bold);
            //KetQua_labelControl.Font = FontStyle.Italic;
            string _sort = "..//..//scr//Sort.txt";
            string _rule = "..//..//scr//Rule.txt";
            string _train = "..//..//scr//Train.txt";
            string _gif = "..//..//pic//giphy.gif";
            if (File.Exists(_sort))
                System.IO.File.Delete(_sort);
            if (File.Exists(_rule))
                System.IO.File.Delete(_rule);
            if (File.Exists(_train))
            {
                filetxt = File.ReadAllText(_train);
                Fuzzy fin = new Fuzzy();
                fin.FileToRule(linePart1, filetxt);
                flagL = true;
            }
            if (File.Exists(_gif))
            {
                KetQua_pictureEdit.Image = Image.FromFile(_gif);
            }

        }

        private void Project_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("\tHỆ DỰ BÁO THỜI TIẾT\n\t  \n\n Giảng viên: Th.S Huỳnh Thị Thanh Thương");
        }

        private void Exit_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _sort = "..//..//scr//Sort.txt";
            string _rule = "..//..//scr//Rule.txt";
            if (File.Exists(_sort))
                System.IO.File.Delete(_sort);
            if (File.Exists(_rule))
                System.IO.File.Delete(_rule);
            Application.Exit();
          //  Environment.Exit(0);
        }

        private void Members_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Dương Thị Thúy Nga - 14520569\nNguyễn Quang Trung - 14521021\nVăn Công Tú - 14521037\nLê Đình Tuấn - 14521045");
        }

        private void ViewHelp_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void LoadFile_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openf.Filter = "TXT|*.txt";
            if (openf.ShowDialog() == DialogResult.OK)
            {
                filetxt = File.ReadAllText(openf.FileName);
                Fuzzy fin = new Fuzzy();
                fin.FileToRule(linePart1, filetxt);
                flagL = true;
            }
        }

        private void TraVeDoAm_Click(object sender, EventArgs e)
        {
            string var = NhietdoBox_textEdit.Text;
            if (flagL == true && var != "")
            {
                int nhiet = Int32.Parse(var);
                KNN k = new KNN();
                int _doam = 0;
                k.TemperInput(nhiet, filetxt, ref _doam);
                DoAmBox_textEdit.Text = _doam.ToString();
            }
            else MessageBox.Show("Input file train.","Message");
        }

        private void DuBao_simpleButton_Click(object sender, EventArgs e)
        {
            if (NhieuMay_radioButton.Checked || ItMay_radioButton.Checked)
            {
                boxM.Text = "";
                boxL.Text = "";
                boxMM.Text = "";
                boxN.Text = "";
            }
            if (flagL == true)
            {
                if (NhieuMay_radioButton.Checked || ItMay_radioButton.Checked)
                {
                    KNN kn = new KNN();
                    string kq = "";
                    float _sum = 0;
                    int t1 = Int32.Parse(NhietdoBox_textEdit.Text);
                    int h1 = Int32.Parse(DoAmBox_textEdit.Text);
                    if (ItMay_radioButton.Checked == true)
                        fm = "It";
                    else
                        fm = "Nhieu";
                    kn.InputT_H(t1, h1, fm, filetxt,ref kq, ref _sum);
                    //MessageBox.Show(kq, _sum.ToString());

                    string[] outline = kq.Split('.');
                    float number = 0;
                    
                    for (int i = 0; i < outline.Length - 1; i++)
                    {
                        string[] re_kq = outline[i].Split(' ');
                        
                        for (int j = 0; j < re_kq.Length; j++)
                        {
                            //MessageBox.Show
                            if (re_kq[j].Equals("Nang"))
                            {
                                number = Int32.Parse(re_kq[0]);
                                number= (number*100)/_sum;
                                string x = string.Format("{0:0.##}", number);
                                boxN.Text = x;
                            }
                            if (re_kq[j].Equals("MatMe"))
                            {
                                number = Int32.Parse(re_kq[0]);
                                number = (number * 100) / _sum;
                                string x = string.Format("{0:0.##}", number);
                                boxMM.Text = x;
                            }
                            if (re_kq[j].Equals("Mua"))
                            {
                                number = Int32.Parse(re_kq[0]);
                                number = (number * 100) / _sum;
                                string x = string.Format("{0:0.##}", number);
                                boxM.Text = x;
                            }
                            if (re_kq[j].Equals("Lanh"))
                            {
                                number = Int32.Parse(re_kq[0]);
                                number = (number * 100) / _sum;
                                string x = string.Format("{0:0.##}", number);
                                boxL.Text = x;
                            }
                        }
                    }
                    string _boxN, _boxM, _boxMM, _boxL;
                    //float n, m, mm, l;
                    _boxN = boxN.Text;
                    _boxM = boxM.Text;
                    _boxL = boxL.Text;
                    _boxMM = boxMM.Text;
                    List<float> ls1 = new List<float>();
                    List<string> ls2 = new List<string>();
                    if (!_boxN.Equals(""))
                    {
                        ls1.Add(float.Parse(_boxN));
                        ls2.Add("N");
                    }
                    if (!_boxM.Equals(""))
                    {
                        ls1.Add(float.Parse(_boxM));
                        ls2.Add("M");
                    }

                    if (!_boxMM.Equals(""))
                    {
                        ls1.Add(float.Parse(_boxMM));
                        ls2.Add("MM");
                    }
                    if (!_boxL.Equals(""))
                    {
                        ls1.Add(float.Parse(_boxL));
                        ls2.Add("L");
                    }
                    float max = -1;
                    string stt = "";
                    int flg = 0;
                    for (int i = 0; i < ls1.Count; i++)
                    {
                        if (ls1[i] > max)
                        {
                            max = ls1[i];
                            stt = ls2[i];
                            flg = i;
                        }
                        
                    }
                    //set pic
                    if (stt.Equals("N"))
                        KetQua_pictureEdit.Image = Image.FromFile("../../pic/n.gif");
                    if (stt.Equals("L"))
                        KetQua_pictureEdit.Image = Image.FromFile("../../pic/l.gif");
                    if (stt.Equals("MM"))
                        KetQua_pictureEdit.Image = Image.FromFile("../../pic/MM.gif");
                    if (stt.Equals("M"))
                        KetQua_pictureEdit.Image = Image.FromFile("../../pic/m.gif");
                    //MessageBox.Show(ls1[0].ToString());
                    //MessageBox.Show(stt.ToString());
                    chart.Checked = false;
                    chartGra.Visible = false;
                }
                else MessageBox.Show("Not enough information", "MESSAGE");
            }
            else MessageBox.Show("Input file train.", "MESSAGE");
        }

        private void chart_CheckedChanged(object sender, bool v)
        {
            throw new NotImplementedException();
        }

        private void New_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhietdoBox_textEdit.Text = "";
            DoAmBox_textEdit.Text = "";
            boxM.Text = "";
            boxL.Text = "";
            boxMM.Text = "";
            boxN.Text = "";
            ItMay_radioButton.Checked = false;
            NhieuMay_radioButton.Checked = false;
            string _sort = "..//..//scr//Sort.txt";
            string _rule = "..//..//scr//Rule.txt";
            string _gif = "..//..//pic//giphy.gif";
            if (File.Exists(_sort))
                System.IO.File.Delete(_sort);
            if (File.Exists(_rule))
                System.IO.File.Delete(_rule);
            if (File.Exists(_gif))
                KetQua_pictureEdit.Image = Image.FromFile(_gif);
        }

        private void NhieuMay_labelControl_Click(object sender, EventArgs e)
        {
            NhieuMay_radioButton.Checked = true;
            ItMay_radioButton.Checked = false;
            boxM.Text = "";
            boxL.Text = "";
            boxMM.Text = "";
            boxN.Text = "";
        }

        private void ItMay_labelControl_Click(object sender, EventArgs e)
        {
            NhieuMay_radioButton.Checked = false;
            ItMay_radioButton.Checked = true;
            boxM.Text = "";
            boxL.Text = "";
            boxMM.Text = "";
            boxN.Text = "";
            
        }

        private void chart_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _boxN, _boxM, _boxMM, _boxL;
            //int n, m, mm, l;
            _boxN=boxN.Text;
            _boxM = boxM.Text;
            _boxL = boxL.Text;
            _boxMM = boxMM.Text;
           
           // MessageBox.Show(_boxM.ToString());
            if (chart.Checked)
            {
                if (!_boxN.Equals(""))
                    this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Nắng", _boxN);
                else this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Nắng", 0);

                if (!_boxM.Equals(""))
                    this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Mưa", _boxM);
                else this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Mưa", 0);

                if (!_boxMM.Equals(""))
                    this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Mát mẻ", _boxMM);
                else this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Mát mẻ", 0);

                if (!_boxL.Equals(""))
                    this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Lạnh", _boxL);
                else this.chartGra.Series["Phần trăm (%)"].Points.AddXY("Lạnh", 0);
                chartGra.Visible = true;
            }
            else
            {
                chartGra.Visible = false;
                this.chartGra.Series["Phần trăm (%)"].Points.Clear();
                
            }

        }

        private void Explain_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _sort = "..//..//scr//Sort.txt";
            if (File.Exists(_sort))
                System.Diagnostics.Process.Start("notepad.exe", @_sort);
            else
                MessageBox.Show("Không tìm thấy file.!!!", "MESSAGE");
        }
    }
}
