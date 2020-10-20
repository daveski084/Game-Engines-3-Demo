
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.SceneManagement;

public class SavePlayerPosition : MonoBehaviour
{
    public float x,
                 y,
                 z;

    public void Save()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }

    public void Load()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 playerLoadLocation = new Vector3(x, y, z);
        transform.position = playerLoadLocation;
    }
}
