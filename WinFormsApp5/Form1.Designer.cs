namespace WinFormsApp5
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ordenarbtn = new System.Windows.Forms.Button();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.datotxt = new System.Windows.Forms.TextBox();
            this.Mostrarbtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvregistro = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guardarbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistro)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(26, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ordenar descendente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 80);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingresar Número:";
            // 
            // ordenarbtn
            // 
            this.ordenarbtn.BackColor = System.Drawing.Color.Teal;
            this.ordenarbtn.FlatAppearance.BorderSize = 0;
            this.ordenarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordenarbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ordenarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordenarbtn.Location = new System.Drawing.Point(26, 363);
            this.ordenarbtn.Name = "ordenarbtn";
            this.ordenarbtn.Size = new System.Drawing.Size(110, 50);
            this.ordenarbtn.TabIndex = 14;
            this.ordenarbtn.Text = "Ordenar Ascendente";
            this.ordenarbtn.UseVisualStyleBackColor = false;
            this.ordenarbtn.Click += new System.EventHandler(this.ordenarbtn_Click);
            // 
            // buscarbtn
            // 
            this.buscarbtn.BackColor = System.Drawing.Color.Teal;
            this.buscarbtn.FlatAppearance.BorderSize = 0;
            this.buscarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buscarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buscarbtn.Location = new System.Drawing.Point(36, 316);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(85, 28);
            this.buscarbtn.TabIndex = 13;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = false;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.BackColor = System.Drawing.Color.Teal;
            this.eliminarbtn.FlatAppearance.BorderSize = 0;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eliminarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminarbtn.Location = new System.Drawing.Point(26, 196);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(85, 28);
            this.eliminarbtn.TabIndex = 11;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = false;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // datotxt
            // 
            this.datotxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.datotxt.Location = new System.Drawing.Point(36, 274);
            this.datotxt.Name = "datotxt";
            this.datotxt.Size = new System.Drawing.Size(100, 23);
            this.datotxt.TabIndex = 12;
            // 
            // Mostrarbtn
            // 
            this.Mostrarbtn.BackColor = System.Drawing.Color.Teal;
            this.Mostrarbtn.FlatAppearance.BorderSize = 0;
            this.Mostrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mostrarbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mostrarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mostrarbtn.Location = new System.Drawing.Point(26, 132);
            this.Mostrarbtn.Name = "Mostrarbtn";
            this.Mostrarbtn.Size = new System.Drawing.Size(85, 28);
            this.Mostrarbtn.TabIndex = 10;
            this.Mostrarbtn.Text = "Mostrar";
            this.Mostrarbtn.UseVisualStyleBackColor = false;
            this.Mostrarbtn.Click += new System.EventHandler(this.Mostrarbtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(168, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 375);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvregistro);
            this.tabPage1.Controls.Add(this.numerotxt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.guardarbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvregistro
            // 
            this.dgvregistro.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgvregistro.Location = new System.Drawing.Point(235, 28);
            this.dgvregistro.Name = "dgvregistro";
            this.dgvregistro.RowTemplate.Height = 25;
            this.dgvregistro.Size = new System.Drawing.Size(193, 313);
            this.dgvregistro.TabIndex = 4;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Números";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // numerotxt
            // 
            this.numerotxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numerotxt.Location = new System.Drawing.Point(93, 38);
            this.numerotxt.Name = "numerotxt";
            this.numerotxt.Size = new System.Drawing.Size(100, 23);
            this.numerotxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número:";
            // 
            // guardarbtn
            // 
            this.guardarbtn.BackColor = System.Drawing.Color.Teal;
            this.guardarbtn.FlatAppearance.BorderSize = 0;
            this.guardarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guardarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarbtn.Location = new System.Drawing.Point(61, 93);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(105, 38);
            this.guardarbtn.TabIndex = 0;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = false;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ordenarbtn);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.datotxt);
            this.Controls.Add(this.Mostrarbtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label5;
        private Button ordenarbtn;
        private Button buscarbtn;
        private Button eliminarbtn;
        private TextBox datotxt;
        private Button Mostrarbtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvregistro;
        private DataGridViewTextBoxColumn Column4;
        private TextBox numerotxt;
        private Label label4;
        private Button guardarbtn;
    }
}