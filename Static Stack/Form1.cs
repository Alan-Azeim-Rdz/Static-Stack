using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Static_Stack
{
    public partial class Form1 : Form
    {
        private Sstack stack = new Sstack(); 
        public Form1()
        {

            InitializeComponent();
        }
        
        private void btnPush_Click(object sender, EventArgs e)
        {

            try
            {
                int number = Convert.ToInt32(txtInput.Text);
                stack.Push(number);
                ActualizarPila();
                txtInput.Clear();
            }
            catch 
            {
                    MessageBox.Show("Por favor, ingresa un número válido.");
            }

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.Pop());
            ActualizarPila();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elemento en el tope: " + stack.Peek());
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamaño actual de la pila: " + stack.Size());
        }

        private void ActualizarPila()
        {
            lstStack.Items.Clear();
            Sstack temporal = new Sstack();
            string elemento;

            // Mostrar los elementos en la pila
            while (!stack.IsEmpty())
            {
                elemento = stack.Pop();
                lstStack.Items.Add(elemento);
                temporal.Push(int.Parse(elemento));
            }

            // Restaurar los elementos en la pila original
            while (!temporal.IsEmpty())
            {
                stack.Push(int.Parse(temporal.Pop()));
            }
        }

    }
}
