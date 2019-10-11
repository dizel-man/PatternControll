using UnityEngine;

public class TvWidgetE 
{
    private string _tv;
   
    public void UpdateNews(object sender, NewsEventArgsE e)
    {
        _tv = e.TvE;
        Display();
    }

    public void Display()
    {
        Debug.Log($"TV: \"{_tv}\" {0}");
    }

  }
