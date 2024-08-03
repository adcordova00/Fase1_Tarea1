namespace Fase1_Tarea1
{
    public partial class frm_tareas : Form
    {
        public frm_tareas()
        {
            InitializeComponent();
        }

        private void lst_tareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Esta funcion sirve para validar que todos los campos esten llenos antes de agregar la tarea
        private static bool AreFieldsValid(params string[] fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    return false;
                }
            }
            return true;
        }

        private static string BuildCadena(string alumno, string curso, string materia, string nombre_tarea, DateTime fecha)
        {
            return $"{alumno} - {curso} - {materia} - {nombre_tarea} - {fecha:yyyy-MM-dd}"; //Estoy llamando a las variables de manera dinamica.
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var alumno = txt_alumno.Text;
            var curso = txt_curso.Text;
            var materia = txt_materia.Text;
            var nombre_tarea = txt_nombre_tarea.Text;
            DateTime fecha = dtp_fecha.Value;

            if (AreFieldsValid(alumno, curso, materia, nombre_tarea))
            {
                string cadena = BuildCadena(alumno, curso, materia, nombre_tarea, fecha);
                lst_tareas.Items.Add(cadena);
                LimpiarForm();
            }
            else
            {
                MessageBox.Show("No se pudo guardar, faltan campos por agregar.");
            }
        }
        public void LimpiarForm()
        {
            txt_alumno.Text = string.Empty;
            txt_curso.Text = string.Empty;
            txt_materia.Text = string.Empty;
            txt_nombre_tarea.Text = string.Empty;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_tareas.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede Eliminar. Selecciona un elemento");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar esta Tarea?", "Tareas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lst_tareas.Items.RemoveAt(lst_tareas.SelectedIndex);
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("El usuario cancelo la operacion");
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}
