using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaEntidad;
using CapaException;
using CapaInterface;

namespace CapaNegocio
{
    public class ObraCompletoBO : IObraCompletoBO
    {
        private MuseoEntities _objContext;

        public ObraCompletoBO()
        {
            this._objContext = new MuseoEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }
        #region Métodos
        /// <summary>
        /// Método que lista las obras de arte
        /// </summary>
        /// <returns></returns>
        public IList<ObraCompleto> ListarObrasCompleto()
        {
            IList<ObraCompleto> obra = (from o in _objContext.Obra
                                        join p in _objContext.Persona
                                        on o.ArtistaRut equals p.Rut
                                        join u in _objContext.Ubicacion
                                        on o.UbicacionId equals u.Id
                                        where p.Tipo == 1
                                        select new ObraCompleto
                                        {
                                            Codigo = o.Codigo,
                                            Artista = p.Nombres + " " + p.ApPaterno + " " + p.ApMaterno,
                                            Estilo = o.Estilo,
                                            Valor = o.Valor,
                                            Dimensiones= o.Dimensiones,
                                            Procedencia = o.Procedencia,
                                            CuidadosEspeciales = o.CuidadosEspeciales,
                                            Salon = u.Salon,
                                            FechaIngreso = o.FechaIngreso
                                        }).ToList();
            return obra;
        }
        /// <summary>
        /// Método que lista las obras del último año ingresado
        /// </summary>
        /// <returns></returns>
        public IList<ObraCompleto> ListarObrasCompleto365()
        {
            DateTime inicio = DateTime.Today.AddYears(-1);
            IList<ObraCompleto> obra = (from o in _objContext.Obra
                                        join p in _objContext.Persona
                                        on o.ArtistaRut equals p.Rut
                                        join u in _objContext.Ubicacion
                                        on o.UbicacionId equals u.Id
                                        where p.Tipo == 1 && o.FechaIngreso >= inicio
                                        select new ObraCompleto
                                        {
                                            Codigo = o.Codigo,
                                            Artista = p.Nombres + " " + p.ApPaterno + " " + p.ApMaterno,
                                            Estilo = o.Estilo,
                                            Valor = o.Valor,
                                            Dimensiones = o.Dimensiones,
                                            Procedencia = o.Procedencia,
                                            CuidadosEspeciales = o.CuidadosEspeciales,
                                            Salon = u.Salon,
                                            FechaIngreso = o.FechaIngreso
                                        }).ToList();
            return obra;
        }

        /// <summary>
        /// Método que lista las obras de arte segun artista
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public IList<ObraCompleto> ListarObrasCompletoArtista(string rut)
        {
            if(string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
            {
                throw new ObraCompletoException("Error: falta rut de artista");
            }
            IList<ObraCompleto> obra = (from o in _objContext.Obra
                                        join p in _objContext.Persona
                                        on o.ArtistaRut equals p.Rut
                                        join u in _objContext.Ubicacion
                                        on o.UbicacionId equals u.Id
                                        where p.Tipo == 1 && p.Rut == rut
                                        select new ObraCompleto
                                        {
                                            Codigo = o.Codigo,
                                            Artista = p.Nombres + " " + p.ApPaterno + " " + p.ApMaterno,
                                            Estilo = o.Estilo,
                                            Valor = o.Valor,
                                            Dimensiones = o.Dimensiones,
                                            Procedencia = o.Procedencia,
                                            CuidadosEspeciales = o.CuidadosEspeciales,
                                            Salon = u.Salon,
                                            FechaIngreso = o.FechaIngreso
                                        }).ToList();
            return obra;
        }
        #endregion
    }
}
