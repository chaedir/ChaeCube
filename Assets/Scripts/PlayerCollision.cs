using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement Movement;

    void OnCollisionEnter(Collision collision) // OnCollisionEnter, ialah apabila objek yg ditempatkan script ini
                                               // mengalami benturan. Collision collision digunakan untuk mendapat
                                               // informasi tentang objek yang disentuh. 
                                               // sehingga pada keterangan di bawah memperlihatkan apabila objek 
                                               // dengan informasi collider yang ber tag Rintangan disentuh maka
                                               // Player movement akan disable.
    {
        if (collision.collider.tag == "Rintangan")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().RestarLevel();
        }        
    }

    void OnTriggerEnter ()
    {
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
