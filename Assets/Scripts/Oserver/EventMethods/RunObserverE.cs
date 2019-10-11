using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunObserverE : MonoBehaviour
{
    NewsAgregatorE newsAggregatorE;
    TwitterWidgetE twitterWidgetE;
    LentaWidgetE lentaWidgetE;
    TvWidgetE tvWidgetE;

    void Start()
    {
        newsAggregatorE = new NewsAgregatorE();

        twitterWidgetE = new TwitterWidgetE();
        lentaWidgetE = new LentaWidgetE();
        tvWidgetE = new TvWidgetE();

        //подписка на событие
        newsAggregatorE.NewsChanged += twitterWidgetE.UpdateNews;
        newsAggregatorE.NewsChanged += lentaWidgetE.UpdateNews;
        newsAggregatorE.NewsChanged += tvWidgetE.UpdateNews;

        newsAggregatorE.NeNewsAvalable();// оповещение

        //отписка от события
        newsAggregatorE.NewsChanged -= lentaWidgetE.UpdateNews;
        newsAggregatorE.NewsChanged -= tvWidgetE.UpdateNews;

        newsAggregatorE.NeNewsAvalable();// оповещение

    }

}
