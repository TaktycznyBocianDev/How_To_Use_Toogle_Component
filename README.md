
#  How to use Toggle Component

This little project is my way to learn how to use Toggle Component in Unity. As I was working on my other projects, I just came across this feature and I try it out.

Now it is also my test GitHub project to try making README actually something somebody wants to read.






## Lessons Learned

Toggles brought my attention after I made one of my games without them. Of course, with them, I would save like few hours of my precious time, but, at least I will remember them.

Using them as a way to give the player a clear select option, instead of doing it by buttons, will now become my common practice. 

It's worth mentioning that I learned from this tutorial:
https://www.youtube.com/watch?v=XXeGLwPMmR8

The rest of the project have only one button and panel, so it is really nothing special.



## One Code to rule them all!

```javascript
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class RadioBtn : MonoBehaviour
{
    private ToggleGroup toggleGroup;
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }
    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault(); 
        //This one scans group for the one toogle that is enabled.

        //Some Test Debugs, pointing that we can easily access active toggle
        Debug.Log(toggle);
        Debug.Log(toggle.name);
    }
}

