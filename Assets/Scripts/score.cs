using UnityEngine;
using UnityEngine.UI; // ini digunakan untuk mengambil settingan dari variable UI

public class score : MonoBehaviour {

    public Transform player; // untuk mengambil properti transform dari objek yang akan di ambil
    public Text scoreText; /* variable "Text" tidak dapat di ambil apabila perintah "using UnityEngine.UI;"
    tidak dimasukkan terlebih dahulu.*/

    void Update () {
        scoreText.text = player.position.z.ToString("0");
		
	}
}
