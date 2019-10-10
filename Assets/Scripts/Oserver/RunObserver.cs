using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunObserver : MonoBehaviour
{
    NewsAgregator newsAggregator;

    TwitterWidget twitterWidget;
    LentaWidget lentaWidget;
    TvWidget tvWidget;

    void Start()
    {
        newsAggregator = new NewsAgregator();

        twitterWidget = new TwitterWidget(newsAggregator);
        lentaWidget = new LentaWidget(newsAggregator);
        tvWidget = new TvWidget(newsAggregator);

        newsAggregator.NeNewsAvalable();

        twitterWidget.RemoveFromSubject();

        newsAggregator.NeNewsAvalable();

    }

}
