namespace LolSkinsApp.models
{
    public class Chroma : Skin
    {
        public string color {get;set;}

        public Chroma(string name, string dateacquired, int price, string rarity, string color) : base(dateacquired,name,price,rarity)
        {
            this.color = color;
        }
    }
}