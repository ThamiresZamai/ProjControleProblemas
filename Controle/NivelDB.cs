using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace Controle
{
    public class NivelDB
    {
        private DB db;

        public bool insert(Nivel nivel)
        {
            try
            {
                string sql = "INSERT INTO TB_NIVEL (descricao) VALUES (" + nivel.Descricao + ")";

                using (db = new DB())
                {
                    db.ExecutarComando(sql);
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
