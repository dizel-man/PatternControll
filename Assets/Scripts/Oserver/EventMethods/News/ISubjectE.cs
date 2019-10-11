using UnityEngine;

public interface ISubjectE
{
    //регистрирует IObservers
    void RegistrObserver(IObserverE observer);

    //удоляет  IObservers
    void RemoveObserver(IObserverE observer);

    //уведомляет IObservers об изменениях
    void NotifyObserver();

}
