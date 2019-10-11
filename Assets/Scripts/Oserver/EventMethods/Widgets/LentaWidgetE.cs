using UnityEngine;

public class LentaWidgetE
{
    private string _lenta;
   

    public void UpdateNews(object sender, NewsEventArgsE e)
    {
        _lenta = e.LentaE;
        Display();
    }

    public void Display()
    {
        Debug.Log($"Lenta: \"{_lenta}\" {0}");
    }

  
}
