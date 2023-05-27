namespace WinFormsAppTest
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnNumber0;
            pnlDisplay = new Panel();
            lblResult = new Label();
            lblMath = new Label();
            pnlOption = new Panel();
            btnCloseParenthesis = new Button();
            btnOpenParenthesis = new Button();
            btnTakeResult = new Button();
            btnDot = new Button();
            btnDevide = new Button();
            btnSubtract = new Button();
            btnMulti = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            flowPanelNumber = new FlowLayoutPanel();
            btnNumber0 = new Button();
            pnlDisplay.SuspendLayout();
            pnlOption.SuspendLayout();
            SuspendLayout();
            // 
            // btnNumber0
            // 
            btnNumber0.BackColor = SystemColors.ButtonShadow;
            btnNumber0.FlatAppearance.BorderSize = 0;
            btnNumber0.FlatStyle = FlatStyle.Flat;
            btnNumber0.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumber0.Location = new Point(442, 325);
            btnNumber0.Name = "btnNumber0";
            btnNumber0.Size = new Size(67, 53);
            btnNumber0.TabIndex = 2;
            btnNumber0.Text = "0";
            btnNumber0.UseVisualStyleBackColor = false;
            btnNumber0.Click += btnNumberClick;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(lblResult);
            pnlDisplay.Controls.Add(lblMath);
            pnlDisplay.Dock = DockStyle.Top;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(516, 151);
            pnlDisplay.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.Control;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(0, 75);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(519, 75);
            lblResult.TabIndex = 1;
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMath
            // 
            lblMath.BackColor = SystemColors.ControlDark;
            lblMath.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMath.ForeColor = Color.Black;
            lblMath.Location = new Point(0, 0);
            lblMath.Name = "lblMath";
            lblMath.Size = new Size(516, 75);
            lblMath.TabIndex = 0;
            lblMath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlOption
            // 
            pnlOption.Controls.Add(btnCloseParenthesis);
            pnlOption.Controls.Add(btnOpenParenthesis);
            pnlOption.Controls.Add(btnNumber0);
            pnlOption.Controls.Add(btnTakeResult);
            pnlOption.Controls.Add(btnDot);
            pnlOption.Controls.Add(btnDevide);
            pnlOption.Controls.Add(btnSubtract);
            pnlOption.Controls.Add(btnMulti);
            pnlOption.Controls.Add(btnAdd);
            pnlOption.Controls.Add(btnClear);
            pnlOption.Controls.Add(btnDelete);
            pnlOption.Controls.Add(flowPanelNumber);
            pnlOption.Dock = DockStyle.Bottom;
            pnlOption.Location = new Point(0, 157);
            pnlOption.Name = "pnlOption";
            pnlOption.Size = new Size(516, 500);
            pnlOption.TabIndex = 1;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.FlatAppearance.BorderSize = 0;
            btnCloseParenthesis.Location = new Point(270, 128);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(41, 33);
            btnCloseParenthesis.TabIndex = 3;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = true;
            btnCloseParenthesis.Click += btnCalculation;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.FlatAppearance.BorderSize = 0;
            btnOpenParenthesis.Location = new Point(227, 128);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(41, 33);
            btnOpenParenthesis.TabIndex = 3;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = true;
            btnOpenParenthesis.Click += btnCalculation;
            // 
            // btnTakeResult
            // 
            btnTakeResult.BackColor = Color.FromArgb(255, 185, 0);
            btnTakeResult.FlatAppearance.BorderSize = 0;
            btnTakeResult.FlatStyle = FlatStyle.Flat;
            btnTakeResult.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakeResult.Location = new Point(378, 378);
            btnTakeResult.Margin = new Padding(0);
            btnTakeResult.Name = "btnTakeResult";
            btnTakeResult.Size = new Size(131, 101);
            btnTakeResult.TabIndex = 1;
            btnTakeResult.Text = "=";
            btnTakeResult.UseVisualStyleBackColor = false;
            btnTakeResult.Click += TakeResult;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ButtonFace;
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(377, 325);
            btnDot.Margin = new Padding(0);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(67, 53);
            btnDot.TabIndex = 1;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnCalculation;
            // 
            // btnDevide
            // 
            btnDevide.BackColor = SystemColors.ButtonFace;
            btnDevide.FlatAppearance.BorderSize = 0;
            btnDevide.FlatStyle = FlatStyle.Flat;
            btnDevide.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDevide.Location = new Point(442, 222);
            btnDevide.Margin = new Padding(0);
            btnDevide.Name = "btnDevide";
            btnDevide.Size = new Size(67, 53);
            btnDevide.TabIndex = 1;
            btnDevide.Text = "/";
            btnDevide.UseVisualStyleBackColor = false;
            btnDevide.Click += btnCalculation;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.ButtonFace;
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.Location = new Point(442, 273);
            btnSubtract.Margin = new Padding(0);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(67, 53);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnCalculation;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.ButtonFace;
            btnMulti.FlatAppearance.BorderSize = 0;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulti.Location = new Point(377, 222);
            btnMulti.Margin = new Padding(0);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(67, 53);
            btnMulti.TabIndex = 1;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnCalculation;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonFace;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(377, 273);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 53);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnCalculation;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(442, 170);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 53);
            btnClear.TabIndex = 1;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += ClearMath;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonShadow;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(377, 170);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 53);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // flowPanelNumber
            // 
            flowPanelNumber.Location = new Point(3, 167);
            flowPanelNumber.Name = "flowPanelNumber";
            flowPanelNumber.Size = new Size(372, 321);
            flowPanelNumber.TabIndex = 0;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(516, 657);
            Controls.Add(pnlOption);
            Controls.Add(pnlDisplay);
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            pnlDisplay.ResumeLayout(false);
            pnlOption.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDisplay;
        private Label lblResult;
        private Label lblMath;
        private Panel pnlOption;
        private FlowLayoutPanel flowPanelNumber;
        private Button btnNumber0;
        private Button btnTakeResult;
        private Button btnDot;
        private Button btnDevide;
        private Button btnSubtract;
        private Button btnMulti;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnCloseParenthesis;
        private Button btnOpenParenthesis;
    }
}