using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public int Points;

    // we need to defined a GUIStyle profile for our graphical user interface (GUI) that shows the value of points to change its font size, shape, etc.
    public GUIStyle PointStyle;

    // this is the default unity graphical user interface (GUI) function. It will render GUI elements on the screen on a specific 2D coordinate 
    private void OnGUI()
    {
        // a GUI label to show the value of the aggregated points, place at the X=10, Y=10 coordinates, with width and height of 100, the next argument is the content that the label shows which is in this case
        // a numerical value. we need to convert the numerical value to a string (text) to be able to show it on the label. The last argument indicates which GUIStyle profile should be used for this label
        GUI.Label(new Rect(10,10,100,100),Points.ToString(),PointStyle);
    }
}
