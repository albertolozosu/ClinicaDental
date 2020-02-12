namespace ClinicaDental
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bttPaciente = new System.Windows.Forms.Button();
            this.bttMedico = new System.Windows.Forms.Button();
            this.bttEmpleado = new System.Windows.Forms.Button();
            this.bttVolverLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttPaciente
            // 
            this.bttPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPaciente.Image = ((System.Drawing.Image)(resources.GetObject("bttPaciente.Image")));
            this.bttPaciente.Location = new System.Drawing.Point(35, 44);
            this.bttPaciente.Name = "bttPaciente";
            this.bttPaciente.Size = new System.Drawing.Size(399, 73);
            this.bttPaciente.TabIndex = 1;
            this.bttPaciente.Text = "Paciente";
            this.bttPaciente.UseVisualStyleBackColor = true;
            this.bttPaciente.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttMedico
            // 
            this.bttMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMedico.Image = ((System.Drawing.Image)(resources.GetObject("bttMedico.Image")));
            this.bttMedico.Location = new System.Drawing.Point(35, 151);
            this.bttMedico.Name = "bttMedico";
            this.bttMedico.Size = new System.Drawing.Size(399, 73);
            this.bttMedico.TabIndex = 4;
            this.bttMedico.Text = "Médico";
            this.bttMedico.UseVisualStyleBackColor = true;
            this.bttMedico.Click += new System.EventHandler(this.bttMedico_Click);
            // 
            // bttEmpleado
            // 
            this.bttEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("bttEmpleado.Image")));
            this.bttEmpleado.Location = new System.Drawing.Point(35, 263);
            this.bttEmpleado.Name = "bttEmpleado";
            this.bttEmpleado.Size = new System.Drawing.Size(399, 73);
            this.bttEmpleado.TabIndex = 5;
            this.bttEmpleado.Text = "Empleado";
            this.bttEmpleado.UseVisualStyleBackColor = true;
            this.bttEmpleado.Click += new System.EventHandler(this.bttEmpleado_Click);
            // 
            // bttVolverLogin
            // 
            this.bttVolverLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVolverLogin.Location = new System.Drawing.Point(344, 404);
            this.bttVolverLogin.Name = "bttVolverLogin";
            this.bttVolverLogin.Size = new System.Drawing.Size(90, 34);
            this.bttVolverLogin.TabIndex = 6;
            this.bttVolverLogin.Text = "Volver";
            this.bttVolverLogin.UseVisualStyleBackColor = true;
            this.bttVolverLogin.Click += new System.EventHandler(this.bttVolverLogin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(485, 487);
            this.Controls.Add(this.bttVolverLogin);
            this.Controls.Add(this.bttEmpleado);
            this.Controls.Add(this.bttMedico);
            this.Controls.Add(this.bttPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttPaciente;
        private System.Windows.Forms.Button bttMedico;
        private System.Windows.Forms.Button bttEmpleado;
        private System.Windows.Forms.Button bttVolverLogin;
    }
}