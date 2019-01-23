namespace ProtonChat.Types
{
    class RemoteConnection
    {
        public string ProtonAddress { get; set; }

        public RemoteConnection(string Address)
        {
            this.ProtonAddress = Address;
        }
    }
}
