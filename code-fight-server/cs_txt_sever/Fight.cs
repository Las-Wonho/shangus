using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_txt_sever
{
    class Fight
    {
        public LinkedList<Team> team = new LinkedList<Team>();
        public void Add_Fight(Team team1)
        {
            this.team.AddLast(team1);
        }
        public void Find(Matcher find_matcher)
        {
            foreach(Team tmp in this.team)
            {
                if (tmp.is_this(find_matcher) != null)
                {
                    team.Remove(team.Find(tmp).Value);
                    return;
                }
            }
            return;
        }
    }
    class Team
    {
        public Matcher matcher_1;
        public Matcher matcher_2;
        public Team(Matcher matcher_1, Matcher matcher_2)
        {
            this.matcher_1 = matcher_1;
            this.matcher_2 = matcher_2;
        }
        public Team is_this(Matcher matcher)
        {
            if(matcher.Equals(this.matcher_1));
            {
                send_message("win","loss");
            }
            if (matcher.Equals(this.matcher_2)) ;
            {
                send_message("loss", "win");
            }
            return null;
        }
        public void send_message(String str, String str2)
        {
            matcher_1.send(str);
            matcher_2.send(str2);
        }
    }
}
