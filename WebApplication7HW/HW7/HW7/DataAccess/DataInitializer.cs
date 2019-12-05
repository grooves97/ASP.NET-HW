using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HW7.Models;

namespace HW7.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var articles = new List<Article>
            {
                new Article
                {
                    Title = "Сценарий для чайников. Создатель The Last of Us поделился секретами мастерства",
                    ImagePath = "http://s.4pda.to/8QooLcTXPvTvTtNLqldyYK3RJTDsfpruNcUR.jpg",
                    Description = "Что за секреты таят в себе сюжеты известных фильмов? Каким образом авторы добиваются своих целей? Как пишутся диалоги и по каким принципам идёт развитие персонажей? На эти и многие другие вопросы любят отвечать авторы YouTube-канала Lessons from Screenplay — на примере голливудского кино они разбирают теории написания сценариев. В новом выпуске передачи они решили позвать на помощь режиссёра The Last of Us. И тот рассказал им много интересного."
                },

                new Article
                {
                    Title = "Анонсирована новая глава хоррор-серии Outlast. Но есть подвох",
                    ImagePath = "http://s.4pda.to/8QooMuoZuGMI1Y4z2iFvpz1f6UeBdriV.jpg",
                    Description = "Случилось страшное. В хорошем смысле: разработчики из Red Barrels анонсировали новый хоррор серии Outlast с подзаголовком Trials. Однако радоваться рановато. Это не совсем то продолжение, на которое наверняка надеялись фанаты культовых первых частей. Новинка станет кооперативным хоррором, который, впрочем, можно будет пройти и в одиночку."
                },

                new Article
                {
                    Title = "Американский политик потратил $1302 из бюджета на покупку игр в Steam. Теперь ему грозит тюрьма",
                    ImagePath = "http://s.4pda.to/8QooMqwy04Aass6w58rjDtLGJ1MkMM.jpg",
                    Description = "В 2016 году конгрессмен США от республиканской партии в Калифорнии Дункан Хантер был уличён в излишне роскошном образе жизни. Расследование показало, что средства, предназначенные для ведения предвыборной кампании, он потратил на себя — в том числе, покупая игры в сервисе Steam. В этот вторник суд признал его виновным. Теперь Хантеру светит тюрьма."
                }
            };

            context.Articles.AddRange(articles);

            context.Admins.Add(
                new Admin
                {
                    Login = "admin",
                    Password = "admin"
                });
            context.SaveChanges();
        }
    }
}