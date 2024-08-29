using System.Diagnostics;
using System.Text;

namespace Pila_Desordenada
{
    public partial class Form1 : Form
    {
        //Se inicaliza la clase verde
        ClasePilaDesordenada<PedimentoExportacion> lista = new ClasePilaDesordenada<PedimentoExportacion>();
        //Datos auxiliares 
        bool BotonImagen = false;
        string RutaImagenFinal = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxRazon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLote.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CapturarDatos()
        {
            dgvListadePedimentos.Rows.Clear();

            foreach (PedimentoExportacion pedimento in lista)
            {
                dgvListadePedimentos.Rows.Add(pedimento.NoPedimento, pedimento.PesoNeto, pedimento.Costo, pedimento.NombreConductor, pedimento.RFC, pedimento.Razon, pedimento.TipoCarga, pedimento.Lote, pedimento.HorarioEntrada, pedimento.Inspeccion ? "Si" : "No", pedimento.Imagen);
            }
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(txtNoPedimento.Text))
            {
                return (false);
            }
            if (string.IsNullOrEmpty(txtPesoNeto.Text))
            {
                return (false);
            }
            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                return (false);
            }
            if (string.IsNullOrEmpty(cbxLote.Text))
            {
                return (false);
            }
            if (string.IsNullOrEmpty(cbxRazon.Text))
            {
                return (false);
            }
            if (string.IsNullOrEmpty(txtNombreConductor.Text))
            {
                return (false);
            }
            if (string.IsNullOrEmpty(txtRFC.Text))
            {
                return (false);
            }
            if (!rbtFragil.Checked && !rbtGeneral.Checked && !rbtGranel.Checked && !rbtPeligrosa.Checked && !rbtPerecederas.Checked)
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

        public void Limpiar()
        {
            txtNoPedimento.Clear();
            txtPesoNeto.Clear();
            txtCosto.Clear();
            dtpHorarioEntrada.Value = DateTime.Now;
            cbxLote.SelectedItem = null;
            cbxRazon.SelectedItem = null;
            txtNombreConductor.Clear();
            txtRFC.Clear();
            rbtGeneral.Checked = false;
            rbtFragil.Checked = false;
            rbtGranel.Checked = false;
            rbtPerecederas.Checked = false;
            rbtPeligrosa.Checked = false;
            chkInspeccion.Checked = false;
            pbxImagen.Image = null;
        }

        public string GenerarStringAleatorio(int Mayor, int Menor)
        {
            Random random = new Random();
            int longitud = random.Next(Mayor, Menor + 1); // Longitud aleatoria entre mínima y máxima

            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; // Caracteres permitidos
            StringBuilder sb = new StringBuilder(longitud);

            for (int i = 0; i < longitud; i++)
            {
                int indiceCaracter = random.Next(caracteresPermitidos.Length);
                char caracterAleatorio = caracteresPermitidos[indiceCaracter];
                sb.Append(caracterAleatorio);
            }

            return sb.ToString();
        }

        public string CargarImagen()
        {
            string RutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string ruta = RutaBase.Substring(0, RutaBase.IndexOf("bin", StringComparison.OrdinalIgnoreCase));
            string rutaCarpeta = Path.Combine(ruta, "Sitios");

            string strNombreArchivo = null;
            // Declaración de variable para seleccionar el archivo
            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos JPEG (*.jpg) | *.jpg";
            miArchivoFoto.InitialDirectory = rutaCarpeta;
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                return (strNombreArchivo);
            }
            else return (null);
        }

        public string ImagenAleatoria(string ruta)
        {
            // Se crea un objeto Random
            Random aleatorio = new Random();
            int imagen = aleatorio.Next(1, 7);
            string rutaFinal = "";

            //Y dependiendo del valor aleatorio se consigue que imagen se usara
            if (imagen == 1)
            {
                rutaFinal = Path.Combine(ruta, "1 - Amberes.jpg");
                return rutaFinal;
            }
            if (imagen == 2)
            {
                rutaFinal = Path.Combine(ruta, "2 - Hamburgo.jpg");
                return rutaFinal;
            }
            if (imagen == 3)
            {
                rutaFinal = Path.Combine(ruta, "3 - Los Angeles.jpg");
                return rutaFinal;
            }
            if (imagen == 4)
            {
                rutaFinal = Path.Combine(ruta, "4 - Roterdam.jpg");
                return rutaFinal;
            }
            if (imagen == 5)
            {
                rutaFinal = Path.Combine(ruta, "5 - Shanghai.jpg");
                return rutaFinal;
            }
            if (imagen == 6)
            {
                rutaFinal = Path.Combine(ruta, "6 - Singapur.jpg");
                return rutaFinal;
            }
            return rutaFinal;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se valida que ningun control este vacio o sin seleccionar
                if (Validar() == false)
                {
                    MessageBox.Show("Favor de rellenar y seleccionar toda la informacion correspondiente");
                }
                else
                {
                    //Objeto rojo
                    PedimentoExportacion pedimento = new PedimentoExportacion();

                    //Se capturan los datos de los controles
                    string Carga = "";
                    string Insp = "";
                    pedimento.NoPedimento = int.Parse(txtNoPedimento.Text);
                    pedimento.PesoNeto = double.Parse(txtPesoNeto.Text);
                    pedimento.Costo = double.Parse(txtCosto.Text);
                    pedimento.HorarioEntrada = DateTime.Parse(dtpHorarioEntrada.Text);
                    pedimento.Lote = char.Parse(cbxLote.Text);
                    pedimento.Razon = cbxRazon.Text;
                    pedimento.NombreConductor = txtNombreConductor.Text;
                    pedimento.RFC = txtRFC.Text;

                    if (rbtGeneral.Checked)
                    {
                        Carga = "General";
                    }
                    if (rbtGranel.Checked)
                    {
                        Carga = "A granel";
                    }
                    if (rbtFragil.Checked)
                    {
                        Carga = "Fragil";
                    }
                    if (rbtPerecederas.Checked)
                    {
                        Carga = "Perecedera";
                    }
                    if (rbtPeligrosa.Checked)
                    {
                        Carga = "Peligrosa";
                    }
                    pedimento.TipoCarga = Carga;

                    if (chkInspeccion.Checked)
                    {
                        pedimento.Inspeccion = true;
                    }
                    else
                    {
                        pedimento.Inspeccion = false;
                    }

                    //El boton que se tenia que presionar para poder continuar era el que generaba la ruta de acceso de la imagen, y aqui se captura por parte del objeto rojo
                    pedimento.Imagen = RutaImagenFinal;
                    //Se verifica, aun con todos los controles llenos, que se de click en el boton que genere la imagen
                    if (BotonImagen)
                    {
                       
                        //Se aplica el metodo de la clase verde para ingresar los nodos y ordenarlos
                        lista.Push(pedimento);
                        //Se añaden al DataGriedView
                        CapturarDatos();

                    }
                    else
                    {
                        MessageBox.Show("Falta presionar el boton de generar imagen");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("NO se permiten datos duplicados");
            }
            finally
            {
                Limpiar();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se crean dos objetos rojos
            PedimentoExportacion pedimento = new PedimentoExportacion();
            PedimentoExportacion pedimentoEliminado = new PedimentoExportacion();

            try
            {
                //Al darle click a una fila, esta se captura para su posible eliminacion
                pedimento.NoPedimento = int.Parse(dgvListadePedimentos.SelectedCells[0].Value.ToString());

                //Se pregunta si se quiere eliminar 
                DialogResult Aviso = MessageBox.Show("¿Estas seguro de querer eliminar este pedimento?", "Eliminar", MessageBoxButtons.YesNo);
                if (Aviso == DialogResult.Yes)
                {
                    //El objeto pedimentoEliminado busca el objeto pedimento
                    string Inspeccion;
                    pedimentoEliminado = lista.BuscarNodo(pedimento);
                    if (pedimentoEliminado.Inspeccion == true)
                    {
                        Inspeccion = "Si";
                    }
                    else
                    {
                        Inspeccion = "No";
                    }

                    //Se elimina la fila del DataGriedView
                    if (dgvListadePedimentos.SelectedRows.Count > 0)
                    {
                        dgvListadePedimentos.Rows.RemoveAt(dgvListadePedimentos.SelectedRows[0].Index);
                    }

                    //Se muestra un messagebox con TODA la informacion del objeto borrado
                    MessageBox.Show("T E C O C O M" + "\n" +
                        "S.A de C.V" + "\n" + "\n" +
                        "Datos del pedimento mandado a eliminar:" + "\n" + "\n" +
                        "Numero de pedimento:  " +
                        pedimentoEliminado.NoPedimento + "\n" +
                        "Peso neto de la carga:  " +
                        pedimentoEliminado.PesoNeto + "\n" +
                        "Costo:  " +
                        pedimentoEliminado.Costo + "\n" +
                        "Tipo de exportacion (lote):  " +
                        pedimentoEliminado.Lote + "\n" +
                        "Razon del viaje:  " +
                        pedimentoEliminado.Razon + "\n" +
                        "Nombre del conductor:  " +
                        pedimentoEliminado.NombreConductor + "\n" +
                        "RFC:  " +
                        pedimentoEliminado.RFC + "\n" +
                        "Tipo de carga:  " +
                        pedimentoEliminado.TipoCarga + "\n" +
                        "¿Paso por Inspeccion?:  " +
                        Inspeccion);

                    //Y se elimina el objeto de la lista
                    pedimentoEliminado = lista.Pop(pedimento);

                    btnEliminar.Enabled = false;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tiene que seleccionar una fila con datos, la lista se encuentra vacia");
            }
        }

        private void btnNodosRandom_Click(object sender, EventArgs e)
        {
            try
            {
                //Se crea un objeto rojo
                PedimentoExportacion pedimento = new PedimentoExportacion();

                //A continiacion se crean los valores aleatorios
                Random AleatorioNoPedimento = new Random();
                int NoPedimentoR = AleatorioNoPedimento.Next(1, 201);

                Random AleatorioPesoNeto = new Random();
                double PesoNetoR = Math.Round(AleatorioPesoNeto.NextDouble() * 500, 2);

                Random AleatorioCosto = new Random();
                double CostoR = Math.Round(AleatorioCosto.NextDouble() * 500000, 2);

                Random AleatorioTipoExportacion = new Random();
                char TipoExportacionR = (char)(AleatorioTipoExportacion.Next(65, 69));

                Random AleatorioRazon = new Random();
                int RazonNo = AleatorioRazon.Next(1, 4);
                string RazonR = "";
                if (RazonNo == 1)
                {
                    RazonR = "Alimentaria";
                }
                if (RazonNo == 2)
                {
                    RazonR = "Construccion";
                }
                if (RazonNo == 3)
                {
                    RazonR = "Tecnologia";
                }

                int Longitud = 10;
                string NombreConductorR = GenerarStringAleatorio(2, 15);

                Random AleatorioRFC = new Random();
                string RFCR = Guid.NewGuid().ToString().Substring(0, Longitud);

                Random AleatorioTipoCarga = new Random();
                int TipoCargaNo = AleatorioTipoCarga.Next(1, 4);
                string TipoCargaR = "";

                if (TipoCargaNo == 1)
                {
                    TipoCargaR = "General";
                }
                if (TipoCargaNo == 2)
                {
                    TipoCargaR = "A granel";
                }
                if (TipoCargaNo == 3)
                {
                    TipoCargaR = "Fragil";
                }
                if (TipoCargaNo == 4)
                {
                    TipoCargaR = "Perecedera";
                }
                if (TipoCargaNo == 5)
                {
                    TipoCargaR = "Peligrosa";
                }

                Random AleatorioInspeccion = new Random();
                bool InspeccionR = AleatorioInspeccion.Next(0, 2) == 0 ? false : true;

                string RutaBase = AppDomain.CurrentDomain.BaseDirectory;
                string ruta = RutaBase.Substring(0, RutaBase.IndexOf("bin", StringComparison.OrdinalIgnoreCase));
                string rutaCarpeta = Path.Combine(ruta, "Sitios");
                RutaImagenFinal = ImagenAleatoria(rutaCarpeta);
                pbxImagen.Image = Image.FromFile(RutaImagenFinal);

                //Despues se capturan por los atributos del objeto
                pedimento.Imagen = RutaImagenFinal;
                pedimento.NoPedimento = NoPedimentoR;
                pedimento.PesoNeto = PesoNetoR;
                pedimento.Costo = CostoR;
                pedimento.Lote = TipoExportacionR;
                pedimento.Razon = RazonR;
                pedimento.NombreConductor = NombreConductorR;
                pedimento.RFC = RFCR;
                pedimento.TipoCarga = TipoCargaR;
                pedimento.Inspeccion = InspeccionR;
                pedimento.HorarioEntrada = DateTime.Now;

                //Se agregan los nodos y se capturan en el DataGriedView, como en el boton de Agregar
                lista.Push(pedimento);
                CapturarDatos();
                Limpiar();
            }
            catch
            {

            }

        }

        private void btnEliminarTop_Click(object sender, EventArgs e)
        {
            //Se crean dos objetos rojos
            PedimentoExportacion pedimento = new PedimentoExportacion();
            PedimentoExportacion pedimentoEliminado = new PedimentoExportacion();

            try
            {
                DataGridViewRow primeraFila = dgvListadePedimentos.Rows[0];
                pedimento.NoPedimento = int.Parse(primeraFila.Cells[0].Value.ToString());

                //Se pregunta si se quiere eliminar
                DialogResult Aviso = MessageBox.Show("¿Estas seguro de querer eliminar este pedimento?", "Eliminar", MessageBoxButtons.YesNo);
                if (Aviso == DialogResult.Yes)
                {
                    //El objeto pedimentoEliminado busca el objeto pedimento
                    string Inspeccion;
                    pedimentoEliminado = lista.BuscarNodo(pedimento);

                    if (pedimentoEliminado.Inspeccion == true)
                    {
                        Inspeccion = "Si";
                    }
                    else
                    {
                        Inspeccion = "No";
                    }

                    //Se elimina la fila del DataGriedView
                    if (dgvListadePedimentos.Rows.Count > 0)
                    {
                        dgvListadePedimentos.Rows.RemoveAt(0);
                    }

                    //Se muestra un messagebox con TODA la informacion del objeto borrado
                    MessageBox.Show("T E C O C O M" + "\n" +
                        "S.A de C.V" + "\n" + "\n" +
                        "Datos del pedimento mandado a eliminar:" + "\n" + "\n" +
                        "Numero de pedimento:  " +
                        pedimentoEliminado.NoPedimento + "\n" +
                        "Peso neto de la carga:  " +
                        pedimentoEliminado.PesoNeto + "\n" +
                        "Costo:  " +
                        pedimentoEliminado.Costo + "\n" +
                        "Tipo de exportacion (lote):  " +
                        pedimentoEliminado.Lote + "\n" +
                        "Razon del viaje:  " +
                        pedimentoEliminado.Razon + "\n" +
                        "Nombre del conductor:  " +
                        pedimentoEliminado.NombreConductor + "\n" +
                        "RFC:  " +
                        pedimentoEliminado.RFC + "\n" +
                        "Tipo de carga:  " +
                        pedimentoEliminado.TipoCarga + "\n" +
                        "¿Paso por Inspeccion?:  " +
                        Inspeccion);

                    //Y se elimina el objeto de la lista
                    pedimentoEliminado = lista.Pop();

                    btnEliminar.Enabled = false;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tiene que seleccionar una fila con datos, la lista se encuentra vacia");
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                BotonImagen = true;
                RutaImagenFinal = CargarImagen();
                pbxImagen.Image = Image.FromFile(RutaImagenFinal);
            }
            catch (Exception)
            {
                BotonImagen = false;
                MessageBox.Show("a");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se avisa si realmente quiere vaciarse toda la lista
                DialogResult Aviso = MessageBox.Show("¿Estas seguro de querer eliminar TODOS los pedimentos?", "Vaciar", MessageBoxButtons.YesNo);
                if (Aviso == DialogResult.Yes)
                {
                    //Y si es asi, entonces se borra
                    lista.Vaciar();
                    //Se borra todo el DataGriedView
                    dgvListadePedimentos.Rows.Clear();
                }
            }
            catch (Exception)
            {
                //Y si ya esta vacia pues no se hace nada
                MessageBox.Show("Pues esta de suerte, la lista ya se encuentra vacia");
            }
            finally
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se instancian dos clases rojas para la busqueda 
                PedimentoExportacion BuscarPedimento = new PedimentoExportacion();
                PedimentoExportacion pedimento = new PedimentoExportacion();

                pedimento.NoPedimento = int.Parse(txtBuscar.Text);
                BuscarPedimento = lista.BuscarNodo(pedimento);

                if(BuscarPedimento == null)
                {
                    MessageBox.Show("El pedimento no existe");
                    
                }
                else
                {
                    txtNoPedimento.Text = BuscarPedimento.NoPedimento.ToString();
                    txtPesoNeto.Text = BuscarPedimento.PesoNeto.ToString();
                    txtCosto.Text = BuscarPedimento.Costo.ToString();
                    dtpHorarioEntrada.Text = BuscarPedimento.HorarioEntrada.ToString();
                    cbxLote.Text = BuscarPedimento.Lote.ToString();
                    cbxRazon.Text = BuscarPedimento.Razon.ToString();
                    txtNombreConductor.Text = BuscarPedimento.NombreConductor.ToString();
                    txtRFC.Text = BuscarPedimento.RFC.ToString();

                    //Ademas de la imagen que quedo guardada tambien en el objeto
                    pbxImagen.Image = Image.FromFile(BuscarPedimento.Imagen);

                    //Se captura la informacion del objeto y los transforma en los controles
                    chkInspeccion.Checked = BuscarPedimento.Inspeccion; txtNoPedimento.Text = BuscarPedimento.NoPedimento.ToString();
                    txtPesoNeto.Text = BuscarPedimento.PesoNeto.ToString();
                    txtCosto.Text = BuscarPedimento.Costo.ToString();
                    dtpHorarioEntrada.Text = BuscarPedimento.HorarioEntrada.ToString();
                    cbxLote.Text = BuscarPedimento.Lote.ToString();
                    cbxRazon.Text = BuscarPedimento.Razon.ToString();
                    txtNombreConductor.Text = BuscarPedimento.NombreConductor.ToString();
                    txtRFC.Text = BuscarPedimento.RFC.ToString();

                    //Ademas de la imagen que quedo guardada tambien en el objeto
                    pbxImagen.Image = Image.FromFile(BuscarPedimento.Imagen);

                    //Se captura la informacion del objeto y los transforma en los controles
                    chkInspeccion.Checked = BuscarPedimento.Inspeccion;

                    if (BuscarPedimento.TipoCarga == "Fragil")
                    {
                        rbtFragil.Checked = true;
                    }
                    if (BuscarPedimento.TipoCarga == "General")
                    {
                        rbtGeneral.Checked = true;
                    }
                    if (BuscarPedimento.TipoCarga == "A granel")
                    {
                        rbtGranel.Checked = true;
                    }
                    if (BuscarPedimento.TipoCarga == "Perecedera")
                    {
                        rbtPerecederas.Checked = true;
                    }
                    if (BuscarPedimento.TipoCarga == "Peligrosa")
                    {
                        rbtPeligrosa.Checked = true;
                    }
                }

                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No ha ingresado ningun pedimento");
            }
            catch (Exception)
            {
                MessageBox.Show("El pedimento que ha ingresado no existe");
            }
            finally
            {
                txtBuscar.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Se pregunta antes si se quiere salir realmente
            DialogResult Aviso = MessageBox.Show("¿Quiere salirse de la aplicacion?", "Salir", MessageBoxButtons.YesNo);
            if (Aviso == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvListadePedimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;

            if (e.RowIndex >= 0)
            {
                //Se llenan los textbox y combobox
                txtNoPedimento.Text = dgvListadePedimentos.SelectedCells[0].Value.ToString();
                txtPesoNeto.Text = dgvListadePedimentos.SelectedCells[1].Value.ToString();
                txtCosto.Text = dgvListadePedimentos.SelectedCells[2].Value.ToString();
                txtNombreConductor.Text = dgvListadePedimentos.SelectedCells[3].Value.ToString();
                txtRFC.Text = dgvListadePedimentos.SelectedCells[4].Value.ToString();
                cbxRazon.Text = dgvListadePedimentos.SelectedCells[5].Value.ToString();

                //Se activan los radiobutton segun el caso
                if (dgvListadePedimentos.SelectedCells[6].Value.ToString() == "Fragil")
                {
                    rbtFragil.Checked = true;
                }
                if (dgvListadePedimentos.SelectedCells[6].Value.ToString() == "General")
                {
                    rbtGeneral.Checked = true;
                }
                if (dgvListadePedimentos.SelectedCells[6].Value.ToString() == "A granel")
                {
                    rbtGranel.Checked = true;
                }
                if (dgvListadePedimentos.SelectedCells[6].Value.ToString() == "Perecedera")
                {
                    rbtPerecederas.Checked = true;
                }
                if (dgvListadePedimentos.SelectedCells[6].Value.ToString() == "Peligrosa")
                {
                    rbtPeligrosa.Checked = true;
                }

                //Mas Textbox y el DataTimePicker
                cbxLote.Text = dgvListadePedimentos.SelectedCells[7].Value.ToString();
                dtpHorarioEntrada.Text = dgvListadePedimentos.SelectedCells[8].Value.ToString();

                //Se activa el checkbox segun el momento
                if (dgvListadePedimentos.SelectedCells[9].Value.ToString() == "Si")
                {
                    chkInspeccion.Checked = true;
                }
                if (dgvListadePedimentos.SelectedCells[9].Value.ToString() == "No")
                {
                    chkInspeccion.Checked = false;
                }

                //Esta variable global almacena la ruta de direccion de la imagen y la obtiene de una casilla oculta del DataGriedView
                RutaImagenFinal = dgvListadePedimentos.SelectedCells[10].Value.ToString();

                //Se envia el string de la ruta de la imagen y la muestra en un picturebox
                if (File.Exists(RutaImagenFinal))
                {
                    // Carga y muestra la imagen
                    pbxImagen.Image = Image.FromFile(RutaImagenFinal);
                }
                else
                {
                    // Maneja el caso en el que la ruta de archivo no es válida o la imagen no existe
                    MessageBox.Show("Ruta de archivo no válida o imagen no encontrada.");
                }
            }
        }

        private void txtNoPedimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Escriba por favor solo numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtPesoNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Escriba por favor solo numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Escriba por favor solo numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Escriba por favor solo numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}