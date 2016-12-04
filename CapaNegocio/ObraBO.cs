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
        string fechaCreacion, DateTime? procedencia, string temperatura, string humedad, string ubicacionSalon)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
            {
                throw new ObraException("Error: falta Codigo.");
            }

            Obra obra = new Obra
            {
                Codigo = codigo,
                ArtistaRut = artistaRut,
                Estilo = estilo,
                Valor = valor,
                Dimensiones = dimensiones,
                FechaCreacion = fechaCreacion,
                Procedencia = procedencia,
                Temperatura = temperatura,
                Humedad = humedad,
                UbicacionSalon = ubicacionSalon
                
            };
            this._objContext.Obra.Add(obra);
            return this._objContext.SaveChanges() > 0;
        }
        public bool VerificarObra(string codigo)
        {
            return this._objContext.Obra.Any(o => o.Codigo == codigo);
        }

        public IList<Obra> ListarObras()
        {
            return this._objContext.Obra.ToList();
        }
        
    }

}
