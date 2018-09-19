using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrangeActions : MonoBehaviour
{

    private RectTransform panelRectTransform;
    public GameObject thisObject;

    // Use this for initialization
    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
        thisObject = GetComponent<GameObject>();
    }


}