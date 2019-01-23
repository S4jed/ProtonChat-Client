namespace ProtonChat.Types
{
    class UpdateFrame
    {
        public Response Response { get; set; }
        public byte[] Frame { get; set; }

        public UpdateFrame(byte[] Frame)
        {
            this.Frame = Frame;
        }
    }
}
