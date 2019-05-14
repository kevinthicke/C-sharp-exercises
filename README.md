﻿# Classes


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
### Ejercicio 2

Modificar el ejercicio 1 eliminando la enumeración ShapeTypes y crear dos clases hijas de _Shape_: _Circle_ y _Rectángle_. Añadir un método _Draw()_ en la clase _Shape_ y sus hijas que muestre por consola:
 ```
 Draw a circle with dimensions 1.2x2.4
 Draw a triangle with dimensions 1.3x5.6
 ...
 ```
 Modificar el método _DrawShapes_ de la clase _Canvas_ para que llame a cada uno de los métodos _Draw()_ de shape y de sus clases hija.
