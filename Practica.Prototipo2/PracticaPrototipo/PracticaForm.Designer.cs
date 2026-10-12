namespace Practica.Prototipo2.PracticaPrototipo
{
    partial class PracticaForm
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 1;
            label1.Text = "Fecha de Entrega:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 2;
            label2.Text = "Datos Obligatorios:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 77);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 3;
            label3.Text = "Razon social del cliente:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(409, 33);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 5;
            label4.Text = "Es pallet cerrado?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(12, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Si";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(87, 191);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 29);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "No";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 163);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 8;
            label5.Text = "CUIT de Cliente";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(379, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 31);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(526, 407);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 10;
            button1.Text = "Cargar Orden";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(676, 407);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // PracticaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "PracticaForm";
            Text = "PracticaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}