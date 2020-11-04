using UnityEngine;

public class TrainFollowBinary : MonoBehaviour
{
    public Transform binary;
    // private float train_velocity
    // private float angular_velocity
    void Start()
    {
        binary = GetComponent<Transform>();
    }

    void Update()
    {
        TrainFollowBinaryStandar();
    }

    void TrainFollowBinaryStandar() {
        gameObject.transform.position += Vector3.back * Time.deltaTime; // insert param velocity here
    }

    // void methodToAllowTrainToCurve()
}
