using UnityEngine;

public class Test : MonoBehaviour
{

    int monedas = 1;
    
    void Start()
    {
       
    }

    void Update()
    {      
        GanarMonedas();
    }   

    void GanarMonedas()
    {
        monedas++;
        Debug.Log("Recolecte: "+monedas+" monedas");
    }

}
