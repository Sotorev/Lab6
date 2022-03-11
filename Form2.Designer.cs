namespace Lab6
{
    partial class Form2
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.rentalButton = new System.Windows.Forms.Button();
            this.traveledTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.rentalIdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nitTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reigstrarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greaterKMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 186);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1075, 150);
            this.dataGridView3.TabIndex = 37;
            // 
            // rentalButton
            // 
            this.rentalButton.BackColor = System.Drawing.Color.LawnGreen;
            this.rentalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalButton.Location = new System.Drawing.Point(859, 85);
            this.rentalButton.Name = "rentalButton";
            this.rentalButton.Size = new System.Drawing.Size(153, 37);
            this.rentalButton.TabIndex = 36;
            this.rentalButton.Text = "Alquilar vehiculo";
            this.rentalButton.UseVisualStyleBackColor = false;
            this.rentalButton.Click += new System.EventHandler(this.rentalButton_Click_1);
            // 
            // traveledTextBox
            // 
            this.traveledTextBox.Location = new System.Drawing.Point(524, 93);
            this.traveledTextBox.Name = "traveledTextBox";
            this.traveledTextBox.Size = new System.Drawing.Size(187, 20);
            this.traveledTextBox.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(412, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Km recorridos";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(573, 133);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Fecha de devolucion";
            // 
            // rentalIdTextBox
            // 
            this.rentalIdTextBox.Location = new System.Drawing.Point(84, 134);
            this.rentalIdTextBox.Name = "rentalIdTextBox";
            this.rentalIdTextBox.Size = new System.Drawing.Size(232, 20);
            this.rentalIdTextBox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Placa";
            // 
            // nitTextBox
            // 
            this.nitTextBox.Location = new System.Drawing.Point(84, 93);
            this.nitTextBox.Name = "nitTextBox";
            this.nitTextBox.Size = new System.Drawing.Size(232, 20);
            this.nitTextBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Nit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Datos necesarios para alquilar vehiculo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reigstrarVehiculoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reigstrarVehiculoToolStripMenuItem
            // 
            this.reigstrarVehiculoToolStripMenuItem.Name = "reigstrarVehiculoToolStripMenuItem";
            this.reigstrarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.reigstrarVehiculoToolStripMenuItem.Text = "Registrar vehiculo";
            this.reigstrarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.reigstrarVehiculoToolStripMenuItem_Click);
            // 
            // greaterKMLabel
            // 
            this.greaterKMLabel.AutoSize = true;
            this.greaterKMLabel.Location = new System.Drawing.Point(416, 44);
            this.greaterKMLabel.Name = "greaterKMLabel";
            this.greaterKMLabel.Size = new System.Drawing.Size(126, 13);
            this.greaterKMLabel.TabIndex = 39;
            this.greaterKMLabel.Text = "Mas kilometros recorridos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 386);
            this.Controls.Add(this.greaterKMLabel);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.rentalButton);
            this.Controls.Add(this.traveledTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rentalIdTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nitTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button rentalButton;
        private System.Windows.Forms.TextBox traveledTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rentalIdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nitTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reigstrarVehiculoToolStripMenuItem;
        private System.Windows.Forms.Label greaterKMLabel;
    }
}