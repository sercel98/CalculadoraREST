package model;

import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;

@Path("model")
public class ServicioWebCalculadora {
    public ServicioWebCalculadora() {
        super();
    }

    @GET
    @Produces("*/*")
    @Path("sumar")
    public double sumar(@QueryParam("x") double x, @QueryParam("y") double y){
        return ServicioCalculadoraBase.sumar(x, y);
    }

    @GET
    @Produces("*/*")
    @Path("multiplicarPorKte")
    public double multiplicarPorKte(@QueryParam("z") double z){
        return ServicioCalculadoraBase.multiplicarPorKte(z);
    }

    @POST
    @Produces("*/*")
    @Path("asignarKte")
    public void asignarKte(@QueryParam("Kte") double Kte) {
        ServicioCalculadoraBase.setKte(Kte);
    }
    
    
}
