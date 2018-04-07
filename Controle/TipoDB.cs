using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;


namespace Controle
{
    public class TipoDB
    {
        private DB db;

        public bool insert(Tipo tipo) {
            try
            {
                string sql = "INSERT INTO TB_TIPO (descricao) VALUES (" + tipo.Descricao + ")";

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
