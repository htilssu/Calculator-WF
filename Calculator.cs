using System.Reflection.Metadata.Ecma335;

namespace WinFormsAppTest
{
    public partial class Calculator : Form
    {
        List<int> nums = new List<int>();
        List<char> chars = new List<char>();
        static string calculation = "/+-*";
        double result = 0;

        public Calculator()
        {
            InitializeComponent();
            AddNumberBtn();
        }


        public void AddNumberBtn()
        {
            for (int i = 7; i >= 0; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Width = 118;
                btn.BackColor = SystemColors.ButtonShadow;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Location = new Point();
                btn.Height = 99;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Click += new EventHandler(btnNumberClick);
                flowPanelNumber.Controls.Add(btn);
                if (i % 3 == 0)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    i -= 6;
                }
            }
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblMath.Text += btn.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblMath.Text.Length > 0)
            {
                lblMath.Text = lblMath.Text.Substring(0, lblMath.Text.Length - 1);
                nums.Clear();
                chars.Clear();
            }
        }

        private void btnCalculation(object sender, EventArgs e)
        {
            btnNumberClick(sender, e);

        }



        /// <summary>
        /// Show result in calaculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TakeResult(object sender, EventArgs e)
        {

            lblResult.Text = "" + Math.Calculate(lblMath.Text).ToString("n9");

        }

        /// <summary>
        /// Clear all display in calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearMath(object sender, EventArgs e)
        {
            lblMath.Text = "";
            lblResult.Text = "";
            nums.Clear();
            chars.Clear();
        }

    }
}