using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                string sql = "INSERT INTO TB_NIVEL (descricao) VALUES ('" + nivel.Descricao + "')";

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
        public List<Nivel> ListarNivel()
        {
            using (db = new DB())
            {
                var sql = "SELECT id, descricao FROM TB_Nivel";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);

            }
        }

        private List<Nivel> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listMensagem = new List<Nivel>();

            while (retorno.Read())
            {
                var item = new Nivel()
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
