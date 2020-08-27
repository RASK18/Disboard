using Disboard.Shared;
using JikanDotNet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;


namespace Disboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ScheduleController
    {
        private int _requests = 0;
        private readonly IJikan _jikan;
        private readonly ILogger<ScheduleController> _logger;

        public ScheduleController(IJikan jikan, ILogger<ScheduleController> logger)
        {
            _jikan = jikan;
            _logger = logger;
        }

        [HttpGet(Name = "GetSchedule")]
        [ProducesResponseType(typeof(Schedule), StatusCodes.Status200OK)]
        public async Task<ScheduleDto> Get()
        {
            #region RealCode

            //Console.WriteLine($"{_requests++} GetSchedule");
            //Schedule schedule = await _jikan.GetSchedule();
            //ScheduleDto scheduleDto = new ScheduleDto(schedule);

            //int total = scheduleDto.Week.SelectMany(w => w.Animes).Count();
            //Console.WriteLine($"Total de Animes: {total}");

            //foreach (DayDto dayDto in scheduleDto.Week)
            //{
            //    Thread.Sleep(8000);
            //    List<AnimeDto> toRemove = new List<AnimeDto>();

            //    foreach (AnimeDto animeDto in dayDto.Animes)
            //    {
            //        Thread.Sleep(8000);
            //        Console.WriteLine($"{_requests++} GetAnimeEpisodes: {animeDto.Name}");
            //        AnimeEpisode lastEpisode = await GetLastEpisode(animeDto.Id);

            //        if (lastEpisode == null)
            //            toRemove.Add(animeDto);
            //        else
            //            animeDto.Episodes = new List<EpisodeDto> { new EpisodeDto(lastEpisode) };
            //    }

            //    dayDto.Animes.RemoveAll(a => toRemove.Contains(a));
            //}

            //string json = JsonConvert.SerializeObject(scheduleDto, Formatting.Indented);

            #endregion

            ScheduleDto scheduleDto = JsonConvert.DeserializeObject<ScheduleDto>(Prueba);
            return scheduleDto;
        }

        private async Task<AnimeEpisode> GetLastEpisode(long animeId)
        {
            AnimeEpisodes episodes = await _jikan.GetAnimeEpisodes(animeId, 1);

            if (episodes.EpisodesLastPage != 1)
                episodes = await _jikan.GetAnimeEpisodes(animeId, episodes.EpisodesLastPage);

            AnimeEpisode result = episodes.EpisodeCollection.LastOrDefault();
            return result;
        }

        private const string Prueba = @"{
  ""Week"": [
    {
      ""IsToday"": false,
      ""Name"": ""lunes"",
      ""Date"": ""2020-08-31T00:00:00+02:00"",
      ""Animes"": [
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 13,
          ""Id"": 41353,
          ""Score"": 7.72,
          ""ScoredBy"": null,
          ""Name"": ""The God of High School"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1722/107269.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""It all began as a fighting tournament to seek out for the best fighter among all high school students in Korea. Mori Jin, a Taekwondo specialist and a high school student, soon learns that there is something much greater beneath the stage of the tournament.\r\n\r\n(Source: LINE Webtoon)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 1,
              ""Name"": ""Action""
            },
            {
              ""Id"": 24,
              ""Name"": ""Sci-Fi""
            },
            {
              ""Id"": 2,
              ""Name"": ""Adventure""
            },
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 37,
              ""Name"": ""Supernatural""
            },
            {
              ""Id"": 17,
              ""Name"": ""Martial Arts""
            },
            {
              ""Id"": 10,
              ""Name"": ""Fantasy""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 6,
              ""Name"": ""Fear / Six"",
              ""OtherNames"": [
                null,
                null
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 24,
          ""Id"": 41266,
          ""Score"": 6.8,
          ""ScoredBy"": null,
          ""Name"": ""Bessatsu Olympia Kyklos"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1543/107116.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Demetrios, a timid and kind vase painter in Ancient Greece who dislikes sports and competitions, is one day forced to come up with a game to compete with the mayor of the neighboring town in order to save his village. While hiding inside a large vase outside his workshop, lightning strikes the vase Demetrios is in, transferring him to Tokyo, Japan, during the 1964 Summer Olympics.\r\n \r\n(Source: MU)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 36,
              ""Name"": ""Slice of Life""
            },
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 13,
              ""Name"": ""Historical""
            },
            {
              ""Id"": 30,
              ""Name"": ""Sports""
            },
            {
              ""Id"": 42,
              ""Name"": ""Seinen""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": false,
              ""Number"": 4,
              ""Name"": ""It Always Starts With Zeus"",
              ""OtherNames"": [
                null,
                null
              ]
            }
          ]
        }
      ]
    },
    {
      ""IsToday"": false,
      ""Name"": ""martes"",
      ""Date"": ""2020-09-01T00:00:00+02:00"",
      ""Animes"": [
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 25,
          ""Id"": 40417,
          ""Score"": 8.31,
          ""ScoredBy"": null,
          ""Name"": ""Fruits Basket 2nd Season"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1486/106692.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""A year has passed since Tooru Honda began living in the Souma residence, and she has since created stronger relationships with its inhabitants Shigure, Kyou, and Yuki. She has also grown closer to the rest of the Souma family and has become familiar with their ancestral secret, having helped them with many of their personal issues. The closer Tooru gets, however, the more she begins to realize that their secret holds a darker truth than she first presumed.\r\n\r\nSummer is approaching and Tooru is invited to spend her days with the Soumas, mainly Kyou and Yuki. Tooru wishes for an easy-going vacation, but her close relationships with the two boys and the rest of the Soumas may prove to cause trouble. As they grow more intimate, their carefree time together is hindered by older hardships and feelings from the past that begin to resurface. The Eternal Banquet also dawns on the members of the zodiac, and they must tend to their duties alongside the unnerving head of the family, Akito Souma.\r\n\r\nWith the banquet approaching and a plethora of feelings to be solved, will Tooru's life with the Soumas remain peaceful, or will she find herself in a situation from which she cannot escape?\r\n\r\n[Written by MAL Rewrite]"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 36,
              ""Name"": ""Slice of Life""
            },
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 37,
              ""Name"": ""Supernatural""
            },
            {
              ""Id"": 8,
              ""Name"": ""Drama""
            },
            {
              ""Id"": 22,
              ""Name"": ""Romance""
            },
            {
              ""Id"": 25,
              ""Name"": ""Shoujo""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 18,
              ""Name"": ""Do You Wanna Kiss?"",
              ""OtherNames"": [
                ""Kiss Shiyokka "",
                ""キスしよっか""
              ]
            }
          ]
        }
      ]
    },
    {
      ""IsToday"": false,
      ""Name"": ""miércoles"",
      ""Date"": ""2020-09-02T00:00:00+02:00"",
      ""Animes"": [
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 13,
          ""Id"": 39587,
          ""Score"": 8.49,
          ""ScoredBy"": null,
          ""Name"": ""Re:Zero kara Hajimeru Isekai Seikatsu 2nd Season"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1444/108005.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Even after dying countless times, Subaru finally ended the threat of the White Whale and defeated the Witch Cult's Sin Archbishop representing sloth, Petelgeuse Romaneeconti. But only shortly after overcoming a tragic ending and reuniting with his beloved Emilia, Subaru learns that Rem has been erased from this world, having fallen victim to the White Whale's Fog of Elimination in the midst of Subaru's death loop. With the White Whale now gone, Subaru and Emilia are forced to confront a reality they never dreamed would happen.\r\n\r\n(Source: Crunchyroll)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 8,
              ""Name"": ""Drama""
            },
            {
              ""Id"": 10,
              ""Name"": ""Fantasy""
            },
            {
              ""Id"": 40,
              ""Name"": ""Psychological""
            },
            {
              ""Id"": 41,
              ""Name"": ""Thriller""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 4,
              ""Name"": ""Parent and Child"",
              ""OtherNames"": [
                ""Oyako "",
                ""親子""
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 12,
          ""Id"": 40056,
          ""Score"": 7.15,
          ""ScoredBy"": null,
          ""Name"": ""Deca-Dence"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1627/107552.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Many years have passed since humanity was driven to the brink of extinction by the sudden emergence of the unknown life forms Gadoll. Those humans that survived now dwell in a 3000m-high mobile fortress Deca-dence built to protect themselves from the Gadoll threat.\r\n\r\nDenizens of Deca-dence fall into two categories: Gears, warriors who fight the Gadoll daily, and Tankers, those without the skills to fight. One day, Natsume, a Tanker girl who dreams of becoming a Gear meets surly Kaburagi, an armor repairman of Deca-dence.\r\n\r\nThis chance meeting between the seemingly two opposites, the girl with a positive attitude who never gives up on her dreams and the realist who has given up on his, will eventually shake the future course of this world. \r\n\r\n(Source: Official Site)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 1,
              ""Name"": ""Action""
            },
            {
              ""Id"": 24,
              ""Name"": ""Sci-Fi""
            },
            {
              ""Id"": 2,
              ""Name"": ""Adventure""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 7,
              ""Name"": ""Driveshaft"",
              ""OtherNames"": [
                null,
                null
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 50,
          ""Id"": 37403,
          ""Score"": 7.3,
          ""ScoredBy"": null,
          ""Name"": ""Ahiru no Sora"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1975/108030.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Lacking what is considered the most important asset in basketball, Sora Kurumatani has struggled with his short height since the inception of his love for the game. Despite missing this beneficial aspect, Sora's unwavering drive never allowed his small stature to dictate his ability to play, believing strongly in trying his hardest and persistently practicing to prove his capability.\r\n\r\nIn hopes of satisfying his mother's wishes, Sora enters Kuzuryuu High School to become a member of the basketball club and compete wholeheartedly in tournaments. However, Sora is disappointed to find out that the boy's basketball team is nothing but a retreat for punks who have no interest in the sport. Sora also comes to learn that brothers Chiaki and Momoharu Hanazono—whom he becomes acquainted with—have also lost their once spirited motivation to play. \r\n\r\nDetermined to revive the basketball team, Sora challenges the boys to a match against him, where his quick feet and swift movements overwhelm the group. Gradually affected by Sora's impressive skills, sheer effort, and tireless devotion to basketball, the boys unexpectedly find their burnt-out passion for the game rekindling once again.\r\n\r\n[Written by MAL Rewrite]"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 30,
              ""Name"": ""Sports""
            },
            {
              ""Id"": 8,
              ""Name"": ""Drama""
            },
            {
              ""Id"": 23,
              ""Name"": ""School""
            },
            {
              ""Id"": 27,
              ""Name"": ""Shounen""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 43,
              ""Name"": ""The Best Lineup"",
              ""OtherNames"": [
                ""Best Member "",
                ""ベストメンバー""
              ]
            }
          ]
        }
      ]
    },
    {
      ""IsToday"": true,
      ""Name"": ""jueves"",
      ""Date"": ""2020-08-27T00:00:00+02:00"",
      ""Animes"": [
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 12,
          ""Id"": 40075,
          ""Score"": 6.43,
          ""ScoredBy"": null,
          ""Name"": ""Koi to Producer: EVOL×LOVE"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1944/108276.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""A girl inherits a company that is almost bankrupt from her late father. Lacking the funds, she must now become the producer herself in order to save the company from collapse.\r\nDuring her work, she meets four boys—financial expert Zen, the idol Kira, police officer Haku, and leading neuroscientist Simon—and is suddenly involved with the conspiracies and mysteries over the existence of special powers known as \""Evol.\""\r\n\r\n(Source: MAL News)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 24,
              ""Name"": ""Sci-Fi""
            },
            {
              ""Id"": 7,
              ""Name"": ""Mystery""
            },
            {
              ""Id"": 31,
              ""Name"": ""Super Power""
            },
            {
              ""Id"": 22,
              ""Name"": ""Romance""
            },
            {
              ""Id"": 25,
              ""Name"": ""Shoujo""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 1,
              ""Name"": ""The Beginning Bonds"",
              ""OtherNames"": [
                ""Hajimari no Kizuna "",
                ""はじまりの絆""
              ]
            }
          ]
        }
      ]
    },
    {
      ""IsToday"": false,
      ""Name"": ""viernes"",
      ""Date"": ""2020-08-28T00:00:00+02:00"",
      ""Animes"": [
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 12,
          ""Id"": 39547,
          ""Score"": 8.49,
          ""ScoredBy"": null,
          ""Name"": ""Yahari Ore no Seishun Love Comedy wa Machigatteiru. Kan"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1958/107912.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Third season of Yahari Ore no Seishun Love Comedy wa Machigatteiru.\r\n\r\nAs the members of the Service Club band together to host a school prom, Hachiman, Yukino and Yui will have to put their feelings into words and truly learn to understand each other at long last… if the Service Club can even stay afloat, that is!\r\n\r\n(Source: Sentai Filmworks)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 36,
              ""Name"": ""Slice of Life""
            },
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 8,
              ""Name"": ""Drama""
            },
            {
              ""Id"": 22,
              ""Name"": ""Romance""
            },
            {
              ""Id"": 23,
              ""Name"": ""School""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 7,
              ""Name"": ""Until the End, Yui Yuigahama Will Continue Watching Over Them."",
              ""OtherNames"": [
                ""Saigo made, Yuigahama Yui wa Mimamori Tsuzukeru. "",
                ""最後まで、由比ヶ浜結衣は見守り続ける。""
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 11,
          ""Id"": 41120,
          ""Score"": 7.64,
          ""ScoredBy"": null,
          ""Name"": ""Fugou Keiji: Balance:Unlimited"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1066/106556.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Daisuke Kanbe, a man of extraordinary wealth, is assigned to the Modern Crime Prevention Headquarters as a detective. It is there that he gets partnered with Haru Katou, a humane detective who values justice above all. The two are polar opposites, and their morals clash time and time again. Haru despises Daisuke for using monetary wealth to solve cases, as he believes that money isn't everything. The two will have to combine their efforts, however, to solve the mysteries that are coming their way.\r\n\r\n[Written by MAL Rewrite]"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 7,
              ""Name"": ""Mystery""
            },
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 39,
              ""Name"": ""Police""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 6,
              ""Name"": ""Ill Got, Ill Spent"",
              ""OtherNames"": [
                ""Akusenmi ni Tsukazu "",
                ""悪銭身に付かず""
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 12,
          ""Id"": 41226,
          ""Score"": 7.04,
          ""ScoredBy"": null,
          ""Name"": ""Uzaki-chan wa Asobitai!"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1540/108292.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Sakurai Shinichi's one wish is for a little peace and quiet. But Uzaki Hana–his boisterous, well-endowed underclassman–has other plans. All she wants is to hang out and poke fun at him. With the help of her chipper charm and peppy persistence, this might just be the start of a beautiful relationship! \r\n\r\n(Source: Seven Seas Entertainment)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 36,
              ""Name"": ""Slice of Life""
            },
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 9,
              ""Name"": ""Ecchi""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 7,
              ""Name"": ""I Want to Hang Out at a Cat Café and a Pub!"",
              ""OtherNames"": [
                ""Neko Cafe to Izakaya de Asobitai! "",
                ""猫カフェと居酒屋で遊びたい！""
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 25,
          ""Id"": 38481,
          ""Score"": 8.23,
          ""ScoredBy"": null,
          ""Name"": ""Toaru Kagaku no Railgun T"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1819/103287.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""The Daihasei Festival has begun, and that of course means that Tokiwadai Middle School—a prestigious all-girls' middle school—is competing too. Despite the participation of the \""Ace of Tokiwadai,\"" Mikoto Misaka, the other students who are participating are still putting their utmost effort into winning, no matter how impossible the feat may seem against her might.\r\n\r\nHowever, not all is fun and games. Due to the the festival, Academy City opens to the outside world, and various factions have begun plotting ways to infiltrate the city. Misaka appears to be on their radar, and as the festival proceeds, people lurking from the shadows begin to emerge...\r\n\r\nToaru Kagaku no Railgun T brings back the Tokiwadai Ace and her friends as they dive deeper into the dark side of Academy City. From terrorist attacks to ruthless underground projects, anything is possible in this city.\r\n\r\n[Written by MAL Rewrite]"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 1,
              ""Name"": ""Action""
            },
            {
              ""Id"": 24,
              ""Name"": ""Sci-Fi""
            },
            {
              ""Id"": 31,
              ""Name"": ""Super Power""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": false,
              ""Number"": 15,
              ""Name"": ""Promise"",
              ""OtherNames"": [
                null,
                null
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 13,
          ""Id"": 40532,
          ""Score"": 7.17,
          ""ScoredBy"": null,
          ""Name"": ""Appare-Ranman!"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1710/106614.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""No dream is too big for Appare Sorrano, a socially-awkward inventor living in a small rural town in Japan in the late 19th century. Fascinated since childhood by the creation of steamships that can connect people across great distances, he's learned to make machines of all kinds from various scientific texts. His goal is to sail across the sea, beyond the sky, and ultimately, to the other side of the moon.\r\n\r\nUnfortunately, through a string of events, Appare finds himself stranded in the middle of the sea on his mini steamship. Floating alongside him is a skilled but cowardly samurai, Kosame Ishikki, who was tasked to keep his eccentric behavior in check. Just when all hope seems lost, a large steamship saves them and takes them to Los Angeles. With no money or plans, they decide to participate in the \""Trans-America Wild Race,\"" which gives Appare the chance to build his own automobile, and Kosame the opportunity to use the cash prize to return home. However, against rival racers and unknown challenges residing in the wilderness, just how far will this adventure take Appare and Kosame?\r\n\r\n[Written by MAL Rewrite]"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 3,
              ""Name"": ""Cars""
            },
            {
              ""Id"": 4,
              ""Name"": ""Comedy""
            },
            {
              ""Id"": 13,
              ""Name"": ""Historical""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 8,
              ""Name"": ""Heavy Rain"",
              ""OtherNames"": [
                null,
                null
              ]
            }
          ]
        }
      ]
    },
    {
      ""IsToday"": false,
      ""Name"": ""sábado"",
      ""Date"": ""2020-08-29T00:00:00+02:00"",
      ""Animes"": [
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 24,
          ""Id"": 40956,
          ""Score"": 7.85,
          ""ScoredBy"": null,
          ""Name"": ""Enen no Shouboutai: Ni no Shou"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1673/107657.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Second season of Enen no Shouboutai."",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 1,
              ""Name"": ""Action""
            },
            {
              ""Id"": 37,
              ""Name"": ""Supernatural""
            },
            {
              ""Id"": 27,
              ""Name"": ""Shounen""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 8,
              ""Name"": ""Smoldering Malevolence"",
              ""OtherNames"": [
                ""Moe Hisomu Akui "",
                ""燃え潜む悪意""
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 13,
          ""Id"": 40496,
          ""Score"": 7.4,
          ""ScoredBy"": null,
          ""Name"": ""Maou Gakuin no Futekigousha: Shijou Saikyou no Maou no Shiso, Tensei shite Shison-tachi no Gakkou e"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1126/108573.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""After 2000 years have passed, the ruthless demon lord has just been reincarnated! But his aptitude at an academy for nurturing candidates for demon lords is, “inept”!?\r\n\r\nHaving the capability to destroy humans, elementals, and gods, after a long period of countless wars and strife, Arnos the demon lord became sick and tired of all that and longed for a peaceful world, so he decided to reincarnate to the future.\r\n\r\nHowever, what awaited him after his reincarnation is a world too used to peace that his descendants became too weak due to a huge weakening in magical powers. \r\n\r\n(Source: MU)"",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 1,
              ""Name"": ""Action""
            },
            {
              ""Id"": 6,
              ""Name"": ""Demons""
            },
            {
              ""Id"": 16,
              ""Name"": ""Magic""
            },
            {
              ""Id"": 10,
              ""Name"": ""Fantasy""
            },
            {
              ""Id"": 23,
              ""Name"": ""School""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 7,
              ""Name"": ""Mother's Words"",
              ""OtherNames"": [
                ""Haha no Kotoba "",
                ""母の言葉""
              ]
            }
          ]
        }
      ]
    },
    {
      ""IsToday"": false,
      ""Name"": ""domingo"",
      ""Date"": ""2020-08-30T00:00:00+02:00"",
      ""Animes"": [
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 11,
          ""Id"": 40540,
          ""Score"": 7.63,
          ""ScoredBy"": null,
          ""Name"": ""Sword Art Online: Alicization - War of Underworld 2nd Season"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1438/105106.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Second part of Sword Art Online: Alicization - War of Underworld."",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 1,
              ""Name"": ""Action""
            },
            {
              ""Id"": 11,
              ""Name"": ""Game""
            },
            {
              ""Id"": 2,
              ""Name"": ""Adventure""
            },
            {
              ""Id"": 22,
              ""Name"": ""Romance""
            },
            {
              ""Id"": 10,
              ""Name"": ""Fantasy""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": true,
              ""Number"": 2,
              ""Name"": ""End to Eternity"",
              ""OtherNames"": [
                ""Mugen no Hate "",
                ""無限の果て""
              ]
            }
          ]
        },
        {
          ""HasBeenReleased"": true,
          ""IsCompleted"": null,
          ""Total"": 15,
          ""Id"": 37962,
          ""Score"": 7.64,
          ""ScoredBy"": null,
          ""Name"": ""IDOLiSH7: Second Beat!"",
          ""ImgUrl"": ""https://cdn.myanimelist.net/images/anime/1962/106361.jpg"",
          ""Type"": ""TV"",
          ""Synopsis"": ""Second season of IDOLiSH7."",
          ""OtherNames"": null,
          ""Genres"": [
            {
              ""Id"": 19,
              ""Name"": ""Music""
            }
          ],
          ""Episodes"": [
            {
              ""HasBeenReleased"": false,
              ""Number"": 4,
              ""Name"": ""A New Form"",
              ""OtherNames"": [
                null,
                null
              ]
            }
          ]
        }
      ]
    }
  ]
}";
    }
}
