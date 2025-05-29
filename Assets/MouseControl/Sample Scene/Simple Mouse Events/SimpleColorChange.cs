using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleColorChange : MonoBehaviour
{

    [SerializeField]
    private MouseTypeEvent mouseEvent;

    [SerializeField]
    private Renderer changeOnClick;
    private bool selected = false;
    [SerializeField]
    private Renderer changeOnMouseOver;
    private bool mouseOver = false;

    [SerializeField]
    private Material defaultMaterial;
    [SerializeField]
    private Material activeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        changeOnClick.sharedMaterial = defaultMaterial;
        changeOnMouseOver.sharedMaterial = defaultMaterial;
    }

    private void OnEnable()
    {
        mouseEvent.OnObjectSelect += OnObjectSelect;
    }

    private void OnDisable()
    {
        mouseEvent.OnObjectSelect -= OnObjectSelect;
    }

    private void OnObjectSelect(object sender, Transform obj)
    {
        if (changeOnClick.transform == obj)
        {
            changeOnClick.sharedMaterial = (selected) ? defaultMaterial : activeMaterial;
            selected = !selected;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Transform obj = mouseEvent.ObjectAtMousePosition();
        if (obj == changeOnMouseOver.transform)
        {
            if (!mouseOver)
            {
                changeOnMouseOver.sharedMaterial = activeMaterial;
            }
            mouseOver = true;
        } else
        {
            if (mouseOver)
            {
                changeOnMouseOver.sharedMaterial = defaultMaterial;
            }
            mouseOver = false;
        }

    }
}
