
namespace Ejercicio_BCO
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantClient = new System.Windows.Forms.TextBox();
            this.cantCuent = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestión Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gestión Cuentas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(155, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(155, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 223);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(167, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(347, 66);
            this.button5.TabIndex = 0;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 755);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de cuentas";
            // 
            // cantClient
            // 
            this.cantClient.Enabled = false;
            this.cantClient.Location = new System.Drawing.Point(416, 661);
            this.cantClient.Name = "cantClient";
            this.cantClient.Size = new System.Drawing.Size(155, 38);
            this.cantClient.TabIndex = 7;
            // 
            // cantCuent
            // 
            this.cantCuent.Enabled = false;
            this.cantCuent.Location = new System.Drawing.Point(416, 752);
            this.cantCuent.Name = "cantCuent";
            this.cantCuent.Size = new System.Drawing.Size(155, 38);
            this.cantCuent.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 857);
            this.Controls.Add(this.cantCuent);
            this.Controls.Add(this.cantClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantClient;
        private System.Windows.Forms.TextBox cantCuent;
    }
}