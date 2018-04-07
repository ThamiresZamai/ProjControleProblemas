namespace Entidade
{
    public class Tipo
    {

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }

        #endregion

        public override string ToString()
        {

            return "\nDescrição: " + this.Descricao;
        }
    }

    
}