using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class SpecificStationDropdownScript : MonoBehaviour {

    public GameObject station;
    public Dropdown dropdown;
    public RectTransform imagePanel;

	// Use this for initialization
	void Start () {
        dropdown.onValueChanged.AddListener(delegate {
            dropDownValueChangedHandler();
        });
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void dropDownValueChangedHandler()
    {
        //imagePanel.GetComponentInChildren<Image>().sprite = station.GetComponent<ARObject>().m_images[dropdown.value];

    }

    public void fillOptions()
    {

    }
}
