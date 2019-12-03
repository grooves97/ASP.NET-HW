using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication7.Models;

namespace WebApplication7.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.UserAdmins.Add(new UserAdmin
            {
                Login = "admin",
                Password = "admin"
            });
            var news = new List<Post>
            {
                new Post
                {
                    Title = "Телескоп «Хаббл» снял пару «танцующих» галактик",
                    ImgPath = "https://s.4pda.to/hCxh76eSs7djDD7z05Pr9RXvQkLVz0K2.jpg",
                    News = "С поверхности Земли ночное небо выглядит статичным — но поле зрения космического телескопа «Хаббл» гораздо шире. Новый снимок, опубликованный Европейским космическим агентством, не просто демонстрирует сразу две отдалённых галактики в одном кадре, но и показывает их взаимодействие в форме причудливого «танца»."
                },
                new Post
                {
                    Title = "В России планируют открыть центр искусственного интеллекта",
                    ImgPath = "https://s.4pda.to/hCxh7z1eaRgA0WWgGeKeygwZZ1z0x7Tr.jpg",
                    News = "В отличие от космической программы, которая активно развивается уже несколько десятилетий, к вопросу становления искусственного интеллекта в России начали присматриваться сравнительно недавно. В ближайшее время в стране может появиться специализированный центр развития ИИ — соответствующее предложение уже поступило в правительство."
                },
                new Post
                {
                    Title = "«Два толстых тома диалогов». Один из авторов Cyberpunk 2077 рассказал о сценарии игры",
                    ImgPath = "https://s.4pda.to/hCxh76Oy1GZdSc5OScr9xH1s0UjWXp.jpg",
                    News = "Главный автор CD Projekt RED Марцин Блаха дал большое интервью польскому изданию Innpoland, в котором поведал любопытные детали сценария долгожданного футуристического боевика Cyberpunk 2077. Кроме того, разработчик рассказал, чем подход к созданию этой игры отличается от того, к которому прибегали при разработке The Witcher 3: Wild Hunt."
                }
            };

            context.Posts.AddRange(news);
            context.SaveChanges();
        }
    }
}