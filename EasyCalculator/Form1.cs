using EasyCalculator.Abstraction.Enums;
using EasyCalculator.Implement;
using EasyCalculator.Processors;
using System;
using System.Windows.Forms;

namespace EasyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
            => ChangeOperationUnary(Operations.ChangeSign);

        private void Form1_Load(object sender, EventArgs e)
        {
            AddStringValue("0");
            DataHandler.Clear();
        }

        public void ChangeOperationBinary(Operations operation)
        {
            DataHandler.ExpressionContinuation = true;
            OperationDataResult result = DataHandler.BinaryOperationResult();
            if (result.Success)
            {
                InfoLabel.Text = result.Data;
            }
            DataHandler.OperationData = operation;
        }
        public void ChangeOperationUnary(Operations operation)
        {
            DataHandler.OperationData = operation;
            OperationDataResult result = DataHandler.UnaryOperationResult();
            if (result.Success)
                InfoLabel.Text = result.Data;
            DataHandler.ExpressionContinuation = false;
        }

        private void GetResult()
        {
            OperationDataResult result = DataHandler.BinaryOperationResult();
            if (result.Success)
                InfoLabel.Text = result.Data;
            DataHandler.ExpressionContinuation = false;
        }

        private void EquallyButton_Click(object sender, EventArgs e)
            => GetResult();

        private void PlusButton_Click(object sender, EventArgs e)
            => ChangeOperationBinary(Operations.Plus);

        private void MinusButton_Click(object sender, EventArgs e)
            => ChangeOperationBinary(Operations.Minus);

        private void MultiplyButton_Click(object sender, EventArgs e)
            => ChangeOperationBinary(Operations.Multiply);

        private void DivideButton_Click(object sender, EventArgs e)
            => ChangeOperationBinary(Operations.Divide);

        private void AddStringValue(string number)
        {
            DataHandler.ClearBeforeNew();
            if (DataHandler.OperationData != 0 && DataHandler.StrData == "")
                InfoLabel.Text = "";
            if (DataHandler.StrData == "")
                InfoLabel.Text = "";

            DataHandler.StrData += number;
            InfoLabel.Text += number;
        }

        private void AddOperationValue(Operations operation)
        {
            DataHandler.ClearBeforeNew();
            DataHandler.SetFirstDataFromOperation(operation);
            InfoLabel.Text = DataHandler.FirstData.ToString();
        }

        private void button_2_Click(object sender, EventArgs e)
            => AddStringValue("2");

        private void button_3_Click(object sender, EventArgs e)
            => AddStringValue("3");

        private void button_1_Click(object sender, EventArgs e)
            => AddStringValue("1");

        private void button_4_Click(object sender, EventArgs e)
            => AddStringValue("4");

        private void button_5_Click(object sender, EventArgs e)
            => AddStringValue("5");

        private void button_6_Click(object sender, EventArgs e)
            => AddStringValue("6");

        private void button_7_Click(object sender, EventArgs e)
            => AddStringValue("7");

        private void button_8_Click(object sender, EventArgs e)
            => AddStringValue("8");

        private void button_9_Click(object sender, EventArgs e)
            => AddStringValue("9");

        private void button_dot_Click(object sender, EventArgs e)
            => AddStringValue(",");

        private void button_0_Click(object sender, EventArgs e)
            => AddStringValue("0");

        private void AcButton_Click(object sender, EventArgs e)
        {
            DataHandler.Clear();
            AddStringValue("0");
            DataHandler.Clear();
        }

        private void button_x_y_Click(object sender, EventArgs e)
            => ChangeOperationBinary(Operations.Power);

        private void button_x_2_Click(object sender, EventArgs e)
        {
            DataHandler.SecondData = 2;
            DataHandler.OperationData = Operations.Power;
            GetResult();
        }

        private void button_x_3_Click(object sender, EventArgs e)
        {
            DataHandler.SecondData = 3;
            DataHandler.OperationData = Operations.Power;
            GetResult();
        }

        private void button_1_by_x_Click(object sender, EventArgs e)
        {
            ChangeOperationBinary(Operations.Divide);
            DataHandler.SecondData = DataHandler.FirstData;
            DataHandler.FirstData = 1;
            if (DataHandler.SecondData != 0)
            {
                GetResult();
            }
            else
            {
                InfoLabel.Text = "Ошибка";
                DataHandler.Clear();
            }
            
        }

        private void Factorialbutton_Click(object sender, EventArgs e) 
            => ChangeOperationUnary(Operations.Factorial);

        private void PercetButton_Click(object sender, EventArgs e)
        {
            DataHandler.SecondData = 100;
            ChangeOperationBinary(Operations.Divide);
        }

        private void RootButton_Click(object sender, EventArgs e)
            => ChangeOperationBinary(Operations.Root);

        private void button_e_Click(object sender, EventArgs e) 
            => AddOperationValue(Operations.GetE);

        private void button_pi_Click(object sender, EventArgs e)
            => AddOperationValue(Operations.GetPi);

        private void button_ln_Click(object sender, EventArgs e) 
            => ChangeOperationUnary(Operations.NaturalLogarithm);

        private void button_lg_Click(object sender, EventArgs e) 
            => ChangeOperationUnary(Operations.TenLogarithm);

        private void button_sin_Click(object sender, EventArgs e) 
            => ChangeOperationUnary(Operations.Sinus);

        private void button_cos_Click(object sender, EventArgs e) 
            => ChangeOperationUnary(Operations.Cosinus);

        private void button_tg_Click(object sender, EventArgs e) 
            => ChangeOperationUnary(Operations.Tangent);
    }
}
