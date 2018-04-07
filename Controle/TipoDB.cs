using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                string sql = "INSERT INTO TB_TIPO (descricao) VALUES ('" + tipo.Descricao + "')";

                using (db = new DB())
                {
                    db.ExecutarComando(sql);
                }               
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public List<Tipo> ListarTipo()
        {
            using (db = new DB())
            {
                var sql = "SELECT id, descricao FROM TB_Tipo";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);

            }
        }

        private List<Tipo> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listMensagem = new List<Tipo>();

            while (retorno.Read())
            {
                var item = new Tipo()
                {
                    Id = Convert.ToInt32(retorno["id"].ToString()),
                    Descricao = retorno["descricao"].ToString()
                };
                listMensagem.Add(item);
            }
            return listMensagem;
        }
    }
}
