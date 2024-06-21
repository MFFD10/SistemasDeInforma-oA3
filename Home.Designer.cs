namespace Sistema_do_HotelA3
{
    partial class Screen_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_Home));
            this.Titulo_Home = new System.Windows.Forms.Label();
            this.button_Cadastro = new System.Windows.Forms.Button();
            this.button_Lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo_Home
            // 
            resources.ApplyResources(this.Titulo_Home, "Titulo_Home");
            this.Titulo_Home.Name = "Titulo_Home";
            // 
            // button_Cadastro
            // 
            this.button_Cadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.button_Cadastro, "button_Cadastro");
            this.button_Cadastro.Name = "button_Cadastro";
            this.button_Cadastro.UseVisualStyleBackColor = false;
            this.button_Cadastro.Click += new System.EventHandler(this.button_Cadastro_Click);
            // 
            // button_Lista
            // 
            this.button_Lista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.button_Lista, "button_Lista");
            this.button_Lista.Name = "button_Lista";
            this.button_Lista.UseVisualStyleBackColor = false;
            this.button_Lista.Click += new System.EventHandler(this.button_Lista_Click);
            // 
            // Screen_Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.button_Lista);
            this.Controls.Add(this.button_Cadastro);
            this.Controls.Add(this.Titulo_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Screen_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Home;
        private System.Windows.Forms.Button button_Cadastro;
        private System.Windows.Forms.Button button_Lista;
    }
}

