using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepOnFloor : MonoBehaviour
{
    [SerializeField]
    private DragAndDrop draggableObject;

    [SerializeField]
    private MouseTypeEvent mouseEvent;

    //[SerializeField]
    //private DragAndDrop floorDraggable;
    Plane plane;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        draggableObject.OnStartDragging += OnStartDragging;
        draggableObject.OnDragging += OnDragging;
    }

    private void OnDisable()
    {
        draggableObject.OnStartDragging -= OnStartDragging;
        draggableObject.OnDragging -= OnDragging;
    }

    private Vector3 relativePosition;
    private Vector3 relativeHeight;
    private float height;

    private void OnStartDragging(object sender, Vector3 worldPosition)
    {
        relativePosition = draggableObject.transform.position - worldPosition;
        plane = new Plane(Vector3.up, worldPosition.y * Vector3.up);
        Debug.Log($"Height is {worldPosition.y}");
    }

    private void OnDragging(object sender, Vector3 worldPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(mouseEvent.ScreenPosition());
        if (plane.Raycast(ray, out float enter)) {
            Vector3 position = relativePosition + ray.GetPoint(enter);
            position.x = Mathf.Clamp(position.x, -4.5f, 4.5f);
            position.z = Mathf.Clamp(position.z, -4.5f, 4.5f);
            draggableObject.transform.position = position;
        }
    }

    void Update()
    {
        
    }
}
