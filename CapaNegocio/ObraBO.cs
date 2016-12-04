using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaException;
using CapaInterface;

namespace CapaNegocio
{
    public class ObraBO : IObraBO
    {
        private MuseoEntities _objContext;

        public ObraBO()
        {
            this._objContext = new MuseoEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public bool AgregarObra(string codigo, string artistaRut, string estilo, long valor, string dimensiones,
        DateTime fechaCreacion, string procedencia, string cuidadosEspeciales, int ubicacionId, DateTime fechaIngreso)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
            {
                throw new ObraException("Error: falta Codigo.");
            }
            if (string.IsNullOrEmpty(artistaRut) || string.IsNullOrWhiteSpace(artistaRut))
            {
                throw new ObraException("Error: falta rut de artista");
            }
            if (ubicacionId <= 0)
            {
                throw new ObraException("Error: falta id de ubicación");
            }
            if (!this.VerificarObra(codigo))
            {
                Obra obra = new Obra
                {
                    Codigo = codigo,
                    ArtistaRut = artistaRut,
                    Estilo = estilo,
                    Valor = valor,
                    Dimensiones = dimensiones,
                    FechaCreacion = fechaCreacion,
                    Procedencia = procedencia,
                    CuidadosEspeciales = cuidadosEspeciales,
                    UbicacionId = ubicacionId,
                    FechaIngreso = fechaIngreso
                };
                this._objContext.Obra.Add(obra);
                return this._objContext.SaveChanges() > 0;
            }
            return false;
        }

        public bool VerificarObra(string codigo)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
            {
                throw new ObraException("Error: falta código de obra");
            }
            return this._objContext.Obra.Any(o => o.Codigo == codigo);
        }

        public IList<Obra> ListarObras()
        {
            return this._objContext.Obra.ToList();
        }

        public IList<Obra> ListarObrasArtista(string artistaRut)
        {
            if (string.IsNullOrEmpty(artistaRut) || string.IsNullOrWhiteSpace(artistaRut))
            {
                throw new ObraException("Error: falta rut de artista");
            }
            return this._objContext.Obra.Where(o => o.ArtistaRut == artistaRut).ToList();
        }
    }
}
