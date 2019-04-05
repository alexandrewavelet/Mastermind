using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IHasChanged
{
    [SerializeField] Transform slots;

    // Use this for initialization
    void Start()
    {
        HasChanged();
    }

    public void HasChanged()
    {

    }

}


namespace UnityEngine.EventSystems
{
    public interface IHasChanged : IEventSystemHandler
    {
        void HasChanged();
    }
}