![imagen](https://cdn-icons-png.flaticon.com/128/6481/6481940.png)

<h1 align="center">TP 3 - Junio de 2022</h1>

# ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★

## Veterinaria **Pequeñas Patitas** ❤

> Sistema de atencion de pacientes.

> Es un nuevo dia en Pequeñas Patitas. En el primer formulario se van agregando los pacientes que llegan, en espera de ser atendidos.

> Al irse atendiendo cada paciente se le ingresa en una ficha con sus datos y se lo asigna a los paseos, si asi lo desea.

> Hay un formulario de manejo de datos donde puede guardarse y recuperarse la informacion en distintos formatos.

> Tiene un timer que cuenta el tiempo transcurrido desde que se inicio la app.

## ⭐️ Temas vistos entre la clase 10 a 15

✅ Excepciones: Se utilizan en varios lugares donde puede haber errores, en el Formulario de Atenciones y en las serializaciones a xml y a Json.

✅ Pruebas unitarias: en el metodo de ficha completa

✅ Metodos de extension, se extiende la clase DateTime agregando un mensaje personalizado segun el dia de la semana.

✅ Generics, se usa una clase paseador generica, puede aceptar solo los animales de la veterinaria.

✅ Interfaces: Para la vacunacion y para los paseos. Se crean dos interfaces IPaseable e IVacunable que solo se aplica en la clase Perro y Gato.

✅Se sobrecarga el == para saber si dos pacientes son iguales.

✅ Se sobrecarga el operador + para agregar un paciente a la lista de atencion

✅ Serializacion xml y json: Se guarda y se recupera la informacion de los pacientes desde esos dos formatos. En xml el listado de todos los pacientes de la veterinaria y en json los paseos perrunos y gatunos (porque en Pequeñas Patitas los gatos tambien pasean!).

✅ Hay tres formularios, un Form Veterinaria, que recibe pacientes y los enfila para ser atendidos. Un Form Atencion donde se atiende a los animalitos y se los ingresa en una ficha a la base de datos de la veterinaria. Y por ultimo un Form de Informacion desde donde se maneja la informacion desde y hasta los archivos.

⭐️Temas vistos entre la clase 15 a 20

✅ conexion a data base: Se envian datos sobre la vacunacion canina y felina a la base de datos de un Instituto de Zoonosis. Tambien se recupera desde esa base de datos el total de vacunas aplicadas por la Veterinaria. Se adjunta el backup de la base de datos en un archivo llamado INSTITUTOZOONOSIS.bak
✅ delegados
✅ expresiones lambda
✅ multi hilo y concurrencia
✅ eventos
