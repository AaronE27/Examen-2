namespace Converciones
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
            comboBox1 = new ComboBox();
            llbMoneda = new Label();
            lblMonto = new Label();
            textBox1 = new TextBox();
            Calcular = new Button();
            Converciones = new Label();
            lblpeso = new Label();
            txtpesos = new TextBox();
            txtdolarusa = new TextBox();
            txtdolarcan = new TextBox();
            txteuro = new TextBox();
            txtyen = new TextBox();
            lblusa = new Label();
            lblcad = new Label();
            lbleu = new Label();
            lblyen = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownWidth = 332;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MXN - Peso mexicano", "USD - Dolar Estadounidense", "CAD - Dolar canadiense", "EUR - Euro", "JPY - Yen Japones" });
            comboBox1.Location = new Point(52, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 40);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // llbMoneda
            // 
            llbMoneda.AutoSize = true;
            llbMoneda.Location = new Point(52, 9);
            llbMoneda.Name = "llbMoneda";
            llbMoneda.Size = new Size(103, 32);
            llbMoneda.TabIndex = 1;
            llbMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(467, 9);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(86, 32);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(467, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 3;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(467, 118);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(200, 46);
            Calcular.TabIndex = 4;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Converciones
            // 
            Converciones.AutoSize = true;
            Converciones.Location = new Point(113, 217);
            Converciones.Name = "Converciones";
            Converciones.Size = new Size(158, 32);
            Converciones.TabIndex = 5;
            Converciones.Text = "Converciones";
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.Location = new Point(113, 284);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new Size(141, 32);
            lblpeso.TabIndex = 6;
            lblpeso.Text = "MNX - Peso";
            lblpeso.Visible = false;
            // 
            // txtpesos
            // 
            txtpesos.Location = new Point(467, 277);
            txtpesos.Name = "txtpesos";
            txtpesos.Size = new Size(200, 39);
            txtpesos.TabIndex = 7;
            txtpesos.Visible = false;
            // 
            // txtdolarusa
            // 
            txtdolarusa.Location = new Point(467, 355);
            txtdolarusa.Name = "txtdolarusa";
            txtdolarusa.Size = new Size(200, 39);
            txtdolarusa.TabIndex = 8;
            txtdolarusa.Visible = false;
            // 
            // txtdolarcan
            // 
            txtdolarcan.Location = new Point(467, 424);
            txtdolarcan.Name = "txtdolarcan";
            txtdolarcan.Size = new Size(200, 39);
            txtdolarcan.TabIndex = 9;
            txtdolarcan.Visible = false;
            // 
            // txteuro
            // 
            txteuro.Location = new Point(467, 500);
            txteuro.Name = "txteuro";
            txteuro.Size = new Size(200, 39);
            txteuro.TabIndex = 10;
            txteuro.Visible = false;
            // 
            // txtyen
            // 
            txtyen.Location = new Point(467, 572);
            txtyen.Name = "txtyen";
            txtyen.Size = new Size(200, 39);
            txtyen.TabIndex = 11;
            txtyen.Visible = false;
            // 
            // lblusa
            // 
            lblusa.AutoSize = true;
            lblusa.Location = new Point(113, 355);
            lblusa.Name = "lblusa";
            lblusa.Size = new Size(141, 32);
            lblusa.TabIndex = 12;
            lblusa.Text = "USD - Dolar";
            lblusa.Visible = false;
            // 
            // lblcad
            // 
            lblcad.AutoSize = true;
            lblcad.Location = new Point(113, 424);
            lblcad.Name = "lblcad";
            lblcad.Size = new Size(139, 32);
            lblcad.TabIndex = 13;
            lblcad.Text = "CAD - dolar";
            lblcad.Visible = false;
            // 
            // lbleu
            // 
            lbleu.AutoSize = true;
            lbleu.Location = new Point(113, 500);
            lbleu.Name = "lbleu";
            lbleu.Size = new Size(128, 32);
            lbleu.TabIndex = 14;
            lbleu.Text = "EUR - Euro";
            lbleu.Visible = false;
            // 
            // lblyen
            // 
            lblyen.AutoSize = true;
            lblyen.Location = new Point(113, 579);
            lblyen.Name = "lblyen";
            lblyen.Size = new Size(201, 32);
            lblyen.TabIndex = 15;
            lblyen.Text = "JPY - Yen japones";
            lblyen.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 669);
            Controls.Add(lblyen);
            Controls.Add(lbleu);
            Controls.Add(lblcad);
            Controls.Add(lblusa);
            Controls.Add(txtyen);
            Controls.Add(txteuro);
            Controls.Add(txtdolarcan);
            Controls.Add(txtdolarusa);
            Controls.Add(txtpesos);
            Controls.Add(lblpeso);
            Controls.Add(Converciones);
            Controls.Add(Calcular);
            Controls.Add(textBox1);
            Controls.Add(lblMonto);
            Controls.Add(llbMoneda);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label llbMoneda;
        private Label lblMonto;
        private TextBox textBox1;
        private Button Calcular;
        private Label Converciones;
        private Label lblpeso;
        private TextBox txtpesos;
        private TextBox txtdolarusa;
        private TextBox txtdolarcan;
        private TextBox txteuro;
        private TextBox txtyen;
        private Label lblusa;
        private Label lblcad;
        private Label lbleu;
        private Label lblyen;
    }
}