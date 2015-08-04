using UnityEngine;
using System.Collections;

public class SpawnLegoCubes : MonoBehaviour {

	public GameObject peliobjekti_1;
	public GameObject peliobjekti_2;
	public GameObject peliobjekti_3;

	// Use this for initialization
	void Start () 
	{
		for (int y = 0; y < 9; y++) {
			for (int x = 0; x < 7; x++) {
				float spawnHeight = 0.51f;
				float spawnWidth = 0.64f;
				if (y % 6 == 0)
				{
					Instantiate(peliobjekti_1, new Vector3(spawnWidth * x + 250f, spawnHeight * y + 0.5f, 250f), Quaternion.identity);
					Instantiate(peliobjekti_1, new Vector3(250 - 0.16f, spawnHeight * y + 0.5f, spawnWidth * x + 250.50f), Quaternion.Euler(0, 90, 0));
				}
				else if (y % 6 == 1)
				{
					Instantiate(peliobjekti_2, new Vector3(spawnWidth * x + 250.32f, spawnHeight * y + 0.5f, 250f), Quaternion.identity);
					Instantiate(peliobjekti_2, new Vector3(250 - 0.16f, spawnHeight * y + 0.5f, spawnWidth * x + 250.16f), Quaternion.Euler(0, 90, 0));
				}
				else if (y % 6 == 2)
				{
					Instantiate(peliobjekti_3, new Vector3(spawnWidth * x + 250, spawnHeight * y + 0.5f, 250), Quaternion.identity);
					Instantiate(peliobjekti_3, new Vector3(250 - 0.16f, spawnHeight * y + 0.5f, spawnWidth * x + 250.50f), Quaternion.Euler(0, 90, 0));
				}
				else if (y % 6 == 3)
				{
					Instantiate(peliobjekti_1, new Vector3(spawnWidth * x + 250.32f, spawnHeight * y + 0.5f, 250), Quaternion.identity);
					Instantiate(peliobjekti_1, new Vector3(250 - 0.16f, spawnHeight * y + 0.5f, spawnWidth * x + 250.16f), Quaternion.Euler(0, 90, 0));
				}
				else if (y % 6 == 4)
				{
					Instantiate(peliobjekti_2, new Vector3(spawnWidth * x + 250, spawnHeight * y + 0.5f, 250), Quaternion.identity);
					Instantiate(peliobjekti_2, new Vector3(250 - 0.16f, spawnHeight * y + 0.5f, spawnWidth * x + 250.50f), Quaternion.Euler(0, 90, 0));
				}
				else if (y % 6 == 5)
				{
					Instantiate(peliobjekti_3, new Vector3(spawnWidth * x + 250.32f, spawnHeight * y + 0.5f, 250), Quaternion.identity);
					Instantiate(peliobjekti_3, new Vector3(250 - 0.16f, spawnHeight * y + 0.5f, spawnWidth * x + 250.16f), Quaternion.Euler(0, 90, 0));
				}
			
			}
		}
	
	}
		
	// Update is called once per frame
	void Update () 
	{

	}
}
