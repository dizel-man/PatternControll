using UnityEngine;

public interface IObserver
{
    void UpdateNews(string twitter, string lenta, string tv);
    void Display();
    void RemoveFromSubject();
}
