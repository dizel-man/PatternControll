using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCount : MonoBehaviour
{
    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        text.text = InstaanseCountPlayers.count.ToString();
    }

    private void Update()
    {
        text.text = InstaanseCountPlayers.count.ToString();
    }
}
