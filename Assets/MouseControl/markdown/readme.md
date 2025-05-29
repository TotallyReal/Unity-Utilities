Use to generate mouse event plus raycasting them on screen to see what they press.
## `MouseTypeEvent`
This is the main script which generates mouse events:
- `OnObjectSelect(Transform)`: Invoked when an object with a collider is pressed.
- `OnObjectSelectedPlus(Transform, Vector3)` : As above, but also provide the point in space where the object was pressed.
In general this script can also be used to find the current object + position the mouse pointing at (and not just when clicked).

For the default mouse event, you can use the prefab `DefaultMouseInput`.

# `DragAndDrop`
Used to generate event for drag and drop.

# Scenes:

There are 3 sample scenes:
1. **Simple mouse events**: Change color of an object by pressing on it \ mouse over it.
2. **Drag and drop**: Drag a cube along a plane.
3. **Rotational dragging**: Using the drag and drop mechanism to rotate objects.

# Dependencies

To use, you should install the new input system package. Also, for the sample scene, I use the [DOTween plugin](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676).