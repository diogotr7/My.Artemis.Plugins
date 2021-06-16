﻿using Artemis.Plugins.Modules.LeagueOfLegends.DataModels.Enums;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Artemis.Plugins.Modules.LeagueOfLegends
{
    internal static class DefaultChampionColors
    {
        /// <summary>
        /// Ensures the custom dictionary has colors values for all the champions.
        /// If it's missing any, it will get set to the default color
        /// </summary>
        internal static void EnsureAllChampionsPresent(IDictionary<Champion, SKColor> colors)
        {
            foreach (var champion in Enum.GetValues<Champion>())
            {
                if (!colors.ContainsKey(champion))
                {
                    colors.Add(champion, GetDefaultChampionColor(champion));
                }
            }
        }

        internal static Dictionary<Champion, SKColor> GetNewDictionary()
            => Enum.GetValues<Champion>().ToDictionary(a => a, b => GetDefaultChampionColor(b));

        /// <summary>
        /// Gets all the default champion colors. This ensures no enum value is forgotten.
        /// </summary>
        internal static Dictionary<Champion, SKColor> Colors { get; } =
            Enum.GetValues<Champion>()
            .ToDictionary(a => a, b => GetDefaultChampionColor(b));

        internal static SKColor GetDefaultChampionColor(Champion champ) => champ switch
        {
            Champion.Unknown => new SKColor(120, 120, 120),
            Champion.None => new SKColor(120, 120, 120),
            Champion.Aatrox => new SKColor(237, 83, 79),
            Champion.Ahri => new SKColor(61, 76, 178),
            Champion.Akali => new SKColor(10, 115, 38),
            Champion.Alistar => new SKColor(64, 6, 97),
            Champion.Amumu => new SKColor(87, 138, 74),
            Champion.Anivia => new SKColor(8, 128, 200),
            Champion.Annie => new SKColor(158, 37, 16),
            Champion.Aphelios => new SKColor(52, 44, 124),
            Champion.Ashe => new SKColor(44, 53, 180),
            Champion.AurelionSol => new SKColor(84, 25, 176),
            Champion.Azir => new SKColor(234, 157, 58),
            Champion.Bard => new SKColor(216, 136, 32),
            Champion.Blitzcrank => new SKColor(194, 114, 44),
            Champion.Brand => new SKColor(196, 76, 36),
            Champion.Braum => new SKColor(42, 180, 208),
            Champion.Caitlyn => new SKColor(74, 143, 164),
            Champion.Camille => new SKColor(117, 113, 113),
            Champion.Cassiopeia => new SKColor(110, 219, 0),
            Champion.Chogath => new SKColor(173, 47, 99),
            Champion.Corki => new SKColor(222, 150, 72),
            Champion.Darius => new SKColor(177, 4, 14),
            Champion.Diana => new SKColor(68, 68, 187),
            Champion.DrMundo => new SKColor(96, 184, 196),
            Champion.Draven => new SKColor(177, 4, 14),
            Champion.Ekko => new SKColor(88, 219, 195),
            Champion.Elise => new SKColor(137, 57, 82),
            Champion.Evelynn => new SKColor(182, 52, 159),
            Champion.Ezreal => new SKColor(225, 242, 97),
            Champion.Fiddlesticks => new SKColor(44, 116, 72),
            Champion.Fiora => new SKColor(204, 41, 98),
            Champion.Fizz => new SKColor(114, 178, 194),
            Champion.Galio => new SKColor(76, 111, 169),
            Champion.Gangplank => new SKColor(228, 60, 12),
            Champion.Garen => new SKColor(38, 64, 186),
            Champion.Gnar => new SKColor(244, 124, 36),
            Champion.Gragas => new SKColor(196, 72, 36),
            Champion.Graves => new SKColor(82, 16, 16),
            Champion.Gwen => new SKColor(74, 248, 255),
            Champion.Hecarim => new SKColor(7, 145, 145),
            Champion.Heimerdinger => new SKColor(191, 155, 70),
            Champion.Illaoi => new SKColor(79, 186, 69),
            Champion.Irelia => new SKColor(188, 60, 76),
            Champion.Ivern => new SKColor(98, 156, 45),
            Champion.Janna => new SKColor(192, 108, 132),
            Champion.JarvanIV => new SKColor(228, 116, 36),
            Champion.Jax => new SKColor(126, 83, 186),
            Champion.Jayce => new SKColor(163, 128, 11),
            Champion.Jhin => new SKColor(164, 38, 94),
            Champion.Jinx => new SKColor(255, 94, 234),
            Champion.KaiSa => new SKColor(104, 52, 128),
            Champion.Kalista => new SKColor(47, 175, 199),
            Champion.Karma => new SKColor(52, 201, 162),
            Champion.Karthus => new SKColor(64, 149, 191),
            Champion.Kassadin => new SKColor(70, 40, 92),
            Champion.Katarina => new SKColor(177, 5, 57),
            Champion.Kayle => new SKColor(240, 183, 83),
            Champion.Kayn => new SKColor(133, 0, 0),
            Champion.Kennen => new SKColor(101, 5, 128),
            Champion.Khazix => new SKColor(82, 39, 196),
            Champion.Kindred => new SKColor(63, 138, 189),
            Champion.Kled => new SKColor(161, 99, 10),
            Champion.KogMaw => new SKColor(140, 140, 52),
            Champion.LeBlanc => new SKColor(68, 15, 128),
            Champion.LeeSin => new SKColor(214, 39, 80),
            Champion.Lillia => new SKColor(167, 67, 224),
            Champion.Leona => new SKColor(193, 105, 37),
            Champion.Lissandra => new SKColor(52, 86, 125),
            Champion.Lucian => new SKColor(6, 40, 82),
            Champion.Lulu => new SKColor(77, 58, 199),
            Champion.Lux => new SKColor(212, 170, 44),
            Champion.Malphite => new SKColor(97, 57, 15),
            Champion.Malzahar => new SKColor(106, 10, 187),
            Champion.Maokai => new SKColor(40, 132, 160),
            Champion.MasterYi => new SKColor(212, 209, 28),
            Champion.MissFortune => new SKColor(217, 57, 17),
            Champion.Mordekaiser => new SKColor(44, 164, 124),
            Champion.Morgana => new SKColor(190, 50, 186),
            Champion.Nami => new SKColor(36, 188, 232),
            Champion.Nasus => new SKColor(132, 53, 196),
            Champion.Nautilus => new SKColor(205, 95, 43),
            Champion.Neeko => new SKColor(84, 26, 219),
            Champion.Nidalee => new SKColor(137, 237, 90),
            Champion.Nocturne => new SKColor(12, 8, 94),
            Champion.Nunu => new SKColor(62, 186, 226),
            Champion.Olaf => new SKColor(227, 141, 43),
            Champion.Orianna => new SKColor(121, 115, 255),
            Champion.Ornn => new SKColor(120, 0, 0),
            Champion.Pantheon => new SKColor(73, 73, 182),
            Champion.Poppy => new SKColor(201, 38, 81),
            Champion.Pyke => new SKColor(50, 104, 98),
            Champion.Qiyana => new SKColor(228, 128, 83),
            Champion.Quinn => new SKColor(172, 84, 76),
            Champion.Rakan => new SKColor(196, 132, 148),
            Champion.Rammus => new SKColor(212, 120, 35),
            Champion.RekSai => new SKColor(49, 0, 133),
            Champion.Rell => new SKColor(222, 148, 28),
            Champion.Renekton => new SKColor(30, 74, 12),
            Champion.Rengar => new SKColor(212, 150, 6),
            Champion.Riven => new SKColor(57, 255, 43),
            Champion.Rumble => new SKColor(198, 50, 28),
            Champion.Ryze => new SKColor(67, 88, 202),
            Champion.Samira => new SKColor(165, 0, 0),
            Champion.Sejuani => new SKColor(29, 107, 193),
            Champion.Senna => new SKColor(40, 161, 215),
            Champion.Seraphine => new SKColor(229, 78, 252),
            Champion.Sett => new SKColor(172, 76, 92),
            Champion.Shaco => new SKColor(84, 68, 164),
            Champion.Shen => new SKColor(92, 102, 195),
            Champion.Shyvana => new SKColor(140, 20, 7),
            Champion.Singed => new SKColor(88, 185, 95),
            Champion.Sion => new SKColor(180, 9, 12),
            Champion.Sivir => new SKColor(193, 113, 74),
            Champion.Skarner => new SKColor(112, 78, 172),
            Champion.Sona => new SKColor(88, 147, 184),
            Champion.Soraka => new SKColor(184, 97, 255),
            Champion.Swain => new SKColor(156, 25, 14),
            Champion.Sylas => new SKColor(108, 132, 188),
            Champion.Syndra => new SKColor(142, 53, 200),
            Champion.TahmKench => new SKColor(132, 100, 60),
            Champion.Taliyah => new SKColor(189, 97, 47),
            Champion.Talon => new SKColor(54, 62, 118),
            Champion.Taric => new SKColor(122, 64, 203),
            Champion.Teemo => new SKColor(200, 96, 38),
            Champion.Thresh => new SKColor(19, 236, 127),
            Champion.Tristana => new SKColor(184, 93, 100),
            Champion.Trundle => new SKColor(81, 172, 192),
            Champion.Tryndamere => new SKColor(64, 64, 191),
            Champion.TwistedFate => new SKColor(20, 75, 130),
            Champion.Twitch => new SKColor(44, 153, 60),
            Champion.Udyr => new SKColor(156, 60, 28),
            Champion.Urgot => new SKColor(92, 196, 76),
            Champion.Varus => new SKColor(169, 55, 107),
            Champion.Vayne => new SKColor(182, 18, 42),
            Champion.Veigar => new SKColor(67, 42, 158),
            Champion.Velkoz => new SKColor(202, 57, 201),
            Champion.Vi => new SKColor(196, 55, 100),
            Champion.Viego => new SKColor(47, 181, 123),
            Champion.Viktor => new SKColor(204, 76, 36),
            Champion.Vladimir => new SKColor(190, 63, 57),
            Champion.Volibear => new SKColor(74, 134, 175),
            Champion.Warwick => new SKColor(62, 153, 50),
            Champion.Wukong => new SKColor(231, 62, 33),
            Champion.Xayah => new SKColor(165, 28, 87),
            Champion.Xerath => new SKColor(58, 76, 164),
            Champion.XinZhao => new SKColor(204, 133, 99),
            Champion.Yasuo => new SKColor(65, 116, 178),
            Champion.Yone => new SKColor(171, 24, 24),
            Champion.Yorick => new SKColor(58, 104, 197),
            Champion.Yuumi => new SKColor(180, 116, 76),
            Champion.Zac => new SKColor(97, 184, 75),
            Champion.Zed => new SKColor(148, 0, 0),
            Champion.Ziggs => new SKColor(227, 67, 23),
            Champion.Zilean => new SKColor(61, 148, 194),
            Champion.Zoe => new SKColor(228, 104, 87),
            Champion.Zyra => new SKColor(158, 40, 19),
            _ => throw new System.NotImplementedException(),
        };
    }
}
