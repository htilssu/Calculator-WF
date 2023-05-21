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
            pnlDisplay = new Panel();
            lblResult = new Label();
            lblMath = new Label();
            pnlOption = new Panel();
            btnNumber0 = new Button();
            btnTakeResult = new Button();
            btnDot = new Button();
            btnDevide = new Button();
            btnSubtract = new Button();
            btnMulti = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            flowPanelNumber = new FlowLayoutPanel();
            pnlDisplay.SuspendLayout();
            pnlOption.SuspendLayout();
            SuspendLayout();
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
            // btnNumber0
            // 
            btnNumber0.BackColor = SystemColors.ButtonFace;
            btnNumber0.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumber0.Location = new Point(377, 381);
            btnNumber0.Name = "btnNumber0";
            btnNumber0.Size = new Size(118, 99);
            btnNumber0.TabIndex = 2;
            btnNumber0.Text = "0";
            btnNumber0.UseVisualStyleBackColor = false;
            btnNumber0.Click += btnNumberClick;
            // 
            // btnTakeResult
            // 
            btnTakeResult.BackColor = SystemColors.ButtonFace;
            btnTakeResult.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakeResult.Location = new Point(442, 327);
            btnTakeResult.Name = "btnTakeResult";
            btnTakeResult.Size = new Size(67, 53);
            btnTakeResult.TabIndex = 1;
            btnTakeResult.Text = "=";
            btnTakeResult.UseVisualStyleBackColor = false;
            btnTakeResult.Click += TakeResult;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ButtonFace;
            btnDot.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(377, 327);
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
            btnDevide.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDevide.Location = new Point(442, 224);
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
            btnSubtract.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.Location = new Point(442, 275);
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
            btnMulti.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulti.Location = new Point(377, 224);
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
            btnAdd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(377, 275);
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
            btnClear.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(442, 172);
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
            btnDelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(377, 172);
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
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(516, 657);
            Controls.Add(pnlOption);
            Controls.Add(pnlDisplay);
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
    }
}