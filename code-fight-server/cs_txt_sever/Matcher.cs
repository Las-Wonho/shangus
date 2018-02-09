using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreeNet;

namespace cs_txt_sever
{
    class Matcher
    {
        public String user_name;
        CGameUser ob;
        public Matcher(CGameUser user, String username)
        {
            this.user_name = username;
            this.ob = user;
        }

        public void send(String text)
        {
            CPacket packet = CPacket.create((short)PROTOCOL.CHAT_MSG_ACK);
            packet.push(text);
            ob.send(packet);
        }
    }
}
