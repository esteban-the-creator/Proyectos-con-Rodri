using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountManager : MonoBehaviour

{
    int currentIndexAccounts;
    int cod;
    double valorqueResta;
    //string EstaCuenta;
    public InputField nombre;
    public InputField otroValorRetiro;
    public InputField saldoInicial;
    public InputField codigo;
    public Text titular;
    public Text saldo;
    Cuenta[] cuentasBanco = new Cuenta[10]; //anotación 1



    public void CrearCuenta()
    {
        Cuenta NuevaCuenta = new Cuenta(System.Convert.ToDouble(saldoInicial.text), nombre.text); // Anotacion 2
        cuentasBanco[currentIndexAccounts] = NuevaCuenta;
        currentIndexAccounts++;
        titular.text = NuevaCuenta.getTitular();

        string tempSaldo = NuevaCuenta.getCantidad().ToString();
        saldo.text = tempSaldo;
    }

    public void ConsultarCuenta()
    {
        cod = System.Convert.ToInt32(codigo.text);
        titular.text = cuentasBanco[cod].getTitular();
        saldo.text = cuentasBanco[cod].getCantidad().ToString();

    }

    public void Retirar()
    {
        cod = System.Convert.ToInt32(codigo.text);
        valorqueResta = System.Convert.ToDouble(otroValorRetiro.text);
        double miSaldoActual = System.Convert.ToDouble(saldoInicial.text) ;
     

        if (valorqueResta > miSaldoActual)
        {
            saldo.text = ("No tienes tanto dinero");

        }

        else
        {
            double saldoqueQueda = miSaldoActual - valorqueResta;
            cuentasBanco[cod].setCantidad(saldoqueQueda);
            saldo.text = cuentasBanco[cod].getCantidad().ToString();
        }

    }
}

/*crear un funcion con el onclick para guardar la información de la cuenta como 
  unanueva y otra funciona que muestra la información de una de las cuentas*/


/* En la siguiente línea guardo en una varibale float llamada "temporal" la conversión a flotante (Tosingle) del texto tipo string 
ingresado en el input field "saldoInicial"; la conversión se hace a través del namespace System, usando la clase convert, llamando 
el metodo ToSingle y dando en los argumentos el atributo a convertir. PD: para convertir a un double se usa ToDouble
"float temporal = System.Convert.ToSingle(saldoInicial.text);" */

/* Anotación 1:
Recordar la sintaxis de un array:
nombre del tipo de atributo o clase del que se va a hacer una array, corchetes, nombre del array igual (igualdad =) a new tipo de 
clase o atributo del que estoy haciendo un array y en los ultimos corchetes la cantidad de datos en el array */

/* Anotacion 2: 
Una solución efectiva cuando no permite usar inputfield.text (nombre.text en este caso) es usar una variable string (EstaCuenta) 
y asignarle el valor del input field, luego utilizar el setter de la cuenta instanciada (NuevaCuenta.Set())para asignarle el nombre 
que se guardó en el string "EstaCuenta", sin embargo usamos el constructor para iniciarlizar el valor */
