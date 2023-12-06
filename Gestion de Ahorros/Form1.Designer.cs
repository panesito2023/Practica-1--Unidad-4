namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.saldo = new System.Windows.Forms.TextBox();
            this.deposito = new System.Windows.Forms.Button();
            this.retiro = new System.Windows.Forms.Button();
            this.abrirCuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaDeposito = new System.Windows.Forms.ListBox();
            this.ListaRetiros = new System.Windows.Forms.ListBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.abrirCuenta);
            this.groupBox1.Controls.Add(this.monto);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.retiro);
            this.groupBox2.Controls.Add(this.deposito);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trasacciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nuevo);
            this.groupBox3.Controls.Add(this.ListaRetiros);
            this.groupBox3.Controls.Add(this.ListaDeposito);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.saldo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historial";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(83, 33);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(148, 25);
            this.nombre.TabIndex = 0;
            // 
            // monto
            // 
            this.monto.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(83, 63);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(148, 25);
            this.monto.TabIndex = 1;
            // 
            // saldo
            // 
            this.saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo.Location = new System.Drawing.Point(272, 146);
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Size = new System.Drawing.Size(84, 21);
            this.saldo.TabIndex = 0;
            // 
            // deposito
            // 
            this.deposito.AutoSize = true;
            this.deposito.Location = new System.Drawing.Point(44, 46);
            this.deposito.Name = "deposito";
            this.deposito.Size = new System.Drawing.Size(86, 28);
            this.deposito.TabIndex = 0;
            this.deposito.Text = "Deposito";
            this.deposito.UseVisualStyleBackColor = true;
            this.deposito.Click += new System.EventHandler(this.deposito_Click);
            // 
            // retiro
            // 
            this.retiro.AutoSize = true;
            this.retiro.Location = new System.Drawing.Point(248, 46);
            this.retiro.Name = "retiro";
            this.retiro.Size = new System.Drawing.Size(75, 28);
            this.retiro.TabIndex = 1;
            this.retiro.Text = "Retiro";
            this.retiro.UseVisualStyleBackColor = true;
            this.retiro.Click += new System.EventHandler(this.retiro_Click);
            // 
            // abrirCuenta
            // 
            this.abrirCuenta.Location = new System.Drawing.Point(263, 33);
            this.abrirCuenta.Name = "abrirCuenta";
            this.abrirCuenta.Size = new System.Drawing.Size(84, 44);
            this.abrirCuenta.TabIndex = 2;
            this.abrirCuenta.Text = "Abrir Cuenta";
            this.abrirCuenta.UseVisualStyleBackColor = true;
            this.abrirCuenta.Click += new System.EventHandler(this.abrirCuenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Deposito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Retiros";
            // 
            // ListaDeposito
            // 
            this.ListaDeposito.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDeposito.FormattingEnabled = true;
            this.ListaDeposito.ItemHeight = 17;
            this.ListaDeposito.Location = new System.Drawing.Point(10, 49);
            this.ListaDeposito.Name = "ListaDeposito";
            this.ListaDeposito.Size = new System.Drawing.Size(120, 174);
            this.ListaDeposito.TabIndex = 3;
            // 
            // ListaRetiros
            // 
            this.ListaRetiros.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRetiros.FormattingEnabled = true;
            this.ListaRetiros.ItemHeight = 17;
            this.ListaRetiros.Location = new System.Drawing.Point(137, 49);
            this.ListaRetiros.Name = "ListaRetiros";
            this.ListaRetiros.Size = new System.Drawing.Size(120, 174);
            this.ListaRetiros.TabIndex = 4;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(272, 173);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 23);
            this.nuevo.TabIndex = 5;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Saldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion de cuenta de ahorro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button abrirCuenta;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button retiro;
        private System.Windows.Forms.Button deposito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox saldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.ListBox ListaRetiros;
        private System.Windows.Forms.ListBox ListaDeposito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

