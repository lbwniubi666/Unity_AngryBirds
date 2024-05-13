using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadlevel : MonoBehaviour
{
    private void Awake()
    {
        var level = Resources.Load(PlayerPrefs.GetString("nowLevel"));
        if (level != null)
        {
            Instantiate(level); //加载游戏关卡
        }
        else
        {
            Debug.LogError("Level not found");
        }
    }
}
