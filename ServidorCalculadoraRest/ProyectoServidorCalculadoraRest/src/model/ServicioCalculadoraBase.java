package model;

public class ServicioCalculadoraBase {
    public static double Kte;
    
    public ServicioCalculadoraBase() {
        super();
    }
    
    public static double sumar(double x, double y){
        return x+y;
    }
    
    public static double multiplicarPorKte(double z){
        return z * Kte;
    }
    


    public static void setKte(double Kte) {
        ServicioCalculadoraBase.Kte = Kte;
    }

    public static double getKte() {
        return Kte;
    }
}
