namespace Convertidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtcent = new Label();
            txtfahe = new Label();
            btnaceptar = new Button();
            txtcen = new TextBox();
            txtfah = new TextBox();
            SuspendLayout();
            // 
            // txtcent
            // 
            txtcent.AutoSize = true;
            txtcent.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcent.Location = new Point(37, 60);
            txtcent.Name = "txtcent";
            txtcent.Size = new Size(181, 22);
            txtcent.TabIndex = 0;
            txtcent.Text = "Grados Centigrados:";
            // 
            // txtfahe
            // 
            txtfahe.AutoSize = true;
            txtfahe.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtfahe.Location = new Point(37, 122);
            txtfahe.Name = "txtfahe";
            txtfahe.Size = new Size(170, 22);
            txtfahe.TabIndex = 1;
            txtfahe.Text = "Grados Fahernheit:";
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(273, 201);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(122, 42);
            btnaceptar.TabIndex = 2;
            btnaceptar.Text = "Aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // txtcen
            // 
            txtcen.Location = new Point(224, 59);
            txtcen.Name = "txtcen";
            txtcen.Size = new Size(156, 23);
            txtcen.TabIndex = 3;
            txtcen.TextChanged += txtcen_TextChanged;
            txtcen.KeyPress += txtcen_KeyPress;
            // 
            // txtfah
            // 
            txtfah.Location = new Point(224, 124);
            txtfah.Name = "txtfah";
            txtfah.Size = new Size(156, 23);
            txtfah.TabIndex = 4;
            txtfah.KeyPress += txtfah_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 304);
            Controls.Add(txtfah);
            Controls.Add(txtcen);
            Controls.Add(btnaceptar);
            Controls.Add(txtfahe);
            Controls.Add(txtcent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Convertidor de Temperaturas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtcent;
        private Label txtfahe;
        private Button btnaceptar;
        private TextBox txtcen;
        private TextBox txtfah;
    }
}
