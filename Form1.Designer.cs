namespace Hotel
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.HotelReserva = new System.Windows.Forms.Label();
            this.dataReserva = new System.Windows.Forms.Label();
            this.responsavelReserva = new System.Windows.Forms.Label();
            this.pagmentoReserva = new System.Windows.Forms.Label();
            this.textHotel = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.textResponsavel = new System.Windows.Forms.TextBox();
            this.textPagamento = new System.Windows.Forms.TextBox();
            this.agendarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HotelReserva
            // 
            this.HotelReserva.AutoSize = true;
            this.HotelReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelReserva.Location = new System.Drawing.Point(11, 85);
            this.HotelReserva.Name = "HotelReserva";
            this.HotelReserva.Size = new System.Drawing.Size(64, 22);
            this.HotelReserva.TabIndex = 0;
            this.HotelReserva.Text = "Hotel:";
            this.HotelReserva.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataReserva
            // 
            this.dataReserva.AutoSize = true;
            this.dataReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataReserva.Location = new System.Drawing.Point(12, 130);
            this.dataReserva.Name = "dataReserva";
            this.dataReserva.Size = new System.Drawing.Size(59, 22);
            this.dataReserva.TabIndex = 1;
            this.dataReserva.Text = "Data:";
            // 
            // responsavelReserva
            // 
            this.responsavelReserva.AutoSize = true;
            this.responsavelReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsavelReserva.Location = new System.Drawing.Point(12, 176);
            this.responsavelReserva.Name = "responsavelReserva";
            this.responsavelReserva.Size = new System.Drawing.Size(137, 22);
            this.responsavelReserva.TabIndex = 2;
            this.responsavelReserva.Text = "Responsável:";
            this.responsavelReserva.Click += new System.EventHandler(this.label3_Click);
            // 
            // pagmentoReserva
            // 
            this.pagmentoReserva.AutoSize = true;
            this.pagmentoReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagmentoReserva.Location = new System.Drawing.Point(12, 223);
            this.pagmentoReserva.Name = "pagmentoReserva";
            this.pagmentoReserva.Size = new System.Drawing.Size(122, 22);
            this.pagmentoReserva.TabIndex = 3;
            this.pagmentoReserva.Text = "Pagamento:";
            // 
            // textHotel
            // 
            this.textHotel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHotel.Location = new System.Drawing.Point(145, 85);
            this.textHotel.Name = "textHotel";
            this.textHotel.Size = new System.Drawing.Size(206, 22);
            this.textHotel.TabIndex = 1;
            // 
            // textData
            // 
            this.textData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textData.Location = new System.Drawing.Point(145, 130);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(206, 22);
            this.textData.TabIndex = 2;
            // 
            // textResponsavel
            // 
            this.textResponsavel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResponsavel.Location = new System.Drawing.Point(145, 176);
            this.textResponsavel.Name = "textResponsavel";
            this.textResponsavel.Size = new System.Drawing.Size(206, 22);
            this.textResponsavel.TabIndex = 3;
            // 
            // textPagamento
            // 
            this.textPagamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPagamento.Location = new System.Drawing.Point(145, 223);
            this.textPagamento.Name = "textPagamento";
            this.textPagamento.Size = new System.Drawing.Size(206, 22);
            this.textPagamento.TabIndex = 4;
            // 
            // agendarReserva
            // 
            this.agendarReserva.Location = new System.Drawing.Point(145, 327);
            this.agendarReserva.Name = "agendarReserva";
            this.agendarReserva.Size = new System.Drawing.Size(193, 53);
            this.agendarReserva.TabIndex = 5;
            this.agendarReserva.Text = "AGENDAR RESERVA";
            this.agendarReserva.UseVisualStyleBackColor = true;
            this.agendarReserva.Click += new System.EventHandler(this.FinalizarReserva);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.agendarReserva);
            this.Controls.Add(this.textPagamento);
            this.Controls.Add(this.textResponsavel);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textHotel);
            this.Controls.Add(this.pagmentoReserva);
            this.Controls.Add(this.responsavelReserva);
            this.Controls.Add(this.dataReserva);
            this.Controls.Add(this.HotelReserva);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendamentoHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HotelReserva;
        private System.Windows.Forms.Label dataReserva;
        private System.Windows.Forms.Label responsavelReserva;
        private System.Windows.Forms.Label pagmentoReserva;
        private System.Windows.Forms.TextBox textHotel;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.TextBox textResponsavel;
        private System.Windows.Forms.TextBox textPagamento;
        private System.Windows.Forms.Button agendarReserva;
    }
}

