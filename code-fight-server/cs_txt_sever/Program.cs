using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using FreeNet;

namespace cs_txt_sever
{
    class Program
    {
        static List<CGameUser> userlist;
        public static List<Matcher> MAT;
        public static Well512 well = new Well512();
        public static Fight fight = new Fight();
        static void Main(string[] args)
        {
            
            CPacketBufferManager.initialize(2000);
            userlist = new List<CGameUser>();

            CNetworkService service = new CNetworkService();
            // 콜백 매소드 설정.
            service.session_created_callback += on_session_created;
            // 초기화.
            service.initialize();
            service.listen("0.0.0.0", 10518, 100);


            Console.WriteLine("Started!");
            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        static void on_session_created(CUserToken token)
        {
            CGameUser user = new CGameUser(token);
            lock (userlist)
            {
                userlist.Add(user);
            }
        }

        public static void remove_user(CGameUser user)
        {
            lock (userlist)
            {
                userlist.Remove(user);
            }
        }

        public static int Hash(string string_)
        {
            int hash = -1;
            int len = string_.Length;

            unchecked
            {
                uint poly = 0xEDB8832F;
                for (int i = 0; i < len; i++)
                {
                    poly = (poly << 1) | (poly >> (32 - 1)); // 1bit Left Shift
                    hash = (int)(poly * hash + string_[i]);
                }
            }

            return hash;
        }
    }
}
