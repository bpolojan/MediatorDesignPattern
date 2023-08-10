namespace MediatorDesignPattern.ChatApp
{
    internal class ChatProgram
    {
        public void Run()
        {
            var teamChat = new TeamChatroom();

            var steve = new Developer("Steve");
            var justin = new Developer("Justin");
            var jenna = new Developer("Jenna");      
            var kim = new Tester("Kim");
            var Julia = new Tester("Julia");

 
            teamChat.RegisterMembers(steve, justin, jenna, kim, Julia);
          
            steve.SendMessage("hye everyone, we're going to be deplying at 2pm today.");
            kim.SendMessage("Ok, thanks for letting us know");
            steve.SendTo<Developer>("Make sure to execute your Unit tests before checking in!");
        }
    }
}
