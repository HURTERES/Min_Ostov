using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Web.UI;
using System.Threading;
using System.Resources;
using System.Web;
using TheArtOfDevHtmlRenderer.Core;
using System.Web.Configuration;

namespace Min_Ostov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public Pen p = new Pen(Color.Black, 3);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RemoveLabel(string labelName)
        {
            System.Windows.Forms.Control[] controls = Controls.Find(labelName, true);
            foreach (System.Windows.Forms.Control control in controls)
            {
                Controls.Remove(control);
                control.Dispose();
            }
        }

        List<string> Lst = new List<string>();

        void Refreshs()
        {
            // control is Label label && 
            foreach (System.Windows.Forms.Control control in Controls)
            {
                if (Cbx12.Checked)
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(40, 133), new PointF(135, 36));
                }
                if (Cbx15.Checked)
                {
                        using (Graphics g = this.CreateGraphics())
                            g.DrawLine(p, new PointF(40, 133), new PointF(220, 133));
                }
                if (Cbx52.Checked)
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 15), new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15));
                }
                if (Cbx23.Checked)
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 15), new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15)); 
                if (Cbx53.Checked)
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15), new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15));
                if (Cbx45.Checked)
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15), new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 15));
                 if (Cbx34.Checked)
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15), new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 15));

            }


        }

        void RefreshList(string Name)
        {
            if (Lst.Count != 0)
                for (int i = 0; i < Lst.Count; i++)
                {
                    if (Lst[i].StartsWith($"{Name}"))
                        Lst.RemoveAt(i);
                }
        }


        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx12.Checked)
            {
                PointF point1 = new PointF(40, 133);
                PointF point2 = new PointF(135, 36);
                using (Graphics g = this.CreateGraphics())
                    g.DrawLine(p, new PointF(40, 133), new PointF(135, 36));

                string userInput = Interaction.InputBox("Введите значение", "Ввод значения");
                if (userInput == "") userInput = "1";
                PointF PLbl = new PointF((point1.X + point2.X) / 2 + 7, (point1.Y + point2.Y) / 2);
                Label Lbl = new Label();
                Lbl.Location = new Point((int)PLbl.X, (int)PLbl.Y);
                Lbl.Name = Cbx12.Name.Split('x')[1];
                Lbl.Text = userInput;
                Lbl.AutoSize = true;
                Controls.Add(Lbl);
                Lst.Add($"{Lbl.Name}={Lbl.Text}");
            }

            else
            {
                RemoveLabel("12");
                Refresh();
                Refreshs();
                RefreshList(Cbx12.Name.Split('x')[1]);
            }

        }

        private void Cbx14_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx15.Checked)
            {
                PointF point1 = new PointF(40, 133);
                PointF point2 = new PointF(220, 133);
                using (Graphics g = this.CreateGraphics())
                    g.DrawLine(p, new PointF(40, 133), new PointF(220, 133));

                string userInput = Interaction.InputBox("Введите значение", "Ввод значения");
                   if (userInput == "") userInput = "1";
                PointF PLbl = new PointF((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2 + 5);
                        Label Lbl = new Label();
                        Lbl.Location = new Point((int)PLbl.X, (int)PLbl.Y);
                        Lbl.Name = Cbx15.Name.Split('x')[1];
                        Lbl.Text = userInput;
                        Lbl.AutoSize = true;
                        Controls.Add(Lbl);
                Lst.Add($"{Lbl.Name}={Lbl.Text}");
            }
            else
            {
                RemoveLabel("15");
                Refresh();
                Refreshs();
                RefreshList(Cbx15.Name.Split('x')[1]);
            }
        }

        private void Cbx24_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx52.Checked)
            {

                PointF point1 = new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 15);
                PointF point2 = new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15);
                string userInput = Interaction.InputBox("Введите значение", "Ввод значения");
                   if (userInput == "") userInput = "1";
                PointF PLbl = new PointF((point1.X + point2.X) / 2 - 15, (point1.Y + point2.Y) / 2);
                Label Lbl = new Label();
                Lbl.Location = new Point((int)PLbl.X, (int)PLbl.Y);
                Lbl.Name = Cbx52.Name.Split('x')[1];
                Lbl.Text = userInput;
                Lbl.AutoSize = true;
                Controls.Add(Lbl);
                Lst.Add($"{Lbl.Name}={Lbl.Text}");
                using (Graphics g = this.CreateGraphics())
                    g.DrawLine(p, new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 15), new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15));
            }
            else
            {
                RemoveLabel("52");
                Refresh();
                Refreshs();
                RefreshList(Cbx52.Name.Split('x')[1]);
            }
        }

        private void Cbx23_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx23.Checked)
            {

                PointF point1 = new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 15);
                PointF point2 = new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15);
                string userInput = Interaction.InputBox("Введите значение", "Ввод значения");
                   if (userInput == "") userInput = "1";
                PointF PLbl = new PointF((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2 + 5);
                Label Lbl = new Label();
                Lbl.Location = new Point((int)PLbl.X, (int)PLbl.Y);
                Lbl.Name = Cbx23.Name.Split('x')[1];
                Lbl.Text = userInput;
                Lbl.AutoSize = true;
                Controls.Add(Lbl);
                Lst.Add($"{Lbl.Name}={Lbl.Text}");
                using (Graphics g = this.CreateGraphics())
                    g.DrawLine(p, new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 15), new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15));
            }
            else
            {
                RemoveLabel("23");
                Refresh();
                Refreshs();
                RefreshList(Cbx23.Name.Split('x')[1]);
            }
        }

        private void Cbx34_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx53.Checked)
            {

                PointF point1 = new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15);
                PointF point2 = new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15);
                string userInput = Interaction.InputBox("Введите значение", "Ввод значения");
                   if (userInput == "") userInput = "1";
                PointF PLbl = new PointF((point1.X + point2.X) / 2 + 7, (point1.Y + point2.Y) / 2);
                Label Lbl = new Label();
                Lbl.Location = new Point((int)PLbl.X, (int)PLbl.Y);
                Lbl.Name = Cbx53.Name.Split('x')[1];
                Lbl.Text = userInput;
                Lbl.AutoSize = true;
                Controls.Add(Lbl);
                Lst.Add($"{Lbl.Name}={Lbl.Text}");
                using (Graphics g = this.CreateGraphics())
                    g.DrawLine(p, new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15), new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15));
            }
            else
            {
                RemoveLabel("53");
                Refresh();
                Refreshs();
                RefreshList(Cbx53.Name.Split('x')[1]);
            }
        }

        private void Cbx45_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx45.Checked)
            {

                PointF point1 = new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15);
                PointF point2 = new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 15);
                string userInput = Interaction.InputBox("Введите значение", "Ввод значения");
                   if (userInput == "") userInput = "1";
                PointF PLbl = new PointF((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2+5);
                Label Lbl = new Label();
                Lbl.Location = new Point((int)PLbl.X, (int)PLbl.Y);
                Lbl.Name = Cbx45.Name.Split('x')[1];
                Lbl.Text = userInput;
                Lbl.AutoSize = true;
                Controls.Add(Lbl);
                Lst.Add($"{Lbl.Name}={Lbl.Text}");
                using (Graphics g = this.CreateGraphics())
                    g.DrawLine(p, new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 15), new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 15));
            }
            else
            {
                RemoveLabel("45");
                Refresh();
                Refreshs();
                RefreshList(Cbx45.Name.Split('x')[1]);
            }
        }

        private void Cbx35_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx34.Checked)
            {

                PointF point1 = new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15);
                PointF point2 = new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 15);
                string userInput = Interaction.InputBox("Введите значение", "Ввод значения");
                   if (userInput == "") userInput = "1";
                PointF PLbl = new PointF((point1.X + point2.X) / 2-20, (point1.Y + point2.Y) / 2);
                Label Lbl = new Label();
                Lbl.Location = new Point((int)PLbl.X, (int)PLbl.Y);
                Lbl.Name = Cbx34.Name.Split('x')[1];
                Lbl.Text = userInput;
                Lbl.AutoSize = true;
                Controls.Add(Lbl);
                Lst.Add($"{Lbl.Name}={Lbl.Text}");
                using (Graphics g = this.CreateGraphics())
                    g.DrawLine(p, new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 15), new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 15));
            }
            else
            {
                RemoveLabel("34");
                Refresh();
                Refreshs();
                RefreshList(Cbx34.Name.Split('x')[1]);
            }
        }


        int min=10000, pos;
        string Way;
        int Summa = 0;
        List<string> Lst2 = new List<string>();
        List<string> Lst3 = new List<string>();
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Ввод переменной для проверки зацикливания отрезков
            bool Contains23 = false;
            int TrueFalse = 0;
            Summa = 0;
            min = 10000;
            pos = 0;
            Way = "";
            Lst3.Clear();
            // Выход из первого пути
            try
            {
                for (int i = 0; i < Lst.Count; i++)
                    if (Lst[i].StartsWith("1"))
                        Lst2.Add(Lst[i]);

                for (int i = 0; i < Lst2.Count; i++)
                    if (min > int.Parse(Lst2[i].Split('=')[1]))
                    {
                        min = int.Parse(Lst2[i].Split('=')[1]);
                        pos = i;
                    }
                if(min != 10000)
                Summa += min;
                Lst3.Add(Lst2[pos].Split('=')[0]);
                Way += Lst2[0].Split('=')[0].Substring(0, 1);
                Lst2.Clear();
            }
            catch { }

            // Выход из второго пути
            try { 
            min = 10000;
            for (int i = 0; i < Lst.Count; i++)
                    if (Lst[i].StartsWith("2") && (!(Lst[i].Split('=')[0].EndsWith(Way))))
                        Lst2.Add(Lst[i]);

                for (int i = 0; i < Lst2.Count; i++)
                    if (min > int.Parse(Lst2[i].Split('=')[1]))
                    {
                        // Только один минимальный элемент, даже если их несколько!
                        min = int.Parse(Lst2[i].Split('=')[1]);
                        pos = i;
                        if (TrueFalse >= 1)
                            TrueFalse++;
                        else TrueFalse++;
                    }
                if (min != 10000)
                Summa += min;
                Lst3.Add(Lst2[pos].Split('=')[0]);
                Way += Lst2[0].Split('=')[0].Substring(0, 1);
                Lst2.Clear();
            }
            catch { }


            // Выход из третьего пути
            try
            {
                min = 10000;
                for (int i = 0; i < Lst.Count; i++)
                    if (Lst[i].StartsWith("3") && !(Lst[i].Split('=')[0].EndsWith(Way)) && TrueFalse != 2)
                        Lst2.Add(Lst[i]);
                for (int i = 0; i < Lst2.Count; i++)
                    if (min > int.Parse(Lst2[i].Split('=')[1]))
                    {
                        min = int.Parse(Lst2[i].Split('=')[1]);
                        pos = i;
                        // Если какой-либбо отрезок есть в теле цикла
                        if (TrueFalse >= 1)
                            TrueFalse++;
                        else TrueFalse++;
                    }
                if (min != 10000)
                    Summa += min;
                Lst3.Add(Lst2[pos].Split('=')[0]);
                Way += Lst2[0].Split('=')[0].Substring(0, 1);
                Lst2.Clear();
                MessageBox.Show($"Мин: {min} Поз:{Lst3[2]} Путь: {Way}");
            }
            catch { }

            // Выход из четвертого пути
            try { 
            min = 10000;
            for (int i = 0; i < Lst.Count; i++)
                if (Lst[i].StartsWith("4") && !(Lst[i].Split('=')[0].EndsWith(Way)) && TrueFalse <= 2)
                        if(Cbx23.Checked == true && Cbx34.Checked == true && Cbx53.Checked == false && Cbx52.Checked == false)
                    Lst2.Add(Lst[i]);
            else if(Cbx12.Checked == true && Cbx52.Checked == true&& Cbx23.Checked == false)
                            Lst2.Add(Lst[i]);
                for (int i = 0; i < Lst2.Count; i++)
                if (min > int.Parse(Lst2[i].Split('=')[1]))
                {
                    min = int.Parse(Lst2[i].Split('=')[1]);
                    pos = i;
                        if (TrueFalse >= 1)
                            TrueFalse++;
                        else TrueFalse++;

                }
            if (min != 10000)
                Summa += min;
                Lst3.Add(Lst2[pos].Split('=')[0]);
            Way += Lst2[0].Split('=')[0].Substring(0, 1);
            Lst2.Clear();
            }
            catch { }

            // Выход из пятого пути
            try
            {
                min = 10000;
                for (int i = 0; i < Lst.Count; i++)
                {
                    if (Lst[i].StartsWith("5") && !(Lst[i].Split('=')[0].EndsWith(Way)) && TrueFalse <= 2)
                        Lst2.Add(Lst[i]);
                    if (Lst[i].StartsWith("2"))
                        Contains23 = true;
                }


                if (Lst2.Count == 2 && Contains23 == false && TrueFalse <= 2)
                {

                    for (int i = 0; i < Lst2.Count; i++)
                    {
                        Lst3.Add(Lst2[i].Split('=')[0]);
                        Summa+= int.Parse(Lst2[i].Split('=')[1]);
                        if (TrueFalse >= 1)
                            TrueFalse++;
                        else TrueFalse++;
                    }
                    Way += Lst2[0].Split('=')[0].Substring(0, 1);
                }
                else
                {
                    for (int i = 0; i < Lst2.Count; i++)
                    {
                        if (min > int.Parse(Lst2[i].Split('=')[1]))
                        {
                            min = int.Parse(Lst2[i].Split('=')[1]);
                            pos = i;
                            if (TrueFalse >= 1)
                                TrueFalse++;
                            else TrueFalse++;
                        }
                    }

                    if (min != 10000)
                        Summa += min;
                    Lst3.Add(Lst2[pos].Split('=')[0]);
                    Way += Lst2[0].Split('=')[0].Substring(0, 1);
                }

                Lst2.Clear();
            }
            catch { }


            Refresh();
            Refreshs();
            label1.Text = "Путь: ";
            for (int i = 0; i < Lst3.Count; i++)
            {
                if(i==Lst3.Count-1)
                    label1.Text += Lst3[i].Split('=')[0] + " ";
                else label1.Text += Lst3[i].Split('=')[0] + "+";

                if (Lst3[i] == "12")
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl1.Location.X + 15, Lbl1.Location.Y + 300), new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 300));
                }
                if (Lst3[i] == "15")
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl1.Location.X + 15, Lbl1.Location.Y + 300), new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 300));
                }
                if (Lst3[i] == "52")
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 300), new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 300));
                }
                if (Lst3[i] == "23")
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl2.Location.X + 15, Lbl2.Location.Y + 300), new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 300));
                }
                if (Lst3[i] == "53" )
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 300), new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 300));
                }
                if (Lst3[i] == "45")
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl4.Location.X + 15, Lbl4.Location.Y + 300), new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 300));
                }
                if (Lst3[i] == "34")
                {
                    using (Graphics g = this.CreateGraphics())
                        g.DrawLine(p, new PointF(Lbl3.Location.X + 15, Lbl3.Location.Y + 300), new PointF(Lbl5.Location.X + 15, Lbl5.Location.Y + 300));
                }
            }
            label1.Text += $"= {Summa}";


        }
    }
}
