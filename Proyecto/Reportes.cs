using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    class Reportes
    {
        Analizador an=new Analizador();
        List<Datos> listok;
        List<Datos> lise;

        public void CrearRT(List<Datos> lista) { 
            listok=lista;
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
                    +"<th>Fila</th>\n"
                    +"<th>columna</th>\n"
                +"</tr>\n";



            for (int i = 0; i < listok.Count; i++)
            {
                html += "<tr>\n"
                        + "<td>" + ((Datos)listok[i]).getNumero() + "</td>\n"
                        + "<td>" + ((Datos)listok[i]).getLexi() + "</td>\n"
                        + "<td>" + ((Datos)listok[i]).getToken() + "</td>\n"
                        + "<td>" + ((Datos)listok[i]).getFila() + "</td>\n"
                        + "<td>" + ((Datos)listok[i]).getColum() + "</td>\n"
                    + "</tr>\n";
               
            }
                
            html+="</table>\n "
                + "</body>\n "
                + "</html>";
           
            MessageBox.Show("Archivo Creado");
            an.Archivo(html, "Simbolos");
        }


        public void CrearRE(List<Datos> lista)
        {
            lise = lista;
            String html2 = "<html>\n"
                 + "<head>\n"
                + "<style type=\"text/css\">\n" //_____________________________style de css__________________________________________
                + "table {\n" +
                "	font-family: verdana,arial,sans-serif;\n" +
                "	font-size:11px;\n" +
                "	color:#333333;\n" +
                "	border-width: 1px;\n" +
                "	border-color: #666666;\n" +
                "	border-collapse: collapse;\n" +
                "	width: 100%;\n" +
                "}\n"
                + " th {\n" +
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
                + "</style>\n"
                + "<meta charset=\"UTF-8\">\n"
                + "<title>Reporte Errores</title>\n"
                + "</head\n>"
                + "<body background=\"\\Reportes\\r3.jpg\">"
                + "<font color=\"Olive\" face=\"Comic Sans MS,arial\">"
                + "<h3>Lista de Errores</h3>"
                + "</font>"
                + "<table>\n"
                + "<tr>\n"
                    + "<th>No.</th>\n"
                    + "<th>Lexema</th>\n"
                    + "<th>Fila</th>\n"
                    + "<th>columna</th>\n"
                    + "<th>Error</th>\n"
                + "</tr>\n";



            for (int i = 0; i < lise.Count; i++)
            {
                html2 += "<tr>\n"
                        + "<td>" + ((Datos)lise[i]).getNumero() + "</td>\n"
                        + "<td>" + ((Datos)lise[i]).getError() + "</td>\n"
                        + "<td>" + ((Datos)lise[i]).getFila() + "</td>\n"
                        + "<td>" + ((Datos)lise[i]).getColum() + "</td>\n"
                        + "<td>" + ((Datos)lise[i]).getTerror() + "</td>\n"
                    + "</tr>\n";

            }

            html2 += "</table>\n "
                + "</body>\n "
                + "</html>";

            MessageBox.Show("Archivo Creado");
            an.Archivo(html2, "Error");
        }


    }
 }

