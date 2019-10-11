using UnityEngine;

public class TwitterWidgetE
{
    private string _twitter;
   

    public void UpdateNews(object sender, NewsEventArgsE e)
    {
        _twitter = e.TwitterE;
        Display();
    }

    public void Display()
    {
        Debug.Log($"Twitter: \"{_twitter}\" {0}");
    }


  
}
