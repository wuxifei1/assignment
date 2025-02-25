namespace CalculatorWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeOperators();
        }

        private void InitializeOperators()
        {
            OpBox.Items.AddRange(new object[] { '+', "-", "*", "/" });
            OpBox.SelectedIndex = 0;
        }

        private double Calculate(double num1, double num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "��":
                    return num1 * num2;
                case "��":
                    if (num2 == 0) throw new DivideByZeroException();
                    return num1 / num2;
                default:
                    throw new ArgumentException("��Ч�������");
            }
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBox1.Text, out double num1))
            {
                MessageBox.Show("�������һ����Ч����");
                return;
            }
            if (!double.TryParse(InputBox2.Text, out double num2))
            {
                MessageBox.Show("������ڶ�����Ч����");
                return;
            }

            try
            {
                double result = Calculate(num1, num2, OpBox.SelectedItem.ToString());
                ResultShowLabel.Text = $"result: {result}";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("��������Ϊ0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
