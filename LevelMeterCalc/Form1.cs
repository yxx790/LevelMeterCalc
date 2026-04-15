using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LevelMeterCalc
{
    public partial class Form1 : Form
    {
        private void calc()
        {
            textBox3.Text = trackBar3.Value.ToString();
            label3.Text = Math.Round((((20 - 4) / (trackBar1.Value * 1.0 - trackBar2.Value * 1.0)) * (trackBar1.Value * 1.0 - trackBar3.Value * 1.0) + 4) ,2).ToString();
        }
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = trackBar1.Value.ToString();
            trackBar3.Maximum = trackBar1.Value;
            textBox2.Text = trackBar2.Value.ToString();
            trackBar3.Minimum = trackBar2.Value;
            calc();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            trackBar3.Maximum = trackBar1.Value;
            calc();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            trackBar3.Minimum = trackBar2.Value;
            calc();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            calc();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, out value))
            {
                if (value >= trackBar1.Minimum && value <= trackBar1.Maximum)
                {
                    trackBar1.BackColor = Control.DefaultBackColor;
                    trackBar1.Value = value;
                    trackBar3.Maximum = trackBar1.Value;
                    calc();
                }
                else { trackBar1.BackColor = Color.Coral; }
            }
            else { trackBar1.BackColor = Color.Coral; }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox2.Text, out value))
            {
                if (value >= trackBar2.Minimum && value <= trackBar2.Maximum)
                {
                    trackBar2.BackColor = Control.DefaultBackColor;
                    trackBar2.Value = value;
                    trackBar3.Minimum = trackBar2.Value;
                    calc();
                }
                else { trackBar2.BackColor = Color.Coral; }
            }
            else { trackBar2.BackColor = Color.Coral; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox3.Text, out value))
            {
                if (value >= trackBar3.Minimum && value <= trackBar3.Maximum)
                {
                    trackBar3.BackColor = Control.DefaultBackColor;
                    trackBar3.Value = value;
                    calc();
                }
                else { trackBar3.BackColor = Color.Coral; }
            }
            else { trackBar3.BackColor = Color.Coral; }
        }
    }
    
}
