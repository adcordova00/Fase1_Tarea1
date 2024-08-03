namespace Fase1_Tarea1
{
    partial class frm_tareas
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
            lst_tareas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_alumno = new TextBox();
            txt_curso = new TextBox();
            txt_materia = new TextBox();
            txt_nombre_tarea = new TextBox();
            dtp_fecha = new DateTimePicker();
            btn_agregar = new Button();
            btn_eliminar = new Button();
            btn_limpiar = new Button();
            SuspendLayout();
            // 
            // lst_tareas
            // 
            lst_tareas.FormattingEnabled = true;
            lst_tareas.Location = new Point(360, 12);
            lst_tareas.Name = "lst_tareas";
            lst_tareas.Size = new Size(488, 404);
            lst_tareas.TabIndex = 0;
            lst_tareas.SelectedIndexChanged += lst_tareas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 51);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Alumno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 132);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Materia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 174);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 4;
            label4.Text = "Nombre Tarea:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 217);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(89, 12);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 6;
            label6.Text = "REGISTRO DE TAREAS";
            // 
            // txt_alumno
            // 
            txt_alumno.Location = new Point(141, 44);
            txt_alumno.Name = "txt_alumno";
            txt_alumno.Size = new Size(184, 27);
            txt_alumno.TabIndex = 7;
            // 
            // txt_curso
            // 
            txt_curso.Location = new Point(141, 83);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(184, 27);
            txt_curso.TabIndex = 8;
            // 
            // txt_materia
            // 
            txt_materia.Location = new Point(141, 125);
            txt_materia.Name = "txt_materia";
            txt_materia.Size = new Size(184, 27);
            txt_materia.TabIndex = 9;
            // 
            // txt_nombre_tarea
            // 
            txt_nombre_tarea.Location = new Point(141, 167);
            txt_nombre_tarea.Name = "txt_nombre_tarea";
            txt_nombre_tarea.Size = new Size(184, 27);
            txt_nombre_tarea.TabIndex = 10;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Location = new Point(141, 210);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(184, 27);
            dtp_fecha.TabIndex = 11;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(141, 264);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(184, 29);
            btn_agregar.TabIndex = 12;
            btn_agregar.Text = "Agregar Nueva Tarea";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(854, 12);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(94, 29);
            btn_eliminar.TabIndex = 13;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(141, 299);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(184, 29);
            btn_limpiar.TabIndex = 14;
            btn_limpiar.Text = "Limpiar Formulario";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // frm_tareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 458);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_agregar);
            Controls.Add(dtp_fecha);
            Controls.Add(txt_nombre_tarea);
            Controls.Add(txt_materia);
            Controls.Add(txt_curso);
            Controls.Add(txt_alumno);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_tareas);
            Name = "frm_tareas";
            Text = "Tarea 1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_tareas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_alumno;
        private TextBox txt_curso;
        private TextBox txt_materia;
        private TextBox txt_nombre_tarea;
        private DateTimePicker dtp_fecha;
        private Button btn_agregar;
        private Button btn_eliminar;
        private Button btn_limpiar;
    }
}
