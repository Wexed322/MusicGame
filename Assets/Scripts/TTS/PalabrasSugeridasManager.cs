using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class PalabrasSugeridasManager : MonoBehaviour
{
    public PalabrasSugeridas currentPalabrasSugueridas;
    public TMP_InputValidator validator;
    public TMP_InputField inputField;


    public List<string> totalWordsInput;


    public string test;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            checkWords(inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.U)) 
        {
            checkOneWord(ref test);
        }

    }
    public void checkOneWord(ref string entrada) 
    {
        int cantidadDeDigitos = entrada.Length;
        int current = 0;
        int next = 1;

        while (next< cantidadDeDigitos)
        {
            if (entrada[current] == entrada[next])
            {
                entrada = entrada.Remove(next,1);
            }
            else 
            {
                current++;
                next++; 
            }
        }

    }
    public void checkWords(string text_input)
    {
        text_input = text_input.Replace(",", "");
        text_input = text_input.Replace(" ", "#");
        text_input = text_input.Replace("\n", "#");

        totalWordsInput = text_input.Split("#").ToList();

        for (int i = 0; i < totalWordsInput.Count; i++)
        {
  
        }



        //comrpobacion
        for (int i = 0; i < totalWordsInput.Count; i++)
        {
            if (currentPalabrasSugueridas.palabras.Contains(totalWordsInput[i]))
            {
                Debug.Log(totalWordsInput[i] + " Esta dentro de la lista");

            }

        }

    }
}
