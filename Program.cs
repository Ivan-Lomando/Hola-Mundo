class producto {
    string nombre;
    int precio;
    List<string> review;
public producto (string nombre, int precio, List<string> review) {
        
            this.nombre = nombre;
        
            this.precio = precio;

            this.review = review;
}
public override string ToString(){
        {
             return $" el nombre es:{this.nombre} el precio es {this.precio} y las valoraciones {this.review}";
        }   

        }



public void agregarreview(review){




}

}

class review {

int clasificacion;

string comentarios;

public review ( int clasificacion, string comentarios) {
        
this.clasificacion = clasificacion;
this.comentarios = comentarios;

}
}