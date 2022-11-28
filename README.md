## 📦 Empresa PUNTA NORTE 🚛


### Descripción

Es un sistema informatico para ser utilizado por la compañia "PUNTA NORTE", que tiene su sede en Puerto Madrin, provincia de Chubut, y se utiliza para controlar los servicios de transporte que presta a ciudades de la provincia de Buenos Aires, centro y sur de Córdoba, Chubut y Mendoza.

Para que PUNTA NORTE pueda desarrollar sus actividades normalmente, el programa cuenta con la seleccion de tres tipos de vehículos: furgonetas, dos tamaños distintos de pickups (tipo B1 y B2) y tres tipos de camiones: livianos, medianos y semiremolques. Como norma, la empresa puede seleccionar el tipo de vehículo a utilizar en cada caso. Si por algun motivo el cliente requiere utilizar un vehiculo de otro porte, el sistema permitira seleccionar otro tipo de vehiculo, pero siendo este uno de mayor tamaño (nunca uno menor), pudiendo asi, satisfacer a los requerimientos del cliente.

El sistema cuenta con un modulo de facturación que contiene información sobre cada viaje, con los siguientes datos:

-	Código de servicio
-	Fecha del servicio
-	Código de cliente
-	Localidad de origen del servicio
-	Localidad de destino del servicio
-	Vehículo
-	Kilometraje recorrido
-	Cantidad de tramos desde origen a destino

Y también contiene información sobre los clientes:

-	Código
-	Razón social
-	Tipo de cliente (comercial, industrial u gubernamental)
-	Localidad de residencia
-	Porcentaje de descuento que se le otorga sobre los precios establecidos

Dentro del sistema, tienen otra tabla que relaciona cada localidad con la provincia donde se encuentra y con la ciudad más cercana dentro de la misma provincia.


### Casos de uso

![](https://github.com/PA2-UNLaM/PA2-2022-2C-WebAppMVC/blob/master/Casos%20de%20Uso.png)
    
| N°  | Como    | Quiero                   | Para                           |
|:---:|:-------:|:-------------------------:|:-----------------------------:|
| 01 | Usuario | Cotizar viaje | Saber el costo de un viaje |
| 02 | Usuario | Crear viaje | Agregar un nuevo viaje |
| 03 | Usuario | Consultar viaje | Saber los datos de un viaje |
| 04 | Usuario | Modificar viaje | Cambiar datos de un viaje |
| 05 | Usuario | Borra viaje | Eliminar un viaje |
|  | |  |  |
| 06 | Usuario | Crear provincia |  Agregar una nueva provincia |
| 07 | Usuario | Modificar provincia | Cambiar datos de una provincia |
| 08 | Usuario | Consultar provincia | Saber los datos de una provincia |
| 09 | Usuario | Borra provincia | Eliminar una provincia |
|  | |  |  |
| 10 | Usuario | Crear localidad |  Agregar una nueva localidad |
| 11 | Usuario | Modificar localidad | Cambiar datos de una localidad |
| 12 | Usuario | Consultar localidad | Saber los datos de una localidad |
| 13 | Usuario | Borrar localidad | Eliminar una localidad |
|  | |  |  |
| <s>14</s> | <s>Usuario</s> |<s>Crear ciudad</s> | <s>Agregar una nueva ciudad</s> |
|<s> 15</s>|<s>Usuario</s>|<s>Modificar ciudad</s>|<s>Cambiar datos de una ciudad</s>|
|<s>16</s>|<s>Usuario</s>|<s>Consultar ciudad</s>|<s>Saber los datos de una ciudad</s>|
|<s>17</s>|<s>Usuario</s>|<s>Borra ciudad</s>|<s>Eliminar una ciudad</s>|

> *Nota:* --> <s>Deuda Tecnica.</s> Desarrollo incompleto, faltante o deseable.


### Criterio de Aceptación

| Criterio n° | Contexto | Evento | Resultado |
|:-----------:|:-----------:|:--------:|:-----------:|
|  | |  |  |
| 01 | El usuario quiere cotizar un nuevo viaje  | Se dirige a *Cotizar Viaje*, se selecciona de la lista *ProvinciaOrigen* la provincia y se hace clic en el boton *SetLocalidadOrigen*, luego se selecciona de la lista *Origen* la localidad y se hace clic en el boton *SetLocalidadOrigen*, luego se selecciona *Cliente*, se selecciona *Vehiculo*, se selecciona *Destino*, se selecciona *Km*,  se selecciona *CantViajes*. <s>Se hace clic en *Cotizar*</s>| Se visualiza calculo sobre un nuevo registro del sistema |
| 02 | El usuario quiere crear un nuevo viaje  | <s> Se dirige a *Viajes*, luego</s> se hace clic en *Create new* se selecciona de la lista *ProvinciaOrigen* la provincia y se hace clic en el boton *SetLocalidadOrigen*, luego se selecciona de la lista *Origen* la localidad y se hace clic en el boton *SetLocalidadOrigen*, luego se selecciona *Cliente*, se selecciona *Vehiculo*, se selecciona *Destino*, se selecciona *Km*,  se selecciona *CantViajes*. Se hace clic en *Create*| Se registra la nueva alta en el sistema |
| 03 | El usuario quiere consultar un viaje | <s> Se dirige a *Viajes*, luego</s> se hace clic en *Details* y se muestra el campo con la información  | Se observa informacion del registro del sistema |
| 04 | El usuario quiere modificar un viaje | <s> Se dirige a *Viajes*, luego</s> se permite modificar los campos *Origen*, *Cliente*, *Vehiculo*, *Destino*, *Km* y *CantViajes*. | Se registran los cambios en el sistema |
| 05 | El usuario quiere borrar un viaje |  <s> Se dirige a *Viajes*, luego</s> se hace clic en *Delete*  y se confirma haciendo clic en el boton *Delete*   | Se borra el registro del sistema |
|  | |  |  |
| 06 | El usuario quiere crear una nueva provincia | Se dirige a *Provincias*, luego se hace clic en *Create new* y se completa el campo *NomProvincia*. Se hace clic en *Create* | Se registra la nueva alta en el sistema |
| 07 | El usuario quiere modificar una provincia | Se dirige a *Provincias*, luego se hace clic en *Edit* y se modifica el campo. Se hace clic en *Save* | Se registran los cambios en el sistema |
| 08 | El usuario quiere consultar una provincia | Se dirige a *Provincias*, luego se hace clic en *Details* y se muestra el campo con la información | Se observa informacion del registro del sistema |
| 09 | El usuario quiere borrar una provincia | Se dirige a *Provincias*, luego se hace clic en *Delete*  y se confirma haciendo clic en el boton *Delete*  | Se borra el registro del sistema |
|  | |  |  |
| 10 | El usuario quiere crear una nueva localidad |<s> Se dirige a *Localidades*, luego </s> Se hace clic en *Create new* y se selecciona de la lista la *Provincia*, luego se completan los campos *NomLoc*, se selecciona la *Ciudad* y se completa el campo *NomCiudad* . Se hace clic en *Create* | Se registra la nueva alta en el sistema|
| 11 | El usuario quiere modificar una localidad |<s> Se dirige a *Localidades*, luego </s>  Se hace clic en *Edit* y se modifica el campo *NomLoc*  (si es requerido, se modifica el campo *NomProvincia* y el campo *NomCiudad*). Se hace clic en *Save* | Se registran los cambios en el sistema |
| 12 | El usuario quiere consultar una localidad |<s> Se dirige a *Localidades*, luego </s>  Se hace clic en *Details* y se muestra el campo con la información | Se observa información del registro del sistema |
| 13 | El usuario quiere borrar una localidad |<s> Se dirige a *Localidades*, luego </s> Se hace clic en *Delete*  y se confirma haciendo clic en el boton *Delete*  | Se borra el registro del sistema |
|  | |  |  |
|<s>14| <s>El usuario quiere crear una nueva ciudad |<s>X |<s>X|
|<s>15| <s>El usuario quiere modificar una ciudad |<s>X |<s>X|
|<s>16|<s>El usuario quiere consultar una ciudad |<s>X |<s>X|
|<s>17 |<s>El usuario quiere borrar una ciudad |<s>X |<s>X|

> *Nota:* --> <s>Deuda Tecnica.</s> Desarrollo incompleto, falta o deseable.
    
    
                                                                                                       // Jorge A. Alonso (PA2-2022-2C)
