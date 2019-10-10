using UnityEngine;

public class TvWidget : IObserver
{
    private string _tv;
    private ISubject _subject;

    //регистрация самого себя в агрегаторе
    public TvWidget(ISubject subject)
    {
        _subject = subject;
        subject.RegistrObserver(this);
    }

    public void UpdateNews(string twitter, string lenta, string tv)
    {
        _tv = tv;
        Display();
    }

    public void Display()
    {
        Debug.Log($"TV: \"{_tv}\" {0}");
    }

    public void RemoveFromSubject()
    {
        _subject.RemoveObserver(this);
    }
}
