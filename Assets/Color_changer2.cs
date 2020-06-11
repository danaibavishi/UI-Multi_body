using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_changer2 : MonoBehaviour
{
	public OSC osc;
    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler( "/wek/outputs" , User_2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void User_2(OscMessage message)
    {
    	float y = message.GetFloat(1);

    	if (y==1)
    	{
    		//Change color to Red
    		GetComponent<Image>().color = Color.red;
    	}
    	else if (y==2)
    	{
    		//Change color to Blue
    		GetComponent<Image>().color = Color.blue;
    	}
    	else if (y==3)
    	{
    		//Change color to Green
    		GetComponent<Image>().color = Color.green;
    	}
    	else if (y==4)
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

