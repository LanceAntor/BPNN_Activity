using Backprop;
namespace Backpropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 1000, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Training data for a 4-input AND gate (16 combinations)
            double[,] inputs = {
                { 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0, 0.0 },
                { 0.0, 0.0, 1.0, 1.0 },
                { 0.0, 1.0, 0.0, 0.0 },
                { 0.0, 1.0, 0.0, 1.0 },
                { 0.0, 1.0, 1.0, 0.0 },
                { 0.0, 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0, 0.0 },
                { 1.0, 0.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0, 0.0 },
                { 1.0, 0.0, 1.0, 1.0 },
                { 1.0, 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0, 0.0 },
                { 1.0, 1.0, 1.0, 1.0 }
            };

            double[] outputs = {
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            };

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    nn.setInputs(0, inputs[j, 0]);
                    nn.setInputs(1, inputs[j, 1]);
                    nn.setInputs(2, inputs[j, 2]);
                    nn.setInputs(3, inputs[j, 3]);
                    nn.setDesiredOutput(0, outputs[j]);
                    nn.learn();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));

            nn.run();

            textBox5.Text = "" + nn.getOuputData(0);
        }
    }
}
