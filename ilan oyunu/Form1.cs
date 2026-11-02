namespace ilan_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int istiqamət = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
            label2.Text = count.ToString();
            Random r = new Random();
            int x = r.Next(0, panel1.Width - yemek.Width);
            int y = r.Next(0, panel1.Height - yemek.Height);
            yemek.Location = new Point(x, y);
            timer1.Interval = 150;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = ilan.Location;
            if (istiqamət == 1) p.Y -= 10;
            else if (istiqamət == 2) p.Y += 10;
            else if (istiqamət == 3) p.X -= 10;
            else if (istiqamət == 4) p.X += 10;
            ilan.Location = p;
            if (ilan.Left < 0 || ilan.Top < 0 ||
                ilan.Right > panel1.Width || ilan.Bottom > panel1.Height)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            if (ilan.Left == yemek.Left && ilan.Top == yemek.Top)
            {
                count++;
                label2.Text = count.ToString();
                if (istiqamət == 1 || istiqamət == 2)
                    ilan.Height += 10;
                else
                    ilan.Width += 10;
                Random r = new Random();
                int x = r.Next(0, panel1.Width - yemek.Width);
                int y = r.Next(0, panel1.Height - yemek.Height);
                yemek.Location = new Point(x, y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (istiqamət != 2) 
                istiqamət = 1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (istiqamət != 1)
                istiqamət = 2;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (istiqamət != 4) 
                istiqamət = 3;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (istiqamət != 3) 
                istiqamət = 4;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Oyundan çıxış edilsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}