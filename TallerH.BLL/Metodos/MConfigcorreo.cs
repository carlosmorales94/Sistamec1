using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;
using System.Transactions;

namespace TallerH.BLL.Metodos
{
     public class MConfigcorreo : IConfigcorreo
    {
        private static MConfigcorreo instancia;

        public static MConfigcorreo Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MConfigcorreo();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }
        DAL.Interfaces.IConfigcorreo cor;
        public MConfigcorreo()
        {
            cor = new DAL.Metodos.MConfigcorreo();
        }

        public void Actualizar(Configcorreo config)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Metodos.MConfigcorreo.Instancia.Actualizar(config);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void ActualizarCorreo(Configcorreo configcorreo)
        {
            cor.ActualizarCorreo(configcorreo);
        }

        public List<Configcorreo> ListarCorreo()
        {
            return cor.ListarCorreo();
        }

    }
}
