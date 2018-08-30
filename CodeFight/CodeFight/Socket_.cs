using FreeNet;
using System.Collections.Generic;
using System.Net;

namespace CodeFight
{
    class Socket_
    {
        static List<IPeer> game_servers = new List<IPeer>();

        static public void Load()
        {
            CPacketBufferManager.initialize(2000);
            // CNetworkService객체는 메시지의 비동기 송,수신 처리를 수행한다.
            // 메시지 송,수신은 서버, 클라이언트 모두 동일한 로직으로 처리될 수 있으므로
            // CNetworkService객체를 생성하여 Connector객체에 넘겨준다.
            CNetworkService service = new CNetworkService();

            // endpoint정보를 갖고있는 Connector생성. 만들어둔 NetworkService객체를 넣어준다.
            CConnector connector = new CConnector(service);
            // 접속 성공시 호출될 콜백 매소드 지정.
            connector.connected_callback += on_connected_gameserver;
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("45.77.14.49"), 10518);
            connector.connect(endpoint);
            //System.Threading.Thread.Sleep(10);
            //System.Threading.Thread.Sleep(1000 * 20);
        }

        static public void post(string line)
        {
            //Console.Write("> ");
            //string line = Console.ReadLine();

            CPacket msg = CPacket.create((short)PROTOCOL.CHAT_MSG_REQ);
            msg.push(line);
            game_servers[0].send(msg);

            //((CRemoteServerPeer)game_servers[0]).token.disconnect();
        }

        /// <summary>
        /// 접속 성공시 호출될 콜백 매소드.
        /// </summary>
        /// <param name="server_token"></param>
        static void on_connected_gameserver(CUserToken server_token)
        {
            lock (game_servers)
            {
                IPeer server = new CRemoteServerPeer(server_token);
                game_servers.Add(server);
                //Console.WriteLine("Connected!");
            }
        }
    }
}
