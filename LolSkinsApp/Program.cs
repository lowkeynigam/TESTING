using System;
using LolSkinsApp.models;

namespace LolSkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Skin One = new Skin("Riot Girl Tristana","24/6/2014",0,"Promotional");
            Skin Two =  new Skin("Unchained Alistar","24/6/2014",0,"Promotional");
            Legacy Three = new Legacy("FrankenTibbers Annie","10/1/2015",975,"Legacy","Harrowing",false);
            Skin Four = new Skin("Pool Party Graves","24/5/2015",1350,"Epic");
            Legacy Five = new Legacy("Heartseeker Ashe","24/5/2015",975,"Legacy","Valentines",false);
            Skin Six = new Skin("Frostblade Irelia","24/5/2015",975,"Common");
            Skin Seven = new Skin("Zombie Slayer Jinx","15/11/2015",1350,"Epic");
            Skin Eight = new Skin("Headhunter Master Yi","15/11/2015",975,"Common");
            Chroma Nine = new Chroma("Headhunter Master Yi Strike","23/11/2015",290,"Common","Golden");
            Chroma Ten = new Chroma("Headhunter Master Yi Strike","23/11/2015",290,"Common","Blue");
            Chroma Eleven = new Chroma("Headhunter Master Yi Strike","23/11/2015",290,"Common","Red");
            Chroma Twelve = new Chroma("Caitlyn Rebel","28/11/2015",290,"Common","Blue");
            Chroma Thirteen = new Chroma("Caitlyn Rebel","28/11/2015",290,"Common","Pink");
            Chroma Fourteen = new Chroma("Caitlyn Rebel","28/11/2015",290,"Common","Green");
            Skin Fifteen = new Skin("Neon Strike Vi","28/11/2015",975,"Common");
            Skin Sixteen = new Skin("Arcade Miss Fortune","23/12/2015",1350,"Epic");
            Skin Seventeen = new Skin("Jade Dragon Wukong","30/12/2015",975,"Common");
            Skin Eighteen = new Skin("Death Blossom Kha'Zix","18/3/2016",975,"Common");
            Legacy Nineteen = new Legacy("Sweeper Alistar","18/3/2016",750,"Common","2014 World Cup",true);
            Skin Twenty = new Skin("Headhunter Nidalee","18/3/2016",975,"Common");
            Legacy TwentyOne = new Legacy("Riot Kayle","15/9/2016",0,"Promotional","2014 Event",true);
            Legacy TwentyTwo = new Legacy("Sandstorm Ekko","24/1/2018",1350,"Epic","Season Six World Championship",true);
            Skin TwentyThree = new Skin("Glacial Malphite","24/1/2018",1350,"Epic");
            Skin TwentyFour = new Skin("Dragon Sorceress Zyra","2/8/2018",1350,"Epic");
            Skin TwentyFive = new Skin("Officer Vi","2/8/2018",975,"Common");
            Chroma TwentySix = new Chroma("Officer Vi","10/8/2018",290,"Common","Red");
            Chroma TwentySeven = new Chroma("Officer Vi","10/8/2018",290,"Common","Black");
            Chroma TwentyEight = new Chroma("Officer Vi","10/8/2018",290,"Common","White");
            Legacy TwentyNine = new Legacy("SKT T1 Zyra","10/8/2018",975,"Common","Season Three Championship",true);
            Legacy Thirty = new Legacy("Warring Kingdoms Vi","29/3/2020",1350,"Epic","Lunar Revel",false);
            Skin ThirtyOne = new Skin("God Staff Jax","10/4/2020",1350,"Epic");
            Skin ThirtyTwo = new Skin("Demon Vi","10/4/2020",1350,"Epic");
            Skin ThirtyThree = new Skin("Pool Party Lee Sin","10/4/2020",975,"Common");
            Skin ThirtyFour = new Skin("Crime City Graves","10/4/2020",975,"Common");
            Legacy ThirtyFive = new Legacy("Sweetheart Sona","21/4/2020",975,"Common","Valentines",false);
            Skin ThirtySix = new Skin("Star Guardian Syndra","26/4/2020",1350,"Epic");
            Skin ThirtySeven = new Skin("PROJECT: Vi","26/4/2020",1350,"Epic");
            Skin ThirtyEight = new Skin("Secret Ageng Xin Zhao","26/4/2020",975,"Common");
            Skin ThirtyNine = new Skin("Presigious Leblanc","26/4/2020",520,"Common");
            Skin Forty = new Skin("Warden Nautilus","26/4/2020",750,"Common");
            Skin FortyOne = new Skin("Blood Moon Diana","30/4/2020",1350,"Epic");
            Skin FortyTwo = new Skin("Hired Gun Lucaian","30/4/2020",975,"Common");
            Skin FortyThree = new Skin("Frosted Ezreal","30/4/2020",975,"Common");
            Skin FortyFour = new Skin("Dragonslayer Vayne","30/4/2020",975,"Common");
            Skin FortyFive = new Skin("Koi Nami","30/4/2020",975,"Common");
            Skin FortySix = new Skin("Iron Solari Leona","30/4/2020",975,"Common");
            Skin FortySeven = new Skin("Blade Mistress Morgana","30/4/2020",975,"Common");
            Skin FortyEight = new Skin("Infernal Varus","30/4/2020",1350,"Epic");
            Skin FortyNine = new Skin("Dragonslayer Trundle","30/4/2020",1350,"Epic");
            Skin Fifty = new Skin("PROJECT: Fiora","30/4/2020",1350,"Epic");
            Skin FiftyOne = new Skin("Warring Kingdoms Nidalee","30/4/2020",975,"Common");
            Chroma FiftyTwo = new Chroma("Dragon Slayer Trundle","30/4/2020",290,"Common","White");
            Chroma FiftyThree = new Chroma("Dragon Slayer Trundle","30/4/2020",290,"Common","Obsidian");
            Chroma FiftyFour = new Chroma("Dragon Slayer Trundle","30/4/2020",290,"Common","Purple");
            Chroma FiftyFive = new Chroma("Dragon Slayer Trundle","30/4/2020",290,"Common","Green");
            Chroma FiftySix = new Chroma("Dragon Slayer Trundle","30/4/2020",290,"Rare","Red");
            Chroma FiftySeven = new Chroma("Dragon Slayer Vayne","30/4/2020",290,"Common","Golden");
            Chroma FiftyEight = new Chroma("Dragon Slayer Vayne","30/4/2020",290,"Common","Crimson");
            Chroma FiftyNine = new Chroma("Dragon Slayer Vayne","30/4/2020",290,"Common","Grey");
            Chroma Sixty = new Chroma("Arcade Miss Fortune","3/5/2020",290,"Common","Yellow");
            Skin SixtyOne = new Skin("Cosmic Queen Ashe","4/5/2020",1350,"Epic");
            Chroma SixtyTwo = new Chroma("Cosmic Queen Ashe","4/5/2020",290,"Epic","Ruby");
            Chroma SixtyThree = new Chroma("Officer Vi","4/5/2020",290,"Common","Aquamarine");
            Chroma SixtyFour = new Chroma("Officer Vi","4/5/2020",290,"Common","Military");
            Skin SixtyFive = new Skin("Blood Moon Elise","5/5/2020",975,"Common");
            Chroma SixtySix = new Chroma("Pool Party Graves","7/5/2020",290,"Common","Yellow");
            Chroma SixtySeven = new Chroma("Pool Party Graves","7/5/2020",290,"Common","Purple");
            Chroma SixtyEight = new Chroma("Cosmic Queen Ashe","8/5/2020",290,"Epic","Emerald");
            Chroma SixtyNine = new Chroma("Cosmic Queen Ashe","11/5/2020",290,"Epic","Sapphire");
            Skin Seventy = new Skin("K/DA Akali","11/5/2020",1350,"Epic");
            Chroma SeventyOne = new Chroma("Arcade Miss Fortune","16/5/2020",290,"Common","Red");
            Chroma SeventyTwo = new Chroma("Infernal Varus","16/5/2021",290,"Common","Red");
            Legacy SeventyThree = new Legacy("Hearbreaker Vi","30/5/2020",1350,"Epic","Valentines",false);
            Skin SeventyFour = new Skin("Urf the Nami-Tee","19/7/2020",975,"Common");
            Legacy SeventyFive = new Legacy("SKT T1 Syndra","24/7/2020",1350,"Epic","Season Six Championships",true);
            Legacy SeventySix = new Legacy("Heartseeker Vayne","24/7/2020",975,"Common","Valentines",false);
            Skin SeventySeven = new Skin("Debonair Vi","24/7/2020",750,"Common");
            Skin SeventyEight = new Skin("Sandstorm Katarina","5/8/2020",975,"Common");
            Legacy SeventyNine = new Legacy("Goalkeeper Blitzcrank","6/8/2020",520,"Common","World Cup 2010",true);
            Skin Eighty = new Skin("Ice Drake Shyvana","7/8/2020",975,"Common");
            Skin EightyOne = new Skin("Elderwood Ahri","14/8/2020",1350,"Epic");
            Skin EightyTwo = new Skin("Super Galaxy Shyvana","24/8/2020",1350,"Epic");
            Skin EightyThree = new Skin("Boneclaw Shyvana","24/8/2020",520,"Common");
            Skin EightyFour = new Skin("Marquis Vladimir","24/8/2020",750,"Common");
            Skin EightyFive = new Skin("PsyOps Vi","4/9/2020",1350,"Epic");
            Chroma EightySix = new Chroma("PsyOps Vi","4/9/2020",290,"Rare","Ruby");
            Chroma EightySeven = new Chroma("PsyOps Vi","4/9/2020",290,"Rare","Hunter");
            Chroma EightyEight = new Chroma("PsyOps Vi","4/9/2020",290,"Common","Tanzanite");
            Chroma EightyNine = new Chroma("PsyOps Vi","4/9/2020",290,"Common","Sandstone");
            Chroma Ninety = new Chroma("PsyOps Vi","4/9/2020",290,"Common","Rose Quartz");
            Chroma NinetyOne = new Chroma("PsyOps Vi","4/9/2020",290,"Common","Turqouise");
            Chroma NinetyTwo = new Chroma("PsyOps Vi","4/9/2020",290,"Common","Granite");
            Chroma NinetyThree = new Chroma("PsyOps Vi","4/9/2020",290,"Common","Obsidian");
            Skin NinetyFour = new Skin("PsyOps Ezreal","7/9/2020",1350,"Epic");
            Skin NinetyFive = new Skin("Darkflame Shyvana","8/9/2020",975,"Common");
            Skin NinetySix = new Skin("Pulsefire Ezreal","13/9/2020",3250,"Ultimate");
            Skin NinetySeven = new Skin("Jade Fang Cassiopeia","19/9/2020",975,"Common");
            Skin NinetyEight = new Skin("Battlecast Alpha Skarner","22/9/2020",1820,"Legendary");
            Legacy NinetyNine = new Legacy("Sweetheart Annie","25/9/2020",750,"Common","Valentines",false);
            Legacy Hundred = new Legacy("Championship Leblanc","30/9/2020",1350,"Epic","Season 10 Championships",true);
            Skin HundredOne = new Skin("Cosmic Dusk Xayah","30/9/2020",1350,"Epic");
            Skin HundredTwo = new Skin("Arclight Vel'Koz","1/10/2020",1350,"Epic");
            Skin HundredThree = new Skin("Obsidian Dragon Sett","3/10/2020",1350,"Epic");
            Legacy HundredFour = new Legacy("Championship Shyvana","3/10/2020",975,"Common","End of Season", false);
            Skin HundredFive = new Skin("Dark Star Xerath","3/10/2020",1350,"Epic");
            Skin HundredSix = new Skin("Aviator Irelia", "3/10/2020",520,"Common");
            Skin HundredSeven = new Skin("PROJECT: Yasuo","4/10/2020",1350,"Epic");
            Skin HundredEight = new Skin("Crime City Jinx","5/10/2020",975,"Common");
            Skin HundredNine = new Skin("Cosmic Reaver Kassadin","9/12/2020",1350,"Epic");
            Legacy HundredTen = new Legacy("Championship Khazix","25/1/2021",1350,"Epic","End of Season",false);
            Skin HundredEleven = new Skin("Star Guardian Jinx","4/3/2021",1820,"Legendary");
            Skin HundredTwelve = new Skin("Guardian of the sands Skarner","20/4/2021",975,"Common");
            Skin HundredThirteen = new Skin("PROJECT: Ashe","16/5/2021",1820,"Legendary");
            Skin HundredFourteen = new Skin("Pizza Delivery Sivir","23/5/2021",1350,"Epic");
            Skin HundredFifteen = new Skin("Fae Dragon Ashe","23/5/2021",1350,"Epic");
            Chroma HundredSixteen = new Chroma("Fae Dragon Ashe","23/5/2021",290,"Common","Obsidian");
            Chroma HundredSeventeen = new Chroma("Fae Dragon Ashe","23/5/2021",290,"Common","Purple");
            Chroma HundredEighteen = new Chroma("Fae Dragon Ashe","23/5/2021",290,"Common","Pink");
            Legacy HundredNineteen = new Legacy("Ambitious Elf Jinx","26/5/2021",1350,"Epic","Christmas",false);
            Skin HundredTwenty = new Skin("Marauder Xin Zhao","27/5/2021",1350,"Epic");
            Skin HundredTwentyOne = new Skin("Cosmic Defender Xin Zhao","27/5/2021",1350,"Epic");
            Skin HundredTwentyTwo = new Skin("Dragonslayer Xin Zhao","27/5/2021",1350,"Epic");
            Skin HundredTwentyThree = new Skin("Warring Kingdoms Xin Zhao","27/5/2021",1350,"Epic");
            Skin HundredTwentyFour = new Skin("PROJECT: Sylas","28/5/2021",1350, "Epic");
            Legacy HundredTwentyFive = new Legacy("Fnatic Janna", "28/5/2021",750,"Common","Season One Championships",true);
            Skin HundredTwentySix = new Skin("Battle Professor Graves","28/5/2021",1350,"Epic");
            Skin HundredTwentySeven = new Skin("Crime City Miss Fortune","30/5/2021",975,"Common");
            Skin HundredTwentyEight = new Skin("PROJECT: Varus","31/5/2021",1350,"Epic");
            Skin HundredTwentyNine = new Skin("Officer Caitlyn","1/6/2021",975,"Common");
            Skin HundredThirty = new Skin("Coven Zyra","1/6/2021",1350,"Epic");
            Skin HundredThirtyOne = new Skin("Pentakill Kayle","4/6/2021",1350,"Epic");
            Legacy HundredThirtyTwo = new Legacy("Temptest Janna","8/6/2021",520,"Common","None",true);
            Legacy HudnredThirtyThree = new Legacy("Union Jack Fiddlesticks","8/6/2021",520,"Common","World Cup 2010",true);
            Legacy HudnredThirtyFour = new Legacy("Snow Day Syndra", "8/6/2021",1350,"Epic","Christmas",false);
            Skin HundredThirtyFive = new Skin("Infernal Nasus","8/6/2021",1820,"Legendary");
            Skin HundredThirtySix = new Skin("Academy Vladimir","8/6/2021",975,"Common");
            Skin HundredThirtySeven = new Skin("Pengu Cosplay Tristana","8/6/2021",1350,"Epic");
            Skin HundredThirtyEight = new Skin("Pool Party Syndra","8/6/2021",1350,"Epic");
            Skin HundredThirtyNine = new Skin("Battle Academia Leona","8/6/2021",1350,"Epic");
            Skin HundredForty = new Skin("Coven Zyra Prestige Edition","8/6/2021",15250,"Mythic");
            Skin HundredFortyOne = new Skin("Nightmare Tryndamere","9/6/2021",750,"Common");










            


            
            










        }
    }
}
