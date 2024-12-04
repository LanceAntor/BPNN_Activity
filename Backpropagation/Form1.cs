using Backprop;
namespace Backpropagation
{
    public partial class Form1 : Form
    {
        int[,] andInputs = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 1, 1, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 0 },
                { 0, 1, 1, 0, 0 },
                { 0, 1, 1, 1, 0 },
                { 1, 0, 0, 0, 0 },
                { 1, 0, 0, 1, 0 },
                { 1, 0, 1, 0, 0 },
                { 1, 0, 1, 1, 0 },
                { 1, 1, 0, 0, 0 },
                { 1, 1, 0, 1, 0 },
                { 1, 1, 1, 0, 0 },
                { 1, 1, 1, 1, 1 }
            };
        NeuralNet nn;
        int[,] operation;

        public Form1()
        {
            InitializeComponent();
        }
        private void resetNN()
        {
            nn = new NeuralNet(4, 4, 1);
            operation = andInputs;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resetNN();
        }
        
        private void setNN()
        {
            for (int i = 0; i < operation.GetLength(0); i++)
            {
                for (int j = 0; j < operation.GetLength(1) - 1; j++)
                {
                    nn.setInputs(j, operation[i, j]);
                }
                nn.setDesiredOutput(0, operation[i, operation.GetLength(1) - 1]);
                nn.learn();
            }
        }
        private void train(int epochs)
        {
            resetNN();
            for (int i = 0; i < epochs; i++)
            {
                setNN();
            }
        }
        private double getError()
        {
            double errorSum = 0;
            for (int i = 0; i < operation.GetLength(0); i++)
            {
                for (int j = 0; j < operation.GetLength(1) - 1; j++)
                {
                    nn.setInputs(j, operation[i, j]);
                }
                nn.run();
                errorSum += Math.Abs(nn.getOuputData(0) - operation[i, operation.GetLength(1) - 1]);
            }
            return errorSum / operation.GetLength(0);
        }
        private int findMinEpochs()
        {
            int l = 0, r = 100000;
            double errorThreshold = 0.01;

            while (l < r)
            {
                int m = (l + r) / 2;
                train(m);

                if (getError() < errorThreshold)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return l;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            train(Convert.ToInt32(epochTextBox.Text));
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

        private void button4_Click(object sender, EventArgs e)
        {
            double error = getError();
            MessageBox.Show("Error: " + error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bestEpoch = findMinEpochs();
            MessageBox.Show("Best Epoch To Train Data: " + bestEpoch);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
