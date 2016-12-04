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
        #region Métodos
        /// <summary>
        /// Método que agrega nuevas obras de arte
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="artistaRut"></param>
        /// <param name="estilo"></param>
        /// <param name="valor"></param>
        /// <param name="dimensiones"></param>
        /// <param name="procedencia"></param>
        /// <param name="cuidadosEspeciales"></param>
        /// <param name="ubicacionId"></param>
        /// <param name="fechaIngreso"></param>
        /// <returns></returns>
        public bool AgregarObra(string codigo, string artistaRut, string estilo, long valor, string dimensiones, string procedencia, string cuidadosEspeciales, int ubicacionId, DateTime? fechaIngreso)
        {
            #region Validación
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
            if (this.VerificarObra(codigo))
            {
                throw new ObraException("Error: Obra ya existe");
            }
            #endregion
            Obra obra = new Obra
            {
                Codigo = codigo,
                ArtistaRut = artistaRut,
                Estilo = estilo,
                Valor = valor,
                Dimensiones = dimensiones,
                Procedencia = procedencia,
                CuidadosEspeciales = cuidadosEspeciales,
                UbicacionId = ubicacionId,
                FechaIngreso = fechaIngreso
            };
            this._objContext.Obra.Add(obra);
            return this._objContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Método que verifica si una obra ya se encuentra ingresada.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool VerificarObra(string codigo)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
            {
                throw new ObraException("Error: falta código de obra");
            }
            return this._objContext.Obra.Any(o => o.Codigo == codigo);
        }

        /// <summary>
        /// Método que lista todas las obras de arte
        /// </summary>
        /// <returns></returns>
        public IList<Obra> ListarObras()
        {
            return this._objContext.Obra.ToList();
        }

        /// <summary>
        /// Métodoq que lista las obras según artista
        /// </summary>
        /// <param name="artistaRut"></param>
        /// <returns></returns>
        public IList<Obra> ListarObrasArtista(string artistaRut)
        {
            if (string.IsNullOrEmpty(artistaRut) || string.IsNullOrWhiteSpace(artistaRut))
            {
                throw new ObraException("Error: falta rut de artista");
            }
            return this._objContext.Obra.Where(o => o.ArtistaRut == artistaRut).ToList();
        }
        #endregion
    }
}
