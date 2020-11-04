using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStartStation : MonoBehaviour
{
    public Transform train_position;
    [SerializeField]
    public Transform[] station_position;

    Dropdown dropDown;
    public int N_STATION = 3;

    // https://answers.unity.com/questions/1569855/search-in-dropdown-options.html

    void Start()
    {
        train_position = GameObject.Find("Treno").GetComponent<Transform>();
        station_position = new Transform[N_STATION];

        dropDown = GameObject.Find("Dropdown").GetComponent<Dropdown>();

        for (int i = 0; i < N_STATION+1; ++i)
        {
            station_position[i] = GameObject.Find("Stazione_" + i.ToString()).GetComponent<Transform>();
            dropDown.value = i;
        }
    }

    void Update()
    {
        SetTrainPositionFromStation();
    }

    public void SetTrainPositionFromStation() {
        if (dropDown.value == 1)
        {
            train_position.localPosition = GameObject.Find("Stazione_3").GetComponent<Transform>().localPosition;
        }
        
    }
}
