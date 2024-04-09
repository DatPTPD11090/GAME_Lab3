using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Infomation : MonoBehaviour
{
    public Text info;
    string name = "Dat Phan MU";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        info.text = "Ten nguoi choi " + name;
    }
}
