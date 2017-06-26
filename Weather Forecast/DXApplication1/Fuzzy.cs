using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DXApplication1
{
    class Fuzzy
    {
        public void findMax(List<float> l, ref int t)
        {
            float max = -1;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] > max)
                {
                    max = l[i];
                    t = i;
                }
            }
        }
        public void F_temp(float x, ref string output)
        {
            List<float> temper = new List<float>();
            int _temp = -1;
            float cao = -1, thap = -1, trungbinh = -1;
            //Nhiet do cao
            if (x <= 25)
                cao = 0;
            if (25 < x && x < 30)
                cao = (x - 25) / 5;
            if (x >= 30)
                cao = 1;
            temper.Add(cao);
            //Nhiet do thap
            if (x <= 20) thap = 1;
            if (20 < x && x < 25) thap = (25 - x) / 5;
            if (x >= 25) thap = 0;
            temper.Add(thap);
            //MessageBox.Show(thap.ToString());
            //Nhiet do trung binh

            if (x <= 20) trungbinh = 0;
            if (20 < x && x <= 25) trungbinh = (x - 20) / 5;
            if (25 < x && x < 30) trungbinh = (30 - x) / 5;
            if (x >= 30) trungbinh = 0;
            temper.Add(trungbinh);
            findMax(temper, ref _temp);
            //

            if (_temp == 0)
                output = "Cao";
            if (_temp == 1)
                output = "Thap";
            if (_temp == 2)
                output = "TB";
            //MessageBox.Show(output.ToString());
        }
        public void F_Humid(float y, ref string s)
        {
            List<float> h = new List<float>();
            int _h = -1;
            float cao = -1, thap = -1;
            //Do am cao
            if (y == 0) cao = 0;
            if (0 < y && y < 70) cao = y / 70;
            if (y >= 70) cao = 1;
            h.Add(cao);
            //Do am thap
            if (y >= 70) thap = 0;
            if (0 < y && y < 70) thap = (70 - y) / 70;
            if (y == 0) thap = 1;
            h.Add(thap);
            findMax(h, ref _h);
            // MessageBox.Show(_h.ToString());
            if (_h == 0)
                s = "Cao";
            if (_h == 1)
                s = "Thap";
            //MessageBox.Show(s.ToString());


        }
        public void FileToRule(string[] linePart, string filetxt)
        {
            string filepath = "..//..//scr//Rule.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            linePart = filetxt.Split('.');
            int n = linePart.Length;
            try { 
            for (int i = 0; i < n - 1; i++)
            {
                string[] DataIn;
                string RuleT = "", RuleH = "", Rule;
                DataIn = linePart[i].Split(' ');
                //MessageBox.Show(DataIn[0]);
                int t = Int32.Parse(DataIn[0]);
                int h = Int32.Parse(DataIn[1]);
                //Mo hoa nhiet do
                F_temp(t, ref RuleT);
                //Mo hoa do am
                F_Humid(h, ref RuleH);
                //thiet lap luat
                Rule = RuleT + " " + RuleH + " " + DataIn[2] + " " + DataIn[3] + ".";
                //xuat ra file
                writer.WriteLine(Rule);

            }
            writer.Close();
            string RutGon_R;
            RutGon_R = File.ReadAllText("..//..//scr//Rule.txt");
            string filepathout = "..//..//scr//Rule.txt";
            File.Delete(filepath);
            FileStream Ro = new FileStream(filepathout, FileMode.Create);
            StreamWriter R_out = new StreamWriter(Ro);
            string[] line_R = RutGon_R.Split('.');
            List<string> l_rutgon_R = new List<string>();
            l_rutgon_R.Add(line_R[0]);
            for (int i = 1; i < line_R.Length - 1; i++)
            {
                int dem = 0;
                for (int j = 0; j < l_rutgon_R.Count; j++)
                    if (line_R[i] != l_rutgon_R[j])
                        dem++;
                if (dem == l_rutgon_R.Count)
                    l_rutgon_R.Add(line_R[i]);
            }
            for (int i = 0; i < l_rutgon_R.Count; i++)
            {
                string st = l_rutgon_R[i] + ".";
                R_out.Write(st);
            }
            R_out.Close();
        }
            catch (Exception e)
            {
                MessageBox.Show("File train error!", "Error");
            }
        }
    }
}
