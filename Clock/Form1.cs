using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Clock
{
    public partial class Form_Clock : Form
    {
        Bitmap image;//���
        SoundPlayer sp;//���� ����������
        string[] rimNumbers = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };//��������� ������ ������� ����
        string[] arabianNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };//��������� ������ �������� ����

        public Form_Clock()
        {
            InitializeComponent();

        }
        private void Form_Clock_Load(object sender, EventArgs e)
        {

            //��������� �������� ���� ��� ��������� ����������
            drawTimeText(arabianNumbers);
            rB_Arabskie.Checked = true;
            //������ ������� ��� �����
            timerTime.Start();
        
        }

       

        private void timerTime_Tick(object sender, EventArgs e)
        {
            pB_Clock.Refresh();//�������� ����������
            label_TekVrem.Text = DateTime.Now.ToLongTimeString();//����� �������� �������
           
        }

        private void pB_Clock_Paint(object sender, PaintEventArgs e)
        {
                DateTime dt = DateTime.Now;
              
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  //�������� ��������� ��������
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias; // �������� ��������� ������.
                e.Graphics.ResetTransform();//������� � �������� ����
                e.Graphics.TranslateTransform(pB_Clock.Width / 2, pB_Clock.Height / 2);//��������, ������� ���� � ����� ����� ���������(����� �����������)
                e.Graphics.RotateTransform(180);//������� �� ������� ������� � ��������
                if (chBox_Plavno.Checked)
                {
                drawArrows(new Pen(Color.White, 10), -2 * (float)Math.PI / 12 * (Convert.ToInt32(dt.Hour) + (1.0f / 60.0f * Convert.ToInt16(dt.Minute))), e.Graphics);
                drawArrows(new Pen(Color.White, 6), -2 * (float)Math.PI / 60 * (Convert.ToInt32(dt.Minute) + (1.0f / 60.0f * Convert.ToInt16(dt.Second))), e.Graphics);
                drawArrows(new Pen(Color.White, 4), -2 * (float)Math.PI / 60 * (Convert.ToInt32(dt.Second) + (1.0f / 1000.0f * Convert.ToInt16(dt.Millisecond))), e.Graphics);
                }
                else
                {
                drawArrows(new Pen(Color.White, 10), -2 * (float)Math.PI / 12 * Convert.ToInt32(dt.Hour), e.Graphics);
                drawArrows(new Pen(Color.White, 6), -2 * (float)Math.PI / 60 * Convert.ToInt32(dt.Minute), e.Graphics);
                drawArrows(new Pen(Color.White, 4), -2 * (float)Math.PI / 60 * Convert.ToInt32(dt.Second), e.Graphics);
                }
                e.Dispose();//�������� � ������������ ������
        }
        private void drawArrows(Pen pen, float angle, Graphics e)
        {
            float radius = pB_Clock.Width / 2 - 70;// ������ ����������
            float x, y;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;//����� ������ �������
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//����� ����� �������
            x = (float)(radius * Math.Sin(angle));
            y = (float)(radius * Math.Cos(angle));
            e.DrawLine(pen, 0, 0, x, y);
        }
        private void drawTimeText(string[] numbers)
        {
            image = new Bitmap("fon.png");
            Graphics gr = Graphics.FromImage(image);//������ �� �������
            gr.ResetTransform();//������� � �������� ����
            gr.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);//���������� ����� ��������� ��� ����� ��������
            gr.RotateTransform(180);//������� ������
            //��������� ���� �� ����������
            for (int i = 12; i >= 1; i--)
            {   //����������� ������� ������ 
                SizeF strSize = gr.MeasureString(numbers[i - 1]/*������ ��� ���������*/, new Font(FontFamily.GenericSansSerif, 18F, FontStyle.Bold)/*������ ������*/);
                gr.DrawString(numbers[i - 1]/*������*/, new Font(FontFamily.GenericSansSerif, 45F, FontStyle.Bold) /*�����*/, new SolidBrush(Color.White) /*�����*/, new Point(0 - (int)strSize.Width / 2, (image.Height / 2) - 80) /*�����*/);
                gr.RotateTransform(-30);//�� ����� �����
            }
            gr.RotateTransform(3);
            //��������� ������� (�������) �����
            for (int i = 0; i <= 60; i++)
            {
                gr.FillEllipse(new SolidBrush(Color.White), (image.Width / 2) - 350, (image.Height / 2) - 350, 10, 10);
                gr.RotateTransform(6);
            }
            pB_Clock.Image = image;
        }

        //������ ������� ����� �� ������
        private void but_Pusk_Click(object sender, EventArgs e)
        {
            timerAlarm.Start();
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            sp = new SoundPlayer();
            if (dt.Date == dTPicker_Date.Value.Date && dt.Hour == Convert.ToInt32(tB_Chas.Text) && dt.Minute == Convert.ToInt32(tB_Min.Text) && dt.Second == Convert.ToInt32(tB_Sec.Text))
            {
                 sp = new SoundPlayer("alarm.wav");
                 sp.Play();
                 if (sp.IsLoadCompleted)
                 {
                    label_Timer.Text = "���������!";
                 }
                 //label_Timer.Text = "���������!";

            }
            else
            {
                DateTime alarm = new DateTime(dTPicker_Date.Value.Year, dTPicker_Date.Value.Month, dTPicker_Date.Value.Day, Convert.ToInt32(tB_Chas.Text), Convert.ToInt32(tB_Min.Text), Convert.ToInt32(tB_Sec.Text));
                TimeSpan budilnik = alarm - dt;
                label_Timer.Text = $"��������� ��������� ����� {budilnik.Days} ���� {budilnik.Hours} ����� {budilnik.Minutes} ����� {budilnik.Seconds} ������";
               

            }
        }

        private void butt_Otmena_Click(object sender, EventArgs e)
        {
            sp.Stop();
            timerAlarm.Stop();
            label_Timer.Text = "���������.";
            tB_Chas.Text = "";
            tB_Min.Text = "";
            tB_Sec.Text = "";
        }
        //���������� �������� ����� ��� ������ �����������
        private void rB_Arabskie_CheckedChanged(object sender, EventArgs e)
        {
            drawTimeText(arabianNumbers);
        }
        //���������� ������� ����� ��� ������ �����������
        private void rB_Rimskie_CheckedChanged(object sender, EventArgs e)
        {
            drawTimeText(rimNumbers);
        }
        //����������� ������� �� ����������� ����� ��� ����������� ����������
        private void tB_Chas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ����� � ������� BackSpace
            {
                e.Handled = true;
            }
        }
    }
}


       