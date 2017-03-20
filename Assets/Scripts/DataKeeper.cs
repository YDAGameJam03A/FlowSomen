using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class DataKeeper {
    static GAMEDIFFCULT gameDiffcult;
    static public GAMEDIFFCULT gamediffcult
    {
        get
        {
            return gameDiffcult;
        }
        set
        {
            gameDiffcult = gamediffcult;
        }
    }

    static int Score;
    static public int score
    {
        get
        {
            return Score;
        }
        set
        {
            Score = score;
        }

    }

    static void ResetScore()
    {
        Score = 0;
    }
}
