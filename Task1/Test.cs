using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();

            questions = new List<Question>();
            Question.FillQuestions(questions);

            QuestionIndex = 0;
            NextQuestion(questions[QuestionIndex]);

            timer1.Start();
        }
        List<Question> questions;
        public sbyte Score = 0;
        private sbyte QuestionIndex;

        uint Time = 0;

        private void NextQuestion(Question question)
        {
            LQuastion.Text = question.Name;
            radioV1.Text = question.V1;
            radioV2.Text = question.V2;
            radioV3.Text = question.V3;
            radioV4.Text = question.V4;
            radioV1.Checked = radioV2.Checked = radioV3.Checked = radioV4.Checked = false;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (radioV1.Checked | radioV2.Checked | radioV3.Checked | radioV4.Checked)
            {
                if ((radioV1.Checked & questions[QuestionIndex].RightV == 1) |
                    (radioV2.Checked & questions[QuestionIndex].RightV == 2) |
                    (radioV3.Checked & questions[QuestionIndex].RightV == 3) |
                    (radioV4.Checked & questions[QuestionIndex].RightV == 4))
                {
                    Score++;
                }
                if (QuestionIndex + 1 < questions.Count)
                {
                    QuestionIndex++;
                    NextQuestion(questions[QuestionIndex]);
                }
                else {
                    timer1.Stop();
                    MessageBox.Show($"Ваш результат: {Score} балов из {questions.Count} за {Time.ToString()} секунд");
                    Close(); 
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
        }
    }
}
