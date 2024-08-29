using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_Desordenada
{
    class PedimentoExportacion : IEquatable<PedimentoExportacion>
    {

        //Atributos
        int _intNoPedimento;
        double _dblPesoNeto;
        double _dblCosto;
        string _strNombreConductor;
        string _strRFC;
        string _strRazon;
        string _strTipoCarga;
        string _strImagen;
        char _chrLote;
        DateTime _dtmHorarioEntrada;
        bool _blnInspeccion;

        //Propiedades
        public int NoPedimento
        {
            get { return _intNoPedimento; }
            set { _intNoPedimento = value; }
        }
        public double PesoNeto
        {
            get { return _dblPesoNeto; }
            set { _dblPesoNeto = value; }
        }
        public double Costo
        {
            get { return _dblCosto; }
            set { _dblCosto = value; }
        }
        public string NombreConductor
        {
            get { return _strNombreConductor; }
            set { _strNombreConductor = value; }
        }
        public string RFC
        {
            get { return _strRFC; }
            set { _strRFC = value; }
        }
        public string Razon
        {
            get { return _strRazon; }
            set { _strRazon = value; }
        }
        public string TipoCarga
        {
            get { return _strTipoCarga; }
            set { _strTipoCarga = value; }
        }
        public string Imagen
        {
            get { return _strImagen; }
            set { _strImagen = value; }
        }
        public char Lote
        {
            get { return _chrLote; }
            set { _chrLote = value; }
        }
        public DateTime HorarioEntrada
        {
            get { return _dtmHorarioEntrada; }
            set { _dtmHorarioEntrada = value; }
        }
        public bool Inspeccion
        {
            get { return _blnInspeccion; }
            set { _blnInspeccion = value; }
        }

        //Metodos de la interfaz IEquatable
        public bool Equals(PedimentoExportacion pedimento)
        {
            if (pedimento == null)
            {
                return false;
            }

            if (pedimento.GetType() != this.GetType())
            {
                return false;
            }


            return (this.NoPedimento == pedimento.NoPedimento);
        }

    }
}
