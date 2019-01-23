namespace ProtonChat.Types
{
    class ConnectionRequest
    {
        public Response Response { get; set; }
        public RemoteConnection Remote { get; set; }
        public bool Connected { get; set; }
    }
}
