using MvcApplication1.Repository;
using System;
﻿using Database.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ArticleModel
    {
        private readonly PostModel post;
        private readonly ICollection<string> comments;

        public ArticleModel()
        {
            Title = "This is an article title";
            Body = "<p>Покупка товаров из-за границы через интернет — дело уже привычное. Впрочем, иногда есть риск попасться на удочку мошенника. Именно такая история произошла с жительницей Гродно, которая присмотрела себе Jeep Grand Cherokee из Великобритании по сносной цене. Продавец попросил $6 тыс. задатка. Женщина перевела деньги. На этом их переписка закончилась. В Беларуси возбуждено уголовное дело по статье «Мошенничество». Женщина 1978 года рождения выбирала себе автомобиль через объявления в интернете. На одном из зарубежных ресурсов она нашла приемлемый вариант. В качестве продавца автомобиля Jeep Grand Cherokee выступил неизвестный из Великобритании, предложенная им цена была существенно ниже стоимости других внедорожников аналогичных моделей. Чтобы отправить покупку в Беларусь, продавец попросил посредством денежного перевода перечислить задаток в размере $6 тыс. и как только получил эту сумму, тут же прекратил переписку. Через пару недель аналогичное фото Jeep Grand Cherokee красовалось уже на другом сайте — для очередной доверчивой жертвы. Возбуждено уголовное дело по ч. 3 ст. 209 «Мошенничество» УК РБ.</p>";
            Date = DateTime.Now;
            Likes = new Collection<LikeModel>();
            comments = CommentsRepository.Comments;
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }


        public ICollection<LikeModel> Likes { get; set; }
         public ArticleModel(PostModel post, ICollection<string> comments)
         {
             this.post = post;
             this.comments = comments;
         }

         public PostModel Post
         {
             get
             {
                 return post;
             }
         }

        public ICollection<string> Comments 
        { 
            get
            {
                return comments;
            }
        }
        public AddCommentModel NewComment { get; set; }
        public UserModel User { get; set; }
       // public ICollection<CommentItemModel> Comments { get; set; }
    }
}