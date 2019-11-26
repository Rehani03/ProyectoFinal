# ProyectoFinal-ButterSoft
## Comenzando
Estas instrucciones permitirán el buen funcionamiento del programa. Esta ventana es la primera que veras el iniciar el programa. En ella 
deberás elegir el usuario a loguear y colocar la contraseña. En caso de que sea la primera vez que ingreses al programa tu usuario será Admin y contraseña 1234. Cabe mencionar que si es la primera vez en el programa el usuario que el sistema le presente tendra Nivel Administrador.


![Login](https://user-images.githubusercontent.com/54560358/69479993-023ff900-0dda-11ea-908f-a481dfb08c8f.JPG)

La siguiente ventana que se le mostrará será la de Menú Principal, en ella encontraras diferentes registros para que puedas comenzar a utilizar el programa. Cabe destacar que los usuarios que esten registrado con nivel Administrador son los que tendrán el acceso completo al programa, en caso de que ingreses con un usuario que este registrado con nivel de Usuario Normal, solo podrás utilizar las consultas, excepto la de Usuario y los Registro de Facturación y Clientes cabe mencionar que estos registros los podras utilizar pero no podras eliminar en ellos, solo podras hacerlo si eres usuario con nivel Administrador como ya mencionado.

![MenuPrincipal_opt](https://user-images.githubusercontent.com/54560358/69480267-6bc10700-0ddc-11ea-9e6f-3915d9795a8e.jpg)

En esta ventana como ya mencionado acceder a los siguientes registros:

## Usuario

![Usuario](https://user-images.githubusercontent.com/54560358/69480389-61ebd380-0ddd-11ea-80f9-445a439be847.JPG)

Este registro permite crear usuarios los cuales podrás darle diferentes niveles, los de nivel Administrador tendrán accedo a todo el programa mientras que los de nivel Usuario Normal solo podrán acceder a Facturación. De igual manera, todos los campos deben ser llenados para que pueda ser registrado el usuario.

## Cliente

![Cliente](https://user-images.githubusercontent.com/54560358/69480595-25b97280-0ddf-11ea-84eb-e0959753d893.JPG)

Este registro permite crear los clientes en el programa, y posee dos campos muy importantes que son consumo y visitas esos campos se irán actualizando de acuerdo al consumo del cliente y las veces que estuvo en la institución.

## Categoria

![Categoria](https://user-images.githubusercontent.com/54560358/69480791-ee4bc580-0de0-11ea-942b-8a45788052a8.JPG)


Este registro permite crear las categorías para los productos. Los campos deben ser llenados.

## Producto
![Producto](https://user-images.githubusercontent.com/54560358/69480677-1129aa00-0de0-11ea-8b86-650c1a4a9e3b.JPG)

Este registro permite crear los productos en el programa. Este también posee la opción de marcar el producto como un donativo lo cual es importante para pasar un producto como si fuera un recibo de contribución, cuando esta opción está marcada se igualan a cero el precio, costo y ganancia. El campo cantidad se ira actualizando de acuerdo con la entrada o venta que se le dé a el producto. Cabe destacar, que para registrar un producto debe haber una categoria ya registrada, y los campos que les requiera deben estar llenados. 
## Entrada de Producto

![EntradaProducto](https://user-images.githubusercontent.com/54560358/69480827-539fb680-0de1-11ea-9d82-71ba686cfc27.JPG)

Este registro permite darles entrada a los productos que se irán a vender. Solo debes elegir el nombre del producto y colocar la cantidad, cuando pulses en el botón agregar ya estarán en detalle y para hacer efectiva la acción solo necesitas pulsar el botón Guardar. Si deseas, también podrás agregar nuevos productos con el botón que está al lado de Producto.
Recuerde, que solo puedes darle entrada a un producto a la vez en el detalle. Y debes tomar en cuenta que para darle entrada a un producto este debe estar ya registrado.

## Facturación

![Factura](https://user-images.githubusercontent.com/54560358/69480979-38ce4180-0de3-11ea-9bd3-11262db9f114.JPG)

Este registro te permite crear las facturas a nombre de los clientes. Para hacerlo solo debes elegir un Cliente, y en Producto eliges el nombre del producto se te mostrara el precio en el apartado precio y colocas la cantidad y luego presionas Agregar para hacer efectiva la factura la debes Guardar.
Cabe mencionar, que solo los usuarios que esten registrados con nivel Administrador son los que podrán eliminar facturas, los usuarios con nivel Normal no podrán. Y debes tomar en cuenta que para registrar una factura debe de habe un Cliente registrado y un Producto con por lo menos 1 en cantidad.
Un detalle importante es, que cuando presionas Guardar te da la opción de imprimir la factura siempre y cuando se haya guardado correctamente.

## Consultas
Existen tres tipos de consultas que varían en su funcionamiento, las cuales son:

- Facturación:
![ConsultaFacturacion](https://user-images.githubusercontent.com/54560358/69482644-74bdd280-0df4-11ea-9cd1-87a14cbf02b4.JPG)

Esta consulta de factura te permite ver el detalle de cada factura solamente, dándole doble clic a una de las celdas de la fila. También te permite imprimir un reporte de factura. Además, puedes filtrar por fecha y por los otros campos de la factura.

- Entrada de Productos:
![ConsultaEntrada](https://user-images.githubusercontent.com/54560358/69482695-f57cce80-0df4-11ea-8d1f-555866e5535e.JPG)

Esta consulta de Entrada de Productos te permite ver el detalle de cada Entrada de Productos solamente, dándole doble clic a una de las celdas de la fila. También te permite imprimir un reporte de la Entrada de Productos. Además, puedes filtrar por fecha y por los otros campos de la Entrada de Productos.


- Categoria:



![ConsultaCategoria](https://user-images.githubusercontent.com/54560358/69483523-a2a81480-0dfe-11ea-9e33-21f0776c4c41.JPG)



Esta consulta de Categorías te permite filtrar por los campos de la categoría e imprimir un reporte de ella.
 
 - Cliente:
![ConsultaCliente](https://user-images.githubusercontent.com/54560358/69483561-3679e080-0dff-11ea-9f48-a89207f9381e.JPG)
Esta consulta es de clientes, te permite filtrar por rango de fecha y por los campos del cliente. También puedes imprimir un reporte.

## Ya terminando el Readme las otras consultas que faltan son iguales a la de cliente, cada una filtra por fecha y por los campos que posea el registro y también imprimen un reporte.

# Pre-Requisitos
Necesitan una computadora con al menos los siguientes requisitos:

## Requisitos:
 -Windows 10 64 bits.

-Procesador: Procesador Dual Core.

-Memoria RAM: 4 GigaByte (GB).

-Espacio en disco duro: 100GigaByte (GB).
 
## Construido con:
-Visual Studio 2019 

-C#

-SQL Server 2014

-Google Chrome

## Autor
Rehani Martin Cordero Tejada
