namespace KrizicKruzic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "   ";
            label2.Text = "   ";
            label3.Text = "   ";
            label4.Text = "   ";
            label5.Text = "   ";
            label6.Text = "   ";
            label7.Text = "   ";
            label8.Text = "   ";
            label9.Text = "   ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "   ") {
                label1.Text = "O";
                label1.ForeColor = Color.Green;
                if (label2.Text == "O" && label3.Text == "O") {
                    Pobjeda();
                } else if (label4.Text == "O" && label7.Text == "O") {
                    Pobjeda();
                } else if (label5.Text == "O" && label9.Text == "O") {
                    Pobjeda();
                } else 
                    Krizic();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "   ")
            {
                label2.Text = "O";
                label2.ForeColor = Color.Green;
                if (label1.Text == "O" && label3.Text == "O")
                {
                    Pobjeda();
                } else if (label5.Text == "O" && label8.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "   ")
            {
                label3.Text = "O";
                label3.ForeColor = Color.Green;
                if (label1.Text == "O" && label2.Text == "O")
                {
                    Pobjeda();
                } else if (label6.Text == "O" && label9.Text == "O")
                {
                    Pobjeda();
                } else if (label5.Text == "O" && label7.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "   ")
            {
                label4.Text = "O";
                label4.ForeColor = Color.Green;
                if (label1.Text == "O" && label7.Text == "O")
                {
                    Pobjeda();
                } else if (label5.Text == "O" && label6.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "   ")
            {
                label5.Text = "O";
                label5.ForeColor = Color.Green;
                if (label2.Text == "O" && label8.Text == "O")
                {
                    Pobjeda();
                } else if (label4.Text == "O" && label6.Text == "O")
                {
                    Pobjeda();
                } else if (label1.Text == "O" && label9.Text == "O")
                {
                    Pobjeda();
                } else if (label3.Text == "O" && label7.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "   ")
            {
                label6.Text = "O";
                label6.ForeColor = Color.Green;
                if (label3.Text == "O" && label9.Text == "O")
                {
                    Pobjeda();
                } else if (label4.Text == "O" && label5.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "   ")
            {
                label7.Text = "O";
                label7.ForeColor = Color.Green;
                if (label1.Text == "O" && label4.Text == "O")
                {
                    Pobjeda();
                } else if (label8.Text == "O" && label9.Text == "O")
                {
                    Pobjeda();
                } else if (label5.Text == "O" && label3.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "   ")
            {
                label8.Text = "O";
                label8.ForeColor = Color.Green;
                if (label2.Text == "O" && label5.Text == "O")
                {
                    Pobjeda();
                } else if (label7.Text == "O" && label9.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "   ")
            {
                label9.Text = "O";
                label9.ForeColor = Color.Green;
                if (label1.Text == "O" && label5.Text == "O")
                {
                    Pobjeda();
                } else if (label3.Text == "O" && label6.Text == "O")
                {
                    Pobjeda();
                } else if (label7.Text == "O" && label8.Text == "O")
                {
                    Pobjeda();
                } else
                    Krizic();
            }
        }

        private void Krizic()
        {
            Random rand = new Random();
            int broj = rand.Next(1, 10);
            byte i = 0; //brojač do kraja igre
            switch (broj)
            {
                case 1:
                    if (label1.Text == "   " && i < 5) { 
                        label1.Text = "X";
                        label1.ForeColor = Color.Crimson;
                        i += 1;
                        if (label2.Text == "X" && label3.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label4.Text == "X" && label7.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label5.Text == "X" && label9.Text == "X")
                        {
                            Poraz();
                        }
                    } else 
                        Krizic();
                    break;
                case 2:
                    if (label2.Text == "   " && i < 5)
                    {
                        label2.Text = "X";
                        label2.ForeColor = Color.Crimson;
                        i += 1;
                        if (label1.Text == "X" && label3.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label5.Text == "X" && label8.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                case 3:
                    if (label3.Text == "   " && i < 5)
                    {
                        label3.Text = "X";
                        label3.ForeColor = Color.Crimson;
                        i += 1;
                        if (label1.Text == "X" && label2.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label6.Text == "X" && label9.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label5.Text == "X" && label7.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                case 4:
                    if (label4.Text == "   " && i < 5)
                    {
                        label4.Text = "X";
                        label4.ForeColor = Color.Crimson;
                        i += 1;
                        if (label1.Text == "X" && label7.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label5.Text == "X" && label6.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                case 5:
                    if (label5.Text == "   " && i < 5)
                    {
                        label5.Text = "X";
                        label5.ForeColor = Color.Crimson;
                        i += 1;
                        if (label2.Text == "X" && label8.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label4.Text == "X" && label6.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label1.Text == "X" && label9.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label3.Text == "X" && label7.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                case 6:
                    if (label6.Text == "   " && i < 5)
                    {
                        label6.Text = "X";
                        label6.ForeColor = Color.Crimson;
                        i += 1;
                        if (label3.Text == "X" && label9.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label4.Text == "X" && label5.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                case 7:
                    if (label7.Text == "   " && i < 5)
                    {
                        label7.Text = "X";
                        label7.ForeColor = Color.Crimson;
                        i += 1;
                        if (label1.Text == "X" && label4.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label8.Text == "X" && label9.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label5.Text == "X" && label3.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                case 8:
                    if (label8.Text == "   " && i < 5)
                    {
                        label8.Text = "X";
                        label8.ForeColor = Color.Crimson;
                        i += 1;
                        if (label2.Text == "X" && label5.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label7.Text == "X" && label9.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                case 9:
                    if (label9.Text == "   " && i < 5)
                    {
                        label9.Text = "X";
                        label9.ForeColor = Color.Crimson;
                        i += 1;
                        if (label1.Text == "X" && label5.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label3.Text == "X" && label6.Text == "X")
                        {
                            Poraz();
                        }
                        else if (label7.Text == "X" && label8.Text == "X")
                        {
                            Poraz();
                        }
                    }
                    else
                        Krizic();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "   ";
            label2.Text = "   "; 
            label3.Text = "   ";
            label4.Text = "   ";
            label5.Text = "   ";
            label6.Text = "   ";
            label7.Text = "   ";
            label8.Text = "   ";
            label9.Text = "   ";

            label1.BackColor = Color.Khaki;
            label2.BackColor = Color.Khaki;
            label3.BackColor = Color.Khaki;
            label4.BackColor = Color.Khaki;
            label5.BackColor = Color.Khaki;
            label6.BackColor = Color.Khaki;
            label7.BackColor = Color.Khaki;
            label8.BackColor = Color.Khaki;
            label9.BackColor = Color.Khaki;
        }

        private void Pobjeda()
        {
            label1.BackColor = Color.Orange;
            label2.BackColor = Color.Orange;
            label3.BackColor = Color.Orange;
            label4.BackColor = Color.Orange;
            label5.BackColor = Color.Orange;
            label6.BackColor = Color.Orange;
            label7.BackColor = Color.Orange;
            label8.BackColor = Color.Orange;
            label9.BackColor = Color.Orange;
        }

        private void Poraz()
        {
            label1.BackColor = Color.Silver;
            label2.BackColor = Color.Silver;
            label3.BackColor = Color.Silver;
            label4.BackColor = Color.Silver;
            label5.BackColor = Color.Silver;
            label6.BackColor = Color.Silver;
            label7.BackColor = Color.Silver;
            label8.BackColor = Color.Silver;
            label9.BackColor = Color.Silver;
        }
    }
}