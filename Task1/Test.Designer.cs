namespace Task1
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            LQuastion = new Label();
            groupBox2 = new GroupBox();
            radioV4 = new RadioButton();
            radioV3 = new RadioButton();
            radioV2 = new RadioButton();
            radioV1 = new RadioButton();
            buttonAccept = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LQuastion);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вопрос:";
            // 
            // LQuastion
            // 
            LQuastion.Dock = DockStyle.Fill;
            LQuastion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LQuastion.Location = new Point(3, 34);
            LQuastion.Name = "LQuastion";
            LQuastion.Size = new Size(487, 88);
            LQuastion.TabIndex = 0;
            LQuastion.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioV4);
            groupBox2.Controls.Add(radioV3);
            groupBox2.Controls.Add(radioV2);
            groupBox2.Controls.Add(radioV1);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 373);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Варианты ответа:";
            // 
            // radioV4
            // 
            radioV4.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioV4.Location = new Point(6, 290);
            radioV4.Name = "radioV4";
            radioV4.Size = new Size(463, 62);
            radioV4.TabIndex = 3;
            radioV4.TabStop = true;
            radioV4.Text = "radioButton4";
            radioV4.UseVisualStyleBackColor = true;
            // 
            // radioV3
            // 
            radioV3.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioV3.Location = new Point(6, 200);
            radioV3.Name = "radioV3";
            radioV3.Size = new Size(463, 62);
            radioV3.TabIndex = 2;
            radioV3.TabStop = true;
            radioV3.Text = "radioButton3";
            radioV3.UseVisualStyleBackColor = true;
            // 
            // radioV2
            // 
            radioV2.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioV2.Location = new Point(6, 116);
            radioV2.Name = "radioV2";
            radioV2.Size = new Size(463, 62);
            radioV2.TabIndex = 1;
            radioV2.TabStop = true;
            radioV2.Text = "radioButton2";
            radioV2.UseVisualStyleBackColor = true;
            // 
            // radioV1
            // 
            radioV1.Font = new Font("Microsoft Sans Serif", 10.2F);
            radioV1.Location = new Point(6, 37);
            radioV1.Name = "radioV1";
            radioV1.Size = new Size(463, 62);
            radioV1.TabIndex = 0;
            radioV1.TabStop = true;
            radioV1.Text = "radioButton1";
            radioV1.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(147, 522);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(195, 43);
            buttonAccept.TabIndex = 2;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 570);
            Controls.Add(buttonAccept);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioV4;
        private RadioButton radioV3;
        private RadioButton radioV2;
        private RadioButton radioV1;
        private Button buttonAccept;
        private Label LQuastion;
        private System.Windows.Forms.Timer timer1;
    }
}