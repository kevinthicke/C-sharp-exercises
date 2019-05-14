# Classes


### Ejercicio 1
Crear una clase _Shape_ que tenga las propiedades privadas _height_,
 _width_, _position_ y _type_. Las propiedades _height_ y _width_ deben ser 
 variables de tipo _float_. Mientras que _position_ y _type_ son tipo _Position_ y
 _ShapeType_. 

 _ShapeType_ debe ser una enumeración que contenga _circle_, _triangle_ y _rectangle_. 
 _Position_ debe ser una clase que tenga como campos las variables _x_ (distancia horizontal del origen de coordenadas)  e _y_ (distancia vertical del origen de coordenadas) de tipo _float_ 

 Debe existir además otra clase denominada _Canvas_ (lienzo, en inglés) con un m\'etodo 
 _DrawShapes_ que tenga como parámetros una lista de tipo _Shape_ e imprima por consola algo análogo a:

 ```
 Draw a circle with dimensions 1.2x2.4
 Draw a triangle with dimensions 1.3x5.6
 ...
 ```

 Construir una clase _Utils_ que tenga un método _getArea_ que tenga como parámetros una variable de tipo _shape_ y le devuelva su perímetro.