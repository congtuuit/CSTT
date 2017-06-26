using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DXApplication1
{
    class KNN
    {
        public void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        public void swaps(ref string a, ref string b)
        {
            string temp;
            temp = a;
            a = b;
            b = temp;
        }
        public void Cal_Humid(List<int> lh, ref int _h)
        {
            int temp = 0;
            int n = (lh.Count * 3) / 4;
            for (int i = 0; i < n; i++)
            {
                temp += lh[i];
            }
            _h = temp / n;
        }
        public void KhoangCach(int x, int y, ref int distan)
        {
            distan = Math.Abs(x - y);
        }
        public void FindMaxInList(List<int> l, ref int max, ref int vitri)
        {
            max = -1;
            vitri = -1;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] > max)
                {
                    max = l[i];
                    vitri = i;
                }
            }
        }
        public void SortT_H(ref List<int> t, ref List<int> h)
        {
            for (int i = 0; i < t.Count - 1; i++)
            {
                for (int j = i + 1; j < t.Count; j++)
                {
                    if (t[i] > t[j])
                    {
                        int t1 = t[i], t2 = t[j];
                        swap(ref t1, ref t2);
                        t[i] = t1; t[j] = t2;

                        int h1 = h[i], h2 = h[j];
                        swap(ref h1, ref h2);
                        h[i] = h1; h[j] = h2;
                    }
                }
            }
        }
        public void SortKC_FT(ref List<int> kc, ref List<string> ft, ref List<string> may, ref List<string> kq)
        {
            for (int i = 0; i < kc.Count - 1; i++)
            {
                for (int j = i + 1; j < kc.Count; j++)
                {
                    if (kc[i] > kc[j])
                    {
                        int t1 = kc[i], t2 = kc[j];
                        swap(ref t1, ref t2);
                        kc[i] = t1; kc[j] = t2;

                        string h1 = ft[i], h2 = ft[j];
                        swaps(ref h1, ref h2);
                        ft[i] = h1; ft[j] = h2;

                        string m1 = may[i], m2 = may[j];
                        swaps(ref m1, ref m2);
                        may[i] = m1; may[j] = m2;

                        string kq1 = kq[i], kq2 = kq[j];
                        swaps(ref kq1, ref kq2);
                        kq[i] = kq1; kq[j] = kq2;
                    }
                }
            }
        }
        //sap xep theo khoang cach nhiet do,-> list. file train

        public void SortAll_T(ref List<string> ft, ref List<string> fh, ref List<string> may, ref List<string> kq, ref List<int> kc, ref List<string> sortend)
        {

            string filepathout = "..//..//scr//Sort.txt";
            FileStream Ro = new FileStream(filepathout, FileMode.Create);
            StreamWriter R_out = new StreamWriter(Ro);
            for (int i = 0; i < kc.Count - 1; i++)
            {

                for (int j = i + 1; j < kc.Count; j++)
                {
                    if (kc[i] > kc[j])
                    {
                        int kc1 = kc[i], kc2 = kc[j];
                        swap(ref kc1, ref kc2);
                        kc[i] = kc1; kc[j] = kc2;

                        string t1 = ft[i], t2 = ft[j];
                        swaps(ref t1, ref t2);
                        ft[i] = t1; ft[j] = t2;

                        string h1 = fh[i], h2 = fh[j];
                        swaps(ref h1, ref h2);
                        fh[i] = h1; fh[j] = h2;

                        string m1 = may[i], m2 = may[j];
                        swaps(ref m1, ref m2);
                        may[i] = m1; may[j] = m2;

                        string kq1 = kq[i], kq2 = kq[j];
                        swaps(ref kq1, ref kq2);
                        kq[i] = kq1; kq[j] = kq2;
                    }
                }
                string tmps;
                tmps = ft[i] + "-" + fh[i] + "-" + may[i] + "-" + kq[i] + ".";
                sortend.Add(tmps);
                R_out.WriteLine(tmps);

            }
            R_out.Close();
        }

        public void Select_List_T(List<string> l_sortEnd, string fh, string fm, ref string kq, ref float _sum)
        {
            int n = (l_sortEnd.Count * 3) / 4;
            List<string> ls_doam = new List<string>();
            //dem so luong do am
            for (int i = 0; i <= n; i++)
            {
                string[] oneline = l_sortEnd[i].Split('-');
                Fuzzy mh = new Fuzzy();
                string f_h = "";
                int _h = Int32.Parse(oneline[1]);
                mh.F_Humid(_h, ref f_h);
                if (fh == f_h)
                {
                    string tm = "";
                    tm = oneline[1] + " " + oneline[2] + " " + oneline[3];
                    ls_doam.Add(tm);
                }
            }
            List<string> ls_M = new List<string>();
            for (int i = 0; i < (ls_doam.Count*2)/4; i++)
            {
                string[] oneline = ls_doam[i].Split(' ');
                if (fm == oneline[1])
                {
                    string tmps = "";
                    tmps = oneline[1] + " " + oneline[2];
                    ls_M.Add(tmps);
                }
            }
            List<string> ls_KQ = new List<string>();
            List<string> countKQ = new List<string>();
            string[] _kq = ls_M[0].Split(' ');
            ls_KQ.Add(_kq[1]);

            for (int i = 1; i < (ls_M.Count*2)/5; i++)
            {
                string[] tmps = ls_M[i].Split(' ');
                int dem = 0;
                for (int j = 0; j < ls_KQ.Count; j++)
                    if (tmps[1] != ls_KQ[j])
                        dem++;
                if (dem == ls_KQ.Count)
                    ls_KQ.Add(tmps[1]);
            }

            //kiem tra
            for (int i = 0; i < ls_M.Count; i++)
            {
                string[] tm = ls_M[i].Split(' ');
                countKQ.Add(tm[1]);
            }

            //MessageBox.Show(countKQ.Count.ToString(), "Tong KQ thu dc.");
            _sum = countKQ.Count;
            
            for (int i = 0; i < ls_KQ.Count; i++)
            {
                int dem = 0;
                for (int j = 0; j < countKQ.Count; j++)
                {
                    if (ls_KQ[i] == countKQ[j])
                        dem++;
                }
                if (dem > 0)
                {
                    kq = kq + dem.ToString() + " " + ls_KQ[i].ToString() ;
                }
                //MessageBox.Show(kq);
            }
        }

        public void TemperInput(int t, string file, ref int doam)
        {
            string[] line;
            List<int> l_khoangcach = new List<int>();
            List<int> h = new List<int>();
            line = file.Split('.');
            int kc = 0;
            int n = line.Length;
            for (int i = 0; i < n - 1; i++)
            {
                string[] DataIn;
                DataIn = line[i].Split(' ');
                int tem = Int32.Parse(DataIn[0]);
                int _h = Int32.Parse(DataIn[1]);
                KhoangCach(tem, t, ref kc);
                h.Add(_h);
                l_khoangcach.Add(kc);
            }

            SortT_H(ref l_khoangcach, ref h);
            doam = 0;
            Cal_Humid(h, ref doam);
        }
        public void InputT_H(int t, int h, string fm, string filetxt, ref string outputKQ, ref float _sum)
        {

            string filerule;
            filerule = File.ReadAllText("..//..//scr//Rule.txt");
            Fuzzy mh = new Fuzzy();
            string ft = "";
            string fh = "";
            mh.F_temp(t, ref ft);
            mh.F_Humid(h, ref fh);

            string[] line;
            List<int> l_khoangcach = new List<int>();
            List<string> lfh = new List<string>();
            List<string> lft = new List<string>();
            List<string> lfm = new List<string>();
            List<string> lfkq = new List<string>();
            List<string> lend = new List<string>();
            line = filetxt.Split('.');
            int kc = 0;
            int n = line.Length;
            for (int i = 0; i < n - 1; i++)
            {
                string[] DataIn;
                DataIn = line[i].Split(' ');
                int tem = Int32.Parse(DataIn[0]);
                KhoangCach(tem, t, ref kc);
                l_khoangcach.Add(kc);
                string d1 = tem.ToString();
                lft.Add(d1);
                lfh.Add(DataIn[1]);
                lfm.Add(DataIn[2]);
                lfkq.Add(DataIn[3]);
            }
            _sum = 0;
            SortAll_T(ref lft, ref lfh, ref lfm, ref lfkq, ref l_khoangcach, ref lend);
            Select_List_T(lend, fh, fm, ref outputKQ, ref _sum);
            //MessageBox.Show(outputKQ,_sum.ToString());

        }


    }
}
