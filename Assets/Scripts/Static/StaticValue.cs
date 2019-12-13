using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Static
{
    public class StaticValue : MonoBehaviour
    {
        //не изменяется при переходе ы другую сцену
        public static int value;
        Text text;

        private void Start()
        {
            text = GetComponent<Text>();
            text.text = value.ToString();
        }


        public void PlusValue()
        {
            value++;

            text.text = value.ToString();
        }

        public void GoToSecondScene()
        {
            SceneManager.LoadScene(0);
         
        }
    }

}

