namespace WindowsFormsApplication1
{
    partial class Consulta3
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.Usuario_Reg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.GroupBox();
            this.Registro = new System.Windows.Forms.Button();
            this.Ocultar_2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Contra_Reg = new System.Windows.Forms.TextBox();
            this.Mostar_2 = new System.Windows.Forms.PictureBox();
            this.Consulta_3 = new System.Windows.Forms.RadioButton();
            this.Consulta2 = new System.Windows.Forms.RadioButton();
            this.Conectado = new System.Windows.Forms.RadioButton();
            this.CierreServidor = new System.Windows.Forms.Button();
            this.Jugar = new System.Windows.Forms.Button();
            this.Normas = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.GroupBox();
            this.Ocultar = new System.Windows.Forms.PictureBox();
            this.Mostrar = new System.Windows.Forms.PictureBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Contra_txt = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.Servicios = new System.Windows.Forms.Button();
            this.ListaConectados = new System.Windows.Forms.Button();
            this.ListaConectados1 = new System.Windows.Forms.DataGridView();
            this.NombreConsulta = new System.Windows.Forms.TextBox();
            this.Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostar_2)).BeginInit();
            this.log_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(89, 67);
            this.IP.Margin = new System.Windows.Forms.Padding(4);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(172, 22);
            this.IP.TabIndex = 2;
            this.IP.Text = "192.168.56.102";
            this.IP.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // Usuario_Reg
            // 
            this.Usuario_Reg.Location = new System.Drawing.Point(194, 38);
            this.Usuario_Reg.Margin = new System.Windows.Forms.Padding(4);
            this.Usuario_Reg.Name = "Usuario_Reg";
            this.Usuario_Reg.Size = new System.Drawing.Size(217, 22);
            this.Usuario_Reg.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 276);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Register.Controls.Add(this.Registro);
            this.Register.Controls.Add(this.Ocultar_2);
            this.Register.Controls.Add(this.label3);
            this.Register.Controls.Add(this.Contra_Reg);
            this.Register.Controls.Add(this.label2);
            this.Register.Controls.Add(this.Usuario_Reg);
            this.Register.Controls.Add(this.Mostar_2);
            this.Register.Location = new System.Drawing.Point(19, 419);
            this.Register.Margin = new System.Windows.Forms.Padding(4);
            this.Register.Name = "Register";
            this.Register.Padding = new System.Windows.Forms.Padding(4);
            this.Register.Size = new System.Drawing.Size(484, 209);
            this.Register.TabIndex = 6;
            this.Register.TabStop = false;
            this.Register.Text = "Register";
            this.Register.Visible = false;
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(175, 126);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(112, 51);
            this.Registro.TabIndex = 16;
            this.Registro.Text = "Registro";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // Ocultar_2
            // 
            this.Ocultar_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ocultar_2.Image = ((System.Drawing.Image)(resources.GetObject("Ocultar_2.Image")));
            this.Ocultar_2.Location = new System.Drawing.Point(431, 62);
            this.Ocultar_2.Name = "Ocultar_2";
            this.Ocultar_2.Size = new System.Drawing.Size(46, 43);
            this.Ocultar_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ocultar_2.TabIndex = 15;
            this.Ocultar_2.TabStop = false;
            this.Ocultar_2.Click += new System.EventHandler(this.Ocultar_2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // Contra_Reg
            // 
            this.Contra_Reg.Location = new System.Drawing.Point(194, 68);
            this.Contra_Reg.Margin = new System.Windows.Forms.Padding(4);
            this.Contra_Reg.Name = "Contra_Reg";
            this.Contra_Reg.Size = new System.Drawing.Size(217, 22);
            this.Contra_Reg.TabIndex = 9;
            // 
            // Mostar_2
            // 
            this.Mostar_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mostar_2.Image = ((System.Drawing.Image)(resources.GetObject("Mostar_2.Image")));
            this.Mostar_2.Location = new System.Drawing.Point(432, 62);
            this.Mostar_2.Name = "Mostar_2";
            this.Mostar_2.Size = new System.Drawing.Size(46, 43);
            this.Mostar_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mostar_2.TabIndex = 14;
            this.Mostar_2.TabStop = false;
            this.Mostar_2.Click += new System.EventHandler(this.Mostar_2_Click);
            // 
            // Consulta_3
            // 
            this.Consulta_3.AutoSize = true;
            this.Consulta_3.Location = new System.Drawing.Point(727, 229);
            this.Consulta_3.Margin = new System.Windows.Forms.Padding(4);
            this.Consulta_3.Name = "Consulta_3";
            this.Consulta_3.Size = new System.Drawing.Size(90, 20);
            this.Consulta_3.TabIndex = 11;
            this.Consulta_3.TabStop = true;
            this.Consulta_3.Text = "Consulta 3";
            this.Consulta_3.UseVisualStyleBackColor = true;
            // 
            // Consulta2
            // 
            this.Consulta2.AutoSize = true;
            this.Consulta2.Location = new System.Drawing.Point(727, 201);
            this.Consulta2.Margin = new System.Windows.Forms.Padding(4);
            this.Consulta2.Name = "Consulta2";
            this.Consulta2.Size = new System.Drawing.Size(90, 20);
            this.Consulta2.TabIndex = 7;
            this.Consulta2.TabStop = true;
            this.Consulta2.Text = "Consulta 2";
            this.Consulta2.UseVisualStyleBackColor = true;
            this.Consulta2.CheckedChanged += new System.EventHandler(this.Longitud_CheckedChanged);
            // 
            // Conectado
            // 
            this.Conectado.AutoSize = true;
            this.Conectado.Location = new System.Drawing.Point(727, 173);
            this.Conectado.Margin = new System.Windows.Forms.Padding(4);
            this.Conectado.Name = "Conectado";
            this.Conectado.Size = new System.Drawing.Size(129, 20);
            this.Conectado.TabIndex = 8;
            this.Conectado.TabStop = true;
            this.Conectado.Text = "Esta conectado?";
            this.Conectado.UseVisualStyleBackColor = true;
            // 
            // CierreServidor
            // 
            this.CierreServidor.Location = new System.Drawing.Point(388, 59);
            this.CierreServidor.Margin = new System.Windows.Forms.Padding(4);
            this.CierreServidor.Name = "CierreServidor";
            this.CierreServidor.Size = new System.Drawing.Size(112, 38);
            this.CierreServidor.TabIndex = 7;
            this.CierreServidor.Text = "desconectar";
            this.CierreServidor.UseVisualStyleBackColor = true;
            this.CierreServidor.Click += new System.EventHandler(this.CierreServidor_Click_1);
            // 
            // Jugar
            // 
            this.Jugar.Location = new System.Drawing.Point(554, 121);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(75, 38);
            this.Jugar.TabIndex = 9;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Normas
            // 
            this.Normas.Location = new System.Drawing.Point(554, 165);
            this.Normas.Name = "Normas";
            this.Normas.Size = new System.Drawing.Size(75, 40);
            this.Normas.TabIndex = 10;
            this.Normas.Text = "Normas";
            this.Normas.UseVisualStyleBackColor = true;
            this.Normas.Click += new System.EventHandler(this.Normas_Click);
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.log_in.Controls.Add(this.Ocultar);
            this.log_in.Controls.Add(this.Mostrar);
            this.log_in.Controls.Add(this.Contraseña);
            this.log_in.Controls.Add(this.Contra_txt);
            this.log_in.Controls.Add(this.Usuario);
            this.log_in.Controls.Add(this.button3);
            this.log_in.Controls.Add(this.Usuario_txt);
            this.log_in.Location = new System.Drawing.Point(19, 103);
            this.log_in.Margin = new System.Windows.Forms.Padding(4);
            this.log_in.Name = "log_in";
            this.log_in.Padding = new System.Windows.Forms.Padding(4);
            this.log_in.Size = new System.Drawing.Size(484, 236);
            this.log_in.TabIndex = 12;
            this.log_in.TabStop = false;
            this.log_in.Text = "Log In";
            // 
            // Ocultar
            // 
            this.Ocultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ocultar.Image = ((System.Drawing.Image)(resources.GetObject("Ocultar.Image")));
            this.Ocultar.Location = new System.Drawing.Point(431, 62);
            this.Ocultar.Name = "Ocultar";
            this.Ocultar.Size = new System.Drawing.Size(46, 43);
            this.Ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ocultar.TabIndex = 14;
            this.Ocultar.TabStop = false;
            this.Ocultar.Click += new System.EventHandler(this.Ocultar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("Mostrar.Image")));
            this.Mostrar.Location = new System.Drawing.Point(430, 62);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(46, 43);
            this.Mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mostrar.TabIndex = 13;
            this.Mostrar.TabStop = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(31, 62);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(155, 31);
            this.Contraseña.TabIndex = 10;
            this.Contraseña.Text = "Contraseña";
            // 
            // Contra_txt
            // 
            this.Contra_txt.Location = new System.Drawing.Point(194, 68);
            this.Contra_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Contra_txt.Name = "Contra_txt";
            this.Contra_txt.Size = new System.Drawing.Size(217, 22);
            this.Contra_txt.TabIndex = 9;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(31, 31);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(108, 31);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Entrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.Location = new System.Drawing.Point(194, 38);
            this.Usuario_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(217, 22);
            this.Usuario_txt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Si quieres registrarte haz click en el botón siguiente:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 35);
            this.button5.TabIndex = 14;
            this.button5.Text = "Registrarse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contLbl
            // 
            this.contLbl.AutoSize = true;
            this.contLbl.Location = new System.Drawing.Point(585, 419);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(44, 16);
            this.contLbl.TabIndex = 16;
            this.contLbl.Text = "label1";
            // 
            // Servicios
            // 
            this.Servicios.Location = new System.Drawing.Point(547, 357);
            this.Servicios.Name = "Servicios";
            this.Servicios.Size = new System.Drawing.Size(108, 52);
            this.Servicios.TabIndex = 17;
            this.Servicios.Text = "¿Cuántos servicios?";
            this.Servicios.UseVisualStyleBackColor = true;
            this.Servicios.Click += new System.EventHandler(this.Servicios_Click);
            // 
            // ListaConectados
            // 
            this.ListaConectados.Location = new System.Drawing.Point(554, 535);
            this.ListaConectados.Name = "ListaConectados";
            this.ListaConectados.Size = new System.Drawing.Size(141, 40);
            this.ListaConectados.TabIndex = 18;
            this.ListaConectados.Text = "ListaConectados";
            this.ListaConectados.UseVisualStyleBackColor = true;
            this.ListaConectados.Click += new System.EventHandler(this.ListaConectados_Click);
            // 
            // ListaConectados1
            // 
            this.ListaConectados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaConectados1.Location = new System.Drawing.Point(736, 457);
            this.ListaConectados1.Name = "ListaConectados1";
            this.ListaConectados1.RowHeadersWidth = 51;
            this.ListaConectados1.RowTemplate.Height = 24;
            this.ListaConectados1.Size = new System.Drawing.Size(160, 171);
            this.ListaConectados1.TabIndex = 19;
            // 
            // NombreConsulta
            // 
            this.NombreConsulta.Location = new System.Drawing.Point(727, 134);
            this.NombreConsulta.Name = "NombreConsulta";
            this.NombreConsulta.Size = new System.Drawing.Size(136, 22);
            this.NombreConsulta.TabIndex = 20;
            // 
            // Consulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.NombreConsulta);
            this.Controls.Add(this.ListaConectados1);
            this.Controls.Add(this.ListaConectados);
            this.Controls.Add(this.Servicios);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.Consulta_3);
            this.Controls.Add(this.Normas);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.Consulta2);
            this.Controls.Add(this.CierreServidor);
            this.Controls.Add(this.Conectado);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consulta3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostar_2)).EndInit();
            this.log_in.ResumeLayout(false);
            this.log_in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Usuario_Reg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Register;
        private System.Windows.Forms.RadioButton Consulta2;
        private System.Windows.Forms.RadioButton Conectado;
        private System.Windows.Forms.TextBox Contra_Reg;
        private System.Windows.Forms.RadioButton Consulta_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CierreServidor;
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button Normas;
        private System.Windows.Forms.GroupBox log_in;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Contra_txt;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Usuario_txt;
        private System.Windows.Forms.PictureBox Mostrar;
        private System.Windows.Forms.PictureBox Ocultar;
        private System.Windows.Forms.PictureBox Mostar_2;
        private System.Windows.Forms.PictureBox Ocultar_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Label contLbl;
        private System.Windows.Forms.Button Servicios;
        private System.Windows.Forms.Button ListaConectados;
        private System.Windows.Forms.DataGridView ListaConectados1;
        private System.Windows.Forms.TextBox NombreConsulta;
    }
}

