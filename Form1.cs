using System.Drawing.Text;

namespace WinFormsApp4
{
    public partial class Close : Form
    {
        public Close()
        {
            InitializeComponent();
        }

        private bool isClickMouse = false;
        private Point currentPosition = new Point(0, 0);

        private void button_click_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Close_MouseUp(object sender, MouseEventArgs e)
        {
            isClickMouse = false;
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            isClickMouse = true;
            currentPosition = new Point(e.X, e.Y);
        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClickMouse) { return; }
            Point buf = new Point(this.Location.X, this.Location.Y);

            buf.X += e.X - currentPosition.X;
            buf.Y += e.Y - currentPosition.Y;
        }


        private bool isPoint = false;
        private bool isNum2 = false;

        private string num1 = null;
        private string num2 = null;

        private string currentOperation = "";
        private Button obj;

        private void SetNum(string txt)
        {
            if (isNum2)
            {
                num2 = txt;
                textResult.Text = num2;
            }
            else
            {
                num1 = txt;
                textResult.Text = num1;
            }
        }

        private void burronNumberClick(Object obj, EventArgs e)
        {
            var txt = ((Button)obj).Text;
            {
                if (isPoint && txt == ",") { return; }
                if (txt == ",") { isPoint = true; }
            }
            if (txt == "+/-")
            {
                if (textResult.Text.Length > 0)
                    if (textResult.Text[0] == ',')
                    {
                        textResult.Text = textResult.Text.Substring(1, textResult.Text.Length - 1);
                    }
                    else
                    {
                        textResult.Text = "-" + textResult.Text;
                    }
                SetNum(textResult.Text);
                return;
            }
            AddNum(txt);
        }
        private void buttonOperationClick(Object obj, EventArgs e)
        {
            if (num1 == null) { if (textResult.Text.Length > 0) num1 = textResult.Text; else return; }

            isNum2 = true;
            currentOperation = ((Button)obj).Text;
            SetResult(currentOperation);
        }

        private void SetResult(string operation)
        {
            string result = null;

            switch (operation)
            {
                case "+": { result = MathOperation.Add(num1, num2); break; }
                case "-": { result = MathOperation.Sub(num1, num2); break; }
                case "*": { result = MathOperation.Mul(num1, num2); break; }
                case "/": { result = MathOperation.Dev(num1, num2); break; }
                case "%": { result = MathOperation.Proc(num1, num2); break; }
                default: break;
            }
            OutputResult(result, operation);

            if (isNum2) { if (result != null) num1 = result; } else { num1 = null; }
            isPoint = false;
            {
                textResult.Text = result;
            }

        }

        private void OutputResult(string? result, string operation)
        {
            throw new NotImplementedException();
        }

        private void buttonClear(object obj, EventArgs e)
        {
            textResult.Text = " ";

            isNum2 = false;
            currentOperation = null;
            num1 = null;
            num2 = null;
            isPoint = false;
        }

        private void bttonResultClick(object obj, EventArgs e)
        {
            SetResult(currentOperation);
            isNum2 = false;
            num1 = null;
            num2 = null;
        }

        private void buttonResetNumber(object obj, EventArgs e)
        {
            if (textResult.Text.Length <= 0) { return; }
            textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);
            SetNum(textResult.Text);
        }

        private void AddNum(string txt)
        {
            if (isNum2)
            {
                num2 += txt;
                textResult.Text = num2;

            }
            else
            {
                num1 += txt;
                textResult.Text = num1;
            }
        }
    }
}