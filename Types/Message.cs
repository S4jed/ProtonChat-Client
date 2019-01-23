namespace ProtonChat.Types
{
    class Message
    {
        public Response Response { get; set; }
        public string Text { get; set; }
        public RemoteConnection Sender { get; set; }

        public Message(string Text)
        {
            this.Text = Text;
        }
    }
}
