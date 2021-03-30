
namespace MacoWIns
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
            this.radioBtn_Nueva = new System.Windows.Forms.RadioButton();
            this.radioBtn_Liq = new System.Windows.Forms.RadioButton();
            this.radioBtn_Promo = new System.Windows.Forms.RadioButton();
            this.radioBtn_Pantalon = new System.Windows.Forms.RadioButton();
            this.radioBtn_Camisa = new System.Windows.Forms.RadioButton();
            this.radioBtn_Saco = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AgregarItem = new System.Windows.Forms.Button();
            this.btn_FinalizarVenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_cantItems = new System.Windows.Forms.Label();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.btn_CalcularG = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FechaG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtn_Nueva
            // 
            this.radioBtn_Nueva.AutoSize = true;
            this.radioBtn_Nueva.Checked = true;
            this.radioBtn_Nueva.Location = new System.Drawing.Point(24, 12);
            this.radioBtn_Nueva.Name = "radioBtn_Nueva";
            this.radioBtn_Nueva.Size = new System.Drawing.Size(62, 19);
            this.radioBtn_Nueva.TabIndex = 0;
            this.radioBtn_Nueva.TabStop = true;
            this.radioBtn_Nueva.Text = " Nueva";
            this.radioBtn_Nueva.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioBtn_Nueva.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Liq
            // 
            this.radioBtn_Liq.AutoSize = true;
            this.radioBtn_Liq.Location = new System.Drawing.Point(24, 37);
            this.radioBtn_Liq.Name = "radioBtn_Liq";
            this.radioBtn_Liq.Size = new System.Drawing.Size(87, 19);
            this.radioBtn_Liq.TabIndex = 1;
            this.radioBtn_Liq.Text = "Liquidación";
            this.radioBtn_Liq.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Promo
            // 
            this.radioBtn_Promo.AutoSize = true;
            this.radioBtn_Promo.Location = new System.Drawing.Point(24, 62);
            this.radioBtn_Promo.Name = "radioBtn_Promo";
            this.radioBtn_Promo.Size = new System.Drawing.Size(84, 19);
            this.radioBtn_Promo.TabIndex = 2;
            this.radioBtn_Promo.Text = "Promoción";
            this.radioBtn_Promo.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Pantalon
            // 
            this.radioBtn_Pantalon.AutoSize = true;
            this.radioBtn_Pantalon.Location = new System.Drawing.Point(17, 62);
            this.radioBtn_Pantalon.Name = "radioBtn_Pantalon";
            this.radioBtn_Pantalon.Size = new System.Drawing.Size(72, 19);
            this.radioBtn_Pantalon.TabIndex = 5;
            this.radioBtn_Pantalon.Text = "Pantalón";
            this.radioBtn_Pantalon.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Camisa
            // 
            this.radioBtn_Camisa.AutoSize = true;
            this.radioBtn_Camisa.Location = new System.Drawing.Point(17, 37);
            this.radioBtn_Camisa.Name = "radioBtn_Camisa";
            this.radioBtn_Camisa.Size = new System.Drawing.Size(64, 19);
            this.radioBtn_Camisa.TabIndex = 4;
            this.radioBtn_Camisa.Text = "Camisa";
            this.radioBtn_Camisa.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Saco
            // 
            this.radioBtn_Saco.AutoSize = true;
            this.radioBtn_Saco.Checked = true;
            this.radioBtn_Saco.Location = new System.Drawing.Point(17, 12);
            this.radioBtn_Saco.Name = "radioBtn_Saco";
            this.radioBtn_Saco.Size = new System.Drawing.Size(50, 19);
            this.radioBtn_Saco.TabIndex = 3;
            this.radioBtn_Saco.TabStop = true;
            this.radioBtn_Saco.Text = "Saco";
            this.radioBtn_Saco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioBtn_Saco.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtn_Liq);
            this.panel1.Controls.Add(this.radioBtn_Nueva);
            this.panel1.Controls.Add(this.radioBtn_Promo);
            this.panel1.Location = new System.Drawing.Point(148, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioBtn_Camisa);
            this.panel2.Controls.Add(this.radioBtn_Saco);
            this.panel2.Controls.Add(this.radioBtn_Pantalon);
            this.panel2.Location = new System.Drawing.Point(22, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 100);
            this.panel2.TabIndex = 7;
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Enabled = false;
            this.textBox_fecha.Location = new System.Drawing.Point(75, 46);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.Size = new System.Drawing.Size(80, 23);
            this.textBox_fecha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "VENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "fecha";
            // 
            // btn_AgregarItem
            // 
            this.btn_AgregarItem.Location = new System.Drawing.Point(39, 208);
            this.btn_AgregarItem.Name = "btn_AgregarItem";
            this.btn_AgregarItem.Size = new System.Drawing.Size(195, 26);
            this.btn_AgregarItem.TabIndex = 11;
            this.btn_AgregarItem.Text = "Agregar item";
            this.btn_AgregarItem.UseVisualStyleBackColor = true;
            this.btn_AgregarItem.Click += new System.EventHandler(this.btn_AgregarItem_Click);
            // 
            // btn_FinalizarVenta
            // 
            this.btn_FinalizarVenta.Location = new System.Drawing.Point(39, 306);
            this.btn_FinalizarVenta.Name = "btn_FinalizarVenta";
            this.btn_FinalizarVenta.Size = new System.Drawing.Size(195, 34);
            this.btn_FinalizarVenta.TabIndex = 12;
            this.btn_FinalizarVenta.Text = "Finalizar Venta";
            this.btn_FinalizarVenta.UseVisualStyleBackColor = true;
            this.btn_FinalizarVenta.Click += new System.EventHandler(this.btn_FinalizarVenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad de items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Monto: ";
            // 
            // lbl_cantItems
            // 
            this.lbl_cantItems.AutoSize = true;
            this.lbl_cantItems.Location = new System.Drawing.Point(151, 240);
            this.lbl_cantItems.Name = "lbl_cantItems";
            this.lbl_cantItems.Size = new System.Drawing.Size(13, 15);
            this.lbl_cantItems.TabIndex = 15;
            this.lbl_cantItems.Text = "0";
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(151, 261);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(13, 15);
            this.lbl_Monto.TabIndex = 16;
            this.lbl_Monto.Text = "0";
            // 
            // btn_CalcularG
            // 
            this.btn_CalcularG.Location = new System.Drawing.Point(393, 98);
            this.btn_CalcularG.Name = "btn_CalcularG";
            this.btn_CalcularG.Size = new System.Drawing.Size(233, 23);
            this.btn_CalcularG.TabIndex = 17;
            this.btn_CalcularG.Text = "BUSCAR";
            this.btn_CalcularG.UseVisualStyleBackColor = true;
            this.btn_CalcularG.Click += new System.EventHandler(this.btn_CalcularG_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Buscar ganancia del día: ";
            // 
            // textBox_FechaG
            // 
            this.textBox_FechaG.Location = new System.Drawing.Point(538, 46);
            this.textBox_FechaG.Name = "textBox_FechaG";
            this.textBox_FechaG.Size = new System.Drawing.Size(80, 23);
            this.textBox_FechaG.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "DD/MM/AAAA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 387);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_FechaG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_CalcularG);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.lbl_cantItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_FinalizarVenta);
            this.Controls.Add(this.btn_AgregarItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_fecha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_Nueva;
        private System.Windows.Forms.RadioButton radioBtn_Liq;
        private System.Windows.Forms.RadioButton radioBtn_Promo;
        private System.Windows.Forms.RadioButton radioBtn_Pantalon;
        private System.Windows.Forms.RadioButton radioBtn_Camisa;
        private System.Windows.Forms.RadioButton radioBtn_Saco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AgregarItem;
        private System.Windows.Forms.Button btn_FinalizarVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_cantItems;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Button btn_CalcularG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FechaG;
        private System.Windows.Forms.Label label6;
    }
}

