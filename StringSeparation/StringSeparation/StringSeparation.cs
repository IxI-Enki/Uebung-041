/*-----------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                          
 *-----------------------------------------------------------------------------
 *                      Jan Ritt                                               
 *-----------------------------------------------------------------------------
 *  Description:  split a sentence @ a user given split-word 
 *-----------------------------------------------------------------------------
*/

/*_________________________________libraries_________________________________*/
using System;                   //  
using System.Text;              //  Unicode Symbols
using System.Threading;         //  Thread.Sleep(1000) = 1 sec

/*---------------------------------- START ----------------------------------*/
namespace StringSeparation  //  
{                           //
  public class Program      //
  {                         //
    static void Main()      //
    {
      ///*----------------------- console_settings ------------------------*///
      const int cWidth = 53;                     //  console width
      const int cHeight = 30;                    //  & height
      Console.SetWindowSize(cWidth, cHeight);    //
      Console.OutputEncoding = Encoding.UTF8;    //  Unicode Symbols

      /*----------------------------- VARIABLES -----------------------------*/
      string userInput, textCache,                     //
             splitCache = "";                          //
      char splitChar;                                  //  
      int index;                                       //
      bool abortInput = false,                         //  abort condition for input
           abortSplit = true;                          //  abort condition if SplitChar is not found in Text

      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n                 String Separation                   " +
      /* cWidth: */ "\n=====================================================");

      /*---[IN:]-------------------- PROMPT_USER ----------------------------*/
      Console.Write("\n Geben Sie den Text ein, den Sie aufsplitten wollen:" +
                    "\n →  ");
      do    //----------------------- GET_INPUT_STRING ----------------------//
      {                                                                      //
        userInput = Console.ReadLine();                                      //  text to split + [enter]
        textCache = userInput;                                               //  safe input to cache     
        abortInput = (textCache.Length > 1) ? false : true;                  //
        if (abortInput)                                                      //
        {                                                                    //
          Console.Write($"\n Ihre Eingabe: '{textCache}' ist unteilbar." +   //
                        $"\n Wiederholen Sie die Eingabe:" +                 //
                        $"\n →  ");                                          //
        }                                                                    //
      } while (abortInput);                                                  //  repeat INPUT if abortInput = true

      //--------------------------- GET_INPUT_CHAR --------------------------//
      Console.Write("\n Wählen Sie das Zeichen an dem gesplittet werden soll:" +
                    "\n →  ");                                               //
      splitChar = Console.ReadKey().KeyChar;                                 //  char ✂ to ✂ split


      //===[CALC:]===========================================================//  test if SplitChar is present in Text
      index = 0;                                                             //
      while ((index + 1) < textCache.Length && (abortSplit == true))         //
      {                                                                      //
        abortSplit = (textCache[index] == splitChar) ? false : true;         //
        index++;                                                             //
      }                                                                      //
      Console.Write($"\n Das Split-Zeichen '{splitChar}' wurde {(abortSplit ? "nicht gefunden" : "gefunden")} " +
                     "\n -----------------------------------------------------" +
                     "\n ");                                                 //
      if (abortSplit == false)                                               //
      {                                                                      //
        // Console.Write("weiter");                                          //
        index = 0;                                                           //
        while ((index + 1) <= textCache.Length)                              //
        {                                                                    //
          if (splitChar != textCache[index])                                 //
          {                                                                  //
            splitCache = splitCache + textCache[index];                      //
            index++;                                                         //
          }                                                                  //
          else                                                               //
          {                                                                  //
            Console.Write($"\n {splitCache} ");                              //
            splitCache = "";                                                 //
            index++;                                                         //
          }                                                                  //
        }                                                                    //
        Console.Write($"\n {splitCache} ");                                  //
      }                                                                      //
      /*-------------------------------- END --------------------------------*/
      Console.Write("\n=====================================================" +
                    "\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}
