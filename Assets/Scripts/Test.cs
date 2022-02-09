using UnityEngine;

public class Test : MonoBehaviour
{

    int monedas = 1;//variable creada para la recolecciòn
    
    int ladrillos = 0;
    void Start()
    {
       //Aqui deberia inicializar los stats del jugador
    }

    void Update()
    {      
        GanarMonedas();
        //MovimientoJugaod();
        //DisparoArma();
        RecolectarLadrillos();
    }   

    void GanarMonedas()
    {
        monedas++;
        Debug.Log("Recolecte: "+monedas+" monedas");
    }

    void RecolectarLadrillos()
    {
        ladrillos++;
        Debug.Log("Adrian esta recolectando :" + ladrillos+" ladrillos");
    }

}
