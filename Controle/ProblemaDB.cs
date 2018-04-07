using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace Controle
{
    public class ProblemaDB
    {
        private DB db;

        public bool insert(Problema problema)
        {
            try
            {
                string sql = "INSERT INTO TB_PROBLEMA (dttCriacao,descricao,fk_tipo,fk_nivel) VALUES ('" + problema.DataCriacao + "','" + problema.Descricao + "'," + problema.Tipo.Id + "," + problema.NivelDificuldade.Id + ")";

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
