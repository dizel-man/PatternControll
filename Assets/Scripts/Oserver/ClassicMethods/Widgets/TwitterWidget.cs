using UnityEngine;

public class TwitterWidget : IObserver
{
    private string _twitter;

    private ISubject _subject;


    // конструктор для того чтобы в нем был сохранен нужный нам ISubject
    public TwitterWidget(ISubject subject)
    {
        _subject = subject;
        subject.RegistrObserver(this); //регистрация
    }

    public void UpdateNews(string twitter, string lenta, string tv)
    {
        _twitter = twitter;
        Display();
    }

    public void Display()
    {
        Debug.Log($"Twitter: \"{_twitter}\" {0}");
    }


    public void RemoveFromSubject()
    {
        _subject.RemoveObserver(this);//удаление
    }
}
