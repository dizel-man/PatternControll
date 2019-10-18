using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//тут мы просто смотрим пример

public class SceneManagerScript : MonoBehaviour
{
    // для удобства
    public Text ValueTxt;

    void Start()
    {
        //это мы просто смотрим в UI сколько раз мы будем переходить
        ValueTxt.text = SingltonManager.Instance.Value.ToString();
    }

    // надо для примера иметь две сцены
    //идем в первую сцену и смотрим сколько раз мы это делали без изменения количеств
    public void GoToFirstScene()
    {
        SceneManager.LoadScene(0);
        SingltonManager.Instance.Value++;

        //и ещё добавил один объект в сцену
        SingltonManagerTwo.Instance.Value++;
    }

    //идем во вторую сцену и смотрим сколько раз
    public void GoToSecondScene()
    {
        SceneManager.LoadScene(1);
        SingltonManager.Instance.Value++;

        SingltonManagerTwo.Instance.Value++;
    }
}
