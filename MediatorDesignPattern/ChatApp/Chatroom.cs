using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.ChatApp
{
    internal abstract class Chatroom
    {
        public abstract void Register(TeamMember member);

        public abstract void Send(string from, string message);

        public abstract void SendTo<T>(string from, string message) where T:TeamMember;

    }

    internal class TeamChatroom : Chatroom
    {
        private List<TeamMember> members= new List<TeamMember>();
        public override void Register(TeamMember member)
        {
            member.SetChatroom(this);  
            members.Add(member);
        }

        public override void Send(string from, string message)
        {
            this.members.ForEach(m=>m.Receive(from, message));
        }
        public void RegisterMembers(params TeamMember[] teamMemebers)
        {
            foreach(var teamMember in teamMemebers)
            {
                this.Register(teamMember);
            }
        }

        public override void SendTo<T>(string from, string message)
        {
            this.members.Where(m=>m.GetType() == typeof(T)).ToList().ForEach(m=>m.Receive(from, message));
        }
    }
}
