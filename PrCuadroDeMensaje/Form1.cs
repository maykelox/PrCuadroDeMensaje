namespace PrCuadroDeMensaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Declaracion de variable
            string nombre;
            //Entrada de datos
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre", "Registro De Datos","Miguel Joel", 100,0);
            MessageBox.Show("Bienvenido Usuario:" + nombre, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente quieres salir de la aplicacion?", "Salir Del Programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion == DialogResult.OK)
            {
                Close();
            }
        }
    }
}