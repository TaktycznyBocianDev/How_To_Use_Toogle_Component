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
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault(); //This one scans group for the one toogle that is enabled.

        //Some Test Debugs
        Debug.Log(toggle);
        Debug.Log(toggle.name);
    }
}
