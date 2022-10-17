namespace Vista
{
    partial class UsuariosForm
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
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clavetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.correotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rolcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.estadoactcheckBox = new System.Windows.Forms.CheckBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(116, 37);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(170, 23);
            this.codigoTextBox.TabIndex = 1;
            // 
            // nombretextBox
            // 
            this.nombretextBox.Enabled = false;
            this.nombretextBox.Location = new System.Drawing.Point(116, 79);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(170, 23);
            this.nombretextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // clavetextBox
            // 
            this.clavetextBox.Enabled = false;
            this.clavetextBox.Location = new System.Drawing.Point(116, 122);
            this.clavetextBox.Name = "clavetextBox";
            this.clavetextBox.PasswordChar = '*';
            this.clavetextBox.Size = new System.Drawing.Size(170, 23);
            this.clavetextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clave: ";
            // 
            // correotextBox
            // 
            this.correotextBox.Enabled = false;
            this.correotextBox.Location = new System.Drawing.Point(116, 162);
            this.correotextBox.Name = "correotextBox";
            this.correotextBox.Size = new System.Drawing.Size(170, 23);
            this.correotextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol:";
            // 
            // rolcomboBox
            // 
            this.rolcomboBox.Enabled = false;
            this.rolcomboBox.FormattingEnabled = true;
            this.rolcomboBox.Items.AddRange(new object[] {
            "Addministrador",
            "Usuario"});
            this.rolcomboBox.Location = new System.Drawing.Point(116, 205);
            this.rolcomboBox.Name = "rolcomboBox";
            this.rolcomboBox.Size = new System.Drawing.Size(170, 23);
            this.rolcomboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado Act: ";
            // 
            // estadoactcheckBox
            // 
            this.estadoactcheckBox.AutoSize = true;
            this.estadoactcheckBox.Enabled = false;
            this.estadoactcheckBox.Location = new System.Drawing.Point(119, 243);
            this.estadoactcheckBox.Name = "estadoactcheckBox";
            this.estadoactcheckBox.Size = new System.Drawing.Size(15, 14);
            this.estadoactcheckBox.TabIndex = 11;
            this.estadoactcheckBox.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(354, 40);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(84, 35);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(2, 276);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.RowTemplate.Height = 25;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(731, 180);
            this.UsuariosdataGridView.TabIndex = 13;
            // 
            // modificarbutton
            // 
            this.modificarbutton.Location = new System.Drawing.Point(459, 40);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(81, 35);
            this.modificarbutton.TabIndex = 14;
            this.modificarbutton.Text = "Modificar";
            this.modificarbutton.UseVisualStyleBackColor = true;
            // 
            // guardarbutton
            // 
            this.guardarbutton.Location = new System.Drawing.Point(560, 42);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(81, 33);
            this.guardarbutton.TabIndex = 15;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = true;
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(354, 95);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(84, 33);
            this.eliminarbutton.TabIndex = 16;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(459, 95);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(81, 33);
            this.cancelarbutton.TabIndex = 17;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 458);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.estadoactcheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rolcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clavetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox codigoTextBox;
        private TextBox nombretextBox;
        private Label label2;
        private TextBox clavetextBox;
        private Label label3;
        private TextBox correotextBox;
        private Label label4;
        private Label label5;
        private ComboBox rolcomboBox;
        private Label label6;
        private CheckBox estadoactcheckBox;
        private Button Nuevobutton;
        private DataGridView UsuariosdataGridView;
        private Button modificarbutton;
        private Button guardarbutton;
        private Button eliminarbutton;
        private Button cancelarbutton;
    }
}