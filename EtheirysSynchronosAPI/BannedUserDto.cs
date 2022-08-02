namespace EtheirysSynchronos.API
{
    public record BannedUserDto
    {
        public string CharacterHash { get; set; }
        public string Reason { get; set; }
    }
}
