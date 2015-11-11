using UnityEngine;
using System.Collections;

public class Messaging : MonoBehaviour {

	public void Message(int chapter){
		switch (chapter) {
		case 0:{
			Debug.Log("Message");
			break;
		}
		case 2:{
			Debug.Log("Message2");
			break;
		}
		case 4:{
			Debug.Log("Message3");
			break;
		}
		}

	}
	
}
