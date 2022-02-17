namespace CustomerManager
{
    partial class AddEditCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEditCustomerLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.NIPLabel = new System.Windows.Forms.Label();
            this.CustomerTypeLabel = new System.Windows.Forms.Label();
            this.CustomerDescriptionLabel = new System.Windows.Forms.Label();
            this.CustomerStatusLabel = new System.Windows.Forms.Label();
            this.CustomerStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomerNameTextbox = new System.Windows.Forms.TextBox();
            this.NIPTextbox = new System.Windows.Forms.TextBox();
            this.CustomerTypeCombobox = new System.Windows.Forms.ComboBox();
            this.CustomerDescriptionRichTextbox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEditCustomerLabel
            // 
            this.AddEditCustomerLabel.AutoSize = true;
            this.AddEditCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.AddEditCustomerLabel.Location = new System.Drawing.Point(32, 25);
            this.AddEditCustomerLabel.Margin = new System.Windows.Forms.Padding(5);
            this.AddEditCustomerLabel.Name = "AddEditCustomerLabel";
            this.AddEditCustomerLabel.Size = new System.Drawing.Size(263, 30);
            this.AddEditCustomerLabel.TabIndex = 1;
            this.AddEditCustomerLabel.Text = "Dodaj / edytuj kontrahenta";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameLabel.Location = new System.Drawing.Point(50, 80);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(148, 21);
            this.CustomerNameLabel.TabIndex = 2;
            this.CustomerNameLabel.Text = "Nazwa kontrahenta:";
            // 
            // NIPLabel
            // 
            this.NIPLabel.AutoSize = true;
            this.NIPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NIPLabel.Location = new System.Drawing.Point(50, 121);
            this.NIPLabel.Name = "NIPLabel";
            this.NIPLabel.Size = new System.Drawing.Size(35, 21);
            this.NIPLabel.TabIndex = 3;
            this.NIPLabel.Text = "NIP";
            // 
            // CustomerTypeLabel
            // 
            this.CustomerTypeLabel.AutoSize = true;
            this.CustomerTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerTypeLabel.Location = new System.Drawing.Point(50, 162);
            this.CustomerTypeLabel.Name = "CustomerTypeLabel";
            this.CustomerTypeLabel.Size = new System.Drawing.Size(125, 21);
            this.CustomerTypeLabel.TabIndex = 4;
            this.CustomerTypeLabel.Text = "Typ kontrahenta:";
            // 
            // CustomerDescriptionLabel
            // 
            this.CustomerDescriptionLabel.AutoSize = true;
            this.CustomerDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerDescriptionLabel.Location = new System.Drawing.Point(50, 203);
            this.CustomerDescriptionLabel.Name = "CustomerDescriptionLabel";
            this.CustomerDescriptionLabel.Size = new System.Drawing.Size(86, 21);
            this.CustomerDescriptionLabel.TabIndex = 5;
            this.CustomerDescriptionLabel.Text = "Opis firmy:";
            // 
            // CustomerStatusLabel
            // 
            this.CustomerStatusLabel.AutoSize = true;
            this.CustomerStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerStatusLabel.Location = new System.Drawing.Point(50, 337);
            this.CustomerStatusLabel.Name = "CustomerStatusLabel";
            this.CustomerStatusLabel.Size = new System.Drawing.Size(152, 21);
            this.CustomerStatusLabel.TabIndex = 6;
            this.CustomerStatusLabel.Text = "Kontrahent aktywny:";
            // 
            // CustomerStatusCheckBox
            // 
            this.CustomerStatusCheckBox.AutoSize = true;
            this.CustomerStatusCheckBox.Checked = true;
            this.CustomerStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustomerStatusCheckBox.Location = new System.Drawing.Point(208, 343);
            this.CustomerStatusCheckBox.Name = "CustomerStatusCheckBox";
            this.CustomerStatusCheckBox.Size = new System.Drawing.Size(15, 14);
            this.CustomerStatusCheckBox.TabIndex = 7;
            this.CustomerStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // CustomerNameTextbox
            // 
            this.CustomerNameTextbox.Location = new System.Drawing.Point(205, 80);
            this.CustomerNameTextbox.MaxLength = 50;
            this.CustomerNameTextbox.Name = "CustomerNameTextbox";
            this.CustomerNameTextbox.Size = new System.Drawing.Size(480, 23);
            this.CustomerNameTextbox.TabIndex = 8;
            // 
            // NIPTextbox
            // 
            this.NIPTextbox.Location = new System.Drawing.Point(205, 121);
            this.NIPTextbox.MaxLength = 10;
            this.NIPTextbox.Name = "NIPTextbox";
            this.NIPTextbox.Size = new System.Drawing.Size(480, 23);
            this.NIPTextbox.TabIndex = 9;
            this.NIPTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NIPTextbox_KeyPress);
            // 
            // CustomerTypeCombobox
            // 
            this.CustomerTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerTypeCombobox.FormattingEnabled = true;
            this.CustomerTypeCombobox.Location = new System.Drawing.Point(205, 162);
            this.CustomerTypeCombobox.Name = "CustomerTypeCombobox";
            this.CustomerTypeCombobox.Size = new System.Drawing.Size(480, 23);
            this.CustomerTypeCombobox.TabIndex = 10;
            // 
            // CustomerDescriptionRichTextbox
            // 
            this.CustomerDescriptionRichTextbox.Location = new System.Drawing.Point(205, 203);
            this.CustomerDescriptionRichTextbox.MaxLength = 500;
            this.CustomerDescriptionRichTextbox.Name = "CustomerDescriptionRichTextbox";
            this.CustomerDescriptionRichTextbox.Size = new System.Drawing.Size(480, 125);
            this.CustomerDescriptionRichTextbox.TabIndex = 11;
            this.CustomerDescriptionRichTextbox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(605, 370);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 25);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(608, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 25);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Anuluj";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddEditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CustomerDescriptionRichTextbox);
            this.Controls.Add(this.CustomerTypeCombobox);
            this.Controls.Add(this.NIPTextbox);
            this.Controls.Add(this.CustomerNameTextbox);
            this.Controls.Add(this.CustomerStatusCheckBox);
            this.Controls.Add(this.CustomerStatusLabel);
            this.Controls.Add(this.CustomerDescriptionLabel);
            this.Controls.Add(this.CustomerTypeLabel);
            this.Controls.Add(this.NIPLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.AddEditCustomerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddEditCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddEditCustomerLabel;
        private Label CustomerNameLabel;
        private Label NIPLabel;
        private Label CustomerTypeLabel;
        private Label CustomerDescriptionLabel;
        private Label CustomerStatusLabel;
        private CheckBox CustomerStatusCheckBox;
        private TextBox CustomerNameTextbox;
        private TextBox NIPTextbox;
        private ComboBox CustomerTypeCombobox;
        private RichTextBox CustomerDescriptionRichTextbox;
        private Button SaveButton;
        private Button BackButton;
    }
}