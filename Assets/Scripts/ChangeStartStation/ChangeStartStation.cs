using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStartStation : MonoBehaviour
{
    public Transform train_position;

    public Dropdown _dropdown;

    void Awake()
    {
        _dropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
    }

    void Start()
    {
        _dropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
    }

    void Update()
    {
        SetTrainPositionFromStation();
    }

    public void SetTrainPositionFromStation()
    {

        int station1 = GetIndexByName(_dropdown,"Station1");
        int station2 = GetIndexByName(_dropdown, "Station2");
        int station3 = GetIndexByName(_dropdown, "Station3");

        if (_dropdown.value == station1)
        {
            train_position.position = GameObject.Find("Stazione_1").GetComponent<Transform>().position + (Vector3.right * 1.5f);
            //train_position.position += Vector3.back * Time.deltaTime;
        }
        else if (_dropdown.value == station2)
        {
            train_position.position = GameObject.Find("Stazione_2").GetComponent<Transform>().position + (Vector3.right*1.5f);
            //train_position.position += Vector3.back * Time.deltaTime;
        }
        else if (_dropdown.value == station3)
        {
            train_position.position = GameObject.Find("Stazione_3").GetComponent<Transform>().position + (Vector3.right * 1.5f);
            //train_position.position += Vector3.back * Time.deltaTime;
        }
        else
        {
            train_position.position += Vector3.back * Time.deltaTime; 
        }
    }

    public static int GetIndexByName(Dropdown dropDown, string name)
    {
        if (dropDown == null) { Debug.Log("dropdown null"); return -1; } // or exception
        if (string.IsNullOrEmpty(name) == true) { return -1; }
        List<Dropdown.OptionData> list = dropDown.options;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].text.Equals(name)) { return i; }
        }
        return -1;
    }
}
