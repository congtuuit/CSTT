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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string _qa = "..//..//scr//Questions.txt";
            string _ans = "..//..//scr//Answers.txt";
            List<QA> questions = new List<QA>();

            if (File.Exists(_qa) && File.Exists(_ans))
            //tạo 1 đối tượng luồng đọc để đọc file Student.txt trong đường dẫn tương đối hiện tại của ứng dụng
            {
                System.IO.StreamReader QuestionReader = new System.IO.StreamReader(_qa);
                System.IO.StreamReader AnswerReader = new System.IO.StreamReader(_ans);
                //mỗi lần đọc 1 dòng trên file text và nếu đọc được sẽ lưu vào chuỗi line
                
                string Qline = QuestionReader.ReadToEnd();
                string Aline = AnswerReader.ReadToEnd();
                string[] qu = Qline.Split('#');
                string[] ans = Aline.Split('#');

                for (int i = 0; i < qu.Length; i++)
                {
                    QA question = new QA();

                    question.Question = qu[i];

                    question.Answer = ans[i];

                    questions.Add(question);
                }

                //bỏ danh sách student vào source của combobox để hiển thị
                QuestionBox.DataSource = questions;
                //khai báo combobox sẽ hiển thị lên cái gì
                QuestionBox.DisplayMember = "Question";
            }
            else
                MessageBox.Show("Q&A Box is not completed.");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QA selectedQues = (QA)QuestionBox.SelectedItem;

            //hiển thị thông tin lên label
            AnswerBox.Text = selectedQues.ToString();
        }
    }
}
