using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticExerciser
{
    public partial class Form1 : Form
    {
        //枚举所有的运算类型
        private enum OpType:byte
        {
            ADD, SUB, MUL, DIV
        }

        private int number1, number2, result;//操作数和运算结果
        private OpType op;      //运算操作符
        private int range;     //数字范围
        private int point, cur, total;//测验时的得分，当前题号，总题数
        private int correctRate
        {
            get { return (int)(point * 100.0 / cur); }
        }
        private bool submited = true;  //避免重复提交刷分

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //下一题
            Next();
        }

        private void Next()
        {
            try
            {
                //若开启测验
                if (cbTest.Checked)
                {
                    if (cur < total)
                        grbTest.Text = "测验(" + ++cur + "/" + total + ")";
                    else
                    {
                        timCountdown.Enabled = false;
                        TestOver();    //结束测试
                        return;
                    }
                }
                //随机获取一个运算类型,获取数字范围
                op = getRandomType();
                range = getCurRange();
                //根据类型生成不同的操作数和答案
                switch (op)
                {
                    case OpType.ADD: GenerateForAdd(); break;
                    case OpType.SUB: GenerateForSub(); break;
                    case OpType.MUL: GenerateForMul(); break;
                    case OpType.DIV: GenerateForDiv(); break;
                }
                //展示题目
                lblProblem.Text = "题目:" + number1
                    + (new char[] { '+', '-', '*', '÷' }[(byte)op])
                    + number2 + "=?";
                submited = false;
                //清空答案框和正确答案
                lblAnswer.Text = "";
                txtAnswer.BackColor = Color.White;
                txtAnswer.Text = "";
                txtAnswer.Focus();
                if (cbTime.Checked)
                    CountDown();    //开启倒计时
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CountDown()
        {
            //初始化时间条
            pgbTime.Value = pgbTime.Maximum = (int)numCountdown.Value * 10;
            //开启倒计时
            timCountdown.Enabled = true;
        }

        private void GenerateForDiv()
        {
            //先生成乘积
            do
            {
                GenerateForMul();
            } while (number2 == 0); //避免除数为零
            //交换乘数与商
            int t = number1;
            number1 = result;
            result = t;
        }

        private void GenerateForMul()
        {
            int count = 0;
            Random r = new Random();
            //先给2个乘数一随机值
            number1 = r.Next(range);
            number2 = r.Next(range);
            //如果乘积超过range，则对其中一数随机缩小范围
            while (IsBeyondRange(number1, number2))
            {   
                if(count++ % 2 == 0)
                    number1 = r.Next(number1);
                else
                    number2 = r.Next(number2);
            }
            result = number1 * number2;
        }

        private bool IsBeyondRange(int mul1, int mul2)
        {
            //避免乘法溢出，先通过位数初步判断是否一定超过range
            //乘数位数之和-1≤乘积的位数≤乘数位数之和
            if(mul1.ToString().Length + mul2.ToString().Length > range.ToString().Length)
                return true;
            //再用乘法严格判断是否超出range
            if (mul1 * mul2 > range)
                return true;
            return false;
        }

        private void GenerateForSub()
        {
            //生成加法式
            GenerateForAdd();
            //交换加数与和
            int t = number1;
            number1 = result;
            result = t;
        }

        private void GenerateForAdd()
        {
            Random r = new Random();
            result = r.Next(range);
            number1 = r.Next(result);
            number2 = result - number1;
        }

        private int getCurRange()
        {
            if (rdbRange1.Checked)
                return 10;
            if (rdbRange2.Checked)
                return 100;
            if (rdbRange3.Checked)
                return 10000;
            if (rdbRange4.Checked)
                return 100000000;
            throw new Exception("没有选择数字范围!");
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //按下回车键判分
            if(e.KeyChar == 13)
            {
                DoJudge();
            }
        }

        private void DoJudge()
        {
            if(submited == true)
                return; //已提交过不再重复判分
            submited = true;
            timCountdown.Enabled = false;
            bool isCorrect = txtAnswer.Text.Equals(result.ToString());
            if (isCorrect)
                txtAnswer.BackColor = Color.Green;  //回答正确
            else
                txtAnswer.BackColor = Color.Red;    //回答错误
            //自动显示答案
            if (cbAnswer.Checked)
                btnAnswer_Click(null, null);
            //若开启测试，则记录得分情况
            if (cbTest.Checked)
            {
                if (isCorrect)
                    point++;    //回答正确，分数++
                ShowScore();    //显示得分情况
                //题目答完
                if (cur >= total)
                    TestOver();
            }
            if (cbNext.Checked)
                timNext.Enabled = true;
        }

        private void TestOver()
        {
            MessageBox.Show("已完成" + total + "道题目，答对" + point + "题，正确率为" + correctRate + "%");
            cbTest.Checked = cbNext.Checked = false;    //停止自动下一题，关闭测试
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "正确答案:" + result;
        }

        private void timNext_Tick(object sender, EventArgs e)
        {
            Next();
            timNext.Enabled = false;
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            numCountdown.Enabled = cbTime.Checked;
            if (!cbTime.Checked)
            {
                timCountdown.Enabled = false;
                pgbTime.Value = 0;
            }
            
        }

        private void timCountdown_Tick(object sender, EventArgs e)
        {
            if (--pgbTime.Value <= 0)
            {
                DoJudge();
                timCountdown.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Stop();
            total = (int)numAmount.Value;
            point = cur = 0;
            grbTest.Text = "测验(" + cur + "/" + total + ")";
            ShowScore();
        }

        private void ShowScore()
        {
            lblScore.Text = "得分:" + point + "/" + cur;
            if (cur != 0)
                lblCorrectRate.Text = "正确率:" + correctRate + "%";
            else
                lblCorrectRate.Text = "正确率:---";
        }

        private OpType getRandomType()
        {
            List<OpType> opList = new List<OpType>();
            if (cbTypeAdd.Checked)
                opList.Add(OpType.ADD);
            if (cbTypeSub.Checked)
                opList.Add(OpType.SUB);
            if (cbTypeMul.Checked)
                opList.Add(OpType.MUL);
            if (cbTypeDiv.Checked)
                opList.Add(OpType.DIV);
            if (opList.Count == 0)
                throw new Exception("没有勾选题目类型");
            Random r = new Random();
            return opList[r.Next(opList.Count)];
        }

        private void rdbRange4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRange4.Checked)
                MessageBox.Show("嘿嘿！准备好作死了吗？");
        }

        private void cbTest_CheckedChanged(object sender, EventArgs e)
        {
            grbTest.Enabled = cbTest.Checked;
            Stop();
            if(cbTest.Checked)
            btnReset_Click(null, null);
        }

        private void Stop()
        {
            timNext.Enabled = timCountdown.Enabled = false;
            lblProblem.Text = "题目:";
            pgbTime.Value = 0;
            txtAnswer.Text = "";
            txtAnswer.BackColor = Color.White;
            lblAnswer.Text = "";
            submited = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbTypeMix_CheckedChanged(object sender, EventArgs e)
        {
            cbTypeAdd.Checked = cbTypeSub.Checked = cbTypeMul.Checked
                = cbTypeDiv.Checked = cbTypeMix.Checked;
            cbTypeAdd.Enabled = cbTypeSub.Enabled = cbTypeMul.Enabled
                = cbTypeDiv.Enabled = !cbTypeMix.Checked;
        }
    }
}
