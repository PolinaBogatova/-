namespace Clock
{
    partial class Form_Clock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.label_TekVrem = new System.Windows.Forms.Label();
            this.rB_Rimskie = new System.Windows.Forms.RadioButton();
            this.rB_Arabskie = new System.Windows.Forms.RadioButton();
            this.chBox_Plavno = new System.Windows.Forms.CheckBox();
            this.butt_Otmena = new System.Windows.Forms.Button();
            this.but_Pusk = new System.Windows.Forms.Button();
            this.tB_Sec = new System.Windows.Forms.TextBox();
            this.tB_Min = new System.Windows.Forms.TextBox();
            this.tB_Chas = new System.Windows.Forms.TextBox();
            this.dTPicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_Timer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pB_Clock = new System.Windows.Forms.PictureBox();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Alarm = new System.Windows.Forms.GroupBox();
            this.groupBox_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Clock)).BeginInit();
            this.groupBox_Alarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.Controls.Add(this.label_TekVrem);
            this.groupBox_menu.Controls.Add(this.rB_Rimskie);
            this.groupBox_menu.Controls.Add(this.rB_Arabskie);
            this.groupBox_menu.Controls.Add(this.chBox_Plavno);
            this.groupBox_menu.Location = new System.Drawing.Point(529, 12);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Size = new System.Drawing.Size(424, 453);
            this.groupBox_menu.TabIndex = 0;
            this.groupBox_menu.TabStop = false;
            this.groupBox_menu.Text = "Меню";
            // 
            // label_TekVrem
            // 
            this.label_TekVrem.AutoSize = true;
            this.label_TekVrem.BackColor = System.Drawing.Color.Transparent;
            this.label_TekVrem.Location = new System.Drawing.Point(6, 26);
            this.label_TekVrem.Name = "label_TekVrem";
            this.label_TekVrem.Size = new System.Drawing.Size(115, 20);
            this.label_TekVrem.TabIndex = 17;
            this.label_TekVrem.Text = "Текущее время";
            // 
            // rB_Rimskie
            // 
            this.rB_Rimskie.AutoSize = true;
            this.rB_Rimskie.Location = new System.Drawing.Point(6, 86);
            this.rB_Rimskie.Name = "rB_Rimskie";
            this.rB_Rimskie.Size = new System.Drawing.Size(141, 24);
            this.rB_Rimskie.TabIndex = 15;
            this.rB_Rimskie.TabStop = true;
            this.rB_Rimskie.Text = "Римские цифры";
            this.rB_Rimskie.UseVisualStyleBackColor = true;
            this.rB_Rimskie.CheckedChanged += new System.EventHandler(this.rB_Rimskie_CheckedChanged);
            // 
            // rB_Arabskie
            // 
            this.rB_Arabskie.AutoSize = true;
            this.rB_Arabskie.Location = new System.Drawing.Point(6, 56);
            this.rB_Arabskie.Name = "rB_Arabskie";
            this.rB_Arabskie.Size = new System.Drawing.Size(149, 24);
            this.rB_Arabskie.TabIndex = 14;
            this.rB_Arabskie.TabStop = true;
            this.rB_Arabskie.Text = "Арабские цифры";
            this.rB_Arabskie.UseVisualStyleBackColor = true;
            this.rB_Arabskie.CheckedChanged += new System.EventHandler(this.rB_Arabskie_CheckedChanged);
            // 
            // chBox_Plavno
            // 
            this.chBox_Plavno.AutoSize = true;
            this.chBox_Plavno.Location = new System.Drawing.Point(165, 86);
            this.chBox_Plavno.Name = "chBox_Plavno";
            this.chBox_Plavno.Size = new System.Drawing.Size(152, 24);
            this.chBox_Plavno.TabIndex = 13;
            this.chBox_Plavno.Text = "Плавные стрелки";
            this.chBox_Plavno.UseVisualStyleBackColor = true;
            // 
            // butt_Otmena
            // 
            this.butt_Otmena.Location = new System.Drawing.Point(165, 275);
            this.butt_Otmena.Name = "butt_Otmena";
            this.butt_Otmena.Size = new System.Drawing.Size(141, 29);
            this.butt_Otmena.TabIndex = 12;
            this.butt_Otmena.Text = "Отменить";
            this.butt_Otmena.UseVisualStyleBackColor = true;
            this.butt_Otmena.Click += new System.EventHandler(this.butt_Otmena_Click);
            // 
            // but_Pusk
            // 
            this.but_Pusk.Location = new System.Drawing.Point(6, 275);
            this.but_Pusk.Name = "but_Pusk";
            this.but_Pusk.Size = new System.Drawing.Size(132, 29);
            this.but_Pusk.TabIndex = 11;
            this.but_Pusk.Text = "Запустить";
            this.but_Pusk.UseVisualStyleBackColor = true;
            this.but_Pusk.Click += new System.EventHandler(this.but_Pusk_Click);
            // 
            // tB_Sec
            // 
            this.tB_Sec.Location = new System.Drawing.Point(134, 169);
            this.tB_Sec.Name = "tB_Sec";
            this.tB_Sec.Size = new System.Drawing.Size(47, 27);
            this.tB_Sec.TabIndex = 9;
            this.tB_Sec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Chas_KeyPress);
            // 
            // tB_Min
            // 
            this.tB_Min.Location = new System.Drawing.Point(74, 169);
            this.tB_Min.Name = "tB_Min";
            this.tB_Min.Size = new System.Drawing.Size(47, 27);
            this.tB_Min.TabIndex = 8;
            this.tB_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Chas_KeyPress);
            // 
            // tB_Chas
            // 
            this.tB_Chas.Location = new System.Drawing.Point(12, 169);
            this.tB_Chas.Name = "tB_Chas";
            this.tB_Chas.Size = new System.Drawing.Size(47, 27);
            this.tB_Chas.TabIndex = 7;
            this.tB_Chas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Chas_KeyPress);
            // 
            // dTPicker_Date
            // 
            this.dTPicker_Date.Location = new System.Drawing.Point(12, 81);
            this.dTPicker_Date.Name = "dTPicker_Date";
            this.dTPicker_Date.Size = new System.Drawing.Size(250, 27);
            this.dTPicker_Date.TabIndex = 6;
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Location = new System.Drawing.Point(0, 228);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(201, 20);
            this.label_Timer.TabIndex = 5;
            this.label_Timer.Text = "Будильник сработает через";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "СС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ММ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ЧЧ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата включения";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // pB_Clock
            // 
            this.pB_Clock.Location = new System.Drawing.Point(12, 12);
            this.pB_Clock.Name = "pB_Clock";
            this.pB_Clock.Size = new System.Drawing.Size(511, 453);
            this.pB_Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Clock.TabIndex = 1;
            this.pB_Clock.TabStop = false;
            this.pB_Clock.Paint += new System.Windows.Forms.PaintEventHandler(this.pB_Clock_Paint);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // groupBox_Alarm
            // 
            this.groupBox_Alarm.Controls.Add(this.label1);
            this.groupBox_Alarm.Controls.Add(this.dTPicker_Date);
            this.groupBox_Alarm.Controls.Add(this.label2);
            this.groupBox_Alarm.Controls.Add(this.butt_Otmena);
            this.groupBox_Alarm.Controls.Add(this.label3);
            this.groupBox_Alarm.Controls.Add(this.but_Pusk);
            this.groupBox_Alarm.Controls.Add(this.label4);
            this.groupBox_Alarm.Controls.Add(this.label_Timer);
            this.groupBox_Alarm.Controls.Add(this.tB_Chas);
            this.groupBox_Alarm.Controls.Add(this.tB_Sec);
            this.groupBox_Alarm.Controls.Add(this.tB_Min);
            this.groupBox_Alarm.Location = new System.Drawing.Point(529, 128);
            this.groupBox_Alarm.Name = "groupBox_Alarm";
            this.groupBox_Alarm.Size = new System.Drawing.Size(424, 337);
            this.groupBox_Alarm.TabIndex = 16;
            this.groupBox_Alarm.TabStop = false;
            this.groupBox_Alarm.Text = "Будильник";
            // 
            // Form_Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(965, 469);
            this.Controls.Add(this.groupBox_Alarm);
            this.Controls.Add(this.pB_Clock);
            this.Controls.Add(this.groupBox_menu);
            this.Name = "Form_Clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.Form_Clock_Load);
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Clock)).EndInit();
            this.groupBox_Alarm.ResumeLayout(false);
            this.groupBox_Alarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox_menu;
        private CheckBox chBox_Plavno;
        private Button butt_Otmena;
        private Button but_Pusk;
        private TextBox tB_Sec;
        private TextBox tB_Min;
        private TextBox tB_Chas;
        private DateTimePicker dTPicker_Date;
        private Label label_Timer;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timerTime;
        private PictureBox pB_Clock;
        private System.Windows.Forms.Timer timerAlarm;
        private RadioButton rB_Rimskie;
        private RadioButton rB_Arabskie;
        private GroupBox groupBox_Alarm;
        private Label label_TekVrem;
    }
}