using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Proyecto
{
    class Analizador
    {
        int state = 0;
        string lexema = "";
        int num = 0;
        int numerr = 0;
        int fila = 1;
        int columna=0;
        
        public List<Datos> arregloToken = new List<Datos>();
        public List<Datos> arregloError = new List<Datos>();
       
        
        public List<Datos> getArrT() {
            return arregloToken;
        }
        public void setAT(List<Datos> arregloToken) {
            this.arregloToken=arregloToken;
        
        }
        public List<Datos> getArrE()
        {
            return arregloError;
        }
        public void setAE(List<Datos> arregloError)
        {
            this.arregloError = arregloError;

        }
        

//------------------------------Metodo analizar-------------------------------------
        public string lexico(string entrada)
        {

            string texto = entrada;
            Char[] cadena = texto.ToCharArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == 10)
                {
                    fila++;
                    columna = 0;
                }
                else
                {
                    columna++;
                }

                switch (state){
                       
        //-----------------Estado 0----------------------------------------------------------------------

                    case 0:
                        if (Char.IsLetter(cadena[i]))
                        {
                            lexema = lexema + cadena[i];
                            state = 1;               
                        }
                        else if(Char.IsDigit(cadena[i]))
                        {
                            lexema = lexema + cadena[i];
                            state = 2;
                        }
                        else if (cadena[i] == 61)
                        {
                            lexema = lexema + cadena[i];
                            state = 3;


                        }
                        else if (cadena[i] == 35)
                        {
                            lexema = lexema + cadena[i];
                            state = 3;


                        }
                        else if (cadena[i] == 34)
                        {
                            lexema = lexema + cadena[i];
                            state = 3;


                        }
                        else if (cadena[i] == 47 )
                        {
                            lexema = lexema + cadena[i];
                            state = 12;
                            

                        }
                        else if (cadena[i] == 42)
                        {
                            lexema = lexema + cadena[i];
                            state = 15;


                        }
                        else if (cadena[i] == 32 || cadena[i] == 10 || cadena[i] == 9)
                        {

                            cadena[i] = cadena[i + 1];

                        }
                        else
                        {
                            lexema = lexema + cadena[i];
                            state = 100;
                        }
                    break;
               //-----------------Estado 1----------------------------------------------------------------------
                    case 1:
                        if (Char.IsLetter(cadena[i]))
                        {
                            lexema = lexema + cadena[i];
                            state = 11;
                            
                        }
                        else if (Char.IsDigit(cadena[i]))
                        {
                            lexema = lexema + cadena[i];
                            state = 11;
                            
                        }
                        else if (cadena[i]==58)
                        {
                            lexema = lexema + cadena[i];
                            state = 4;

                        }
                        else if (cadena[i] == 32 || cadena[i] == 10 || cadena[i] == 9)
                        {
                            
                            num++;
                            arregloToken.Add(new  Datos(num,lexema,tipoT(lexema),fila,columna));
                            lexema = "";
                            state = 0;

                        }
                        else {
                            lexema = lexema + cadena[i];
                            state = 100;
                        }
                    break;
                //-----------------Estado 2----------------------------------------------------------------------
                    case 2:
                        if(Char.IsDigit(cadena[i]))
                        {
                            lexema = lexema + cadena[i];
                            state = 2;

                            
              
                        }
                        else if (cadena[i] == 32 || cadena[i] == 10 || cadena[i] == 9)
                        {

                            num++;
                            arregloToken.Add(new Datos(num, lexema, "Token_Digito", fila, columna));
                            lexema = "";
                            state = 0;

                        }
                        else
                        {
                            lexema = lexema + cadena[i];
                            state = 100;
                        }
                    break;
                //-----------------Estado 3---------------------------------------------------------------------- 
                    case 3:
                    
                        num++;
                        arregloToken.Add(new Datos(num, lexema, "Token_Simbolo", fila, columna));
                        state = 0;
                        lexema = "";
                    
                            
                            
                    break;
                //-----------------Estado 4----------------------------------------------------------------------
                    case 4:
                    if (cadena[i]==92)
                    {
                        lexema = lexema + cadena[i];
                        state = 5;

                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
                    break;
                //-----------------Estado 5---------------------------------------------------------------------- 
                    case 5:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 6;

                    }
                    else if(Char.IsDigit(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 6;
                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
                    break;
                //-----------------Estado 6----------------------------------------------------------------------
                    case 6:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 6;

                    }
                    else if (Char.IsDigit(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 6;
                    }
                    else if (cadena[i]==92)
                    {
                        lexema = lexema + cadena[i];
                        state = 7;
                    }
                    else if (cadena[i]==46)
                    {
                        lexema = lexema + cadena[i];
                        state = 8;
                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
                    break;
                //-----------------Estado 7----------------------------------------------------------------------
                    case 7:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 9;

                    }
                    else if (Char.IsDigit(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 9;
                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
                    
                    break;
                //-----------------Estado 8----------------------------------------------------------------------
                    case 8:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 10;

                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }

                    break;
                //-----------------Estado 9----------------------------------------------------------------------
                    case 9:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 9;

                    }
                    else if (Char.IsDigit(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 9;
                    }
                    else if (cadena[i] == 92)
                    {
                        lexema = lexema + cadena[i];
                        state = 7;
                    }
                    else if (cadena[i] == 46)
                    {
                        lexema = lexema + cadena[i];
                        state = 8;
                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
                    break;
                //-----------------Estado 10----------------------------------------------------------------------
                    case 10:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 10;

                    }
                    else if (cadena[i] == 32 || cadena[i] == 10 || cadena[i] == 9 || cadena[i] == 34)
                    {

                        num++;
                        arregloToken.Add(new Datos(num, lexema, "Token_Ruta", fila, columna));
                        lexema = "";
                        state = 0;

                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
                    break;
                //-----------------Estado 11----------------------------------------------------------------------
                    case 11:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 11;

                    }
                    else if (Char.IsDigit(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 11;

                    }
                    else if (cadena[i] == 32 || cadena[i] == 10 || cadena[i] == 9)
                    {

                        num++;
                        arregloToken.Add(new Datos(num, lexema, tipoT(lexema), fila, columna));
                        lexema = "";
                        state = 0;

                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
               
                    break;
          //-----------------Estado 12----------------------------------------------------------------------
                    case 12:

                    if (cadena[i] == 42)
                    {
                        lexema = lexema + cadena[i];
                        state = 13;
                    }
                    else 
                    {

                        lexema = lexema + cadena[i];
                        state = 100;
                    }



                    break;
          //-----------------Estado 13----------------------------------------------------------------------
                    case 13:

                    if (cadena[i] == 42)
                    {
                        lexema = lexema + cadena[i];
                        state = 14;
                    }
                    else
                    {

                        lexema = lexema + cadena[i];
                        state = 100;
                    }

                    break;
         //-----------------Estado 14----------------------------------------------------------------------
                    case 14:
                    
                        num++;
                        arregloToken.Add(new Datos(num, lexema, tipoT(lexema), fila, columna));
                        state = 0;
                        lexema = "";
                    
                        
                    break;
        //-----------------Estado 15----------------------------------------------------------------------
                    case 15:

                    if (cadena[i] == 42)
                    {
                        lexema = lexema + cadena[i];
                        state = 16;
                    }
                    else
                    {

                        lexema = lexema + cadena[i];
                        state = 100;
                    }

                    break;
            //-----------------Estado 16----------------------------------------------------------------------
                    case 16:

                    if (cadena[i] == 47)
                    {
                        lexema = lexema + cadena[i];
                        state = 17;
                    }
                    else
                    {

                        lexema = lexema + cadena[i];
                        state = 100;
                    }

                    break;
                 //-----------------Estado 14----------------------------------------------------------------------
                    case 17:
                    num++;
                    arregloToken.Add(new Datos(num, lexema, tipoT(lexema), fila, columna));
                    state = 0;
                    lexema = "";
                    break;
         //-----------------Estado Error----------------------------------------------------------------------
                    case 100:
                    if (cadena[i] == 32 || cadena[i] == 10 || cadena[i] == 9)
                    {

                        numerr++;
                        arregloError.Add(new Datos(numerr,lexema,fila,columna));
                        lexema = "";
                        state = 0;

                    }
                    else
                    {
                        lexema = lexema + cadena[i];
                        state = 100;
                    }
               
                    break;
                }       
            //---------------------Fin Switch---------------------------------------------------------
            
            }
            //---------------------Fin For---------------------------------------------------------
            return lexema;
        }
//-----------------------------------Metodo Crear Archivo--------------------------------------
        public void Archivo(string cod, string tr) {
            string nomA="";
            if(tr=="Simbolos"){
                nomA = "C:\\Simbolos.html";
            }
            else if(tr=="Error")
            {
                nomA = "C:\\Error.html";
            }
            TextWriter archivo = new StreamWriter(nomA);
            archivo.WriteLine(cod);
            archivo.Close();
        }

//-----------------------------------Metodo Verificar tokens--------------------------------------       
        public string tipoT(string lexema) {
            string tiptoken;
            
            switch(lexema){
                case "Configuracion":
                    tiptoken = "Token_Configuracion";
                break;

                case "configuracion":
                     tiptoken = "Token_Configuracion";
                break;

                case "Juego":
                tiptoken = "Token_Juego";
                break;

                case "Niveles":
                tiptoken = "Token_Niveles";
                break;

                case "Tiempo":
                tiptoken = "Token_Tiempo";
                break;

                case "Sonido":
                tiptoken = "Token_Sonido";
                break;

                case "Ahorcado":
                tiptoken = "Token_Ahorcado";
                break;

                case "Usuario":
                tiptoken = "Token_Usuario";
                break;

                case "Vocabulario":
                tiptoken = "Token_Vocabulario";
                break;

                case "Facil":
                tiptoken = "Token_Facil";
                break;

                case "Intermedio":
                tiptoken = "Token_Intermedio";
                break;

                case "Dificil":
                tiptoken = "Token_Dificl";
                break;

                case "Nombre":
                tiptoken = "Token_Nombre";
                break;

                case "Ruta":
                tiptoken = "Token_Ruta";
                break;

                case "Idioma":
                tiptoken = "Token_Idioma";
                break;

                case "Palabra":
                tiptoken = "Token_Palabra";
                break;

                case "Longitud":
                tiptoken = "Token_Longitud";
                break;

                case "Pista1":
                tiptoken = "Token_Pista1";
                break;

                case "Pista2":
                tiptoken = "Token_Pista2";
                break;

                case "#":
                tiptoken = "Token_#";
                break;

                case "/**":
                tiptoken = "Token_/**";
                break;

                case "**/":
                tiptoken = "Token_**/";
                break;

                case "=":
                tiptoken = "Token_=";
                break;

               // case " :
                //tiptoken = "Token_Comillas";
                //break; 

                default:
                tiptoken = "Token_texto";
                break;
            }

            return tiptoken;
        
        }

    }
}