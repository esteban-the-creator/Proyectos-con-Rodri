using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuenta 

{

    string titular;
    double cantidad;

    public Cuenta(double _cantidad, string _titular)
    {
        this.cantidad = _cantidad;
        this.titular = _titular;
    }

    public Cuenta(string _titular)
    {
        this.titular = _titular;
    }

    /* 2 construct que cumpla con lo anterior, crear los métodos get, set y to string 
     * 2 métodos epeciales "saldoInicial" será un double cantidad :::se ingresa una cantidad a la cuenta , si la cantidad introducida es negativa no se hara nada 
     * "retirar" (double cantidad) se retira una cantidad a la cuenta, si restando la cantidd actual a la que nos pasan es negativa, la cantidad de la cuenta pasa aa ser 0*/


    public void Ingresar()
    {


    }

    public void Retirar()
    {

    }


    // a partir de este bloque se crean las funciones de instancia get y set para los dos atributos

    public void setCantidad(double _cantidad)
    {
        this.cantidad = _cantidad;
    }

    public double getCantidad()
    {
        return this.cantidad;
    }

    public void setTitular(string _titular)
    {
        this.titular = _titular;
    }

    public string getTitular()
    {
        return this.titular;
    }


}