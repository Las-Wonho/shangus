using FreeNet;
namespace CodeFight
{
    class CRemoteServerPeer : IPeer
    {
        public CUserToken token { get; private set; }
        public CRemoteServerPeer(CUserToken token)
        {
            this.token = token;
            this.token.set_peer(this);
        }

        void IPeer.on_message(Const<byte[]> buffer)
        {
            CPacket msg = new CPacket(buffer.Value, this);
            PROTOCOL protocol_id = (PROTOCOL)msg.pop_protocol_id();
            switch (protocol_id)
            {
                case PROTOCOL.CHAT_MSG_ACK:
                    {
                        get.a = msg.pop_string();
                        //Console.WriteLine(string.Format("{0}", text));
                        //MessageBox.Show(Program.get_text);
                    }
                    break;
            }
        }

        void IPeer.on_removed()
        {
            //Console.WriteLine("Server removed.");
        }

        void IPeer.send(CPacket msg)
        {
            this.token.send(msg);
        }

        void IPeer.disconnect()
        {
            this.token.socket.Disconnect(false);
        }

        void IPeer.process_user_operation(CPacket msg)
        {
        }
    }
}
