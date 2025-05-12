namespace ProjetoCorreiosAPI.VO
{
    public class AuthVO
    {
        public string? ambiente { get; set; }
        public string? id { get; set; }
        public string? ip { get; set; }
        public string? perfil { get; set; }
        public string? cpf { get; set; }
        public string? categoria { get; set; }
        public DateTime emissao { get; set; }
        public DateTime expiraEm { get; set; }
        public string token{ get; set; }
    }
}
