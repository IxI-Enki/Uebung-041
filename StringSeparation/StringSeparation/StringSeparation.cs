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
      string userInput, textCache, splitCache = "";    //
      char userSplit, splitChar;                       //  
      int index;                                       //
      bool abort = false;                              //

      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n                 String Separation                   " +
      /* cWidth: */ "\n=====================================================");

      /*---[in:]-------------------- PROMPT_USER ----------------------------*/
      Console.Write("\n Geben Sie den Text ein, den Sie aufsplitten wollen:" +
                    "\n →  ");
      do    //----------------------- GET_INPUT_STRING ----------------------//
      {                                                                      //
        userInput = Console.ReadLine();    //  text to split + [enter]       //
        textCache = userInput;             //  📌 cache input                //  
        abort = (textCache.Length > 1) ? false : true;    // length>1(t:f) = abort(❌:✔) 
        if (abort)                                 //  if abort = [✔]        //
        {                                          //____________ ⨽⇣⨼ _______//
          Console.Write($"\n Ihre Eingabe: '{textCache}' ist unteilbar." +   //
                        $"\n Wiederholen Sie die Eingabe:" +    // ⇣         //
                        $"\n →  ");                             // ⇣         //
        }                                                       // ⇣ ________//
      } while (abort);    //------------------------------------// 🔄 repeat INPUT if abort = ✔

      /*--------------------------- GET_INPUT_CHAR --------------------------*/
      Console.Write("\n Wählen Sie das Zeichen an dem gesplittet werden soll:" +
                    "\n →  ");                //  
      splitChar = Console.ReadKey().KeyChar;  //  char✂to✂split 

      /*===[calc:]===========================================================*/
      for (index = 0; textCache.Length > index; index++)                     // i++ for every char∈input
      {                                                                      //
        splitCache = "";                                   // 🗑 empty cache
        while (textCache[index] != splitChar && !abort)    // while abort = [❌]
        {                                                  //                 ⇣
          if (textCache.Length != index)    //-------------- length > i --- either
          {                                                //    ⨽  ⇣  ⨼      ⇣
            splitCache = splitCache + textCache[index];    // - cache char[i] ⇣
            index++;                                       // - i++           ⇣
          }                                 //------------------------------ or
          else                                             //                 ⇣
          {                                                //                 ⇣
            splitCache = splitCache + textCache[index];    // - add char[i] to cache
            abort = true;                                  // - abort = [✔]  ⇣
          }                                                //                //
        }    //--------------------------------------------------------------//  
                                                                             //
        //---[out:]-------------------- SOLUTION ----------------------------//
        Console.Write($"\n {splitCache} ");                                  // tell solution                
      }    /*================================================================*/

      /*-------------------------------- END --------------------------------*/
      Console.Write("\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}