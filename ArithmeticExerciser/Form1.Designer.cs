namespace ArithmeticExerciser
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblProblem = new System.Windows.Forms.Label();
            this.cbNext = new System.Windows.Forms.CheckBox();
            this.cbAnswer = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.cbTypeDiv = new System.Windows.Forms.CheckBox();
            this.cbTypeMul = new System.Windows.Forms.CheckBox();
            this.cbTypeSub = new System.Windows.Forms.CheckBox();
            this.cbTypeAdd = new System.Windows.Forms.CheckBox();
            this.cbTypeMix = new System.Windows.Forms.CheckBox();
            this.grbRange = new System.Windows.Forms.GroupBox();
            this.rdbRange4 = new System.Windows.Forms.RadioButton();
            this.rdbRange3 = new System.Windows.Forms.RadioButton();
            this.rdbRange2 = new System.Windows.Forms.RadioButton();
            this.rdbRange1 = new System.Windows.Forms.RadioButton();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCorrectRate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbTest = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.cbTest = new System.Windows.Forms.CheckBox();
            this.grbOption = new System.Windows.Forms.GroupBox();
            this.numCountdown = new System.Windows.Forms.NumericUpDown();
            this.timCountdown = new System.Windows.Forms.Timer(this.components);
            this.timNext = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grbType.SuspendLayout();
            this.grbRange.SuspendLayout();
            this.grbTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.grbOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountdown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Font = new System.Drawing.Font("宋体", 30F);
            this.lblProblem.Location = new System.Drawing.Point(102, 220);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(147, 50);
            this.lblProblem.TabIndex = 0;
            this.lblProblem.Text = "题目:";
            // 
            // cbNext
            // 
            this.cbNext.AutoSize = true;
            this.cbNext.Location = new System.Drawing.Point(17, 25);
            this.cbNext.Name = "cbNext";
            this.cbNext.Size = new System.Drawing.Size(134, 19);
            this.cbNext.TabIndex = 2;
            this.cbNext.Text = "自动显示下一题";
            this.cbNext.UseVisualStyleBackColor = true;
            // 
            // cbAnswer
            // 
            this.cbAnswer.AutoSize = true;
            this.cbAnswer.Checked = true;
            this.cbAnswer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAnswer.Location = new System.Drawing.Point(17, 49);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(119, 19);
            this.cbAnswer.TabIndex = 3;
            this.cbAnswer.Text = "自动显示答案";
            this.cbAnswer.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(503, 323);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 42);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(111, 276);
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(555, 11);
            this.pgbTime.TabIndex = 5;
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Location = new System.Drawing.Point(17, 73);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(160, 19);
            this.cbTime.TabIndex = 6;
            this.cbTime.Text = "倒计时      秒/题";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.cbTypeDiv);
            this.grbType.Controls.Add(this.cbTypeMul);
            this.grbType.Controls.Add(this.cbTypeSub);
            this.grbType.Controls.Add(this.cbTypeAdd);
            this.grbType.Controls.Add(this.cbTypeMix);
            this.grbType.Location = new System.Drawing.Point(46, 32);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(118, 152);
            this.grbType.TabIndex = 9;
            this.grbType.TabStop = false;
            this.grbType.Text = "题目类型";
            // 
            // cbTypeDiv
            // 
            this.cbTypeDiv.AutoSize = true;
            this.cbTypeDiv.Location = new System.Drawing.Point(18, 99);
            this.cbTypeDiv.Name = "cbTypeDiv";
            this.cbTypeDiv.Size = new System.Drawing.Size(89, 19);
            this.cbTypeDiv.TabIndex = 4;
            this.cbTypeDiv.Text = "除法运算";
            this.cbTypeDiv.UseVisualStyleBackColor = true;
            // 
            // cbTypeMul
            // 
            this.cbTypeMul.AutoSize = true;
            this.cbTypeMul.Location = new System.Drawing.Point(18, 74);
            this.cbTypeMul.Name = "cbTypeMul";
            this.cbTypeMul.Size = new System.Drawing.Size(89, 19);
            this.cbTypeMul.TabIndex = 3;
            this.cbTypeMul.Text = "乘法运算";
            this.cbTypeMul.UseVisualStyleBackColor = true;
            // 
            // cbTypeSub
            // 
            this.cbTypeSub.AutoSize = true;
            this.cbTypeSub.Checked = true;
            this.cbTypeSub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTypeSub.Location = new System.Drawing.Point(18, 49);
            this.cbTypeSub.Name = "cbTypeSub";
            this.cbTypeSub.Size = new System.Drawing.Size(89, 19);
            this.cbTypeSub.TabIndex = 2;
            this.cbTypeSub.Text = "减法运算";
            this.cbTypeSub.UseVisualStyleBackColor = true;
            // 
            // cbTypeAdd
            // 
            this.cbTypeAdd.AutoSize = true;
            this.cbTypeAdd.Checked = true;
            this.cbTypeAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTypeAdd.Location = new System.Drawing.Point(18, 25);
            this.cbTypeAdd.Name = "cbTypeAdd";
            this.cbTypeAdd.Size = new System.Drawing.Size(89, 19);
            this.cbTypeAdd.TabIndex = 1;
            this.cbTypeAdd.Text = "加法运算";
            this.cbTypeAdd.UseVisualStyleBackColor = true;
            // 
            // cbTypeMix
            // 
            this.cbTypeMix.AutoSize = true;
            this.cbTypeMix.Location = new System.Drawing.Point(18, 124);
            this.cbTypeMix.Name = "cbTypeMix";
            this.cbTypeMix.Size = new System.Drawing.Size(59, 19);
            this.cbTypeMix.TabIndex = 0;
            this.cbTypeMix.Text = "混合";
            this.cbTypeMix.UseVisualStyleBackColor = true;
            this.cbTypeMix.CheckedChanged += new System.EventHandler(this.cbTypeMix_CheckedChanged);
            // 
            // grbRange
            // 
            this.grbRange.Controls.Add(this.rdbRange4);
            this.grbRange.Controls.Add(this.rdbRange3);
            this.grbRange.Controls.Add(this.rdbRange2);
            this.grbRange.Controls.Add(this.rdbRange1);
            this.grbRange.Location = new System.Drawing.Point(197, 32);
            this.grbRange.Name = "grbRange";
            this.grbRange.Size = new System.Drawing.Size(118, 152);
            this.grbRange.TabIndex = 10;
            this.grbRange.TabStop = false;
            this.grbRange.Text = "数字范围";
            // 
            // rdbRange4
            // 
            this.rdbRange4.AutoSize = true;
            this.rdbRange4.Location = new System.Drawing.Point(18, 99);
            this.rdbRange4.Name = "rdbRange4";
            this.rdbRange4.Size = new System.Drawing.Size(73, 19);
            this.rdbRange4.TabIndex = 3;
            this.rdbRange4.TabStop = true;
            this.rdbRange4.Text = "亿以内";
            this.rdbRange4.UseVisualStyleBackColor = true;
            this.rdbRange4.CheckedChanged += new System.EventHandler(this.rdbRange4_CheckedChanged);
            // 
            // rdbRange3
            // 
            this.rdbRange3.AutoSize = true;
            this.rdbRange3.Location = new System.Drawing.Point(18, 74);
            this.rdbRange3.Name = "rdbRange3";
            this.rdbRange3.Size = new System.Drawing.Size(73, 19);
            this.rdbRange3.TabIndex = 2;
            this.rdbRange3.TabStop = true;
            this.rdbRange3.Text = "万以内";
            this.rdbRange3.UseVisualStyleBackColor = true;
            // 
            // rdbRange2
            // 
            this.rdbRange2.AutoSize = true;
            this.rdbRange2.Location = new System.Drawing.Point(18, 49);
            this.rdbRange2.Name = "rdbRange2";
            this.rdbRange2.Size = new System.Drawing.Size(73, 19);
            this.rdbRange2.TabIndex = 1;
            this.rdbRange2.TabStop = true;
            this.rdbRange2.Text = "百以内";
            this.rdbRange2.UseVisualStyleBackColor = true;
            // 
            // rdbRange1
            // 
            this.rdbRange1.AutoSize = true;
            this.rdbRange1.Checked = true;
            this.rdbRange1.Location = new System.Drawing.Point(18, 24);
            this.rdbRange1.Name = "rdbRange1";
            this.rdbRange1.Size = new System.Drawing.Size(73, 19);
            this.rdbRange1.TabIndex = 0;
            this.rdbRange1.TabStop = true;
            this.rdbRange1.Text = "十以内";
            this.rdbRange1.UseVisualStyleBackColor = true;
            // 
            // txtAnswer
            // 
            this.txtAnswer.AccessibleName = "";
            this.txtAnswer.BackColor = System.Drawing.Color.White;
            this.txtAnswer.Font = new System.Drawing.Font("宋体", 30F);
            this.txtAnswer.Location = new System.Drawing.Point(238, 297);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(250, 65);
            this.txtAnswer.TabIndex = 11;
            this.tip.SetToolTip(this.txtAnswer, "按下回车键提交回答");
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.Location = new System.Drawing.Point(102, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "回答:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("宋体", 30F);
            this.lblAnswer.Location = new System.Drawing.Point(103, 384);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 50);
            this.lblAnswer.TabIndex = 13;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(620, 323);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(102, 42);
            this.btnAnswer.TabIndex = 14;
            this.btnAnswer.Text = "显示答案";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("宋体", 15F);
            this.lblScore.Location = new System.Drawing.Point(23, 74);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 25);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "得分:";
            // 
            // lblCorrectRate
            // 
            this.lblCorrectRate.AutoSize = true;
            this.lblCorrectRate.Font = new System.Drawing.Font("宋体", 15F);
            this.lblCorrectRate.Location = new System.Drawing.Point(23, 110);
            this.lblCorrectRate.Name = "lblCorrectRate";
            this.lblCorrectRate.Size = new System.Drawing.Size(100, 25);
            this.lblCorrectRate.TabIndex = 16;
            this.lblCorrectRate.Text = "正确率:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(117, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(54, 25);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "设置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbTest
            // 
            this.grbTest.Controls.Add(this.label3);
            this.grbTest.Controls.Add(this.btnReset);
            this.grbTest.Controls.Add(this.numAmount);
            this.grbTest.Controls.Add(this.lblCorrectRate);
            this.grbTest.Controls.Add(this.lblScore);
            this.grbTest.Enabled = false;
            this.grbTest.Location = new System.Drawing.Point(567, 32);
            this.grbTest.Name = "grbTest";
            this.grbTest.Size = new System.Drawing.Size(190, 152);
            this.grbTest.TabIndex = 18;
            this.grbTest.TabStop = false;
            this.grbTest.Text = "测验";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "题量:";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(56, 34);
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(54, 25);
            this.numAmount.TabIndex = 20;
            this.numAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbTest
            // 
            this.cbTest.AutoSize = true;
            this.cbTest.Location = new System.Drawing.Point(17, 97);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(89, 19);
            this.cbTest.TabIndex = 19;
            this.cbTest.Text = "开启测验";
            this.cbTest.UseVisualStyleBackColor = true;
            this.cbTest.CheckedChanged += new System.EventHandler(this.cbTest_CheckedChanged);
            // 
            // grbOption
            // 
            this.grbOption.Controls.Add(this.checkBox1);
            this.grbOption.Controls.Add(this.numCountdown);
            this.grbOption.Controls.Add(this.cbAnswer);
            this.grbOption.Controls.Add(this.cbNext);
            this.grbOption.Controls.Add(this.cbTime);
            this.grbOption.Controls.Add(this.cbTest);
            this.grbOption.Location = new System.Drawing.Point(348, 32);
            this.grbOption.Name = "grbOption";
            this.grbOption.Size = new System.Drawing.Size(186, 152);
            this.grbOption.TabIndex = 20;
            this.grbOption.TabStop = false;
            this.grbOption.Text = "选项";
            // 
            // numCountdown
            // 
            this.numCountdown.Enabled = false;
            this.numCountdown.Location = new System.Drawing.Point(90, 72);
            this.numCountdown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCountdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountdown.Name = "numCountdown";
            this.numCountdown.Size = new System.Drawing.Size(41, 25);
            this.numCountdown.TabIndex = 21;
            this.numCountdown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // timCountdown
            // 
            this.timCountdown.Tick += new System.EventHandler(this.timCountdown_Tick);
            // 
            // timNext
            // 
            this.timNext.Interval = 500;
            this.timNext.Tick += new System.EventHandler(this.timNext_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(17, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 19);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "按回车键以提交";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 470);
            this.Controls.Add(this.grbOption);
            this.Controls.Add(this.grbTest);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbRange);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblProblem);
            this.Name = "Form1";
            this.Text = "小天才魔鬼训练营";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.grbRange.ResumeLayout(false);
            this.grbRange.PerformLayout();
            this.grbTest.ResumeLayout(false);
            this.grbTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.grbOption.ResumeLayout(false);
            this.grbOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.CheckBox cbNext;
        private System.Windows.Forms.CheckBox cbAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.GroupBox grbRange;
        private System.Windows.Forms.RadioButton rdbRange3;
        private System.Windows.Forms.RadioButton rdbRange2;
        private System.Windows.Forms.RadioButton rdbRange1;
        private System.Windows.Forms.CheckBox cbTypeDiv;
        private System.Windows.Forms.CheckBox cbTypeMul;
        private System.Windows.Forms.CheckBox cbTypeSub;
        private System.Windows.Forms.CheckBox cbTypeAdd;
        private System.Windows.Forms.CheckBox cbTypeMix;
        private System.Windows.Forms.RadioButton rdbRange4;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCorrectRate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbTest;
        private System.Windows.Forms.CheckBox cbTest;
        private System.Windows.Forms.GroupBox grbOption;
        private System.Windows.Forms.Timer timCountdown;
        private System.Windows.Forms.Timer timNext;
        private System.Windows.Forms.NumericUpDown numCountdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

