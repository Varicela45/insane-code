namespace Burbuja
{
    using System.Diagnostics;
    public partial class Form1 : Form
    {
        List<Persona> p = new List<Persona>();
        int intMovimientos = 0, intPreguntas = 0, intComparaciones = 0;
        TimeSpan _TiempoTranscurrido;
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
            intMovimientos = 0; intPreguntas = 0; intComparaciones = 0;
            var _Cronometro = new Stopwatch();
            _Cronometro.Start();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (p[j].Edad > p[j + 1].Edad)
                    {
                        Persona temp = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = temp;
                        intMovimientos++;
                    }
                    intPreguntas++;
                }
                intComparaciones++;
            }
            _Cronometro.Stop();
            _TiempoTranscurrido = _Cronometro.Elapsed;
        }

        private void OrdenarBurbujaIzquierda()
        {
            bool b = true;
            intMovimientos = 0; intPreguntas = 0; intComparaciones = 0;
            var _Cronometro = new Stopwatch();
            _Cronometro.Start();
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
                        intMovimientos++;
                    }
                    intPreguntas++;
                }
                intComparaciones++;
            }
            _Cronometro.Stop();
            _TiempoTranscurrido = _Cronometro.Elapsed;
        }

        private void OrdenarBurbujaConSenal()
        {
            bool b = true;
            int i = 0;
            intMovimientos = 0; intPreguntas = 0; intComparaciones = 0;
            var _Cronometro = new Stopwatch();
            _Cronometro.Start();
            while (i < (p.Count - 1) && b == true)
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
                        intMovimientos++;
                    }
                    intPreguntas++;
                }
                intComparaciones++;
                i++;
            }
            _Cronometro.Stop();
            _TiempoTranscurrido = _Cronometro.Elapsed;
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
            string _TiempoTotal = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _TiempoTranscurrido.Hours, _TiempoTranscurrido.Minutes, _TiempoTranscurrido.Seconds, _TiempoTranscurrido.Milliseconds / 10);
            txtTiempo.Text = _TiempoTotal;
            txtMovimientos.Text = intMovimientos.ToString();
            txtComparaciones.Text = intComparaciones.ToString();
            txtPreguntas.Text = intPreguntas.ToString();
            intMovimientos = 0;
            intComparaciones = 0;
            intPreguntas = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}