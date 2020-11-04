using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStartStation : MonoBehaviour
{
    public Transform train_position;
    [SerializeField]
    public Transform[] station_position;

    public int N_STATION = 3;

    void Start()
    {
        train_position = GameObject.Find("Treno").GetComponent<Transform>();
        station_position = new Transform[N_STATION];

        for (int i = 0; i < N_STATION; i++)
        {
            station_position[i] = GameObject.Find("Stazione_" + i.ToString()).GetComponent<Transform>();
        }
    }

    void Update()
    {
        
    }

    void SetTrainPositionFromStation() {

    }
}
