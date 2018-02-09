using System;
using FreeNet;

namespace cs_txt_sever
{
    class CGameUser : IPeer
    {

        CUserToken token;
        Program pr = new Program();
        CNetworkService service = new CNetworkService();
        public CGameUser(CUserToken token)
        {
            this.token = token;
            this.token.set_peer(this);
        }
        
        void IPeer.on_message(Const<byte[]> buffer)
        {
            try
            {
                // ex)
                CPacket msg = new CPacket(buffer.Value, this);
                CPacket msag = new CPacket(buffer.Value, this);
                PROTOCOL protocol = (PROTOCOL)msg.pop_protocol_id();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("protocol id " + protocol);

                
                switch (protocol)
                {
                    case PROTOCOL.CHAT_MSG_REQ:
                        {
                            string text = msg.pop_string();
                            string text_post = "1";
                            Console.WriteLine(string.Format("get text  - {0}", text));
                            service.save_log("\r\n------------------------------------------------------\r\nprotocol id " + protocol + " " + string.Format("text - {0}", text));
                            CPacket response = CPacket.create((short)PROTOCOL.CHAT_MSG_ACK);
                            try
                            {
                                string[] text_ = text.Split(' ');
                                if (text_[0] == "match")
                                {
                                    Program.MAT.Add(new Matcher(this, text_[1]));
                                    if (Program.MAT.Count >= 2)
                                    {
                                        Matcher mat = Program.MAT[0];
                                        Matcher mat_ = Program.MAT[1];
                                        string tmp__ = Convert.ToString(Well512.Next(1001, 1005));
                                        mat.send(mat_.user_name + " " + tmp__);
                                        mat_.send(mat.user_name + " " + tmp__);

                                        Program.fight.Add_Fight(new Team(mat,mat_));

                                        Program.MAT.RemoveAt(0);
                                        Program.MAT.RemoveAt(1);
                                    }
                                    else
                                    {
                                        //int a = 10;
                                        //String str = $"asd{a}as";

                                        Program.fight.Find(new Matcher(this, text_[1]));

                                    }
                                }
                            }
                            catch
                            {
                            }
                            finally
                            {
                            }
                        }
                        break;
                }
            }
            catch { }
        }

        void IPeer.on_removed()
        {
            Console.WriteLine("The client disconnected.");

            Program.remove_user(this);
        }

        public void send(CPacket msg)
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
