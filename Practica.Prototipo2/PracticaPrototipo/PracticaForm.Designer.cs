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
            textBox1 = new TextBox();
            Clientetxt = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // Clientetxt
            // 
            Clientetxt.BorderStyle = BorderStyle.None;
            Clientetxt.Location = new Point(68, 197);
            Clientetxt.Name = "Clientetxt";
            Clientetxt.Size = new Size(150, 24);
            Clientetxt.TabIndex = 1;
            // 
            // PracticaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Clientetxt);
            Controls.Add(textBox1);
            Name = "PracticaForm";
            Text = "PracticaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox Clientetxt;
    }
}