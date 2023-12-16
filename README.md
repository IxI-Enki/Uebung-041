<!--              READE -> VORLAGE Uebungen: Programmieren & Software Engineering              -->

# Uebung-*041*  --  [*String Separation*]()  

<!-- ---------------------------------------------|-------------------------------------------- -->
###### 📎[**Angabe**](https://github.com/IxI-Enki/Uebung-041/work-directory/41-SimpleSplit.pdf) *.pdf*
<sup><sub> 
--- 
</sub></sup>

<!-- ---------------------------------------------|-------------------------------------------- -->
## 📊 Lernziele:  
-  ↳ Stringbearbeitung  
<!--     >  <sub> [..*weiterführende Quelle*..] </sub> [ **¹** ]()

<!--
<sup><sub> </sub></sup>
---

  
## ✅ Vertiefung:  
  > ↳ `◌ Punkte einfügen`  
  > ↳ ` ⋯ `  
  >  ..
  >  <sub> [..*weiterführende Quelle*..] </sub> [ **²** ]()

-->
---
<!-- ---------------------------------------------|-------------------------------------------- -->
## 🧮 **Aufgabenstellung:**  
- Schreiben Sie ein Programm, welches vom Benutzer einen beliebigen Text und ein weiteres Zeichen „Split“ einliest.  
- Anschließend splitten Sie den eingegebenen Text, nach jedem Vorkommen des Zeichens „Split“ im Text auf.
<!--  >  <sub> [..*weiterführende Quelle*..] </sub> [ **³** ]() -->

---
 
<!-- ---------------------------------------------|-------------------------------------------- -->
## 🔎 **Ausgabe** <sub>*Bsp.*</sub> 


   |   *Benutzerschnittstelle* :    |
   | :-----------------------------------------------------------------------------------------------------------------: |
   |  ![**Ausgabebeispiel 📎**](https://github.com/IxI-Enki/Uebung-041/assets/138018029/e56fe121-f1a6-4d99-a302-7f2b91cbd291)
<!--  > <sub> [..*weiterführende Quelle*..] </sub> [ **⁴** ]() -->

---
<!-- ---------------------------------------------|-------------------------------------------- -->
## 🧩 **Hinweis** / <sub>Ablauf</sub> 🧠<sup>💭</sup>  


 
 ### *Ablauf:*               
            
  **⒈**)  Die ***Benutzereingaben dürfen*** im gesamten Programm ***nicht verändert werden*** und müssen erhalten bleiben.     

  **⒉**)  Zur Lösung dieser Aufgabe dürfen Sie ***nicht die Standard-Methoden von String verwenden***! 
     
 <!--  >  <sub> [..*weiterführende Quelle*..] </sub> [ **⁵** ]()  -->

 ---

<!-- ---------------------------------------------|-------------------------------------------- -->

# *SPOILER* <sub><sup> → [*Lösung*](https://github.com/IxI-Enki/Uebung-041/blob/main/StringSeparation/StringSeparation/StringSeparation.cs) <sup></sub>:




### 🖥 **Ausgabe**: 
   |            * meine Ausgabe: *  |   
   |--------------------------------|
   |  ![**Ausgabe 📎**](https://github.com/IxI-Enki/Uebung-041/assets/138018029/c3f89232-87fd-4222-a15d-6a1a6b30793c)  |

<!--> <sub> [..*weiterführende Quelle*..] </sub> [ **⁶** ]()-->

---

## 💾 `C#` - *Programm*:
 <details><summary>👉 ausklappen 👈 </summary>


 ```c#
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

```
> <sub> [..*weiterführende Quelle*..] </sub> [ **⁷** ]()

</dertails>

-->
