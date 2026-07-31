namespace MenuColmado
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
            txtCantidad = new TextBox();
            groupBox1 = new GroupBox();
            rdbTarjeta = new RadioButton();
            rdbEfectivo = new RadioButton();
            btnCalcular = new Button();
            label2 = new Label();
            lblTotal = new Label();
            label1 = new Label();
            cmbProductos = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(104, 91);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(219, 23);
            txtCantidad.TabIndex = 0;
            txtCantidad.Text = "1 ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbTarjeta);
            groupBox1.Controls.Add(rdbEfectivo);
            groupBox1.Location = new Point(52, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de pago";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(6, 47);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(144, 19);
            rdbTarjeta.TabIndex = 1;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta (+10% recargo)";
            rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Checked = true;
            rdbEfectivo.Location = new Point(6, 22);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(67, 19);
            rdbEfectivo.TabIndex = 0;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            rdbEfectivo.CheckedChanged += rdbEfectivo_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(52, 280);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 94);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Cantidad:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTotal.Location = new Point(40, 358);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(122, 13);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total a pagar: RD$ 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Producto";
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Items.AddRange(new object[] { "Plátano verde - RD$ 25", "Refresco 2L - RD$ 100", "Arroz (1 lb) - RD$ 45", "Aceite (16 oz) - RD$ 85", "Salami (1 lb) - RD$ 150", "Queso GEO (1 lb) - RD$ 220", "Habichuelas (1 lb) - RD$ 60" });
            cmbProductos.Location = new Point(129, 25);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(121, 23);
            cmbProductos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbProductos);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox1);
            Controls.Add(txtCantidad);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCantidad;
        private GroupBox groupBox1;
        private RadioButton rdbEfectivo;
        private Button btnCalcular;
        private Label label2;
        private RadioButton rdbTarjeta;
        private Label lblTotal;
        private Label label1;
        private ComboBox cmbProductos;
    }
}
