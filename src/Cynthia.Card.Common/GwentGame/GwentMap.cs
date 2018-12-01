using System;
using System.Collections.Generic;
using System.Linq;

namespace Cynthia.Card
{
    public static class GwentMap
    {
        public static IEnumerable<CardStatus> GetCards(bool isHasDerive = false)
        {
            return CardMap
            .Where(x=>!x.Value.IsDerive)
            .OrderByDescending(x=>x.Value.Group)
            .ThenBy(x=>x.Value.Faction)
            .ThenBy(x=>x.Value.Strength)
            .Select(x=>new CardStatus(x.Key));
        }
        public static IDictionary<string, GwentCard> CardMap { get; } = new Dictionary<string, GwentCard>
        {
            //卡牌展示
            //=========================================================================================================================================================================
            //中立
            //=========================================================================================================================================================================
            //中立金
            {
                "12001",//皇家谕令
                new GwentCard()
                {
                    CardId = "12001",//Id
                    EffectType=typeof(RoyalDecree),//效果Id
                    Name="皇家谕令",
                    Strength=0,
                    Group=Group.Gold,
                    Faction = Faction.Neutral,
                    CardUseInfo = CardUseInfo.MyPlace,
                    CardType = CardType.Special,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "吾，弗尔泰斯特，以泰莫利亚圣君、索登亲王、布鲁格守护者及其他各种合法称号之名义，作出如下判决……。",
                    Info = "从牌组打出1张金色单位牌，使其获得2点增益。",
                    CardArtsId = "20015400",//卡图Id
                }
            },
            {
                "12002",//杰洛特：伊格尼法印
                new GwentCard()
                {
                    CardId = "12002",
                    EffectType=typeof(GeraltIgni),//效果Id
                    Name="杰洛特：伊格尼法印",
                    Strength=5,
                    Group=Group.Gold,
                    Faction = Faction.Neutral,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "猎魔人晃晃手指就能点灯，或把敌人烧成灰。",
                    Info = "若对方某排总战力不低于25点，则摧毁其上所有最强的单位。",
                    CardArtsId = "11210200",

                }
            },
            {
                "12003",//丹德里恩：传奇诗人
                new GwentCard()
                {
                    CardId = "12003",
                    EffectType=typeof(DandelionPoet),//效果Id
                    Name="丹德里恩：传奇诗人",
                    Strength=5,
                    Group=Group.Gold,
                    Faction = Faction.Neutral,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "文胜于武，笔胜于剑。",
                    Info = "抽一张牌，随后打出1张牌。",
                    CardArtsId = "20177600",

                }
            },
            //========================================================================================================================
            //中立银
            {
                "13001",//萝卜
                new GwentCard()
                {
                    CardId = "13001",
                    EffectType=typeof(Roach),//效果Id
                    Name="萝卜",
                    Strength=4,
                    Group=Group.Silver,
                    Faction = Faction.Neutral,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "杰洛特，我们得来场人马间的对话。恕我直言，你的骑术……真的有待提高，伙计。",
                    Info = "己方每次从手牌打出金色单位牌时，召唤此单位至随机排。",
                    CardArtsId = "11221000",

                }
            },
            {
                "13002",//乞丐王
                new GwentCard()
                {
                    CardId = "13002",
                    EffectType=typeof(KingofBeggars),//效果Id
                    Name="乞丐王",
                    Strength=5,
                    Group=Group.Silver,
                    Faction = Faction.Neutral,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "要是我缺鼻子或者断手了，那显然，乞丐王接受这两种付款方式。",
                    Info = "若打出后总战力低于对方，则获得强化，直至战力持平或最多15点。",
                    CardArtsId = "11221300",

                }
            },
            //========================================================================================================================
            //中立铜
            {
                "14001",//侦查
                new GwentCard()
                {
                    CardId = "14001",
                    EffectType=typeof(Reconnaissance),//效果Id
                    Name="侦查",
                    Strength=0,
                    Group=Group.Copper,
                    Faction = Faction.Neutral,
                    CardUseInfo = CardUseInfo.MyPlace,
                    CardType = CardType.Special,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "如果斥候没有回来，我们就掉头。乡下的人说这些树林里全是松鼠。我指的可不是啃松果的那种。",
                    Info = "检视牌组中2张铜色单位牌，随后打出1张。",
                    CardArtsId = "11340200",

                }
            },
            //=========================================================================================================================================================================
            //帝国
            //=========================================================================================================================================================================
            //帝国领袖
            {
                "31001",//约翰·卡尔维特
                new GwentCard()
                {
                    CardId ="31001",
                    EffectType=typeof(JanCalveit),//效果Id
                    Name="约翰·卡尔维特",
                    Strength=5,
                    Group=Group.Leader,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "剑只是统治者的工具之一。",
                    Info = "检视牌组顶端3张卡牌，打出一张。",
                    CardArtsId = "16110300",

                }
            },
            //========================================================================================================================
            //帝国金卡
            {
                "32001",//亚特里的林法恩
                new GwentCard()
                {
                    CardId ="32001",
                    EffectType=typeof(RainfarnOfAttre),//效果Id
                    Name="亚特里的林法恩",
                    Strength=5,
                    Group=Group.Gold,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "辛特拉沦陷后，亚特里随即告破，这里的守军若不听任尼弗迦德人驱策，就只能去死。",
                    Info = "从牌组打出一张铜色/银色间谍单位牌",
                    CardArtsId = "20003200",

                }
            },
            {
                "32006",//威戈佛特兹
                new GwentCard()
                {
                    CardId ="32006",
                    EffectType=typeof(Vilgefortz),//效果Id
                    Name="威戈佛特兹",
                    Strength=9,
                    Group=Group.Gold,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "我们都是他棋盘上的棋子，而这棋局的规则，我们一无所知。",
                    Info = "摧毁1个友军单位，随后从牌组顶端打出1张牌；\n或\n休战：摧毁1个敌军单位，随后对方抽1张铜色牌并揭示它。",
                    CardArtsId = "16210500",
                }
            },
            {
                "32008",//门诺·库霍恩
                new GwentCard()
                {
                    CardId ="32008",
                    EffectType=typeof(MennoCoehoorn),//效果Id
                    Name="门诺·库霍恩",
                    Strength=8,
                    Group=Group.Gold,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "细心的侦察分队比训练有素的军团更管用。",
                    Info = "对1个敌军单位造成4点伤害。若它为间谍单位，则直接将其摧毁。",
                    CardArtsId = "16210200",
                }
            },
            //========================================================================================================================
            //帝国银卡
            {
                "33001",//约阿希姆·德·维特
                new GwentCard()
                {
                    CardId ="33001",
                    EffectType=typeof(JoachimDeWett),//效果Id
                    Name="约阿希姆·德·维特",
                    Strength=5,
                    Group=Group.Silver,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.EnemyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "即便用 “无能” 来形容德·维特公爵对维登集团军的领袖，都算给他面子。",
                    Info = "间谍。\n从牌组顶端打出1张铜色/银色非间谍单位牌，并使它获得10点增益。",
                    CardArtsId = "16221100",

                }
            },
            {
                "33002",//冒牌希里
                new GwentCard()
                {
                    CardId ="33002",
                    EffectType=typeof(FalseCiri),//效果Id
                    Name="冒牌希里",
                    Strength=8,
                    Group=Group.Silver,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.EnemyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "“她来了，” 他心想 “皇帝的联姻对象。冒牌公主、冒牌的辛特拉女王、冒牌的雅鲁加河口统治者，也是帝国未来的命脉。”",
                    Info = "间谍。\n回合开始时，若为间谍，则获得1点增益。所在半场的玩家放弃跟牌后，移至对方半场同排。\n遗愿：摧毁同排最弱的单位",
                    CardArtsId = "16221200",

                }
            },
            {
                "33003",//魔像守卫
                new GwentCard()
                {
                    CardId ="33003",
                    EffectType=typeof(TheGuardian),//效果Id
                    Name="魔像守卫",
                    Strength=11,
                    Group=Group.Silver,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "石拳阻挡刀剑，逻辑战胜谎言。",
                    Info = "将一个 “次级魔像守卫” 置于对方牌组顶端。",
                    CardArtsId = "16240100",

                }
            },
            {
                "33004",//坎塔蕾拉
                new GwentCard()
                {
                    CardId ="33004",
                    EffectType=typeof(Cantarella),//效果Id
                    Name="坎塔蕾拉",
                    Strength=13,
                    Group=Group.Silver,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.EnemyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "男人渴望着诱惑，神秘加优雅往往事半功倍。",
                    Info = "力竭：抽两张牌。保留一张，将另一张置于牌组底端。",
                    CardArtsId = "16221000",

                }
            },
            {
                "33005",//艾希蕾·阿纳兴
                new GwentCard()
                {
                    CardId ="33005",
                    EffectType=typeof(Assire),//效果Id
                    Name="艾希蕾·阿纳兴",
                    Strength=11,
                    Group=Group.Silver,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "尼弗迦德法师也有选择：要么服从，要么上断头台。",
                    Info = "将双方墓场中最多2张铜色/银色牌放回各自牌组。",
                    CardArtsId = "16220200",
                }
            },
            //========================================================================================================================
            //帝国铜卡
            {
                "34001",//维可瓦罗医师
                new GwentCard()
                {
                    CardId ="34001",
                    EffectType=typeof(VicovaroNovice),//效果Id
                    Name="维可瓦罗医师",
                    Strength=1,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = true,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "这个世界的瘟疫跟战争一样多，夺人性命也一样出其不意。",
                    Info = "从对方墓地复活1个铜色单位。",
                    CardArtsId = "16230400",

                }
            },
            {
                "34002",//特使
                new GwentCard()
                {
                    CardId ="34002",
                    EffectType=typeof(Emissary),//效果Id
                    Name="特使",
                    Strength=2,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.EnemyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "但是……这样不对啊！两国交兵不斩来使！。",
                    Info = "间谍。\n随机检视牌组中2张铜色单位牌，打出一张。",
                    CardArtsId = "16231400",

                }
            },
            {
                "34003",//近卫军
                new GwentCard()
                {
                    CardId ="34003",
                    EffectType=typeof(ImperaBrigade),//效果Id
                    Name="近卫军",
                    Strength=6,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "近卫军决不投降，绝不。",
                    Info = "场上每有1个敌军间谍单位，便获得2点增益。每有1个间谍单位出现在对方半场，便获得2点增益。",
                    CardArtsId = "16230700",

                }
            },
            {
                "34004",//尼弗迦德骑士
                new GwentCard()
                {
                    CardId ="34004",
                    EffectType=typeof(NilfgaardianKnight),//效果Id
                    Name="尼弗迦德骑士",
                    Strength=12,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "出自名门望族，生于金塔之城，组成帝国的精锐部队。",
                    Info = "随机揭示1张己方手牌（优先级为铜银金）。\n2点护甲。",
                    CardArtsId = "16231800",
                }
            },
            {
                "34005",//近卫军铁卫
                new GwentCard()
                {
                    CardId ="34005",
                    EffectType=typeof(ImperaEnforcers),//效果Id
                    Name="近卫军铁卫",
                    Strength=6,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "皇帝最忠诚的贴身护卫，誓死保卫皇帝的安全。",
                    Info = "对1名敌军单位造成2点伤害。\n己方回合内每出现1个敌军间谍单位，便在回合结束时对1个敌军单位造成2点单位。",
                    CardArtsId = "16230800",
                }
            },
            {
                "34008",//渗透者
                new GwentCard()
                {
                    CardId ="34008",
                    EffectType=typeof(Infiltrator),//效果Id
                    Name="渗透着",
                    Strength=10,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "你可以一直逃，但你永远藏不了。",
                    Info = "改变1个单位的间谍状态。",
                    CardArtsId = "20011800",
                }
            },
            {
                "34020",//那乌西卡旅
                new GwentCard()
                {
                    CardId ="34020",
                    EffectType=typeof(NauzicaaBrigade),//效果Id
                    Name="那乌西卡旅",
                    Strength=5,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = false,
                    IsCountdown = false,
                    IsDerive = false,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "我们被称作死神头。想知道为什么吗？",
                    Info = "对1个间谍单位造成7点伤害。若摧毁目标，则获得4点强化。",
                    CardArtsId = "16231000",
                }
            },
            //========================================================================================================================
            //帝国衍生物
            {
                "35001",//次级魔像
                new GwentCard()
                {
                    CardId ="35001",
                    EffectType=typeof(NoneEffect),//效果Id
                    Name="次级魔像守卫",
                    Strength=6,
                    Group=Group.Copper,
                    Faction = Faction.Nilfgaard,
                    CardUseInfo = CardUseInfo.MyRow,
                    CardType = CardType.Unit,
                    IsDoomed = true,
                    IsCountdown = false,
                    IsDerive = true,
                    Categories = new Categorie[]{},//需要添加
                    Flavor = "按理说死去的守卫者不该再坚守岗位，但魔法可往往不会遵循常理……",
                    Info = "没有特殊技能。",
                    CardArtsId = "16240100",
                }
            },
            //=========================================================================================================================================================================
            //=========================================================================================================================================================================
        };
        /*public static IDictionary<string, Type> CardEffectMap { get; } = new Dictionary<string, Type>
        {
            //无效果
            {"None",typeof(NoneEffect)},//白板
            //=========================================================================================================
            //中立
            //---------------------------------------------------------
            //中立金
            {"12001",typeof(RoyalDecree)},//皇家谕令
            {"12002",typeof(GeraltIgni)},//杰洛特：伊格尼法印
            {"12003",typeof(DandelionPoet)},//丹德里恩：传奇诗人
            //---------------------------------------------------------
            //中立银
            {"13001",typeof(Roach)},//萝卜
            {"13002",typeof(KingofBeggars)},//乞丐王
            //---------------------------------------------------------
            //中立铜
            {"14001",typeof(Reconnaissance)},//侦查
            //=========================================================================================================
            //帝国
            //---------------------------------------------------------
            //帝国领袖
            {"31001",typeof(JanCalveit)},//约翰·卡尔维特
            //---------------------------------------------------------
            //帝国金
            {"32001",typeof(RainfarnOfAttre)},//亚特里的林法恩
            {"32006",typeof(Vilgefortz)},//威戈佛特兹*
            {"32008",typeof(MennoCoehoorn)},//门诺·库霍恩*
            //---------------------------------------------------------
            //帝国银
            {"33001",typeof(JoachimDeWett)},//约阿希姆·德·维特
            {"33002",typeof(FalseCiri)},//冒牌希里
            {"33003",typeof(TheGuardian)},//魔像守卫
            {"33004",typeof(Cantarella)},//坎塔蕾拉
            {"33005",typeof(Assire)},//艾希蕾·阿纳兴*
            //---------------------------------------------------------
            //帝国铜
            {"34001",typeof(VicovaroNovice)},//维可瓦罗医师
            {"34002",typeof(Emissary)},//特使
            {"34003",typeof(ImperaBrigade)},//近卫军
            {"34004",typeof(NilfgaardianKnight)},//尼弗迦德骑士
            {"34005",typeof(ImperaEnforcers)},//近卫军铁卫
            {"34008",typeof(Infiltrator)},//渗透者*
            {"34020",typeof(NauzicaaBrigade)},//那乌西卡旅*
            //==========================================================================================================
        };*/
        public static IEnumerable<GwentCard> DeckChange(IEnumerable<string> deck)
        {
            var step1 = deck.Select(x => CardMap[x]);
            return step1.Select(x => new GwentCard()
            {
                Categories = x.Categories,
                Faction = x.Faction,
                Flavor = x.Flavor,
                Group = x.Group,
                Info = x.Info,
                Name = x.Name,
                Strength = x.Strength,
                //-------
                CardId = x.CardId,
                IsCountdown = x.IsCountdown,
                Countdown = x.Countdown,
                IsDoomed = x.IsDoomed,
                CardArtsId = x.CardArtsId,
                CardType = x.CardType,
                CardUseInfo = x.CardUseInfo,
            });
        }
        public static IDictionary<Group, string> FlavorMap { get; } = new Dictionary<Group, string>
        {
            { Group.Leader, "领袖" },
            { Group.Gold,"金" },
            { Group.Silver,"银" },
            { Group.Copper,"铜" }
        };
    }
}