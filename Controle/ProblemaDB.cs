using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<Problema> ListarProblema()
        {
            using (db = new DB())
            {
                var sql = "SELECT TB_Problema.dttcriacao,TB_Problema.descricao,TB_Tipo.descricao as descricao_tipo, TB_Nivel.descricao as descricao_nivel" 
                           +" FROM TB_Problema"
                           +" inner join TB_Nivel on TB_Nivel.id = TB_Problema.fk_nivel"
                           +" inner join TB_Tipo on TB_Tipo.id = TB_Problema.fk_tipo"
                           +" order by TB_Problema.descricao";

                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);

            }
        }

        private List<Problema> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listMensagem = new List<Problema>();

            while (retorno.Read())
            {
                var item = new Problema()
                {
                    Descricao = retorno["descricao"].ToString(),
                    DataCriacao = Convert.ToDateTime(retorno["dttcriacao"].ToString()),
                    NivelDificuldade = new Nivel() {  Descricao = retorno["descricao_nivel"].ToString()},
                    Tipo = new Tipo() {   Descricao = retorno["descricao_tipo"].ToString()} 
                };
                listMensagem.Add(item);
            }
            return listMensagem;
        }
    }
}
