using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum Artefakt
{
    Schere,
    Stein,
    Papier

}

public class Manager : MonoBehaviour
{
    //Struktur die man mit (public Artefakt artefakt) aufrufen kann und hinter den drei woertern schere stein papier steh eine
    //zahl es startet bei null man kann aber wenn man fixe zahlen moechte zuweisen
    //Schere = 12,
    //Stein = 13,
    //Papier = 9
    //if (artefakt == Artefakt.Schere)

    [SerializeField] private Image computer, player;
    [SerializeField] TextMeshProUGUI ausgangstext;
    [SerializeField] int PlayerWon = 0;
    [SerializeField] int ComputerWon = 0;
    [SerializeField] int Insgesamt = 0;
    


    /*
        Bei BTN Press: Schere Stein Papier spielen      fertig
        P Random Schere Stein Papier wählen             fertig
        C Random Schere Stein Papier wählen             fertig
        Auswerten wer gewonnen hat
        Msg hinschreiben wer gewonnen hat
    */

    public void PlayGame()
    {
        //Debug.Log("Gedrückt");
        //Schere Rot (0), Papier Grün (1), Stein Blau (2)
        computer.GetComponent<Image>().color = Color.red;
        player.color = Color.blue;
        Insgesamt = Insgesamt + 1;

        int rndP = Random.Range(0, 3);
        int rnd = Random.Range(0, 3);


        Artefakt artefakt = Artefakt.Schere;

        if (artefakt == Artefakt.Schere)
        {
            computer.color = Color.red;
            if (rndP == 0)
            {
                //Debug.Log("Schere und Schere");
                //Debug.Log("Unentschieden");
                ausgangstext.text = "Versuchs noch einmal";
                
            }

            else if (rndP == 1)
            {
                //Debug.Log("Schere und Papier");
                //Debug.Log("Player Verliert");
                ausgangstext.text = "Ein Punkt für den Computer";
                ComputerWon = ComputerWon + 1;

            }

            else if (rndP == 2)
            {
                //Debug.Log("Schere und Stein");
                //Debug.Log("Computer Verliert");
                ausgangstext.text = "Ein Punkt für den Player";
                PlayerWon = PlayerWon + 1;

            }
        }

        if (artefakt == Artefakt.Papier)
        {
            computer.color = Color.green;
            if (rndP == 0)
            {
                //Debug.Log("Papier und Schere");
                //Debug.Log("Player gewinnt");
                ausgangstext.text = "Ein Punkt für den Player";
                PlayerWon = PlayerWon + 1;

            }

            if (rndP == 1)
            {
                //Debug.Log("Papier und Papier");
                //Debug.Log("Unentschieden");
                ausgangstext.text = "Versuchs noch einmal";

            }

            if (rndP == 2)
            {
                //Debug.Log("Papier und Stein");
                //Debug.Log("Player Verliert");
                ausgangstext.text = "Ein Punkt für den Computer";
                ComputerWon = ComputerWon + 1;

            }
        }

        if (artefakt == Artefakt.Stein)
        {
            computer.color = Color.blue;
            if (rndP == 0)
            {
                //Debug.Log("Stein und Schere");
                //Debug.Log("Computer gewinnt");
                ausgangstext.text = "Ein Punkt für den Computer";
                ComputerWon = ComputerWon + 1;

            }

            if (rndP == 1)
            {
                //Debug.Log("Stein und Papier");
                //Debug.Log("Player gewinnt");
                ausgangstext.text = "Ein Punkt für den Player";
                PlayerWon = PlayerWon + 1;

            }

            if (rndP == 2)
            {
                //Debug.Log("Stein und Stein");
                //Debug.Log("Unentschieden");
                ausgangstext.text = "Versuchs noch einmal";

            }
        }



            if (rndP == 0)
            {
                player.color = Color.red;
            }

            if (rndP == 1)
            {
                player.color = Color.green;
            }

            if (rndP == 2)
            {
                player.color = Color.blue;
            }


            if (Insgesamt == 5)
            {
                if (ComputerWon > PlayerWon)
                {
                    //Debug.Log("Compi hat gewonnen");
                    ausgangstext.text = "Der Computer Hat Gewonnen :))";
                }
                else if (ComputerWon < PlayerWon)
                {
                    //Debug.Log("hi");
                    ausgangstext.text = "Der Player Hat Gewonnen :))";
                }
                else
                {
                    //Debug.Log("Keiner hat gewonnen");
                    ausgangstext.text = "Keiner Hat Gewonnen :((";
                }


                //Debug.Log("Funktianiert");
                Insgesamt = 0;
            }
                

    }   
}
    
