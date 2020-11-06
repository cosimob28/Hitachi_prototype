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

    void FixedUpdate()
    {
        TrainFollowBinaryStandar();
    }

    void TrainFollowBinaryStandar()
    {
        gameObject.transform.position += Vector3.back * 1.1f * Time.deltaTime; // insert param velocity here
    }

    // void methodToAllowTrainToCurve()
}
