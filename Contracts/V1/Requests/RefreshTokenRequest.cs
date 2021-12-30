namespace NickWebApi.Contracts.V1.Requests
{
    public class RefreshTokenRequest
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public string RefreshToken { get; set; }
    }
}
