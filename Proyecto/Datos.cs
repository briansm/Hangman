using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto
{
    class Datos
    {
        int numero;
        int fila = 1;
        int columna;

        string lexi;
        string error;
        string token;
        string Terror = "Error Lexico, TOken No reconocido";
           

            public  void datosToken(int num,string lexe,string tokn, int f, int c){
                this.numero = num;
                this.lexi = lexe;
                this.token = tokn;
                this.fila = f;
                this.columna = c;
            }
            public void datosError(int num, string error, int f, int c)
            {
                this.numero = num;
                this.error = error;
                this.fila = f;
                this.columna = c;
                string tipe = this.Terror;
            }

//-------------------Getters y setter------------------------------------------
            public int getNumero() {
                return numero;   
            }
            public void setNumero(int nume) {
                this.numero = nume;
            }

            public int getFila()
            {
                return fila;
            }
            public void setFila(int fila)
            {
                this.fila = fila;
            }

            public int getColum()
            {
                return columna;
            }
            public void setColum(int colum)
            {
                this.columna = colum;
            }

            public string getLexi()
            {
                return lexi;
            }
            public void setLexi(string lexi)
            {
                this.lexi = lexi;
            }

            public string getToken()
            {
                return token;
            }
            public void setToken(string  token)
            {
                this.token = token;
            }

            public string getError()
            {
                return error;
            }
            public void setError(string error)
            {
                this.error = error;
            }

            public string getTerror()
            {
                return Terror;
            }
            public void setTerror(string terror)
            {
                this.Terror = terror;
            }
    }
}
