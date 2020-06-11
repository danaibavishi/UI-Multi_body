using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_changer : MonoBehaviour
{
	public OSC osc;
    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler( "/wek/outputs" , User_1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void User_1(OscMessage message)
    {
    	float x = message.GetFloat(0);

    	if (x==1)
    	{
    		//Change color to Red
    		GetComponent<Image>().color = Color.red;
    	}
    	else if (x==2)
    	{
    		//Change color to Blue
    		GetComponent<Image>().color = Color.blue;
    	}
    	else if (x==3)
    	{
    		//Change color to Green
    		GetComponent<Image>().color = Color.green;
    	}
    	else if (x==4)
    	{
    		//Change color to Yellow
    		GetComponent<Image>().color = Color.yellow;
    	}
    	else
    	{
    		//Change color to Purple
    		GetComponent<Image>().color = Color.black;
    	}
    }
}
