using System.Diagnostics;

namespace ExposicionBurbuja
{
    public partial class Form1 : Form
    {
        string TipoOrdenamiento = ""; // Aux para el switch
        int movimientos = 0, preguntas = 0, comparaciones = 0; // Contadores

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnIzquierda.Checked = true;
            rbtnAscendente.Checked = true;
            cbxNumeros.Text = "10";
            TipoOrdenamiento = "Izquierda";
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rbtnIzquierda.Checked = true;
            rbtnAscendente.Checked = true;
            txtTiempo.Text = "";
            txtMovimientos.Text = "";
            txtComparaciones.Text = "";
            txtPreguntas.Text = "";
            cbxNumeros.Text = "10";
            picbxGrafica.Image = null;
            lbxDesordenados.Items.Clear();
            lbxOrdenados.Items.Clear();
        }

        private void btnAleatorizar_Click(object sender, EventArgs e)
        {
            var _cronometro = new System.Diagnostics.Stopwatch();
            _cronometro.Start();
            lbxDesordenados.Items.Clear();
            lbxOrdenados.Items.Clear();
            int _numero;

            Random r = new Random();

            for (int x = 0; x < int.Parse(cbxNumeros.Text); x++)
            {
                do
                {
                    _numero = r.Next(0, 5001);
                } while (lbxDesordenados.Items.Contains(_numero));

                lbxDesordenados.Items.Add(_numero);
            }


            _cronometro.Stop();
            TimeSpan _TiempoTranscurrido = _cronometro.Elapsed;
            string _TiempoTotal = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _TiempoTranscurrido.Hours, _TiempoTranscurrido.Minutes, _TiempoTranscurrido.Seconds, _TiempoTranscurrido.Milliseconds / 10);
            txtTiempo.Text = _TiempoTotal;
            picbxGrafica.Image = Image.FromFile(".\\Imagenes\\desordenado.png");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lbxOrdenados.Items.Clear();

            int[] _valores = new int[lbxDesordenados.Items.Count]; // Creacion arreglo

            var _cronometro = new System.Diagnostics.Stopwatch();
            _cronometro.Start();

            for (int i = 0; i < lbxDesordenados.Items.Count; i++) // Llenado del arreglo
            {
                _valores[i] = Convert.ToInt32(lbxDesordenados.Items[i]);
            }

            switch (TipoOrdenamiento)
            {
                case "Izquierda":
                    {
                        for(int i = 1; i < _valores.Length; i++)
                        {
                            for(int j = (_valores.Length - 1); j >= 1; j--)
                            {
                                //Si el ordenamiento es Ascendente
                                if (rbtnAscendente.Checked)
                                {
                                    if (_valores[j - 1] > _valores[j])
                                    {
                                        int auxiliar = _valores[j - 1];
                                        _valores[j - 1] = _valores[j];
                                        _valores[j] = auxiliar;
                                        movimientos++;
                                    }
                                    preguntas++;
                                }
                                //Si el ordenamiento es descendente
                                else
                                {
                                    if (_valores[j - 1] < _valores[j])
                                    {
                                        int auxiliar = _valores[j - 1];
                                        _valores[j - 1] = _valores[j];
                                        _valores[j] = auxiliar;
                                        movimientos++;
                                    }
                                    preguntas++;
                                }
                            }
                            comparaciones++;
                        }

                        for (int i = 0; i < int.Parse(cbxNumeros.Text); i++)
                        {
                            lbxOrdenados.Items.Add(_valores[i]);
                        }
                    }
                    break;
                case "Derecha":
                    {
                        int n = _valores.Length;
                        for (int i = 1; i < n - 1; i++)
                        {
                            for (int j = 1; j <= n - i; j++)
                            {
                                //Si el ordenamiento es ascendente
                                if (rbtnAscendente.Checked)
                                {
                                    if (_valores[j - 1] > _valores[j])
                                    {
                                        //Condición cumplida, traspaso de números.
                                        int _auxiliar = _valores[j - 1];
                                        _valores[j - 1] = _valores[j];
                                        _valores[j] = _auxiliar;
                                        movimientos++;
                                    }
                                    preguntas++;
                                }
                                //Si el ordenamiento es descendente
                                else
                                {
                                    if (_valores[j - 1] < _valores[j])
                                    {
                                        //Condición cumplida, traspaso de números.
                                        int _auxiliar = _valores[j - 1];
                                        _valores[j - 1] = _valores[j];
                                        _valores[j] = _auxiliar;
                                        movimientos++;
                                    }
                                    preguntas++;
                                }
                            }
                            comparaciones++;
                        }

                        for (int i = 0; i < n; i++)
                        {
                            lbxOrdenados.Items.Add(_valores[i]);
                        }
                    }
                    break;
                case "ConSeñal":
                    {
                        bool b = true;
                        while (b)
                        {
                            b = false;
                            for (int j = (_valores.Length - 1); j >= 1; j--)
                            {
                                //Si el ordenamiento es ascendente
                                if (rbtnAscendente.Checked)
                                {
                                    if (_valores[j - 1] > _valores[j])
                                    {
                                        int auxiliar = _valores[j - 1];
                                        _valores[j - 1] = _valores[j];
                                        _valores[j] = auxiliar;
                                        b = true;
                                        movimientos++;
                                    }
                                }
                                //Si el ordenamiento es descendente
                                else
                                {
                                    if (_valores[j - 1] < _valores[j])
                                    {
                                        int auxiliar = _valores[j - 1];
                                        _valores[j - 1] = _valores[j];
                                        _valores[j] = auxiliar;
                                        b = true;
                                        movimientos++;
                                    }
                                }
                                preguntas++;
                            }
                            comparaciones++;
                        }

                        for (int i = 0; i < int.Parse(cbxNumeros.Text); i++)
                        {
                            lbxOrdenados.Items.Add(_valores[i]);
                        }
                    }
                    break;
            }

            if (rbtnAscendente.Checked)
                picbxGrafica.Image = Image.FromFile(".\\Imagenes\\ordenado.png");
            else
                if (rbtnDescendente.Checked)
                picbxGrafica.Image = Image.FromFile(".\\Imagenes\\ordenado2.png");

            _cronometro.Stop();
            TimeSpan _TiempoTranscurrido = _cronometro.Elapsed;
            string _TiempoTotal = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _TiempoTranscurrido.Hours, _TiempoTranscurrido.Minutes, _TiempoTranscurrido.Seconds, _TiempoTranscurrido.Milliseconds / 10);
            txtTiempo.Text = _TiempoTotal;
            txtMovimientos.Text = movimientos.ToString();
            txtComparaciones.Text = comparaciones.ToString();
            txtPreguntas.Text = preguntas.ToString();
            movimientos = 0;
            comparaciones = 0;
            preguntas = 0;
        }

        private void rbtnIzquierda_CheckedChanged(object sender, EventArgs e)
        {
            TipoOrdenamiento = "Izquierda";
        }

        private void rbtnDerecha_CheckedChanged(object sender, EventArgs e)
        {
            TipoOrdenamiento = "Derecha";
        }

        private void rbtnConSeñal_CheckedChanged(object sender, EventArgs e)
        {
            TipoOrdenamiento = "ConSeñal";
        }
    }
}