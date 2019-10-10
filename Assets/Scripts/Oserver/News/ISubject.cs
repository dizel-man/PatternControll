using UnityEngine;

public interface ISubject
{
    //регистрирует IObservers
    void RegistrObserver(IObserver observer);

    //удоляет  IObservers
    void RemoveObserver(IObserver observer);

    //уведомляет IObservers об изменениях
    void NotifyObserver();

}
