namespace LolSkinsApp.models
{
    public class Skin
    {
    public Skin(string name, string dateacquired, int price, string rarity)
        {
            this.dateacquired = dateacquired;
            this.name = name;
            this.price = price;
            this.rarity = rarity;
        }

    public string dateacquired {get;set;}
    public string name {get;set;}

    public int price {get;set;}
    public string rarity {get;set;}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}