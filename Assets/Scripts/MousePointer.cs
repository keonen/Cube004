using UnityEngine;
using System.Collections;

public class MousePointer : MonoBehaviour 
{
	public Texture2D cursorImage;
	
	private int cursorWidth = 32;
	private int cursorHeight = 32;
	
	void Start()
	{
		Cursor.visible = false;
		//Screen.showCursor = false;
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{			
			Application.LoadLevel(Application.loadedLevel);
		}
		
		if (Input.GetKeyDown(KeyCode.L))
		{			
			Cursor.lockState = CursorLockMode.Locked;
		}
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{			
			Cursor.lockState = CursorLockMode.None;
		}

		if (Input.GetKeyDown(KeyCode.O))
		{			
			Cursor.lockState = CursorLockMode.None;
		}

		if (Input.GetKeyDown(KeyCode.Q))
		{			
			Application.Quit();
		}
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x - 16, Screen.height - Input.mousePosition.y - 16, cursorWidth, cursorHeight), cursorImage);
	}
}
