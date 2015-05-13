using UnityEngine;
using System.Collections;

public class BattleSystem : MonoBehaviour {

	public int health;
	public int damage;

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () 
	{
		if (GetComponent("BattleSystem").enabled = true)
		{
			GetComponent("PlayerMovement").enabled = false;
		}
		elif (GetComponent ("BattleSystem").enabled = false)
		{
			GetComponent("PlayerMovement").enabled = true;
		}
	}

	void Battle()
	{
		while(health > 0)
		{
			Random rnd = new Random();
			int question = rnd.Next(0,number_of_questions);


		}
	}
}
