namespace Atividade01.View
{
    partial class Atividade
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
            components = new System.ComponentModel.Container();
            tbx_valor1 = new TextBox();
            tbx_valor2 = new TextBox();
            label1 = new Label();
            lbl_Valor1 = new Label();
            lbl_Valor2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn_soma = new Button();
            lbl_responde = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // tbx_valor1
            // 
            tbx_valor1.Location = new Point(120, 191);
            tbx_valor1.Name = "tbx_valor1";
            tbx_valor1.Size = new Size(98, 23);
            tbx_valor1.TabIndex = 0;
            tbx_valor1.TextChanged += textBox1_TextChanged;
            // 
            // tbx_valor2
            // 
            tbx_valor2.Location = new Point(120, 251);
            tbx_valor2.Name = "tbx_valor2";
            tbx_valor2.Size = new Size(98, 23);
            tbx_valor2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 23);
            label1.Name = "label1";
            label1.Size = new Size(93, 33);
            label1.TabIndex = 2;
            label1.Text = "Soma ";
            label1.Click += label1_Click;
            // 
            // lbl_Valor1
            // 
            lbl_Valor1.AutoSize = true;
            lbl_Valor1.Location = new Point(61, 194);
            lbl_Valor1.Name = "lbl_Valor1";
            lbl_Valor1.Size = new Size(39, 15);
            lbl_Valor1.TabIndex = 3;
            lbl_Valor1.Text = "Valor1";
            lbl_Valor1.Click += label2_Click;
            // 
            // lbl_Valor2
            // 
            lbl_Valor2.AutoSize = true;
            lbl_Valor2.Location = new Point(61, 254);
            lbl_Valor2.Name = "lbl_Valor2";
            lbl_Valor2.Size = new Size(39, 15);
            lbl_Valor2.TabIndex = 4;
            lbl_Valor2.Text = "Valor2";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn_soma
            // 
            btn_soma.Location = new Point(45, 324);
            btn_soma.Name = "btn_soma";
            btn_soma.Size = new Size(240, 60);
            btn_soma.TabIndex = 6;
            btn_soma.Text = "Soma";
            btn_soma.UseVisualStyleBackColor = true;
            btn_soma.Click += btn_soma_Click;
            // 
            // lbl_responde
            // 
            lbl_responde.BackColor = SystemColors.GradientActiveCaption;
            lbl_responde.Font = new Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_responde.Location = new Point(45, 123);
            lbl_responde.Name = "lbl_responde";
            lbl_responde.Size = new Size(240, 37);
            lbl_responde.TabIndex = 7;
            lbl_responde.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(120, 66);
            label5.Name = "label5";
            label5.Size = new Size(174, 30);
            label5.TabIndex = 8;
            label5.Text = "Dois Valores";
            // 
            // Atividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 418);
            Controls.Add(label5);
            Controls.Add(lbl_responde);
            Controls.Add(btn_soma);
            Controls.Add(lbl_Valor2);
            Controls.Add(lbl_Valor1);
            Controls.Add(label1);
            Controls.Add(tbx_valor2);
            Controls.Add(tbx_valor1);
            Name = "Atividade";
            Text = "TelaSoma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_valor1;
        private TextBox tbx_valor2;
        private Label label1;
        private Label lbl_Valor1;
        private Label lbl_Valor2;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_soma;
        private Label lbl_responde;
        private Label label5;
    }
}