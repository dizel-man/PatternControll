using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//создан для того чтобы передавать что то из публикатора в подписчики 
public class NewsEventArgsE
{
    public string TwitterE { get; private set; }
    public string LentaE { get; private set; }
    public string TvE { get; private set; }


    public NewsEventArgsE(string twitter, string lenta, string tv)
    {
        TwitterE = twitter;
        LentaE = lenta;
        TvE = tv;
    }
}

//*** sender это то кто посылает события, а NewsEventArgsE содержит то что надо передать
public delegate void NewsChangedEventHandlerE(object sender, NewsEventArgsE e);


public class NewsAgregatorE 
{
 

    //событие*** в прошедшем времени
    public event NewsChangedEventHandlerE NewsChanged;



    //отправка из какого-нибудь другого источника свежих новостей
    public void NeNewsAvalable()
    {
        string twitterE = GetTwitterNews();
        string lentaE = GetLentaNews();
        string tvE = GetTVNews();

        //публикация события
        if (NewsChanged != null)
            NewsChanged(this, new NewsEventArgsE(twitterE,lentaE,tvE));
    }

    public string GetTwitterNews()
    {
        var news = new List<string>
        {
            "новость из Twitter номер 1",
            "новость из Twitter номер 2",
            "новость из Twitter номер 3"

        };

        return news[Random.Range(0, news.Count)];
    }

    public string GetLentaNews()
    {
        var news = new List<string>
        {
            "новость из Lenta номер 1",
            "новость из Lenta номер 2",
            "новость из Lenta номер 3"

        };

        return news[Random.Range(0, news.Count)];
    }

    public string GetTVNews()
    {
        var news = new List<string>
        {
            "новость из TV номер 1",
            "новость из TV номер 2",
            "новость из TV номер 3"

        };

        return news[Random.Range(0, news.Count)];
    }

   

}
