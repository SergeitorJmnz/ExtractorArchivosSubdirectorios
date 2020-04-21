# Extractor de archivos de un directorio con múltiples subdirectorios

*__Este programa extrae todos los archivos que esten dentro de un directorio y sus respectivos subdirectorios.__*


En diversas ocasiones, para saber la cantidad de archivos que tiene un directorio en el que hay gran cantidad de subdirectorios 
y donde cada uno tiene unos cuantos de dichos archivos, en windows solemos listar el contenido de la carpeta raíz con 
```
dir /b /s lista.txt
```
o con
```
dir /b /s lista.csv
```
para ver el nombre de todos los archivos y su ruta.

Como la labor de ir extrayendo uno a uno dichos archivos es bastante tediosa, he creado esta sencilla aplicación que la realiza 
automáticamente, haciendo de esta manera que una tarea que podría llevarnos hasta horas (en caso de que la cantidad de archivos 
a extraer sea extensa), se realice en pocos minutos.



El código está en Visual Basic .Net y es bastante sencillo, puesto que lo realicé en poco tiempo ya que era necesario y urgente 
para mi trabajo en ese momento.

Si quieres modificar el código, descarga la carpeta y el archivo que aparecen en la carpeta raíz del repositorio, abre Visual Studio e 
importa el archivo [CopyFilesApp.sln](https://github.com/SergeitorJmnz/ExtractorArchivosSubdirectorios/CopyFilesApp.sln).

Tiene muchas cosas por optimizar, por lo que si estás interesado en él y crees poder perfeccionarlo, sientete libre de hacerlo,
incluso si me lo comunicas me haces un gran favor puesto que me ayudas a mejorar y aprender :)

Si por el contrario, lo que deseas es usar la aplicación sin más, simplemente descarga el archivo [CopyFilesApp.exe](https://github.com/SergeitorJmnz/ExtractorArchivosSubdirectorios/tree/master/CopyFilesApp/bin/Debug/CopyFilesApp.exe) 
y sigue las instrucciones que aparecen en pantalla.

Para más información visita la [Wiki](https://github.com/SergeitorJmnz/ExtractorArchivosSubdirectorios/wiki).
