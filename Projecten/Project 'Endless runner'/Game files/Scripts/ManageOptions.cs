﻿using UnityEngine;
using UnityEngine.UI;

public class ManageOptions : MonoBehaviour
{
    public Dropdown musicDropDown;
    public GameVariables gameVariables;

    void Start()
    {
        musicDropDown = this.GetComponent<Dropdown>();

        for (int i = 0; i < gameVariables.resourceClips.Length; i++)
        {
            musicDropDown.options.Add(new Dropdown.OptionData(gameVariables.resourceClips[i].name));
        }
    }
}
    