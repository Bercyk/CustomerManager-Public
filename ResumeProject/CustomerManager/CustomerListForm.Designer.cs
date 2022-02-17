namespace CustomerManager
{
    partial class CustomerListForm
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
            this.CustomerListLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CustomerListView = new System.Windows.Forms.ListView();
            this.CustomerName = new System.Windows.Forms.ColumnHeader();
            this.NIP = new System.Windows.Forms.ColumnHeader();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerListLabel
            // 
            this.CustomerListLabel.AutoSize = true;
            this.CustomerListLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.CustomerListLabel.Location = new System.Drawing.Point(20, 20);
            this.CustomerListLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerListLabel.Name = "CustomerListLabel";
            this.CustomerListLabel.Size = new System.Drawing.Size(189, 30);
            this.CustomerListLabel.TabIndex = 0;
            this.CustomerListLabel.Text = "Lista kontrahentów";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(30, 60);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 25);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(115, 60);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 25);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edytuj";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CustomerListView
            // 
            this.CustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerName,
            this.NIP});
            this.CustomerListView.FullRowSelect = true;
            this.CustomerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CustomerListView.Location = new System.Drawing.Point(20, 90);
            this.CustomerListView.MultiSelect = false;
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(550, 350);
            this.CustomerListView.TabIndex = 3;
            this.CustomerListView.UseCompatibleStateImageBehavior = false;
            this.CustomerListView.View = System.Windows.Forms.View.Details;
            // 
            // CustomerName
            // 
            this.CustomerName.Name = "CustomerListForm";
            this.CustomerName.Text = "Nazwa kontrahenta";
            this.CustomerName.Width = 350;
            // 
            // NIP
            // 
            this.NIP.Text = "NIP";
            this.NIP.Width = 196;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(503, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Wyjdź";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 460);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CustomerListView);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomerListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CustomerListLabel;
        private Button AddButton;
        private Button EditButton;
        private ListView CustomerListView;
        private ColumnHeader CustomerName;
        private ColumnHeader NIP;
        private Button ExitButton;
    }
}