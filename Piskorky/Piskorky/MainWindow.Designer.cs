namespace Piskorky
{
    partial class MainWindow
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
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.gameGridField = new System.Windows.Forms.DataGridView();
            this.StepBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameGridField)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Items.AddRange(new object[] {
            "New Game",
            "Save Game",
            "Load Game",
            "Exit"});
            this.comboBoxMenu.Location = new System.Drawing.Point(1, 1);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMenu.TabIndex = 0;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // gameGridField
            // 
            this.gameGridField.AllowUserToAddRows = false;
            this.gameGridField.AllowUserToDeleteRows = false;
            this.gameGridField.AllowUserToResizeColumns = false;
            this.gameGridField.AllowUserToResizeRows = false;
            this.gameGridField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameGridField.ColumnHeadersVisible = false;
            this.gameGridField.Location = new System.Drawing.Point(1, 28);
            this.gameGridField.Name = "gameGridField";
            this.gameGridField.RowHeadersVisible = false;
            this.gameGridField.Size = new System.Drawing.Size(801, 422);
            this.gameGridField.TabIndex = 1;
            this.gameGridField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameGridField_CellClick);
            this.gameGridField.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StepBack
            // 
            this.StepBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepBack.Location = new System.Drawing.Point(628, 1);
            this.StepBack.Name = "StepBack";
            this.StepBack.Size = new System.Drawing.Size(174, 26);
            this.StepBack.TabIndex = 2;
            this.StepBack.Text = "Go back by one turn";
            this.StepBack.UseVisualStyleBackColor = true;
            this.StepBack.Click += new System.EventHandler(this.StepBack_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StepBack);
            this.Controls.Add(this.gameGridField);
            this.Controls.Add(this.comboBoxMenu);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGridField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.DataGridView gameGridField;
        private System.Windows.Forms.Button StepBack;
    }
}

