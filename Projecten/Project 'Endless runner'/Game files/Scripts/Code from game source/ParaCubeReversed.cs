﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaCubeReversed : MonoBehaviour
{
    public int _band;
    public GameVariables gameVariables;
    public ParaCubeData[] difficultyData;

    [System.Serializable]
    public class ParaCubeData
    {
        public float scaleMultiplier;
        public float startScale;
        public bool useBuffer;
    }
    void Awake()
    {
        gameVariables = GameObject.Find("GameController").GetComponent<GameVariables>();
    }

    void Update()
    {
        if (difficultyData[gameVariables.difficultyValue].useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (NewAudioPeer._bandBuffer[_band] * -difficultyData[gameVariables.difficultyValue].scaleMultiplier) + difficultyData[gameVariables.difficultyValue].startScale, transform.localScale.z);
        }
        if (!difficultyData[gameVariables.difficultyValue].useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (NewAudioPeer._freqBand[_band] * -difficultyData[gameVariables.difficultyValue].scaleMultiplier) + difficultyData[gameVariables.difficultyValue].startScale, transform.localScale.z);
        }
    }
}


