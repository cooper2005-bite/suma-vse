namespace practica__5_vse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radius, Height;
            double baseArea, LateralArea, totalArea;
            double Volume;
            Radius = double.Parse (textBox1.Text);
            Height = double.Parse(textBox2.Text);

            baseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            totalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
            textBox3.Text  = baseArea.ToString("0.##");
            textBox4.Text = baseArea.ToString("0.##");
            textBox5.Text = baseArea.ToString("0 ##");
            textBox6.Text = baseArea.ToString("0 ##");

        }
    }
}