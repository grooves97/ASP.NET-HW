using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplicationHW7.Models;

namespace WebApplicationHW7.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            Role user = new Role { Name = "user" };
            Role admin = new Role { Name = "admin" };

            context.Roles.Add(user);
            context.Roles.Add(admin);

            context.Users.Add(new User
            {
                RoleName = admin,
                Password = "admin",
                Email = "admin"
            });

            context.Posts.AddRange(new List<Post>()
            {
                new Post
                {
                    ImgPath = "http://s.4pda.to/bRdtx3ehA1XCGV1y83dgZAm3z2PgYgc.jpg",
                    Title ="Lincoln готовится к выпуску своего первого электрокара",
                    Text = "Американская компания Lincoln, специализирующаяся на производстве автомобилей премиум-класса, анонсировала выпуск собственного кроссовера с электродвигателем. За основу будущей новинки вендор возьмёт оригинальную платформу-«скейтборд», а в производство автомобиль поступит уже в 2021-м."
                },

                new Post
                {
                    ImgPath = "http://s.4pda.to/bRdtz0Ebz1gHPvV4fSXuZSmF98z2b1Yfboz1Qjii.jpg",
                    Title = "Дискету для Apple Macintosh из 90-х оценили в $7500",
                    Text = "В эпоху облачных технологий физические носители используются всё реже, особенно такие устаревшие и ненадёжные, как флоппи-диски. И всё же находятся пользователи, готовые выложить тысячи долларов за раритетный накопитель, особенно если он стал частью истории знаменитой компании. Торговая площадка RR Auction выставила на продажу дискету с системным ПО для Macintosh. Фишкой дискеты стало не только содержимое — к её внешнему виду в прямом смысле приложил руку основатель Apple Стив Джобс."
                },

                new Post
                {
                    ImgPath = "http://s.4pda.to/bRdtxIBz0CE9HRkez2NldM1q3PqNydWIcSFCVo.jpg",
                    Title = "Кина не будет. Глава Take-Two объяснил, почему GTA обойдётся без экранизации",
                    Text = "Ещё с 90-х Голливуд пытается переносить популярные игры на большой экран: Super Mario Bros., Tomb Raider, Resident Evil — многие знаменитые серии получили киноадаптацию. Но не эпохальная Grand Theft Auto. Почему одна из самых известных медиафраншиз в истории индустрии избегает кино? Отвечает Штраус Зельник, исполнительный директор Take-Two."
                }
            });
            base.Seed(context);
        }
    }
}