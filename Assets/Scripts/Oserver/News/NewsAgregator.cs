using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsAgregator : ISubject
{
    //список наблюдателей
    private List<IObserver> _observers;

    public NewsAgregator()
    {
        _observers = new List<IObserver>();
    }

    //регистрация наблюдателей
    public void RegistrObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    //удаление наблюдателей
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    //получение состояния новостей 
    public void NotifyObserver()
    {

        string twitter = GetTwitterNews();
        string lenta = GetLentaNews();
        string tv = GetTVNews();

        foreach (var observer in _observers)
        {
            observer.UpdateNews(twitter, lenta, tv);
        }
    }

    //отправка из какого-нибудь другого источника свежих новостей
    public void NeNewsAvalable()
    {
        NotifyObserver();
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
