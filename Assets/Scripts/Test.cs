using UnityEngine;

public class Test : MonoBehaviour
{

    int monedas = 1;//variable creada para la recolecciòn
    
    void Start()
    {
       //Aqui deberia inicializar los stats del jugador
    }

    void Update()
    {      
        GanarMonedas();
        //MovimientoJugaod();
        //DisparoArma();
    }   

    void GanarMonedas()
    {
        monedas++;
        Debug.Log("Recolecte: "+monedas+" monedas");
    }

}
