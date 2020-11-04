using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTrain : MonoBehaviour
{
    public GameObject train;
    private Vector3 cameraLocation;

    // Start is called before the first frame update
    void Start()
    {
        //calcolo della distanza tra la camera e il treno
        cameraLocation = transform.position - train.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ad ogni frame, viene aggiornata la posizione della camera 
        transform.position = train.transform.position + cameraLocation;
    }
}
