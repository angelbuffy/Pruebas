namespace Farmacia_Final
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.Ingresar_Login = new System.Windows.Forms.Button();
            this.Cancelar_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(211, 129);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(176, 20);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxContra
            // 
            this.textBoxContra.Location = new System.Drawing.Point(211, 201);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(176, 20);
            this.textBoxContra.TabIndex = 4;
            // 
            // Ingresar_Login
            // 
            this.Ingresar_Login.Location = new System.Drawing.Point(175, 293);
            this.Ingresar_Login.Name = "Ingresar_Login";
            this.Ingresar_Login.Size = new System.Drawing.Size(75, 23);
            this.Ingresar_Login.TabIndex = 5;
            this.Ingresar_Login.Text = "Ingresar";
            this.Ingresar_Login.UseVisualStyleBackColor = true;
            this.Ingresar_Login.Click += new System.EventHandler(this.Ingresar_Login_Click);
            // 
            // Cancelar_Login
            // 
            this.Cancelar_Login.Location = new System.Drawing.Point(312, 293);
            this.Cancelar_Login.Name = "Cancelar_Login";
            this.Cancelar_Login.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_Login.TabIndex = 6;
            this.Cancelar_Login.Text = "Cancelar";
            this.Cancelar_Login.UseVisualStyleBackColor = true;
            this.Cancelar_Login.Click += new System.EventHandler(this.Cancelar_Login_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 405);
            this.Controls.Add(this.Cancelar_Login);
            this.Controls.Add(this.Ingresar_Login);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.Button Ingresar_Login;
        private System.Windows.Forms.Button Cancelar_Login;
    }
}