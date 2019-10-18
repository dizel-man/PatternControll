using UnityEngine;
//это пример для сохранения такого скрипта в каждой сцене в единственном числе
//это синглтон
//надо его бросить на объект который хотим сохранять в единственном числе в любой сцене
public class SingltonManager : MonoBehaviour
{
    //только get 
    //private set - чтобы никто не мог его стереть
    public static SingltonManager Instance { get; private set; }

    //делается для подсчета только gameobjectы - не для этого класса
    public int Value;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // в сцене появится вкладка DontDestroyOnLoad и под ней будет наш 
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
