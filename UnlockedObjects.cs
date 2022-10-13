using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour
{
    public int SubaruSelect;
    public GameObject SubaruBlocker;
    // Start is called before the first frame update
    void Start()
    {
        SubaruSelect = PlayerPrefs.GetInt("SubaruBought");
        if (SubaruSelect ==100)
        {
            SubaruBlocker.SetActive(false);
        }
    }


}
