namespace LolSkinsApp.models
{
    public class Legacy : Skin
    {
        public Legacy(string name, string dateacquired, int price, string rarity, string eventname, bool retired) : base(dateacquired,name,price,rarity)
        {
            this.eventname = eventname;
            this.retired = retired;
        }

        public string eventname {get;set;}
        public bool retired {get;set;}

        
    }
}