using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDatas {
    protected float spawnLag = 0.0f;
    protected int noodleNum = 0;
    protected float holdTime = 0.0f;

    public int noodlenum{
        get
        {
            return noodleNum;
        }
        set
        {
            noodleNum = noodlenum;
        }
    }

    public float spawnlag
    {
        get
        {
            return spawnLag;
        }
    }

    public float holdtime
    {
        get
        {
            return holdTime;
        }
    }
}
