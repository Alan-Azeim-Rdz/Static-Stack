namespace Static_Stack
{
    partial class Form1
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
            txtInput = new TextBox();
            lstStack = new ListBox();
            btnPush = new Button();
            btnPop = new Button();
            btnPeek = new Button();
            btnSize = new Button();
            LblData = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(118, 29);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(193, 23);
            txtInput.TabIndex = 0;
            // 
            // lstStack
            // 
            lstStack.Font = new Font("Berlin Sans FB", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstStack.FormattingEnabled = true;
            lstStack.ItemHeight = 46;
            lstStack.Location = new Point(490, 44);
            lstStack.Name = "lstStack";
            lstStack.Size = new Size(426, 510);
            lstStack.TabIndex = 1;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(148, 106);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(125, 58);
            btnPush.TabIndex = 2;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(148, 188);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(125, 58);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(148, 272);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(125, 58);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnSize
            // 
            btnSize.Location = new Point(148, 368);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(125, 58);
            btnSize.TabIndex = 5;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.Location = new Point(490, 9);
            LblData.Name = "LblData";
            LblData.Size = new Size(235, 15);
            LblData.TabIndex = 6;
            LblData.Text = "Pila estatica con un espacio de 8 elementos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 7;
            label1.Text = "dato a ingresar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 566);
            Controls.Add(label1);
            Controls.Add(LblData);
            Controls.Add(btnSize);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(lstStack);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ListBox lstStack;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private Button btnSize;
        private Label LblData;
        private Label label1;
    }
}
