using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Proyecto
{
    class Analizador
    {
        int state = 0;
        string lexema = "";
//------------------------------Metodo analizar-------------------------------------
        public string lexico(string entrada)
        {

            string texto = entrada;
            Char[] cadena = texto.ToCharArray();
            for (int i = 0; i < cadena.Length; i++)
            {
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
                        else if (cadena[i] == 42 || cadena[i] == 47 || cadena[i] == 66 || cadena[i] == 67)
                        {
                            lexema = lexema + cadena[i];
                            state = 3;
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
                    break;
                //-----------------Estado 2----------------------------------------------------------------------
                    case 2:
                        if(Char.IsDigit(cadena[i]))
                        {
                            lexema = lexema + cadena[i];
                            state = 2;
              
                        }
                    break;
                //-----------------Estado 3---------------------------------------------------------------------- 
                    case 3:
                    
                    break;
                //-----------------Estado 4----------------------------------------------------------------------
                    case 4:
                    if (cadena[i]==92)
                    {
                        lexema = lexema + cadena[i];
                        state = 5;

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
                    
                    break;
                //-----------------Estado 8----------------------------------------------------------------------
                    case 8:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 10;

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
                    break;
                //-----------------Estado 10----------------------------------------------------------------------
                    case 10:
                    if (Char.IsLetter(cadena[i]))
                    {
                        lexema = lexema + cadena[i];
                        state = 10;

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
               
                    break;
                }       
            //---------------------Fin Switch---------------------------------------------------------
            
            }
            //---------------------Fin For---------------------------------------------------------
            return lexema;
        }
//-----------------------------------Metodo Crear Archivo--------------------------------------
        public void Archivo() {
            TextWriter archivo = new StreamWriter("Simbolos.html");
            String html = "<html>\n"
                 +"<head>\n"
                +"<style type=\"text/css\">\n" //_____________________________style de css__________________________________________
                +"table {\n" +
                "	font-family: verdana,arial,sans-serif;\n" +
                "	font-size:11px;\n" +
                "	color:#333333;\n" +
                "	border-width: 1px;\n" +
                "	border-color: #666666;\n" +
                "	border-collapse: collapse;\n" +
                "	width: 100%;\n" +
                "}\n"
                +" th {\n" +
                "	border-width: 1px;\n" +
                "	padding: 8px;\n" +
                "	border-style: solid;\n" +
                "	background-color: #1DFF50;\n" +
                "	color: white;\n" +
                "}\n" +
                " td {\n" +
                "	border-width: 1px;\n" +
                "	padding: 8px;\n" +
                "	border-style: solid;\n" +
                "	border-color: #666666;\n" +
                "	background-color: #ffffff;\n" +
                "}\n" +
                " tr:nth-child(even){background-color: #f2f2f2}\n"
                +"</style>\n"
                +"<meta charset=\"UTF-8\">\n"
                +"<title>Reporte tokens</title>\n"
                +"</head\n>"
                +"<body background=\"\\Reportes\\r3.jpg\">"
                +"<font color=\"Olive\" face=\"Comic Sans MS,arial\">"
                +"<h3>Lista de tokens</h3>"
                +"</font>"
                +"<table>\n"
                +"<tr>\n"
                    +"<th>No.</th>\n"
                    +"<th>Lexema</th>\n"
                    +"<th>Componente léxico</th>\n"
                    +"<th>No. línea</th>\n"
                    +"<th>No. columna</th>\n"
                +"</tr>\n";
                
            
               
                    html+="<tr>\n"
                            +"<td>"+"Simbolo1"+"</td>\n"
                            +"<td>"+"Simbolo2"+"</td>\n"
                            +"<td>"+"1"+"</td>\n"
                            +"<td>"+"2"+"</td>\n"
                            +"<td>"+"3"+"</td>\n"
                        +"</tr>\n";
//                    System.out.println(html);
              
                
            html+="</table>\n "
                + "</body>\n "
                + "</html>";
            archivo.WriteLine(html);
            archivo.Close();
            MessageBox.Show("Archivo Creado");
        }

    }
}