namespace ProjetoCorreiosAPI.VO
{
    public class ReturnVO
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Retorno { get; set; }
        public ReturnVO()
        {

        }

        public ReturnVO(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

    }
    public class ReturnVO<T>
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Retorno { get; set; }
        public ReturnVO(bool sucesso, string mensagem, T retorno)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Retorno = retorno;
        }
        public ReturnVO(string mensagem, T retorno)
        {
            Sucesso = true;
            Mensagem = mensagem;
            Retorno = retorno;
        }
        public ReturnVO(T retorno)
        {
            Sucesso = true;
            Retorno = retorno;
        }
        public ReturnVO(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }
        public ReturnVO(string mensagem)
        {
            Sucesso = true;
            Mensagem = mensagem;
        }

    }
}
