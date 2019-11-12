using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplicationHW5.Models;

namespace WebApplicationHW5.DataAcces
{
    public class WallInitializer : CreateDatabaseIfNotExists<WallContext>
    {
        protected override void Seed(WallContext context)
        {
            context.Messages.AddRange(new List<Message>
            {
                new Message
                {
                    Name="Aslan",
                    Text="Всем привет"
                },
                new Message
                {
                    Name="Иван Гай",
                    Text="Хаю Хай с вами Иван Гай"
                },
                new Message
                {
                    Name="Азат",
                    Text="Саламчик"
                },
            });
        }
    }
}