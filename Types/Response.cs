namespace ProtonChat.Types
{
    enum Response
    {
        Error = -1,
        Success = 0,
        InvalidData = 1,

        LocalNotConnected = 1001,
        LocalAlreadyConnected = 1002,
        CannotConnectToSelf = 1003,
        RemoteNotConnected = 1004,
        RemoteAlreadyConnected = 1005
    }
}
