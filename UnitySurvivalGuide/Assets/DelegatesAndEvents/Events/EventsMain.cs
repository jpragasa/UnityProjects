using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsMain : MonoBehaviour
{

    public delegate void ActionClick();
    public static event ActionClick onClick;
    // Events are similar to delegates, they allow users to subscribe or unsubscribe from a delegate
    // When having an object subscribe to an event, always ensure to implement a way for the object to unsubscribe when destroyed.
    // When subscribing to the event, the class trying to subscribe should be adding a method SIMILAR to the delagate, cannot be different.
    public void ButtonClick()
    {
        // Turn all cubes red
        if(onClick != null)
        {
            onClick();
        }
       
    }
}
