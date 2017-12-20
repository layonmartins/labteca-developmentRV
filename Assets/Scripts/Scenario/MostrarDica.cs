using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarDica : MonoBehaviour {

    public Canvas dicaFinal;

    public void ChamarMostrarDica()
    {
        StartCoroutine(mostrarDica());
    }

    IEnumerator mostrarDica()
    {
        Debug.Log("chamou Mostrar dica");
        yield return new WaitForSeconds(2);
        Debug.Log("travou");
        dicaFinal.GetComponent<CanvasGroup>().alpha = 1f;
    }
	
	
}
