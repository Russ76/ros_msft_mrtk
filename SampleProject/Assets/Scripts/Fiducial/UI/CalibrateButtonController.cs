﻿using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalibrateButtonController : MonoBehaviour
{
    public MeshRenderer buttonMesh;

    public Material enabledMat;
    public Material disabledMat;

    public Interactable buttonLogic;

    private bool state;

    private void Start()
    {
        if (buttonMesh == null)
        {
            Debug.LogError("CalibrateButtonController is missing a buttonMesh");
        }

        if (enabledMat == null)
        {
            Debug.LogError("CalibrateButtonController is missing a enabledMat");
        }

        if (disabledMat == null)
        {
            Debug.LogError("CalibrateButtonController is missing a disabledMat");
        }

        if (buttonLogic == null)
        {
            Debug.LogError("CalibrateButtonController is missing a buttonLogic");
        }

        UpdateState(false);
    }

    public void UpdateState(bool state)
    {
        this.state = state;

        buttonMesh.material = state ? enabledMat : disabledMat;

        buttonLogic.enabled = state;
    }

    public void Foo()
    {
        Debug.Log("wahoodofjdslkfj");
    }
}