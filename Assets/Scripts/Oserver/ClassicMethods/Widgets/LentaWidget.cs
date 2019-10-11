using UnityEngine;

public class LentaWidget : IObserver
{
    private string _lenta;
    private ISubject _subject;

    // конструктор для того чтобы в нем был сохранен нужный нам ISubject
    public LentaWidget(ISubject subject)
    {
        _subject = subject;
        subject.RegistrObserver(this); //регистрация
    }

    public void UpdateNews(string twitter, string lenta, string tv)
    {
        _lenta = lenta;
        Display();
    }

    public void Display()
    {
        Debug.Log($"Lenta: \"{_lenta}\" {0}");
    }

    public void RemoveFromSubject()
    {
        _subject.RemoveObserver(this);//удаление
    }
}
