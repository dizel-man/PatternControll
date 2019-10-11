using UnityEngine;

public interface IObserverE
{
    void UpdateNews(string twitter, string lenta, string tv);
    void Display();
    void RemoveFromSubject();
}
