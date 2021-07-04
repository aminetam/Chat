
namespace GestionStock
{
    partial class Authentification
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
            this.SeConnecter = new System.Windows.Forms.Button();
            this.Sinscrire = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeConnecter
            // 
            this.SeConnecter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeConnecter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeConnecter.Location = new System.Drawing.Point(243, 431);
            this.SeConnecter.Name = "SeConnecter";
            this.SeConnecter.Size = new System.Drawing.Size(118, 32);
            this.SeConnecter.TabIndex = 0;
            this.SeConnecter.Text = "Se Connecter";
            this.SeConnecter.UseVisualStyleBackColor = false;
            this.SeConnecter.Click += new System.EventHandler(this.SeConnecter_Click);
            // 
            // Sinscrire
            // 
            this.Sinscrire.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sinscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sinscrire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sinscrire.Location = new System.Drawing.Point(48, 431);
            this.Sinscrire.Name = "Sinscrire";
            this.Sinscrire.Size = new System.Drawing.Size(115, 32);
            this.Sinscrire.TabIndex = 1;
            this.Sinscrire.Text = "S\'inscrire";
            this.Sinscrire.UseVisualStyleBackColor = false;
            this.Sinscrire.Click += new System.EventHandler(this.Sinscrire_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(99, 206);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(210, 22);
            this.Username.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(99, 323);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(210, 22);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Authentification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Sinscrire);
            this.Controls.Add(this.SeConnecter);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SeConnecter;
        private System.Windows.Forms.Button Sinscrire;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}