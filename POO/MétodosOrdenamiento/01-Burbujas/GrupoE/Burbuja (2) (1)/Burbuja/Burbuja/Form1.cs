namespace Burbuja
{
    public partial class Form1 : Form
    {
        List<Persona> p = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona pp = new Persona();
            Random r = new Random();
            string[] nombres = { "Arturo", "Pedro", "Pepe", "Kevin", "Eder", "Luis", "Carlos" };
            pp.Nombre = nombres[r.Next(nombres.Length)];
            pp.Edad = r.Next(17, 50);
            pp.Telefono = r.Next(1000000, 10000000);

            p.Add(pp);

            dataGridView1.Rows.Clear();
            foreach (Persona p in p)
            {
                dataGridView1.Rows.Add(p.Nombre, p.Edad, p.Telefono);
            }
        }

        private void OrdenarBurbujaDerecha()
        {
            int n = p.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (p[j].Edad > p[j + 1].Edad)
                    {
                        Persona temp = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = temp;
                    }
                }
            }
        }

        private void OrdenarBurbujaIzquierda()
        {
            bool b = true;
            while (b)
            {
                b = false;
                for (int j = (p.Count - 1); j >= 1; j--)
                {
                    if (p[j - 1].Edad > p[j].Edad)
                    {
                        Persona auxiliar = p[j - 1];
                        p[j - 1] = p[j];
                        p[j] = auxiliar;
                        b = true;
                    }
                }
            }
        }

        private void OrdenarBurbujaConSenal()
        {
            bool b = true;
            int i = 0;
            while (i<(p.Count-1) && b==true)
            {
                b = false;
                for (int j = 0; j < (p.Count - 1); j++)
                {
                    if (p[j].Edad > p[j + 1].Edad)
                    {
                        Persona auxiliar = p[j + 1];
                        p[j + 1] = p[j];
                        p[j] = auxiliar;
                        b = true;
                    }
                }
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                OrdenarBurbujaDerecha();
                dataGridView2.Rows.Clear();
                foreach (Persona p in p)
                {
                    dataGridView2.Rows.Add(p.Nombre, p.Edad, p.Telefono);
                }
            }
            if (radioButton2.Checked)
            {
                OrdenarBurbujaIzquierda();
                dataGridView2.Rows.Clear();
                foreach (Persona p in p)
                {
                    dataGridView2.Rows.Add(p.Nombre, p.Edad, p.Telefono);
                }
            }
            if (radioButton3.Checked)
            {
                OrdenarBurbujaConSenal();
                dataGridView2.Rows.Clear();
                foreach (Persona p in p)
                {
                    dataGridView2.Rows.Add(p.Nombre, p.Edad, p.Telefono);
                }
            }
        }
    }
}