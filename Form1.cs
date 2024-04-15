namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.ReadOnly = true;
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }
        public class TreeNode
        {
            public char Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(char value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        public class ShuntingYard
        {
            private string input;

            public ShuntingYard(string expression)
            {
                input = expression;
            }

            private int Precedence(char op)
            {
                switch (op)
                {
                    case '+':
                    case '-':
                        return 1;
                    case '*':
                    case '/':
                        return 2;
                    default:
                        return 0;
                }
            }

            private List<char> ConvertToPostfix()
            {
                List<char> postfix = new List<char>();
                Stack<char> operators = new Stack<char>();

                foreach (char c in input)
                {
                    if (Char.IsDigit(c))
                    {
                        postfix.Add(c);
                    }
                    else if (c == '(')
                    {
                        operators.Push(c);
                    }
                    else if (c == ')')
                    {
                        while (operators.Count > 0 && operators.Peek() != '(')
                        {
                            postfix.Add(operators.Pop());
                        }
                        operators.Pop(); // Pop '('
                    }
                    else
                    {
                        while (operators.Count > 0 && Precedence(c) <= Precedence(operators.Peek()))
                        {
                            postfix.Add(operators.Pop());
                        }
                        operators.Push(c);
                    }
                }

                while (operators.Count > 0)
                {
                    postfix.Add(operators.Pop());
                }

                return postfix;
            }

            private int Evaluate(TreeNode node)
            {
                if (Char.IsDigit(node.Value))
                {
                    return node.Value - '0';
                }

                int leftValue = Evaluate(node.Left);
                int rightValue = Evaluate(node.Right);

                switch (node.Value)
                {
                    case '+':
                        return leftValue + rightValue;
                    case '-':
                        return leftValue - rightValue;
                    case '*':
                        return leftValue * rightValue;
                    case '/':
                        return leftValue / rightValue;
                    default:
                        throw new ArgumentException("Invalid operator: " + node.Value);
                }
            }
            public int EvaluateExpression()
            {
                TreeNode root = BuildTree();
                return Evaluate(root);
            }

            public TreeNode BuildTree()
            {
                List<char> postfix = ConvertToPostfix();
                Stack<TreeNode> stack = new Stack<TreeNode>();


                try
                {
                    foreach (char c in postfix)
                    {
                        if (Char.IsDigit(c))
                        {
                            stack.Push(new TreeNode(c));
                        }
                        else
                        {
                            if (stack.Count < 2) 
                            {
                                throw new InvalidOperationException("Not enough operands to build the tree.");
                            }

                            TreeNode node = new TreeNode(c);
                            node.Right = stack.Pop();
                            node.Left = stack.Pop();
                            stack.Push(node);
                        }
                    }

                    if (stack.Count != 1)
                    {
                        throw new InvalidOperationException("Invalid expression. Tree construction failed.");
                    }

                    return stack.Pop();
                }
                catch (Exception ex)
                {
                    return null; // Trả về null nếu có lỗi
                }
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string expression = txtDisplay.Text;
            ShuntingYard shuntingYard = new ShuntingYard(expression);
            TreeNode root = shuntingYard.BuildTree();
            if (root == null)
            {
                txtDisplay.Text = "ERROR";
            }
            else
            {
                int result = shuntingYard.EvaluateExpression();
                txtDisplay.Text = result.ToString();
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }
    }
}
