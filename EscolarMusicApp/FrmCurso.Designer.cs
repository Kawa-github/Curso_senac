namespace EscolarMusicApp
{
    partial class FrmCurso
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCarga_course = new System.Windows.Forms.TextBox();
            this.txtNome_course = new System.Windows.Forms.TextBox();
            this.txtId_course = new System.Windows.Forms.TextBox();
            this.gravarcursos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtValor_course = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(212, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 27);
            this.button4.TabIndex = 130;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(212, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 27);
            this.button3.TabIndex = 129;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(53, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 126;
            this.label4.Text = "Valor do curso:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(53, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 125;
            this.label3.Text = "Carga horária:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 124;
            this.label2.Text = "Nome do curso:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 123;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(401, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 27);
            this.button2.TabIndex = 118;
            this.button2.Text = "Lista de cursos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtCarga_course
            // 
            this.txtCarga_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCarga_course.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCarga_course.Location = new System.Drawing.Point(146, 143);
            this.txtCarga_course.Name = "txtCarga_course";
            this.txtCarga_course.Size = new System.Drawing.Size(116, 20);
            this.txtCarga_course.TabIndex = 117;
            // 
            // txtNome_course
            // 
            this.txtNome_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNome_course.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome_course.Location = new System.Drawing.Point(146, 112);
            this.txtNome_course.Name = "txtNome_course";
            this.txtNome_course.Size = new System.Drawing.Size(153, 20);
            this.txtNome_course.TabIndex = 115;
            // 
            // txtId_course
            // 
            this.txtId_course.Location = new System.Drawing.Point(146, 78);
            this.txtId_course.Name = "txtId_course";
            this.txtId_course.ReadOnly = true;
            this.txtId_course.Size = new System.Drawing.Size(59, 21);
            this.txtId_course.TabIndex = 114;
            // 
            // gravarcursos
            // 
            this.gravarcursos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gravarcursos.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarcursos.Location = new System.Drawing.Point(101, 225);
            this.gravarcursos.Name = "gravarcursos";
            this.gravarcursos.Size = new System.Drawing.Size(87, 27);
            this.gravarcursos.TabIndex = 116;
            this.gravarcursos.Text = "Gravar";
            this.gravarcursos.UseVisualStyleBackColor = false;
            this.gravarcursos.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(402, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 184);
            this.listBox1.TabIndex = 132;
            // 
            // txtValor_course
            // 
            this.txtValor_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtValor_course.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValor_course.Location = new System.Drawing.Point(146, 173);
            this.txtValor_course.Name = "txtValor_course";
            this.txtValor_course.Size = new System.Drawing.Size(116, 20);
            this.txtValor_course.TabIndex = 133;
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 289);
            this.Controls.Add(this.txtValor_course);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCarga_course);
            this.Controls.Add(this.txtNome_course);
            this.Controls.Add(this.txtId_course);
            this.Controls.Add(this.gravarcursos);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCurso";
            this.Text = "FrmCurso";
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCarga_course;
        private System.Windows.Forms.TextBox txtNome_course;
        private System.Windows.Forms.TextBox txtId_course;
        private System.Windows.Forms.Button gravarcursos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtValor_course;
    }
}