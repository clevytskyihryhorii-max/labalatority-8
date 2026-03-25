namespace laboratorna8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNumber = new TextBox();
            btnAdd = new Button();
            btnSort = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(56, 12);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(164, 23);
            txtNumber.TabIndex = 0;
            txtNumber.KeyDown += txtNumber_KeyDown;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(240, 65);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(240, 113);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(190, 35);
            btnSort.TabIndex = 3;
            btnSort.Text = "Сортувати ↓ (спадання)";
            btnSort.Click += btnSort_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(240, 166);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(190, 35);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Видалити вибране";
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(240, 218);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Очистити список";
            btnClear.Click += btnClear_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 229);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Число:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            Controls.Add(label1);
            Controls.Add(txtNumber);
            Controls.Add(btnAdd);
            Controls.Add(listBox1);
            Controls.Add(btnSort);
            Controls.Add(btnRemove);
            Controls.Add(btnClear);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}
