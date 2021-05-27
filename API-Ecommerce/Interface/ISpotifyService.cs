namespace API_Ecommerce.Interface
{
    public interface ISpotifyService
    {
        string TokenDeAcesso { get; set; }
        void RealizarCargaInicial();
        string AtualizarTokenDeAcesso();
    }
}
