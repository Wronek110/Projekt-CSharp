namespace projekt_wronek
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
            ClientList = new ListBox();
            ProduktListBox = new ListBox();
            ZamowieniaListBox = new ListBox();
            ClientAdd = new Button();
            ClientDel = new Button();
            ClientEdit = new Button();
            ClientClear = new Button();
            ClientTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ProduktTextBox = new TextBox();
            ProduktAdd = new Button();
            ProduktDel = new Button();
            ProduktEdit = new Button();
            ProduktClear = new Button();
            ZamowieniaAdd = new Button();
            ZamowieniaDel = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // ClientList
            // 
            ClientList.FormattingEnabled = true;
            ClientList.ItemHeight = 15;
            ClientList.Location = new Point(12, 29);
            ClientList.Name = "ClientList";
            ClientList.Size = new Size(161, 229);
            ClientList.TabIndex = 0;
            ClientList.SelectedIndexChanged += ClientList_SelectedIndexChanged;
            // 
            // ProduktListBox
            // 
            ProduktListBox.FormattingEnabled = true;
            ProduktListBox.ItemHeight = 15;
            ProduktListBox.Location = new Point(311, 29);
            ProduktListBox.Name = "ProduktListBox";
            ProduktListBox.Size = new Size(161, 229);
            ProduktListBox.TabIndex = 1;
            ProduktListBox.SelectedIndexChanged += ProduktListBox_SelectedIndexChanged;
            // 
            // ZamowieniaListBox
            // 
            ZamowieniaListBox.FormattingEnabled = true;
            ZamowieniaListBox.ItemHeight = 15;
            ZamowieniaListBox.Location = new Point(627, 29);
            ZamowieniaListBox.Name = "ZamowieniaListBox";
            ZamowieniaListBox.Size = new Size(161, 229);
            ZamowieniaListBox.TabIndex = 2;
            ZamowieniaListBox.SelectedIndexChanged += ZamowieniaListBox_SelectedIndexChanged;
            // 
            // ClientAdd
            // 
            ClientAdd.Location = new Point(12, 293);
            ClientAdd.Name = "ClientAdd";
            ClientAdd.Size = new Size(58, 23);
            ClientAdd.TabIndex = 3;
            ClientAdd.Text = "Dodaj";
            ClientAdd.UseVisualStyleBackColor = true;
            ClientAdd.Click += ClientAdd_Click;
            // 
            // ClientDel
            // 
            ClientDel.Location = new Point(115, 293);
            ClientDel.Name = "ClientDel";
            ClientDel.Size = new Size(58, 23);
            ClientDel.TabIndex = 5;
            ClientDel.Text = "Usuń";
            ClientDel.UseVisualStyleBackColor = true;
            ClientDel.Click += ClientDel_Click;
            // 
            // ClientEdit
            // 
            ClientEdit.Location = new Point(12, 322);
            ClientEdit.Name = "ClientEdit";
            ClientEdit.Size = new Size(161, 23);
            ClientEdit.TabIndex = 6;
            ClientEdit.Text = "Edytuj";
            ClientEdit.UseVisualStyleBackColor = true;
            ClientEdit.Click += ClientEdit_Click;
            // 
            // ClientClear
            // 
            ClientClear.Location = new Point(12, 351);
            ClientClear.Name = "ClientClear";
            ClientClear.Size = new Size(161, 23);
            ClientClear.TabIndex = 7;
            ClientClear.Text = "Wyczysc";
            ClientClear.UseVisualStyleBackColor = true;
            ClientClear.Click += ClientClear_Click;
            // 
            // ClientTextBox
            // 
            ClientTextBox.Location = new Point(12, 264);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.Size = new Size(161, 23);
            ClientTextBox.TabIndex = 8;
            ClientTextBox.TextChanged += ClientTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Klienci";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 9);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "Produkty";
            label2.Click += label2_Click;
            // 
            // ProduktTextBox
            // 
            ProduktTextBox.Location = new Point(311, 264);
            ProduktTextBox.Name = "ProduktTextBox";
            ProduktTextBox.Size = new Size(161, 23);
            ProduktTextBox.TabIndex = 11;
            ProduktTextBox.TextChanged += ProduktTextBox_TextChanged;
            // 
            // ProduktAdd
            // 
            ProduktAdd.Location = new Point(311, 293);
            ProduktAdd.Name = "ProduktAdd";
            ProduktAdd.Size = new Size(58, 23);
            ProduktAdd.TabIndex = 12;
            ProduktAdd.Text = "Dodaj";
            ProduktAdd.UseVisualStyleBackColor = true;
            ProduktAdd.Click += ProduktAdd_Click;
            // 
            // ProduktDel
            // 
            ProduktDel.Location = new Point(414, 293);
            ProduktDel.Name = "ProduktDel";
            ProduktDel.Size = new Size(58, 23);
            ProduktDel.TabIndex = 13;
            ProduktDel.Text = "Usuń";
            ProduktDel.UseVisualStyleBackColor = true;
            ProduktDel.Click += ProduktDel_Click;
            // 
            // ProduktEdit
            // 
            ProduktEdit.Location = new Point(311, 322);
            ProduktEdit.Name = "ProduktEdit";
            ProduktEdit.Size = new Size(161, 23);
            ProduktEdit.TabIndex = 14;
            ProduktEdit.Text = "Edytuj";
            ProduktEdit.UseVisualStyleBackColor = true;
            ProduktEdit.Click += ProduktEdit_Click;
            // 
            // ProduktClear
            // 
            ProduktClear.Location = new Point(311, 351);
            ProduktClear.Name = "ProduktClear";
            ProduktClear.Size = new Size(161, 23);
            ProduktClear.TabIndex = 15;
            ProduktClear.Text = "Wyczysc";
            ProduktClear.UseVisualStyleBackColor = true;
            ProduktClear.Click += ProduktClear_Click;
            // 
            // ZamowieniaAdd
            // 
            ZamowieniaAdd.Location = new Point(627, 264);
            ZamowieniaAdd.Name = "ZamowieniaAdd";
            ZamowieniaAdd.Size = new Size(161, 23);
            ZamowieniaAdd.TabIndex = 16;
            ZamowieniaAdd.Text = "Dodaj Zamówienie";
            ZamowieniaAdd.UseVisualStyleBackColor = true;
            ZamowieniaAdd.Click += ZamowieniaAdd_Click;
            // 
            // ZamowieniaDel
            // 
            ZamowieniaDel.Location = new Point(627, 293);
            ZamowieniaDel.Name = "ZamowieniaDel";
            ZamowieniaDel.Size = new Size(161, 23);
            ZamowieniaDel.TabIndex = 17;
            ZamowieniaDel.Text = "Usuń Zamówienie";
            ZamowieniaDel.UseVisualStyleBackColor = true;
            ZamowieniaDel.Click += ZamowieniaDel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(673, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 18;
            label3.Text = "Zamówienia";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(ZamowieniaDel);
            Controls.Add(ZamowieniaAdd);
            Controls.Add(ProduktClear);
            Controls.Add(ProduktEdit);
            Controls.Add(ProduktDel);
            Controls.Add(ProduktAdd);
            Controls.Add(ProduktTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClientTextBox);
            Controls.Add(ClientClear);
            Controls.Add(ClientEdit);
            Controls.Add(ClientDel);
            Controls.Add(ClientAdd);
            Controls.Add(ZamowieniaListBox);
            Controls.Add(ProduktListBox);
            Controls.Add(ClientList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ClientList;
        private ListBox ProduktListBox;
        private ListBox ZamowieniaListBox;
        private Button ClientAdd;
        private Button ClientDel;
        private Button ClientEdit;
        private Button ClientClear;
        private TextBox ClientTextBox;
        private Label label1;
        private Label label2;
        private TextBox ProduktTextBox;
        private Button ProduktAdd;
        private Button ProduktDel;
        private Button ProduktEdit;
        private Button ProduktClear;
        private Button ZamowieniaAdd;
        private Button ZamowieniaDel;
        private Label label3;
    }
}
