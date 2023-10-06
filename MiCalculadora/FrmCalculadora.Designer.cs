namespace MiCalculadora
{
    partial class FrmCalculadora
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
            rdbDecimal = new RadioButton();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lstHistorial = new ListBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmbOperacion = new ComboBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(33, 42);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(85, 27);
            rdbDecimal.TabIndex = 1;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(290, 146);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(234, 88);
            grpSistema.TabIndex = 2;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(121, 42);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(80, 27);
            rdbBinario.TabIndex = 2;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(45, 90);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 26);
            lblResultado.TabIndex = 3;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(45, 260);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(229, 38);
            lblPrimerOperador.TabIndex = 4;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(335, 260);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(144, 38);
            lblOperacion.TabIndex = 5;
            lblOperacion.Text = "Operacion";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(529, 260);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(260, 38);
            lblSegundoOperador.TabIndex = 6;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(78, 313);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(140, 30);
            txtPrimerOperando.TabIndex = 7;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(576, 313);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(140, 30);
            txtSegundoOperando.TabIndex = 9;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(45, 364);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(208, 68);
            btnOperar.TabIndex = 10;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(302, 364);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(208, 68);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(558, 364);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(208, 68);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(810, 90);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(259, 349);
            lstHistorial.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(835, 45);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 15;
            label2.Text = "Historial:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(347, 319);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 16;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 461);
            Controls.Add(cmbOperacion);
            Controls.Add(label2);
            Controls.Add(lstHistorial);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(grpSistema);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Uriel Marles";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdbDecimal;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ListBox lstHistorial;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbOperacion;
    }
}