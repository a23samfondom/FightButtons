using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EventSystemController : MonoBehaviour
{
    [SerializeField] Button firstButton;
    

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null) { firstButton.Select(); }
    }
}
