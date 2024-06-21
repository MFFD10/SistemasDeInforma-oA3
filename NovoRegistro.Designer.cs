namespace Sistema_do_HotelA3
{
    partial class Screen_NovaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_NovaReserva));
            this.Titulo_NovoRegistro = new System.Windows.Forms.Label();
            this.button_Concluir = new System.Windows.Forms.Button();
            this.Label_Nome_Cliente = new System.Windows.Forms.Label();
            this.Label_Email_Cliente = new System.Windows.Forms.Label();
            this.Label_Data_Reserva = new System.Windows.Forms.Label();
            this.Label_Pagamento_Reserva = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.select_Data = new System.Windows.Forms.DateTimePicker();
            this.Forma_Pagamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Titulo_NovoRegistro
            // 
            this.Titulo_NovoRegistro.AutoSize = true;
            this.Titulo_NovoRegistro.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_NovoRegistro.Location = new System.Drawing.Point(35, 50);
            this.Titulo_NovoRegistro.Name = "Titulo_NovoRegistro";
            this.Titulo_NovoRegistro.Size = new System.Drawing.Size(512, 56);
            this.Titulo_NovoRegistro.TabIndex = 0;
            this.Titulo_NovoRegistro.Text = "Cadastro de Reserva";
            // 
            // button_Concluir
            // 
            this.button_Concluir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_Concluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Concluir.Location = new System.Drawing.Point(150, 500);
            this.button_Concluir.Name = "button_Concluir";
            this.button_Concluir.Size = new System.Drawing.Size(253, 35);
            this.button_Concluir.TabIndex = 1;
            this.button_Concluir.Text = "Concluir";
            this.button_Concluir.UseVisualStyleBackColor = false;
            this.button_Concluir.Click += new System.EventHandler(this.button_Concluir_Click);
            // 
            // Label_Nome_Cliente
            // 
            this.Label_Nome_Cliente.AutoSize = true;
            this.Label_Nome_Cliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nome_Cliente.Location = new System.Drawing.Point(40, 160);
            this.Label_Nome_Cliente.Name = "Label_Nome_Cliente";
            this.Label_Nome_Cliente.Size = new System.Drawing.Size(198, 24);
            this.Label_Nome_Cliente.TabIndex = 2;
            this.Label_Nome_Cliente.Text = "Nome Completo: ";
            // 
            // Label_Email_Cliente
            // 
            this.Label_Email_Cliente.AutoSize = true;
            this.Label_Email_Cliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email_Cliente.Location = new System.Drawing.Point(40, 230);
            this.Label_Email_Cliente.Name = "Label_Email_Cliente";
            this.Label_Email_Cliente.Size = new System.Drawing.Size(201, 24);
            this.Label_Email_Cliente.TabIndex = 3;
            this.Label_Email_Cliente.Text = "Email de Contato: ";
            // 
            // Label_Data_Reserva
            // 
            this.Label_Data_Reserva.AutoSize = true;
            this.Label_Data_Reserva.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Data_Reserva.Location = new System.Drawing.Point(40, 300);
            this.Label_Data_Reserva.Name = "Label_Data_Reserva";
            this.Label_Data_Reserva.Size = new System.Drawing.Size(194, 24);
            this.Label_Data_Reserva.TabIndex = 4;
            this.Label_Data_Reserva.Text = "Data da Reserva: ";
            // 
            // Label_Pagamento_Reserva
            // 
            this.Label_Pagamento_Reserva.AutoSize = true;
            this.Label_Pagamento_Reserva.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pagamento_Reserva.Location = new System.Drawing.Point(40, 370);
            this.Label_Pagamento_Reserva.Name = "Label_Pagamento_Reserva";
            this.Label_Pagamento_Reserva.Size = new System.Drawing.Size(243, 24);
            this.Label_Pagamento_Reserva.TabIndex = 5;
            this.Label_Pagamento_Reserva.Text = "Forma de Pagamento:";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nome.Location = new System.Drawing.Point(260, 160);
            this.textBox_Nome.MaxLength = 100;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(287, 27);
            this.textBox_Nome.TabIndex = 6;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(260, 230);
            this.textBox_Email.MaxLength = 100;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(287, 27);
            this.textBox_Email.TabIndex = 7;
            // 
            // select_Data
            // 
            this.select_Data.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.select_Data.Location = new System.Drawing.Point(260, 300);
            this.select_Data.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.select_Data.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.select_Data.Name = "select_Data";
            this.select_Data.Size = new System.Drawing.Size(127, 27);
            this.select_Data.TabIndex = 8;
            // 
            // Forma_Pagamento
            // 
            this.Forma_Pagamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forma_Pagamento.FormattingEnabled = true;
            this.Forma_Pagamento.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Dinheiro",
            "Pix"});
            this.Forma_Pagamento.Location = new System.Drawing.Point(290, 370);
            this.Forma_Pagamento.Name = "Forma_Pagamento";
            this.Forma_Pagamento.Size = new System.Drawing.Size(257, 29);
            this.Forma_Pagamento.TabIndex = 9;
            this.Forma_Pagamento.SelectedIndexChanged += new System.EventHandler(this.Forma_Pagamento_SelectedIndexChanged);
            // 
            // Screen_NovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Forma_Pagamento);
            this.Controls.Add(this.select_Data);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.Label_Pagamento_Reserva);
            this.Controls.Add(this.Label_Data_Reserva);
            this.Controls.Add(this.Label_Email_Cliente);
            this.Controls.Add(this.Label_Nome_Cliente);
            this.Controls.Add(this.button_Concluir);
            this.Controls.Add(this.Titulo_NovoRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Screen_NovaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema do HotelA3 - Nova Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_NovoRegistro;
        private System.Windows.Forms.Button button_Concluir;
        private System.Windows.Forms.Label Label_Nome_Cliente;
        private System.Windows.Forms.Label Label_Email_Cliente;
        private System.Windows.Forms.Label Label_Data_Reserva;
        private System.Windows.Forms.Label Label_Pagamento_Reserva;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.DateTimePicker select_Data;
        private System.Windows.Forms.ComboBox Forma_Pagamento;
    }
}